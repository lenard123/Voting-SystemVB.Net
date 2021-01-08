Public Class ManageAdmin

    Private Shared Instance As ManageAdmin

    Public Shared Function GetInstance() As ManageAdmin
        If IsNothing(Instance) Then
            Instance = New ManageAdmin
        End If
        Return Instance
    End Function

    Private Sub BtnUpdateAccount_Click(sender As Object, e As EventArgs) Handles BtnUpdateAccount.Click
        UpdateAccount.ShowPopup()
    End Sub

    Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles BtnChangePassword.Click
        ChangePassword.ShowPopup()
    End Sub

    Private Sub ButtonAddAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAddAdmin.Click
        If Admin.GetCurrentUser().CanAddAdmin() Then
            AddAdmin.ShowPopup()
        Else
            Alert.ShowAlert("You do not have the privilege to perform this action", Alert.AlertType.Error)
        End If
    End Sub

    Private Sub BtnRecover_Click(sender As Object, e As EventArgs) Handles BtnRecover.Click
        If Admin.GetCurrentUser().CanDoAll() Then
            RecoverAccount.ShowPopup()
        Else
            Alert.ShowAlert("You do not have the privilege to perform this action", Alert.AlertType.Error)
        End If
    End Sub

    Private Sub BtnUpdatePrivileges_Click(sender As Object, e As EventArgs) Handles BtnUpdatePrivileges.Click
        If Admin.GetCurrentUser().CanDoAll() Then
            UpdatePrivileges.ShowPopup()
        Else
            Alert.ShowAlert("You do not have the privilege to perform this action", Alert.AlertType.Error)
        End If
    End Sub

    Private Sub BtnViewPrivileges_Click(sender As Object, e As EventArgs) Handles BtnViewPrivileges.Click
        AdminPrivileges.ShowPopup()
    End Sub
End Class
