Public Class CandidateCard

    Private _Candidate As Candidate

    Public Sub New(_Candidate As Candidate)
        ' This call is required by the designer.
        InitializeComponent()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
        DoubleBuffered = True

        ' Add any initialization after the InitializeComponent() call.
        Me._Candidate = _Candidate
        Me.LabelFullname.Text = _Candidate.Fullname.ToUpper()
        Me.LabelPosition.Text = "For " & Position.GetName(_Candidate.PositionID)
        Me.LabelCourse.Text = _Candidate.Course
        Me.LabelYear.Text = _Candidate.Year + " Year"
        Me.LabelTagline.Text = _Candidate.Tagline
        Me.Guna2PictureBox1.ImageLocation = _Candidate.PartyImage
        Me.LabelStudentID.Text = _Candidate.StudentStudentID
        Me.Guna2PictureBox2.ImageLocation = _Candidate.Image
        If Not IsNothing(_Candidate.Tagline) Or _Candidate.Tagline.Length > 0 Then
            Me.LabelTagline.Text = """" & _Candidate.Tagline & """"
        End If

        If Not IsNothing(_Candidate.Party) Then
            Me.LabelParty.Text = _Candidate.Party
        Else
            Me.LabelParty.Text = "Independent"
        End If
    End Sub

    Public Sub Editable()
        Me.ButtonEdit.Visible = True
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If Not Admin.GetCurrentUser().CanUpdateCandidate() Then
            Alert.ShowAlert("You don't have a privilege to perform this action", Alert.AlertType.Error)
            Return
        End If
        Dim uCandidate = New UpdateCandidate(_Candidate)
        uCandidate.ShowPopup()
    End Sub

End Class
