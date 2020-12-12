Public Class UpdateAdmin

    Private Shared Instance As UpdateAdmin

    Public Shared Function GetInstance() As UpdateAdmin
        If IsNothing(Instance) Then
            Instance = New UpdateAdmin()
            Instance.DoubleBuffered = True
        End If

        Return Instance

    End Function

    Private Sub TextUser_Leave(sender As Object, e As EventArgs) Handles TextUser.Leave
        Util.Validator("Username", TextUser, ErrorUser, "required", "min:6")
    End Sub

    Private Sub TextName_Leave(sender As Object, e As EventArgs) Handles TextName.Leave
        Util.Validator("Fullname", TextName, ErrorName, "required", "min:5")
    End Sub

    Private Sub TextPassword_Leave(sender As Object, e As EventArgs) Handles TextPassword.Leave
        Util.Validator("Confirm Password", TextPassword, ErrorPass, "required")
    End Sub

    Private Sub ButtonAddAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAddAdmin.Click
        AdminPanel.GetInstance().LoadControl(AddAdmin.GetInstance())
    End Sub

    Private Sub ButtonChangePass_Click(sender As Object, e As EventArgs) Handles ButtonChangePass.Click
        AdminPanel.GetInstance().LoadControl(New UpdatePassword)
    End Sub

    Private Sub UpdateAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextUser.Text = Admin.GetCurrentUser().Username
        TextName.Text = Admin.GetCurrentUser().Fullname

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If Admin.GetCurrentUser().ComparePassword(TextPassword.Text) Then

            Admin.GetCurrentUser().Username = TextUser.Text
            Admin.GetCurrentUser().Password = TextPassword.Text

            Try
                Admin.GetCurrentUser().Update()
                Alert.ShowAlert("Update Successfully", Alert.AlertType.Success)
            Catch ex As Exception
            End Try

        Else : Alert.ShowAlert("Wrong Password", Alert.AlertType.Error)

        End If

    End Sub
End Class
