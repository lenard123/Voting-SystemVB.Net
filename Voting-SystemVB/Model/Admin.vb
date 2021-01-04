Imports System.Data.OleDb

Public Class Admin

    Private Id As Integer
    Private _Fullname, _Username, _Password As String
    Private Privileges As New List(Of Integer)

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

    'Privileges
    Public ReadOnly Property CanDoAll As Boolean
        Get
            Return Privileges.Contains(Privilege.PrivilegeType.ALL)
        End Get
    End Property
    Public ReadOnly Property CanStartElection As Boolean
        Get
            Return CanDoAll Or Privileges.Contains(Privilege.PrivilegeType.START_ELECTION)
        End Get
    End Property
    Public ReadOnly Property CanUpdateCandidate As Boolean
        Get
            Return CanDoAll Or Privileges.Contains(Privilege.PrivilegeType.CANDIDATE_UPDATE)
        End Get
    End Property
    Public ReadOnly Property CanRegisterCandidate As Boolean
        Get
            Return CanDoAll Or Privileges.Contains(Privilege.PrivilegeType.CANDIDATE_REGISTER)
        End Get
    End Property
    Public ReadOnly Property CanAddParty
        Get
            Return CanDoAll Or Privileges.Contains(Privilege.PrivilegeType.PARTY_ADD)
        End Get
    End Property
    Public ReadOnly Property CanUpdateParty
        Get
            Return CanDoAll Or Privileges.Contains(Privilege.PrivilegeType.PARTY_UPDATE)
        End Get
    End Property
    Public ReadOnly Property CanUpdateStudent
        Get
            Return CanDoAll Or Privileges.Contains(Privilege.PrivilegeType.VOTERS_UPDATE)
        End Get
    End Property
    Public ReadOnly Property CanAddStudent
        Get
            Return CanDoAll Or Privileges.Contains(Privilege.PrivilegeType.VOTERS_ADD)
        End Get
    End Property
    Public ReadOnly Property CanAddAdmin
        Get
            Return CanDoAll
        End Get
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal Id As Integer, ByVal Password As String)
        Me.Id = Id
        Me._Password = Password
    End Sub

    ''' <summary>
    ''' Verify Password
    ''' </summary>
    ''' <param name="Password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ComparePassword(ByVal Password As String) As Boolean
        Return Me._Password.Equals(Password)
    End Function

    ''' <summary>
    ''' Update Admin Information
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Update() As Boolean
        Dim Res As Boolean = False
        Using Cmd As New OleDbCommand(QUERY_UPDATE, GetConnection())
            BindParameters(Cmd, Username, Fullname, Password, Id)

            GetConnection().Open()
            Res = Cmd.ExecuteNonQuery() <> -1
            GetConnection().Close()
        End Using
        Return Res
    End Function

    ''' <summary>
    ''' Add new Admin
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Save(Privileges As List(Of Integer)) As Boolean
        Dim Res As Boolean = False
        Using Cmd As New OleDbCommand(QUERY_INSERT, GetConnection())
            BindParameters(Cmd, Fullname, Username, Password)
            GetConnection().Open()
            Res = Cmd.ExecuteNonQuery() <> -1
            GetConnection().Close()
        End Using
        Return UpdatePrivileges(Username, Privileges)
    End Function

    Public Shared Function UpdatePrivileges(Username As String, Privileges As List(Of Integer)) As Boolean
        Dim sAdmin = Admin.Find(Username)
        Using Cmd As New OleDbCommand(QUERY_REMOVE_PRIVILEGE, GetConnection())
            BindParameters(Cmd, sAdmin.Id)
            GetConnection().Open()
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = QUERY_ADD_PRIVILEGE
            For Each iPrivilege In Privileges
                BindParameters(Cmd, sAdmin.Id, iPrivilege)
                Cmd.ExecuteNonQuery()
            Next
            GetConnection().Close()
        End Using
        Return True
    End Function

    ''' <summary>
    ''' Fetch the users privileges
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FetchPrivilege()
        Privileges.Clear()
        Using Cmd = New OleDbCommand(QUERY_FETCH_PRIVILEGE, GetConnection())
            BindParameters(Cmd, Id)
            GetConnection().Open()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Privileges.Add(Reader.GetInt32(2))
                End While
            End Using
            GetConnection().Close()
        End Using
    End Sub

    ''' <summary>
    ''' Check if the given username exists in the database
    ''' </summary>
    ''' <param name="Username"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function IsExists(Username As String) As Boolean
        Dim Result As Boolean
        Using Cmd = New OleDbCommand(QUERY_ISEXISTS, GetConnection())
            BindParameters(Cmd, Username)
            GetConnection().Open() 'Open Connection
            Result = Integer.Parse(Cmd.ExecuteScalar()) > 0 'Evaluate Result
            GetConnection().Close() 'Close Connection
        End Using
        Return Result
    End Function

    ''' <summary>
    ''' Find Admin using the given username
    ''' </summary>
    ''' <param name="Username"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Find(ByVal Username As String) As Admin
        'Throw Exception if the given Username Not Found
        If Not IsExists(Username) Then Throw New AdminNotExistsException

        Dim Result As Admin = Nothing
        Using Cmd = New OleDbCommand(QUERY_SELECT_BY_USERNAME, GetConnection())
            BindParameters(Cmd, Username)
            GetConnection().Open()
            Using Reader = Cmd.ExecuteReader()
                If Reader.Read Then
                    Result = GetAdmin(Reader)
                End If
            End Using
            GetConnection().Close()
        End Using
        Return Result
    End Function


    ''' <summary>
    ''' Setting Current user if the username and password match
    ''' </summary>
    ''' <param name="Username"></param>
    ''' <param name="Password"></param>
    ''' <remarks></remarks>
    Public Shared Sub Login(Username As String, Password As String)
        'Get the Admin by given username
        Dim checkAdmin = Admin.Find(Username)

        If Not checkAdmin.Username.Equals(Username) Then Throw New Exception("Invalid Username")

        'throw exception if password not match
        If Not checkAdmin.ComparePassword(Password) Then Throw New InvalidPasswordException

        'set current login user
        SetCurrentUser(checkAdmin)
    End Sub


    ''' <summary>
    ''' Convert Reader to Admin Model
    ''' </summary>
    ''' <param name="Reader"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function GetAdmin(Reader As OleDbDataReader) As Admin
        Dim Result As Admin = New Admin(Reader.GetInt32(INDEX_ID), Reader.GetString(INDEX_PASSWORD))
        Result.Fullname = Reader.GetString(INDEX_FULLNAME)
        Result.Username = Reader.GetString(INDEX_USERNAME)
        Return Result
    End Function

    ''' <summary>
    ''' Get the current user
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCurrentUser() As Admin
        Return _CurrentUser
    End Function

    ''' <summary>
    ''' Set Current User
    ''' </summary>
    ''' <param name="CUser"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetCurrentUser(CUser As Admin)
        _CurrentUser = CUser
        If Not IsNothing(CUser) Then _CurrentUser.FetchPrivilege()
    End Sub

    ''' <summary>
    ''' Refresh the data of  Current User
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function RefreshCurrentUser() As Admin
        If Not IsNothing(_CurrentUser) Then
            SetCurrentUser(Admin.Find(_CurrentUser.Username))
        End If
        Return _CurrentUser
    End Function


    'Constant Properties
    Private Const QUERY_SELECT_BY_USERNAME = "SELECT * FROM [Admin] WHERE [username]=?"
    Private Const QUERY_UPDATE = "UPDATE [Admin] SET [username]=?, [fullname]=?, [password]=? WHERE [ID]=?"
    Private Const QUERY_REMOVE_PRIVILEGE = "DELETE FROM [AdminPrivileges] WHERE [admin_id]=?"
    Private Const QUERY_ADD_PRIVILEGE = "INSERT INTO [AdminPrivileges]([admin_id],[privilege_id]) VALUES(?,?)"
    Private Const QUERY_INSERT = "INSERT INTO [Admin]([fullname], [username], [password]) VALUES(?,?,?)"
    Private Const QUERY_ISEXISTS = "SELECT COUNT(*) FROM [Admin] WHERE [username]=?"
    Private Const QUERY_FETCH_PRIVILEGE = "SELECT * FROM [AdminPrivileges] WHERE [admin_id]=?"

    Public Const INDEX_ID = 0
    Public Const INDEX_FULLNAME = 1
    Public Const INDEX_USERNAME = 2
    Public Const INDEX_PASSWORD = 3

End Class
