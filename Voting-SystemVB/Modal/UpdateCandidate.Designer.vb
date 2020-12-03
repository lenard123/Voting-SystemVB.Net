<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCandidate
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
        Me.ButtonCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonClear = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TextTagline = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CBPosition = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TextCYS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextFullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextVoter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorkerUpdate = New System.ComponentModel.BackgroundWorker()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCancel.CheckedState.Parent = Me.ButtonCancel
        Me.ButtonCancel.CustomImages.Parent = Me.ButtonCancel
        Me.ButtonCancel.FillColor = System.Drawing.Color.Transparent
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonCancel.ForeColor = System.Drawing.Color.Gray
        Me.ButtonCancel.HoverState.Parent = Me.ButtonCancel
        Me.ButtonCancel.Location = New System.Drawing.Point(414, 438)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.ShadowDecoration.Parent = Me.ButtonCancel
        Me.ButtonCancel.Size = New System.Drawing.Size(93, 22)
        Me.ButtonCancel.TabIndex = 20
        Me.ButtonCancel.Text = "Cancel"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Animated = True
        Me.ButtonUpdate.CheckedState.Parent = Me.ButtonUpdate
        Me.ButtonUpdate.CustomImages.Parent = Me.ButtonUpdate
        Me.ButtonUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ButtonUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.HoverState.Parent = Me.ButtonUpdate
        Me.ButtonUpdate.Location = New System.Drawing.Point(513, 430)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.ShadowDecoration.Parent = Me.ButtonUpdate
        Me.ButtonUpdate.Size = New System.Drawing.Size(150, 36)
        Me.ButtonUpdate.TabIndex = 21
        Me.ButtonUpdate.Text = "Update"
        '
        'ButtonClear
        '
        Me.ButtonClear.Animated = True
        Me.ButtonClear.CheckedState.Parent = Me.ButtonClear
        Me.ButtonClear.CustomImages.Parent = Me.ButtonClear
        Me.ButtonClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ButtonClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.HoverState.Parent = Me.ButtonClear
        Me.ButtonClear.Location = New System.Drawing.Point(24, 201)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.ShadowDecoration.Parent = Me.ButtonClear
        Me.ButtonClear.Size = New System.Drawing.Size(137, 28)
        Me.ButtonClear.TabIndex = 18
        Me.ButtonClear.Text = "Clear Picture"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(185, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Voter's ID"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPG(*.JPG)|*.jpg"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.Guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox1.ImageLocation = "images/default/candidate.jpg"
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(24, 58)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(137, 137)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 17
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.Guna2GroupBox1.Controls.Add(Me.TextTagline)
        Me.Guna2GroupBox1.Controls.Add(Me.CBPosition)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.Guna2GroupBox1.Controls.Add(Me.TextCYS)
        Me.Guna2GroupBox1.Controls.Add(Me.TextFullname)
        Me.Guna2GroupBox1.Controls.Add(Me.TextVoter)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonClear)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(689, 499)
        Me.Guna2GroupBox1.TabIndex = 25
        Me.Guna2GroupBox1.Text = "Update Candidate"
        '
        'TextTagline
        '
        Me.TextTagline.Animated = True
        Me.TextTagline.BorderRadius = 5
        Me.TextTagline.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextTagline.DefaultText = ""
        Me.TextTagline.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextTagline.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextTagline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextTagline.DisabledState.Parent = Me.TextTagline
        Me.TextTagline.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextTagline.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextTagline.FocusedState.Parent = Me.TextTagline
        Me.TextTagline.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextTagline.HoverState.Parent = Me.TextTagline
        Me.TextTagline.Location = New System.Drawing.Point(187, 371)
        Me.TextTagline.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextTagline.Name = "TextTagline"
        Me.TextTagline.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextTagline.PlaceholderText = ""
        Me.TextTagline.SelectedText = ""
        Me.TextTagline.ShadowDecoration.Parent = Me.TextTagline
        Me.TextTagline.Size = New System.Drawing.Size(477, 36)
        Me.TextTagline.TabIndex = 24
        '
        'CBPosition
        '
        Me.CBPosition.Animated = True
        Me.CBPosition.BackColor = System.Drawing.Color.Transparent
        Me.CBPosition.BorderRadius = 5
        Me.CBPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPosition.Enabled = False
        Me.CBPosition.FocusedColor = System.Drawing.Color.Empty
        Me.CBPosition.FocusedState.Parent = Me.CBPosition
        Me.CBPosition.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBPosition.FormattingEnabled = True
        Me.CBPosition.HoverState.Parent = Me.CBPosition
        Me.CBPosition.ItemHeight = 30
        Me.CBPosition.ItemsAppearance.Parent = Me.CBPosition
        Me.CBPosition.Location = New System.Drawing.Point(187, 296)
        Me.CBPosition.Name = "CBPosition"
        Me.CBPosition.ShadowDecoration.Parent = Me.CBPosition
        Me.CBPosition.Size = New System.Drawing.Size(476, 36)
        Me.CBPosition.TabIndex = 23
        '
        'TextCYS
        '
        Me.TextCYS.Animated = True
        Me.TextCYS.BorderRadius = 5
        Me.TextCYS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextCYS.DefaultText = ""
        Me.TextCYS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextCYS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextCYS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextCYS.DisabledState.Parent = Me.TextCYS
        Me.TextCYS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextCYS.Enabled = False
        Me.TextCYS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextCYS.FocusedState.Parent = Me.TextCYS
        Me.TextCYS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextCYS.HoverState.Parent = Me.TextCYS
        Me.TextCYS.Location = New System.Drawing.Point(187, 222)
        Me.TextCYS.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextCYS.Name = "TextCYS"
        Me.TextCYS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextCYS.PlaceholderText = ""
        Me.TextCYS.SelectedText = ""
        Me.TextCYS.ShadowDecoration.Parent = Me.TextCYS
        Me.TextCYS.Size = New System.Drawing.Size(476, 37)
        Me.TextCYS.TabIndex = 21
        '
        'TextFullname
        '
        Me.TextFullname.Animated = True
        Me.TextFullname.BorderRadius = 5
        Me.TextFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextFullname.DefaultText = ""
        Me.TextFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextFullname.DisabledState.Parent = Me.TextFullname
        Me.TextFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextFullname.Enabled = False
        Me.TextFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFullname.FocusedState.Parent = Me.TextFullname
        Me.TextFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFullname.HoverState.Parent = Me.TextFullname
        Me.TextFullname.Location = New System.Drawing.Point(187, 149)
        Me.TextFullname.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextFullname.Name = "TextFullname"
        Me.TextFullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextFullname.PlaceholderText = ""
        Me.TextFullname.SelectedText = ""
        Me.TextFullname.ShadowDecoration.Parent = Me.TextFullname
        Me.TextFullname.Size = New System.Drawing.Size(476, 37)
        Me.TextFullname.TabIndex = 20
        '
        'TextVoter
        '
        Me.TextVoter.Animated = True
        Me.TextVoter.BorderRadius = 5
        Me.TextVoter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextVoter.DefaultText = ""
        Me.TextVoter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextVoter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextVoter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextVoter.DisabledState.Parent = Me.TextVoter
        Me.TextVoter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextVoter.Enabled = False
        Me.TextVoter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextVoter.FocusedState.Parent = Me.TextVoter
        Me.TextVoter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextVoter.HoverState.Parent = Me.TextVoter
        Me.TextVoter.Location = New System.Drawing.Point(188, 83)
        Me.TextVoter.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextVoter.Name = "TextVoter"
        Me.TextVoter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextVoter.PlaceholderText = ""
        Me.TextVoter.SelectedText = ""
        Me.TextVoter.ShadowDecoration.Parent = Me.TextVoter
        Me.TextVoter.Size = New System.Drawing.Size(476, 37)
        Me.TextVoter.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(183, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 21)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tagline"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(183, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Position"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(185, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Course/Year/Section"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(184, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fullname"
        '
        'BackgroundWorkerUpdate
        '
        '
        'UpdateCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "UpdateCandidate"
        Me.Size = New System.Drawing.Size(689, 499)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TextFullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextVoter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextTagline As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBPosition As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TextCYS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorkerUpdate As System.ComponentModel.BackgroundWorker

End Class
