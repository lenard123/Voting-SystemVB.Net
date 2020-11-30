<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ButtonSave = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonReset = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonChangePass = New Guna.UI2.WinForms.Guna2Button()
        Me.ErrorUser = New System.Windows.Forms.Label()
        Me.ErrorName = New System.Windows.Forms.Label()
        Me.ErrorPass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(27, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Account"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 57)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fullname"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 48)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Confirm Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextUser
        '
        Me.TextUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextUser.DefaultText = ""
        Me.TextUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextUser.DisabledState.Parent = Me.TextUser
        Me.TextUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextUser.FocusedState.Parent = Me.TextUser
        Me.TextUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextUser.HoverState.Parent = Me.TextUser
        Me.TextUser.Location = New System.Drawing.Point(33, 127)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextUser.PlaceholderText = ""
        Me.TextUser.SelectedText = ""
        Me.TextUser.ShadowDecoration.Parent = Me.TextUser
        Me.TextUser.Size = New System.Drawing.Size(523, 62)
        Me.TextUser.TabIndex = 4
        '
        'TextName
        '
        Me.TextName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextName.DefaultText = ""
        Me.TextName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextName.DisabledState.Parent = Me.TextName
        Me.TextName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextName.FocusedState.Parent = Me.TextName
        Me.TextName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextName.HoverState.Parent = Me.TextName
        Me.TextName.Location = New System.Drawing.Point(33, 260)
        Me.TextName.Name = "TextName"
        Me.TextName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextName.PlaceholderText = ""
        Me.TextName.SelectedText = ""
        Me.TextName.ShadowDecoration.Parent = Me.TextName
        Me.TextName.Size = New System.Drawing.Size(518, 62)
        Me.TextName.TabIndex = 5
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
        Me.TextPassword.Location = New System.Drawing.Point(33, 391)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextPassword.PlaceholderText = ""
        Me.TextPassword.SelectedText = ""
        Me.TextPassword.ShadowDecoration.Parent = Me.TextPassword
        Me.TextPassword.Size = New System.Drawing.Size(518, 62)
        Me.TextPassword.TabIndex = 6
        '
        'ButtonSave
        '
        Me.ButtonSave.CheckedState.Parent = Me.ButtonSave
        Me.ButtonSave.CustomImages.Parent = Me.ButtonSave
        Me.ButtonSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.HoverState.Parent = Me.ButtonSave
        Me.ButtonSave.Location = New System.Drawing.Point(644, 127)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.ShadowDecoration.Parent = Me.ButtonSave
        Me.ButtonSave.Size = New System.Drawing.Size(206, 45)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "SAVE"
        '
        'ButtonReset
        '
        Me.ButtonReset.BorderThickness = 1
        Me.ButtonReset.CheckedState.Parent = Me.ButtonReset
        Me.ButtonReset.CustomImages.Parent = Me.ButtonReset
        Me.ButtonReset.FillColor = System.Drawing.Color.White
        Me.ButtonReset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonReset.ForeColor = System.Drawing.Color.Black
        Me.ButtonReset.HoverState.Parent = Me.ButtonReset
        Me.ButtonReset.Location = New System.Drawing.Point(644, 260)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.ShadowDecoration.Parent = Me.ButtonReset
        Me.ButtonReset.Size = New System.Drawing.Size(206, 45)
        Me.ButtonReset.TabIndex = 8
        Me.ButtonReset.Text = "RESET"
        '
        'ButtonChangePass
        '
        Me.ButtonChangePass.BorderThickness = 1
        Me.ButtonChangePass.CheckedState.Parent = Me.ButtonChangePass
        Me.ButtonChangePass.CustomImages.Parent = Me.ButtonChangePass
        Me.ButtonChangePass.FillColor = System.Drawing.Color.White
        Me.ButtonChangePass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonChangePass.ForeColor = System.Drawing.Color.Black
        Me.ButtonChangePass.HoverState.Parent = Me.ButtonChangePass
        Me.ButtonChangePass.Location = New System.Drawing.Point(644, 191)
        Me.ButtonChangePass.Name = "ButtonChangePass"
        Me.ButtonChangePass.ShadowDecoration.Parent = Me.ButtonChangePass
        Me.ButtonChangePass.Size = New System.Drawing.Size(206, 45)
        Me.ButtonChangePass.TabIndex = 9
        Me.ButtonChangePass.Text = "CHANGE PASSWORD"
        '
        'ErrorUser
        '
        Me.ErrorUser.AutoSize = True
        Me.ErrorUser.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorUser.ForeColor = System.Drawing.Color.Red
        Me.ErrorUser.Location = New System.Drawing.Point(30, 192)
        Me.ErrorUser.Name = "ErrorUser"
        Me.ErrorUser.Size = New System.Drawing.Size(55, 14)
        Me.ErrorUser.TabIndex = 10
        Me.ErrorUser.Text = "ErrorUser"
        '
        'ErrorName
        '
        Me.ErrorName.AutoSize = True
        Me.ErrorName.ForeColor = System.Drawing.Color.Red
        Me.ErrorName.Location = New System.Drawing.Point(30, 325)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.Size = New System.Drawing.Size(57, 13)
        Me.ErrorName.TabIndex = 11
        Me.ErrorName.Text = "ErrorName"
        '
        'ErrorPass
        '
        Me.ErrorPass.AutoSize = True
        Me.ErrorPass.ForeColor = System.Drawing.Color.Red
        Me.ErrorPass.Location = New System.Drawing.Point(30, 456)
        Me.ErrorPass.Name = "ErrorPass"
        Me.ErrorPass.Size = New System.Drawing.Size(52, 13)
        Me.ErrorPass.TabIndex = 12
        Me.ErrorPass.Text = "ErrorPass"
        '
        'UpdateAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ErrorPass)
        Me.Controls.Add(Me.ErrorName)
        Me.Controls.Add(Me.ErrorUser)
        Me.Controls.Add(Me.ButtonChangePass)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.TextUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateAdmin"
        Me.Size = New System.Drawing.Size(1111, 557)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ButtonSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonChangePass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorUser As System.Windows.Forms.Label
    Friend WithEvents ErrorName As System.Windows.Forms.Label
    Friend WithEvents ErrorPass As System.Windows.Forms.Label

End Class
