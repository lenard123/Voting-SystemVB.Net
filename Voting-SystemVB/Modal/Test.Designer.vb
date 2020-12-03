<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Guna2ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Guna2VProgressBar1 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Guna2WinProgressIndicator1 = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.SuspendLayout()
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(63, 86)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(216, 49)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Guna2Button1"
        '
        'Guna2CircleProgressBar1
        '
        Me.Guna2CircleProgressBar1.Location = New System.Drawing.Point(322, 102)
        Me.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar1.ShadowDecoration.Parent = Me.Guna2CircleProgressBar1
        Me.Guna2CircleProgressBar1.Size = New System.Drawing.Size(130, 130)
        Me.Guna2CircleProgressBar1.TabIndex = 1
        '
        'Guna2ProgressBar1
        '
        Me.Guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2ProgressBar1.Location = New System.Drawing.Point(322, 68)
        Me.Guna2ProgressBar1.Name = "Guna2ProgressBar1"
        Me.Guna2ProgressBar1.ShadowDecoration.Parent = Me.Guna2ProgressBar1
        Me.Guna2ProgressBar1.Size = New System.Drawing.Size(300, 10)
        Me.Guna2ProgressBar1.TabIndex = 2
        Me.Guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2VProgressBar1
        '
        Me.Guna2VProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2VProgressBar1.Location = New System.Drawing.Point(540, 102)
        Me.Guna2VProgressBar1.Name = "Guna2VProgressBar1"
        Me.Guna2VProgressBar1.ShadowDecoration.Parent = Me.Guna2VProgressBar1
        Me.Guna2VProgressBar1.Size = New System.Drawing.Size(30, 300)
        Me.Guna2VProgressBar1.TabIndex = 3
        Me.Guna2VProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2WinProgressIndicator1
        '
        Me.Guna2WinProgressIndicator1.CircleSize = 1.0!
        Me.Guna2WinProgressIndicator1.Location = New System.Drawing.Point(91, 174)
        Me.Guna2WinProgressIndicator1.Name = "Guna2WinProgressIndicator1"
        Me.Guna2WinProgressIndicator1.Size = New System.Drawing.Size(156, 156)
        Me.Guna2WinProgressIndicator1.TabIndex = 4
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2WinProgressIndicator1)
        Me.Controls.Add(Me.Guna2VProgressBar1)
        Me.Controls.Add(Me.Guna2ProgressBar1)
        Me.Controls.Add(Me.Guna2CircleProgressBar1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Name = "Test"
        Me.Size = New System.Drawing.Size(760, 407)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Guna2ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Guna2VProgressBar1 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Guna2WinProgressIndicator1 As Guna.UI2.WinForms.Guna2WinProgressIndicator

End Class
