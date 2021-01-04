<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAccount
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
        Me.ButtonCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextFullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorFullname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorUsername = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorPassword = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.TextPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorUsername)
        Me.Guna2GroupBox1.Controls.Add(Me.TextUsername)
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorFullname)
        Me.Guna2GroupBox1.Controls.Add(Me.TextFullname)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(379, 449)
        Me.Guna2GroupBox1.TabIndex = 26
        Me.Guna2GroupBox1.Text = "Update Account Information"
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
        Me.ButtonCancel.Location = New System.Drawing.Point(107, 393)
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
        Me.ButtonUpdate.Location = New System.Drawing.Point(206, 387)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.ShadowDecoration.Parent = Me.ButtonUpdate
        Me.ButtonUpdate.Size = New System.Drawing.Size(150, 36)
        Me.ButtonUpdate.TabIndex = 21
        Me.ButtonUpdate.Text = "Update"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(20, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Fullname"
        '
        'TextFullname
        '
        Me.TextFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextFullname.DefaultText = ""
        Me.TextFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextFullname.DisabledState.Parent = Me.TextFullname
        Me.TextFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFullname.FocusedState.Parent = Me.TextFullname
        Me.TextFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFullname.HoverState.Parent = Me.TextFullname
        Me.TextFullname.Location = New System.Drawing.Point(24, 98)
        Me.TextFullname.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextFullname.Name = "TextFullname"
        Me.TextFullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextFullname.PlaceholderText = ""
        Me.TextFullname.SelectedText = ""
        Me.TextFullname.ShadowDecoration.Parent = Me.TextFullname
        Me.TextFullname.Size = New System.Drawing.Size(332, 37)
        Me.TextFullname.TabIndex = 23
        '
        'ErrorFullname
        '
        Me.ErrorFullname.AutoSize = True
        Me.ErrorFullname.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorFullname.ForeColor = System.Drawing.Color.Red
        Me.ErrorFullname.Location = New System.Drawing.Point(22, 141)
        Me.ErrorFullname.Name = "ErrorFullname"
        Me.ErrorFullname.Size = New System.Drawing.Size(0, 13)
        Me.ErrorFullname.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(20, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Username"
        '
        'TextUsername
        '
        Me.TextUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextUsername.DefaultText = ""
        Me.TextUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextUsername.DisabledState.Parent = Me.TextUsername
        Me.TextUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextUsername.FocusedState.Parent = Me.TextUsername
        Me.TextUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextUsername.HoverState.Parent = Me.TextUsername
        Me.TextUsername.Location = New System.Drawing.Point(24, 202)
        Me.TextUsername.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextUsername.PlaceholderText = ""
        Me.TextUsername.SelectedText = ""
        Me.TextUsername.ShadowDecoration.Parent = Me.TextUsername
        Me.TextUsername.Size = New System.Drawing.Size(332, 37)
        Me.TextUsername.TabIndex = 25
        '
        'ErrorUsername
        '
        Me.ErrorUsername.AutoSize = True
        Me.ErrorUsername.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorUsername.ForeColor = System.Drawing.Color.Red
        Me.ErrorUsername.Location = New System.Drawing.Point(22, 246)
        Me.ErrorUsername.Name = "ErrorUsername"
        Me.ErrorUsername.Size = New System.Drawing.Size(0, 13)
        Me.ErrorUsername.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(20, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Confirm Password"
        '
        'TextPassword
        '
        Me.TextPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextPassword.DefaultText = ""
        Me.TextPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextPassword.DisabledState.Parent = Me.TextPassword
        Me.TextPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextPassword.FocusedState.Parent = Me.TextPassword
        Me.TextPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextPassword.HoverState.Parent = Me.TextPassword
        Me.TextPassword.Location = New System.Drawing.Point(25, 306)
        Me.TextPassword.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextPassword.PlaceholderText = ""
        Me.TextPassword.SelectedText = ""
        Me.TextPassword.ShadowDecoration.Parent = Me.TextPassword
        Me.TextPassword.Size = New System.Drawing.Size(331, 36)
        Me.TextPassword.TabIndex = 27
        Me.TextPassword.UseSystemPasswordChar = True
        '
        'ErrorPassword
        '
        Me.ErrorPassword.AutoSize = True
        Me.ErrorPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorPassword.ForeColor = System.Drawing.Color.Red
        Me.ErrorPassword.Location = New System.Drawing.Point(22, 349)
        Me.ErrorPassword.Name = "ErrorPassword"
        Me.ErrorPassword.Size = New System.Drawing.Size(0, 13)
        Me.ErrorPassword.TabIndex = 28
        '
        'UpdateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "UpdateAccount"
        Me.Size = New System.Drawing.Size(379, 449)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ErrorPassword As System.Windows.Forms.Label
    Friend WithEvents TextPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorUsername As System.Windows.Forms.Label
    Friend WithEvents TextUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorFullname As System.Windows.Forms.Label
    Friend WithEvents TextFullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonUpdate As Guna.UI2.WinForms.Guna2Button

End Class
