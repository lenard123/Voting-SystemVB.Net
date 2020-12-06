Imports System.Windows.Forms.DataVisualization.Charting

Public Class AdminHomeStarted2

    Private Shared Instance As AdminHomeStarted2
    Private Shared StudentsCount As Integer = 0
    Private Shared VotersCount As Integer = 0
    Private Shared Candidates As New Dictionary(Of Integer, List(Of Candidate))
    Private Shared SelectedPosition = 1

    Public Shared Function GetInstance()
        If IsNothing(Instance) Then
            Instance = New AdminHomeStarted2()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    Private Sub StartLoading()
        TotalVotersCircle.Value = 50
        AlreadyVotedCircle.Value = 50
        RemainingVotersCircle.Value = 50
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

    Private Sub AdminHomeStarted2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartLoading()
        BackgroundWorkerInit.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorkerInit_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerInit.DoWork
        StudentsCount = Student.CountAll()
        VotersCount = Votes.CountAllDone()
        Candidates = Candidate.GetAll2()
    End Sub

    Private Sub BackgroundWorkerInit_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerInit.RunWorkerCompleted
        President.PerformClick()
    End Sub

    Public Sub RefreshData()
        If BackgroundWorkerRefresh.IsBusy Then Return
        StartLoading()

        BackgroundWorkerRefresh.RunWorkerAsync(SelectedPosition)

    End Sub

    Private Sub BackgroundWorkerRefresh_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerRefresh.DoWork
        VotersCount = Votes.CountAllDone()
        e.Result = Votes.CountVotes(e.Argument)
    End Sub

    Private Sub BackgroundWorkerRefresh_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerRefresh.RunWorkerCompleted
        StopLoading()

        Dim Tally As Dictionary(Of Integer, Integer) = e.Result

        Chart1.Series.Clear()

        ShowCandidates.Text = "Results as of: " & Date.Now().ToString("hh:mm:ss tt")
        For Each item In Candidates(SelectedPosition)
            Dim vote = 0
            If Tally.ContainsKey(item.ID) Then vote = Tally(item.ID)

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

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs)
        RefreshData()
    End Sub

    Private Sub DisplayChart(sender As Object, e As EventArgs) Handles President.Click, VPresident.Click, Treasurer.Click, Secretary.Click, PRO.Click, Auditor.Click
        SelectedPosition = Integer.Parse(sender.tag)
        RefreshData()
    End Sub
End Class

