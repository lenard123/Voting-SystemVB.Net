Public Class AdminLogin

    Implements MainControl

    'Have 1 Global Instance for Whole Application
    Private Shared Instance As AdminLogin

    'Return AdminLogin Instance
    Public Shared Function GetInstance() As AdminLogin
        If IsNothing(Instance) Then
            Instance = New AdminLogin
        End If
        Return Instance
    End Function

    'Goto Voters Login
    Private Sub ButtonVoter_Click(sender As Object, e As EventArgs) Handles ButtonVoter.Click
        Main.LoadControl(VoterLogin.GetInstance())
    End Sub

    'Close Program
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub

    'Show/Hide Password
    Private Sub ButtonVisibility_Click(sender As Object, e As EventArgs) Handles ButtonVisibility.Click
        If (TextPassword.UseSystemPasswordChar) Then
            ButtonVisibility.Image = My.Resources.hide
            TextPassword.UseSystemPasswordChar = False
        Else
            ButtonVisibility.Image = My.Resources.show
            TextPassword.UseSystemPasswordChar = True
        End If
    End Sub

    'Login
    Private Async Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If ValidateForm() Then
            Dim loadingAlert = Alert.ShowAlert("Logging in, please wait", Alert.AlertType.Info)
            Dim Result = Await Admin.FindAsync(TextUsername.Text)
            loadingAlert.CloseAlert()
            If IsNothing(Result) Then
                Alert.ShowAlert("Invalid username", Alert.AlertType.Error)
            Else
                If Not Result.ComparePassword(TextPassword.Text) Then
                    Alert.ShowAlert("Wrong username or password", Alert.AlertType.Error)
                Else
                    Alert.ShowAlert("Login Successfully", Alert.AlertType.Success)
                    Main.LoadControl(AdminPanel.GetInstance().SetUser(Result))
                End If
            End If

        End If
    End Sub

    'Validate Inputs
    Private Function ValidateForm() As Boolean
        Dim ValidationError As String = ""
        Dim StudentID = TextUsername.Text.Length
        Dim Password = TextPassword.Text.Length

        If (StudentID < 6) Then
            ValidationError += "- Username must have atleast 6 characters" & Environment.NewLine
            PanelUsernameStatus.BackColor = Color.Red
        End If
        If Password < 6 Then
            ValidationError += "- Password field must have atleast 6 characters" & Environment.NewLine
            PanelPasswordStatus.BackColor = Color.Red
        End If
        If ValidationError.Length > 0 Then
            Dim ve As New ValidationError(ValidationError)
            ve.ShowPopup()
        End If
        Return ValidationError.Length.Equals(0)
    End Function



    'Focus Indicators
    Private Sub TextUsername_Enter(sender As Object, e As EventArgs) Handles TextUsername.Enter
        PanelUsernameStatus.BackColor = Color.FromArgb(255, 164, 91)
    End Sub

    Private Sub TextPassword_Enter(sender As Object, e As EventArgs) Handles TextPassword.Enter
        PanelPasswordStatus.BackColor = Color.FromArgb(255, 164, 91)
    End Sub

    Private Sub TextUsername_Leave(sender As Object, e As EventArgs) Handles TextUsername.Leave
        PanelUsernameStatus.BackColor = Color.Transparent
    End Sub

    Private Sub TextPassword_Leave(sender As Object, e As EventArgs) Handles TextPassword.Leave
        PanelPasswordStatus.BackColor = Color.Transparent
    End Sub

    Public Sub RefreshControl() Implements MainControl.RefreshControl
        TextPassword.Clear()
        Main.RestoreWindowState()
    End Sub

End Class
