Public Class RecoverAccount

    Private Shared Popup As ModalPopup
    Private Shared Admins As List(Of Admin)

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup()
        Popup.Init(New RecoverAccount)
        Popup.ShowPopup()
    End Sub

    Private Sub RecoverAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBUsername.DataSource = GetDataTable()
        CBUsername.DisplayMember = "username"
        CBUsername.ValueMember = "listindex"
    End Sub

    Private Function GetDataTable() As DataTable
        Dim Result As New DataTable
        Admins = Admin.GetAll()
        Result.Columns.Add("listindex")
        Result.Columns.Add("username")
        Result.Rows.Add(-1, "Select Sub Admin Username")
        For i = 0 To Admins.Count - 1
            If Admins(i).Username.Equals(Admin.GetCurrentUser().Username) Then Continue For
            Result.Rows.Add(i, Admins(i).Username)
        Next
        Return Result
    End Function


    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Popup.ClosePopup()
    End Sub

    Private Sub CBUsername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUsername.SelectedValueChanged
        Dim sAdmin = GetSelected()
        If Not IsNothing(sAdmin) Then
            TextFullname.Text = sAdmin.Fullname
            TextNewPassword.Enabled = True
        Else
            TextFullname.Text = ""
            TextNewPassword.Text = ""
            TextNewPassword.Enabled = False
        End If
    End Sub

    Private Function GetSelected() As Admin
        Return Admins.Find(Function(a As Admin) a.Username.Equals(CBUsername.Text))
    End Function

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If Not ValidateForm() Then Return

        Dim uAdmin = GetSelected()
        uAdmin.Password = TextNewPassword.Text

        If uAdmin.Update() Then
            Alert.ShowAlert("Password updated successfully", Alert.AlertType.Success)
            Popup.ClosePopup()
        Else
            Alert.ShowAlert("An error occured", Alert.AlertType.Error)
        End If

    End Sub

    Private Function ValidateForm() As Boolean
        If IsNothing(GetSelected()) Then
            Alert.ShowAlert("Select the username first", Alert.AlertType.Error)
            Return False
        End If

        If Not Util.Validator("Password", TextNewPassword, ErrorNewPassword, "required", "min:6") Then Return False

        If Not Util.Validator("Your Password", TextYourPassword, ErrorYourPassword, "required") Then Return False
        If Not Admin.GetCurrentUser().ComparePassword(TextYourPassword.Text) Then
            TextYourPassword.BorderColor = Color.Red
            ErrorYourPassword.Text = "Wrong Password"
            Return False
        End If

        Return True
    End Function

End Class
