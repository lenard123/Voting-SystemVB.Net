Imports System.Data.OleDb

Public Class Student

    Public Shared ReadOnly YEAR_1 = "1st"
    Public Shared ReadOnly YEAR_2 = "2nd"
    Public Shared ReadOnly YEAR_3 = "3rd"
    Public Shared ReadOnly YEAR_4 = "4th"

    Private Shared ReadOnly QUERY_SEARCH = "SELECT DISTINCT [Student].*, [Votes].[student_id] as [has_voted] FROM [Votes] RIGHT JOIN [Student] ON [Votes].[student_id]=[Student].[ID] WHERE [Student].[student_id] LIKE ? OR [Student].[firstname] LIKE ? OR [Student].[lastname] LIKE ?"
    Private Shared ReadOnly QUERY_SELECT_ALL = "SELECT DISTINCT [Student].*, [Votes].[student_id] as [has_voted] FROM [Votes] RIGHT JOIN [Student] ON [Votes].[student_id]=[Student].[ID]"
    Private Shared ReadOnly QUERY_SELECT_BY_ID = "SELECT DISTINCT [Student].*, [Votes].[student_id] as [has_voted] FROM [Votes] RIGHT JOIN [Student] ON [Votes].[student_id]=[Student].[ID] WHERE [Student].[ID]=?"
    Private Shared ReadOnly QUERY_SELECT_BY_STUDENT_ID = "SELECT DISTINCT [Student].*, [Votes].[student_id] as [has_voted] FROM [Votes] RIGHT JOIN [Student] ON [Votes].[student_id]=[Student].[ID] WHERE [Student].[student_id]=?"
    Private Shared ReadOnly QUERY_COUNT_ALL = "SELECT COUNT(*) From Student"

    Private Shared ReadOnly LENGTH_ID As Integer = 10
    Private Shared ReadOnly LENGTH_STUDENT_ID As Integer = 10
    Private Shared ReadOnly LENGTH_FIRSTNAME As Integer = 20
    Private Shared ReadOnly LENGTH_LASTNAME As Integer = 20
    Private Shared ReadOnly LENGTH_YEAR As Integer = 3
    Private Shared ReadOnly LENGTH_COURSE As Integer = 5
    Private Shared ReadOnly LENGTH_SECTION As Integer = 1
    Private Shared ReadOnly LENGTH_PASSWORD As Integer = 32

    Private Shared ReadOnly INDEX_ID As Integer = 0
    Private Shared ReadOnly INDEX_STUDENT_ID As Integer = 1
    Private Shared ReadOnly INDEX_FIRSTNAME As Integer = 2
    Private Shared ReadOnly INDEX_LASTNAME As Integer = 3
    Private Shared ReadOnly INDEX_YEAR As Integer = 4
    Private Shared ReadOnly INDEX_COURSE As Integer = 5
    Private Shared ReadOnly INDEX_SECTION As Integer = 6
    Private Shared ReadOnly INDEX_PASSWORD As Integer = 7
    Private Shared ReadOnly INDEX_HAS_VOTED As Integer = 8

    Private Shared CurrentUser As Student

    Private _Id As Integer
    Private _StudentId, _Fullname, _Firstname, _Lastname, _Course, _Section, _YearLevel, _Password As String
    Private _HasVoted As Boolean

    Private Shared CachedAllStudent As List(Of Student) = Nothing
    Private Shared NeedRefresh As Boolean = True

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

    Public Sub New()
    End Sub
    Public Sub New(Id As Integer, Password As String)
        Me._Id = Id
        Me._Password = Password
    End Sub

    Public Function ComparePassword(Password As String) As Boolean
        Return Me._Password.Equals(Password)
    End Function

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

    Public Function IsCandidate() As Boolean
        Return Not IsNothing(Candidate.FindByStudentID(Id))
    End Function

    Public Shared Async Function GetAllAsync() As Task(Of List(Of Student))
        Dim Result = New List(Of Student)
        Await GetConnection().OpenAsync()
        Using Cmd As New OleDbCommand(QUERY_SELECT_ALL, GetConnection())
            Using Reader = Await Cmd.ExecuteReaderAsync()
                While Reader.Read()
                    Result.Add(GetStudent(Reader))
                End While
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function

    Public Shared Function GetAll() As List(Of Student)
        'Return Cached if not empty
        If IsNothing(CachedAllStudent) Or NeedRefresh Then
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
            CachedAllStudent = Result
            Return Result
        Else
            Return CachedAllStudent
        End If
    End Function



    '
    ' SHARED FUNCTIONS
    '

    Public Shared Sub SetCurrentUser(user As Student)
        CurrentUser = user
    End Sub

    Public Shared Function GetCurrentUser() As Student
        Return CurrentUser
    End Function



    ''' <summary>
    ''' Count the number of Voters Asynchronously
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Shared Function CountAll() As Integer
        Dim Result As Integer = 0
        GetConnection().Open()
        Using Cmd = New OleDbCommand(QUERY_COUNT_ALL, GetConnection())
            Result = Integer.Parse(Cmd.ExecuteScalar())
        End Using
        GetConnection().Close()
        Return Result
    End Function

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
                NeedRefresh = True
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
                NeedRefresh = True
                res = Cmd.ExecuteNonQuery() <> -1
            End Using
            GetConnection().Close()
            Return res
        Else
            Console.WriteLine("Election has started")
            Return False
        End If
    End Function

    Public Shared Function GetAllF() As List(Of Student)
        NeedRefresh = True
        Return GetAll()
    End Function

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

End Class
