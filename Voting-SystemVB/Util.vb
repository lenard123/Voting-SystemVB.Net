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

    Public Function GetControlImage(ByRef ctl As Control)
        Dim bm As New Bitmap(ctl.Width, ctl.Height)
        ctl.DrawToBitmap(bm, New Rectangle(0, 0, ctl.Width, ctl.Height))
        Return bm
    End Function

End Module
