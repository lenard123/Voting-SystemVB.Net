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
            Dim Result = Student.Find(TextStudentId.Text)
            If IsNothing(Result) Then
                MessageBox.Show("Student ID doesn't exists in the database")
            Else
                If Not (Result.ComparePassword(TextPin.Text)) Then
                    MessageBox.Show("Wrong Password")
                Else
                    MessageBox.Show("Login Successfully")
                End If
            End If
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        Dim ValidationError As String = ""
        Dim StudentID = TextStudentId.Text
        Dim Password = TextPin.Text

        If (StudentID.Length.Equals(0) Or Password.Length.Equals(0)) Then
            ValidationError += "Student ID and Password Field is Required " & Environment.NewLine
        Else
            If Not (StudentID.Length.Equals(10)) Then
                ValidationError += "Student ID must have 10 characters" & Environment.NewLine
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

    Private Sub VoterLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New ToolTip
        t.ShowAlways = True
        t.Active = True
        t.InitialDelay = 1000
        t.AutoPopDelay = 5000
        t.ReshowDelay = 500
        t.SetToolTip(ButtonLogin, "HELLO")
    End Sub

    Private Sub UpdateStatus(pnl As Panel, state As Integer)
        If (state.Equals(1)) Then 'default State
            pnl.BackColor = Color.FromArgb(255, 164, 91)
        ElseIf (state.Equals(2)) Then
            pnl.BackColor = Color.FromArgb(224, 117, 125)
        ElseIf (state.Equals(3)) Then
            pnl.BackColor = Color.FromArgb(22, 165, 150)
        End If
    End Sub

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
End Class
