Imports System.Data.OleDb

Public Class VoteNow

    Private Shared Instance As VoteNow
    Private Shared Labels As New List(Of Label)
    Private Shared _CandidateList As New List(Of CandidateList)
    Private Shared LoadingAlert As Alert

    Public Shared Function GetInstance() As VoteNow
        If IsNothing(Instance) Then
            Instance = New VoteNow
            Instance.DoubleBuffered = True
            Labels.Add(Instance.LabelPresident)
            Labels.Add(Instance.LabelVicePresident)
            Labels.Add(Instance.LabelSecretary)
            Labels.Add(Instance.Label1Treasurer)
            Labels.Add(Instance.LabelAuditor)
            Labels.Add(Instance.LabelPRO)
        End If
        Return Instance
    End Function

    Private Sub VoteNow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Candidates = VotersPanel.GetCandidates()
        For i = 1 To 6
            Dim cl As New CandidateList(i, Candidates(i), Labels(i - 1))
            _CandidateList.Add(cl)
            FlowLayoutPanel1.Controls.Add(cl)
        Next
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        For Each item In _CandidateList
            item.ClearSelected()
        Next
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If Validator() Then
            If MessageBox.Show("Please Note: You can not undone once submitted.", "Confirm", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                'ButtonSubmit.Enabled = False
                'ButtonClear.Enabled = False
                LoadingAlert = Alert.ShowAlert("Submitting Vote, please wait...", Alert.AlertType.Info, False)
                BackgroundWorkerSubmitVote.RunWorkerAsync(GetVotes())
            End If
        End If
    End Sub

    Private Function Validator() As Boolean
        Dim id = 1
        For Each item In Labels
            If IsNothing(item.Tag) OrElse item.Tag.Equals("") OrElse Not TypeOf item.Tag Is Candidate Then
                Alert.ShowAlert("No candidate selected in " & Position.GetName(id) & " Position.", Alert.AlertType.Error)
                Return False
            End If
            id += 1
        Next

        Return True
    End Function

    Private Function GetVotes() As List(Of Integer)
        Dim Result As New List(Of Integer)
        For Each item In Labels
            Result.Add(DirectCast(item.Tag, Candidate).ID)
        Next
        Return Result
    End Function

    Private Sub BackgroundWorkerSubmitVote_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSubmitVote.DoWork
        Try
            Votes.SubmitVotes(e.Argument)
        Catch ex As Exception
            e.Result = ex
        End Try
    End Sub

    Private Sub BackgroundWorkerSubmitVote_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerSubmitVote.RunWorkerCompleted
        LoadingAlert.CloseAlert()
        ButtonSubmit.Enabled = True
        ButtonClear.Enabled = True

        If TypeOf e.Result Is Exception Then
            Alert.ShowAlert(DirectCast(e.Result, Exception).Message, Alert.AlertType.Error)
        Else
            VotersPanel.GetInstance().GotoButton = VotersPanel.GetInstance().ButtonVoteInfo
            VotersPanel.GetInstance().RefreshControl()
            Alert.ShowAlert("Vote Submitted Successfully", Alert.AlertType.Success)
        End If
    End Sub
End Class
