Imports System.Data.OleDb

Module DBHelper

    Private Connection As OleDbConnection = Nothing

    Public Function GetConnection() As OleDbConnection
        If IsNothing(Connection) Then
            Connection = New OleDbConnection(Config("ConnectionString"))
        End If
        Return Connection
    End Function

    Public Function ExecuteReader(Connection As OleDbConnection, Query As String, Parameters As List(Of OleDbParameter)) As OleDbDataReader
        Dim Command As OleDbCommand = New OleDbCommand(Query, Connection)
        For Each Parameter As OleDbParameter In Parameters
            Command.Parameters.Add(Parameter)
        Next
        Command.Prepare()
        Return Command.ExecuteReader()
    End Function

    Public Function ExecuteReader(Connection As OleDbConnection, Query As String, Parameter As OleDbParameter) As OleDbDataReader
        Dim Parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)
        Parameters.Add(Parameter)
        Return ExecuteReader(Connection, Query, Parameters)
    End Function

    Public Function ConvertToParam(Type As OleDbType, Value As Object, Length As Integer) As OleDbParameter
        Dim Param As OleDbParameter = New OleDbParameter()
        Param.OleDbType = Type
        Param.Value = Value
        Param.Size = Length
        Return Param
    End Function
End Module
