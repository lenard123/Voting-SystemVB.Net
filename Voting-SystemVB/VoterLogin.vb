Public Class VoterLogin

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub

    Private Sub ButtonVisibility_Click(sender As Object, e As EventArgs) Handles ButtonVisibility.Click
        If (TextPin.UseSystemPasswordChar) Then
            ButtonVisibility.Image = My.Resources.hide
            TextPin.UseSystemPasswordChar = False
        Else
            ButtonVisibility.Image = My.Resources.show
            TextPin.UseSystemPasswordChar = True
        End If
    End Sub
End Class
