<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CandidateInfo
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVicePresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSecretary = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonTreasurer = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonAuditor = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonPRO = New Guna.UI2.WinForms.Guna2Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Candidate Informations"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(36, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Display informations about the candidates"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.AutoScroll = True
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.Controls.Add(Me.Panel1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(40, 144)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(729, 305)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel1.Location = New System.Drawing.Point(8, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 283)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(707, 283)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonPresident)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonVicePresident)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonSecretary)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonTreasurer)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonAuditor)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonPRO)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(40, 101)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(729, 37)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'ButtonPresident
        '
        Me.ButtonPresident.Animated = True
        Me.ButtonPresident.BorderRadius = 10
        Me.ButtonPresident.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonPresident.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonPresident.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonPresident.CheckedState.Parent = Me.ButtonPresident
        Me.ButtonPresident.CustomImages.Parent = Me.ButtonPresident
        Me.ButtonPresident.FillColor = System.Drawing.Color.Empty
        Me.ButtonPresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonPresident.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonPresident.HoverState.Parent = Me.ButtonPresident
        Me.ButtonPresident.Location = New System.Drawing.Point(3, 3)
        Me.ButtonPresident.Name = "ButtonPresident"
        Me.ButtonPresident.ShadowDecoration.Parent = Me.ButtonPresident
        Me.ButtonPresident.Size = New System.Drawing.Size(110, 34)
        Me.ButtonPresident.TabIndex = 0
        Me.ButtonPresident.Tag = "1"
        Me.ButtonPresident.Text = "President"
        '
        'ButtonVicePresident
        '
        Me.ButtonVicePresident.Animated = True
        Me.ButtonVicePresident.BorderRadius = 10
        Me.ButtonVicePresident.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonVicePresident.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonVicePresident.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonVicePresident.CheckedState.Parent = Me.ButtonVicePresident
        Me.ButtonVicePresident.CustomImages.Parent = Me.ButtonVicePresident
        Me.ButtonVicePresident.FillColor = System.Drawing.Color.Empty
        Me.ButtonVicePresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVicePresident.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonVicePresident.HoverState.Parent = Me.ButtonVicePresident
        Me.ButtonVicePresident.Location = New System.Drawing.Point(119, 3)
        Me.ButtonVicePresident.Name = "ButtonVicePresident"
        Me.ButtonVicePresident.ShadowDecoration.Parent = Me.ButtonVicePresident
        Me.ButtonVicePresident.Size = New System.Drawing.Size(110, 34)
        Me.ButtonVicePresident.TabIndex = 1
        Me.ButtonVicePresident.Tag = "2"
        Me.ButtonVicePresident.Text = "Vice President"
        '
        'ButtonSecretary
        '
        Me.ButtonSecretary.Animated = True
        Me.ButtonSecretary.BorderRadius = 10
        Me.ButtonSecretary.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonSecretary.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonSecretary.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonSecretary.CheckedState.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.CustomImages.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.FillColor = System.Drawing.Color.Empty
        Me.ButtonSecretary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSecretary.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonSecretary.HoverState.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.Location = New System.Drawing.Point(235, 3)
        Me.ButtonSecretary.Name = "ButtonSecretary"
        Me.ButtonSecretary.ShadowDecoration.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.Size = New System.Drawing.Size(110, 34)
        Me.ButtonSecretary.TabIndex = 2
        Me.ButtonSecretary.Tag = "3"
        Me.ButtonSecretary.Text = "Secretary"
        '
        'ButtonTreasurer
        '
        Me.ButtonTreasurer.Animated = True
        Me.ButtonTreasurer.BorderRadius = 10
        Me.ButtonTreasurer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonTreasurer.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonTreasurer.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonTreasurer.CheckedState.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.CustomImages.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.FillColor = System.Drawing.Color.Empty
        Me.ButtonTreasurer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonTreasurer.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonTreasurer.HoverState.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.Location = New System.Drawing.Point(351, 3)
        Me.ButtonTreasurer.Name = "ButtonTreasurer"
        Me.ButtonTreasurer.ShadowDecoration.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.Size = New System.Drawing.Size(110, 34)
        Me.ButtonTreasurer.TabIndex = 3
        Me.ButtonTreasurer.Tag = "4"
        Me.ButtonTreasurer.Text = "Treasurer"
        '
        'ButtonAuditor
        '
        Me.ButtonAuditor.Animated = True
        Me.ButtonAuditor.BorderRadius = 10
        Me.ButtonAuditor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonAuditor.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonAuditor.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonAuditor.CheckedState.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.CustomImages.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.FillColor = System.Drawing.Color.Empty
        Me.ButtonAuditor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonAuditor.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonAuditor.HoverState.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.Location = New System.Drawing.Point(467, 3)
        Me.ButtonAuditor.Name = "ButtonAuditor"
        Me.ButtonAuditor.ShadowDecoration.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.Size = New System.Drawing.Size(110, 34)
        Me.ButtonAuditor.TabIndex = 4
        Me.ButtonAuditor.Tag = "5"
        Me.ButtonAuditor.Text = "Auditor"
        '
        'ButtonPRO
        '
        Me.ButtonPRO.Animated = True
        Me.ButtonPRO.BorderRadius = 10
        Me.ButtonPRO.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonPRO.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonPRO.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonPRO.CheckedState.Parent = Me.ButtonPRO
        Me.ButtonPRO.CustomImages.Parent = Me.ButtonPRO
        Me.ButtonPRO.FillColor = System.Drawing.Color.Empty
        Me.ButtonPRO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonPRO.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonPRO.HoverState.Parent = Me.ButtonPRO
        Me.ButtonPRO.Location = New System.Drawing.Point(583, 3)
        Me.ButtonPRO.Name = "ButtonPRO"
        Me.ButtonPRO.ShadowDecoration.Parent = Me.ButtonPRO
        Me.ButtonPRO.Size = New System.Drawing.Size(110, 34)
        Me.ButtonPRO.TabIndex = 5
        Me.ButtonPRO.Tag = "6"
        Me.ButtonPRO.Text = "P.R.O"
        '
        'BackgroundWorker1
        '
        '
        'CandidateInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CandidateInfo"
        Me.Size = New System.Drawing.Size(812, 470)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVicePresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSecretary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonTreasurer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonAuditor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonPRO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
