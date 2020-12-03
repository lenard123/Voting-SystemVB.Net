Public Class UpdateVoter

    Dim stud As Student
    Private Valid() As Boolean = {False, False, False, False, False}
    Public Popup As New ModalPopup
    Private LoadingAlert As Alert

    Public Sub ShowPopup()
        Popup.Init(Me)
        Popup.ShowPopup()
    End Sub

    Public Sub New(stud As Student)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.stud = stud
        TextStudentID.Text = stud.StudentId
        TextFirstname.Text = stud.Firstname
        TextLastname.Text = stud.Lastname
        CBCourse.Text = stud.Course
        CBYear.Text = stud.YearLevel.Substring(0, 3)
        CBSection.Text = stud.Section

        If Election.HasNotStarted Then
            If stud.IsCandidate() Then
                ButtonUpdateCandidate.Visible = True
            Else
                ButtonRegisterCandidate.Visible = True
            End If
        End If

        TextStudentID.Enabled = False
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Popup.ClosePopup()
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If ValidateForm() Then
            stud.Firstname = TextFirstname.Text
            stud.Lastname = TextLastname.Text
            stud.Course = CBCourse.Text
            stud.YearLevel = CBYear.Text
            stud.Section = CBSection.Text

            ButtonSubmit.Enabled = False
            ButtonDiscard.Enabled = False

            LoadingAlert = Alert.ShowAlert("Updating Voters information please wait", Alert.AlertType.Info, False)

            BackgroundWorkerUpdate.RunWorkerAsync(stud)
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        TextFirstname_Leave(Nothing, Nothing)
        TextLastname_Leave(Nothing, Nothing)
        CBYear_Leave(Nothing, Nothing)
        CBCourse_Leave(Nothing, Nothing)
        CBSection_Leave(Nothing, Nothing)
        Return Not Valid.Contains(False)
    End Function

    Private Sub TextFirstname_Leave(sender As Object, e As EventArgs) Handles TextFirstname.Leave
        Valid.SetValue(Validator("Firstname", TextFirstname, ErrorFirstname, "required", "min:2", "alpha"), 0)
    End Sub

    Private Sub TextLastname_Leave(sender As Object, e As EventArgs) Handles TextLastname.Leave
        Valid.SetValue(Validator("Lastname", TextLastname, ErrorLastname, "required", "min:2", "alpha"), 1)
    End Sub

    Private Sub CBYear_Leave(sender As Object, e As EventArgs) Handles CBYear.Leave
        Valid.SetValue(Validator("Year Level", CBYear, ErrorYear, "required"), 2)
    End Sub

    Private Sub CBCourse_Leave(sender As Object, e As EventArgs) Handles CBCourse.Leave
        Valid.SetValue(Validator("Course", CBCourse, ErrorCourse, "required"), 3)
    End Sub

    Private Sub CBSection_Leave(sender As Object, e As EventArgs) Handles CBSection.Leave
        Valid.SetValue(Validator("Section", CBSection, ErrorSection, "required"), 4)
    End Sub

    Private Sub BackgroundWorkerUpdate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerUpdate.DoWork
        e.Result = DirectCast(e.Argument, Student).Update()
    End Sub

    Private Sub BackgroundWorkerUpdate_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerUpdate.RunWorkerCompleted
        LoadingAlert.CloseAlert()
        ButtonDiscard.Enabled = True
        ButtonSubmit.Enabled = True
        If e.Result Then
            Alert.setAlert("Updated Successfully!", Alert.AlertType.Info)
            ManageVoters.GetInstance().ButtonRefresh.PerformClick()
            Popup.ClosePopup()
        Else
            Alert.setAlert("An error occured while updating", Alert.AlertType.Error)
        End If
    End Sub

    Private Sub ButtonRegisterCandidate_Click(sender As Object, e As EventArgs) Handles ButtonRegisterCandidate.Click
        Dim ac = New AddCandidate(stud)
        ac.Popup = Popup
        Popup.ChangeContent(ac)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonUpdateCandidate_Click(sender As Object, e As EventArgs) Handles ButtonUpdateCandidate.Click
        Dim uc = New UpdateCandidate(Candidate.FindByStudentID(stud.Id))
        uc.Popup = Popup
        Popup.ChangeContent(uc)
        Popup.ShowPopup()
    End Sub
End Class
