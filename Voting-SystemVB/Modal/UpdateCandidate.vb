Public Class UpdateCandidate

    Dim sCandidate As Candidate
    Dim Popup As New ModalPopup()

    Public Sub New(sCandidate As Candidate)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.sCandidate = sCandidate
        Guna2PictureBox1.ImageLocation = sCandidate.Image
        TextVoter.Text = sCandidate.StudentStudentID
        TextFullname.Text = sCandidate.Fullname
        TextCYS.Text = sCandidate.Course & "-" & sCandidate.Year & " year"

        CBPosition.DataSource = Position.GetDatatable()
        CBPosition.ValueMember = "id"
        CBPosition.DisplayMember = "name"
        CBPosition.SelectedValue = sCandidate.PositionID

        TextTagline.Text = sCandidate.Tagline

    End Sub

    Public Sub ShowPopup()
        Popup.Init(Me)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Popup.ClosePopup()
    End Sub

    Private Sub ButtonSelectPicture_Click(sender As Object, e As EventArgs) Handles ButtonSelectPicture.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Guna2PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Async Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        sCandidate.Image = Guna2PictureBox1.ImageLocation
        sCandidate.Tagline = TextTagline.Text
        Me.Enabled = False
        Alert.setAlert("Updating Candidate information, please wait", Alert.AlertType.Info)
        Await UpdateCandidate()
    End Sub

    Private Async Function UpdateCandidate() As Task
        Dim res = Await sCandidate.UpdateAsync()
        Await ManageCandidate.GetInstance().LoadPosition(sCandidate.PositionID)
        If res Then
            Alert.setAlert("Updated Successfully", Alert.AlertType.Success)
        Else
            Alert.setAlert("An error occurred", Alert.AlertType.Error)
        End If
        Popup.ClosePopup()
    End Function

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Guna2PictureBox1.ImageLocation = ""
    End Sub
End Class
