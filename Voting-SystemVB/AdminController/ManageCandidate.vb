Imports Guna.UI2.WinForms

Public Class ManageCandidate

    Implements MainControl

    Dim Candidates As New Dictionary(Of Integer, List(Of Candidate))
    Dim PreviousButton As Guna2Button
    Dim SelectedPosition As Integer = 1
    Private Shared Instance As ManageCandidate

    Public Shared Function GetInstance() As ManageCandidate
        If IsNothing(Instance) Then
            Instance = New ManageCandidate
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    Public Sub LoadPosition()
        FlowLayoutPanel1.Controls.Remove(ButtonRegister)
        DisposeChild()
        For Each item As Candidate In Candidates(SelectedPosition)
            Dim ctl = New CandidateCard(item)
            If Election.HasNotStarted Then ctl.Editable()
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

    Private Sub SwitchView(sender As Guna2Button, e As EventArgs) Handles ButtonPresident.Click, ButtonVPresident.Click, ButtonSecretary.Click, ButtonTreasurer.Click, ButtonAuditor.Click, ButtonPRO.Click

        'If Not IsNothing(PreviousButton) Then
        '    PreviousButton.FillColor = Color.White
        '    PreviousButton.ForeColor = Color.Black
        'End If
        If ButtonPresident.Equals(sender) Then
            SelectedPosition = Position.PRESIDENT_ID
        ElseIf ButtonVPresident.Equals(sender) Then
            SelectedPosition = Position.VICE_PRESIDENT_ID
        ElseIf ButtonSecretary.Equals(sender) Then
            SelectedPosition = Position.SECRETARY_ID
        ElseIf ButtonTreasurer.Equals(sender) Then
            SelectedPosition = Position.TREASURER_ID
        ElseIf ButtonAuditor.Equals(sender) Then
            SelectedPosition = Position.AUDITOR_ID
        ElseIf ButtonPRO.Equals(sender) Then
            SelectedPosition = Position.PRO_ID
        End If
        'sender.FillColor = Color.FromArgb(255, 164, 91)
        'sender.ForeColor = Color.White
        PreviousButton = sender
        LoadPosition()
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim ac As New AddCandidate(SelectedPosition)
        ac.ShowPopup()
    End Sub

    Private Sub ManageCandidate_Refresh() Implements MainControl.RefreshControl
        If IsNothing(PreviousButton) Then PreviousButton = ButtonPresident
        If Not Election.HasNotStarted Then ButtonRegister.Visible = False
        BackgroundWorkerRefresh.RunWorkerAsync()
    End Sub

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
