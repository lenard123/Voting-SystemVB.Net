Public Class ValidationError

    Private Popup As ModalPopup

    Public Sub New(ByVal Errors As String)
        ' This call is required by the designer.
        InitializeComponent()
        LabelErrors.Text = Errors
    End Sub

    Public Sub New(ByVal Errors As String, ByVal Title As String)
        ' This call is required by the designer.
        InitializeComponent()
        LabelErrors.Text = Errors
        SetTitle(Title)
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(Errors As List(Of String))
        ' This call is required by the designer.
        InitializeComponent()

        For Each _Error In Errors
            LabelErrors.Text += "- " & _Error & Environment.NewLine
        Next

    End Sub

    Public Sub ShowPopup()
        Popup = New ModalPopup()
        Popup.Init(Me)
        Popup.ShowPopup()
    End Sub

    Public Shared Sub Alert(ByVal Errors As String, ByVal Title As String)
        Dim ve As New ValidationError(Errors, Title)
        ve.ShowPopup()
    End Sub

    Public Sub SetTitle(ByVal Title As String)
        LabelTitle.Text = Title
    End Sub


    Private Sub ClosePopup(sender As Object, e As EventArgs) Handles Button1.Click
        Popup.ClosePopup()
    End Sub
End Class
