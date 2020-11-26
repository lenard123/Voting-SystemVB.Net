Public Class ManageParty

    Public Async Function RefreshParty() As Task
        PartyDataGridView.DataSource = Await Task.Run(Function()
                                                          Return Party.GetAll()
                                                      End Function)
    End Function

    Private Sub ManageParty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshParty()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        RefreshParty()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Me.Hide()
        Dim aParty As New AddParty(Me)
        aParty.Dock = DockStyle.Fill
        Parent.Controls.Add(aParty)
    End Sub

    Private Sub PartyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PartyDataGridView.CellDoubleClick
        Me.Hide()
        Dim SelectedParty = DirectCast(PartyDataGridView.DataSource, List(Of Party))(e.RowIndex)
        Dim sParty As New UpdateParty(SelectedParty, Me)
        sParty.Dock = DockStyle.Fill
        Parent.Controls.Add(sParty)
    End Sub
End Class
