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
End Class
