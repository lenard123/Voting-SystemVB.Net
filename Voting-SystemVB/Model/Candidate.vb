
Imports System.Data.OleDb

Public Class Candidate

    'Encapsulated data
    Private _ID, _StudentID, _PositionID, _PartyID, VoteCount As Integer
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
    Private ReadOnly Property GetFilename As String
        Get
            Return "candidate-" & _StudentID & ".jpg"
        End Get
    End Property

    Public Sub SetVoteCount(count As Integer)
        VoteCount = count
    End Sub

    Public Function GetVoteCount() As Integer
        Return VoteCount
    End Function

    ''' <summary>
    ''' Update Candidate  Information
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Update()
        'Prevent Updating When the election has started
        If Not Election.HasNotStarted Then Throw New ElectionAlreadyStartedException()

        'Prevent Unauthorized Admin from updating information
        If Not Admin.GetCurrentUser().CanUpdateCandidate Then Throw New InvalidPrivilegeException

        'Upload Image
        Dim NewImage = GetImage(Image, GetFilename(), "images\" & Election.GetImageDirectory() & "\" & GetFilename())
        Using Cmd As New OleDbCommand(QUERY_UPDATE, GetConnection())
            BindParameters(Cmd, _Tagline, NewImage, _ID, Election.GetCurrentId())

            GetConnection().Open()
            Cmd.ExecuteNonQuery()
            GetConnection().Close()
        End Using

    End Sub

    ''' <summary>
    ''' Register a new Candidate
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Save()
        'Prevent add new candidate if the election has started
        If Not Election.HasNotStarted Then Throw New ElectionAlreadyStartedException

        'Prevent Unauthorized Admin from updating information
        If Not Admin.GetCurrentUser().CanRegisterCandidate Then Throw New InvalidPrivilegeException

        'Upload image
        Dim NewImage = GetImage(Image, GetFilename(), IMAGE_DEFAULT)

        Using Cmd As New OleDbCommand(QUERY_INSERT, GetConnection())
            BindParameters(Cmd, _StudentID, _Tagline, _PositionID, NewImage, Election.GetCurrentId())
            GetConnection().Open()
            Cmd.ExecuteNonQuery()
            GetConnection().Close()
        End Using
    End Sub


    '
    '    SHARED FUNCTIONS
    '

    ''' <summary>
    ''' Upload Candidate Image and return the uploaded image path
    ''' </summary>
    ''' <param name="Source">Image to be uploaded</param>
    ''' <param name="FileName">Destination</param>
    ''' <param name="_Default">If source is empty</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Count the number of candidates
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Count() As Dictionary(Of Integer, Integer)
        'Initialize Result variable
        Dim Res As New Dictionary(Of Integer, Integer)
        Position.GetAll().ForEach(Sub(item) Res.Add(item, 0))

        Using Cmd = New OleDbCommand(QUERY_COUNT, GetConnection())
            GetConnection().Open()
            BindParameters(Cmd, Election.GetCurrentId())
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Dim PositionId = Reader.GetInt32(0)
                    Dim CandidateCount = Reader.GetInt32(1)
                    Res(PositionId) = CandidateCount
                End While
            End Using
            GetConnection().Close()
        End Using
        Return Res
    End Function

    ''' <summary>
    ''' Find Specific Student by the given Student ID
    ''' </summary>
    ''' <param name="StudentID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function FindByStudentID(StudentID As Integer) As Candidate
        Dim Result As Candidate = Nothing
        Using Cmd As New OleDbCommand(QUERY_FIND_STUDENT, GetConnection())
            BindParameters(Cmd, StudentID, Election.GetCurrentId())
            GetConnection().Open()
            Using Reader = Cmd.ExecuteReader()
                If Reader.Read() Then
                    Result = GetCandidate(Reader)
                End If
            End Using
            GetConnection().Close()
        End Using
        Return Result
    End Function

    ''' <summary>
    ''' Get All Candidates
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetAll() As Dictionary(Of Integer, List(Of Candidate))
        Dim Result = Position.GetDictionary()
        Using Cmd As New OleDbCommand(QUERY_SELECT_ALL, GetConnection())
            BindParameters(Cmd, Election.GetCurrentId())
            GetConnection().Open()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Dim iCandidate = GetCandidate(Reader)
                    Result(iCandidate.PositionID).Add(iCandidate)
                End While
            End Using
            GetConnection().Close()
        End Using
        Return Result
    End Function

    ''' <summary>
    ''' Get All Candidate in Specific Party
    ''' </summary>
    ''' <param name="PartyID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetAllByPartyID(PartyID As Integer) As List(Of Candidate)
        Dim Result As New List(Of Candidate)
        Using Cmd As New OleDbCommand(QUERY_SELECT_BY_PARTY, GetConnection())
            BindParameters(Cmd, PartyID, Election.GetCurrentId())
            GetConnection().Open()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Result.Add(GetCandidate(Reader))
                End While
            End Using
            GetConnection.Close()
        End Using
        Return Result
    End Function

    ''' <summary>
    ''' Get Candidates Voted By Specific Voters
    ''' </summary>
    ''' <param name="ID">Id of Voters</param>
    ''' <returns>List of Candidate voted by the given voters</returns>
    ''' <remarks></remarks>
    Public Shared Function GetVotedCandidates(ID As Integer) As List(Of Candidate)
        Dim Result As New List(Of Candidate)
        Using Cmd As New OleDbCommand(QUERY_SELECT_BY_VOTERS, GetConnection())
            BindParameters(Cmd, ID, Election.GetCurrentId())
            GetConnection().Open()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Result.Add(GetCandidate(Reader))
                End While
            End Using
            GetConnection().Close()
        End Using
        Return Result
    End Function

    Public Shared Function GetResult() As Dictionary(Of Integer, Candidate)
        Dim Result As New Dictionary(Of Integer, Candidate)
        Using Cmd As New OleDbCommand(QUERY_SELECT_RESULT, GetConnection())
            BindParameters(Cmd, Election.GetCurrentElection().Id)
            GetConnection().Open()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Dim cand = GetCandidate(Reader)
                    Result.Add(cand.PositionID, cand)
                End While
            End Using
            GetConnection().Close()
        End Using
        Return Result
    End Function

    ''' <summary>
    ''' Convert Reader into Candidate Model
    ''' </summary>
    ''' <param name="Reader"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
        Result.SetVoteCount(Reader.GetInt32(INDEX_VOTE_COUNT))
        Return Result
    End Function

    'DATA CONFIGURATIONS AND QUERIES
    Private Const QUERY_UPDATE = "UPDATE [Candidate] SET [description]=?, [image_path]=? WHERE [ID]=? AND [election_id]=?"
    Private Const QUERY_INSERT = "INSERT INTO [Candidate]([student_id],[description],[position_id],[image_path],[election_id]) VALUES (?,?,?,?,?)"
    Private Const QUERY_FIND_STUDENT = "SELECT * FROM [CandidateQuery] WHERE [student_id]=? AND [election_id]=?"
    Private Const QUERY_SELECT_ALL = "SELECT * FROM [CandidateQuery] WHERE [election_id]=?"
    Private Const QUERY_SELECT_BY_PARTY = "SELECT * FROM [CandidateQuery] WHERE [party_id]=? AND [election_id]=?"
    Private Const QUERY_COUNT = "SELECT [position_id], COUNT(*) FROM Candidate WHERE [election_id]=? GROUP BY [position_id]"
    Private Const QUERY_SELECT_BY_VOTERS = "SELECT [CandidateQuery].* FROM [CandidateQuery] INNER JOIN [Votes] ON [CandidateQuery].[ID]=[Votes].[candidate_id] WHERE [Votes].[student_id]=? and [CandidateQuery].[election_id]=?"
    Private Const QUERY_SELECT_RESULT = "SELECT CandidateQuery.* FROM CandidateQuery INNER JOIN Result On  CandidateQuery.id = Result.candidate_id WHERE CandidateQuery.election_id = ?"

    Public Const IMAGE_DEFAULT = "images\default\candidate.jpg"

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
    Private Const INDEX_VOTE_COUNT = 14

End Class
