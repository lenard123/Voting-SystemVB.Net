Public Class UpdateAdmin

    Private Shared Instance As UpdateAdmin

    Public Shared Function GetInstance() As UpdateAdmin
        If IsNothing(Instance) Then
            Instance = New UpdateAdmin()
        End If

        Return Instance



    End Function

End Class
