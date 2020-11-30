Imports System.Data.OleDb

Public Class Admin

    Private Shared ReadOnly QUERY_SELECT_BY_USERNAME = "SELECT * FROM [Admin] WHERE [username]=?"

    Public Shared ReadOnly ADMIN_USERNAME_LENGTH = 40

    Public Shared ReadOnly ADMIN_ID_INDEX = 0
    Public Shared ReadOnly ADMIN_FULLNAME_INDEX = 1
    Public Shared ReadOnly ADMIN_USERNAME_INDEX = 2
    Public Shared ReadOnly ADMIN_PASSWORD_INDEX = 3

    Private Id As Integer
    Private _Fullname, _Username, Password As String

    Private Shared _CurrentUser As Admin = Nothing

    Public Property Fullname As String
        Get
            Return _Fullname
        End Get
        Set(value As String)
            _Fullname = value
        End Set
    End Property
    Public Property Username As String
        Get
            Return _Username
        End Get
        Set(value As String)
            _Username = value
        End Set
    End Property

    Public Sub New(ByVal Id As Integer, ByVal Password As String)
        Me.Id = Id
        Me.Password = Password
    End Sub

    'Verify Password
    Public Function ComparePassword(ByVal Password As String)
        Return Me.Password.Equals(Password)
    End Function

    'Get Specific admin using their username
    Public Shared Async Function FindAsync(Username As String) As Task(Of Admin)
        Dim Result As Admin = Nothing
        Await GetConnection().OpenAsync()
        Using Cmd = New OleDbCommand(QUERY_SELECT_BY_USERNAME, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Username, ADMIN_USERNAME_LENGTH))
            Cmd.Prepare()
            Using Reader = Await Cmd.ExecuteReaderAsync()
                If Reader.Read Then
                    Result = GetAdmin(Reader)
                End If
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function
    Public Shared Function Find(ByVal Username As String) As Admin
        Dim Result As Admin = Nothing
        GetConnection().Open()
        Using Cmd = New OleDbCommand(QUERY_SELECT_BY_USERNAME, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Username, ADMIN_USERNAME_LENGTH))
            Cmd.Prepare()
            Using Reader = Cmd.ExecuteReader()
                If Reader.Read Then
                    Result = GetAdmin(Reader)
                End If
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function

    'Convert Reader to Admin Model
    Private Shared Function GetAdmin(Reader As OleDbDataReader) As Admin
        Dim Result As Admin = New Admin(Reader.GetInt32(ADMIN_ID_INDEX), Reader.GetString(ADMIN_PASSWORD_INDEX))
        Result.Fullname = Reader.GetString(ADMIN_FULLNAME_INDEX)
        Result.Username = Reader.GetString(ADMIN_USERNAME_INDEX)
        Return Result
    End Function

    'Get Current User
    Public Shared Function GetCurrentUser() As Admin
        Return _CurrentUser
    End Function

    'Set Current User
    Public Shared Sub SetCurrentUser(CUser As Admin)
        _CurrentUser = CUser
    End Sub
End Class
