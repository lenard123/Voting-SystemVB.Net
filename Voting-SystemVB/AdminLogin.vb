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
End Class
