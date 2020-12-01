Public Class VotersPanel

    Private Shared Instance As VotersPanel

    Public Shared Function GetInstance() As VotersPanel
        If IsNothing(Instance) Then
            Instance = New VotersPanel
        End If
        Return Instance
    End Function

    Private Sub VotersPanel_ParentChanged(sender As Object, e As EventArgs) Handles MyBase.ParentChanged

    End Sub
End Class
