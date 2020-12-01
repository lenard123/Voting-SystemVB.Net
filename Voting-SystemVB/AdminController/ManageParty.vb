Public Class ManageParty

    Implements MainControl

    Private Shared Instance As ManageParty
    Private Shared UpdatePartyInstance As UpdateParty

    Public Shared Function GetInstance() As ManageParty
        If IsNothing(Instance) Then
            Instance = New ManageParty()
        End If
        Return Instance
    End Function

    Public Async Function RefreshParty() As Task
        PartyDataGridView.DataSource = Await Party.GetAllAsync()
    End Function

    Private Async Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Await RefreshParty()
    End Sub
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        AdminPanel.GetInstance().LoadControl(AddParty.GetInstance())
    End Sub
    Private Sub PartyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PartyDataGridView.CellDoubleClick
        If Not Election.HasNotStarted Then
            Dim SelectedParty = DirectCast(PartyDataGridView.DataSource, List(Of Party))(e.RowIndex)
            If (Not IsNothing(UpdatePartyInstance)) Then UpdatePartyInstance.Dispose()
            UpdatePartyInstance = New UpdateParty(SelectedParty)
            AdminPanel.GetInstance().LoadControl(UpdatePartyInstance)
        End If
    End Sub
    Private Async Sub ManageParty_Refresh() Implements MainControl.RefreshControl
        If Election.HasNotStarted Then
            ButtonAdd.Enabled = True
        End If
        Await RefreshParty()
    End Sub
End Class
