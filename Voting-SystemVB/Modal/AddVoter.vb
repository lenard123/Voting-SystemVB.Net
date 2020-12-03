Public Class AddVoter

    Private Popup As New ModalPopup()
    Private Valid() As Boolean = {False, False, False, False, False, False}
    Private LoadingAlert As Alert

    Public Sub ShowPopup()
        Popup.Init(Me)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If ValidateForm() Then
            ButtonSubmit.Enabled = False
            ButtonDiscard.Enabled = False
            LoadingAlert = Alert.ShowAlert("Registering Voters, please wait", Alert.AlertType.Info, False)
            Dim voter As New Student
            voter.StudentId = TextStudentID.Text
            voter.Firstname = TextFirstname.Text
            voter.Lastname = TextLastname.Text
            voter.YearLevel = CBYear.Text
            voter.Course = CBCourse.Text
            voter.Section = CBSection.Text
            BackgroundWorkerAddStudent.RunWorkerAsync(voter)
        End If
    End Sub


    'Validators
    Private Function ValidateForm() As Boolean
        'Trigger Validators
        TextStudentID_Leave(Nothing, Nothing)
        TextFirstname_Leave(Nothing, Nothing)
        TextLastname_Leave(Nothing, Nothing)
        CBYear_Leave(Nothing, Nothing)
        CBCourse_Leave(Nothing, Nothing)
        CBSection_Leave(Nothing, Nothing)
        Return Not Valid.Contains(False)
    End Function
    Private Sub TextStudentID_Leave(sender As Object, e As EventArgs) Handles TextStudentID.Leave
        Dim IsValid = Validator("Student ID", TextStudentID, ErrorStudentID, "required", "exact:10")
        If (IsValid) Then
            Dim checkStud = Student.Find(TextStudentID.Text)
            If Not IsNothing(checkStud) Then
                IsValid = 0
                TextStudentID.BorderColor = Color.Red
                ErrorStudentID.Text = "Student ID already exists in the database"
            End If
        End If
        Valid.SetValue(IsValid, 0)
    End Sub
    Private Sub TextFirstname_Leave(sender As Object, e As EventArgs) Handles TextFirstname.Leave
        Valid.SetValue(Validator("Firstname", TextFirstname, ErrorFirstname, "required", "min:2", "alpha"), 1)
    End Sub
    Private Sub TextLastname_Leave(sender As Object, e As EventArgs) Handles TextLastname.Leave
        Valid.SetValue(Validator("Lastname", TextLastname, ErrorLastname, "required", "min:2", "alpha"), 2)
    End Sub
    Private Sub CBYear_Leave(sender As Object, e As EventArgs) Handles CBYear.Leave
        Valid.SetValue(Validator("Year Level", CBYear, ErrorYear, "required"), 3)
    End Sub
    Private Sub CBCourse_Leave(sender As Object, e As EventArgs) Handles CBCourse.Leave
        Valid.SetValue(Validator("Course", CBCourse, ErrorCourse, "required"), 4)
    End Sub
    Private Sub CBSection_Leave(sender As Object, e As EventArgs) Handles CBSection.Leave
        Valid.SetValue(Validator("Section", CBSection, ErrorSection, "required"), 5)
    End Sub

    Private Sub ButtonDiscard_Click_1(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Popup.ClosePopup()
    End Sub

    Private Sub AddVoter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextStudentID.Select()
    End Sub

    Private Sub BackgroundWorkerAddStudent_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerAddStudent.DoWork
        e.Result = DirectCast(e.Argument, Student).Save()
    End Sub

    Private Sub BackgroundWorkerAddStudent_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerAddStudent.RunWorkerCompleted

        LoadingAlert.CloseAlert()
        ButtonSubmit.Enabled = True
        ButtonDiscard.Enabled = True

        If e.Result Then
            Alert.ShowAlert("Voter Registered Successfully.", Alert.AlertType.Success)
            Popup.ClosePopup()
            ManageVoters.GetInstance().ButtonRefresh.PerformClick()
        Else
            Alert.ShowAlert("An error occured while registering voter", Alert.AlertType.Error)
        End If
    End Sub
End Class
