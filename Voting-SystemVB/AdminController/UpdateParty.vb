Imports Guna.UI2.WinForms

Public Class UpdateParty

    Dim sParty As Party
    Dim IsValid = False
    Dim mp As ManageParty
    Dim alertLoading As Alert

    Public Sub New(sParty As Party, mp As ManageParty)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        alertLoading = Alert.ShowAlert("Loading Party informations, please wait", Alert.AlertType.Info)
        Me.sParty = sParty
        Me.mp = mp
        Me.Enabled = False
        LoadInformation()
    End Sub

    Private Async Function LoadInformation() As Task
        TextName.Text = sParty.Title
        TextDesccription.Text = sParty.Description
        PictureBox1.ImageLocation = sParty.Image
        Dim Candidates = Await Candidate.GetAllAsync()
        PopulateCombobox(CBPresident, Position.PRESIDENT_ID, Candidates)
        PopulateCombobox(CBVicePresident, Position.VICE_PRESIDENT_ID, Candidates)
        PopulateCombobox(CBSecretary, Position.SECRETARY_ID, Candidates)
        PopulateCombobox(CBTreasurer, Position.TREASURER_ID, Candidates)
        PopulateCombobox(CBAuditor, Position.AUDITOR_ID, Candidates)
        PopulateCombobox(CBPRO, Position.PRO_ID, Candidates)
        Me.Enabled = True
        alertLoading.CloseAlert()
    End Function

    Private Sub PopulateCombobox(cb As Guna2ComboBox, PositionID As Integer, Candidates As List(Of Candidate))
        Dim dt As New DataTable()
        Dim Selected = 0
        dt.Columns.Add("ID")
        dt.Columns.Add("Fullname")
        dt.Rows.Add(0, "Vacant")

        For Each item In Candidates
            If (item.PartyID = sParty.ID Or IsNothing(item.PartyID) Or item.PartyID < 1) And item.PositionID = PositionID Then
                dt.Rows.Add(item.ID, item.Fullname)
                If item.PartyID = sParty.ID Then Selected = item.ID
            End If
        Next

        cb.DataSource = dt
        cb.DisplayMember = "Fullname"
        cb.ValueMember = "ID"
        cb.SelectedValue = Selected
    End Sub

    Private Sub ButtonSelectPicture_Click(sender As Object, e As EventArgs) Handles ButtonSelectPicture.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        PictureBox1.ImageLocation = ""
    End Sub

    Private Sub ValidateForm(sender As Object, e As EventArgs) Handles TextName.Leave
        IsValid = Validator("Party Name", TextName, ErrorName, "required", "min:3")
        If IsValid Then
            Dim temp = Party.Find(TextName.Text)
            If Not IsNothing(temp) Then
                If temp.ID <> sParty.ID Then
                    IsValid = False
                    TextName.BorderColor = Color.Red
                    ErrorName.Text = "Party name already taken"
                End If
            End If
        End If
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Dispose()
        mp.Show()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        ValidateForm(sender, e)
        If IsValid Then
            Me.Enabled = False
            Alert.setAlert("Updating Party information please wait", Alert.AlertType.Info)
            Save()
        End If
    End Sub

    Private Async Function Save() As Task
        Dim members As New List(Of Integer)
        AddMembers(members, CBPresident)
        AddMembers(members, CBVicePresident)
        AddMembers(members, CBSecretary)
        AddMembers(members, CBAuditor)
        AddMembers(members, CBTreasurer)
        AddMembers(members, CBPRO)

        sParty.Title = TextName.Text
        sParty.Description = TextDesccription.Text
        sParty.Image = PictureBox1.ImageLocation

        Dim Result = Await sParty.UpdateAsync(members)
        If Result Then
            Alert.setAlert("Party updated successfully", Alert.AlertType.Success)
        Else
            Alert.setAlert("An error occured", Alert.AlertType.Error)
        End If
        Me.Dispose()
        mp.RefreshParty()
        mp.Show()
    End Function

    Private Sub AddMembers(ByRef members As List(Of Integer), cb As Guna2ComboBox)
        If cb.SelectedIndex <> 0 Then
            members.Add(cb.SelectedValue)
        End If
    End Sub
End Class
