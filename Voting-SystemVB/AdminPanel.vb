Imports Guna.UI2.WinForms

Public Class AdminPanel

    Implements MainControl

    Private Shared Instance As AdminPanel

    Private ElectionStatus As Integer
    Public ActivePage As Guna2Button
    Private isCountDownStart As Boolean = False
    Private RemainingTime As Long

    'Get Instance
    Public Shared Function GetInstance() As AdminPanel
        If IsNothing(Instance) Then
            Instance = New AdminPanel
        End If
        Return Instance
    End Function

    'Load Control
    Public Sub LoadControl(content As Control)
        MainContent.Controls.Clear()
        content.Dock = DockStyle.Fill
        MainContent.Controls.Add(content)
        If TypeOf content Is MainControl Then
            DirectCast(content, MainControl).RefreshControl()
        End If
    End Sub

    'Return Admin Home Depending on Election Status
    Public Function AdminHomeControl() As Control
        If Election.HasNotStarted() Then
            Return AdminHomeNotStarted.GetInstance()
        ElseIf Election.IsOngoing() Then
            Return AdminHomeStarted2.GetInstance()
        End If
        Return Nothing
    End Function

    'Display Election Status
    Private Sub ShowElectionStatus()
        Dim state = ElectionStatus
        If state.Equals(Election.STATUS_NOT_STARTED) Then
            ChipElectionStatus.Text = "Not Started"
            ChipElectionStatus.ForeColor = Color.Black
            ChipElectionStatus.FillColor = Color.Yellow
        ElseIf state.Equals(Election.STATUS_ONGOING) Then
            ChipElectionStatus.Text = "Started"
            ChipElectionStatus.ForeColor = Color.White
            ChipElectionStatus.FillColor = Color.Green
        ElseIf state.Equals(Election.STATUS_ENDED) Then
            ChipElectionStatus.Text = "Ended"
            ChipElectionStatus.ForeColor = Color.White
            ChipElectionStatus.FillColor = Color.FromArgb(94, 148, 255)
        Else
            ChipElectionStatus.Text = "Error(Unknown State)"
            ChipElectionStatus.ForeColor = Color.White
            ChipElectionStatus.FillColor = Color.Red
        End If
    End Sub

    'Logout Button
    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Admin.SetCurrentUser(Nothing)
        Main.LoadControl(AdminLogin.GetInstance())
    End Sub

    'Switch Control
    Private Sub ChangeView_Click(sender As Guna2Button, e As EventArgs) Handles ButtonVoter.Click, ButtonHome.Click, ButtonCandidate.Click, ButtonAdmin.Click, ButtonParty.Click
        If sender.Equals(ActivePage) Then Return

        If Not IsNothing(ActivePage) Then ActivePage.ForeColor = Color.DarkGray
        sender.ForeColor = Color.White

        If sender.Equals(ButtonHome) Then
            LoadControl(AdminHomeControl())
        ElseIf sender.Equals(ButtonVoter) Then
            LoadControl(ManageVoters.GetInstance())
        ElseIf sender.Equals(ButtonCandidate) Then
            LoadControl(ManageCandidate.GetInstance())
        ElseIf sender.Equals(ButtonParty) Then
            LoadControl(ManageParty.GetInstance())
        ElseIf sender.Equals(ButtonAdmin) Then
            LoadControl(UpdateAdmin.GetInstance())
        End If

        indicator.Location = New Point(0, sender.Location.Y + PanelButtonGroup.Location.Y)
        ActivePage = sender
    End Sub

    'Countdown Tick
    Private Sub CountDownTimer_Tick(sender As Object, e As EventArgs) Handles CountDownTimer.Tick
        LabelCountdown.Text = RemainingTimeToString(RemainingTime)
        RemainingTime -= 1
    End Sub

    Public Sub Admin_Panel_Reload() Implements MainControl.RefreshControl
        If IsNothing(Admin.GetCurrentUser()) Then
            Alert.ShowAlert("Login first", Alert.AlertType.Info)
            Main.LoadControl(AdminLogin.GetInstance())
        Else
            BackgroundWorkerRefresh.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorkerRefresh_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerRefresh.DoWork
        ElectionStatus = Election.GetCurrentElectionF().Status
    End Sub
    Private Sub BackgroundWorkerRefresh_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerRefresh.RunWorkerCompleted
        LabelFullname.Text = Admin.GetCurrentUser().Fullname
        ShowElectionStatus()

        If Election.IsOngoing And Not isCountDownStart Then
            RemainingTime = DateDiff(DateInterval.Second, Date.Now(), Election.GetCurrentElection().Ended)
            ElectionStartedLabel1.Visible = True
            CountDownTimer.Start()
            isCountDownStart = True
        End If

        ButtonHome.PerformClick()
    End Sub

End Class
