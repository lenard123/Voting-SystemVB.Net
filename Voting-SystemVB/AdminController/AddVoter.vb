Public Class AddVoter

    Private Popup As New ModalPopup()
    Private Valid() As Boolean = {False, False, False, False, False, False}

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Popup.ClosePopup()
    End Sub

    Public Sub ShowPopup()
        Popup.Init(Me)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If ValidateForm() Then
            Dim voter As New Student
            voter.StudentId = TextStudentID.Text
            voter.Firstname = TextFirstname.Text
            voter.Lastname = TextLastname.Text
            voter.YearLevel = CBYear.Text
            voter.Course = CBCourse.Text
            voter.Section = CBSection.Text
            If voter.Save() Then
                Alert.ShowAlert("Voter Registered Successfully.", Alert.AlertType.Success)
            Else
                Alert.ShowAlert("An error occured while registering voter", Alert.AlertType.Error)
            End If
            Popup.ClosePopup()
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        Return Not Valid.Contains(False)
    End Function

    Private Sub TextStudentID_Leave(sender As Object, e As EventArgs) Handles TextStudentID.Leave, ButtonSubmit.Click
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

    Private Sub TextFirstname_Leave(sender As Object, e As EventArgs) Handles TextFirstname.Leave, ButtonSubmit.Click
        Valid.SetValue(Validator("Firstname", TextFirstname, ErrorFirstname, "required", "min:2"), 1)
    End Sub

    Private Sub TextLastname_Leave(sender As Object, e As EventArgs) Handles TextLastname.Leave, ButtonSubmit.Click
        Valid.SetValue(Validator("Lastname", TextLastname, ErrorLastname, "required", "min:2"), 2)
    End Sub

    Private Sub CBYear_Leave(sender As Object, e As EventArgs) Handles CBYear.Leave, ButtonSubmit.Click
        Valid.SetValue(Validator("Year Level", CBYear, ErrorYear, "required"), 3)
    End Sub

    Private Sub CBCourse_Leave(sender As Object, e As EventArgs) Handles CBCourse.Leave, ButtonSubmit.Click
        Valid.SetValue(Validator("Course", CBCourse, ErrorCourse, "required"), 4)
    End Sub

    Private Sub CBSection_Leave(sender As Object, e As EventArgs) Handles CBSection.Leave, ButtonSubmit.Click
        Valid.SetValue(Validator("Section", CBSection, ErrorSection, "required"), 5)
    End Sub
End Class
