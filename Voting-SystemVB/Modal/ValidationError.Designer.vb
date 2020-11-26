<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidationError
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelErrors = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LabelTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 116)
        Me.Panel1.TabIndex = 1
        '
        'LabelTitle
        '
        Me.LabelTitle.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(3, 40)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(418, 32)
        Me.LabelTitle.TabIndex = 2
        Me.LabelTitle.Text = "Validation Errors"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LabelErrors)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(0, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(421, 165)
        Me.Panel2.TabIndex = 3
        '
        'LabelErrors
        '
        Me.LabelErrors.AutoEllipsis = True
        Me.LabelErrors.AutoSize = True
        Me.LabelErrors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelErrors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrors.Location = New System.Drawing.Point(0, 0)
        Me.LabelErrors.Name = "LabelErrors"
        Me.LabelErrors.Padding = New System.Windows.Forms.Padding(30, 10, 0, 10)
        Me.LabelErrors.Size = New System.Drawing.Size(30, 40)
        Me.LabelErrors.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 105)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(421, 60)
        Me.Panel3.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(310, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ValidationError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ValidationError"
        Me.Size = New System.Drawing.Size(421, 280)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LabelErrors As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
