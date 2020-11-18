Imports System.Configuration

Module Util

    Public Function Config(Key As String) As String
        Try
            Dim AppSettings = ConfigurationManager.AppSettings
            Dim result = AppSettings(Key)
            If (IsNothing(result)) Then
                result = ""
            End If
            Return result
        Catch ex As ConfigurationException
            MessageBox.Show("There is an error while reading the App Configuration")
            Return ""
        End Try
    End Function

End Module
