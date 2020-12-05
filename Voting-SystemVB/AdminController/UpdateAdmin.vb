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
End Class
