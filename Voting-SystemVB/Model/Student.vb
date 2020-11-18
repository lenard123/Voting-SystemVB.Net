Imports System.Data.OleDb

Public Class Student

    Private Shared STUDENT_ID_LENGTH As Integer = 10
    Private Shared STUDENT_STUDENTID_LENGTH As Integer = 10
    Private Shared STUDENT_ID_INDEX As Integer = 0
    Private Shared STUDENT_STUDENTID_INDEX As Integer = 1
    Private Shared STUDENT_FIRSTNAME_INDEX As Integer = 2
    Private Shared STUDENT_LASTNAME_INDEX As Integer = 3
    Private Shared STUDENT_YEAR_INDEX As Integer = 4
    Private Shared STUDENT_COURSE_INDEX As Integer = 5
    Private Shared STUDENT_SECTION_INDEX As Integer = 6
    Private Shared STUDENT_PASSWORD_INDEX As Integer = 7

    Private _Id As Integer
    Private _StudentId, _Fullname, _Firstname, _Lastname, _Course, _Section, _YearLevel, Password As String

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
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

    Public Sub New(Password As String)
        Me.Password = Password
    End Sub

    Public Function ComparePassword(Password As String) As Boolean
        Return Me.Password.Equals(Password)
    End Function

    Public Shared Function Find(Id As Integer) As Student
        Dim Result As Student = Nothing
        GetConnection().Open()
        Dim Reader As OleDbDataReader = ExecuteReader(
            GetConnection(),
            "SELECT * FROM [Student] WHERE [ID]=?",
            ConvertToParam(OleDbType.Integer, Id, STUDENT_ID_LENGTH)
        )
        If Reader.Read() Then
            Result = GetStudent(Reader)
        End If
        Reader.Close()
        GetConnection().Close()
        Return Result
    End Function

    Public Shared Function Find(Id As String) As Student
        Dim Result As Student = Nothing
        GetConnection().Open()
        Dim Reader As OleDbDataReader = ExecuteReader(
            GetConnection(),
            "SELECT * FROM [Student] WHERE [student_id]=?",
            ConvertToParam(OleDbType.VarChar, Id, STUDENT_STUDENTID_LENGTH)
        )
        If Reader.Read() Then
            Result = GetStudent(Reader)
        End If
        Reader.Close()
        GetConnection().Close()
        Return Result
    End Function

    Private Shared Function GetStudent(Reader As OleDbDataReader) As Student
        Dim Result As Student = New Student(Reader.GetString(STUDENT_PASSWORD_INDEX))
        Try
            Result.Id = Reader.GetInt32(STUDENT_ID_INDEX)
            Result.StudentId = Reader.GetString(STUDENT_STUDENTID_INDEX)
            Result.Firstname = Reader.GetString(STUDENT_FIRSTNAME_INDEX)
            Result.Lastname = Reader.GetString(STUDENT_LASTNAME_INDEX)
            Result.Course = Reader.GetString(STUDENT_COURSE_INDEX)
            Result.YearLevel = Reader.GetString(STUDENT_YEAR_INDEX)
            Result.Section = Reader.GetString(STUDENT_SECTION_INDEX)
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
        Return Result
    End Function
End Class
