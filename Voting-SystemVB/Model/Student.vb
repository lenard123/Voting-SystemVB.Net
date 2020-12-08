Imports System.Data.OleDb

Public Class Student

    Private Const QUERY_SEARCH = "SELECT DISTINCT [Student].*, [Votes].[student_id] as [has_voted] FROM [Votes] RIGHT JOIN [Student] ON [Votes].[student_id]=[Student].[ID] WHERE [Student].[student_id] LIKE ? OR [Student].[firstname] LIKE ? OR [Student].[lastname] LIKE ?"
    Private Const QUERY_SELECT_ALL = "SELECT DISTINCT [Student].*, [Votes].[student_id] as [has_voted] FROM [Votes] RIGHT JOIN [Student] ON [Votes].[student_id]=[Student].[ID]"
    Private Const QUERY_SELECT_BY_ID = "SELECT DISTINCT [Student].*, [Votes].[student_id] as [has_voted] FROM [Votes] RIGHT JOIN [Student] ON [Votes].[student_id]=[Student].[ID] WHERE [Student].[ID]=?"
    Private Const QUERY_SELECT_BY_STUDENT_ID = "SELECT DISTINCT [Student].*, [Votes].[student_id] as [has_voted] FROM [Votes] RIGHT JOIN [Student] ON [Votes].[student_id]=[Student].[ID] WHERE [Student].[student_id]=?"
    Private Const QUERY_COUNT_ALL = "SELECT COUNT(*) From Student"

    Public Const LENGTH_ID As Integer = 10
    Private Const LENGTH_STUDENT_ID As Integer = 10
    Private Const LENGTH_FIRSTNAME As Integer = 20
    Private Const LENGTH_LASTNAME As Integer = 20
    Private Const LENGTH_YEAR As Integer = 3
    Private Const LENGTH_COURSE As Integer = 5
    Private Const LENGTH_SECTION As Integer = 1
    Private Const LENGTH_PASSWORD As Integer = 32

    Private Const INDEX_ID As Integer = 0
    Private Const INDEX_STUDENT_ID As Integer = 1
    Private Const INDEX_FIRSTNAME As Integer = 2
    Private Const INDEX_LASTNAME As Integer = 3
    Private Const INDEX_YEAR As Integer = 4
    Private Const INDEX_COURSE As Integer = 5
    Private Const INDEX_SECTION As Integer = 6
    Private Const INDEX_PASSWORD As Integer = 7
    Private Const INDEX_HAS_VOTED As Integer = 8

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

    'Compare Password
    Public Function ComparePassword(Password As String) As Boolean
        Return Me._Password.Equals(Password)
    End Function

    'Check if Student is a registered candidate
    Public Function IsCandidate() As Boolean
        Return Not IsNothing(Candidate.FindByStudentID(Id))
    End Function


    'Update the info of Students
    Public Function Update() As Boolean
        If Election.HasNotStarted Then
            Dim Query = "UPDATE [Student] SET [firstname]=?, [lastname]=?, [course]=?, [year_level]=?, [section]=?, [password]=? WHERE [ID]=?"
            Dim res As Boolean
            GetConnection().Open()
            Using Cmd As New OleDbCommand(Query, GetConnection())
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Firstname, LENGTH_FIRSTNAME))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Lastname, LENGTH_LASTNAME))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Course, LENGTH_COURSE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _YearLevel, LENGTH_YEAR))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Section, LENGTH_SECTION))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _Password, LENGTH_PASSWORD))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, Id, LENGTH_ID))
                Cmd.Prepare()
                res = Cmd.ExecuteNonQuery() <> -1
            End Using
            GetConnection.Close()
            Return res
        Else
            Console.WriteLine("Election has started")
            Return False
        End If
        Return False
    End Function

    'Save a new Student
    Public Function Save() As Boolean
        If Election.HasNotStarted Then
            Dim Query = "INSERT INTO [Student]([student_id], [firstname], [lastname], [course], [year_level], [section], [password]) VALUES (?,?,?,?,?,?,?)"
            Dim res As Boolean
            GetConnection().Open()
            Using Cmd As New OleDbCommand(Query, GetConnection())
                Dim r As New Random
                Dim password = StudentId & "-" & r.Next(1000, 10000)
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, StudentId, LENGTH_STUDENT_ID))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Firstname, LENGTH_FIRSTNAME))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Lastname, LENGTH_LASTNAME))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Course, LENGTH_COURSE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, _YearLevel, LENGTH_YEAR))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Section, LENGTH_SECTION))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, password, LENGTH_PASSWORD))
                Cmd.Prepare()
                res = Cmd.ExecuteNonQuery() <> -1
            End Using
            GetConnection().Close()
            Return res
        Else
            Console.WriteLine("Election has started")
            Return False
        End If
    End Function


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

    'Count all numbers of Students
    Public Shared Function CountAll() As Integer
        Dim Result As Integer = 0
        GetConnection().Open()
        Using Cmd = New OleDbCommand(QUERY_COUNT_ALL, GetConnection())
            Result = Integer.Parse(Cmd.ExecuteScalar())
        End Using
        GetConnection().Close()
        Return Result
    End Function

    'Get All Students
    Public Shared Function GetAll() As List(Of Student)
        Dim Result As New List(Of Student)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_SELECT_ALL, GetConnection())
            Using Reader = Cmd.ExecuteReader()
                While (Reader.Read())
                    Result.Add(GetStudent(Reader))
                End While
            End Using
        End Using
        GetConnection.Close()
        Return Result
    End Function

    'Find Student Using ID
    Public Shared Function Find(Id As Integer) As Student
        Dim Result As Student = Nothing
        GetConnection().Open()
        Using Cmd = New OleDbCommand(QUERY_SELECT_BY_ID, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, Id, LENGTH_ID))
            Cmd.Prepare()
            Using Reader = Cmd.ExecuteReader()
                If Reader.Read() Then
                    Result = GetStudent(Reader)
                End If
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function

    'Find Student Using Student Id
    Public Shared Function Find(Id As String) As Student
        Dim Result As Student = Nothing
        GetConnection().Open()
        Using Cmd = New OleDbCommand(QUERY_SELECT_BY_STUDENT_ID, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Id, LENGTH_STUDENT_ID))
            Cmd.Prepare()
            Using Reader = Cmd.ExecuteReader()
                If Reader.Read() Then
                    Result = GetStudent(Reader)
                End If
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function

    'Search Students
    Public Shared Function Search(Query As String) As List(Of Student)
        Query = "%" & Query & "%"
        Dim Result As New List(Of Student)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_SEARCH, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Query, 64))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Query, 64))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Query, 64))
            Cmd.Prepare()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Result.Add(GetStudent(Reader))
                End While
            End Using
        End Using
        GetConnection.Close()
        Return Result
    End Function

    'Convert Reader into Student Class
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

    'Refresh Current User
    Public Shared Function RefreshCurrentUser() As Student
        If Not IsNothing(CurrentUser) Then
            CurrentUser = Find(CurrentUser.Id)
        End If
        Return CurrentUser
    End Function
End Class
