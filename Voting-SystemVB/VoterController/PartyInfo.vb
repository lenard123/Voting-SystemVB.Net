Imports Guna.UI2.WinForms

Public Class PartyInfo

    Implements MainControl

    Private Shared Instance As PartyInfo
    Private Shared Parties As New Dictionary(Of Party, List(Of Candidate))

    Public Shared Function GetInstance() As PartyInfo
        If IsNothing(Instance) Then
            Instance = New PartyInfo
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    Sub RefreshControl() Implements MainControl.RefreshControl
        If Parties.Count < 1 Then
            StartLoading()
            BackgroundWorkerFetch.RunWorkerAsync()
        End If
    End Sub

    Sub StartLoading()
        PanelMain.Controls.Remove(FlowLayoutPanel1)
        PanelLoading.BringToFront()
        Guna2WinProgressIndicator1.Start()
    End Sub

    Sub StopLoading()
        PanelLoading.SendToBack()
        Guna2WinProgressIndicator1.Stop()
    End Sub

    Private Sub BackgroundWorkerFetch_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerFetch.DoWork
        Dim lParties = Party.GetAll()
        For Each item In lParties
            Parties.Add(item, Candidate.GetAllByPartyID(item.ID))
        Next
    End Sub

    Private Sub BackgroundWorkerFetch_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerFetch.RunWorkerCompleted
        StopLoading()
        If Parties.Count < 1 Then
            PanelNoParty.BringToFront()
        Else
            PanelMain.Controls.Add(FlowLayoutPanel1)
            Panel1.BringToFront()
            For Each iParty In Parties
                FlowLayoutPanel1.Controls.Add(GetButton(iParty.Key))
            Next

            DirectCast(FlowLayoutPanel1.Controls(0), Guna2Button).PerformClick()

        End If
    End Sub

    Private Function GetButton(item As Party) As Guna2Button
        Dim btn As New Guna2Button
        btn.Animated = True
        btn.FillColor = Color.Transparent
        btn.ForeColor = Color.LightGray
        btn.Text = item.Title
        btn.Tag = item
        btn.Margin = New Padding(0)
        btn.Size = New Size(FlowLayoutPanel1.Width - 10, btn.Height)
        AddHandler btn.Click, AddressOf PartyBtn_Click
        Return btn
    End Function

    Dim PreviousButton As Guna2Button

    Private Sub PartyBtn_Click(sender As Guna2Button, e As EventArgs)
        If Not IsNothing(PreviousButton) Then
            PreviousButton.FillColor = Color.Transparent
            PreviousButton.ForeColor = Color.Gray
        End If

        sender.ForeColor = Color.White
        sender.FillColor = Color.FromArgb(46, 43, 63)

        PreviousButton = sender

        Dim sParty = DirectCast(sender.Tag, Party)

        PictureBox1.ImageLocation = "images\default\error.jpg"

        If Not sParty.Image.Equals("") Then PictureBox1.ImageLocation = sParty.Image

        LabelParty.Text = sParty.Title
        LabelDesc.Text = sParty.Description

        For i = 1 To 6
            GetLabel(i).Text = GetName(i, Parties(sParty))
        Next

    End Sub

    Function GetName(PositionId As Integer, candidates As List(Of Candidate))
        Dim Result = "(No Representative)"
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

End Class
