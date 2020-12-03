Imports System.Windows.Forms.DataVisualization.Charting
Imports Guna.UI2.WinForms

Public Class AdminHomeStarted

    Private Shared Instance As AdminHomeStarted

    Private AllVoters As Integer
    Private DoneVoters As Integer

    Private Candidates As New Dictionary(Of Integer, List(Of Candidate))
    Private PieCharts As New Dictionary(Of Integer, Chart)
    Private LoadingIndicator As New Guna2ProgressIndicator
    Private SelectedPosition As Integer = Position.PRESIDENT_ID
    Private SelectedButton As Guna2Button

    Public Shared Function GetInstance() As AdminHomeStarted
        If IsNothing(Instance) Then
            Instance = New AdminHomeStarted
        End If
        Return Instance
    End Function

    Private Sub AdminHomeStarted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorkerInit.RunWorkerAsync()
    End Sub

    Private Function AddLabel(Counter As Integer, Fullname As String, Party As String, VoteCount As Integer) As Guna2HtmlLabel

        If IsNothing(Party) Or "".Equals(Party) Then
            Party = "Independent"
        End If

        Dim nLabel As New Guna2HtmlLabel
        Dim chipVotes As New Guna2Chip

        nLabel.Text = "<font size='15px'>"
        nLabel.Text &= Counter & ". " & "<b>" & Fullname & "</b> "
        nLabel.Text &= "(<i>" & Party & "</i>)"
        nLabel.Text &= "</font>"
        nLabel.Margin = New Padding(3, 3, 3, 3)

        chipVotes.Text = VoteCount & " VOTES"
        chipVotes.Margin = New Padding(3, 0, 3, 12)
        chipVotes.Size = New Size(75, 23)

        ResultText.Controls.Add(nLabel)
        ResultText.Controls.Add(chipVotes)

        Return nLabel
    End Function

    Private Sub ShowLoading()
        Dim x, y As Integer
        x = (ResultPanel.Width / 2) - 75
        y = (ResultPanel.Height / 2) - 75
        LoadingIndicator.Location = New Point(x, y)
        LoadingIndicator.Start()
        ResultPanel.Controls.Clear()
        ResultPanel.Controls.Add(LoadingIndicator)
    End Sub
    Private Sub StopLoading()
        LoadingIndicator.Stop()
        ResultPanel.Controls.Remove(LoadingIndicator)
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        If Not BackgroundWorkerRefresh.IsBusy Then
            RefreshData()
        End If
    End Sub

    Private Sub ButtonPosition_Click(sender As Object, e As EventArgs) Handles ButtonPresident.Click, ButtonVPresident.Click, ButtonTreasurer.Click, ButtonSecretary.Click, ButtonPRO.Click, ButtonAuditor.Click
        If sender.Equals(SelectedButton) Then Return
        If Not BackgroundWorkerRefresh.IsBusy Then
            If Not IsNothing(SelectedButton) Then
                SelectedButton.FillColor = Color.White
                SelectedButton.ForeColor = Color.Black
            End If
            SelectedButton = sender
            SelectedButton.FillColor = Color.FromArgb(71, 169, 248)
            SelectedButton.ForeColor = Color.White
            SelectedPosition = SelectedButton.Tag
            RefreshData()
        End If
    End Sub

    Private Sub DisplayPieChart_CheckedChanged(sender As Object, e As EventArgs) Handles DisplayPieChart.CheckedChanged
        If DisplayPieChart.Checked Then
            ResultPanel.BringToFront()
        Else
            ResultPanel.SendToBack()
        End If
    End Sub

    Private Sub GotoVoters(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click, Guna2ImageButton3.Click, Guna2ImageButton2.Click
        AdminPanel.GetInstance().ButtonVoter.PerformClick()
        ManageVoters.GetInstance().TextSearch.Text = DirectCast(sender, Control).Tag
        ManageVoters.GetInstance().ButtonSearch.PerformClick()
    End Sub

    'Init Data
    Private Sub BackgroundWorkerInit_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerInit.DoWork
        'Fetch Voter Counts
        AllVoters = Student.CountAll()

        'Fetch Candidates
        Candidates.Add(Position.PRESIDENT_ID, Candidate.GetAllByPosition(Position.PRESIDENT_ID))
        Candidates.Add(Position.VICE_PRESIDENT_ID, Candidate.GetAllByPosition(Position.VICE_PRESIDENT_ID))
        Candidates.Add(Position.SECRETARY_ID, Candidate.GetAllByPosition(Position.SECRETARY_ID))
        Candidates.Add(Position.TREASURER_ID, Candidate.GetAllByPosition(Position.TREASURER_ID))
        Candidates.Add(Position.AUDITOR_ID, Candidate.GetAllByPosition(Position.AUDITOR_ID))
        Candidates.Add(Position.PRO_ID, Candidate.GetAllByPosition(Position.PRO_ID))

    End Sub
    Private Sub BackgroundWorkerInit_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerInit.RunWorkerCompleted
        LabelVotersCount.Text = AllVoters
        LoadingIndicator.Size = New Size(150, 150)
        ButtonPresident.PerformClick()
    End Sub


    Private Sub RefreshData()
        If BackgroundWorkerRefresh.IsBusy Then Return
        ShowLoading()

        ChartVoteCount.Series(0).Points.Clear()
        ChartVoteCount.Series(1).Points.Clear()
        While ResultText.Controls.Count > 0
            ResultText.Controls(0).Dispose()
        End While
        BackgroundWorkerRefresh.RunWorkerAsync()
    End Sub

    'Refresh Data
    Private Sub BackgroundWorkerRefresh_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerRefresh.DoWork
        DoneVoters = Votes.CountAllDone()
        e.Result = Votes.CountVotes(SelectedPosition)
    End Sub

    Private Sub BackgroundWorkerRefresh_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerRefresh.RunWorkerCompleted
        'Update Last Refresh Label
        LabelLastUpdate.Text = "Result As of: " & Date.Now().ToString("MMMM dd, yyyy hh:mm:ss tt")
        'Update Number of Voters
        LabelDoneVoters.Text = DoneVoters
        LabelRemainingVoters.Text = AllVoters - DoneVoters

        Dim VoteCounts As Dictionary(Of Integer, Integer) = e.Result

        ResultPanel.Controls.Add(ChartVoteCount)

        Dim CandidateCounter = 1
        For Each item In Candidates(SelectedPosition)
            Dim vote = 0
            If VoteCounts.ContainsKey(item.ID) Then vote = VoteCounts(item.ID)
            Dim nPoint As New DataPoint()
            nPoint.Label = item.Fullname
            nPoint.SetValueY(vote)

            ChartVoteCount.Series(0).Points.Add(nPoint)
            ChartVoteCount.Series(1).Points.Add(nPoint)

            AddLabel(CandidateCounter, item.Fullname, item.Party, vote)
            CandidateCounter += 1
        Next

        StopLoading()
    End Sub
End Class
