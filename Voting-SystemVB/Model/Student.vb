Imports System.Data.OleDb

Public Class Student

    Private Shared CurrentUser As Student

    Private _Id As Integer
    Private _StudentId, _Fullname, _Firstname, _Lastname, _Course, _Section, _YearLevel, _Password As String
    Private _HasVoted As Boolean

    'Public Properties
    Public Property HasVoted As Boolean
        Get
            Return _HasVoted
        End Get
        Set(value As Boolean)
            _HasVoted = value
        End Set
    End Property
    Public ReadOnly Property Id As Integer
        Get
            Return _Id
        End Get
    End Property
    Public Property StudentId As String
        Get
            Return _StudentId
        End Get
        Set(value As String)
            _StudentId = value
        End Set
    End Property
    Public ReadOnly Property Fullname As String
        Get
            Return _Firstname & " " & _Lastname
        End Get
    End Property
    Public Property Firstname As String
        Get
            Return _Firstname
        End Get
        Set(value As String)
            _Firstname = value
        End Set
    End Property
    Public Property Lastname As String
        Get
            Return _Lastname
        End Get
        Set(value As String)
            _Lastname = value
        End Set
    End Property
    Public Property Course As String
        Get
            Return _Course
        End Get
        Set(value As String)
            _Course = value
        End Set
    End Property
    Public Property YearLevel As String
        Get
            Return _YearLevel & " year"
        End Get
        Set(value As String)
            _YearLevel = value
        End Set
    End Property
    Public Property Section As String
        Get
            Return _Section
        End Get
        Set(value As String)
            _Section = value
        End Set
    End Property
    Public ReadOnly Property Password As String
        Get
            Return _Password
        End Get
    End Property


    'Instatiation
    Public Sub New()
    End Sub
    Public Sub New(Id As Integer, Password As String)
        Me._Id = Id
        Me._Password = Password
    End Sub

    ''' <summary>
    ''' Check if Password match
    ''' </summary>
    ''' <param name="Password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ComparePassword(Password As String) As Boolean
        Return Me._Password.Equals(Password)
    End Function

    ''' <summary>
    ''' Check if Student is a registered candidate
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsCandidate() As Boolean
        Dim Result = False

        Using Cmd = New OleDbCommand(QUERY_IS_CANDIDATE, GetConnection())
            BindParameters(Cmd, Id, Election.GetCurrentId())
            GetConnection().Open()
            Result = Integer.Parse(Cmd.ExecuteScalar()) > 0
            GetConnection().Close()
        End Using

        Return Result
    End Function


    ''' <summary>
    ''' Update the info of Students
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Update()

        If Not Election.HasNotStarted Then Throw New ElectionAlreadyStartedException
        If Not Admin.GetCurrentUser().CanUpdateStudent() Then Throw New InvalidPrivilegeException

        Using Cmd As New OleDbCommand(QUERY_UPDATE, GetConnection())
            BindParameters(Cmd, Firstname, Lastname, Course, _YearLevel, Section, _Password, Id, Election.GetCurrentId())

            GetConnection().Open()
            Cmd.ExecuteNonQuery()
            GetConnection.Close()
        End Using
    End Sub

    ''' <summary>
    ''' Save a new Student
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Save()
        If Not Election.HasNotStarted Then Throw New ElectionAlreadyStartedException
        If Not Admin.GetCurrentUser().CanAddStudent Then Throw New InvalidPrivilegeException

        Using Cmd As New OleDbCommand(QUERY_INSERT, GetConnection())
            Dim password = (New Random).Next(100000, 999999)

            BindParameters(Cmd, StudentId, Firstname, Lastname, Course, _YearLevel, Section, password, Election.GetCurrentId())

            GetConnection().Open()
            Cmd.ExecuteNonQuery()
            GetConnection().Close()
        End Using
    End Sub


    '
    ' SHARED FUNCTIONS
    '

    'Gets and Set the Current User
    Public Shared Sub SetCurrentUser(user As Student)
        CurrentUser = user
    End Sub
    Public Shared Function GetCurrentUser() As Student
        Return CurrentUser
    End Function

    ''' <summary>
    ''' Count all numbers of Students
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CountAll() As Integer
        Dim Result As Integer = 0
        GetConnection().Open()
        Using Cmd = New OleDbCommand(QUERY_COUNT_ALL, GetConnection())
            BindParameters(Cmd, Election.GetCurrentId())
            Result = Integer.Parse(Cmd.ExecuteScalar())
        End Using
        GetConnection().Close()
        Return Result
    End Function

    ''' <summary>
    ''' Fetch All the Students
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetAll() As List(Of Student)
        Dim Result As New List(Of Student)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_SELECT_ALL, GetConnection())
            BindParameters(Cmd, Election.GetCurrentId())
            Using Reader = Cmd.ExecuteReader()
                While (Reader.Read())
                    Result.Add(GetStudent(Reader))
                End While
            End Using
        End Using
        GetConnection.Close()
        Return Result
    End Function


    ''' <summary>
    ''' Find Student Using Their ID
    ''' </summary>
    ''' <param name="_Id">Can be ID or StudentID</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Find(_Id As Object) As Student

        'Throw Exception when student ID doesn't exists
        If Not IsExists(_Id) Then Throw New StudentNotExistsException

        'Initialize variables
        Dim Result As Student = Nothing
        Dim StudentID As String = _Id.ToString()
        Dim ID = -1
        Integer.TryParse(_Id, ID)

        Using Cmd = New OleDbCommand(QUERY_SELECT_BY_ID, GetConnection())
            BindParameters(Cmd, ID, StudentID, Election.GetCurrentId())
            GetConnection().Open()
            Using Reader = Cmd.ExecuteReader()
                If Reader.Read() Then Result = GetStudent(Reader)
            End Using
            GetConnection().Close()
        End Using

        Return Result
    End Function

    ''' <summary>
    ''' Check IF the GivenID exists in the database
    ''' </summary>
    ''' <param name="_ID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function IsExists(_ID As Object) As Boolean
        'Initialize Variables
        Dim Result = False
        Dim student_id = _ID.ToString()
        Dim ID = -1
        Integer.TryParse(_ID, ID)

        Using Cmd As New OleDbCommand(QUERY_IS_EXISTS_ID, GetConnection())
            'Prepare Parameters
            BindParameters(Cmd, ID, student_id, Election.GetCurrentId())
            GetConnection().Open()
            Result = Integer.Parse(Cmd.ExecuteScalar()) > 0
            GetConnection().Close()
        End Using

        Return Result
    End Function

    ''' <summary>
    ''' Search in students database
    ''' </summary>
    ''' <param name="Query">Use as filter</param>
    ''' <returns></returns>
    ''' <remarks>Search in StudentID and Fullname Columns</remarks>
    Public Shared Function Search(Query As String) As List(Of Student)
        Query = "%" & Query.Trim() & "%"
        Dim Result As New List(Of Student)

        Using Cmd As New OleDbCommand(QUERY_SEARCH, GetConnection())
            BindParameters(Cmd, Query, Query, Query, Election.GetCurrentId())
            GetConnection().Open()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Result.Add(GetStudent(Reader))
                End While
            End Using
        End Using
        GetConnection.Close()
        Return Result
    End Function

    ''' <summary>
    ''' Convert Reader into Student Class
    ''' </summary>
    ''' <param name="Reader"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function GetStudent(Reader As OleDbDataReader) As Student
        Dim Result As Student = New Student(Reader.GetInt32(INDEX_ID), Reader.GetString(INDEX_PASSWORD))
        Try
            Result.StudentId = Reader.GetString(INDEX_STUDENT_ID)
            Result.Firstname = Reader.GetString(INDEX_FIRSTNAME)
            Result.Lastname = Reader.GetString(INDEX_LASTNAME)
            Result.Course = Reader.GetString(INDEX_COURSE)
            Result.YearLevel = Reader.GetString(INDEX_YEAR)
            Result.Section = Reader.GetString(INDEX_SECTION)
            Result.HasVoted = Not Reader.IsDBNull(INDEX_HAS_VOTED)
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
        Return Result
    End Function

    ''' <summary>
    ''' Refresh the data of Current Logged In User
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function RefreshCurrentUser() As Student
        If Not IsNothing(CurrentUser) Then
            CurrentUser = Find(CurrentUser.Id)
        End If
        Return CurrentUser
    End Function

    ''' <summary>
    ''' Logged in the user that match the StudentID and Password
    ''' </summary>
    ''' <param name="StudentID"></param>
    ''' <param name="Password"></param>
    ''' <remarks></remarks>
    Public Shared Sub Login(StudentID As String, Password As String)

        'Check if the election has started
        Election.GetCurrentElectionRefresh()
        If Election.HasNotStarted() Then Throw New ElectionHasNotStartedException()

        'Get Student
        Dim CheckStud = Find(StudentID)

        'Validate Password
        If Not CheckStud.ComparePassword(Password) Then Throw New InvalidPasswordException()

        'SetUser
        SetCurrentUser(CheckStud)
    End Sub

    'Constant Properties
    Private Const QUERY_SEARCH = "SELECT * FROM [StudentQuery] WHERE ([student_id] LIKE ? OR [firstname] LIKE ? OR [lastname] LIKE ?) AND [election_id]=?"
    Private Const QUERY_SELECT_ALL = "SELECT * FROM [StudentQuery] WHERE [election_id]=?"
    Private Const QUERY_SELECT_BY_ID = "SELECT * FROM [StudentQuery] WHERE ([ID]=? OR [student_id]=?) AND [election_id]=?"
    Private Const QUERY_COUNT_ALL = "SELECT COUNT(*) From [Student] WHERE [election_id]=?"
    Private Const QUERY_IS_EXISTS_ID = "SELECT COUNT(*) FROM [Student] WHERE ([ID]=? OR [student_id]=?) AND [election_id]=?"
    Private Const QUERY_IS_CANDIDATE = "SELECT COUNT(*) FROM [Candidate] WHERE [student_id]=? AND [election_id]=?"
    Private Const QUERY_UPDATE = "UPDATE [Student] SET [firstname]=?, [lastname]=?, [course]=?, [year_level]=?, [section]=?, [password]=? WHERE [ID]=? AND [election_id]=?"
    Private Const QUERY_INSERT = "INSERT INTO [Student]([student_id], [firstname], [lastname], [course], [year_level], [section], [password], [election_id]) VALUES (?,?,?,?,?,?,?,?)"

    Private Const INDEX_ID As Integer = 0
    Private Const INDEX_STUDENT_ID As Integer = 1
    Private Const INDEX_FIRSTNAME As Integer = 2
    Private Const INDEX_LASTNAME As Integer = 3
    Private Const INDEX_YEAR As Integer = 4
    Private Const INDEX_COURSE As Integer = 5
    Private Const INDEX_SECTION As Integer = 6
    Private Const INDEX_PASSWORD As Integer = 7
    Private Const INDEX_HAS_VOTED As Integer = 8
End Class
