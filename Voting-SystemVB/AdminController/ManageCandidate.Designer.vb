<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageCandidate
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
        Me.ButtonPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSecretary = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonTreasurer = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonAuditor = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonPRO = New Guna.UI2.WinForms.Guna2Button()
        Me.Card1 = New Voting_SystemVB.Card()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonRegister = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Card1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonPresident
        '
        Me.ButtonPresident.CheckedState.Parent = Me.ButtonPresident
        Me.ButtonPresident.CustomImages.Parent = Me.ButtonPresident
        Me.ButtonPresident.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonPresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonPresident.ForeColor = System.Drawing.Color.White
        Me.ButtonPresident.HoverState.Parent = Me.ButtonPresident
        Me.ButtonPresident.Location = New System.Drawing.Point(63, 21)
        Me.ButtonPresident.Name = "ButtonPresident"
        Me.ButtonPresident.ShadowDecoration.Parent = Me.ButtonPresident
        Me.ButtonPresident.Size = New System.Drawing.Size(102, 28)
        Me.ButtonPresident.TabIndex = 0
        Me.ButtonPresident.Text = "President"
        '
        'ButtonVPresident
        '
        Me.ButtonVPresident.CheckedState.Parent = Me.ButtonVPresident
        Me.ButtonVPresident.CustomImages.Parent = Me.ButtonVPresident
        Me.ButtonVPresident.FillColor = System.Drawing.Color.White
        Me.ButtonVPresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVPresident.ForeColor = System.Drawing.Color.Black
        Me.ButtonVPresident.HoverState.Parent = Me.ButtonVPresident
        Me.ButtonVPresident.Location = New System.Drawing.Point(165, 21)
        Me.ButtonVPresident.Name = "ButtonVPresident"
        Me.ButtonVPresident.ShadowDecoration.Parent = Me.ButtonVPresident
        Me.ButtonVPresident.Size = New System.Drawing.Size(102, 28)
        Me.ButtonVPresident.TabIndex = 0
        Me.ButtonVPresident.Text = "Vice President"
        '
        'ButtonSecretary
        '
        Me.ButtonSecretary.CheckedState.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.CustomImages.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.FillColor = System.Drawing.Color.White
        Me.ButtonSecretary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSecretary.ForeColor = System.Drawing.Color.Black
        Me.ButtonSecretary.HoverState.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.Location = New System.Drawing.Point(267, 21)
        Me.ButtonSecretary.Name = "ButtonSecretary"
        Me.ButtonSecretary.ShadowDecoration.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.Size = New System.Drawing.Size(102, 28)
        Me.ButtonSecretary.TabIndex = 0
        Me.ButtonSecretary.Text = "Secretary"
        '
        'ButtonTreasurer
        '
        Me.ButtonTreasurer.CheckedState.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.CustomImages.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.FillColor = System.Drawing.Color.White
        Me.ButtonTreasurer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonTreasurer.ForeColor = System.Drawing.Color.Black
        Me.ButtonTreasurer.HoverState.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.Location = New System.Drawing.Point(369, 21)
        Me.ButtonTreasurer.Name = "ButtonTreasurer"
        Me.ButtonTreasurer.ShadowDecoration.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.Size = New System.Drawing.Size(102, 28)
        Me.ButtonTreasurer.TabIndex = 0
        Me.ButtonTreasurer.Text = "Treasurer"
        '
        'ButtonAuditor
        '
        Me.ButtonAuditor.CheckedState.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.CustomImages.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.FillColor = System.Drawing.Color.White
        Me.ButtonAuditor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonAuditor.ForeColor = System.Drawing.Color.Black
        Me.ButtonAuditor.HoverState.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.Location = New System.Drawing.Point(471, 21)
        Me.ButtonAuditor.Name = "ButtonAuditor"
        Me.ButtonAuditor.ShadowDecoration.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.Size = New System.Drawing.Size(102, 28)
        Me.ButtonAuditor.TabIndex = 0
        Me.ButtonAuditor.Text = "Auditor"
        '
        'ButtonPRO
        '
        Me.ButtonPRO.CheckedState.Parent = Me.ButtonPRO
        Me.ButtonPRO.CustomImages.Parent = Me.ButtonPRO
        Me.ButtonPRO.FillColor = System.Drawing.Color.White
        Me.ButtonPRO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonPRO.ForeColor = System.Drawing.Color.Black
        Me.ButtonPRO.HoverState.Parent = Me.ButtonPRO
        Me.ButtonPRO.Location = New System.Drawing.Point(573, 21)
        Me.ButtonPRO.Name = "ButtonPRO"
        Me.ButtonPRO.ShadowDecoration.Parent = Me.ButtonPRO
        Me.ButtonPRO.Size = New System.Drawing.Size(102, 28)
        Me.ButtonPRO.TabIndex = 0
        Me.ButtonPRO.Text = "P.R.O."
        '
        'Card1
        '
        Me.Card1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Card1.BackColor = System.Drawing.Color.White
        Me.Card1.BGColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Card1.Controls.Add(Me.Panel1)
        Me.Card1.Location = New System.Drawing.Point(63, 49)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(763, 333)
        Me.Card1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(25, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 324)
        Me.Panel1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonRegister)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.MinimumSize = New System.Drawing.Size(715, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(715, 410)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ButtonRegister
        '
        Me.ButtonRegister.CheckedState.Parent = Me.ButtonRegister
        Me.ButtonRegister.CustomImages.Parent = Me.ButtonRegister
        Me.ButtonRegister.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ButtonRegister.ForeColor = System.Drawing.Color.White
        Me.ButtonRegister.HoverState.Parent = Me.ButtonRegister
        Me.ButtonRegister.Location = New System.Drawing.Point(15, 15)
        Me.ButtonRegister.Margin = New System.Windows.Forms.Padding(15, 15, 10, 10)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.ShadowDecoration.Parent = Me.ButtonRegister
        Me.ButtonRegister.Size = New System.Drawing.Size(280, 370)
        Me.ButtonRegister.TabIndex = 0
        Me.ButtonRegister.Text = "Register Candidate"
        '
        'ManageCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Card1)
        Me.Controls.Add(Me.ButtonPRO)
        Me.Controls.Add(Me.ButtonAuditor)
        Me.Controls.Add(Me.ButtonTreasurer)
        Me.Controls.Add(Me.ButtonSecretary)
        Me.Controls.Add(Me.ButtonVPresident)
        Me.Controls.Add(Me.ButtonPresident)
        Me.Name = "ManageCandidate"
        Me.Size = New System.Drawing.Size(879, 397)
        Me.Card1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSecretary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonTreasurer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonAuditor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonPRO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Card1 As Voting_SystemVB.Card
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonRegister As Guna.UI2.WinForms.Guna2TileButton

End Class
