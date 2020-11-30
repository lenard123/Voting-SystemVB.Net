Imports System.Data.OleDb

Module DBHelper

    Private Connection As OleDbConnection = Nothing

    Public Function GetConnection() As OleDbConnection
        If IsNothing(Connection) Then
            Connection = New OleDbConnection(Config("ConnectionString"))
        End If
        Return Connection
    End Function

    Public Function ConvertToParam(Type As OleDbType, Value As Object, Length As Integer) As OleDbParameter
        Dim Param As OleDbParameter = New OleDbParameter()
        Param.OleDbType = Type
        Param.Value = Value
        Param.Size = Length
        Return Param
    End Function

    Public Function TestConnection() As Boolean
        Try
            GetConnection.Open()
            GetConnection.Close()
            Return True
        Catch ex As OleDb.OleDbException
            Return False
        End Try
    End Function

End Module
