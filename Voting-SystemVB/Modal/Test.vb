Public Class Test


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UploadDatabase.ShowPopup()
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Election.GetCurrentElectionRefresh()
        Dim x = GetDBSchema(DatabaseType.ACCDB, GetConnection())
        Debug.WriteLine(x)
    End Sub
End Class
