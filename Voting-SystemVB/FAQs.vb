Public Class FAQs

    Private Shared Instance As FAQs

    Public Shared Sub ShowFAQ()

        If IsNothing(Instance) OrElse Instance.IsDisposed() Then
            Instance = New FAQs
        End If

        Instance.Show()
        Instance.Focus()

    End Sub

End Class