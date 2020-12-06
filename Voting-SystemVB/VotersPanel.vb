Imports Guna.UI2.WinForms

Public Class VotersPanel

    Implements MainControl

    Private Shared Instance As VotersPanel
    Private Shared Candidates As Dictionary(Of Integer, List(Of Candidate))
    Private Shared VotedCandidates As List(Of Candidate)

    Private RemainingTime As Integer
    Private IsCountdownStart As Boolean = False
    Private SelectedButton As Guna2Button
    Public GotoButton As Guna2Button

    Public Shared Function GetInstance() As VotersPanel
        If IsNothing(Instance) Then
            Instance = New VotersPanel
            Instance.GotoButton = Instance.ButtonCandidate
        End If
        Return Instance
    End Function

    Public Sub RefreshControl() Implements MainControl.RefreshControl

        LoadControl(LoadingControl.GetInstance())
        BackgroundWorkerRefresh.RunWorkerAsync()

    End Sub

    Public Shared Function GetCandidates() As Dictionary(Of Integer, List(Of Candidate))
        If IsNothing(Candidates) Then
            Candidates = Candidate.GetAll2()
        End If
        Return Candidates
    End Function

    Public Shared Function GetVotedCandidates() As List(Of Candidate)
        If IsNothing(VotedCandidates) Then
            VotedCandidates = Candidate.GetVotedCandidates(Student.GetCurrentUser().Id)
        End If
        Return VotedCandidates
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

    Private Sub MainButton_Click(sender As Guna2Button, e As EventArgs) Handles ButtonCandidate.Click, ButtonParty.Click, ButtonVoteNow.Click, ButtonVoteInfo.Click
        Dim tag As Integer = Integer.Parse(sender.Tag)

        'If sender.Equals(SelectedButton) Then Return

        If Not IsNothing(SelectedButton) Then SelectedButton.ForeColor = SystemColors.ControlDark

        sender.ForeColor = Color.White
        Indicator.Location = New Point(0, SideBarButton.Location.Y + sender.Location.Y)
        SelectedButton = sender

        Select Case tag
            Case 1
                LoadControl(CandidateInfo.GetInstance())
            Case 2
                LoadControl(PartyInfo.GetInstance())
            Case 3
                LoadControl(VoteNow.GetInstance())
            Case 4
                LoadControl(VoteInfo.GetInstance())
        End Select

    End Sub


    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Student.SetCurrentUser(Nothing)
        Main.LoadControl(VoterLogin.GetInstance())
    End Sub

    Private Sub BackgroundWorkerRefresh_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerRefresh.DoWork
        If (Student.RefreshCurrentUser().HasVoted) Then
            VotedCandidates = Candidate.GetVotedCandidates(Student.GetCurrentUser().Id)
        End If
        Election.GetCurrentElectionF()
        GetCandidates()
    End Sub

    Private Sub BackgroundWorkerRefresh_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerRefresh.RunWorkerCompleted
        If IsNothing(Student.GetCurrentUser()) Then
            Alert.ShowAlert("You need to login first", Alert.AlertType.Info)
            Main.LoadControl(VoterLogin.GetInstance())
        Else
            If Not IsCountdownStart Then
                RemainingTime = DateDiff(DateInterval.Second, Date.Now(), Election.GetCurrentElection().Ended)
                Timer1.Start()
                IsCountdownStart = True
            End If
            LabelName.Text = Student.GetCurrentUser().Fullname
            If Student.GetCurrentUser().HasVoted Then
                ChipStatus.FillColor = Color.Green
                ChipStatus.Text = "Done"

                ButtonVoteInfo.Visible = True
                ButtonVoteNow.Visible = False

            Else
                ChipStatus.FillColor = Color.Red
                ChipStatus.Text = "Not yet"


                ButtonVoteInfo.Visible = False
                If Election.IsOngoing() Then
                    ButtonVoteNow.Visible = True
                End If
            End If
            GotoButton.PerformClick()
        End If
    End Sub
End Class
