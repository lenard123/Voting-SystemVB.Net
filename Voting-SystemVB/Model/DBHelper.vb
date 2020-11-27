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
End Module
