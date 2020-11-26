Public Class AddCandidate

    Private Popup As New ModalPopup
    Dim IsValid = False
    Dim sStudent As Student

    Public Sub New(PositionID As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        CBPosition.DataSource = Position.GetDatatable()
        CBPosition.ValueMember = "id"
        CBPosition.DisplayMember = "name"
        CBPosition.SelectedValue = PositionID

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
            sStudent = Student.Find(TextVoter.Text)
            If IsNothing(sStudent) Then
                TextVoter.BorderColor = Color.Red
                ErrorVoter.Text = "Can not find voters id"
                IsValid = False
            Else
                If sStudent.IsCandidate() Then
                    TextVoter.BorderColor = Color.Red
                    ErrorVoter.Text = "This voter is already registered as candidate"
                Else
                    TextFullname.Text = sStudent.Fullname
                    TextCYS.Text = sStudent.Course & "-" & sStudent.YearLevel & "-" & sStudent.Section
                End If
            End If
        End If
    End Sub

    Private Sub ButtonSelectPicture_Click(sender As Object, e As EventArgs) Handles ButtonSelectPicture.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Guna2PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        TextVoter_Leave(sender, e)
        If IsValid Then
            ButtonSave.Enabled = False
            ButtonSave.Text = "Saving"
            ButtonDiscard.Enabled = False
            Save()
        End If
    End Sub

    Private Async Function Save() As Task
        Dim nCandidate = New Candidate(sStudent.Id)
        nCandidate.Tagline = TextTagline.Text
        nCandidate.Image = Guna2PictureBox1.ImageLocation
        nCandidate.PositionID = CBPosition.SelectedValue
        Dim Res = Await nCandidate.SaveAsync()
        If Res Then
            Alert.setAlert("Candidate Registered Successfully", Alert.AlertType.Success)
        Else
            Alert.setAlert("An error occured", Alert.AlertType.Error)
        End If
        ButtonSave.Enabled = True
        ButtonSave.Text = "Save"
        ButtonDiscard.Enabled = True
        Popup.ClosePopup()
        ManageCandidate.GetInstance().LoadPosition(CBPosition.SelectedValue)
    End Function

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Guna2PictureBox1.ImageLocation = ""
    End Sub
End Class
