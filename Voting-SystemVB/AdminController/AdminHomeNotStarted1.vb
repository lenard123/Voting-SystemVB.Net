Public Class AdminHomeNotStarted1

    Private Shared Instance As AdminHomeNotStarted1

    Public Shared Function GetInstance() As AdminHomeNotStarted1
        If IsNothing(Instance) Then
            Instance = New AdminHomeNotStarted1
        End If
        Return Instance
    End Function

End Class
