<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemCrashError
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
        Me.Icon = New System.Windows.Forms.PictureBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Icon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 190)
        Me.Panel1.TabIndex = 0
        '
        'Icon
        '
        Me.Icon.Image = Global.Voting_SystemVB.My.Resources.Resources.error_white
        Me.Icon.Location = New System.Drawing.Point(287, 39)
        Me.Icon.Name = "Icon"
        Me.Icon.Size = New System.Drawing.Size(142, 127)
        Me.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon.TabIndex = 0
        Me.Icon.TabStop = False
        '
        'LabelTitle
        '
        Me.LabelTitle.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitle.Location = New System.Drawing.Point(0, 238)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(710, 32)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "Oh Snap!"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDescription
        '
        Me.LabelDescription.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.LabelDescription.Location = New System.Drawing.Point(0, 281)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(710, 25)
        Me.LabelDescription.TabIndex = 1
        Me.LabelDescription.Text = "It looks like an error occured"
        Me.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(299, 346)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(112, 32)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'SystemCrashError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SystemCrashError"
        Me.Size = New System.Drawing.Size(710, 416)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Icon As System.Windows.Forms.PictureBox
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents LabelDescription As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button

End Class
