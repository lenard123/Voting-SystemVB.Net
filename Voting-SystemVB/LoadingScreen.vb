Public Class LoadingScreen

    Dim Percent As Integer = 0

    Dim DBConnection As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Percent.Equals(10)) Then
            Timer1.Stop()
            AdminLogin.GetInstance()
            Timer1.Start()
        ElseIf (Percent.Equals(20)) Then
            Timer1.Stop()
            VoterLogin.GetInstance()
            Timer1.Start()
        ElseIf (Percent.Equals(50)) Then
            Timer1.Stop()
            Try
                DBHelper.GetConnection().Open()
                DBHelper.GetConnection().Close()
                DBConnection = 1
            Catch ex As OleDb.OleDbException
                Percent = 100
            End Try
            Timer1.Start()
        ElseIf (Percent >= 100) Then
            Timer1.Stop()
            Finish()
        End If
        Expand()
        Percent = Percent + 1
    End Sub

    Private Sub Finish()
        If (DBConnection.Equals(0)) Then
            MessageBox.Show("An error occured while connecting to database")
            Application.Exit()
        Else
            Main.LoadControl(VoterLogin.GetInstance())
        End If
        Dispose()
    End Sub

    Private Sub Expand()
        PanelProgress.Width = (Percent / 100) * Me.Width
    End Sub

    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
