Public Class AddAdmin

    Private Shared Instance As AddAdmin

    Public Shared Function GetInstance() As AddAdmin
        If IsNothing(Instance) Then
            Instance = New AddAdmin
        End If
        Return Instance
    End Function

End Class
