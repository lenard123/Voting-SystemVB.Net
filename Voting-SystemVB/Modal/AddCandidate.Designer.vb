﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCandidate
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
        Me.ButtonClear = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSave = New Guna.UI2.WinForms.Guna2Button()
        Me.CBPosition = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorVoter = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BackgroundWorkerSave = New System.ComponentModel.BackgroundWorker()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TextCYS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextFullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextTagline = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextVoter = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ButtonClear.Location = New System.Drawing.Point(24, 220)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.ShadowDecoration.Parent = Me.ButtonClear
        Me.ButtonClear.Size = New System.Drawing.Size(137, 32)
        Me.ButtonClear.TabIndex = 11
        Me.ButtonClear.Text = "Clear Picture"
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(413, 479)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(85, 24)
        Me.ButtonDiscard.TabIndex = 15
        Me.ButtonDiscard.Text = "Discard"
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Animated = True
        Me.ButtonSave.CheckedState.Parent = Me.ButtonSave
        Me.ButtonSave.CustomImages.Parent = Me.ButtonSave
        Me.ButtonSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ButtonSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.HoverState.Parent = Me.ButtonSave
        Me.ButtonSave.Location = New System.Drawing.Point(510, 472)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.ShadowDecoration.Parent = Me.ButtonSave
        Me.ButtonSave.Size = New System.Drawing.Size(132, 37)
        Me.ButtonSave.TabIndex = 16
        Me.ButtonSave.Text = "Save"
        '
        'CBPosition
        '
        Me.CBPosition.BackColor = System.Drawing.Color.Transparent
        Me.CBPosition.BorderRadius = 5
        Me.CBPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPosition.FocusedColor = System.Drawing.Color.Empty
        Me.CBPosition.FocusedState.Parent = Me.CBPosition
        Me.CBPosition.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBPosition.FormattingEnabled = True
        Me.CBPosition.HoverState.Parent = Me.CBPosition
        Me.CBPosition.ItemHeight = 30
        Me.CBPosition.ItemsAppearance.Parent = Me.CBPosition
        Me.CBPosition.Location = New System.Drawing.Point(192, 346)
        Me.CBPosition.Name = "CBPosition"
        Me.CBPosition.ShadowDecoration.Parent = Me.CBPosition
        Me.CBPosition.Size = New System.Drawing.Size(450, 36)
        Me.CBPosition.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(188, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tagline (Optional)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(190, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Position*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(190, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Course/Year/Section"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(190, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Fullname"
        '
        'ErrorVoter
        '
        Me.ErrorVoter.AutoSize = True
        Me.ErrorVoter.BackColor = System.Drawing.SystemColors.Control
        Me.ErrorVoter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorVoter.ForeColor = System.Drawing.Color.Red
        Me.ErrorVoter.Location = New System.Drawing.Point(190, 145)
        Me.ErrorVoter.Name = "ErrorVoter"
        Me.ErrorVoter.Size = New System.Drawing.Size(0, 13)
        Me.ErrorVoter.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(190, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Voter's ID*"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPG(*.JPG)|*.jpg"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox1.ErrorImage = Global.Voting_SystemVB.My.Resources.Resources.error_image
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.ImageLocation = ""
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(24, 77)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(137, 137)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'BackgroundWorkerSave
        '
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.TextCYS)
        Me.Guna2GroupBox1.Controls.Add(Me.TextFullname)
        Me.Guna2GroupBox1.Controls.Add(Me.TextTagline)
        Me.Guna2GroupBox1.Controls.Add(Me.TextVoter)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonDiscard)
        Me.Guna2GroupBox1.Controls.Add(Me.CBPosition)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonSave)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonClear)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorVoter)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(679, 532)
        Me.Guna2GroupBox1.TabIndex = 20
        Me.Guna2GroupBox1.Text = "Register Candidate"
        '
        'TextCYS
        '
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
        Me.TextCYS.Location = New System.Drawing.Point(192, 273)
        Me.TextCYS.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextCYS.Name = "TextCYS"
        Me.TextCYS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextCYS.PlaceholderText = ""
        Me.TextCYS.SelectedText = ""
        Me.TextCYS.ShadowDecoration.Parent = Me.TextCYS
        Me.TextCYS.Size = New System.Drawing.Size(450, 39)
        Me.TextCYS.TabIndex = 23
        '
        'TextFullname
        '
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
        Me.TextFullname.Location = New System.Drawing.Point(192, 188)
        Me.TextFullname.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextFullname.Name = "TextFullname"
        Me.TextFullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextFullname.PlaceholderText = ""
        Me.TextFullname.SelectedText = ""
        Me.TextFullname.ShadowDecoration.Parent = Me.TextFullname
        Me.TextFullname.Size = New System.Drawing.Size(450, 39)
        Me.TextFullname.TabIndex = 22
        '
        'TextTagline
        '
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
        Me.TextTagline.Location = New System.Drawing.Point(192, 426)
        Me.TextTagline.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextTagline.Name = "TextTagline"
        Me.TextTagline.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextTagline.PlaceholderText = ""
        Me.TextTagline.SelectedText = ""
        Me.TextTagline.ShadowDecoration.Parent = Me.TextTagline
        Me.TextTagline.Size = New System.Drawing.Size(450, 36)
        Me.TextTagline.TabIndex = 21
        '
        'TextVoter
        '
        Me.TextVoter.BorderRadius = 5
        Me.TextVoter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextVoter.DefaultText = ""
        Me.TextVoter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextVoter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextVoter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextVoter.DisabledState.Parent = Me.TextVoter
        Me.TextVoter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextVoter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextVoter.FocusedState.Parent = Me.TextVoter
        Me.TextVoter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextVoter.HoverState.Parent = Me.TextVoter
        Me.TextVoter.Location = New System.Drawing.Point(192, 106)
        Me.TextVoter.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextVoter.Name = "TextVoter"
        Me.TextVoter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextVoter.PlaceholderText = "Candidate must be a registered voters"
        Me.TextVoter.SelectedText = ""
        Me.TextVoter.ShadowDecoration.Parent = Me.TextVoter
        Me.TextVoter.Size = New System.Drawing.Size(450, 37)
        Me.TextVoter.TabIndex = 20
        '
        'AddCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "AddCandidate"
        Me.Size = New System.Drawing.Size(679, 532)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ButtonClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrorVoter As System.Windows.Forms.Label
    Friend WithEvents CBPosition As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BackgroundWorkerSave As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TextVoter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextTagline As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextCYS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextFullname As Guna.UI2.WinForms.Guna2TextBox

End Class
