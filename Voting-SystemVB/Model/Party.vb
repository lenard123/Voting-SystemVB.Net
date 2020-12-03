
Imports System.Data.OleDb

Public Class Party

    Private Shared ReadOnly QUERY_SELECT_ALL = "SELECT * FROM [Party]"

    Public Shared ReadOnly LENGTH_ID = 10
    Public Shared ReadOnly LENGTH_TITLE = 64
    Public Shared ReadOnly LENGTH_DESC = 255
    Public Shared ReadOnly LENGTH_IMAGE = 128

    Private Shared ReadOnly INDEX_ID = 0
    Private Shared ReadOnly INDEX_TITLE = 1
    Private Shared ReadOnly INDEX_DESCRIPTION = 2
    Private Shared ReadOnly INDEX_IMAGE = 3

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
            Return _Title
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

    Public Shared Function Find(Title As String) As Party
        GetConnection().Open()
        Dim res = Find(Title, GetConnection())
        GetConnection().Close()
        Return res
    End Function
    Public Shared Function Find(Title As String, conn As OleDbConnection) As Party
        Dim res As Party = Nothing
        Using Cmd As New OleDbCommand("SELECT * FROM [Party] WHERE [Title]=?", conn)
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

    Public Function Update(Members As List(Of Integer)) As Boolean
        If Election.HasNotStarted Then
            Dim Image = OriginalImage
            Dim Dirname = "election-" & Election.GetCurrentElection().Id
            Dim Filename = "party-" & ID & ".jpg"
            Dim Res = False
            If Me.Image.Equals("") And Not OriginalImage.Equals("") Then
                'No image - then delete old image
                Util.DeleteFile(OriginalImage)
                Image = ""
            ElseIf Not Me.Image.Equals("") And Not Me.Image.Equals(OriginalImage) Then
                'Replace Image
                If Not OriginalImage.Equals("images\" & Dirname & "\" & Filename) Then
                    Util.DeleteFile(OriginalImage)
                End If
                Image = Util.Upload(Dirname, Filename, Me.Image)
            End If
            GetConnection().Open()
            Using Cmd = New OleDbCommand("UPDATE [Party] SET [Title]=?, [Description]=?, [image_path]=? WHERE [ID]=?", GetConnection())
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Title, LENGTH_TITLE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Description, LENGTH_DESC))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Image, LENGTH_IMAGE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, ID, LENGTH_ID))
                Cmd.Prepare()
                If Cmd.ExecuteNonQuery() <> -1 Then
                    If UpdateMembers(Members, GetConnection()) Then
                        Res = True
                    End If
                End If
            End Using
            GetConnection().Close()
            Return Res
        End If
        Return False
    End Function

    Public Function Save(Members As List(Of Integer)) As Boolean
        If Election.HasNotStarted Then
            Dim Dir = "election-" & Election.GetCurrentElection().Id
            Dim filename = "party-" & Date.Now().Ticks & ".jpg"
            Dim Image As String = ""
            If Not IsNothing(Me._Image) Or Me.Image <> "" Then Image = Util.Upload(Dir, filename, Me.Image)
            Dim Query = "INSERT INTO [Party]([Title], [Description], [image_path]) VALUES (?, ?, ?)"
            Dim result = False
            GetConnection().Open()
            Using Cmd = New OleDbCommand(Query, GetConnection())
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Title, LENGTH_TITLE))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Description, LENGTH_DESC))
                Cmd.Parameters.Add(ConvertToParam(OleDbType.VarChar, Image, LENGTH_IMAGE))
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

    Public Function UpdateMembers(Members As List(Of Integer), conn As OleDbConnection) As Boolean
        Dim result = False
        Using Cmd As New OleDbCommand("DELETE FROM [CandidateParty] WHERE [party_id]=?", conn)
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, _ID, LENGTH_ID))
            Cmd.Prepare()
            If Cmd.ExecuteNonQuery() <> -1 Then
                Dim Cmd2 As New OleDbCommand("INSERT INTO [CandidateParty]([candidate_id], [party_id]) VALUES (?,?)", GetConnection())
                For Each member In Members
                    Cmd2.Parameters.Clear()
                    Cmd2.Parameters.Add(ConvertToParam(OleDbType.Integer, member, LENGTH_ID))
                    Cmd2.Parameters.Add(ConvertToParam(OleDbType.Integer, _ID, LENGTH_ID))
                    Cmd2.Prepare()
                    Cmd2.ExecuteNonQuery()
                Next
                result = True
            End If
        End Using
        Return result
    End Function

   
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

End Class
