<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VotersPanel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Indicator = New System.Windows.Forms.Panel()
        Me.SideBarButton = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonCandidate = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonParty = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVoteNow = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVoteInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.ChipStatus = New Guna.UI2.WinForms.Guna2Chip()
        Me.LabelCountdown = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ChildPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SideBarButton.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Indicator)
        Me.Panel1.Controls.Add(Me.SideBarButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 691)
        Me.Panel1.TabIndex = 1
        '
        'Indicator
        '
        Me.Indicator.BackColor = System.Drawing.Color.White
        Me.Indicator.Location = New System.Drawing.Point(0, 144)
        Me.Indicator.Name = "Indicator"
        Me.Indicator.Size = New System.Drawing.Size(5, 40)
        Me.Indicator.TabIndex = 4
        '
        'SideBarButton
        '
        Me.SideBarButton.Controls.Add(Me.ButtonCandidate)
        Me.SideBarButton.Controls.Add(Me.ButtonParty)
        Me.SideBarButton.Controls.Add(Me.ButtonVoteNow)
        Me.SideBarButton.Controls.Add(Me.ButtonVoteInfo)
        Me.SideBarButton.Controls.Add(Me.Guna2Button4)
        Me.SideBarButton.Controls.Add(Me.ButtonLogout)
        Me.SideBarButton.Location = New System.Drawing.Point(5, 144)
        Me.SideBarButton.Name = "SideBarButton"
        Me.SideBarButton.Size = New System.Drawing.Size(220, 384)
        Me.SideBarButton.TabIndex = 3
        '
        'ButtonCandidate
        '
        Me.ButtonCandidate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCandidate.CheckedState.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.CustomImages.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonCandidate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonCandidate.ForeColor = System.Drawing.Color.White
        Me.ButtonCandidate.HoverState.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.Location = New System.Drawing.Point(0, 0)
        Me.ButtonCandidate.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonCandidate.Name = "ButtonCandidate"
        Me.ButtonCandidate.ShadowDecoration.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.Size = New System.Drawing.Size(220, 40)
        Me.ButtonCandidate.TabIndex = 0
        Me.ButtonCandidate.Tag = "1"
        Me.ButtonCandidate.Text = "CANDIDATE INFO"
        '
        'ButtonParty
        '
        Me.ButtonParty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonParty.CheckedState.Parent = Me.ButtonParty
        Me.ButtonParty.CustomImages.Parent = Me.ButtonParty
        Me.ButtonParty.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonParty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonParty.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonParty.HoverState.Parent = Me.ButtonParty
        Me.ButtonParty.Location = New System.Drawing.Point(0, 40)
        Me.ButtonParty.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonParty.Name = "ButtonParty"
        Me.ButtonParty.ShadowDecoration.Parent = Me.ButtonParty
        Me.ButtonParty.Size = New System.Drawing.Size(220, 40)
        Me.ButtonParty.TabIndex = 1
        Me.ButtonParty.Tag = "2"
        Me.ButtonParty.Text = "PARTY"
        '
        'ButtonVoteNow
        '
        Me.ButtonVoteNow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonVoteNow.CheckedState.Parent = Me.ButtonVoteNow
        Me.ButtonVoteNow.CustomImages.Parent = Me.ButtonVoteNow
        Me.ButtonVoteNow.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonVoteNow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVoteNow.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonVoteNow.HoverState.Parent = Me.ButtonVoteNow
        Me.ButtonVoteNow.Location = New System.Drawing.Point(0, 80)
        Me.ButtonVoteNow.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVoteNow.Name = "ButtonVoteNow"
        Me.ButtonVoteNow.ShadowDecoration.Parent = Me.ButtonVoteNow
        Me.ButtonVoteNow.Size = New System.Drawing.Size(220, 40)
        Me.ButtonVoteNow.TabIndex = 2
        Me.ButtonVoteNow.Tag = "3"
        Me.ButtonVoteNow.Text = "VOTE NOW"
        '
        'ButtonVoteInfo
        '
        Me.ButtonVoteInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonVoteInfo.CheckedState.Parent = Me.ButtonVoteInfo
        Me.ButtonVoteInfo.CustomImages.Parent = Me.ButtonVoteInfo
        Me.ButtonVoteInfo.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonVoteInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVoteInfo.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonVoteInfo.HoverState.Parent = Me.ButtonVoteInfo
        Me.ButtonVoteInfo.Location = New System.Drawing.Point(0, 120)
        Me.ButtonVoteInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVoteInfo.Name = "ButtonVoteInfo"
        Me.ButtonVoteInfo.ShadowDecoration.Parent = Me.ButtonVoteInfo
        Me.ButtonVoteInfo.Size = New System.Drawing.Size(220, 40)
        Me.ButtonVoteInfo.TabIndex = 5
        Me.ButtonVoteInfo.Tag = "4"
        Me.ButtonVoteInfo.Text = "VOTE INFO"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(0, 160)
        Me.Guna2Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(220, 40)
        Me.Guna2Button4.TabIndex = 3
        Me.Guna2Button4.Tag = "5"
        Me.Guna2Button4.Text = "CURRENT VOTE COUNT"
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLogout.CheckedState.Parent = Me.ButtonLogout
        Me.ButtonLogout.CustomImages.Parent = Me.ButtonLogout
        Me.ButtonLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonLogout.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonLogout.HoverState.Parent = Me.ButtonLogout
        Me.ButtonLogout.Location = New System.Drawing.Point(0, 200)
        Me.ButtonLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.ShadowDecoration.Parent = Me.ButtonLogout
        Me.ButtonLogout.Size = New System.Drawing.Size(220, 40)
        Me.ButtonLogout.TabIndex = 4
        Me.ButtonLogout.Tag = "6"
        Me.ButtonLogout.Text = "LOGOUT"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel2.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel2.Controls.Add(Me.Guna2GradientPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(225, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(989, 41)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(21, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VOTERS PANEL"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(918, 8)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(27, 23)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(951, 8)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(27, 23)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(15, 41)
        Me.Guna2GradientPanel2.TabIndex = 0
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(225, 41)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(15, 650)
        Me.Guna2GradientPanel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Guna2Separator1)
        Me.Panel3.Controls.Add(Me.ChipStatus)
        Me.Panel3.Controls.Add(Me.LabelCountdown)
        Me.Panel3.Controls.Add(Me.LabelName)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(240, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(974, 93)
        Me.Panel3.TabIndex = 5
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 83)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(974, 10)
        Me.Guna2Separator1.TabIndex = 4
        '
        'ChipStatus
        '
        Me.ChipStatus.BorderRadius = 5
        Me.ChipStatus.FillColor = System.Drawing.Color.Red
        Me.ChipStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChipStatus.ForeColor = System.Drawing.Color.White
        Me.ChipStatus.Location = New System.Drawing.Point(90, 59)
        Me.ChipStatus.Name = "ChipStatus"
        Me.ChipStatus.ShadowDecoration.Parent = Me.ChipStatus
        Me.ChipStatus.Size = New System.Drawing.Size(75, 18)
        Me.ChipStatus.TabIndex = 3
        Me.ChipStatus.Text = "Not Yet"
        Me.ChipStatus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'LabelCountdown
        '
        Me.LabelCountdown.AutoSize = True
        Me.LabelCountdown.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelCountdown.ForeColor = System.Drawing.Color.White
        Me.LabelCountdown.Location = New System.Drawing.Point(157, 35)
        Me.LabelCountdown.Name = "LabelCountdown"
        Me.LabelCountdown.Size = New System.Drawing.Size(75, 21)
        Me.LabelCountdown.TabIndex = 2
        Me.LabelCountdown.Text = "Loading..."
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelName.ForeColor = System.Drawing.Color.White
        Me.LabelName.Location = New System.Drawing.Point(113, 14)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(162, 21)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Lenard Mangay-ayam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(6, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Logged in as:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(6, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 21)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Has Voted: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(6, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Election Will End in:"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Panel2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ChildPanel
        '
        Me.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChildPanel.Location = New System.Drawing.Point(240, 134)
        Me.ChildPanel.Name = "ChildPanel"
        Me.ChildPanel.Size = New System.Drawing.Size(974, 557)
        Me.ChildPanel.TabIndex = 6
        '
        'VotersPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.ChildPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(1214, 691)
        Me.Name = "VotersPanel"
        Me.Size = New System.Drawing.Size(1214, 691)
        Me.Panel1.ResumeLayout(False)
        Me.SideBarButton.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Indicator As System.Windows.Forms.Panel
    Friend WithEvents SideBarButton As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonCandidate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonParty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVoteNow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVoteInfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents ChipStatus As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents LabelCountdown As System.Windows.Forms.Label
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ChildPanel As System.Windows.Forms.Panel

End Class
