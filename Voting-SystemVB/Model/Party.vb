
Imports System.Data.OleDb

Public Class Party

    Private Const QUERY_SELECT_ALL = "SELECT * FROM [Party]"
    Private Const QUERY_FIND = "SELECT * FROM [Party] WHERE [Title]=?"
    Private Const QUERY_UPDATE = "UPDATE [Party] SET [Title]=?, [Description]=?, [image_path]=? WHERE [ID]=?"
    Private Const QUERY_INSERT = "INSERT INTO [Party]([Title], [Description], [image_path]) VALUES (?, ?, ?)"
    Private Const QUERY_DELETE_PARTY_MEMBERS = "DELETE FROM [CandidateParty] WHERE [party_id]=?"
    Private Const QUERY_ADD_PARTY_MEMBERS = "INSERT INTO [CandidateParty]([candidate_id], [party_id]) VALUES (?,?)"
    Private Const QUERY_COUNT_ALL = "SELECT COUNT(*) FROM [Party]"

    Public Const LENGTH_ID = 10
    Public Const LENGTH_TITLE = 64
    Public Const LENGTH_DESC = 255
    Public Const LENGTH_IMAGE = 128

    Private Const INDEX_ID = 0
    Private Const INDEX_TITLE = 1
    Private Const INDEX_DESCRIPTION = 2
    Private Const INDEX_IMAGE = 3

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

    'Update Party Information
    Public Function Update(Members As List(Of Integer)) As Boolean
        If Election.HasNotStarted Then
            Dim Result As Boolean = False
            Dim NewImage = GetImage(Image, OriginalImage)
            GetConnection().Open()
            Using Cmd = New OleDbCommand(QUERY_UPDATE, GetConnection())
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Title, LENGTH_TITLE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Description, LENGTH_DESC))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, NewImage, LENGTH_IMAGE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, ID, LENGTH_ID))
                Cmd.Prepare()
                If Cmd.ExecuteNonQuery() <> -1 Then
                    If UpdateMembers(Members, GetConnection()) Then
                        Result = True
                    End If
                End If
            End Using
            GetConnection().Close()
            Return Result
        End If
        Return False
    End Function

    'Register New Party
    Public Function Save(Members As List(Of Integer)) As Boolean
        If Election.HasNotStarted Then
            Dim NewImage = GetImage(Image, "")
            Dim result = False
            GetConnection().Open()
            Using Cmd = New OleDbCommand(QUERY_INSERT, GetConnection())
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Title, LENGTH_TITLE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Description, LENGTH_DESC))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, NewImage, LENGTH_IMAGE))
                Cmd.Prepare()
                If Cmd.ExecuteNonQuery() Then
                    Dim _Party = Find(Title, GetConnection())
                    If _Party.UpdateMembers(Members, GetConnection()) Then
                        result = True
                    End If
                End If
            End Using
            GetConnection().Close()
            Return result
        End If
        Return False
    End Function

    'Update Party Members
    Private Function UpdateMembers(Members As List(Of Integer), conn As OleDbConnection) As Boolean
        Dim result = False
        Using Cmd As New OleDbCommand(QUERY_DELETE_PARTY_MEMBERS, conn)
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _ID, LENGTH_ID))
            Cmd.Prepare()
            If Cmd.ExecuteNonQuery() <> -1 Then
                Using Cmd2 As New OleDbCommand(QUERY_ADD_PARTY_MEMBERS, GetConnection())
                    For Each member In Members
                        Cmd2.Parameters.Clear()
                        Cmd2.Parameters.Add(ConvertToParam(OleDbType.Integer, member, LENGTH_ID))
                        Cmd2.Parameters.Add(ConvertToParam(OleDbType.Integer, _ID, LENGTH_ID))
                        Cmd2.Prepare()
                        Cmd2.ExecuteNonQuery()
                    Next
                    result = True
                End Using
            End If
        End Using
        Return result
    End Function

    'Get All Party
    Public Shared Function GetAll() As List(Of Party)
        Dim Result As New List(Of Party)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_SELECT_ALL, GetConnection())
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
            Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Title, LENGTH_TITLE))
            Cmd.Prepare()
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
            Count = Integer.Parse(Cmd.ExecuteScalar())
        End Using
        GetConnection().Close()
        Return Count
    End Function

End Class
