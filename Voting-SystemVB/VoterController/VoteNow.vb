Public Class VoteNow

    Private Shared Instance As VoteNow

    Public Shared Function GetInstance() As VoteNow
        If IsNothing(Instance) Then
            Instance = New VoteNow
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

End Class
