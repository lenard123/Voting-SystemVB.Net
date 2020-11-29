Imports Guna.UI2.WinForms

Public Class AddParty

    Dim AllCandidates As List(Of Candidate)
    Dim IsValid As Boolean = False
    Private Shared Instance As AddParty

    Public Shared Function GetInstance() As AddParty
        If IsNothing(Instance) Then
            Instance = New AddParty()
        End If
        Return Instance
    End Function

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
        AdminPanel.GetInstance().LoadControl(ManageParty.GetInstance())
    End Sub

    Private Sub ButtonSelectPicture_Click(sender As Object, e As EventArgs) Handles ButtonSelectPicture.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ValidateForm(sender As Object, e As EventArgs) Handles TextName.Leave
        IsValid = Validator("Party Name", TextName, ErrorName, "required", "min:3")
        If IsValid Then
            Dim temp = Party.Find(TextName.Text)
            If Not IsNothing(temp) Then
                IsValid = False
                TextName.BorderColor = Color.Red
                ErrorName.Text = "Party name already taken"
            End If
        End If
    End Sub

    Private Async Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        ValidateForm(sender, e)
        If IsValid Then
            ButtonSave.Enabled = False
            ButtonDiscard.Enabled = False
            ButtonSave.Text = "Saving"
            Dim members As New List(Of Integer)
            AddMembers(members, CBPresident)
            AddMembers(members, CBVicePresident)
            AddMembers(members, CBSecretary)
            AddMembers(members, CBAuditor)
            AddMembers(members, CBTreasurer)
            AddMembers(members, CBPRO)
            Await Save(members)
        End If
    End Sub

    Private Async Function Save(members As List(Of Integer)) As Task
        Dim nParty = New Party()
        Dim Result As Boolean
        nParty.Title = TextName.Text
        nParty.Description = TextDesccription.Text
        nParty.Image = PictureBox1.ImageLocation
        Result = Await nParty.SaveAsync(members)

        ButtonSave.Enabled = True
        ButtonDiscard.Enabled = True
        ButtonSave.Text = "Save"

        If Result Then
            Alert.setAlert("Party Added Successfully", Alert.AlertType.Success)
        Else
            Alert.setAlert("An error occured", Alert.AlertType.Error)
        End If

        AdminPanel.GetInstance().LoadControl(ManageParty.GetInstance())

    End Function

    Private Sub AddMembers(ByRef members As List(Of Integer), cb As Guna2ComboBox)
        If cb.SelectedIndex <> 0 Then
            members.Add(cb.SelectedValue)
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        PictureBox1.ImageLocation = ""
    End Sub

    Private Sub AddParty_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        AllCandidates = Candidate.GetAll()
        PopulateCombobox(CBPresident, Position.PRESIDENT_ID)
        PopulateCombobox(CBVicePresident, Position.VICE_PRESIDENT_ID)
        PopulateCombobox(CBSecretary, Position.SECRETARY_ID)
        PopulateCombobox(CBTreasurer, Position.TREASURER_ID)
        PopulateCombobox(CBAuditor, Position.AUDITOR_ID)
        PopulateCombobox(CBPRO, Position.PRO_ID)
    End Sub
End Class
