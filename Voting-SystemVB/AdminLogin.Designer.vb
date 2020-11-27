<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelPasswordStatus = New System.Windows.Forms.Panel()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelUsernameStatus = New System.Windows.Forms.Panel()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.ButtonVoter = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonVisibility = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonVisibility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(137, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 531)
        Me.Panel1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(145, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Election System"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(41, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Supreme Student Council"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonClose.ForeColor = System.Drawing.Color.Gray
        Me.ButtonClose.Location = New System.Drawing.Point(821, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(20, 23)
        Me.ButtonClose.TabIndex = 11
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(399, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(357, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Login using your Admin Account"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PanelPasswordStatus)
        Me.Panel3.Controls.Add(Me.ButtonVisibility)
        Me.Panel3.Controls.Add(Me.TextPassword)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(381, 280)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(441, 45)
        Me.Panel3.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Panel3, "Enter your Password here")
        '
        'PanelPasswordStatus
        '
        Me.PanelPasswordStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelPasswordStatus.Location = New System.Drawing.Point(0, 0)
        Me.PanelPasswordStatus.Name = "PanelPasswordStatus"
        Me.PanelPasswordStatus.Size = New System.Drawing.Size(5, 45)
        Me.PanelPasswordStatus.TabIndex = 4
        '
        'TextPassword
        '
        Me.TextPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPassword.Location = New System.Drawing.Point(46, 13)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(347, 20)
        Me.TextPassword.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TextPassword, "Enter your Password here")
        Me.TextPassword.UseSystemPasswordChar = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PanelUsernameStatus)
        Me.Panel2.Controls.Add(Me.TextUsername)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(381, 229)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 45)
        Me.Panel2.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Panel2, "Enter your Username here")
        '
        'PanelUsernameStatus
        '
        Me.PanelUsernameStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelUsernameStatus.Location = New System.Drawing.Point(0, 0)
        Me.PanelUsernameStatus.Name = "PanelUsernameStatus"
        Me.PanelUsernameStatus.Size = New System.Drawing.Size(5, 45)
        Me.PanelUsernameStatus.TabIndex = 1
        '
        'TextUsername
        '
        Me.TextUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsername.Location = New System.Drawing.Point(46, 13)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(376, 20)
        Me.TextUsername.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TextUsername, "Enter your Username here")
        '
        'ButtonVoter
        '
        Me.ButtonVoter.FlatAppearance.BorderSize = 0
        Me.ButtonVoter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVoter.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.ButtonVoter.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonVoter.Location = New System.Drawing.Point(561, 351)
        Me.ButtonVoter.Name = "ButtonVoter"
        Me.ButtonVoter.Size = New System.Drawing.Size(137, 23)
        Me.ButtonVoter.TabIndex = 4
        Me.ButtonVoter.Text = "Back to Voters Login?"
        Me.ButtonVoter.UseVisualStyleBackColor = False
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.ButtonLogin.ForeColor = System.Drawing.Color.White
        Me.ButtonLogin.Location = New System.Drawing.Point(381, 340)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(164, 43)
        Me.ButtonLogin.TabIndex = 3
        Me.ButtonLogin.Text = "LOGIN"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(106, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ButtonVisibility
        '
        Me.ButtonVisibility.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonVisibility.Image = Global.Voting_SystemVB.My.Resources.Resources.show
        Me.ButtonVisibility.Location = New System.Drawing.Point(399, 11)
        Me.ButtonVisibility.Name = "ButtonVisibility"
        Me.ButtonVisibility.Size = New System.Drawing.Size(25, 25)
        Me.ButtonVisibility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ButtonVisibility.TabIndex = 3
        Me.ButtonVisibility.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Voting_SystemVB.My.Resources.Resources.padlock
        Me.PictureBox3.Location = New System.Drawing.Point(15, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Voting_SystemVB.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(15, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ButtonVoter)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Name = "AdminLogin"
        Me.Size = New System.Drawing.Size(841, 531)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonVisibility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ButtonVisibility As System.Windows.Forms.PictureBox
    Friend WithEvents TextPassword As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextUsername As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonVoter As System.Windows.Forms.Button
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PanelPasswordStatus As System.Windows.Forms.Panel
    Friend WithEvents PanelUsernameStatus As System.Windows.Forms.Panel

End Class
