Public Class AdminLogin

    Implements MainControl

    'Have 1 Global Instance for Whole Application
    Private Shared Instance As AdminLogin

    Private LoadingAlert As Alert

    'Return AdminLogin Instance
    Public Shared Function GetInstance() As AdminLogin
        If IsNothing(Instance) Then
            Instance = New AdminLogin
        End If
        Return Instance
    End Function

    'Goto Voters Login
    Private Sub ButtonVoter_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Main.LoadControl(VoterLogin.GetInstance())
    End Sub

    'Show/Hide Password
    Private Sub ButtonVisibility_Click(sender As Object, e As EventArgs) Handles Guna2Button1.CheckedChanged
        TextPassword.UseSystemPasswordChar = Not TextPassword.UseSystemPasswordChar
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
    Private Sub Field_Enter(sender As Control, e As EventArgs) Handles TextUsername.Enter, TextPassword.Enter
        If sender.Equals(TextUsername) Then sender = PanelUsernameStatus
        If sender.Equals(TextPassword) Then sender = PanelPasswordStatus
        sender.BackColor = Color.FromArgb(255, 164, 91)
    End Sub
    Private Sub Field_Leave(sender As Control, e As EventArgs) Handles TextUsername.Leave, TextPassword.Leave
        If sender.Equals(TextUsername) Then sender = PanelUsernameStatus
        If sender.Equals(TextPassword) Then sender = PanelPasswordStatus
        sender.BackColor = Color.Transparent
    End Sub

    Public Sub RefreshControl() Implements MainControl.RefreshControl
        TextPassword.Clear()
    End Sub


    'Login
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If ValidateForm() Then
            If Not BackgroundWorkerLogin.IsBusy Then
                LoadingAlert = Alert.ShowAlert("Logging in, please wait", Alert.AlertType.Info, False)
                BackgroundWorkerLogin.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub BackgroundWorkerLogin_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerLogin.DoWork
        Try
            Admin.Login(TextUsername.Text, TextPassword.Text)
        Catch ex As Exception
            e.Result = ex
        End Try
    End Sub

    Private Sub BackgroundWorkerLogin_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerLogin.RunWorkerCompleted
        LoadingAlert.CloseAlert()

        If TypeOf e.Result Is Exception Then
            Alert.ShowAlert(DirectCast(e.Result, Exception).Message, Alert.AlertType.Error)
        Else
            Alert.ShowAlert("Login Successfully", Alert.AlertType.Success)
            Main.LoadControl(AdminPanel.GetInstance())
        End If
    End Sub

    Private Sub btnFAQS_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnFAQS.LinkClicked
        FAQs.ShowFAQ()
    End Sub
End Class
