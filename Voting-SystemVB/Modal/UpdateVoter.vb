Public Class UpdateVoter

    Dim stud As Student
    Private Valid() As Boolean = {False, False, False, False, False}
    Private mv As ManageVoters

    Public Popup As New ModalPopup

    Public Sub ShowPopup()
        Popup.Init(Me)
        Popup.ShowPopup()
    End Sub

    Public Sub New(stud As Student, mv As ManageVoters)
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

        Me.mv = mv
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Popup.ClosePopup()
    End Sub

    Private Async Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If Not Valid.Contains(False) Then
            stud.Firstname = TextFirstname.Text
            stud.Lastname = TextLastname.Text
            stud.Course = CBCourse.Text
            stud.YearLevel = CBYear.Text
            stud.Section = CBSection.Text
            If stud.Update() Then
                Alert.setAlert("Updated Successfully!", Alert.AlertType.Info)
            Else
                Alert.setAlert("An error occured while updating", Alert.AlertType.Error)
            End If
            Popup.ClosePopup()
            Await mv.RefreshStudent()
        End If
    End Sub

    Private Sub TextFirstname_Leave(sender As Object, e As EventArgs) Handles TextFirstname.Leave
        Valid.SetValue(Validator("Firstname", TextFirstname, ErrorFirstname, "required", "min:2", "alpha"), 0)
    End Sub

    Private Sub TextLastname_Leave(sender As Object, e As EventArgs) Handles TextLastname.Leave
        Valid.SetValue(Validator("Lastname", TextLastname, ErrorLastname, "required", "min:2", "alpha"), 1)
    End Sub

    Private Sub CBYear_Leave(sender As Object, e As EventArgs) Handles CBYear.Leave, ButtonSubmit.Click
        Valid.SetValue(Validator("Year Level", CBYear, ErrorYear, "required"), 2)
    End Sub

    Private Sub CBCourse_Leave(sender As Object, e As EventArgs) Handles CBCourse.Leave, ButtonSubmit.Click
        Valid.SetValue(Validator("Course", CBCourse, ErrorCourse, "required"), 3)
    End Sub

    Private Sub CBSection_Leave(sender As Object, e As EventArgs) Handles CBSection.Leave, ButtonSubmit.Click
        Valid.SetValue(Validator("Section", CBSection, ErrorSection, "required"), 4)
    End Sub

End Class
