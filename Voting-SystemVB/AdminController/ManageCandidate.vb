Imports Guna.UI2.WinForms

Public Class ManageCandidate

    Dim PreviousButton As Guna2Button
    Dim ResultSet As List(Of Candidate)
    Dim SelectedPosition As Integer

    Private ReadOnly Property FilteredResultSet
        Get
            Dim FilteredRS As New List(Of Candidate)
            For Each item In ResultSet
                If item.PositionID = SelectedPosition Then
                    FilteredRS.Add(item)
                End If
            Next
            Return FilteredRS
        End Get
    End Property

    Private Sub ManageCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCandidate()
        PreviousButton = ButtonPresident
        LoadPosition(Position.PRESIDENT_ID)
    End Sub

    Private Sub RefreshCandidate()
        ResultSet = Candidate.GetAll()
    End Sub

    Private Sub LoadPosition(Position As Integer)
        SelectedPosition = Position
        FlowLayoutPanel1.Controls.Remove(ButtonRegister)
        DisposeChild()
        For Each item As Candidate In FilteredResultSet
            FlowLayoutPanel1.Controls.Add(New CandidateCard(item))
        Next
        FlowLayoutPanel1.Controls.Add(ButtonRegister)
    End Sub

    Private Sub DisposeChild()
        While FlowLayoutPanel1.Controls.Count > 1
            FlowLayoutPanel1.Controls(1).Dispose()
        End While
    End Sub

    Private Sub SwitchView(sender As Object, e As EventArgs) Handles ButtonPresident.Click, ButtonVPresident.Click, ButtonSecretary.Click, ButtonTreasurer.Click, ButtonAuditor.Click, ButtonPRO.Click
        If (sender.Equals(PreviousButton)) Then Return
        PreviousButton.FillColor = Color.White
        PreviousButton.ForeColor = Color.Black
        If ButtonPresident.Equals(sender) Then
            LoadPosition(Position.PRESIDENT_ID)
        ElseIf ButtonVPresident.Equals(sender) Then
            LoadPosition(Position.VICE_PRESIDENT_ID)
        ElseIf ButtonSecretary.Equals(sender) Then
            LoadPosition(Position.SECRETARY_ID)
        ElseIf ButtonTreasurer.Equals(sender) Then
            LoadPosition(Position.TREASURER_ID)
        ElseIf ButtonAuditor.Equals(sender) Then
            LoadPosition(Position.AUDITOR_ID)
        ElseIf ButtonPRO.Equals(sender) Then
            LoadPosition(Position.PRO_ID)
        End If
        DirectCast(sender, Guna2Button).FillColor = Color.FromArgb(255, 164, 91)
        DirectCast(sender, Guna2Button).ForeColor = Color.White
        PreviousButton = sender
    End Sub

End Class
