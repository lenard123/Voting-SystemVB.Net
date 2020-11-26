
Imports System.Data.OleDb

Public Class Candidate

    Private Shared ReadOnly LENGTH_ID = 10
    Private Shared ReadOnly LENGTH_STUDENT_ID = 10
    Private Shared ReadOnly LENGTH_TAGLINE = 100
    Private Shared ReadOnly LENGTH_POSITION_ID = 10
    Private Shared ReadOnly LENGTH_IMAGE = 100
    Private Shared ReadOnly LENGTH_GENDER = 6

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
    Private Shared ReadOnly INDEX_STUDENT_STUDENT_ID = 13

    Private _ID, _StudentID, _PositionID, _PartyID As Integer
    Private _Tagline, _Image, _Gender, _Fullname, _Course, _Year, _Party, _PartyImage, _PartyDesc, _StudentStudentID As String

    Private Shared Cached As List(Of Candidate) = Nothing
    Private Shared NeedRefresh As Boolean = True

    Public Sub New(StudentID As Integer)
        Me._StudentID = StudentID
    End Sub

    Public Sub New(ID As Integer, StudentID As Integer, Fullname As String, YearLevel As String, Course As String, Party As String, PartyImage As String, PartyDesc As String, PartyID As Integer, StudentStudentID As String)
        Me._ID = ID
        Me._StudentID = StudentID
        Me._Fullname = Fullname
        Me._Year = YearLevel
        Me._Course = Course
        Me._Party = Party
        Me._PartyImage = PartyImage
        Me._PartyDesc = PartyDesc
        Me._PartyID = PartyID
        Me._StudentStudentID = StudentStudentID
    End Sub

    Public ReadOnly Property StudentStudentID As String
        Get
            Return _StudentStudentID
        End Get
    End Property

    Public ReadOnly Property PartyImage As String
        Get
            If IsNothing(_PartyImage) Then
                Return ""
            End If
            Return Util.GetFullPath(_PartyImage)
        End Get
    End Property

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
            If IsNothing(_Image) Or _Image.Equals("") Then
                Return Util.GetFullPath("images\default\candidate.jpg")
            End If
            Return Util.GetFullPath(_Image)
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

    Public Shared Async Function GetAllAsync() As Task(Of List(Of Candidate))
        Return Await Task.Run(Function()
                                  Return GetAllF()
                              End Function)
    End Function

    Public Async Function UpdateAsync() As Task(Of Boolean)
        Return Await Task.Run(Function()
                                  Return Update()
                              End Function)
    End Function

    Public Function Update() As Boolean
        If Election.HasNotStarted Then
            Dim Dir = "election-" & Election.GetCurrentElection().Id
            Dim filename = "candidate-" & _StudentID & ".jpg"
            Dim Res = False
            If Image.Equals(Util.GetFullPath("images\default\candidate.jpg")) Then
                Image = ""
            ElseIf Image.Equals(Util.GetFullPath("images\" & Dir & "\" & filename)) Then
                Image = "images\" & Dir & "\" & filename
            Else
                Image = Util.Upload(Dir, filename, Image)
            End If

            GetConnection().Open()
            Using Cmd As New OleDbCommand("UPDATE [Candidate] SET [description]=?, [image_path]=? WHERE [ID]=?", GetConnection())
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _Tagline, LENGTH_TAGLINE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _Image, LENGTH_IMAGE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _ID, LENGTH_ID))
                Cmd.Prepare()
                Res = Cmd.ExecuteNonQuery() <> -1
            End Using
            GetConnection().Close()
            Return Res
        End If
        Console.WriteLine("Election has started")
        Return False
    End Function

    Public Async Function SaveAsync() As Task(Of Boolean)
        Return Await Task.Run(Function()
                                  Return Save()
                              End Function)
    End Function

    Public Function Save() As Boolean
        If Election.HasNotStarted Then
            Dim Image As String = Nothing
            Dim Result As Boolean = False

            If Not IsNothing(Me.Image) Then
                Dim Dir = "election-" & Election.GetCurrentElection().Id
                Dim filename = "candidate-" & _StudentID & ".jpg"
                Image = Util.Upload(Dir, filename, Me.Image)
            End If
            GetConnection().Open()
            Using Cmd As New OleDbCommand("INSERT INTO [Candidate]([student_id],[description],[position_id],[image_path]) VALUES (?,?,?,?)", GetConnection())
                Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _StudentID, LENGTH_STUDENT_ID))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _Tagline, LENGTH_TAGLINE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _PositionID, LENGTH_POSITION_ID))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Image, LENGTH_IMAGE))
                Cmd.Prepare()
                Result = Cmd.ExecuteNonQuery() <> -1
            End Using
            GetConnection().Close()
            Return Result
        End If
        Console.WriteLine("Election has started")
        Return False
    End Function

    Public Shared Function FindByStudentID(StudentID As Integer) As Candidate
        Dim Result As Candidate = Nothing
        GetConnection().Open()
        Using Cmd As New OleDbCommand("SELECT * FROM [CandidateQuery] WHERE student_id=?", GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, StudentID, LENGTH_STUDENT_ID))
            Cmd.Prepare()
            Using Reader = Cmd.ExecuteReader()
                If Reader.Read() Then
                    Result = GetCandidate(Reader)
                End If
            End Using
        End Using
        GetConnection().Close()
        Return Result
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

    Public Shared Async Function GetAllByPartyIDAsync(PartyId As Integer) As Task(Of List(Of Candidate))
        Return Await Task.Run(Function()
                                  Return GetAllByPartyID(PartyId)
                              End Function)
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
        Dim ImagePath As String = ""
        Dim Gender As String = Nothing
        Dim Fullname As String = Nothing
        Dim YearLevel As String = Nothing
        Dim Course As String = Nothing
        Dim Party As String = Nothing
        Dim PartyImage As String = Nothing
        Dim PartyDescription As String = Nothing
        Dim PartyID As Integer = Nothing
        Dim StudentStudentID As String = Nothing

        ID = Reader.GetInt32(INDEX_ID)
        StudentID = Reader.GetInt32(INDEX_STUDENT_ID)
        PositionID = Reader.GetInt32(INDEX_POSITION_ID)
        Fullname = Reader.GetString(INDEX_FULLNAME)
        YearLevel = Reader.GetString(INDEX_YEAR)
        Course = Reader.GetString(INDEX_COURSE)
        StudentStudentID = Reader.GetString(INDEX_STUDENT_STUDENT_ID)

        If Not Reader.IsDBNull(INDEX_GENDER) Then Gender = Reader.GetString(INDEX_GENDER)
        If Not Reader.IsDBNull(INDEX_IMAGE) Then ImagePath = Reader.GetString(INDEX_IMAGE)
        If Not Reader.IsDBNull(INDEX_TAGLINE) Then Tagline = Reader.GetString(INDEX_TAGLINE)
        If Not Reader.IsDBNull(INDEX_PARTY) Then Party = Reader.GetString(INDEX_PARTY)
        If Not Reader.IsDBNull(INDEX_PARTY_IMAGE) Then PartyImage = Reader.GetString(INDEX_PARTY_IMAGE)
        If Not Reader.IsDBNull(INDEX_PARTY_DESCRIPTION) Then PartyDescription = Reader.GetString(INDEX_PARTY_DESCRIPTION)
        If Not Reader.IsDBNull(INDEX_PARTY_ID) Then PartyID = Reader.GetInt32(INDEX_PARTY_ID)

        Dim Result As New Candidate(ID, StudentID, Fullname, YearLevel, Course, Party, PartyImage, PartyDescription, PartyID, StudentStudentID)
        Result.PositionID = PositionID
        Result.Image = ImagePath
        Result.Gender = Gender
        Result.Tagline = Tagline
        Return Result
    End Function


End Class
