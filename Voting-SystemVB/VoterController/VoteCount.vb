Imports Guna.UI2.WinForms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class VoteCount

    Private Shared Candidates As New Dictionary(Of Integer, List(Of Candidate))
    Private Shared Results As Dictionary(Of Integer, Dictionary(Of Integer, Integer))
    Private Shared SelectedPosition = "ButtonPresident"
    Private Shared Instance As VoteCount
    Private Shared LastRefresh As Date

    Public Shared Function GetInstance() As VoteCount
        If IsNothing(Instance) Then
            Instance = New VoteCount
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    Private Sub VoteCount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Candidates = Candidate.GetAll()
        BtnRefresh.PerformClick()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Results = Votes.CountAllVotes()
        LastRefresh = Date.Now()
        Dim SelectedButton = DirectCast(PositionGroup.Controls(SelectedPosition), Guna2Button)
        SelectedPosition = Nothing
        SelectedButton.PerformClick()
    End Sub

    Private Sub DisplayChart_Click(sender As Guna2Button, e As EventArgs) Handles ButtonPresident.Click, ButtonVicePresident.Click, ButtonSecretary.Click, ButtonTreasurer.Click, ButtonAuditor.Click, ButtonPRO.Click
        If sender.Name.Equals(SelectedPosition) Then Return

        SelectedPosition = sender.Name
        Dim SelectedPositionID = Integer.Parse(sender.Tag)
        Chart1.Series.Clear()
        LabelDesc.Text = "Results as of: " & LastRefresh.ToString("hh:mm:ss tt")

        For Each item In Candidates(SelectedPositionID)
            Dim vote = GetVoteCount(item.PositionID, item.ID)

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

    Private Function GetVoteCount(PositionID As Integer, CandidateID As Integer) As Integer
        Dim Result = 0
        If Results.ContainsKey(PositionID) AndAlso Results(PositionID).ContainsKey(CandidateID) Then
            Result = Results(PositionID)(CandidateID)
        End If
        Return Result
    End Function

End Class
