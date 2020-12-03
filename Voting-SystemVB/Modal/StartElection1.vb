Public Class StartElection1

    Private Shared Popup As ModalPopup

    Dim DateNow As Date

    Private Sub StartElection1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateNow = Date.Now()
        TextName.Text = DateNow.Year & " Student Council Election"
    End Sub

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup
        Popup.Init(New StartElection1)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Popup.ClosePopup()
    End Sub
End Class
