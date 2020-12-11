
Imports Guna.UI2.WinForms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class AdminHomeEnded

    Private Shared Instance As AdminHomeEnded
    Private Shared AllCandidates As Dictionary(Of Integer, List(Of Candidate)) 'Position => Candidates
    Private Shared VoteCounts As New Dictionary(Of Integer, Dictionary(Of Integer, Integer)) 'Position => {Candidate => VoteCount}
    Private Shared Parties As List(Of Party)

    Public Shared Function GetInstance() As AdminHomeEnded
        If IsNothing(Instance) Then
            Instance = New AdminHomeEnded
        End If
        Return Instance
    End Function
    Function GetTopCandidates(PositionID As Integer, highestvote As Integer) As List(Of Candidate)
        Dim Top = New List(Of Candidate)
        For Each item In AllCandidates(PositionID)
            If VoteCounts(PositionID).ContainsKey(item.ID) AndAlso VoteCounts(PositionID)(item.ID) = highestvote Then
                Top.Add(item)
            End If
        Next
        Return Top
    End Function
    Sub AdminHomeEnded_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartLoading()
        BackgroundWorkerFetchResult.RunWorkerAsync()
    End Sub
    Sub StartLoading()
        TableLayoutPanel1.Visible = False
        Guna2WinProgressIndicator1.Start()
        LoadingPanel.Visible = True
    End Sub
    Sub StopLoading()
        TableLayoutPanel1.Visible = True
        LoadingPanel.Visible = False
        Guna2WinProgressIndicator1.Stop()
    End Sub
    Sub ShowWinners()
        For i = 1 To 6
            Dim HighestVotes = VoteCounts(i).Max(Function(votecount As KeyValuePair(Of Integer, Integer))
                                                     Return votecount.Value
                                                 End Function)
            Dim ri = New ResultItem(i, HighestVotes, GetTopCandidates(i, HighestVotes))
            FlowLayoutPanel1.Controls.Add(ri)
        Next
    End Sub
    Sub ShowChartPosition_Click(sender As Guna2Button, e As EventArgs) Handles President.Click, VPresident.Click, Secretary.Click, Treasurer.Click, Auditor.Click, PRO.Click
        Dim PositionID = Integer.Parse(sender.Tag)
        Dim Tally As Dictionary(Of Integer, Integer) = VoteCounts(PositionID)
        Chart1.Series.Clear()
        ShowCandidates.Text = "Final Vote Counts of " & Position.GetName(PositionID) & " Position."
        For Each item In AllCandidates(PositionID)
            Dim vote = 0
            If Tally.ContainsKey(item.ID) Then vote = Tally(item.ID)

            Dim seriesItem = New Series()
            Dim nPoint As New DataPoint()
            nPoint.SetValueY(vote)
            seriesItem.Name = item.Fullname
            seriesItem.Points.Add(nPoint)
            Chart1.Series.Add(seriesItem)
        Next

        'Di ko sure kung para san to
        'pero may bug sa display ng chart
        'pag wala to eh
        Chart1.ResetAutoValues()
    End Sub
    Sub ShowPartyChart()
        If Parties.Count > 1 Then
            Panel2.Visible = True
            Chart2.Series.Clear()
            For Each item In Parties
                Dim seriesItem = New Series(item.Title)
                seriesItem.ChartArea = "ChartAreaBar"
                seriesItem.XValueType = ChartValueType.String
                For i = 1 To 6
                    Dim nPoint As New DataPoint(seriesItem)
                    Dim sCand = AllCandidates(i).Find(Function(c) c.PartyID = item.ID)

                    nPoint.ToolTip = sCand.Fullname
                    If Not IsNothing(sCand) AndAlso VoteCounts(i).ContainsKey(sCand.ID) Then
                        nPoint.SetValueXY(Position.GetName(i), VoteCounts(i)(sCand.ID))
                    Else
                        nPoint.SetValueXY(Position.GetName(i), 0)
                    End If

                    seriesItem.Points.Add(nPoint)
                Next
                Chart2.Series.Add(seriesItem)
            Next
            Chart2.ResetAutoValues()
        Else
            Panel2.Visible = False
        End If
    End Sub
    Private Sub BackgroundWorkerFetchResult_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerFetchResult.DoWork
        'Fetch All Candidates
        AllCandidates = Candidate.GetAll()

        'Fetch Parties
        Parties = Party.GetAll()

        'Fetch Vote Counts
        For i = 1 To 6
            VoteCounts.Add(i, Votes.CountVotes(i))
        Next
    End Sub
    Private Sub BackgroundWorkerFetchResult_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerFetchResult.RunWorkerCompleted
        StopLoading()
        ShowWinners()
        ShowPartyChart()
        President.PerformClick()
    End Sub

End Class
