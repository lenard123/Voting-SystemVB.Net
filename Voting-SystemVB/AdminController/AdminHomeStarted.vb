Imports System.Windows.Forms.DataVisualization.Charting
Imports Guna.UI2.WinForms

Public Class AdminHomeStarted

    Private Shared Instance As AdminHomeStarted

    Private AllVoters As Integer
    Private Candidates As New Dictionary(Of Integer, List(Of Candidate))
    Private PieCharts As New Dictionary(Of Integer, Chart)
    Private DoneVoting As Integer
    Private RemainingVotes As Integer
    Private LoadingIndicator As New Guna2ProgressIndicator
    Private SelectedPosition As Integer = Position.PRESIDENT_ID
    Private SelectedButton As Guna2Button

    Public Shared Function GetInstance() As AdminHomeStarted
        If IsNothing(Instance) Then
            Instance = New AdminHomeStarted
        End If
        Return Instance
    End Function

    Private Async Sub AdminHomeStarted_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Fetch Voter Counts
        AllVoters = Await Student.CountAllAsync()
        LabelVotersCount.Text = AllVoters

        'Fetch Candidates
        Candidates.Add(Position.PRESIDENT_ID, Await Candidate.GetAllByPositionAsync(Position.PRESIDENT_ID))
        Candidates.Add(Position.VICE_PRESIDENT_ID, Await Candidate.GetAllByPositionAsync(Position.VICE_PRESIDENT_ID))
        Candidates.Add(Position.SECRETARY_ID, Await Candidate.GetAllByPositionAsync(Position.SECRETARY_ID))
        Candidates.Add(Position.TREASURER_ID, Await Candidate.GetAllByPositionAsync(Position.TREASURER_ID))
        Candidates.Add(Position.AUDITOR_ID, Await Candidate.GetAllByPositionAsync(Position.AUDITOR_ID))
        Candidates.Add(Position.PRO_ID, Await Candidate.GetAllByPositionAsync(Position.PRO_ID))

        LoadingIndicator.Size = New Size(150, 150)

        ButtonPosition_Click(ButtonPresident, Nothing)

    End Sub

    Private Async Function RefreshPosition(PositionID As Integer) As Task
        ShowLoading()

        DoneVoting = Await Votes.CountAllDoneAsync()
        RemainingVotes = AllVoters - DoneVoting
        
        LabelDoneVoters.Text = DoneVoting
        LabelRemainingVoters.Text = RemainingVotes

        If DisplayPieChart.Checked Then
            Await ReloadChart(PositionID)
        End If

        StopLoading()

    End Function

    Private Async Function ReloadChart(PositionID As Integer) As Task

        LabelLastUpdate.Text = "Result As of: " & Date.Now().ToString("MMMM dd, yyyy hh:mm:ss tt")

        ChartVoteCount.Series(0).Points.Clear()
        ChartVoteCount.Series(1).Points.Clear()

        Dim VoteCounts = Await Votes.CountVotesAsync(PositionID)
        ResultPanel.Controls.Add(ChartVoteCount)
        For Each item In Candidates(PositionID)
            Dim vote = 0
            If VoteCounts.ContainsKey(item.ID) Then vote = VoteCounts(item.ID)

            Dim nPoint As New DataPoint()
            nPoint.Label = item.Fullname
            nPoint.SetValueY(vote)
            ChartVoteCount.Series(0).Points.Add(nPoint)
            ChartVoteCount.Series(1).Points.Add(nPoint)
        Next
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

    Private Async Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Await RefreshPosition(SelectedPosition)
    End Sub

    Private Async Sub ButtonPosition_Click(sender As Object, e As EventArgs) Handles ButtonPresident.Click, ButtonVPresident.Click, ButtonTreasurer.Click, ButtonSecretary.Click, ButtonPRO.Click, ButtonAuditor.Click
        If sender.Equals(SelectedButton) Then Return

        If Not IsNothing(SelectedButton) Then
            SelectedButton.FillColor = Color.White
            SelectedButton.ForeColor = Color.Black
        End If
        SelectedButton = sender
        SelectedButton.FillColor = Color.FromArgb(71, 169, 248)
        SelectedButton.ForeColor = Color.White

        SelectedPosition = SelectedButton.Tag
        Await RefreshPosition(SelectedPosition)

    End Sub
End Class
