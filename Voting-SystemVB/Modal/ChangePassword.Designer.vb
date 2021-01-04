<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.ErrorOldPassword = New System.Windows.Forms.Label()
        Me.TextOldPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorReEnterPassword = New System.Windows.Forms.Label()
        Me.TextReEnterPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorNewPassword = New System.Windows.Forms.Label()
        Me.TextNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorOldPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.TextOldPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorReEnterPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.TextReEnterPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorNewPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.TextNewPassword)
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
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(575, 450)
        Me.Guna2GroupBox1.TabIndex = 27
        Me.Guna2GroupBox1.Text = "Update Account Information"
        '
        'ErrorOldPassword
        '
        Me.ErrorOldPassword.AutoSize = True
        Me.ErrorOldPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorOldPassword.ForeColor = System.Drawing.Color.Red
        Me.ErrorOldPassword.Location = New System.Drawing.Point(22, 349)
        Me.ErrorOldPassword.Name = "ErrorOldPassword"
        Me.ErrorOldPassword.Size = New System.Drawing.Size(0, 13)
        Me.ErrorOldPassword.TabIndex = 28
        '
        'TextOldPassword
        '
        Me.TextOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextOldPassword.DefaultText = ""
        Me.TextOldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextOldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextOldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextOldPassword.DisabledState.Parent = Me.TextOldPassword
        Me.TextOldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextOldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextOldPassword.FocusedState.Parent = Me.TextOldPassword
        Me.TextOldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextOldPassword.HoverState.Parent = Me.TextOldPassword
        Me.TextOldPassword.Location = New System.Drawing.Point(25, 306)
        Me.TextOldPassword.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextOldPassword.Name = "TextOldPassword"
        Me.TextOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextOldPassword.PlaceholderText = ""
        Me.TextOldPassword.SelectedText = ""
        Me.TextOldPassword.ShadowDecoration.Parent = Me.TextOldPassword
        Me.TextOldPassword.Size = New System.Drawing.Size(524, 36)
        Me.TextOldPassword.TabIndex = 27
        Me.TextOldPassword.UseSystemPasswordChar = True
        '
        'ErrorReEnterPassword
        '
        Me.ErrorReEnterPassword.AutoSize = True
        Me.ErrorReEnterPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorReEnterPassword.ForeColor = System.Drawing.Color.Red
        Me.ErrorReEnterPassword.Location = New System.Drawing.Point(22, 246)
        Me.ErrorReEnterPassword.Name = "ErrorReEnterPassword"
        Me.ErrorReEnterPassword.Size = New System.Drawing.Size(0, 13)
        Me.ErrorReEnterPassword.TabIndex = 26
        '
        'TextReEnterPassword
        '
        Me.TextReEnterPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextReEnterPassword.DefaultText = ""
        Me.TextReEnterPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextReEnterPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextReEnterPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextReEnterPassword.DisabledState.Parent = Me.TextReEnterPassword
        Me.TextReEnterPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextReEnterPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextReEnterPassword.FocusedState.Parent = Me.TextReEnterPassword
        Me.TextReEnterPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextReEnterPassword.HoverState.Parent = Me.TextReEnterPassword
        Me.TextReEnterPassword.Location = New System.Drawing.Point(24, 202)
        Me.TextReEnterPassword.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextReEnterPassword.Name = "TextReEnterPassword"
        Me.TextReEnterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextReEnterPassword.PlaceholderText = ""
        Me.TextReEnterPassword.SelectedText = ""
        Me.TextReEnterPassword.ShadowDecoration.Parent = Me.TextReEnterPassword
        Me.TextReEnterPassword.Size = New System.Drawing.Size(525, 37)
        Me.TextReEnterPassword.TabIndex = 25
        Me.TextReEnterPassword.UseSystemPasswordChar = True
        '
        'ErrorNewPassword
        '
        Me.ErrorNewPassword.AutoSize = True
        Me.ErrorNewPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorNewPassword.ForeColor = System.Drawing.Color.Red
        Me.ErrorNewPassword.Location = New System.Drawing.Point(22, 141)
        Me.ErrorNewPassword.Name = "ErrorNewPassword"
        Me.ErrorNewPassword.Size = New System.Drawing.Size(0, 13)
        Me.ErrorNewPassword.TabIndex = 24
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
        Me.TextNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextNewPassword.FocusedState.Parent = Me.TextNewPassword
        Me.TextNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextNewPassword.HoverState.Parent = Me.TextNewPassword
        Me.TextNewPassword.Location = New System.Drawing.Point(24, 98)
        Me.TextNewPassword.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextNewPassword.Name = "TextNewPassword"
        Me.TextNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextNewPassword.PlaceholderText = ""
        Me.TextNewPassword.SelectedText = ""
        Me.TextNewPassword.ShadowDecoration.Parent = Me.TextNewPassword
        Me.TextNewPassword.Size = New System.Drawing.Size(525, 37)
        Me.TextNewPassword.TabIndex = 23
        Me.TextNewPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(20, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Old Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(20, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Re-enter new password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(20, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "New Password"
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
        Me.ButtonCancel.Location = New System.Drawing.Point(300, 396)
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
        Me.ButtonUpdate.Location = New System.Drawing.Point(399, 390)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.ShadowDecoration.Parent = Me.ButtonUpdate
        Me.ButtonUpdate.Size = New System.Drawing.Size(150, 36)
        Me.ButtonUpdate.TabIndex = 21
        Me.ButtonUpdate.Text = "Update"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "ChangePassword"
        Me.Size = New System.Drawing.Size(575, 450)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ErrorOldPassword As System.Windows.Forms.Label
    Friend WithEvents TextOldPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorReEnterPassword As System.Windows.Forms.Label
    Friend WithEvents TextReEnterPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorNewPassword As System.Windows.Forms.Label
    Friend WithEvents TextNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonUpdate As Guna.UI2.WinForms.Guna2Button

End Class
