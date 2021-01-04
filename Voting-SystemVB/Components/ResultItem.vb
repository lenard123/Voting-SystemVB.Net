Public Class ResultItem

    Public Sub New(PositionId As Integer, VoteCount As Integer, Winner As Candidate)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelPosition.Text = Position.GetName(PositionId)
        LabelVotes.Text = VoteCount & " Votes"
        LabelWinners.Text = Winner.Fullname
        If IsNothing(Winner.Party) Then
            LabelWinners.Text &= " (Independent)" & Environment.NewLine
        Else
            LabelWinners.Text &= " (" & Winner.Party & ")" & Environment.NewLine
        End If
    End Sub

End Class
