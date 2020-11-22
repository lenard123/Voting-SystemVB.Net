Public Class AdminPanel

    'Handles Draggable Form
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX, MouseDownY As Integer

    'Handles Maximizing Form
    Private IsNormal As Boolean = True

    Private Shared ReadOnly HomePageIndex = 0

    Private Account As Admin
    Private ElectionStatus As Integer
    Private ActivePage As Button

    Public Sub New(ByVal Account As Admin)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Account = Account
        ElectionStatus = Election.GetCurrentElection().Status

        LabelFullname.Text = Account.Fullname
        ShowElectionStatus()
        Home()
        ActivePage = ButtonHome
    End Sub

    Private Sub LoadControl(content As Control)
        DisposeChild()
        content.Dock = DockStyle.Fill
        MainContent.Controls.Add(content)
    End Sub

    Private Sub DisposeChild()
        For Each child As Control In MainContent.Controls
            child.Dispose()
        Next
    End Sub

    Private Sub Home()
        If ElectionStatus.Equals(Election.STATUS_NOT_STARTED) Then
            LoadControl(New AdminHomeNotStarted)
        End If
    End Sub

    Private Sub Voter()
        LoadControl(New ManageVoters)
    End Sub

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
        DisposeChild()
        Main.LoadControl(AdminLogin.GetInstance())
        Dispose()
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

    Private Sub ChangeView_Click(sender As Object, e As EventArgs) Handles ButtonVoter.Click, ButtonHome.Click
        If sender.Equals(ActivePage) Then Return
        If sender.Equals(ButtonHome) Then
            Home()
            ActivePage = sender
            indicator.Location = New Point(0, ButtonHome.Location.Y)
        ElseIf sender.Equals(ButtonVoter) Then
            Voter()
            ActivePage = sender
            indicator.Location = New Point(0, ButtonVoter.Location.Y)
        End If
    End Sub

    Private Sub ButtonMaximize_Click(sender As Object, e As EventArgs) Handles ButtonMaximize.Click
        Main.Instance.WindowState = FormWindowState.Maximized
    End Sub
End Class
