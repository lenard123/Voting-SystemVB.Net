Public Class CandidatesList

    Dim Candidates As List(Of Candidate)
    Dim LabelCandidates() As Control

    Enum CandidateType
        Text
        Radio
    End Enum

    Public Sub New(Candidates As List(Of Candidate), Position As String, type As CandidateType)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Candidates = Candidates
        Me.LabelPosition.Text = Position
        ReDim LabelCandidates(Candidates.Count)
        Select Case type
            Case CandidateType.Text
                Dim i = 1
                For Each mCandidate In Candidates
                    Dim LabelTmp As New Guna.UI2.WinForms.Guna2HtmlLabel
                    LabelTmp.Text = i & ". " & GetParty(mCandidate.Party) & mCandidate.Fullname
                    FlowLayoutPanel1.Controls.Add(LabelTmp)
                    i = i + 1
                Next
        End Select


    End Sub

    Shared Function GetParty(Party As String) As String
        If IsNothing(Party) OrElse Party.Equals("") Then Party = "Independent"
        Return "(<b>" & Party & "</b>) "
    End Function

End Class
