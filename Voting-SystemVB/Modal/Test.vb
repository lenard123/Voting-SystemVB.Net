Public Class Test

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New Alert()
        x.setAlert("Test", Alert.AlertType.Info)
    End Sub
End Class
