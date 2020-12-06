
Imports System.Data.OleDb

Public Class Candidate

    'DATA CONFIGURATIONS AND QUERIES
    Private Const QUERY_UPDATE = "UPDATE [Candidate] SET [description]=?, [image_path]=? WHERE [ID]=?"
    Private Const QUERY_INSERT = "INSERT INTO [Candidate]([student_id],[description],[position_id],[image_path]) VALUES (?,?,?,?)"
    Private Const QUERY_FIND_STUDENT = "SELECT * FROM [CandidateQuery] WHERE student_id=?"
    Private Const QUERY_SELECT_ALL = "SELECT * FROM [CandidateQuery]"
    Private Const QUERY_SELECT_BY_PARTY = "SELECT * FROM [CandidateQuery] WHERE [party_id]=?"
    Private Const QUERY_SELECT_BY_POSITION = "SELECT * FROM [CandidateQuery] WHERE [position_id]=?"
    Private Const QUERY_COUNT_BY_POSITION = "SELECT COUNT(*) FROM Candidate WHERE [position_id]=?"
    Private Const QUERY_SELECT_BY_VOTERS = "SELECT [CandidateQuery].* FROM [CandidateQuery] INNER JOIN [Votes] ON [CandidateQuery].[ID]=[Votes].[candidate_id] WHERE [Votes].[student_id]=?"

    Public Const IMAGE_DEFAULT = "images\default\candidate.jpg"

    Public Const LENGTH_ID = 10
    Private Const LENGTH_STUDENT_ID = 10
    Private Const LENGTH_TAGLINE = 100
    Private Const LENGTH_POSITION_ID = 10
    Private Const LENGTH_IMAGE = 100
    Private Const LENGTH_GENDER = 6

    Private Const INDEX_ID = 0
    Private Const INDEX_STUDENT_ID = 1
    Private Const INDEX_TAGLINE = 2
    Private Const INDEX_POSITION_ID = 3
    Private Const INDEX_IMAGE = 4
    Private Const INDEX_GENDER = 5
    Private Const INDEX_FULLNAME = 6
    Private Const INDEX_YEAR = 7
    Private Const INDEX_COURSE = 8
    Private Const INDEX_PARTY = 9
    Private Const INDEX_PARTY_IMAGE = 10
    Private Const INDEX_PARTY_DESCRIPTION = 11
    Private Const INDEX_PARTY_ID = 12
    Private Const INDEX_STUDENT_STUDENT_ID = 13

    'Encapsulated data
    Private _ID, _StudentID, _PositionID, _PartyID As Integer
    Private _Tagline, _Image, _Gender, _Fullname, _Course, _Year, _Party, _PartyImage, _PartyDesc, _StudentStudentID As String

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
            If IsNothing(_PartyImage) OrElse _PartyImage.Length = 0 Then
                Return ""
            End If
            Return _PartyImage
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
                Return IMAGE_DEFAULT
            End If
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

    'Get Image Path
    Private Function GetFilename() As String
        Return "candidate-" & _StudentID & ".jpg"
    End Function

    'Update Candidate
    Public Function Update() As Boolean
        'Prevent Updating When the election has started
        If Not Election.HasNotStarted Then Return False

        Dim NewImage = GetImage(Image, GetFilename(), "images\" & Election.GetImageDirectory() & "\" & GetFilename())
        Dim Res = False

        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_UPDATE, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _Tagline, LENGTH_TAGLINE))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, NewImage, LENGTH_IMAGE))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _ID, LENGTH_ID))
            Cmd.Prepare()
            Res = Cmd.ExecuteNonQuery() <> -1
        End Using
        GetConnection().Close()

        Return Res
    End Function

    'Save Candidate
    Public Function Save() As Boolean
        If Not Election.HasNotStarted Then Return False

        Dim Result As Boolean = False
        Dim NewImage = GetImage(Image, GetFilename(), IMAGE_DEFAULT)

        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_INSERT, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _StudentID, LENGTH_STUDENT_ID))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _Tagline, LENGTH_TAGLINE))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _PositionID, LENGTH_POSITION_ID))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, NewImage, LENGTH_IMAGE))
            Cmd.Prepare()
            Result = Cmd.ExecuteNonQuery() <> -1
        End Using
        GetConnection().Close()

        Return Result
    End Function


    '
    '    SHARED FUNCTIONS
    '

    'Upload Candidate Image
    Private Shared Function GetImage(Source As String, FileName As String, _Default As String) As String

        Dim Dir = Election.GetImageDirectory()
        'ADD CASES
        '1. NO IMAGE
        '2. UPLOAD IMAGE

        'UPDATE CASES
        '1. CHANGE NOTHING
        '2. CHANGE IMAGE
        '3. CLEAR IMAGE

        If Source.Equals(_Default) Then
            Return _Default
        ElseIf IsNothing(Source) Or Source.Equals("") Then
            If Not FileName.Equals(_Default) Then
                Util.DeleteFile(IO.Path.Combine(Dir, FileName))
            End If
            Return ""
        Else
            Return Util.Upload(Dir, FileName, Source)
        End If
    End Function

    'Count candidates in specific position
    Public Shared Function Count(PositionID As Integer) As Integer
        Dim Res As Integer = 0
        GetConnection().Open()
        Using Cmd = New OleDbCommand(QUERY_COUNT_BY_POSITION, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, PositionID, LENGTH_POSITION_ID))
            Cmd.Prepare()
            Res = DirectCast(Cmd.ExecuteScalar(), Integer)
        End Using
        GetConnection().Close()
        Return Res
    End Function

    'Find Specific Student by the given Student ID
    Public Shared Function FindByStudentID(StudentID As Integer) As Candidate
        Dim Result As Candidate = Nothing
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_FIND_STUDENT, GetConnection())
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

    'Get All Candidates
    Public Shared Function GetAll() As List(Of Candidate)
        Dim Result As New List(Of Candidate)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_SELECT_ALL, GetConnection())
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Result.Add(GetCandidate(Reader))
                End While
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function

    'Return Data In Dictionary Structure
    Public Shared Function GetAll2() As Dictionary(Of Integer, List(Of Candidate))
        Dim Result = GetEmptyDictionary()
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_SELECT_ALL, GetConnection())
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Dim iCandidate = GetCandidate(Reader)
                    Result(iCandidate.PositionID).Add(iCandidate)
                End While
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function

    'Initialize Dictionary Data
    Public Shared Function GetEmptyDictionary() As Dictionary(Of Integer, List(Of Candidate))
        Dim EmptyDictionary = New Dictionary(Of Integer, List(Of Candidate))
        For Each item In Position.GetAll()
            EmptyDictionary.Add(item, New List(Of Candidate))
        Next
        Return EmptyDictionary
    End Function

    'Get All Candidate in Specific Party
    Public Shared Function GetAllByPartyID(PartyID As Integer) As List(Of Candidate)
        Dim Result As New List(Of Candidate)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_SELECT_BY_PARTY, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, PartyID, Voting_SystemVB.Party.LENGTH_ID))
            Cmd.Prepare()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Result.Add(GetCandidate(Reader))
                End While
            End Using
        End Using
        GetConnection.Close()
        Return Result
    End Function

    'Get All Candidate By Positions
    Public Shared Function GetAllByPosition(Position As Integer) As List(Of Candidate)
        Dim Result As New List(Of Candidate)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_SELECT_BY_POSITION, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, Position, Voting_SystemVB.Party.LENGTH_ID))
            Cmd.Prepare()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Result.Add(GetCandidate(Reader))
                End While
            End Using
        End Using
        GetConnection.Close()
        Return Result
    End Function

    'Get Candidates Voted By Specific Voters
    Public Shared Function GetVotedCandidates(ID As Integer) As List(Of Candidate)
        Dim Result As New List(Of Candidate)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_SELECT_BY_VOTERS, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, ID, Student.LENGTH_ID))
            Cmd.Prepare()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Result.Add(GetCandidate(Reader))
                End While
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function

    'Convert Reader into Candidate Model
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
