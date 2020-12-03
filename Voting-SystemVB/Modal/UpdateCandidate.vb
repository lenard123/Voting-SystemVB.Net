Public Class UpdateCandidate

    Dim sCandidate As Candidate
    Dim LoadingAlert As Alert
    Public Popup As ModalPopup

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
        Popup = New ModalPopup()
        Popup.Init(Me)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Popup.ClosePopup()
    End Sub

    Private Sub ButtonSelectPicture_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Guna2PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        sCandidate.Image = Guna2PictureBox1.ImageLocation
        sCandidate.Tagline = TextTagline.Text

        ButtonCancel.Enabled = False
        ButtonUpdate.Enabled = False

        LoadingAlert = Alert.ShowAlert("Updating Candidate information, please wait", Alert.AlertType.Info, False)

        BackgroundWorkerUpdate.RunWorkerAsync()

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Guna2PictureBox1.ImageLocation = Candidate.IMAGE_DEFAULT
    End Sub

    Private Sub BackgroundWorkerUpdate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerUpdate.DoWork
        e.Result = sCandidate.Update()
    End Sub

    Private Sub BackgroundWorkerUpdate_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerUpdate.RunWorkerCompleted

        ButtonCancel.Enabled = True
        ButtonUpdate.Enabled = True
        LoadingAlert.CloseAlert()

        If e.Result Then
            Alert.setAlert("Updated Successfully", Alert.AlertType.Success)
            ManageCandidate.GetInstance().RefreshCandidate()
            Popup.ClosePopup()
        Else
            Alert.setAlert("An error occurred", Alert.AlertType.Error)
        End If
    End Sub
End Class
