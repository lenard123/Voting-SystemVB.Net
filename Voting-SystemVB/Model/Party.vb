
Imports System.Data.OleDb

Public Class Party

    Public Shared ReadOnly LENGTH_ID = 10

    Private Shared ReadOnly INDEX_ID = 0
    Private Shared ReadOnly INDEX_TITLE = 1
    Private Shared ReadOnly INDEX_DESCRIPTION = 2
    Private Shared ReadOnly INDEX_IMAGE = 3

    Private _ID As Integer
    Private _Title, _Description, _Image As String

    Public Property Image As String
        Get
            Return _Image
        End Get
        Set(value As String)
            _Image = value
        End Set
    End Property

    Public Property Description As String
        Get
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

    Public Sub New(ID As Integer)
        Me._ID = ID
    End Sub

    Public Function Save() As Boolean
        Return Save(New Hashtable())
    End Function

    Public Function Save(Member As Hashtable) As Boolean

        Return False
    End Function

    Public Shared Function GetAll() As List(Of Party)
        Dim Result As New List(Of Party)
        GetConnection().Open()
        Using Cmd As New OleDbCommand("SELECT * FROM [Party]", GetConnection())
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
        Dim Description As String
        Dim Image As String

        ID = Reader.GetInt32(INDEX_ID)
        Title = Reader.GetString(INDEX_TITLE)
        If Not Reader.IsDBNull(INDEX_DESCRIPTION) Then Description = Reader.GetString(INDEX_DESCRIPTION)
        If Not Reader.IsDBNull(INDEX_IMAGE) Then Image = Reader.GetString(INDEX_IMAGE)

        Dim Result As New Party(ID)
        Result.Title = Title
        Result.Description = Description
        Result.Image = Image
        Return Result
    End Function

End Class
