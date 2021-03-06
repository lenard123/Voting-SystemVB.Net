﻿' Good Luck sa nag babasa netong code nato
' Kahit ako di ko na maintindihan
' saka nakaka tamad irefactor

Imports System.Windows.Forms.DataVisualization.Charting
Imports Guna.UI2.WinForms

Public Class AdminHomeStarted

    Private Shared StudentsCount As Integer = 0
    Private Shared VotersCount As Integer = 0
    Private Shared Candidates As New Dictionary(Of Integer, List(Of Candidate))
    Private Shared SelectedPosition As Guna2Button
    Private Shared Results As New Dictionary(Of Integer, Dictionary(Of Integer, Integer))
    Private Shared LastRefresh As Date

    'Creates Only One Instances
    Private Shared Instance As AdminHomeStarted
    Public Shared Function GetInstance()
        If IsNothing(Instance) Then
            Instance = New AdminHomeStarted()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    Private Sub StartLoading()
        TotalVotersCircle.Animated = True
        AlreadyVotedCircle.Animated = True
        RemainingVotersCircle.Animated = True
    End Sub
    Private Sub StopLoading()
        TotalVotersCircle.Value = 100
        AlreadyVotedCircle.Value = VotersCount / StudentsCount * 100
        RemainingVotersCircle.Value = (StudentsCount - VotersCount) / StudentsCount * 100

        TotalVotersCount.Text = StudentsCount
        AlreadyVotedCount.Text = VotersCount
        RemainingVotersCount.Text = StudentsCount - VotersCount

        TotalVotersCircle.Animated = False
        AlreadyVotedCircle.Animated = False
        RemainingVotersCircle.Animated = False
    End Sub

    'Fetch Initial Data When the Panel Loaded for the first time
    Private Sub AdminHomeStarted2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartLoading()
        BackgroundWorkerInit.RunWorkerAsync()
    End Sub
    Private Sub BackgroundWorkerInit_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerInit.DoWork
        StudentsCount = Student.CountAll()
        VotersCount = Votes.CountAllDone()
        Candidates = Candidate.GetAll()
    End Sub
    Private Sub BackgroundWorkerInit_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerInit.RunWorkerCompleted
        President.PerformClick()
        RefreshData()
    End Sub

    'Refresh Data
    Public Sub RefreshData()
        If BackgroundWorkerRefresh.IsBusy Then Return
        StartLoading()
        BackgroundWorkerRefresh.RunWorkerAsync()
    End Sub
    Private Sub BackgroundWorkerRefresh_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerRefresh.DoWork
        VotersCount = Votes.CountAllDone()
        Results = Votes.CountAllVotes
        LastRefresh = Date.Now()
    End Sub
    Private Sub BackgroundWorkerRefresh_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerRefresh.RunWorkerCompleted
        StopLoading()
        DisplayChart()
    End Sub

    Private Function GetVoteCount(item As Candidate) As Integer
        Dim Result = 0
        If Results.ContainsKey(item.PositionID) AndAlso Results(item.PositionID).ContainsKey(item.ID) Then
            Result = Results(item.PositionID)(item.ID)
        End If
        Return Result
    End Function

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        RefreshData()
    End Sub

    'Display Chart
    Private Sub ButtonPosition_Click(sender As Guna2Button, e As EventArgs) Handles President.Click, VPresident.Click, Treasurer.Click, Secretary.Click, PRO.Click, Auditor.Click
        SelectedPosition = sender
        DisplayChart()
    End Sub

    Private Sub DisplayChart()
        Chart1.Series.Clear()
        Dim SelectedPositionID = Integer.Parse(SelectedPosition.Tag)
        ShowCandidates.Text = "Results as of: " & LastRefresh.ToString("hh:mm:ss tt")
        For Each item In Candidates(SelectedPositionID)
            Dim vote = GetVoteCount(item)
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

End Class

