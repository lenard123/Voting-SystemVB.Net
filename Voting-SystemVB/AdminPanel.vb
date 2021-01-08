Imports Guna.UI2.WinForms

Public Class AdminPanel

    Implements MainControl


    Public ActivePage As Guna2Button
    Private isCountDownStart As Boolean = False
    Private RemainingTime As Long

    'Get Instance
    Private Shared Instance As AdminPanel
    Public Shared Function GetInstance() As AdminPanel
        If IsNothing(Instance) Then
            Instance = New AdminPanel
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    'Load Control
    Public Sub LoadControl(content As Control)
        MainContent.Controls.Clear()
        MainContent.Controls.Add(content)
        content.Dock = DockStyle.Fill
        'Trigger Refresh Method
        If TypeOf content Is MainControl Then
            DirectCast(content, MainControl).RefreshControl()
        End If
    End Sub

    'Return Admin Home Depending on Election Status
    Public Function AdminHomeControl() As Control
        If Election.HasNotStarted() Then
            Return AdminHomeNotStarted.GetInstance()
        ElseIf Election.IsOngoing() Then
            Return AdminHomeStarted.GetInstance()
        ElseIf Election.HasEnded() Then
            Return FinalizeResult.GetInstance()
        ElseIf Election.IsFinalized() Then
            Return AdminHomeEnded.GetInstance()
        End If
        Return Nothing
    End Function

    'Display Election Status
    Private Sub ShowElectionStatus()
        If Election.HasNotStarted() Then
            ChipElectionStatus.Text = "Not Started"
            ChipElectionStatus.ForeColor = Color.Black
            ChipElectionStatus.FillColor = Color.Yellow
        ElseIf Election.IsOngoing() Then
            ChipElectionStatus.Text = "Started"
            ChipElectionStatus.ForeColor = Color.White
            ChipElectionStatus.FillColor = Color.Green
        ElseIf Election.HasEnded() Or Election.IsFinalized() Then
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
        CountDownTimer.Stop()
        isCountDownStart = False
        Main.LoadControl(AdminLogin.GetInstance())
    End Sub

    'Switch Control
    Private Sub ChangeView_Click(sender As Guna2Button, e As EventArgs) Handles ButtonVoter.Click, ButtonHome.Click, ButtonCandidate.Click, ButtonAdmin.Click, ButtonParty.Click
        If sender.Equals(ActivePage) Then Return

        If sender.Equals(ButtonHome) Then
            LoadControl(AdminHomeControl())
        ElseIf sender.Equals(ButtonVoter) Then
            LoadControl(ManageVoters.GetInstance())
        ElseIf sender.Equals(ButtonCandidate) Then
            LoadControl(ManageCandidate.GetInstance())
        ElseIf sender.Equals(ButtonParty) Then
            LoadControl(ManageParty.GetInstance())
        ElseIf sender.Equals(ButtonAdmin) Then
            LoadControl(ManageAdmin.GetInstance())
        End If

        indicator.Location = New Point(0, sender.Location.Y + PanelButtonGroup.Location.Y)
        ActivePage = sender
    End Sub

    'Countdown Tick
    Private Sub CountDownTimer_Tick(sender As Object, e As EventArgs) Handles CountDownTimer.Tick
        LabelCountdown.Text = RemainingTimeToString(RemainingTime)
        RemainingTime -= 1

        If RemainingTime < 0 Then
            Alert.ShowAlert("Election has finally ended", Alert.AlertType.Info)
            ActivePage = Nothing 'To force the Panel to reload the Home Ended
            Admin_Panel_Reload()
        End If

    End Sub

    'Background Worker Refresh Admin Panel
    Public Sub Admin_Panel_Reload() Implements MainControl.RefreshControl
        If IsNothing(Admin.GetCurrentUser()) Then
            Alert.ShowAlert("Login first", Alert.AlertType.Info)
            Main.LoadControl(AdminLogin.GetInstance())
        Else
            BackgroundWorkerRefresh.RunWorkerAsync()
        End If
    End Sub
    Private Sub BackgroundWorkerRefresh_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerRefresh.DoWork
        Election.GetCurrentElectionRefresh()
        Admin.RefreshCurrentUser()
    End Sub
    Private Sub BackgroundWorkerRefresh_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerRefresh.RunWorkerCompleted
        LabelFullname.Text = Admin.GetCurrentUser().Fullname
        ShowElectionStatus()
        BtnNewElection.Visible = False
        LabelCountdown.Text = ""

        If Election.HasNotStarted() Then
            ElectionStartedLabel1.Visible = False
        ElseIf Election.IsOngoing() And Not isCountDownStart Then
            RemainingTime = DateDiff(DateInterval.Second, Date.Now(), Election.GetCurrentElection().Ended)
            ElectionStartedLabel1.Visible = True
            CountDownTimer.Start()
            isCountDownStart = True
        ElseIf Election.HasEnded() Then
            ElectionStartedLabel1.Visible = False
            If isCountDownStart Then
                CountDownTimer.Stop()
            End If
        ElseIf Election.IsFinalized() Then
            BtnNewElection.Visible = True
        End If

        ButtonHome.PerformClick()
    End Sub

    Private Sub BtnNewElection_Click(sender As Object, e As EventArgs) Handles BtnNewElection.Click
        NewElection.ShowPopup()
    End Sub
End Class
