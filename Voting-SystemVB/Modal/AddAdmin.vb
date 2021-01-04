Public Class AddAdmin

    Private Shared Popup As ModalPopup
    Private Priviliges As New List(Of Integer)

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup
        Popup.Init(New AddAdmin)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Popup.ClosePopup()
    End Sub

    Private Sub TogglePrivileges(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged, Guna2ToggleSwitch9.CheckedChanged, Guna2ToggleSwitch6.CheckedChanged, Guna2ToggleSwitch5.CheckedChanged, Guna2ToggleSwitch4.CheckedChanged, Guna2ToggleSwitch3.CheckedChanged, Guna2ToggleSwitch2.CheckedChanged
        Dim pSwitch = DirectCast(sender, Guna.UI2.WinForms.Guna2ToggleSwitch)
        Dim Id As Integer = pSwitch.Tag

        If pSwitch.Checked Then
            Priviliges.Add(Id)
        Else
            Priviliges.Remove(Id)
        End If

    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If Not ValidateForm() Then Return
        Dim nAdmin As New Admin
        nAdmin.Fullname = TextFullname.Text
        nAdmin.Username = TextUsername.Text
        nAdmin.Password = TextPassword.Text
        If nAdmin.Save(Priviliges) Then
            Alert.ShowAlert("Admin added successfully", Alert.AlertType.Success)
            Popup.ClosePopup()
        Else
            Alert.ShowAlert("An error occured", Alert.AlertType.Error)
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        'Validate Fullname
        If Not Util.Validator("Fullname", TextFullname, ErrorFullname, "required", "min:4") Then Return False

        'Validate Username
        If Not Util.Validator("Username", TextUsername, ErrorUsername, "required", "min:6") Then Return False
        If Admin.IsExists(TextUsername.Text) Then
            TextUsername.BorderColor = Color.Red
            ErrorUsername.Text = "Username already exists"
            Return False
        End If

        'Validate Password
        If Not Util.Validator("Password", TextPassword, ErrorPassword, "required", "min:6") Then Return False

        'Confirm Password
        If Not Util.Validator("Your Password", TextYourPassword, ErrorYourPassword, "required") Then Return False
        If Not Admin.GetCurrentUser().ComparePassword(TextYourPassword.Text) Then
            TextYourPassword.BorderColor = Color.Red
            ErrorYourPassword.Text = "Wrong Password"
            Return False
        End If

        Return True
    End Function

End Class
