Imports Guna.UI2.WinForms
Imports System.ComponentModel

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
        If Not IsNothing(CandidateCards) Then ButtonPresident.PerformClick()
    End Sub

    Private Sub ChangePosition(sender As Object, e As EventArgs) Handles ButtonPresident.Click, ButtonVicePresident.Click, ButtonSecretary.Click, ButtonTreasurer.Click, ButtonAuditor.Click, ButtonPRO.Click
        'Parse Tag to Integer
        sender = DirectCast(sender, Guna2Button)
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

        LoadPanel()
    End Sub

    Sub LoadPanel()
        FlowLayoutPanel2.Controls.Clear()
        For Each card In CandidateCards(SelectedPosition)
            FlowLayoutPanel2.Controls.Add(card)
        Next
    End Sub


    Private Sub InitCards()
        Dim Candidates = VotersPanel.GetCandidates()
        CandidateCards = New Dictionary(Of Integer, List(Of CandidateCard))
        For i = 1 To 6
            CandidateCards.Add(i, New List(Of CandidateCard))
            If Not Candidates.ContainsKey(i) Then Candidates.Add(i, New List(Of Candidate))
            For Each iCandidate In Candidates(i)
                CandidateCards(i).Add(New CandidateCard(iCandidate))
            Next
        Next
    End Sub

    Private Sub CandidateInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        InitCards()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ButtonPresident.PerformClick()
    End Sub
End Class
