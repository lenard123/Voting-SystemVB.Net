Public Class ModalPopup

    Inherits Form

    Private Content As Control
    Private frm As Form
    Private WithEvents TimerFadeOut As New Timer


    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        ShowInTaskbar = False
        BackColor = Color.Black
        Opacity = 0.5
        Owner = Main.Instance
        Size = Main.Instance.Size

        TimerFadeOut.Interval = 1
    End Sub

    Public Sub Init(Content As Control)
        Me.Content = Content
    End Sub


    Public Sub ShowPopup()
        Me.Show()
        Me.Location = Main.Instance.Location
        frm = New Form
        frm.Size = Main.Instance.Size
        frm.Owner = Main.Instance
        frm.ShowInTaskbar = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Size = Content.Size()
        frm.Controls.Add(Content)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.TopMost = True

        AddHandler Content.Disposed, AddressOf OnFrmClose
        AddHandler frm.FormClosed, AddressOf OnFrmClose
        AddHandler Me.FormClosed, AddressOf OnFrmClose

        frm.ShowDialog()
    End Sub

    Sub OnFrmClose(sender As Object, e As EventArgs)
        If sender.Equals(Content) Then
            frm.Dispose()
        ElseIf sender.Equals(frm) Then
            TimerFadeOut.Start()
        ElseIf sender.Equals(Me) Then
            Main.Instance.BringToFront()
        End If
    End Sub

    Public Sub ChangeContent(Content As Control)
        Me.Content.Dispose()
        Me.Content = Content
    End Sub

    Public Sub ClosePopup()
        Content.Dispose()
    End Sub

    Sub TimerFadeOut_Tick(sender As Object, e As EventArgs) Handles TimerFadeOut.Tick
        If Me.Opacity > 0 Then
            Opacity -= 0.04
        Else
            TimerFadeOut.Stop()
            Me.Close()
            'GC.Collect()
        End If
    End Sub

End Class
