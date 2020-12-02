Imports Guna.UI2.WinForms

Public Class CandidateInfo

    Implements MainControl

    Private Shared Instance As CandidateInfo
    Private CandidateCards As Dictionary(Of Integer, List(Of CandidateCard))
    Private SelectedPosition As Integer
    Private SelectedButton As Guna2Button

    Public Shared Function GetInstance() As CandidateInfo
        If IsNothing(Instance) Then
            Instance = New CandidateInfo
        End If
        Return Instance
    End Function

    Private Sub OnLoadRefresh() Implements MainControl.RefreshControl
        ButtonPresident.PerformClick()
    End Sub

    Private Sub ChangePosition(sender As Guna2Button, e As EventArgs) Handles ButtonPresident.Click, ButtonVicePresident.Click, ButtonSecretary.Click, ButtonTreasurer.Click, ButtonAuditor.Click, ButtonPRO.Click
        'Parse Tag to Integer   
        Dim tag = Integer.Parse(sender.Tag)

        'Ignore if choose the same button
        If tag = SelectedPosition Then Return

        'Set to default the Previous Button
        If Not IsNothing(SelectedButton) Then
            SelectedButton.FillColor = Color.Transparent
            SelectedButton.ForeColor = SystemColors.ControlDark
        End If

        'ActivateColor
        sender.ForeColor = Color.White
        sender.FillColor = Color.FromArgb(46, 43, 63)
        SelectedButton = sender
        SelectedPosition = tag

        LoadData()
    End Sub

    Private Async Sub LoadData()
        If IsNothing(CandidateCards) Then Await InitCards()
        FlowLayoutPanel2.Controls.Clear()
        For Each card In CandidateCards(SelectedPosition)
            FlowLayoutPanel2.Controls.Add(card)
        Next
    End Sub

    Private Async Function InitCards() As Task
        Dim Candidates = Await VotersPanel.GetCandidates()
        CandidateCards = New Dictionary(Of Integer, List(Of CandidateCard))
        For i = 1 To 6
            CandidateCards.Add(i, New List(Of CandidateCard))
            If Not Candidates.ContainsKey(i) Then Candidates.Add(i, New List(Of Candidate))
            For Each iCandidate In Candidates(i)
                CandidateCards(i).Add(New CandidateCard(iCandidate))
            Next
        Next
    End Function

End Class
