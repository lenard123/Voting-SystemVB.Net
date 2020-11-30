Public Class UpdateAdmin

    Private Shared Instance As UpdateAdmin

    Public Shared Function GetInstance() As UpdateAdmin
        If IsNothing(Instance) Then
            Instance = New UpdateAdmin()
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

End Class
