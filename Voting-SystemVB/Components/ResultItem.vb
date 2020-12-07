Public Class ResultItem

    Public Sub New(PositionId As Integer, VoteCount As Integer, Winners As List(Of Candidate))
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelPosition.Text = Position.GetName(PositionId)
        LabelVotes.Text = VoteCount & " Votes"
        LabelWinners.Text = ""
        For Each winner In Winners
            LabelWinners.Text &= winner.Fullname
            If IsNothing(winner.Party) Then
                LabelWinners.Text &= " (Independent)" & Environment.NewLine
            Else
                LabelWinners.Text &= " (" & winner.Party & ")" & Environment.NewLine
            End If
        Next
        LabelWinners.Text &= "." 'For some padding
    End Sub

End Class
