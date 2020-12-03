
Imports Guna.UI2.WinForms

Public Class AddParty

    Public Shared Popup As ModalPopup
    Dim Candidates As Dictionary(Of Integer, List(Of Candidate))
    Dim IsValidName As Boolean = False
    Dim nParty As New Party()

    Private Sub AddParty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchCandidate()
    End Sub

    Sub StartLoading()
        Guna2WinProgressIndicator1.Visible = True
        LabelLoading.Visible = True
        Guna2WinProgressIndicator1.Start()
        ButtonDiscard.Enabled = False
        ButtonSave.Enabled = False
    End Sub

    Sub StopLoading()
        Guna2WinProgressIndicator1.Stop()
        Guna2WinProgressIndicator1.Visible = False
        LabelLoading.Visible = False
        ButtonSave.Enabled = True
        ButtonDiscard.Enabled = True
    End Sub

    Sub FetchCandidate()
        StartLoading()
        BackgroundWorkerFetchCandidate.RunWorkerAsync()
    End Sub

    Sub PopulateCombobox(cb As Guna2ComboBox)
        Dim PositionId As Integer = Integer.Parse(cb.Tag)
        Dim dt As New DataTable()
        dt.Columns.Add("ID")
        dt.Columns.Add("Fullname")
        dt.Rows.Add(0, "Vacant")
        For Each item In Candidates(PositionId)
            If item.PartyID > 0 Then Continue For
            dt.Rows.Add(item.ID, item.Fullname)
        Next
        cb.DataSource = dt
        cb.DisplayMember = "Fullname"
        cb.ValueMember = "ID"
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Guna2PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BackgroundWorkerFetchCandidate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerFetchCandidate.DoWork
        Candidates = Candidate.GetAll2()
    End Sub

    Private Sub BackgroundWorkerFetchCandidate_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerFetchCandidate.RunWorkerCompleted
        StopLoading()
        PopulateCombobox(CBPresident)
        PopulateCombobox(CBVicePresident)
        PopulateCombobox(CBSecretary)
        PopulateCombobox(CBTreasurer)
        PopulateCombobox(CBAuditor)
        PopulateCombobox(CBPRO)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Guna2PictureBox1.ImageLocation = ""
    End Sub

    Private Sub TextName_Leave(sender As Object, e As EventArgs) Handles TextName.Leave
        IsValidName = Util.Validator("Name", TextName, ErrorName, "required", "min:3")
        If IsValidName Then
            Dim temp = Party.Find(TextName.Text)
            If Not IsNothing(temp) Then
                IsValidName = False
                TextName.BorderColor = Color.Red
                ErrorName.Text = "Party name already taken"
            End If
        End If
    End Sub

    Private Sub AddMember(ByRef members As List(Of Integer), cb As Guna2ComboBox)
        If cb.SelectedIndex <> 0 Then
            members.Add(cb.SelectedValue)
        End If
    End Sub

    Private Function GetMembers() As List(Of Integer)
        Dim members As New List(Of Integer)
        AddMember(members, CBPresident)
        AddMember(members, CBVicePresident)
        AddMember(members, CBSecretary)
        AddMember(members, CBTreasurer)
        AddMember(members, CBAuditor)
        AddMember(members, CBPRO)
        Return members
    End Function

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        TextName_Leave(sender, e)
        If IsValidName Then
            StartLoading()
            nParty.Title = TextName.Text
            nParty.Image = Guna2PictureBox1.ImageLocation
            BackgroundWorkerSave.RunWorkerAsync(GetMembers())
        End If
    End Sub

    Private Sub BackgroundWorkerSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSave.DoWork
        e.Result = nParty.Save(e.Argument)
    End Sub

    Private Sub BackgroundWorkerSave_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerSave.RunWorkerCompleted
        StopLoading()
        If e.Result Then
            Alert.ShowAlert("Party Added Successfully", Alert.AlertType.Success)
            ManageParty.GetInstance().ButtonRefresh.PerformClick()
            Popup.ClosePopup()
        Else
            Alert.ShowAlert("An error occured", Alert.AlertType.Error)
        End If
    End Sub

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup
        Popup.Init(New AddParty)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Popup.ClosePopup()
    End Sub
End Class
