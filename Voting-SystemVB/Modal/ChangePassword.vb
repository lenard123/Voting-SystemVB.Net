Public Class ChangePassword

    Private Shared Popup As ModalPopup

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup()
        Popup.Init(New ChangePassword)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Popup.ClosePopup()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If Not ValidateForm() Then Return

        Admin.GetCurrentUser().Password = TextNewPassword.Text

        If Admin.GetCurrentUser().Update() Then
            Alert.ShowAlert("Password updated successfully", Alert.AlertType.Success)
            Popup.ClosePopup()
        Else
            Alert.ShowAlert("An error occured", Alert.AlertType.Error)
        End If

    End Sub

    Private Function ValidateForm() As Boolean
        'Validate New Password
        If Not Util.Validator("Password", TextNewPassword, ErrorNewPassword, "required", "min:6") Then Return False

        'Validate ReEnter Password
        If Not Util.Validator("ReEnter Password", TextReEnterPassword, ErrorReEnterPassword, "required") Then Return False
        If Not TextNewPassword.Text.Equals(TextReEnterPassword.Text) Then
            TextReEnterPassword.BorderColor = Color.Red
            ErrorReEnterPassword.Text = "Password not match"
            Return False
        End If

        'validate Old Password
        If Not Util.Validator("Old Password", TextOldPassword, ErrorOldPassword, "required") Then Return False
        If Not Admin.GetCurrentUser().ComparePassword(TextOldPassword.Text) Then
            TextOldPassword.BorderColor = Color.Red
            ErrorOldPassword.Text = "Wrong Password"
            Return False
        End If

        'if passed all the validations
        Return True
    End Function

End Class
