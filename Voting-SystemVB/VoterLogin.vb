Public Class VoterLogin

    Implements MainControl

    Private Shared Instance As VoterLogin

    Public Shared Function GetInstance() As VoterLogin
        If IsNothing(Instance) Then
            Instance = New VoterLogin()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    Dim LoadingAlert As Alert

    'Toggle password Visibility
    Private Sub ButtonVisibility_Click(sender As Object, e As EventArgs) Handles Guna2Button1.CheckedChanged
        'Invert State
        TextPin.UseSystemPasswordChar = Not TextPin.UseSystemPasswordChar
    End Sub

    'Go To Admin Login
    Private Sub ButtonAdmin_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Main.LoadControl(AdminLogin.GetInstance())
    End Sub

    Public Sub RefreshControl() Implements MainControl.RefreshControl
        TextPin.Clear()
    End Sub

    'VALIDATORS
    Private Function ValidateForm() As Boolean
        Dim _ValidationError As String = ""
        Dim StudentID = TextStudentId.Text
        Dim Password = TextPin.Text

        If (StudentID.Length.Equals(0) Or Password.Length.Equals(0)) Then
            _ValidationError += "- Student ID and Password Field is Required " & Environment.NewLine
            If StudentID.Length.Equals(0) Then
                PanelStudentIdStatus.BackColor = Color.Red
            End If
            If Password.Length.Equals(0) Then
                PanelPasswordStatus.BackColor = Color.Red
            End If
        Else
            If Not (StudentID.Length.Equals(10)) Then
                _ValidationError += "- Student ID must have 10 characters" & Environment.NewLine
                PanelStudentIdStatus.BackColor = Color.Red
            End If
            If Password.Length < 6 Then
                _ValidationError += "- Password field must have atleast 6 characters" & Environment.NewLine
                PanelPasswordStatus.BackColor = Color.Red
            End If
        End If
        If _ValidationError.Length > 0 Then
            Dim validator As New ValidationError(_ValidationError)
            validator.ShowPopup()
        End If
        Return _ValidationError.Length.Equals(0)
    End Function
    Private Sub Field_Enter(sender As Control, e As EventArgs) Handles TextStudentId.Enter, TextPin.Enter
        If sender.Equals(TextStudentId) Then sender = PanelStudentIdStatus
        If sender.Equals(TextPin) Then sender = PanelPasswordStatus
        sender.BackColor = Color.FromArgb(255, 164, 91)
    End Sub
    Private Sub Field_Leave(sender As Control, e As EventArgs) Handles TextStudentId.Leave, TextPin.Leave
        If sender.Equals(TextStudentId) Then sender = PanelStudentIdStatus
        If sender.Equals(TextPin) Then sender = PanelPasswordStatus
        sender.BackColor = Color.Transparent
    End Sub

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
            Student.Login(TextStudentId.Text, TextPin.Text)
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
            VotersPanel.GetInstance().GotoButton = VotersPanel.GetInstance().ButtonCandidate
            Main.LoadControl(VotersPanel.GetInstance())
        End If
    End Sub

    Private Sub btnFAQS_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnFAQS.LinkClicked
        FAQs.ShowFAQ()
    End Sub
End Class
