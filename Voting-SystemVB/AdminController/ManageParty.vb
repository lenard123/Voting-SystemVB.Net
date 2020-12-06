Imports Guna.UI2.WinForms

Public Class ManageParty

    Implements MainControl

    Private Shared Instance As ManageParty

    Public Shared Function GetInstance() As ManageParty
        If IsNothing(Instance) Then
            Instance = New ManageParty()
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click, Guna2Button2.Click
        BackgroundWorkerRefresh.RunWorkerAsync()
    End Sub
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click, Guna2Button1.Click
        AddParty.ShowPopup()
    End Sub
    'Private Sub PartyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
    '    If Election.HasNotStarted Then
    '        Dim sParty = DirectCast(PartyDataGridView.DataSource, List(Of Party))(e.RowIndex)
    '        UpdateParty.ShowPopup(sParty)
    '    End If
    'End Sub
    Private Sub ManageParty_Refresh() Implements MainControl.RefreshControl
        If Election.HasNotStarted Then
            ButtonAdd.Visible = True
        Else
            ButtonAdd.Visible = False
        End If
        ButtonRefresh.PerformClick()
    End Sub


    Private Sub BackgroundWorkerRefresh_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerRefresh.DoWork
        e.Result = Party.GetAll()
    End Sub

    Dim PreviousButton As Guna2Button

    Private Sub BackgroundWorkerRefresh_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerRefresh.RunWorkerCompleted
        'Get Selected Party
        Dim SelectedParty As Party = Nothing
        If Not IsNothing(PreviousButton) Then
            SelectedParty = PreviousButton.Tag
        End If
        DisposeButtons()

        For Each item As Party In e.Result
            Dim btn = GetButton(item)
            FlowLayoutPanel1.Controls.Add(btn)
            If Not IsNothing(SelectedParty) AndAlso item.ID = SelectedParty.ID Then PreviousButton = btn
        Next

        If FlowLayoutPanel1.Controls.Count = 1 Then
            PanelMain.Controls.Remove(FlowLayoutPanel1)
            PanelNoParty.BringToFront()

        Else
            PanelMain.Controls.Add(FlowLayoutPanel1)
            PanelNoParty.SendToBack()
            If Not IsNothing(PreviousButton) Then
                PreviousButton.PerformClick()
            Else
                DirectCast(FlowLayoutPanel1.Controls(1), Guna2Button).PerformClick()
            End If
            FlowLayoutPanel1.Controls.Add(ButtonAdd)
        End If
    End Sub

    Private Sub DisposeButtons()
        FlowLayoutPanel1.Controls.Remove(ButtonAdd)
        FlowLayoutPanel1.Controls.Remove(PictureBox1)
        While FlowLayoutPanel1.Controls.Count > 0
            FlowLayoutPanel1.Controls(0).Dispose()
        End While
        FlowLayoutPanel1.Controls.Add(PictureBox1)
    End Sub

    Private Function GetButton(item As Party) As Guna2Button
        Dim btn As New Guna2Button
        btn.Animated = True
        btn.FillColor = Color.White
        btn.ForeColor = Color.Black
        btn.Text = item.Title
        btn.Tag = item
        btn.ButtonMode = Enums.ButtonMode.RadioButton
        btn.CheckedState.FillColor = Color.FromArgb(255, 164, 91)
        btn.CheckedState.ForeColor = Color.White
        btn.Margin = New Padding(0)
        btn.Size = New Size(FlowLayoutPanel1.Width - 10, btn.Height)
        AddHandler btn.Click, AddressOf PartyBtnClick
        Return btn
    End Function


    Private Sub PartyBtnClick(sender As Guna2Button, e As EventArgs)
        'If Not IsNothing(PreviousButton) Then
        '    PreviousButton.FillColor = Color.White
        '    PreviousButton.ForeColor = Color.Black
        'End If

        'sender.FillColor = Color.FromArgb(94, 148, 255)
        'sender.ForeColor = Color.White

        PreviousButton = sender

        Dim Tag = DirectCast(sender.Tag, Party)

        LabelParty.Text = Tag.Title
        LabelDesc.Text = Tag.Description
        If Tag.Image.Equals("") Then
            PictureBox1.ImageLocation = "images\default\error.jpg"
        Else
            PictureBox1.ImageLocation = Tag.Image
        End If
        BackgroundWorkerFetchMember.RunWorkerAsync(Tag.ID)

    End Sub

    Private Sub BackgroundWorkerFetchMember_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerFetchMember.DoWork
        e.Result = Candidate.GetAllByPartyID(e.Argument)
    End Sub

    Private Sub BackgroundWorkerFetchMember_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerFetchMember.RunWorkerCompleted
        For i = 1 To 6
            GetLabel(i).Text = GetName(i, e.Result)
        Next
    End Sub

    Function GetName(PositionId As Integer, candidates As List(Of Candidate))
        Dim Result = "(Vacant)"
        For Each iCandidate In candidates
            If PositionId = iCandidate.PositionID Then Return iCandidate.Fullname
        Next
        Return Result
    End Function

    Function GetLabel(PositionID As Integer) As Label
        Dim sLabel As Label = Nothing
        Select Case PositionID
            Case Position.PRESIDENT_ID
                sLabel = Label1President
            Case Position.VICE_PRESIDENT_ID
                sLabel = LabelVicePresident
            Case Position.SECRETARY_ID
                sLabel = LabelSecretary
            Case Position.TREASURER_ID
                sLabel = LabelTreasurer
            Case Position.AUDITOR_ID
                sLabel = LabelAuditor
            Case Position.PRO_ID
                sLabel = LabelPRO
        End Select
        Return sLabel
    End Function

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click, Guna2Button3.Click
        If Not IsNothing(PreviousButton) Then
            UpdateParty.ShowPopup(PreviousButton.Tag)
        End If
    End Sub
End Class
