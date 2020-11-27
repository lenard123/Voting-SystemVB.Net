Public Class LoadingScreen

    Dim Percent As Integer = 0

    Dim DBConnection As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'At 10% Get the Admin Login
        If (Percent.Equals(10)) Then
            Timer1.Stop()
            AdminLogin.GetInstance()
            Timer1.Start()

            'At 20% Get the Voter Login
        ElseIf (Percent.Equals(20)) Then
            Timer1.Stop()
            VoterLogin.GetInstance()
            Timer1.Start()

            'At 50% Connect to the database
        ElseIf (Percent.Equals(50)) Then
            Timer1.Stop()
            Try
                GetConnection.Open()
                GetConnection.Close()
                DBConnection = 1
            Catch ex As OleDb.OleDbException
                Percent = 100
            End Try
            Timer1.Start()
        ElseIf Percent.Equals(60) Then
            Election.GetCurrentElection()
            'At 100% Halt the timer
        ElseIf Percent.Equals(70) Then
            LoadFont()
        ElseIf (Percent >= 100) Then
            Timer1.Stop()
            Finish()
        End If
        Expand()
        Percent = Percent + 1
    End Sub

    Private Sub Finish()
        If (DBConnection.Equals(0)) Then
            Dim popup As New SystemCrashError("Oops!!", "An error occured while connecting to database")
            popup.ShowPopup()
        Else
            Main.LoadControl(VoterLogin.GetInstance())
            Dispose()
        End If
    End Sub

    Private Sub Expand()
        PanelProgress.Width = (Percent / 100) * Me.Width
    End Sub

    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
