Public Class ModalPopup

    Inherits Form

    Private Content As Control
    Private frm As Form


    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        ShowInTaskbar = False
        BackColor = Color.Black
        Opacity = 0.5
        Owner = Main.Instance
        Size = Main.Instance.Size
    End Sub

    Public Sub Init(Content As Control)
        Me.Content = Content
    End Sub


    Public Sub ShowPopup()
        Me.Show()
        Me.Location = Main.Instance.Location
        frm = New Form
        frm.BackColor = Color.Black
        frm.Size = Main.Instance.Size
        frm.Owner = Main.Instance
        frm.ShowInTaskbar = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Size = Content.Size()
        frm.Controls.Add(Content)
        frm.StartPosition = FormStartPosition.CenterScreen
        AddHandler frm.FormClosed, AddressOf OnFrmClose
        frm.ShowDialog()
    End Sub

    Sub OnFrmClose()
        Me.Dispose()
        Main.Instance.Activate()
        GC.Collect()
    End Sub

    Public Sub ChangeContent(Content As Control)
        Me.Content.Dispose()
        Me.frm.Dispose()
        Me.Content = Content
    End Sub

    Public Sub ClosePopup()
        frm.Dispose()
    End Sub

End Class
