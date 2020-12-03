Public Class ModalPopup

    Inherits UserControl

    Private Content As Control
    Private frm As Form
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Private DrawBackground As Boolean = True


    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
    End Sub

    Public Sub Init(Content As Control)
        Me.Content = Content
    End Sub


    Public Sub ShowPopup()
        If DrawBackground Then DrawPopupBackground()
        Main.Instance.Activate()
        frm = New Form
        frm.Owner = Main.Instance
        frm.ShowInTaskbar = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Size = Content.Size()
        frm.Controls.Add(Content)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Public Sub ChangeContent(Content As Control)
        Me.Content.Dispose()
        Me.frm.Dispose()
        DrawBackground = False
        Me.Content = Content
    End Sub

    Public Sub ClosePopup()
        frm.Dispose()
        Me.Dispose()
        GC.Collect()
    End Sub

    Private Sub DrawPopupBackground()
        BackgroundImage = GetControlImage(Main.Instance.Controls(0))
        Using grp As Graphics = Graphics.FromImage(BackgroundImage)
            Using brsh As Brush = New SolidBrush(Color.FromArgb(100, Color.Black))
                grp.FillRectangle(brsh, 0, 0, BackgroundImage.Width, BackgroundImage.Height)
            End Using
        End Using
        Me.Dock = DockStyle.Fill
        Main.Instance.Controls.Add(Me)
        Me.BringToFront()
    End Sub

End Class
