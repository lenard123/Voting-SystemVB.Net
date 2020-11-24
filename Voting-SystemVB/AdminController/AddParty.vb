Imports Guna.UI2.WinForms

Public Class AddParty

    Dim AllCandidates As List(Of Candidate)
    Dim mp As ManageParty
    Dim IsValid As Boolean = False


    Public Sub New(mp As ManageParty)
        ' This call is required by the designer.
        InitializeComponent()

        Me.mp = mp

        ' Add any initialization after the InitializeComponent() call.
        AllCandidates = Candidate.GetAll()

        PopulateCombobox(CBPresident, Position.PRESIDENT_ID)
        PopulateCombobox(CBVicePresident, Position.VICE_PRESIDENT_ID)
        PopulateCombobox(CBSecretary, Position.SECRETARY_ID)
        PopulateCombobox(CBTreasurer, Position.TREASURER_ID)
        PopulateCombobox(CBAuditor, Position.AUDITOR_ID)
        PopulateCombobox(CBPRO, Position.PRO_ID)
    End Sub

    Private Sub PopulateCombobox(cb As Guna2ComboBox, PositionID As Integer)
        cb.DataSource = Filter(PositionID)
        cb.DisplayMember = "Fullname"
        cb.ValueMember = "ID"
        cb.SelectedItem = 0
    End Sub

    Private Function Filter(PositionID As Integer) As DataTable
        Dim Result As New DataTable()
        Result.Columns.Add("ID")
        Result.Columns.Add("Fullname")
        Result.Rows.Add(0, "Vacant")
        For Each item In AllCandidates
            If (IsNothing(item.PartyID) Or item.PartyID < 1) And item.PositionID = PositionID Then
                Result.Rows.Add(item.ID, item.Fullname)
            End If
        Next
        Return Result
    End Function

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Dispose()
        mp.Show()
    End Sub

    Private Sub ButtonSelectPicture_Click(sender As Object, e As EventArgs) Handles ButtonSelectPicture.Click
        OpenFileDialog1.Filter = "JPG(*.JPG)|*.jpg"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ValidateForm(sender As Object, e As EventArgs) Handles TextName.Leave
        IsValid = Validator("Party Name", TextName, ErrorName, "required", "min:3")
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        ValidateForm(sender, e)
        If IsValid Then

        End If
    End Sub
End Class
