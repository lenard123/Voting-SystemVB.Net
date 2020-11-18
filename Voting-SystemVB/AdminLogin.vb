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
        If (TextPassword.UseSystemPasswordChar) Then
            ButtonVisibility.Image = My.Resources.hide
            TextPassword.UseSystemPasswordChar = False
        Else
            ButtonVisibility.Image = My.Resources.show
            TextPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        Dim ValidationError As String = ""
        Dim StudentID = TextUsername.Text
        Dim Password = TextPassword.Text

        If (StudentID.Length.Equals(0) Or Password.Length.Equals(0)) Then
            ValidationError += "Username and Password Field is Required " & Environment.NewLine
        Else
            If Not (StudentID.Length < 6) Then
                ValidationError += "Username must have atleast 6 characters" & Environment.NewLine
            End If
            If Password.Length < 6 Then
                ValidationError += "Password field must have atleast 6 characters" & Environment.NewLine
            End If
        End If
        If ValidationError.Length > 0 Then
            MessageBox.Show(ValidationError)
        End If
        Return ValidationError.Length.Equals(0)
    End Function
End Class
