<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecoverAccount
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.CBUsername = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TextYourPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextFullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.ErrorNewPassword = New System.Windows.Forms.Label()
        Me.ErrorYourPassword = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorYourPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorNewPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.CBUsername)
        Me.Guna2GroupBox1.Controls.Add(Me.TextYourPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.TextNewPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.TextFullname)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonSubmit)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(492, 501)
        Me.Guna2GroupBox1.TabIndex = 27
        Me.Guna2GroupBox1.Text = "Recover Sub Admin Account"
        '
        'CBUsername
        '
        Me.CBUsername.BackColor = System.Drawing.Color.Transparent
        Me.CBUsername.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUsername.FocusedColor = System.Drawing.Color.Empty
        Me.CBUsername.FocusedState.Parent = Me.CBUsername
        Me.CBUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBUsername.FormattingEnabled = True
        Me.CBUsername.HoverState.Parent = Me.CBUsername
        Me.CBUsername.ItemHeight = 30
        Me.CBUsername.ItemsAppearance.Parent = Me.CBUsername
        Me.CBUsername.Location = New System.Drawing.Point(37, 94)
        Me.CBUsername.Name = "CBUsername"
        Me.CBUsername.ShadowDecoration.Parent = Me.CBUsername
        Me.CBUsername.Size = New System.Drawing.Size(423, 36)
        Me.CBUsername.TabIndex = 31
        '
        'TextYourPassword
        '
        Me.TextYourPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextYourPassword.DefaultText = ""
        Me.TextYourPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextYourPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextYourPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextYourPassword.DisabledState.Parent = Me.TextYourPassword
        Me.TextYourPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextYourPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextYourPassword.FocusedState.Parent = Me.TextYourPassword
        Me.TextYourPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextYourPassword.HoverState.Parent = Me.TextYourPassword
        Me.TextYourPassword.Location = New System.Drawing.Point(37, 365)
        Me.TextYourPassword.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextYourPassword.Name = "TextYourPassword"
        Me.TextYourPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextYourPassword.PlaceholderText = ""
        Me.TextYourPassword.SelectedText = ""
        Me.TextYourPassword.ShadowDecoration.Parent = Me.TextYourPassword
        Me.TextYourPassword.Size = New System.Drawing.Size(423, 36)
        Me.TextYourPassword.TabIndex = 30
        Me.TextYourPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(32, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Enter Your Password Here"
        '
        'TextNewPassword
        '
        Me.TextNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextNewPassword.DefaultText = ""
        Me.TextNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextNewPassword.DisabledState.Parent = Me.TextNewPassword
        Me.TextNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextNewPassword.Enabled = False
        Me.TextNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextNewPassword.FocusedState.Parent = Me.TextNewPassword
        Me.TextNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextNewPassword.HoverState.Parent = Me.TextNewPassword
        Me.TextNewPassword.Location = New System.Drawing.Point(36, 268)
        Me.TextNewPassword.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextNewPassword.Name = "TextNewPassword"
        Me.TextNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextNewPassword.PlaceholderText = ""
        Me.TextNewPassword.SelectedText = ""
        Me.TextNewPassword.ShadowDecoration.Parent = Me.TextNewPassword
        Me.TextNewPassword.Size = New System.Drawing.Size(424, 37)
        Me.TextNewPassword.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(32, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "New Password"
        '
        'TextFullname
        '
        Me.TextFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextFullname.DefaultText = ""
        Me.TextFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.TextFullname.DisabledState.FillColor = System.Drawing.Color.White
        Me.TextFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.TextFullname.DisabledState.Parent = Me.TextFullname
        Me.TextFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextFullname.Enabled = False
        Me.TextFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFullname.FocusedState.Parent = Me.TextFullname
        Me.TextFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFullname.HoverState.Parent = Me.TextFullname
        Me.TextFullname.Location = New System.Drawing.Point(36, 182)
        Me.TextFullname.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextFullname.Name = "TextFullname"
        Me.TextFullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextFullname.PlaceholderText = ""
        Me.TextFullname.SelectedText = ""
        Me.TextFullname.ShadowDecoration.Parent = Me.TextFullname
        Me.TextFullname.Size = New System.Drawing.Size(426, 37)
        Me.TextFullname.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(32, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fullname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Username"
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
        Me.ButtonCancel.Location = New System.Drawing.Point(213, 448)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.ShadowDecoration.Parent = Me.ButtonCancel
        Me.ButtonCancel.Size = New System.Drawing.Size(93, 22)
        Me.ButtonCancel.TabIndex = 20
        Me.ButtonCancel.Text = "Cancel"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Animated = True
        Me.ButtonSubmit.CheckedState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.CustomImages.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ButtonSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.White
        Me.ButtonSubmit.HoverState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Location = New System.Drawing.Point(312, 442)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.ShadowDecoration.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Size = New System.Drawing.Size(150, 36)
        Me.ButtonSubmit.TabIndex = 21
        Me.ButtonSubmit.Text = "Submit"
        '
        'ErrorNewPassword
        '
        Me.ErrorNewPassword.AutoSize = True
        Me.ErrorNewPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorNewPassword.ForeColor = System.Drawing.Color.Red
        Me.ErrorNewPassword.Location = New System.Drawing.Point(32, 307)
        Me.ErrorNewPassword.Name = "ErrorNewPassword"
        Me.ErrorNewPassword.Size = New System.Drawing.Size(0, 13)
        Me.ErrorNewPassword.TabIndex = 32
        '
        'ErrorYourPassword
        '
        Me.ErrorYourPassword.AutoSize = True
        Me.ErrorYourPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorYourPassword.ForeColor = System.Drawing.Color.Red
        Me.ErrorYourPassword.Location = New System.Drawing.Point(34, 404)
        Me.ErrorYourPassword.Name = "ErrorYourPassword"
        Me.ErrorYourPassword.Size = New System.Drawing.Size(0, 13)
        Me.ErrorYourPassword.TabIndex = 33
        '
        'RecoverAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "RecoverAccount"
        Me.Size = New System.Drawing.Size(492, 501)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ButtonCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextYourPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextFullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBUsername As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ErrorYourPassword As System.Windows.Forms.Label
    Friend WithEvents ErrorNewPassword As System.Windows.Forms.Label

End Class
