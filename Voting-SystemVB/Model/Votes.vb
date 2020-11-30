Imports System.Data.OleDb

Public Class Votes

    Private Shared ReadOnly QUERY_COUNT_ALL = "SELECT COUNT(*) FROM (SELECT DISTINCT [student_id] FROM [Votes])"

    Public Shared Async Function CountAllDone() As Task(Of Integer)
        Dim Res As Integer = 0
        Await GetConnection().OpenAsync()
        Using Cmd As New OleDbCommand(QUERY_COUNT_ALL, GetConnection())
            Res = Await Cmd.ExecuteScalarAsync()
        End Using
        GetConnection().Close()
        Return Res
    End Function

End Class
