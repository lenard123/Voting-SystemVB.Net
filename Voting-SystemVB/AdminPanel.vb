Public Class AdminPanel

    Implements MainControl

    'Handles Draggable Form
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX, MouseDownY As Integer

    'Handles Maximizing Form
    Private IsNormal As Boolean = True

    Private Account As Admin
    Private ElectionStatus As Integer
    Private ActivePage As Button

    Private Shared Instance As AdminPanel
    Private isCountDownStart As Boolean = False
    Private RemainingTime As Long


    Public Shared Function GetInstance() As AdminPanel
        If IsNothing(Instance) Then
            Instance = New AdminPanel
        End If
        Return Instance
    End Function

    Public Function SetUser(Account As Admin) As AdminPanel
        Me.Account = Account
        Admin.SetCurrentUser(Account)
        Return Me
    End Function

    Public Sub LoadControl(content As Control)
        MainContent.Controls.Clear()
        content.Dock = DockStyle.Fill
        MainContent.Controls.Add(content)

        If TypeOf content Is MainControl Then
            DirectCast(content, MainControl).RefreshControl()
        End If

    End Sub

    Public Function AdminHomeControl() As Control
        If Election.HasNotStarted Then
            Return AdminHomeNotStarted.GetInstance()
        ElseIf Election.IsOngoing Then
            Return AdminHomeStarted.GetInstance()
        End If
        Return Nothing
    End Function

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

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        SetUser(Nothing)
        Main.LoadControl(AdminLogin.GetInstance())
    End Sub

    Private Sub AdminPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseDown
        If e.Button = MouseButtons.Left And IsNormal Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub AdminPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseUp
        IsFormBeingDragged = False
    End Sub

    Private Sub AdminPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point
            temp.X = Main.Instance.Location.X + (e.X - MouseDownX)
            temp.Y = Main.Instance.Location.Y + (e.Y - MouseDownY)
            Main.Instance.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub

    Private Sub ChangeView_Click(sender As Object, e As EventArgs) Handles ButtonVoter.Click, ButtonHome.Click, ButtonCandidate.Click, ButtonParty.Click, ButtonAdmin.Click
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
            LoadControl(UpdateAdmin.GetInstance())
        End If
        indicator.Location = New Point(0, DirectCast(sender, Control).Location.Y)
        ActivePage = sender
    End Sub

    Private Sub ButtonMaximize_Click(sender As Object, e As EventArgs) Handles ButtonMaximize.Click
        Main.Instance.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub RefreshState()
        ElectionStatus = Election.GetCurrentElectionF().Status
        LabelFullname.Text = Account.Fullname
        ShowElectionStatus()

        If Election.IsOngoing And Not isCountDownStart Then
            RemainingTime = DateDiff(DateInterval.Second, Date.Now(), Election.GetCurrentElection().Ended)
            ElectionStartedLabel1.Visible = True
            CountDownTimer.Start()
            isCountDownStart = True
        End If

    End Sub

    Private Sub CountDownTimer_Tick(sender As Object, e As EventArgs) Handles CountDownTimer.Tick
        LabelCountdown.Text = RemainingTimeToString(RemainingTime)
        RemainingTime -= 1
    End Sub

    Private Sub AdminPanel_ParentChanged() Implements MainControl.RefreshControl
        If Not IsNothing(Account) Then
            RefreshState()
            ChangeView_Click(ButtonHome, Nothing)
        End If
    End Sub
End Class
