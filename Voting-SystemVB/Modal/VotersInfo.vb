Public Class VotersInfo

    Public Shared Popup As ModalPopup

    Public Sub New(item As Student)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LabelVoterID.Text = item.StudentId
        LabelPassword.Text = item.Password

        If item.HasVoted Then
            VoterStatus.FillColor = Color.Green
            VoterStatus.Text = "Done Voting"
            VoterStatus.ForeColor = Color.White
        Else
            VoterStatus.FillColor = Color.Yellow
            VoterStatus.ForeColor = Color.Black
            VoterStatus.Text = "Haven't Voted"
        End If

        LabelFullname.Text = item.Fullname
        LabelCourse.Text = item.Course
        LabelSection.Text = item.Section
        LabelYear.Text = item.YearLevel

    End Sub

    Public Shared Sub ShowPopup(item As Student)
        Popup = New ModalPopup
        Popup.Init(New VotersInfo(item))
        Popup.ShowPopup()
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Popup.ClosePopup()
    End Sub

End Class
