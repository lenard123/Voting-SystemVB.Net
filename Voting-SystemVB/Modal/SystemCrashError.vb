Public Class SystemCrashError

    Dim Modal As ModalPopup

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(ByVal Title As String)
        ' This call is required by the designer.
        InitializeComponent()
        Me.LabelTitle.Text = Title
    End Sub

    Public Sub New(ByVal Title As String, ByVal Description As String)
        ' This call is required by the designer.
        InitializeComponent()
        Me.LabelTitle.Text = Title
        Me.LabelDescription.Text = Description
    End Sub

    Public Sub SetIcon(img As Image)
        Icon.Image = img
    End Sub

    Public Sub ShowPopup()
        Modal = New ModalPopup()
        Modal.Init(Me)
        Modal.ShowPopup()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Modal.ClosePopup()
        Application.Exit()
    End Sub
End Class
