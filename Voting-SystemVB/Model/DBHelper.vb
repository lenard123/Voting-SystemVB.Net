Imports System.Data.OleDb

Module DBHelper

    Enum DatabaseType
        NONE
        MDB
        ACCDB
        XLXS
    End Enum

    Private Connection As OleDbConnection = Nothing

    Public Function GetConnection() As OleDbConnection
        If IsNothing(Connection) Then
            Connection = New OleDbConnection(Config("ConnectionString"))
        End If
        Return Connection
    End Function

    Public Function GetProvider(type As DatabaseType) As String
        Select Case type
            Case DatabaseType.ACCDB
                Return "Microsoft.ACE.OLEDB.12.0"
            Case Else
                Return ""
        End Select
    End Function

    Public Function GetDBSchema(type As DatabaseType, conn As System.Data.Common.DbConnection) As Dictionary(Of String, List(Of String))
        Dim Result As New Dictionary(Of String, List(Of String))
        Select Case type
            Case DatabaseType.ACCDB
                conn.Open()
                Dim table_schema = conn.GetSchema("tables")
                For Each rowTable As DataRow In table_schema.Rows
                    Dim table_name As String = rowTable(2)
                    Dim columns As New List(Of String)

                    If table_name.Substring(0, 4).Equals("MSys") Then Continue For
                    Dim column_schema = conn.GetSchema("Columns", {Nothing, Nothing, table_name, Nothing})
                    For Each rowColumn As DataRow In column_schema.Rows
                        columns.Add(rowColumn("column_name"))
                    Next
                    Result.Add(table_name, columns)
                Next
                conn.Close()
        End Select
        Return Result
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
