Public Class VoterLogin

    Private Shared Instance As VoterLogin

    Public Shared Function GetInstance() As VoterLogin
        If IsNothing(Instance) Then
            Instance = New VoterLogin()
        End If
        Return Instance
    End Function

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

    Private Sub ButtonAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAdmin.Click
        Main.LoadControl(AdminLogin.GetInstance())
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If ValidateForm() Then
            If Election.GetCurrentElectionF().Status = Election.HasNotStarted Then
                ValidationError.Alert("Election has not started yet", "Unable to Login")
            Else
                Dim Result = Student.Find(TextStudentId.Text)
                If IsNothing(Result) Then
                    ValidationError.Alert("Student ID doesn't exists in the database", "Login Failed")
                    'MessageBox.Show("Student ID doesn't exists in the database")
                Else
                    If Not (Result.ComparePassword(TextPin.Text)) Then
                        ValidationError.Alert("Wrong Password", "Login Failed")
                    Else
                        Alert.ShowAlert("Login Successfully", Alert.AlertType.Success)
                        Student.SetCurrentUser(Result)
                        Main.LoadControl(VotersPanel.GetInstance())
                    End If
                End If
            End If
        End If
    End Sub

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



    Private Sub TextStudentId_Enter(sender As Object, e As EventArgs) Handles TextStudentId.Enter
        PanelStudentIdStatus.BackColor = Color.FromArgb(255, 164, 91)
    End Sub

    Private Sub TextStudentId_Leave(sender As Object, e As EventArgs) Handles TextStudentId.Leave
        PanelStudentIdStatus.BackColor = Color.Transparent
    End Sub

    Private Sub TextPin_Enter(sender As Object, e As EventArgs) Handles TextPin.Enter
        PanelPasswordStatus.BackColor = Color.FromArgb(255, 164, 91)
    End Sub

    Private Sub TextPin_Leave(sender As Object, e As EventArgs) Handles TextPin.Leave
        PanelPasswordStatus.BackColor = Color.Transparent
    End Sub

    Private Sub VoterLogin_Paint(sender As Object, e As EventArgs) Handles MyBase.Paint
        TextPin.Clear()
    End Sub
End Class
