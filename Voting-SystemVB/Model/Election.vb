Imports System.Data.OleDb

Public Class Election

    Private Const QUERY_START_ELECTION = "UPDATE [Election] SET [Title]=?, [Status]=?, [Started]=?, [Ended]=? WHERE [ID]=?"
    Private Const QUERY_CURRENT_ELECTION = "SELECT TOP 1 * FROM Election ORDER BY ID DESC;"
    Private Const QUERY_COUNT_ALL = "SELECT COUNT(*) FROM [ELECTION]"

    Public Const STATUS_NOT_STARTED = 0
    Public Const STATUS_ONGOING = 1
    Public Const STATUS_ENDED = 2

    Private Const LENGTH_ID = 10
    Private Const LENGTH_TITLE = 60
    Private Const LENGTH_STATUS = 1
    Private Const LENGTH_STARTED = 255
    Private Const LENGTH_ENDED = 255


    Private Const INDEX_ID = 0
    Private Const INDEX_TITLE = 1
    Private Const INDEX_STATUS = 2
    Private Const INDEX_STARTED = 3
    Private Const INDEX_ENDED = 4

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
        Return CurrentElection._Status = STATUS_NOT_STARTED
    End Function
    Public Shared Function IsOngoing() As Boolean
        Return CurrentElection._Status = STATUS_ONGOING And Date.Now() < CurrentElection.Ended
    End Function
    Public Shared Function HasEnded() As Boolean
        Return CurrentElection._Status = STATUS_ENDED Or Date.Now() > CurrentElection.Ended
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

    'Count all Elections
    Public Shared Function CountAll() As Integer
        Dim Count = 0
        GetConnection().Open()
        Using Cmd = New OleDbCommand(QUERY_COUNT_ALL, GetConnection())
            Count = Integer.Parse(Cmd.ExecuteScalar())
        End Using
        GetConnection().Close()
        Return Count
    End Function

    'Get The Image Directory of Current Election
    Public Shared Function GetImageDirectory() As String
        Return "election-" & CurrentElection.Id
    End Function

    'Refresh the status Current Election
    Public Shared Function GetCurrentElectionF() As Election
        CurrentElection = Nothing
        Return GetCurrentElection()
    End Function

    'Get the current election
    Public Shared Function GetCurrentElection() As Election
        If IsNothing(CurrentElection) Then
            GetConnection.Open()
            Dim Cmd As New OleDbCommand(QUERY_CURRENT_ELECTION, GetConnection())
            Dim Reader = Cmd.ExecuteReader()
            If Reader.Read() Then
                CurrentElection = GetElection(Reader)
            End If
            Reader.Close()
            Cmd.Dispose()
            GetConnection.Close()
        End If
        Return CurrentElection
    End Function

    'Start the current election
    Public Shared Function StartElection(Title As String, EndDate As Date) As Boolean
        If HasNotStarted() Then
            Dim Result = False
            GetConnection().Open()
            Using Cmd = New OleDbCommand(QUERY_START_ELECTION, GetConnection())
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Title, LENGTH_TITLE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, STATUS_ONGOING, LENGTH_STATUS))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.Date, Date.Now(), LENGTH_STARTED))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.Date, EndDate, LENGTH_ENDED))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, CurrentElection.Id, LENGTH_ID))
                Cmd.Prepare()
                If Cmd.ExecuteNonQuery() <> -1 Then
                    Result = True
                End If
            End Using
            GetConnection().Close()
            Return Result
        End If
        Return False
    End Function

    'Convert Reader into Election Model
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


End Class
