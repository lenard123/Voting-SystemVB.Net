Imports System.Data.OleDb

Public Class Votes

    Private Shared ReadOnly QUERY_COUNT_ALL = "SELECT COUNT(*) FROM (SELECT DISTINCT [student_id] FROM [Votes])"
    Private Shared ReadOnly QUERY_COUNT_VOTE = "SELECT [candidate_id], COUNT([candidate_id]) as [Votes] FROM (SELECT [Votes].[candidate_id] FROM [Votes] INNER JOIN [Candidate] ON [Votes].[candidate_id]=[Candidate].[ID] WHERE [position_id]=?) GROUP BY [candidate_id]"

    Public Shared Async Function CountAllDoneAsync() As Task(Of Integer)
        Dim Res As Integer = 0
        Await GetConnection().OpenAsync()
        Using Cmd As New OleDbCommand(QUERY_COUNT_ALL, GetConnection())
            Res = Await Cmd.ExecuteScalarAsync()
        End Using
        GetConnection().Close()
        Return Res
    End Function

    Public Shared Async Function CountVotesAsync(PositionID As Integer) As Task(Of Dictionary(Of Integer, Integer))
        Dim Result As New Dictionary(Of Integer, Integer)
        Await GetConnection().OpenAsync()
        Using Cmd As New OleDbCommand(QUERY_COUNT_VOTE, GetConnection())
            Cmd.Parameters.Add(ConvertToParam(OleDbType.Integer, PositionID, 1))
            Cmd.Prepare()
            Using Reader = Await Cmd.ExecuteReaderAsync()
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

End Class
