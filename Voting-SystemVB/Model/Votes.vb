Imports System.Data.OleDb

Public Class Votes

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
        Return CountVotes(PositionID, Election.GetCurrentId())
    End Function
    Public Shared Function CountVotes(PositionID As Integer, ElectionId As Integer) As Dictionary(Of Integer, Integer)
        Dim Result As New Dictionary(Of Integer, Integer)
        GetConnection().Open()
        Using Cmd As New OleDbCommand(QUERY_COUNT_VOTE, GetConnection())
            BindParameters(Cmd, PositionID, ElectionId)
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

    'Count the votes of All Candidates
    Public Shared Function CountAllVotes() As Dictionary(Of Integer, Dictionary(Of Integer, Integer))
        Dim Result As New Dictionary(Of Integer, Dictionary(Of Integer, Integer))
        Position.GetAll().ForEach(Sub(position_id As Integer) Result.Add(position_id, CountVotes(position_id)))
        Return Result
    End Function

    Public Shared Sub SubmitVotes(Candidates As List(Of Integer))

        If IsNothing(Student.GetCurrentUser()) Then Throw New NotLoggedInException

        If Not Election.IsOngoing() Then Throw New ApplicationException("Election is not ongoing")

        If Student.RefreshCurrentUser().HasVoted Then Throw New AlreadyVotedException

        Using Cmd As New OleDbCommand(QUERY_INSERT_VOTE, GetConnection())
            GetConnection().Open()
            For Each item In Candidates
                BindParameters(Cmd, Student.GetCurrentUser().Id, item)
                Cmd.ExecuteNonQuery()
            Next
            GetConnection().Close()
        End Using
    End Sub

    Public Shared Sub FinalizeResult(Candidates As Dictionary(Of Integer, Candidate))
        GetConnection.Open()
        Using Cmd As New OleDbCommand(QUERY_INSERT_RESULT, GetConnection())
            For i = 1 To 6
                Dim cand = Candidates(i)
                Dim iParty = IIf(IsNothing(cand.Party), "Independent", cand.Party)
                BindParameters(Cmd, Election.GetCurrentElection().Id, i, cand.ID, cand.Fullname, iParty, cand.GetVoteCount())
                Cmd.ExecuteNonQuery()
            Next
        End Using
        GetConnection().Close()
        Election.FinalizeElection()
    End Sub

    '
    ' CONSTANT PROPERTIES
    '
    Private Const QUERY_COUNT_ALL = "SELECT COUNT(*) FROM (SELECT DISTINCT [student_id] FROM [Votes])"
    Private Const QUERY_COUNT_VOTE = "SELECT [candidate_id], COUNT([candidate_id]) as [Votes] FROM (SELECT [Votes].[candidate_id] FROM [Votes] INNER JOIN [Candidate] ON [Votes].[candidate_id]=[Candidate].[ID] WHERE [position_id]=? and  [Candidate].[election_id]=?) GROUP BY [candidate_id]"
    Private Const QUERY_INSERT_VOTE = "INSERT INTO [Votes]([student_id],[candidate_id]) VALUES (?,?)"
    Private Const QUERY_INSERT_RESULT = "INSERT INTO [Result]([election_id],[position_id],[candidate_id],[fullname],[party],[votes]) VALUES (?,?,?,?,?,?)"

End Class
