Public Class AdminHomeNotStarted

    Dim CandidateCounts As New List(Of KeyValuePair(Of Integer, Integer))
    Dim VoterCounts As Integer

    Private Shared Instance As AdminHomeNotStarted

    Public Shared Function GetInstance()
        If IsNothing(Instance) Then
            Instance = New AdminHomeNotStarted()
        End If
        Return Instance
    End Function


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

    Private Async Sub AdminHomeNotStarted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VoterCounts = Await Student.CountAllAsync()
        For Each Id In Position.GetAll()
            CandidateCounts.Add(New KeyValuePair(Of Integer, Integer)(Id, Await Candidate.CountAsync(Id)))
        Next
    End Sub

    Private Sub TotalParties_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TotalCandidates_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TotalVoters_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Remaining_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonVPresident_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonSecretary_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonTreasurer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VPresident_Click(sender As Object, e As EventArgs) Handles VPresident.Click

    End Sub

    Private Sub Auditor_Click(sender As Object, e As EventArgs) Handles Auditor.Click

    End Sub

    Private Sub Secretary_Click(sender As Object, e As EventArgs) Handles Secretary.Click

    End Sub

    Private Sub President_Click(sender As Object, e As EventArgs) Handles President.Click

    End Sub

    Private Sub ViewChart_Click(sender As Object, e As EventArgs) Handles ViewChart.Click

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub
End Class
