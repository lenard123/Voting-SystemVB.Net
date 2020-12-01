<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoterLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoterLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.PanelStudentID = New System.Windows.Forms.Panel()
        Me.PanelStudentIdStatus = New System.Windows.Forms.Panel()
        Me.TextStudentId = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelPasswordStatus = New System.Windows.Forms.Panel()
        Me.ButtonVisibility = New System.Windows.Forms.PictureBox()
        Me.TextPin = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ButtonAdmin = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelStudentID.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ButtonVisibility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 531)
        Me.Panel1.TabIndex = 2
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(399, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(323, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Login to your Voters Account"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_close.ForeColor = System.Drawing.Color.Gray
        Me.btn_close.Location = New System.Drawing.Point(821, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(20, 23)
        Me.btn_close.TabIndex = 5
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "X"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'PanelStudentID
        '
        Me.PanelStudentID.BackColor = System.Drawing.Color.White
        Me.PanelStudentID.Controls.Add(Me.PanelStudentIdStatus)
        Me.PanelStudentID.Controls.Add(Me.TextStudentId)
        Me.PanelStudentID.Controls.Add(Me.PictureBox2)
        Me.PanelStudentID.Location = New System.Drawing.Point(381, 229)
        Me.PanelStudentID.Name = "PanelStudentID"
        Me.PanelStudentID.Size = New System.Drawing.Size(441, 45)
        Me.PanelStudentID.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.PanelStudentID, "Enter your StudentID")
        '
        'PanelStudentIdStatus
        '
        Me.PanelStudentIdStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelStudentIdStatus.Location = New System.Drawing.Point(0, 0)
        Me.PanelStudentIdStatus.Name = "PanelStudentIdStatus"
        Me.PanelStudentIdStatus.Size = New System.Drawing.Size(5, 45)
        Me.PanelStudentIdStatus.TabIndex = 2
        '
        'TextStudentId
        '
        Me.TextStudentId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextStudentId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextStudentId.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStudentId.Location = New System.Drawing.Point(46, 13)
        Me.TextStudentId.Name = "TextStudentId"
        Me.TextStudentId.Size = New System.Drawing.Size(376, 20)
        Me.TextStudentId.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TextStudentId, "Enter your StudentID")
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PanelPasswordStatus)
        Me.Panel3.Controls.Add(Me.ButtonVisibility)
        Me.Panel3.Controls.Add(Me.TextPin)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(381, 280)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(441, 45)
        Me.Panel3.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Panel3, "Enter your Password")
        '
        'PanelPasswordStatus
        '
        Me.PanelPasswordStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelPasswordStatus.Location = New System.Drawing.Point(0, 0)
        Me.PanelPasswordStatus.Name = "PanelPasswordStatus"
        Me.PanelPasswordStatus.Size = New System.Drawing.Size(5, 45)
        Me.PanelPasswordStatus.TabIndex = 4
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
        'TextPin
        '
        Me.TextPin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextPin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPin.Location = New System.Drawing.Point(46, 13)
        Me.TextPin.Name = "TextPin"
        Me.TextPin.Size = New System.Drawing.Size(347, 20)
        Me.TextPin.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TextPin, "Enter your Password")
        Me.TextPin.UseSystemPasswordChar = True
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
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.Gray
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
        'ButtonAdmin
        '
        Me.ButtonAdmin.FlatAppearance.BorderSize = 0
        Me.ButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdmin.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.ButtonAdmin.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonAdmin.Location = New System.Drawing.Point(561, 351)
        Me.ButtonAdmin.Name = "ButtonAdmin"
        Me.ButtonAdmin.Size = New System.Drawing.Size(120, 23)
        Me.ButtonAdmin.TabIndex = 4
        Me.ButtonAdmin.Text = "ADMIN LOGIN ?"
        Me.ButtonAdmin.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        '
        'VoterLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonAdmin)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelStudentID)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "VoterLogin"
        Me.Size = New System.Drawing.Size(841, 531)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelStudentID.ResumeLayout(False)
        Me.PanelStudentID.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ButtonVisibility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents PanelStudentID As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextStudentId As System.Windows.Forms.TextBox
    Friend WithEvents TextPin As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents ButtonAdmin As System.Windows.Forms.Button
    Friend WithEvents ButtonVisibility As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PanelStudentIdStatus As System.Windows.Forms.Panel
    Friend WithEvents PanelPasswordStatus As System.Windows.Forms.Panel

End Class
