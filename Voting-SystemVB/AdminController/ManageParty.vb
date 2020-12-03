Public Class ManageParty

    Implements MainControl

    Private Shared Instance As ManageParty

    Public Shared Function GetInstance() As ManageParty
        If IsNothing(Instance) Then
            Instance = New ManageParty()
        End If
        Return Instance
    End Function

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        BackgroundWorkerRefresh.RunWorkerAsync()
    End Sub
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        AddParty.ShowPopup()
    End Sub
    Private Sub PartyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PartyDataGridView.CellDoubleClick
        If Election.HasNotStarted Then
            Dim sParty = DirectCast(PartyDataGridView.DataSource, List(Of Party))(e.RowIndex)
            UpdateParty.ShowPopup(sParty)
        End If
    End Sub
    Private Sub ManageParty_Refresh() Implements MainControl.RefreshControl
        If Election.HasNotStarted Then
            ButtonAdd.Enabled = True
        End If
        ButtonRefresh.PerformClick()
    End Sub


    Private Sub BackgroundWorkerRefresh_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerRefresh.DoWork
        e.Result = Party.GetAll()
    End Sub

    Private Sub BackgroundWorkerRefresh_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerRefresh.RunWorkerCompleted
        PartyDataGridView.DataSource = e.Result
    End Sub
End Class
