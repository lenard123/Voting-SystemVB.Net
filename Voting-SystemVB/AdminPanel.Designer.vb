<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPanel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelButtonGroup = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonHome = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVoter = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonCandidate = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonParty = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.indicator = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainContent = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelFullname = New System.Windows.Forms.Label()
        Me.ChipElectionStatus = New Guna.UI2.WinForms.Guna2Chip()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelCountdown = New System.Windows.Forms.Label()
        Me.ElectionStartedLabel1 = New System.Windows.Forms.Label()
        Me.CountDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.BackgroundWorkerRefresh = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.PanelButtonGroup.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PanelButtonGroup)
        Me.Panel1.Controls.Add(Me.indicator)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 637)
        Me.Panel1.TabIndex = 0
        '
        'PanelButtonGroup
        '
        Me.PanelButtonGroup.Controls.Add(Me.ButtonHome)
        Me.PanelButtonGroup.Controls.Add(Me.ButtonVoter)
        Me.PanelButtonGroup.Controls.Add(Me.ButtonCandidate)
        Me.PanelButtonGroup.Controls.Add(Me.ButtonParty)
        Me.PanelButtonGroup.Controls.Add(Me.ButtonAdmin)
        Me.PanelButtonGroup.Controls.Add(Me.ButtonLogout)
        Me.PanelButtonGroup.Location = New System.Drawing.Point(5, 80)
        Me.PanelButtonGroup.Name = "PanelButtonGroup"
        Me.PanelButtonGroup.Size = New System.Drawing.Size(215, 330)
        Me.PanelButtonGroup.TabIndex = 5
        '
        'ButtonHome
        '
        Me.ButtonHome.Animated = True
        Me.ButtonHome.CheckedState.Parent = Me.ButtonHome
        Me.ButtonHome.CustomImages.Parent = Me.ButtonHome
        Me.ButtonHome.FillColor = System.Drawing.Color.Transparent
        Me.ButtonHome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonHome.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonHome.HoverState.Parent = Me.ButtonHome
        Me.ButtonHome.Image = Global.Voting_SystemVB.My.Resources.Resources.home
        Me.ButtonHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonHome.Location = New System.Drawing.Point(0, 0)
        Me.ButtonHome.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.ShadowDecoration.Parent = Me.ButtonHome
        Me.ButtonHome.Size = New System.Drawing.Size(215, 45)
        Me.ButtonHome.TabIndex = 0
        Me.ButtonHome.Text = "Home"
        '
        'ButtonVoter
        '
        Me.ButtonVoter.Animated = True
        Me.ButtonVoter.CheckedState.Parent = Me.ButtonVoter
        Me.ButtonVoter.CustomImages.Parent = Me.ButtonVoter
        Me.ButtonVoter.FillColor = System.Drawing.Color.Transparent
        Me.ButtonVoter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVoter.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonVoter.HoverState.Parent = Me.ButtonVoter
        Me.ButtonVoter.Image = Global.Voting_SystemVB.My.Resources.Resources.voter
        Me.ButtonVoter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonVoter.Location = New System.Drawing.Point(0, 45)
        Me.ButtonVoter.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVoter.Name = "ButtonVoter"
        Me.ButtonVoter.ShadowDecoration.Parent = Me.ButtonVoter
        Me.ButtonVoter.Size = New System.Drawing.Size(215, 45)
        Me.ButtonVoter.TabIndex = 1
        Me.ButtonVoter.Text = "Voters"
        '
        'ButtonCandidate
        '
        Me.ButtonCandidate.Animated = True
        Me.ButtonCandidate.CheckedState.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.CustomImages.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.FillColor = System.Drawing.Color.Transparent
        Me.ButtonCandidate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonCandidate.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonCandidate.HoverState.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.Image = Global.Voting_SystemVB.My.Resources.Resources.candidate
        Me.ButtonCandidate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonCandidate.Location = New System.Drawing.Point(0, 90)
        Me.ButtonCandidate.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonCandidate.Name = "ButtonCandidate"
        Me.ButtonCandidate.ShadowDecoration.Parent = Me.ButtonCandidate
        Me.ButtonCandidate.Size = New System.Drawing.Size(215, 45)
        Me.ButtonCandidate.TabIndex = 2
        Me.ButtonCandidate.Text = "Candidates"
        '
        'ButtonParty
        '
        Me.ButtonParty.Animated = True
        Me.ButtonParty.CheckedState.Parent = Me.ButtonParty
        Me.ButtonParty.CustomImages.Parent = Me.ButtonParty
        Me.ButtonParty.FillColor = System.Drawing.Color.Transparent
        Me.ButtonParty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonParty.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonParty.HoverState.Parent = Me.ButtonParty
        Me.ButtonParty.Image = Global.Voting_SystemVB.My.Resources.Resources.party
        Me.ButtonParty.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonParty.Location = New System.Drawing.Point(0, 135)
        Me.ButtonParty.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonParty.Name = "ButtonParty"
        Me.ButtonParty.ShadowDecoration.Parent = Me.ButtonParty
        Me.ButtonParty.Size = New System.Drawing.Size(215, 45)
        Me.ButtonParty.TabIndex = 3
        Me.ButtonParty.Text = "Party"
        '
        'ButtonAdmin
        '
        Me.ButtonAdmin.Animated = True
        Me.ButtonAdmin.CheckedState.Parent = Me.ButtonAdmin
        Me.ButtonAdmin.CustomImages.Parent = Me.ButtonAdmin
        Me.ButtonAdmin.FillColor = System.Drawing.Color.Transparent
        Me.ButtonAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonAdmin.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonAdmin.HoverState.Parent = Me.ButtonAdmin
        Me.ButtonAdmin.Image = Global.Voting_SystemVB.My.Resources.Resources.settings
        Me.ButtonAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonAdmin.Location = New System.Drawing.Point(0, 180)
        Me.ButtonAdmin.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonAdmin.Name = "ButtonAdmin"
        Me.ButtonAdmin.ShadowDecoration.Parent = Me.ButtonAdmin
        Me.ButtonAdmin.Size = New System.Drawing.Size(215, 45)
        Me.ButtonAdmin.TabIndex = 4
        Me.ButtonAdmin.Text = "Update Account"
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Animated = True
        Me.ButtonLogout.CheckedState.Parent = Me.ButtonLogout
        Me.ButtonLogout.CustomImages.Parent = Me.ButtonLogout
        Me.ButtonLogout.FillColor = System.Drawing.Color.Transparent
        Me.ButtonLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonLogout.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonLogout.HoverState.Parent = Me.ButtonLogout
        Me.ButtonLogout.Image = Global.Voting_SystemVB.My.Resources.Resources.logout
        Me.ButtonLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonLogout.Location = New System.Drawing.Point(0, 225)
        Me.ButtonLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.ShadowDecoration.Parent = Me.ButtonLogout
        Me.ButtonLogout.Size = New System.Drawing.Size(215, 45)
        Me.ButtonLogout.TabIndex = 5
        Me.ButtonLogout.Text = "Logout"
        '
        'indicator
        '
        Me.indicator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.indicator.Location = New System.Drawing.Point(0, 80)
        Me.indicator.Name = "indicator"
        Me.indicator.Size = New System.Drawing.Size(5, 47)
        Me.indicator.TabIndex = 4
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.Guna2ControlBox2)
        Me.PanelHeader.Controls.Add(Me.Guna2ControlBox1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(220, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(912, 20)
        Me.PanelHeader.TabIndex = 1
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(865, 1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(21, 20)
        Me.Guna2ControlBox2.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(888, 1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(21, 20)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(58, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(117, 135)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(30, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Panel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(181, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(492, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supreme Student Council Election-System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainContent
        '
        Me.MainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainContent.Location = New System.Drawing.Point(220, 156)
        Me.MainContent.Name = "MainContent"
        Me.MainContent.Size = New System.Drawing.Size(912, 481)
        Me.MainContent.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(182, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Election Status: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(182, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Logged in as:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFullname
        '
        Me.LabelFullname.AutoSize = True
        Me.LabelFullname.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.LabelFullname.ForeColor = System.Drawing.Color.Black
        Me.LabelFullname.Location = New System.Drawing.Point(316, 41)
        Me.LabelFullname.Name = "LabelFullname"
        Me.LabelFullname.Size = New System.Drawing.Size(133, 22)
        Me.LabelFullname.TabIndex = 1
        Me.LabelFullname.Text = "User Fullname"
        Me.LabelFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChipElectionStatus
        '
        Me.ChipElectionStatus.FillColor = System.Drawing.Color.Green
        Me.ChipElectionStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChipElectionStatus.ForeColor = System.Drawing.Color.White
        Me.ChipElectionStatus.Location = New System.Drawing.Point(328, 73)
        Me.ChipElectionStatus.Name = "ChipElectionStatus"
        Me.ChipElectionStatus.ShadowDecoration.Parent = Me.ChipElectionStatus
        Me.ChipElectionStatus.Size = New System.Drawing.Size(83, 17)
        Me.ChipElectionStatus.TabIndex = 4
        Me.ChipElectionStatus.Text = "Not Started"
        Me.ChipElectionStatus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ChipElectionStatus)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.LabelCountdown)
        Me.Panel2.Controls.Add(Me.LabelFullname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ElectionStartedLabel1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(220, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(912, 136)
        Me.Panel2.TabIndex = 5
        '
        'LabelCountdown
        '
        Me.LabelCountdown.AutoSize = True
        Me.LabelCountdown.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelCountdown.ForeColor = System.Drawing.Color.Black
        Me.LabelCountdown.Location = New System.Drawing.Point(361, 100)
        Me.LabelCountdown.Name = "LabelCountdown"
        Me.LabelCountdown.Size = New System.Drawing.Size(0, 23)
        Me.LabelCountdown.TabIndex = 1
        Me.LabelCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ElectionStartedLabel1
        '
        Me.ElectionStartedLabel1.AutoSize = True
        Me.ElectionStartedLabel1.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.ElectionStartedLabel1.ForeColor = System.Drawing.Color.Black
        Me.ElectionStartedLabel1.Location = New System.Drawing.Point(182, 100)
        Me.ElectionStartedLabel1.Name = "ElectionStartedLabel1"
        Me.ElectionStartedLabel1.Size = New System.Drawing.Size(173, 22)
        Me.ElectionStartedLabel1.TabIndex = 1
        Me.ElectionStartedLabel1.Text = "Election will end in"
        Me.ElectionStartedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElectionStartedLabel1.Visible = False
        '
        'CountDownTimer
        '
        Me.CountDownTimer.Interval = 1000
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.PanelHeader
        '
        'BackgroundWorkerRefresh
        '
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainContent)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminPanel"
        Me.Size = New System.Drawing.Size(1132, 637)
        Me.Panel1.ResumeLayout(False)
        Me.PanelButtonGroup.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents indicator As System.Windows.Forms.Panel
    Friend WithEvents MainContent As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelFullname As System.Windows.Forms.Label
    Friend WithEvents ChipElectionStatus As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CountDownTimer As System.Windows.Forms.Timer
    Friend WithEvents LabelCountdown As System.Windows.Forms.Label
    Friend WithEvents ElectionStartedLabel1 As System.Windows.Forms.Label
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents BackgroundWorkerRefresh As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelButtonGroup As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVoter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonCandidate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonParty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonLogout As Guna.UI2.WinForms.Guna2Button

End Class
