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
        Me.LabelTagline.Text = _Candidate.Tagline
        Me.Guna2PictureBox1.ImageLocation = _Candidate.PartyImage
        Me.LabelStudentID.Text = _Candidate.StudentStudentID

        If Not IsNothing(_Candidate.Tagline) Then
            Me.LabelTagline.Text = """" & _Candidate.Tagline & """"
        End If

        If Not IsNothing(_Candidate.Party) Then
            Me.LabelParty.Text = _Candidate.Party
        Else
            Me.LabelParty.Text = "Independent"
        End If
        LoadImage()
    End Sub

    Async Function LoadImage() As Task
        Me.Guna2CirclePictureBox1.Image = Await Task.Run(Function()
                                                             Return Util.ConvertToImage(_Candidate.Image)
                                                         End Function)
    End Function

    Public Sub Editable()
        Me.ButtonEdit.Visible = True
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim uCandidate = New UpdateCandidate(_Candidate)
        uCandidate.ShowPopup()
    End Sub

    Private Sub CandidateCard_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If Not IsNothing(Me.Guna2CirclePictureBox1) Then
            Me.Guna2CirclePictureBox1.Image.Dispose()
        End If
    End Sub
End Class
