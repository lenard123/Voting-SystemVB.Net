Imports Guna.UI2.WinForms

Public Class PreviousElections

    Implements MainControl

    Private Shared Instance As PreviousElections
    Private Shared Elections As List(Of Election)

    Public Shared Function GetInstance() As PreviousElections
        If IsNothing(Instance) Then
            Instance = New PreviousElections
        End If
        Return Instance
    End Function

    Public Sub ReloadForm() Implements MainControl.RefreshControl
        DisposedButtons()
        Elections = Election.GetAll()

        For i = 0 To Elections.Count - 1
            If Elections(i).Id = Election.GetCurrentId() Then Continue For
            FlowLayoutPanel1.Controls.Add(GetButton(i))
        Next

    End Sub

    Sub DisposedButtons()
        While FlowLayoutPanel1.Controls.Count > 0
            FlowLayoutPanel1.Controls(0).Dispose()
        End While
    End Sub

    Function GetButton(Index As Integer) As Guna2Button
        Dim btn As New Guna2Button
        btn.Size = New Size(819, 68)
        btn.Text = Elections(Index).Title
        btn.Margin = New Padding(0)
        btn.ForeColor = Color.Black
        btn.FillColor = Color.White
        btn.Animated = True
        btn.Font = New Font("Segoe UI", 14)
        btn.Tag = Elections(Index).Id
        AddHandler btn.Click, AddressOf ViewResult_Click
        Return btn
    End Function

    Private Sub ViewResult_Click(sender As Guna2Button, e As EventArgs)
        AdminPanel.GetInstance().LoadControl(New AdminHomeEnded(sender.Tag))
    End Sub

End Class
