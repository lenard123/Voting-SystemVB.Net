Public Class AddCandidate

    Public Popup As New ModalPopup
    Dim IsValid = False
    Dim sStudent As Student
    Dim loadingAlert As Alert

    Public Sub New(PositionID As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CBPosition.DataSource = Position.GetDatatable()
        CBPosition.ValueMember = "id"
        CBPosition.DisplayMember = "name"
        CBPosition.SelectedValue = PositionID
        Guna2PictureBox1.ImageLocation = Candidate.IMAGE_DEFAULT

    End Sub

    Public Sub New(rStudent As Student)
        InitializeComponent()

        CBPosition.DataSource = Position.GetDatatable()
        CBPosition.ValueMember = "id"
        CBPosition.DisplayMember = "name"

        TextVoter.Select()
        TextVoter.Text = rStudent.StudentId
        CBPosition.Select()
        Guna2PictureBox1.ImageLocation = Candidate.IMAGE_DEFAULT
    End Sub

    Public Sub ShowPopup()
        Popup.Init(Me)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Popup.ClosePopup()
    End Sub

    Private Sub TextVoter_Leave(sender As Object, e As EventArgs) Handles TextVoter.Leave
        IsValid = Util.Validator("Voters id", TextVoter, ErrorVoter, "required")
        If IsValid Then
            Try
                sStudent = Student.Find(TextVoter.Text)
                If sStudent.IsCandidate() Then
                    TextVoter.BorderColor = Color.Red
                    ErrorVoter.Text = "This voter is already registered as candidate"
                    IsValid = False
                Else
                    TextFullname.Text = sStudent.Fullname
                    TextCYS.Text = sStudent.Course & "-" & sStudent.YearLevel & "-" & sStudent.Section
                End If
            Catch ex As StudentNotExistsException
                TextVoter.BorderColor = Color.Red
                ErrorVoter.Text = ex.Message
                IsValid = False
            End Try
        End If
    End Sub

    Private Sub ButtonSelectPicture_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Guna2PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        TextVoter_Leave(sender, e)
        If IsValid Then
            ButtonSave.Enabled = False
            ButtonDiscard.Enabled = False
            loadingAlert = Alert.ShowAlert("Saving...", Alert.AlertType.Info, False)

            Dim nCandidate = New Candidate(sStudent.Id)
            loadingAlert.CloseAlert()
            nCandidate.Tagline = TextTagline.Text
            nCandidate.Image = Guna2PictureBox1.ImageLocation
            nCandidate.PositionID = CBPosition.SelectedValue

            BackgroundWorkerSave.RunWorkerAsync(nCandidate)

        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Guna2PictureBox1.ImageLocation = Candidate.IMAGE_DEFAULT
    End Sub

    Private Sub BackgroundWorkerSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSave.DoWork
        Try
            DirectCast(e.Argument, Candidate).Save()
        Catch ex As Exception
            e.Result = ex
        End Try
    End Sub

    Private Sub BackgroundWorkerSave_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerSave.RunWorkerCompleted
        ButtonSave.Enabled = True
        ButtonDiscard.Enabled = True
        loadingAlert.CloseAlert()

        If TypeOf e.Result Is Exception Then
            Alert.ShowAlert(DirectCast(e.Result, Exception).Message, Alert.AlertType.Error)
        Else
            Alert.setAlert("Candidate Registered Successfully", Alert.AlertType.Success)
            Popup.ClosePopup()
            ManageCandidate.GetInstance().RefreshCandidate()
        End If

    End Sub

End Class
