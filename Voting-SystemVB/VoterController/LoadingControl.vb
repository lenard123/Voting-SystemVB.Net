Public Class LoadingControl

    Private Shared Instance As LoadingControl

    Public Shared Function GetInstance() As LoadingControl
        If IsNothing(Instance) Then
            Instance = New LoadingControl
        End If
        Return Instance
    End Function

End Class
