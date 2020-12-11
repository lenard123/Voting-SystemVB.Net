Imports System.Data.OleDb

Public Class Election

    Private Shared CurrentElection As Election

    Private _Id, _Status As Integer
    Private _Title As String
    Private _Started, _Ended As DateTime

    Public Sub New(Id As Integer, Status As Integer, Started As DateTime, Ended As DateTime)
        Me._Id = Id
        Me._Status = Status
        Me._Started = Started
        Me._Ended = Ended
    End Sub

    Public Shared Function HasNotStarted() As Boolean
        Return CurrentElection._Status = Status.NOT_STARTED
    End Function
    Public Shared Function IsOngoing() As Boolean
        Return CurrentElection._Status = Status.ONGOING And Date.Now() < CurrentElection.Ended
    End Function
    Public Shared Function HasEnded() As Boolean
        Return CurrentElection._Status = Status.ENDED Or Date.Now() > CurrentElection.Ended
    End Function

    Public ReadOnly Property Id As Integer
        Get
            Return _Id
        End Get
    End Property
    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
        End Set
    End Property
    Public ReadOnly Property Started As DateTime
        Get
            Return _Started
        End Get
    End Property
    Public ReadOnly Property Ended As DateTime
        Get
            Return _Ended
        End Get
    End Property

    ''' <summary>
    ''' Count all Elections
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CountAll() As Integer
        Dim Count = 0
        Using Cmd = New OleDbCommand(QUERY_COUNT_ALL, GetConnection())
            GetConnection().Open()
            Count = Integer.Parse(Cmd.ExecuteScalar())
            GetConnection().Close()
        End Using
        Return Count
    End Function

    ''' <summary>
    ''' Get The Image Directory of Current Election
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetImageDirectory() As String
        Return "election-" & CurrentElection.Id
    End Function

    ''' <summary>
    ''' Refresh the status Current Election
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCurrentElectionRefresh() As Election
        CurrentElection = Nothing
        Return GetCurrentElection()
    End Function

    ''' <summary>
    ''' Get the current election
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCurrentElection() As Election
        If IsNothing(CurrentElection) Then
            Using Cmd = New OleDbCommand(QUERY_CURRENT_ELECTION, GetConnection())
                GetConnection().Open()
                Using Reader = Cmd.ExecuteReader()
                    If Reader.Read Then
                        CurrentElection = GetElection(Reader)
                    End If
                End Using
                GetConnection().Close()
            End Using
        End If
        Return CurrentElection
    End Function

    ''' <summary>
    ''' Start the current election
    ''' </summary>
    ''' <param name="Title"></param>
    ''' <param name="EndDate"></param>
    ''' <remarks></remarks>
    Public Shared Sub StartElection(Title As String, EndDate As Date)

        If Not HasNotStarted() Then Throw New ElectionAlreadyStartedException

        If Not Admin.GetCurrentUser().CanStartElection() Then Throw New InvalidPrivilegeException

        Using Cmd = New OleDbCommand(QUERY_START_ELECTION, GetConnection())
            BindParameters(Cmd, Title, Status.ONGOING, Date.Now(), EndDate, CurrentElection.Id)
            GetConnection().Open()
            Cmd.ExecuteNonQuery()
            GetConnection().Close()
        End Using

        GetCurrentElectionRefresh()
    End Sub

    ''' <summary>
    ''' Convert Reader into Election Model
    ''' </summary>
    ''' <param name="Reader"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function GetElection(ByRef Reader As OleDbDataReader) As Election
        Dim Id = Reader.GetInt32(INDEX_ID)
        Dim Status = Reader.GetInt16(INDEX_STATUS)
        Dim Title As String = Nothing
        Dim Started As DateTime = Nothing
        Dim Ended As DateTime = Nothing

        If (Not Reader.IsDBNull(INDEX_TITLE)) Then Title = Reader.GetString(INDEX_TITLE)
        If (Not Reader.IsDBNull(INDEX_STARTED)) Then Started = Reader.GetDateTime(INDEX_STARTED)
        If (Not Reader.IsDBNull(INDEX_ENDED)) Then Ended = Reader.GetDateTime(INDEX_ENDED)

        Dim Result As Election = New Election(Id, Status, Started, Ended)
        Result.Title = Title
        Return Result
    End Function

    '
    ' CONSTANT PROPERTIES
    '

    Enum Status
        NOT_STARTED = 0
        ONGOING = 1
        ENDED = 2
    End Enum

    Private Const QUERY_START_ELECTION = "UPDATE [Election] SET [Title]=?, [Status]=?, [Started]=?, [Ended]=? WHERE [ID]=?"
    Private Const QUERY_CURRENT_ELECTION = "SELECT TOP 1 * FROM Election ORDER BY ID DESC;"
    Private Const QUERY_COUNT_ALL = "SELECT COUNT(*) FROM [ELECTION]"

    Private Const INDEX_ID = 0
    Private Const INDEX_TITLE = 1
    Private Const INDEX_STATUS = 2
    Private Const INDEX_STARTED = 3
    Private Const INDEX_ENDED = 4


End Class
