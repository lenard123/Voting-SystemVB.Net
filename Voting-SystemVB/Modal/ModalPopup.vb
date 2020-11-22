Public Class ModalPopup

    Inherits UserControl

    Private Content As Control
    Private OwnerForm As Form
    Private frm As Form

    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        OwnerForm = Main.Instance
    End Sub

    Public Sub Init(Content As Control)
        Me.Content = Content
    End Sub


    Public Sub ShowPopup()
        DrawPopupBackground()
        frm = New Form
        frm.ShowInTaskbar = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Size = Content.Size()
        frm.Controls.Add(Content)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub



    Public Sub ClosePopup()
        OwnerForm.Controls.Remove(Me)
        Content.Dispose()
        frm.Dispose()
        Me.Dispose()
        GC.Collect()
    End Sub

    Private Sub DrawPopupBackground()
        BackgroundImage = GetControlImage(OwnerForm)
        Using grp As Graphics = Graphics.FromImage(BackgroundImage)
            Using brsh As Brush = New SolidBrush(Color.FromArgb(90, Color.Black))
                grp.FillRectangle(brsh, 0, 0, BackgroundImage.Width, BackgroundImage.Height)
            End Using
        End Using
        Me.Dock = DockStyle.Fill
        OwnerForm.Controls.Add(Me)
        Me.BringToFront()
    End Sub

End Class
