Imports System.Data.OleDb

Public Class Votes

    Private Const QUERY_COUNT_ALL = "SELECT COUNT(*) FROM (SELECT DISTINCT [student_id] FROM [Votes])"
    Private Const QUERY_COUNT_VOTE = "SELECT [candidate_id], COUNT([candidate_id]) as [Votes] FROM (SELECT [Votes].[candidate_id] FROM [Votes] INNER JOIN [Candidate] ON [Votes].[candidate_id]=[Candidate].[ID] WHERE [position_id]=?) GROUP BY [candidate_id]"
    Private Const QUERY_INSERT_VOTE = "INSERT INTO [Votes]([student_id],[candidate_id]) VALUES (?,?)"

    'Return the number of student who already voted
    Public Shared Function CountAllDone() As Integer
        Dim Res As Integer = 0
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_COUNT_ALL, GetConnection())
            Res = Cmd.ExecuteScalar()
        End Using
        GetConnection().Close()
        Return Res
    End Function

    'Count the votes of the candidates in the specified position
    Public Shared Function CountVotes(PositionID As Integer) As Dictionary(Of Integer, Integer)
        Dim Result As New Dictionary(Of Integer, Integer)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_COUNT_VOTE, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, PositionID, 1))
            Cmd.Prepare()
            Using Reader = Cmd.ExecuteReader()
                While Reader.Read()
                    Dim CandidateID As Integer = Reader.GetInt32(0)
                    Dim VoteCount As Integer = Reader.GetInt32(1)
                    Result.Add(CandidateID, VoteCount)
                End While
            End Using
        End Using
        GetConnection().Close()
        Return Result
    End Function

    Public Shared Function SubmitVotes(Candidates As List(Of Integer)) As Boolean
        If IsNothing(Student.GetCurrentUser()) Then
            Debug.WriteLine("No Active user")
            Return False
        ElseIf Not Election.IsOngoing() Then
            Debug.WriteLine("Election is not ongoing")
            Return False
        ElseIf Student.RefreshCurrentUser().HasVoted Then
            Debug.WriteLine("User already voted")
            Return False
        Else
            GetConnection().Open()
            Using Cmd As New OleDbCommand(QUERY_INSERT_VOTE, GetConnection())
                For Each item In Candidates
                    Cmd.Parameters.Clear()
                    Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, Student.GetCurrentUser().Id, Student.LENGTH_ID))
                    Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, item, Candidate.LENGTH_ID))
                    Cmd.Prepare()
                    If Cmd.ExecuteNonQuery() = -1 Then
                        GetConnection().Close()
                        Return False
                    End If
                Next
            End Using
            GetConnection().Close()
            Return True
        End If
    End Function

End Class
