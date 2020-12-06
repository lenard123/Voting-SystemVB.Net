﻿Public Class LoadingScreen

    Implements MainControl

    Dim Percent As Integer = 0

    Dim ValidConnection As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Stop()
        Select Case Percent
            Case 0
                If DBHelper.TestConnection() Then
                    ValidConnection = True
                Else
                    Percent = 100
                End If
            Case 1
                AdminLogin.GetInstance()
            Case 2
                VoterLogin.GetInstance()
            Case 3
                AdminPanel.GetInstance()
            Case 5
                AdminHomeNotStarted.GetInstance()
            Case 6
                AdminHomeStarted.GetInstance()
            Case 7
                ManageCandidate.GetInstance()
            Case 8
                ManageParty.GetInstance()
            Case 9
                ManageVoters.GetInstance()
            Case 10
                LoadFont()
            Case 11
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
