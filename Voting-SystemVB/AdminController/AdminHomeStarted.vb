Public Class AdminHomeStarted

    Private Shared Instance As AdminHomeStarted

    Public Shared Function GetInstance() As AdminHomeStarted
        If IsNothing(Instance) Then
            Instance = New AdminHomeStarted
        End If
        Return Instance
    End Function

End Class
