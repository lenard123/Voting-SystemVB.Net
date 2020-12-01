Public Class AdminHomeNotStarted

    Implements MainControl

    Dim CandidateCounts As New List(Of KeyValuePair(Of Integer, Integer))
    Dim VoterCounts As Integer

    Private Shared Instance As AdminHomeNotStarted

    Public Shared Function GetInstance()
        If IsNothing(Instance) Then
            Instance = New AdminHomeNotStarted()
        End If
        Return Instance
    End Function

    Private Sub ButtonStartElection_Click(sender As Object, e As EventArgs) 
        If isValid() Then
            AdminPanel.GetInstance().LoadControl(StartElection.GetInstance())
        End If
    End Sub

    Private Function isValid() As Boolean
        If VoterCounts < 30 Then
            Alert.ShowAlert("Atleast 30 voters are required to start the Election", Alert.AlertType.Error)
            Return False
        End If

        For Each Key As KeyValuePair(Of Integer, Integer) In CandidateCounts
            If Not ValidatePosition(Key) Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Function ValidatePosition(item As KeyValuePair(Of Integer, Integer)) As Boolean
        Dim Count As Integer = item.Value
        Dim Name As String = Position.GetName(item.Key)
        If Count < 1 Then
            Alert.ShowAlert("There is no candidate yet in the " & Name & " position", Alert.AlertType.Error)
            Return False
        ElseIf Count = 1 Then
            Alert.ShowAlert("There is only one candidate in " & Name & " position, and will win by default", Alert.AlertType.Warning)
        End If
        Return True
    End Function

    Private Async Sub AdminHomeNotStarted_Refresh() Implements MainControl.RefreshControl
        VoterCounts = Await Student.CountAllAsync()
        For Each Id In Position.GetAll()
            CandidateCounts.Add(New KeyValuePair(Of Integer, Integer)(Id, Await Candidate.CountAsync(Id)))
        Next
    End Sub

End Class
