Imports Guna.UI2.WinForms

Public Class CandidateList1

    Dim PositionID As Integer
    Dim Candidates As List(Of Candidate)
    Dim LabelResult As Label
    Dim Active As Guna2RadioButton

    Public Sub New(PositionID As Integer, Candidates As List(Of Candidate), ByRef Result As Label)
        ' This call is required by the designer.
        DoubleBuffered = True
        InitializeComponent()
        Me.PositionID = PositionID
        Me.Candidates = Candidates
        Me.LabelResult = Result

        LabelPositionName.Text = Position.GetName(PositionID)

        For Each item In Candidates
            Dim rbn = New Guna2RadioButton
            rbn.ForeColor = Color.LightGray
            rbn.Text = item.Fullname & GetParty(item.Party)
            rbn.AutoSize = True
            'rbn.Size = New Size(397, rbn.Height)
            rbn.AutoEllipsis = True
            rbn.Tag = item
            AddHandler rbn.CheckedChanged, AddressOf Me.RadioBtn_Click
            FlowLayoutPanel1.Controls.Add(rbn)
        Next


    End Sub

    Shared Function GetParty(Party As String) As String
        If IsNothing(Party) OrElse Party.Equals("") Then Party = "Independent"
        Return " (" & Party & ")"
    End Function

    Private Sub RadioBtn_Click(sender As Guna2RadioButton, e As EventArgs)
        If sender.Checked Then
            Active = sender
            LabelResult.Tag = sender.Tag
            LabelResult.Text = DirectCast(sender.Tag, Candidate).Fullname
        End If
    End Sub

    Public Sub ClearSelected()
        If Not IsNothing(Active) Then
            LabelResult.Text = "(None Selected)"
            LabelResult.Tag = Nothing
            Active.Checked = False
            Active = Nothing
        End If
    End Sub

End Class
