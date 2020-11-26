Imports System.Configuration
Imports System.Drawing.Text
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Guna.UI2.WinForms
Imports System.Text

Module Util

    Private FontAwesome As PrivateFontCollection

    Public Function ConvertToImage(Filename As String) As Bitmap
        Dim ImagePath = ""
        Dim Result As Bitmap
        If File.Exists(Filename) Then
            ImagePath = Filename
        ElseIf File.Exists(GetFullPath(Filename)) Then
            ImagePath = GetFullPath(Filename)
        Else
            ImagePath = GetFullPath("images\default\error.jpg")
        End If

        Using tempBitm = New Bitmap(ImagePath)
            Using tempPicturebox = New PictureBox()
                tempPicturebox.Image = tempBitm
                tempPicturebox.SizeMode = PictureBoxSizeMode.AutoSize
                Result = GetControlImage(tempPicturebox)
            End Using
        End Using
        Return Result
    End Function

    Public Function GetFullPath(file As String) As String
        Return Path.Combine(Application.StartupPath, file)
    End Function

    Public Function Upload(directoryname As String, filename As String, source As String)
        Dim dir = Path.Combine(Application.StartupPath, "images", directoryname)
        Dim fil = Path.Combine(dir, filename)
        If Not Directory.Exists(dir) Then
            Directory.CreateDirectory(dir)
        End If

        If File.Exists(fil) Then
            File.Replace(source, fil, Nothing)
        Else
            File.Copy(source, fil)
        End If

        Return Path.Combine("images", directoryname, filename)

    End Function

    Public Sub DeleteFile(fname As String)
        If File.Exists(fname) Then
            File.Delete(fname)
        ElseIf File.Exists(GetFullPath(fname)) Then
            File.Delete(GetFullPath(fname))
        End If
    End Sub

    Public Function GetFontAwesomeSolid(size As Integer) As Font
        LoadFont()
        Return New Font(FontAwesome.Families(0), size)
    End Function

    Public Sub LoadFont()
        If IsNothing(FontAwesome) Then
            FontAwesome = New PrivateFontCollection
            Dim intLength As Integer = My.Resources.FontAwesomeSolid.Length
            Dim byteFont() As Byte = My.Resources.FontAwesomeSolid
            Dim data As IntPtr = Marshal.AllocCoTaskMem(intLength)
            Marshal.Copy(byteFont, 0, data, intLength)
            FontAwesome.AddMemoryFont(data, intLength)
        End If
    End Sub

    Public Function Config(Key As String) As String
        Try
            Dim AppSettings = ConfigurationManager.AppSettings
            Dim result = AppSettings(Key)
            If (IsNothing(result)) Then
                result = ""
            End If
            Return result
        Catch ex As ConfigurationException
            Dim sc As New SystemCrashError("Oops!", "There was an error while reading the App Configuration")
            Return ""
        End Try
    End Function

    Public Function GetControlImage(ByRef ctl As Control)
        Dim bm As New Bitmap(ctl.Width, ctl.Height)
        ctl.DrawToBitmap(bm, New Rectangle(0, 0, ctl.Width, ctl.Height))
        Return bm
    End Function

    Public Function Validator(ByVal Name As String, ByRef Control As Guna2ComboBox, ByRef ErrorMessage As Label, ParamArray Rules() As String) As Boolean
        Return Validator(Name, Control.BorderColor, Control.Text, Control.Text.Length, ErrorMessage, Rules)
    End Function

    Public Function Validator(ByVal Name As String, ByRef Control As Guna2TextBox, ByRef ErrorMessage As Label, ParamArray Rules() As String) As Boolean
        Return Validator(Name, Control.BorderColor, Control.Text, Control.TextLength, ErrorMessage, Rules)
    End Function

    Public Function Validator(ByVal Name As String, ByRef BorderColor As Color, ByVal txt As String, ByVal len As Integer, ByVal ErrorMessage As Label, ParamArray Rules() As String) As Boolean
        'SET default
        BorderColor = Color.FromArgb(217, 221, 226)
        ErrorMessage.Text = ""
        For Each Rule In Rules
            Dim _Rule = Rule.Split(":").GetValue(0)
            If _Rule.Equals("required") And len < 1 Then
                BorderColor = Color.Red
                ErrorMessage.Text = Name & " Field is required."
                Return False
            ElseIf _Rule.Equals("min") Then
                Dim min = Integer.Parse(Rule.Split(":").GetValue(1))
                If len < min Then
                    BorderColor = Color.Red
                    ErrorMessage.Text = Name & " Field must not less than " & min & " characters."
                    Return False
                End If
            ElseIf _Rule.Equals("exact") Then
                Dim exact = Integer.Parse(Rule.Split(":").GetValue(1))
                If exact <> len Then
                    BorderColor = Color.Red
                    ErrorMessage.Text = Name & " Field must have exactly " & exact & " characters."
                    Return False
                End If
            ElseIf _Rule.Equals("alpa") Then
                Dim res = RegularExpressions.Regex.IsMatch(txt, "^[A-Za-z]+$")
                If Not res Then
                    BorderColor = Color.Red
                    ErrorMessage.Text = Name & " Field must only contain letters."
                End If
            End If
        Next
        Return True
    End Function

End Module
