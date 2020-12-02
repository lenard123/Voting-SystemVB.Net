Public Class PartyInfo

    Private Shared Instance As PartyInfo

    Public Shared Function GetInstance() As PartyInfo
        If IsNothing(Instance) Then
            Instance = New PartyInfo
        End If
        Return Instance
    End Function

End Class
