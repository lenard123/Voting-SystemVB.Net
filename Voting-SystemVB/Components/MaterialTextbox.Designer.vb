<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaterialTextbox
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
        Me.TextField = New System.Windows.Forms.TextBox()
        Me.Underline = New System.Windows.Forms.Panel()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextField
        '
        Me.TextField.BackColor = System.Drawing.SystemColors.Control
        Me.TextField.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextField.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextField.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TextField.Location = New System.Drawing.Point(0, 0)
        Me.TextField.Name = "TextField"
        Me.TextField.Size = New System.Drawing.Size(244, 20)
        Me.TextField.TabIndex = 0
        '
        'Underline
        '
        Me.Underline.BackColor = System.Drawing.Color.Gray
        Me.Underline.Dock = System.Windows.Forms.DockStyle.Top
        Me.Underline.Location = New System.Drawing.Point(0, 20)
        Me.Underline.Name = "Underline"
        Me.Underline.Size = New System.Drawing.Size(244, 3)
        Me.Underline.TabIndex = 1
        '
        'LabelError
        '
        Me.LabelError.AutoEllipsis = True
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(0, 26)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(0, 13)
        Me.LabelError.TabIndex = 2
        '
        'MaterialTextbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.Underline)
        Me.Controls.Add(Me.TextField)
        Me.MaximumSize = New System.Drawing.Size(1000, 40)
        Me.MinimumSize = New System.Drawing.Size(200, 40)
        Me.Name = "MaterialTextbox"
        Me.Size = New System.Drawing.Size(244, 40)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextField As System.Windows.Forms.TextBox
    Friend WithEvents Underline As System.Windows.Forms.Panel
    Friend WithEvents LabelError As System.Windows.Forms.Label

End Class
