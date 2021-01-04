Public Class LoadingScreen

    Implements MainControl

    Dim Percent As Integer = 0

    Dim ValidConnection As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Stop()
        Select Case Percent
            Case 0
                Debug.WriteLine("Testing Connection")
                If DBHelper.TestConnection() Then
                    ValidConnection = True
                Else
                    Debug.WriteLine("Can not connect to database")
                    Percent = 100
                End If
            Case 1
                Debug.WriteLine("Loading AdminLogin")
                AdminLogin.GetInstance()
            Case 2
                Debug.WriteLine("Loading VoterLogin")
                VoterLogin.GetInstance()
            Case 3
                Debug.WriteLine("Loading AdminPanel")
                AdminPanel.GetInstance()
            Case 5
                Debug.WriteLine("Loading AdminHomeNotStarted")
                AdminHomeNotStarted.GetInstance()
            Case 6
            Case 7
                Debug.WriteLine("Loading ManageCandidate")
                ManageCandidate.GetInstance()
            Case 8
                Debug.WriteLine("Loading ManageParty")
                ManageParty.GetInstance()
            Case 9
                Debug.WriteLine("Loading ManageVoter")
                ManageVoters.GetInstance()
            Case 10
                Debug.WriteLine("Loading FontAwesome")
                LoadFont()
            Case 11
                Debug.WriteLine("Loading UpdateAccount")
                UpdateAdmin.GetInstance()
        End Select

        If Percent >= 100 Then
            Finish()
        Else
            Timer1.Start()
            Expand()
            Percent = Percent + 1
        End If


    End Sub

    Private Sub Finish()
        If Not ValidConnection Then
            Dim popup As New SystemCrashError("Oops!!", "An error occured while connecting to database")
            popup.ShowPopup()
        Else
            Main.WindowState = FormWindowState.Maximized
            Main.LoadControl(VoterLogin.GetInstance())
            Dispose()
        End If
    End Sub

    Private Sub Expand()
        PanelProgress.Width = (Percent / 100) * Me.Width
    End Sub

    Private Sub LoadingScreen_Load() Implements MainControl.RefreshControl
        Timer1.Start()
    End Sub
End Class
