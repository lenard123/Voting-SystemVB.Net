Public Class VoteInfo

    Implements MainControl

    Private Shared Instance As VoteInfo
    Private Shared Candidates As List(Of Candidate)

    Public Shared Function GetInstance() As VoteInfo
        If IsNothing(Instance) Then
            Instance = New VoteInfo
            Instance.DoubleBuffered = True
        End If
        Return Instance
    End Function

    Public Sub VoteInfo_Refresh() Implements MainControl.RefreshControl
        Candidates = VotersPanel.GetVotedCandidates()
        LabelPresident.Text = GetFullName(Position.PRESIDENT_ID)
        LabelVicePresident.Text = GetFullName(Position.VICE_PRESIDENT_ID)
        LabelSecretary.Text = GetFullName(Position.SECRETARY_ID)
        Label1Treasurer.Text = GetFullName(Position.TREASURER_ID)
        LabelAuditor.Text = GetFullName(Position.AUDITOR_ID)
        LabelPRO.Text = GetFullName(Position.PRO_ID)
    End Sub

    Function GetFullName(id As Integer) As String
        For Each item In Candidates
            If item.PositionID = id Then Return item.Fullname & GetParty(item.Party)
        Next
        Return "(Non Selected)"
    End Function

    Shared Function GetParty(Party As String) As String
        If IsNothing(Party) OrElse Party.Equals("") Then Party = "Independent"
        Return " (" & Party & ")"
    End Function

End Class
