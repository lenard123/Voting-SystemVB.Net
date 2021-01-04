<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalizeResult
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ButtonSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.LabelPRO = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelAuditor = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1Treasurer = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelSecretary = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelVicePresident = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelPresident = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Finalize Election Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(36, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(456, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select the final winner for candidates with the same vote counts."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ButtonSubmit)
        Me.Panel3.Controls.Add(Me.Guna2Separator1)
        Me.Panel3.Controls.Add(Me.LabelPRO)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.LabelAuditor)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label1Treasurer)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.LabelSecretary)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.LabelVicePresident)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.LabelPresident)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(35, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(384, 436)
        Me.Panel3.TabIndex = 6
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Animated = True
        Me.ButtonSubmit.CheckedState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.CustomImages.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.White
        Me.ButtonSubmit.HoverState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Location = New System.Drawing.Point(91, 374)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.ShadowDecoration.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Size = New System.Drawing.Size(175, 34)
        Me.ButtonSubmit.TabIndex = 19
        Me.ButtonSubmit.Text = "Finalize Result"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(31, 76)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(333, 10)
        Me.Guna2Separator1.TabIndex = 17
        '
        'LabelPRO
        '
        Me.LabelPRO.AutoEllipsis = True
        Me.LabelPRO.AutoSize = True
        Me.LabelPRO.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelPRO.ForeColor = System.Drawing.Color.White
        Me.LabelPRO.Location = New System.Drawing.Point(87, 294)
        Me.LabelPRO.Name = "LabelPRO"
        Me.LabelPRO.Size = New System.Drawing.Size(121, 19)
        Me.LabelPRO.TabIndex = 4
        Me.LabelPRO.Text = "(None Selected)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label14.ForeColor = System.Drawing.Color.DarkGray
        Me.Label14.Location = New System.Drawing.Point(27, 294)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 19)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "P.R.O.:"
        '
        'LabelAuditor
        '
        Me.LabelAuditor.AutoEllipsis = True
        Me.LabelAuditor.AutoSize = True
        Me.LabelAuditor.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelAuditor.ForeColor = System.Drawing.Color.White
        Me.LabelAuditor.Location = New System.Drawing.Point(95, 256)
        Me.LabelAuditor.Name = "LabelAuditor"
        Me.LabelAuditor.Size = New System.Drawing.Size(121, 19)
        Me.LabelAuditor.TabIndex = 6
        Me.LabelAuditor.Text = "(None Selected)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(27, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 19)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Auditor:"
        '
        'Label1Treasurer
        '
        Me.Label1Treasurer.AutoEllipsis = True
        Me.Label1Treasurer.AutoSize = True
        Me.Label1Treasurer.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label1Treasurer.ForeColor = System.Drawing.Color.White
        Me.Label1Treasurer.Location = New System.Drawing.Point(108, 218)
        Me.Label1Treasurer.Name = "Label1Treasurer"
        Me.Label1Treasurer.Size = New System.Drawing.Size(121, 19)
        Me.Label1Treasurer.TabIndex = 8
        Me.Label1Treasurer.Text = "(None Selected)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(27, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Treasurer:"
        '
        'LabelSecretary
        '
        Me.LabelSecretary.AutoEllipsis = True
        Me.LabelSecretary.AutoSize = True
        Me.LabelSecretary.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelSecretary.ForeColor = System.Drawing.Color.White
        Me.LabelSecretary.Location = New System.Drawing.Point(108, 180)
        Me.LabelSecretary.Name = "LabelSecretary"
        Me.LabelSecretary.Size = New System.Drawing.Size(121, 19)
        Me.LabelSecretary.TabIndex = 10
        Me.LabelSecretary.Text = "(None Selected)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(27, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Secretary:"
        '
        'LabelVicePresident
        '
        Me.LabelVicePresident.AutoEllipsis = True
        Me.LabelVicePresident.AutoSize = True
        Me.LabelVicePresident.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelVicePresident.ForeColor = System.Drawing.Color.White
        Me.LabelVicePresident.Location = New System.Drawing.Point(142, 142)
        Me.LabelVicePresident.Name = "LabelVicePresident"
        Me.LabelVicePresident.Size = New System.Drawing.Size(121, 19)
        Me.LabelVicePresident.TabIndex = 12
        Me.LabelVicePresident.Text = "(None Selected)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(27, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Vice President:"
        '
        'LabelPresident
        '
        Me.LabelPresident.AutoEllipsis = True
        Me.LabelPresident.AutoSize = True
        Me.LabelPresident.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelPresident.ForeColor = System.Drawing.Color.White
        Me.LabelPresident.Location = New System.Drawing.Point(108, 104)
        Me.LabelPresident.Name = "LabelPresident"
        Me.LabelPresident.Size = New System.Drawing.Size(121, 19)
        Me.LabelPresident.TabIndex = 14
        Me.LabelPresident.Text = "(None Selected)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(27, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "President:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Final Winner"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Guna2Separator2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(437, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(508, 436)
        Me.Panel2.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(18, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 319)
        Me.Panel1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(445, 158)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Tie Breaker"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(18, 76)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(478, 10)
        Me.Guna2Separator2.TabIndex = 20
        '
        'FinalizeResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FinalizeResult"
        Me.Size = New System.Drawing.Size(985, 560)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ButtonSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents LabelPRO As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LabelAuditor As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1Treasurer As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LabelSecretary As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelVicePresident As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelPresident As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator

End Class
