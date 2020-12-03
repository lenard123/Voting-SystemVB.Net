Imports Guna.UI2.WinForms

Public Class VotersPanel

    Implements MainControl

    Private Shared Instance As VotersPanel
    Private Shared Candidates As Dictionary(Of Integer, List(Of Candidate))

    Private RemainingTime As Integer
    Private IsCountdownStart As Boolean = False
    Private SelectedButton As Guna2Button

    Public Shared Function GetInstance() As VotersPanel
        If IsNothing(Instance) Then
            Instance = New VotersPanel
        End If
        Return Instance
    End Function

    Private Sub RefreshControl() Implements MainControl.RefreshControl
        If IsNothing(Student.GetCurrentUser()) Then
            Alert.ShowAlert("You need to login first", Alert.AlertType.Info)
            Main.LoadControl(VoterLogin.GetInstance())
        Else
            RemainingTime = DateDiff(DateInterval.Second, Date.Now(), Election.GetCurrentElection().Ended)
            Timer1.Start()
            IsCountdownStart = True
            LabelName.Text = Student.GetCurrentUser().Fullname
            If Student.GetCurrentUser().HasVoted Then
                ChipStatus.FillColor = Color.Green
                ChipStatus.Text = "Done"
            Else
                ChipStatus.FillColor = Color.Red
                ChipStatus.Text = "Not yet"
            End If
            ButtonCandidate.PerformClick()
        End If
    End Sub

    Public Shared Function GetCandidates() As Dictionary(Of Integer, List(Of Candidate))
        If IsNothing(Candidates) Then
            Candidates = Candidate.GetAll2()
        End If
        Return Candidates
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelCountdown.Text = RemainingTimeToString(RemainingTime)
        RemainingTime -= 1
    End Sub

    Public Sub LoadControl(content As UserControl)
        ChildPanel.Controls.Clear()
        ChildPanel.Controls.Add(content)
        content.Dock = DockStyle.Fill
        If TypeOf content Is MainControl Then
            DirectCast(content, MainControl).RefreshControl()
        End If
    End Sub

    Private Sub ButtonClick(sender As Guna2Button, e As EventArgs) Handles ButtonCandidate.Click, ButtonParty.Click
        Dim tag As Integer = Integer.Parse(sender.Tag)

        If sender.Equals(SelectedButton) Then Return

        If Not IsNothing(SelectedButton) Then SelectedButton.ForeColor = SystemColors.ControlDark

        sender.ForeColor = Color.White
        Indicator.Location = New Point(0, SideBarButton.Location.Y + sender.Location.Y)
        SelectedButton = sender

        Select Case tag
            Case 1
                LoadControl(CandidateInfo.GetInstance())
            Case 2
                LoadControl(PartyInfo.GetInstance())
        End Select

    End Sub


    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Student.SetCurrentUser(Nothing)
        Main.LoadControl(VoterLogin.GetInstance())
    End Sub
End Class
