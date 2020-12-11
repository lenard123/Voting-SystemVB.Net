Imports Guna.UI2.WinForms

Public Class UpdateParty

    Public Shared Popup As ModalPopup

    Private sParty As Party
    Dim IsValidName As Boolean = False
    Dim Candidates As Dictionary(Of Integer, List(Of Candidate))

    Public Sub New(sParty As Party)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.sParty = sParty
        Me.TextName.Text = sParty.Title
        Me.TextDescription.Text = sParty.Description
        Me.Guna2PictureBox1.ImageLocation = sParty.Image

        FetchMembers()

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

    Sub FetchMembers()
        StartLoading()
        BackgroundWorkerFetchMembers.RunWorkerAsync()
    End Sub

    Sub PopulateCombobox(cb As Guna2ComboBox)
        Dim PositionId As Integer = Integer.Parse(cb.Tag)
        Dim Selected As Integer = 0
        Dim dt As New DataTable()
        dt.Columns.Add("ID")
        dt.Columns.Add("Fullname")
        dt.Rows.Add(0, "Vacant")
        For Each item In Candidates(PositionId)
            If item.PartyID > 0 And item.PartyID <> sParty.ID Then Continue For
            If item.PartyID = sParty.ID Then Selected = item.ID
            dt.Rows.Add(item.ID, item.Fullname)
        Next
        cb.DataSource = dt
        cb.DisplayMember = "Fullname"
        cb.ValueMember = "ID"
        cb.SelectedValue = Selected
    End Sub

    Private Sub BackgroundWorkerFetchMembers_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerFetchMembers.DoWork
        Candidates = Candidate.GetAll()
    End Sub

    Private Sub BackgroundWorkerFetchMembers_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerFetchMembers.RunWorkerCompleted
        StopLoading()
        PopulateCombobox(CBPresident)
        PopulateCombobox(CBVicePresident)
        PopulateCombobox(CBSecretary)
        PopulateCombobox(CBTreasurer)
        PopulateCombobox(CBAuditor)
        PopulateCombobox(CBPRO)
    End Sub

    Public Shared Sub ShowPopup(sParty As Party)
        Popup = New ModalPopup
        Popup.Init(New UpdateParty(sParty))
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Popup.ClosePopup()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Guna2PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Guna2PictureBox1.ImageLocation = ""
    End Sub

    Private Sub TextName_Leave(sender As Object, e As EventArgs) Handles TextName.Leave
        IsValidName = Util.Validator("Name", TextName, ErrorName, "required", "min:3")
        If IsValidName Then
            Dim temp = Party.Find(TextName.Text)
            If Not IsNothing(temp) AndAlso temp.ID <> sParty.ID Then
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
            sParty.Title = TextName.Text
            sParty.Description = TextDescription.Text
            sParty.Image = Guna2PictureBox1.ImageLocation
            BackgroundWorkerUpdate.RunWorkerAsync(GetMembers())
        End If
    End Sub

    Private Sub BackgroundWorkerUpdate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerUpdate.DoWork
        Try
            sParty.Update(e.Argument)
        Catch ex As Exception
            e.Result = ex
        End Try
    End Sub

    Private Sub BackgroundWorkerUpdate_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerUpdate.RunWorkerCompleted
        StopLoading()

        If TypeOf e.Result Is Exception Then
            Alert.ShowAlert(DirectCast(e.Result, Exception).Message, Alert.AlertType.Error)
        Else
            Alert.ShowAlert("Party Update Successfully", Alert.AlertType.Success)
            ManageParty.GetInstance().ButtonRefresh.PerformClick()
            Popup.ClosePopup()
        End If
    End Sub
End Class
