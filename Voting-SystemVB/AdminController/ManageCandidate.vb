Imports Guna.UI2.WinForms

Public Class ManageCandidate

    Dim PreviousButton As Guna2Button
    Dim SelectedPosition As Integer
    Private Shared Instance As ManageCandidate

    Public Shared Function GetInstance() As ManageCandidate
        If IsNothing(Instance) Then
            Instance = New ManageCandidate
        End If
        Return Instance
    End Function

    Public Async Function LoadPosition(Position As Integer) As Task
        Dim Rs = Await Candidate.GetAllByPositionAsync(Position)
        FlowLayoutPanel1.Controls.Remove(ButtonRegister)
        DisposeChild()
        For Each item As Candidate In Rs
            Dim ctl = New CandidateCard(item)
            If Election.HasNotStarted Then ctl.Editable()
            FlowLayoutPanel1.Controls.Add(ctl)
            ctl.BringToFront()
        Next
        FlowLayoutPanel1.Controls.Add(ButtonRegister)
        SelectedPosition = Position
    End Function

    Private Sub DisposeChild()
        While FlowLayoutPanel1.Controls.Count > 0
            Dim ctl = FlowLayoutPanel1.Controls(0)
            FlowLayoutPanel1.Controls.Remove(ctl)
            ctl.Dispose()
        End While
    End Sub

    Private Async Sub SwitchView(sender As Object, e As EventArgs) Handles ButtonPresident.Click, ButtonVPresident.Click, ButtonSecretary.Click, ButtonTreasurer.Click, ButtonAuditor.Click, ButtonPRO.Click
        If (sender.Equals(PreviousButton)) Then Return
        PreviousButton.FillColor = Color.White
        PreviousButton.ForeColor = Color.Black
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
        Await LoadPosition(SelectedPosition)
        DirectCast(sender, Guna2Button).FillColor = Color.FromArgb(255, 164, 91)
        DirectCast(sender, Guna2Button).ForeColor = Color.White
        PreviousButton = sender
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim ac As New AddCandidate(SelectedPosition)
        ac.ShowPopup()
    End Sub

    Private Async Sub ManageCandidate_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        PreviousButton = ButtonPresident
        If Not Election.HasNotStarted Then ButtonRegister.Visible = False
        Await LoadPosition(Position.PRESIDENT_ID)
    End Sub
End Class
