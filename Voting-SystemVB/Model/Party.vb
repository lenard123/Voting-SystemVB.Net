
Imports System.Data.OleDb

Public Class Party

    Private _ID As Integer
    Private _Title, _Description, _Image, _OriginalImage As String

    Public ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property
    ReadOnly Property OriginalImage As String
        Get
            If IsNothing(_OriginalImage) Then
                Return ""
            End If
            Return _OriginalImage
        End Get
    End Property
    Public Property Image As String
        Get
            If IsNothing(_Image) Then
                Return ""
            End If
            Return _Image
        End Get
        Set(value As String)
            _Image = value
        End Set
    End Property
    Public Property Description As String
        Get
            If IsNothing(_Description) Then Return ""
            Return _Description
        End Get
        Set(value As String)
            _Description = value
        End Set
    End Property
    Public Property Title As String
        Get
            Return _Title.ToUpper
        End Get
        Set(value As String)
            _Title = value
        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(ID As Integer)
        Me._ID = ID
    End Sub

    Public Sub SetOriginalImage(Image As String)
        _OriginalImage = Image
    End Sub

    ''' <summary>
    ''' Update Party Information
    ''' </summary>
    ''' <param name="Members"></param>
    ''' <remarks></remarks>
    Public Sub Update(Members As List(Of Integer))

        If Not Election.HasNotStarted() Then Throw New ElectionAlreadyStartedException

        If Not Admin.GetCurrentUser().CanUpdateParty() Then Throw New InvalidPrivilegeException

        Dim NewImage = GetImage(Image, OriginalImage)
        Using Cmd = New OleDbCommand(QUERY_UPDATE, GetConnection())
            BindParameters(Cmd, Title, Description, NewImage, ID)

            GetConnection().Open()
            If Cmd.ExecuteNonQuery() <> -1 Then
                UpdateMembers(Members, GetConnection())
            End If
            GetConnection().Close()
        End Using
    End Sub

    ''' <summary>
    ''' Register New Party
    ''' </summary>
    ''' <param name="Members"></param>
    ''' <remarks></remarks>
    Public Sub Save(Members As List(Of Integer))

        If Not Election.HasNotStarted Then Throw New ElectionAlreadyStartedException

        If Not Admin.GetCurrentUser().CanAddParty Then Throw New InvalidPrivilegeException

        Dim NewImage = GetImage(Image, "")
        Using Cmd = New OleDbCommand(QUERY_INSERT, GetConnection())
            BindParameters(Cmd, Title, Description, NewImage, Election.GetCurrentId())
            GetConnection().Open()
            If Cmd.ExecuteNonQuery() Then
                Dim _Party = Find(Title, GetConnection())
                _Party.UpdateMembers(Members, GetConnection())
            End If
            GetConnection().Close()
        End Using
    End Sub

    ''' <summary>
    ''' Update Party Representatives
    ''' </summary>
    ''' <param name="Members"></param>
    ''' <param name="conn"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function UpdateMembers(Members As List(Of Integer), conn As OleDbConnection) As Boolean
        Dim result = False
        Using Cmd As New OleDbCommand(QUERY_DELETE_PARTY_MEMBERS, conn)
            BindParameters(Cmd, _ID)
            If Cmd.ExecuteNonQuery() <> -1 Then
                Using Cmd2 As New OleDbCommand(QUERY_ADD_PARTY_MEMBERS, GetConnection())
                    For Each member In Members
                        BindParameters(Cmd2, member, _ID)
                        Cmd2.ExecuteNonQuery()
                    Next
                    result = True
                End Using
            End If
        End Using
        Return result
    End Function

    ''' <summary>
    ''' Get All Party
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetAll() As List(Of Party)
        Return GetAll(Election.GetCurrentId())
    End Function
    Public Shared Function GetAll(ElectionId As Integer) As List(Of Party)
        Dim Result As New List(Of Party)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_SELECT_ALL, GetConnection())
            BindParameters(Cmd, ElectionId)
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Result.Add(GetParty(Reader))
                End While
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function

    'Upload Party Image
    Private Shared Function GetImage(Source As String, _Default As String) As String

        Dim Dir = Election.GetImageDirectory()
        Dim FileName = "party-" & Date.Now().Ticks & ".jpg"
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
            Util.DeleteFile(_Default)
            Return ""
        Else
            Util.DeleteFile(_Default)
            Return Util.Upload(Dir, FileName, Source)
        End If
    End Function

    'Find Party Using Title
    Public Shared Function Find(Title As String) As Party
        GetConnection().Open()
        Dim res = Find(Title, GetConnection())
        GetConnection().Close()
        Return res
    End Function
    Public Shared Function Find(Title As String, conn As OleDbConnection) As Party
        Dim res As Party = Nothing
        Using Cmd As New OleDbCommand(QUERY_FIND, conn)
            BindParameters(Cmd, Title, Election.GetCurrentId())
            Using Reader = Cmd.ExecuteReader()
                If Reader.Read() Then
                    res = GetParty(Reader)
                End If
            End Using
        End Using
        Return res
    End Function

    'Convert Reader into Party Model
    Private Shared Function GetParty(Reader As OleDbDataReader) As Party
        Dim ID As Integer
        Dim Title As String
        Dim Description As String = Nothing
        Dim Image As String = Nothing

        ID = Reader.GetInt32(INDEX_ID)
        Title = Reader.GetString(INDEX_TITLE)
        If Not Reader.IsDBNull(INDEX_DESCRIPTION) Then Description = Reader.GetString(INDEX_DESCRIPTION)
        If Not Reader.IsDBNull(INDEX_IMAGE) Then Image = Reader.GetString(INDEX_IMAGE)

        Dim Result As New Party(ID)
        Result.SetOriginalImage(Image)
        Result.Title = Title
        Result.Description = Description
        Result.Image = Image
        Return Result
    End Function

    Public Shared Function CountAll() As Integer
        Dim Count = 0
        GetConnection().Open()
        Using Cmd = New OleDbCommand(QUERY_COUNT_ALL, GetConnection())
            BindParameters(Cmd, Election.GetCurrentId())
            Count = Integer.Parse(Cmd.ExecuteScalar())
        End Using
        GetConnection().Close()
        Return Count
    End Function

    '
    ' Constant Properties
    '
    Private Const QUERY_SELECT_ALL = "SELECT * FROM [Party] WHERE [election_id]=?"
    Private Const QUERY_FIND = "SELECT * FROM [Party] WHERE [Title]=? AND [election_id] =?"
    Private Const QUERY_UPDATE = "UPDATE [Party] SET [Title]=?, [Description]=?, [image_path]=? WHERE [ID]=?"
    Private Const QUERY_INSERT = "INSERT INTO [Party]([Title], [Description], [image_path], [election_id]) VALUES (?, ?, ?, ?)"
    Private Const QUERY_DELETE_PARTY_MEMBERS = "DELETE FROM [CandidateParty] WHERE [party_id]=?"
    Private Const QUERY_ADD_PARTY_MEMBERS = "INSERT INTO [CandidateParty]([candidate_id], [party_id]) VALUES (?,?)"
    Private Const QUERY_COUNT_ALL = "SELECT COUNT(*) FROM [Party] WHERE [election_id]=?"

    Private Const INDEX_ID = 0
    Private Const INDEX_TITLE = 1
    Private Const INDEX_DESCRIPTION = 2
    Private Const INDEX_IMAGE = 3
End Class
