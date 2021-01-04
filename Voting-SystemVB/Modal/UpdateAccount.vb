Public Class UpdateAccount

    Private Shared Popup As ModalPopup

    Private CurrentUser As Admin

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CurrentUser = Admin.GetCurrentUser()

        TextFullname.Text = CurrentUser.Fullname
        TextUsername.Text = CurrentUser.Username

    End Sub

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup()
        Popup.Init(New UpdateAccount)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Popup.ClosePopup()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If Not ValidateForm() Then Return

        CurrentUser.Fullname = TextFullname.Text
        CurrentUser.Username = TextUsername.Text

        If CurrentUser.Update() Then
            Alert.ShowAlert("Account updated Successfully", Alert.AlertType.Success)
            AdminPanel.GetInstance().LabelFullname.Text = CurrentUser.Fullname
            Popup.ClosePopup()
        Else
            Alert.ShowAlert("An error occured", Alert.AlertType.Error)
        End If

    End Sub

    Public Function ValidateForm() As Boolean
        'Validate FullName
        If Not Util.Validator("Fullname", TextFullname, ErrorFullname, "required", "min:4") Then Return False

        'Validate Username
        If Not Util.Validator("Username", TextUsername, ErrorUsername, "required", "min:6") Then Return False
        If Not CurrentUser.Username.Equals(TextUsername.Text) AndAlso Admin.IsExists(TextUsername.Text) Then
            TextUsername.BorderColor = Color.Red
            ErrorUsername.Text = "Username already exists"
            Return False
        End If

        'Validate Password
        If Not Util.Validator("Password", TextPassword, ErrorPassword, "required") Then Return False
        If Not CurrentUser.ComparePassword(TextPassword.Text) Then
            ErrorPassword.Text = "Password Not match"
            TextPassword.BorderColor = Color.Red
            Return False
        End If

        'If all validation passed
        Return True
    End Function

End Class
