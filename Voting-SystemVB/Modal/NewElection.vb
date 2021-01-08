Public Class NewElection

    Private Shared Popup As ModalPopup

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup
        Popup.Init(New NewElection)
        Popup.ShowPopup()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Popup.ClosePopup()
    End Sub
End Class
