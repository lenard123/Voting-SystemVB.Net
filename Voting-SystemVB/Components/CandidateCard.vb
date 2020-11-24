Public Class CandidateCard

    Private _Candidate As Candidate

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(_Candidate As Candidate)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Candidate = _Candidate
        Me.LabelFullname.Text = _Candidate.Fullname.ToUpper()
        Me.LabelPosition.Text = "For " & _Candidate.CandidatePosition
        Me.LabelCourse.Text = _Candidate.Course
        Me.LabelYear.Text = _Candidate.Year + " Year"

        If Not IsNothing(_Candidate.Tagline) Then
            Me.LabelTagline.Text = """" & _Candidate.Tagline & """"
        End If

        If Not IsNothing(_Candidate.Party) Then
            Me.LabelParty.Text = _Candidate.Party
        Else
            Me.LabelParty.Text = "Independent"
        End If

    End Sub



End Class
