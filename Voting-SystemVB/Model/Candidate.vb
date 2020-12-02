
Imports System.Data.OleDb

Public Class Candidate

    'DATA CONFIGURATIONS AND QUERIES
    Private Shared ReadOnly QUERY_UPDATE = "UPDATE [Candidate] SET [description]=?, [image_path]=? WHERE [ID]=?"
    Private Shared ReadOnly QUERY_INSERT = "INSERT INTO [Candidate]([student_id],[description],[position_id],[image_path]) VALUES (?,?,?,?)"
    Private Shared ReadOnly QUERY_FIND_STUDENT = "SELECT * FROM [CandidateQuery] WHERE student_id=?"
    Private Shared ReadOnly QUERY_SELECT_ALL = "SELECT * FROM [CandidateQuery]"
    Private Shared ReadOnly QUERY_SELECT_BY_PARTY = "SELECT * FROM [CandidateQuery] WHERE [party_id]=?"
    Private Shared ReadOnly QUERY_SELECT_BY_POSITION = "SELECT * FROM [CandidateQuery] WHERE [position_id]=?"
    Private Shared ReadOnly QUERY_COUNT_BY_POSITION = "SELECT COUNT(*) FROM Candidate WHERE [position_id]=?"

    Private Shared ReadOnly IMAGE_DEFAULT = "images\default\candidate.jpg"

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

    Private ReadOnly Property Filename As String
        Get
            Return "candidate-" & _ID & ".jpg"
        End Get
    End Property

    'Update Candidate Asynchronously
    Public Async Function UpdateAsync() As Task(Of Boolean)
        If Not Election.HasNotStarted Then Return False
        Dim Res = False
        Dim _ImagePath = ""

        If Image.Equals("images\" & Election.ImageDirectory & "\" & Filename) Then
            _ImagePath = "images\" & Election.ImageDirectory & "\" & Filename
        ElseIf Not Image.Equals(IMAGE_DEFAULT) Then
            _ImagePath = Util.Upload(Election.ImageDirectory, Filename, Image)
        End If

        Await GetConnection().OpenAsync()
        Using Cmd As New OleDbCommand(QUERY_UPDATE, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _Tagline, LENGTH_TAGLINE))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _ImagePath, LENGTH_IMAGE))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _ID, LENGTH_ID))
            Cmd.Prepare()
            Res = Await Cmd.ExecuteNonQueryAsync() <> -1
        End Using
        GetConnection().Close()

        Return Res
    End Function
    'Update Candidate
    Public Function Update() As Boolean
        'Prevent Updating When the election has started
        If Not Election.HasNotStarted Then Return False
        Dim _ImagePath = ""
        Dim Res = False

        'IF there's a selected image by the user
        If Not Image.Equals("images\" & Election.ImageDirectory & "\" & Filename) And Not Image.Equals(IMAGE_DEFAULT) Then
            'Upload Image
            _ImagePath = Util.Upload(Election.ImageDirectory, Filename, Image)
        End If

        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_UPDATE, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _Tagline, LENGTH_TAGLINE))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _ImagePath, LENGTH_IMAGE))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _ID, LENGTH_ID))
            Cmd.Prepare()
            Res = Cmd.ExecuteNonQuery() <> -1
        End Using
        GetConnection().Close()

        Return Res
    End Function

    'Save Candidate Asynchronously
    Public Async Function SaveAsync() As Task(Of Boolean)
        If Not Election.HasNotStarted Then Return False
        Dim ImagePath As String = ""
        Dim Result As Boolean = False

        'Upload Image if there's is selected
        If Not IsNothing(_Image) Then
            ImagePath = Util.Upload(Election.ImageDirectory, Filename, _Image)
        End If

        Await GetConnection().OpenAsync()
        Using Cmd As New OleDbCommand(QUERY_INSERT, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _StudentID, LENGTH_STUDENT_ID))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _Tagline, LENGTH_TAGLINE))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _PositionID, LENGTH_POSITION_ID))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, ImagePath, LENGTH_IMAGE))
            Cmd.Prepare()
            Result = (Await Cmd.ExecuteNonQueryAsync()) <> -1
        End Using
        GetConnection().Close()

        Return Result
    End Function
    'Save Candidate
    Public Function Save() As Boolean
        If Not Election.HasNotStarted Then Return False
        Dim ImagePath As String = ""
        Dim Result As Boolean = False

        'Upload Image if there's is selected
        If Not IsNothing(_Image) Then
            ImagePath = Util.Upload(Election.ImageDirectory, Filename, _Image)
        End If

        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_INSERT, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _StudentID, LENGTH_STUDENT_ID))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _Tagline, LENGTH_TAGLINE))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _PositionID, LENGTH_POSITION_ID))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, ImagePath, LENGTH_IMAGE))
            Cmd.Prepare()
            Result = Cmd.ExecuteNonQuery() <> -1
        End Using
        GetConnection().Close()

        Return Result
    End Function


    '
    '    SHARED FUNCTIONS
    '

    'Count candidates in specific position
    Public Shared Async Function CountAsync(PositionID As Integer) As Task(Of Integer)
        Dim Res As Integer = 0
        Await GetConnection().OpenAsync()
        Using Cmd = New OleDbCommand(QUERY_COUNT_BY_POSITION, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, PositionID, LENGTH_POSITION_ID))
            Cmd.Prepare()
            Res = DirectCast(Await Cmd.ExecuteScalarAsync(), Integer)
        End Using
        GetConnection().Close()
        Return Res
    End Function
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
    Public Shared Async Function FindByStudentIDAsync(StudentID As Integer) As Task(Of Candidate)
        Dim Result As Candidate = Nothing
        Await GetConnection().OpenAsync()
        Using Cmd As New OleDbCommand(QUERY_FIND_STUDENT, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, StudentID, LENGTH_STUDENT_ID))
            Cmd.Prepare()
            Using Reader = Await Cmd.ExecuteReaderAsync()
                If Reader.Read() Then
                    Result = GetCandidate(Reader)
                End If
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function
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
    Public Shared Async Function GetAllAsync() As Task(Of List(Of Candidate))
        Dim Result As New List(Of Candidate)
        Await GetConnection().OpenAsync()
        Using Cmd = New OleDbCommand(QUERY_SELECT_ALL, GetConnection())
            Using Reader = Await Cmd.ExecuteReaderAsync()
                While Reader.Read()
                    Result.Add(GetCandidate(Reader))
                End While
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function
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
    Public Shared Async Function GetAll2Async() As Task(Of Dictionary(Of Integer, List(Of Candidate)))
        Dim Result As New Dictionary(Of Integer, List(Of Candidate))
        Await GetConnection().OpenAsync()
        Using Cmd As New OleDbCommand(QUERY_SELECT_ALL, GetConnection())
            Using Reader = Await Cmd.ExecuteReaderAsync()
                While Reader.Read()
                    Dim iCandidate = GetCandidate(Reader)
                    If Not Result.ContainsKey(iCandidate.PositionID) Then Result.Add(iCandidate.PositionID, New List(Of Candidate))
                    Result(iCandidate.PositionID).Add(iCandidate)
                End While
            End Using
        End Using
        Return Result
    End Function

    'Get All Candidate in Specific Party
    Public Shared Async Function GetAllByPartyIDAsync(PartyId As Integer) As Task(Of List(Of Candidate))
        Dim Result As New List(Of Candidate)
        Await GetConnection().OpenAsync()
        Using Cmd As New OleDbCommand(QUERY_SELECT_BY_PARTY, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, PartyId, Voting_SystemVB.Party.LENGTH_ID))
            Cmd.Prepare()
            Using Reader = Await Cmd.ExecuteReaderAsync()
                While Reader.Read()
                    Result.Add(GetCandidate(Reader))
                End While
            End Using
        End Using
        GetConnection.Close()
        Return Result
    End Function
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

    'Get All Candidate in Specific Position
    Public Shared Async Function GetAllByPositionAsync(Position As Integer) As Task(Of List(Of Candidate))
        Dim Result As New List(Of Candidate)
        Await GetConnection().OpenAsync()
        Using Cmd As New OleDbCommand(QUERY_SELECT_BY_POSITION, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, Position, Voting_SystemVB.Party.LENGTH_ID))
            Cmd.Prepare()
            Using Reader = Await Cmd.ExecuteReaderAsync()
                While Reader.Read()
                    Result.Add(GetCandidate(Reader))
                End While
            End Using
        End Using
        GetConnection.Close()
        Return Result
    End Function
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
