Imports System.Data.OleDb

Public Class Election

    Private Shared ReadOnly QUERY_START_ELECTION = "UPDATE [Election] SET [Title]=?, [Status]=?, [Started]=?, [Ended]=? WHERE [ID]=?"

    Public Shared ReadOnly STATUS_NOT_STARTED = 0
    Public Shared ReadOnly STATUS_ONGOING = 1
    Public Shared ReadOnly STATUS_ENDED = 2

    Private Shared ReadOnly LENGTH_ID = 10
    Private Shared ReadOnly LENGTH_TITLE = 60
    Private Shared ReadOnly LENGTH_STATUS = 1
    Private Shared ReadOnly LENGTH_STARTED = 255
    Private Shared ReadOnly LENGTH_ENDED = 255


    Private Shared ReadOnly INDEX_ID = 0
    Private Shared ReadOnly INDEX_TITLE = 1
    Private Shared ReadOnly INDEX_STATUS = 2
    Private Shared ReadOnly INDEX_STARTED = 3
    Private Shared ReadOnly INDEX_ENDED = 4

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

    Public Shared ReadOnly Property HasNotStarted As Boolean
        Get
            Return CurrentElection.Status = STATUS_NOT_STARTED
        End Get
    End Property
    Public Shared ReadOnly Property IsOngoing As Boolean
        Get
            Return CurrentElection.Status = STATUS_ONGOING
        End Get
    End Property
    Public Shared ReadOnly Property HasEnded As Boolean
        Get
            Return CurrentElection.Status = STATUS_ENDED
        End Get
    End Property

    Public ReadOnly Property Id As Integer
        Get
            Return _Id
        End Get
    End Property
    Public ReadOnly Property Status As Integer
        Get
            Return _Status
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

    Public Shared ReadOnly Property ImageDirectory As String
        Get
            Return "election-" & CurrentElection.Id
        End Get
    End Property

    Public Shared Function GetCurrentElectionF() As Election
        CurrentElection = Nothing
        Return GetCurrentElection()
    End Function
    Public Shared Function GetCurrentElection() As Election
        If IsNothing(CurrentElection) Then
            GetConnection.Open()
            Dim Cmd As New OleDbCommand("SELECT TOP 1 * FROM Election ORDER BY ID DESC;", GetConnection())
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

    Public Shared Function StartElection(Title As String, EndDate As Date) As Boolean
        If HasNotStarted Then
            Console.WriteLine(EndDate)
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

    Private Shared Function GetElection(ByRef Reader As OleDbDataReader) As Election
        Dim Id = Reader.GetInt32(INDEX_ID)
        Dim Status = Reader.GetInt16(INDEX_STATUS)
        Dim Title As String = Nothing
        If (Not Reader.IsDBNull(INDEX_TITLE)) Then Title = Reader.GetString(INDEX_TITLE)
        Dim Started As DateTime = Nothing
        If (Not Reader.IsDBNull(INDEX_STARTED)) Then Started = Reader.GetDateTime(INDEX_STARTED)
        Dim Ended As DateTime = Nothing
        If (Not Reader.IsDBNull(INDEX_ENDED)) Then Ended = Reader.GetDateTime(INDEX_ENDED)
        Dim Result As Election = New Election(Id, Status, Started, Ended)
        Result.Title = Title
        Return Result
    End Function


End Class
