
Imports System.Data.OleDb

Public Class Candidate

    Private Shared ReadOnly INDEX_ID = 0
    Private Shared ReadOnly INDEX_STUDENT_ID = 1
    Private Shared ReadOnly INDEX_TAGLINE = 2
    Private Shared ReadOnly INDEX_POSITION_ID = 3
    Private Shared ReadOnly INDEX_IMAGE = 4
    Private Shared ReadOnly INDEX_GENDER = 5
    Private Shared ReadOnly INDEX_FULLNAME = 6
    Private Shared ReadOnly INDEX_YEAR = 7
    Private Shared ReadOnly INDEX_COURSE = 8
    Private Shared ReadOnly INDEX_PARTY = 9
    Private Shared ReadOnly INDEX_PARTY_IMAGE = 10
    Private Shared ReadOnly INDEX_PARTY_DESCRIPTION = 11
    Private Shared ReadOnly INDEX_PARTY_ID = 12

    Private _ID, _StudentID, _PositionID, _PartyID As Integer
    Private _Tagline, _Image, _Gender, _Fullname, _Course, _Year, _Party, _PartyImage, _PartyDesc As String

    Private Shared Cached As List(Of Candidate) = Nothing
    Private Shared NeedRefresh As Boolean = True

    Public Sub New(ID As Integer, StudentID As Integer, Fullname As String, YearLevel As String, Course As String, Party As String, PartyImage As String, PartyDesc As String, PartyID As Integer)
        Me._ID = ID
        Me._StudentID = StudentID
        Me._Fullname = Fullname
        Me._Year = YearLevel
        Me._Course = Course
        Me._Party = Party
        Me._PartyImage = PartyImage
        Me._PartyDesc = PartyDesc
        Me._PartyID = PartyID
    End Sub

    Public ReadOnly Property PartyID As Integer
        Get
            Return _PartyID
        End Get
    End Property

    Public ReadOnly Property Year As String
        Get
            Return _Year
        End Get
    End Property

    Public Property PositionID As Integer
        Get
            Return _PositionID
        End Get
        Set(value As Integer)
            _PositionID = value
        End Set
    End Property

    Public ReadOnly Property Course As String
        Get
            Return _Course
        End Get
    End Property

    Public ReadOnly Property CandidatePosition As String
        Get
            Select Case PositionID
                Case Position.PRESIDENT_ID
                    Return "President"
                Case Position.VICE_PRESIDENT_ID
                    Return "Vice President"
                Case Position.SECRETARY_ID
                    Return "Secretary"
                Case Position.TREASURER_ID
                    Return "Treasurer"
                Case Position.AUDITOR_ID
                    Return "Auditor"
                Case Position.PRO_ID
                    Return "P.R.O."
            End Select
            Return "(Invalid Position)"
        End Get
    End Property

    Public ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property

    Public Property Tagline As String
        Get
            Return _Tagline
        End Get
        Set(value As String)
            _Tagline = value
        End Set
    End Property

    Public Property Image As String
        Get
            Return _Image
        End Get
        Set(value As String)
            _Image = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _Gender
        End Get
        Set(value As String)
            _Gender = value
        End Set
    End Property

    Public ReadOnly Property Party As String
        Get
            Return _Party
        End Get
    End Property

    Public ReadOnly Property Fullname As String
        Get
            Return _Fullname
        End Get
    End Property

    Public Shared Function GetAllF() As List(Of Candidate)
        NeedRefresh = True
        Return GetAll()
    End Function

    Public Shared Function GetAll() As List(Of Candidate)
        If IsNothing(Cached) Or NeedRefresh Then
            Dim Result As New List(Of Candidate)
            Dim Query = "SELECT * FROM [CandidateQuery]"
            GetConnection().Open()
            Using Cmd As New OleDbCommand(Query, GetConnection())
                Using Reader = Cmd.ExecuteReader()
                    While Reader.Read()
                        Result.Add(GetCandidate(Reader))
                    End While
                End Using
            End Using
            Cached = Result
            GetConnection().Close()
        End If
        Return Cached
    End Function

    Public Shared Function GetAllByPartyID(PartyID As Integer) As List(Of Candidate)
        Dim Result As New List(Of Candidate)
        Dim Query = "SELECT * FROM [CandidateQuery] WHERE [position_id]=?"
        GetConnection().Open()
        Using Cmd As New OleDbCommand(Query, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, PartyID, Voting_SystemVB.Party.LENGTH_ID))
            Cmd.Prepare()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Result.Add(GetCandidate(Reader))
                End While
            End Using
        End Using
        Return Result
    End Function

    Public Shared Function Count(PositionID As Integer)
        Dim Result As Integer = 0
        GetConnection().Open()
        Dim cmd = New OleDbCommand("SELECT Count(*) From Candidate Where position_id=" & PositionID, GetConnection())
        Result = Integer.Parse(cmd.ExecuteScalar())
        GetConnection().Close()
        Return Result
    End Function

    Public Shared Function GetCandidate(Reader As OleDbDataReader) As Candidate
        Dim ID As Integer = Nothing
        Dim StudentID As Integer = Nothing
        Dim Tagline As String = Nothing
        Dim PositionID As Integer = Nothing
        Dim ImagePath As String = Nothing
        Dim Gender As String = Nothing
        Dim Fullname As String = Nothing
        Dim YearLevel As String = Nothing
        Dim Course As String = Nothing
        Dim Party As String = Nothing
        Dim PartyImage As String = Nothing
        Dim PartyDescription As String = Nothing
        Dim PartyID As Integer

        ID = Reader.GetInt32(INDEX_ID)
        StudentID = Reader.GetInt32(INDEX_STUDENT_ID)
        PositionID = Reader.GetInt32(INDEX_POSITION_ID)
        ImagePath = Reader.GetString(INDEX_IMAGE)
        Gender = Reader.GetString(INDEX_GENDER)
        Fullname = Reader.GetString(INDEX_FULLNAME)
        YearLevel = Reader.GetString(INDEX_YEAR)
        Course = Reader.GetString(INDEX_COURSE)

        If Not Reader.IsDBNull(INDEX_TAGLINE) Then Tagline = Reader.GetString(INDEX_TAGLINE)
        If Not Reader.IsDBNull(INDEX_PARTY) Then Party = Reader.GetString(INDEX_PARTY)
        If Not Reader.IsDBNull(INDEX_PARTY_IMAGE) Then PartyImage = Reader.GetString(INDEX_PARTY_IMAGE)
        If Not Reader.IsDBNull(INDEX_PARTY_DESCRIPTION) Then PartyDescription = Reader.GetString(INDEX_PARTY_DESCRIPTION)
        If Not Reader.IsDBNull(INDEX_PARTY_ID) Then PartyID = Reader.GetInt32(INDEX_PARTY_ID)

        Dim Result As New Candidate(ID, StudentID, Fullname, YearLevel, Course, Party, PartyImage, PartyDescription, PartyID)
        Result.PositionID = PositionID
        Result.Image = ImagePath
        Result.Gender = Gender
        Return Result
    End Function


End Class
