Imports System.Data.OleDb

Public Class Admin

    Private Shared ReadOnly QUERY_SELECT_BY_USERNAME = "SELECT * FROM [Admin] WHERE [username]=?"
    Private Shared ReadOnly QUERY_UPDATE = "UPDATE [Admin] SET [username]=?, [fullname]=? WHERE [ID]=?"
    Private Shared ReadOnly QUERY_INSERT = "INSERT INTO [Admin]([fullname], [username], [password]) VALUES(?,?,?)"

    Public Shared ReadOnly ADMIN_ID_LENGTH = 10
    Public Shared ReadOnly ADMIN_USERNAME_LENGTH = 40
    Public Shared ReadOnly ADMIN_FULLNAME_LENGTH = 40
    Public Shared ReadOnly ADMIN_PASSWORD_LENGTH = 40

    Public Shared ReadOnly ADMIN_ID_INDEX = 0
    Public Shared ReadOnly ADMIN_FULLNAME_INDEX = 1
    Public Shared ReadOnly ADMIN_USERNAME_INDEX = 2
    Public Shared ReadOnly ADMIN_PASSWORD_INDEX = 3

    Private Id As Integer
    Private _Fullname, _Username, _Password As String

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
    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

    Public Sub New(ByVal Id As Integer, ByVal Password As String)
        Me.Id = Id
        Me._Password = Password
    End Sub

    'Verify Password
    Public Function ComparePassword(ByVal Password As String)
        Return Me._Password.Equals(Password)
    End Function

    Public Function Update() As Boolean
        Dim Res As Boolean = False
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_UPDATE, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Me.Username, ADMIN_USERNAME_LENGTH))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Me.Fullname, ADMIN_FULLNAME_LENGTH))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Me.Id, ADMIN_ID_LENGTH))
            Cmd.Prepare()
            Res = Cmd.ExecuteNonQuery() <> -1
        End Using
        GetConnection().Close()
        Return Res
    End Function

    Public Function Save() As Boolean
        Dim Res As Boolean = False
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_INSERT, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Me._Fullname, ADMIN_FULLNAME_LENGTH))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Me._Username, ADMIN_USERNAME_LENGTH))
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Me._Password, ADMIN_PASSWORD_LENGTH))
            Cmd.Prepare()
            Res = Cmd.ExecuteNonQuery() <> -1
        End Using
        GetConnection().Close()
        Return Res
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

    'Refresh Current User
    Public Shared Function RefreshCurrentUser() As Admin
        If Not IsNothing(_CurrentUser) Then
            _CurrentUser = Admin.Find(_CurrentUser.Username)
        End If
        Return _CurrentUser
    End Function
End Class
