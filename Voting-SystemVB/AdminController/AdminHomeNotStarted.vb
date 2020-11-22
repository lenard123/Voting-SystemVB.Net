Public Class AdminHomeNotStarted

    Private Sub AdminHomeNotStarted_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VoterCount.Text = Student.CountAll() & " Student(s)"
        PresidentCount.Text = Candidate.Count(Position.PRESIDENT_ID) & " Candidate(s)"
        ViceCount.Text = Candidate.Count(Position.VICE_PRESIDENT_ID) & " Candidate(s)"
        SecretaryCount.Text = Candidate.Count(Position.SECRETARY_ID) & " Candidate(s)"
        TreasurerCount.Text = Candidate.Count(Position.TREASURER_ID) & " Candidate(s)"
        AuditorCount.Text = Candidate.Count(Position.AUDITOR_ID) & " Candidate(s)"
        PROCount.Text = Candidate.Count(Position.PRO_ID) & " Candidate(s)"
    End Sub
End Class
