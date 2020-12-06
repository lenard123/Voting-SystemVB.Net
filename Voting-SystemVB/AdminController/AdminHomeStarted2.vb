Public Class AdminHomeStarted2

    Private Shared Instance As AdminHomeStarted2

    Public Shared Function GetInstance()
        If IsNothing(Instance) Then
            Instance = New AdminHomeStarted2()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    Private Sub AdminHomeStarted2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TotalVotersCount.Text = Student.CountAll()
        AlreadyVotedCount.Text = Votes.CountAllDone()
        RemainingVotersCount.Text = Student.CountAll - Votes.CountAllDone()


        TotalVotersCircle.Value = 100%
        AlreadyVotedCircle.Value = Votes.CountAllDone()
        RemainingVotersCircle.Value = 100% - Votes.CountAllDone()

    End Sub
End Class
