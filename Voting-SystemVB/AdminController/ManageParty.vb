Public Class ManageParty

    Private Sub RefreshParty()
        PartyDataGridView.DataSource = Party.GetAll()
    End Sub

    Private Sub ManageParty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshParty()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        RefreshParty()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Me.Hide()
        Dim ap As New AddParty(Me)
        ap.Dock = DockStyle.Fill
        Parent.Controls.Add(ap)
    End Sub
End Class
