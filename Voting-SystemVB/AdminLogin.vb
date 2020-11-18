Public Class AdminLogin

    Private Shared Instance As AdminLogin

    Public Shared Function GetInstance() As AdminLogin
        If IsNothing(Instance) Then
            Instance = New AdminLogin
        End If
        Return Instance
    End Function

    Private Sub ButtonVoter_Click(sender As Object, e As EventArgs) Handles ButtonVoter.Click
        Main.LoadControl(VoterLogin.GetInstance())
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
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
