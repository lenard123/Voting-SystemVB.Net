
Imports System.Data.OleDb

Public Class Candidate

    Private Shared ReadOnly INDEX_ID = 0
    Private Shared ReadOnly INDEX_STUDENT_ID = 1
    Private Shared ReadOnly INDEX_DESCRIPTION = 2
    Private Shared ReadOnly INDEX_POSITION_ID = 3
    Private Shared ReadOnly INDEX_IMAGE = 4
    Private Shared ReadOnly INDEX_GENDER = 5
    Private Shared ReadOnly INDEX_FULLNAME = 6
    Private Shared ReadOnly INDEX_YEAR = 7

    Private _ID, _StudentID, _PositionID, _Year As Integer
    Private _Description, _Image, _Gender, _Fullname As String

    Public ReadOnly Property Year As Integer
        Get
            Return _Year
        End Get
    End Property

    Public Property Description As String
        Get
            Return _Description
        End Get
        Set(value As String)
            _Description = value
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

    Public ReadOnly Property Fullname As String
        Get
            Return _Fullname
        End Get
    End Property


    Public Shared Function Count(PositionID As Integer)
        Dim Result As Integer = 0
        GetConnection().Open()
        Dim cmd = New OleDbCommand("SELECT Count(*) From Candidate Where position_id=" & PositionID, GetConnection())
        Result = Integer.Parse(cmd.ExecuteScalar())
        GetConnection().Close()
        Return Result
    End Function


End Class
