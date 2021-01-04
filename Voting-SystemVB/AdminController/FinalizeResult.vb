Public Class FinalizeResult

    Private Shared Instance As FinalizeResult
    Private Shared AllCandidates As Dictionary(Of Integer, List(Of Candidate)) 'Position => Candidates
    Private Shared VoteCounts As New Dictionary(Of Integer, Dictionary(Of Integer, Integer)) 'Position => {Candidate => VoteCount}
    Dim Result As New Dictionary(Of Integer, Candidate)

    Public Shared Function GetInstance() As FinalizeResult
        If IsNothing(Instance) Then
            Instance = New FinalizeResult
        End If
        Return Instance
    End Function

    Private Sub FinalizeResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fetch All Candidates
        AllCandidates = Candidate.GetAll()

        'Fetch Vote Counts
        For i = 1 To 6
            VoteCounts.Add(i, Votes.CountVotes(i))
        Next

        Dim Winners As Dictionary(Of Integer, List(Of Candidate)) = GetWinners()

        For Each Winner In Winners
            Dim lblPosition = GetLabelPosition(Winner.Key)
            If Winner.Value.Count = 1 Then
                lblPosition.Tag = Winner.Value(0)
                lblPosition.Text = Winner.Value(0).Fullname
            Else
                Dim cl As New CandidateList1(Winner.Key, Winner.Value, lblPosition)
                FlowLayoutPanel1.Controls.Add(cl)
            End If
        Next

    End Sub

    Private Function GetLabelPosition(Id As Integer) As Label
        Select Case Id
            Case 1
                Return LabelPresident
            Case 2
                Return LabelVicePresident
            Case 3
                Return LabelSecretary
            Case 4
                Return Label1Treasurer
            Case 5
                Return LabelAuditor
            Case 6
                Return LabelPRO
            Case Else
                Return Nothing
        End Select
    End Function

    Private Function GetWinners() As Dictionary(Of Integer, List(Of Candidate))
        Dim Winners As New Dictionary(Of Integer, List(Of Candidate))
        For i = 1 To 6
            Dim HighestVote = VoteCounts(i).Max(Function(VoteCount) VoteCount.Value)
            Winners.Add(i, GetTopCandidates(i, HighestVote))
            GetTopCandidates(i, HighestVote).ForEach(Sub(cand) cand.SetVoteCount(HighestVote))
        Next
        Return Winners
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

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        For i = 1 To 6
            Dim lblPosition As Label = GetLabelPosition(i)
            If Not TypeOf lblPosition.Tag Is Candidate Then
                Alert.ShowAlert("No Candidate selected in " & Position.GetName(i) & " Position.", Alert.AlertType.Error)
                Result.Clear()
                Return
            End If

            Result.Add(i, lblPosition.Tag)

        Next

        If MessageBox.Show("Please Note: Once you submitted the election will officially ended", "Confirm", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Votes.FinalizeResult(Result)
            AdminPanel.GetInstance().ActivePage = Nothing
            Alert.ShowAlert("Election has officially ended", Alert.AlertType.Success)
            AdminPanel.GetInstance().Admin_Panel_Reload()
        End If

    End Sub
End Class
