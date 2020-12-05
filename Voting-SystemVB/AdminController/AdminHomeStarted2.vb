Public Class AdminHomeStarted2

    Private Shared Instance As AdminHomeStarted2

    Public Shared Function GetInstance()
        If IsNothing(Instance) Then
            Instance = New AdminHomeStarted2()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

End Class
