Imports Guna.UI2.WinForms

Public Class ManageCandidate

    Implements MainControl

    Dim Candidates As New Dictionary(Of Integer, List(Of Candidate))
    Dim PreviousButton As Guna2Button
    Dim SelectedPosition As Integer = 1

    'One instance for the whole Applications
    Private Shared Instance As ManageCandidate
    Public Shared Function GetInstance() As ManageCandidate
        If IsNothing(Instance) Then
            Instance = New ManageCandidate
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    'Display Candidates
    Public Sub LoadPosition()
        FlowLayoutPanel1.Controls.Remove(ButtonRegister)
        DisposeChild()
        For Each item As Candidate In Candidates(SelectedPosition)
            Dim ctl = New CandidateCard(item)
            If Election.HasNotStarted() Then ctl.Editable()
            FlowLayoutPanel1.Controls.Add(ctl)
            ctl.BringToFront()
        Next
        FlowLayoutPanel1.Controls.Add(ButtonRegister)
    End Sub
    Private Sub DisposeChild()
        While FlowLayoutPanel1.Controls.Count > 0
            Dim ctl = FlowLayoutPanel1.Controls(0)
            FlowLayoutPanel1.Controls.Remove(ctl)
            ctl.Dispose()
        End While
    End Sub

    'Switch Positions
    Private Sub SwitchView(sender As Guna2Button, e As EventArgs) Handles ButtonPresident.Click, ButtonVPresident.Click, ButtonSecretary.Click, ButtonTreasurer.Click, ButtonAuditor.Click, ButtonPRO.Click
        SelectedPosition = Integer.Parse(sender.Tag)
        PreviousButton = sender
        LoadPosition()
    End Sub

    'Register Candidate Button
    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim ac As New AddCandidate(SelectedPosition)
        ac.ShowPopup()
    End Sub

    'OnControl Loaded
    Private Sub ManageCandidate_Refresh() Implements MainControl.RefreshControl
        If IsNothing(PreviousButton) Then PreviousButton = ButtonPresident
        'Hide Register Button is the election already started or finish
        If Not Election.HasNotStarted() Then ButtonRegister.Visible = False
        BackgroundWorkerRefresh.RunWorkerAsync()
    End Sub

    'Background Worker Refresh Candidate
    Sub RefreshCandidate()
        If BackgroundWorkerRefresh.IsBusy Then Return
        FlowLayoutPanel1.Controls.Remove(ButtonRegister)
        DisposeChild()
        BackgroundWorkerRefresh.RunWorkerAsync()
    End Sub
    Private Sub BackgroundWorkerRefresh_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerRefresh.DoWork
        e.Result = Candidate.GetAll2()
    End Sub
    Private Sub BackgroundWorkerRefresh_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerRefresh.RunWorkerCompleted
        Candidates = e.Result
        If Not IsNothing(PreviousButton) Then PreviousButton.PerformClick()
    End Sub
    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs)
        BackgroundWorkerRefresh.RunWorkerAsync()
    End Sub
End Class
