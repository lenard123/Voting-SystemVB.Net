Imports System.Data.OleDb

Module DBHelper

    Private Connection As OleDbConnection = Nothing

    Public Function GetConnection() As OleDbConnection
        If IsNothing(Connection) Then
            Connection = New OleDbConnection(Config("ConnectionString"))
        End If
        Return Connection
    End Function

End Module
