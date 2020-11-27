Public Class Alert

    Enum AlertType
        Success
        Warning
        [Error]
        Info
    End Enum

    Dim x, y As Integer
    Public Sub setAlert(msg As String, type As AlertType)
        Dim fname As String
        Me.Opacity = 0
        Me.StartPosition = FormStartPosition.Manual
        'Me.TopMost = True
        For i As Integer = 0 To 10
            fname = "alert" & i.ToString()
            Dim f As Alert = Application.OpenForms.Item(fname)
            If f Is Nothing Then
                Me.Name = fname
                x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                Me.Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5
        Select Case type
            Case AlertType.Success
                PictureBox1.Image = My.Resources.check
                BackColor = Color.FromArgb(82, 152, 114)
            Case AlertType.Warning
                PictureBox1.Image = My.Resources.error_white
                BackColor = Color.FromArgb(255, 164, 91)
            Case AlertType.Error
                PictureBox1.Image = My.Resources.error_white
                BackColor = Color.FromArgb(255, 70, 70)
            Case AlertType.Info
                PictureBox1.Image = My.Resources.info
                BackColor = Color.FromArgb(71, 169, 248)
        End Select
        Label1.Text = msg
        Me.Show()
        Me.Timer1.Interval = 1
        Me.Timer1.Start()
    End Sub

    Enum actionEnum
        wait
        start
        close
    End Enum

    Private action As actionEnum = actionEnum.start

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case actionEnum.start
                Timer1.Interval = 1
                Me.Opacity += 0.1
                If x < Me.Location.X Then
                    Me.Left -= 1
                Else
                    If Me.Opacity = 1 Then
                        action = actionEnum.wait
                    End If
                End If
            Case actionEnum.wait
                Timer1.Interval = 3000
                action = actionEnum.close
            Case actionEnum.close
                Timer1.Interval = 1
                Me.Opacity -= 0.1
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Close()
                End If
        End Select
    End Sub

    Public Sub CloseAlert()
        action = actionEnum.close
        Timer1.Interval = 1
    End Sub

    Public Shared Function ShowAlert(msg As String, type As AlertType) As Alert
        Dim _alert As New Alert
        _alert.setAlert(msg, type)
        Return _alert
    End Function

End Class