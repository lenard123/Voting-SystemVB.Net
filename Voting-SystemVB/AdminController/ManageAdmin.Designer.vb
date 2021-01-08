<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAdmin
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnUpdateAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnChangePassword = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonAddAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnRecover = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnUpdatePrivileges = New Guna.UI2.WinForms.Guna2Button()
        Me.FontAwesome1 = New Voting_SystemVB.FontAwesome()
        Me.FontAwesome2 = New Voting_SystemVB.FontAwesome()
        Me.FontAwesome3 = New Voting_SystemVB.FontAwesome()
        Me.FontAwesome4 = New Voting_SystemVB.FontAwesome()
        Me.FontAwesome5 = New Voting_SystemVB.FontAwesome()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnViewPrivileges = New Guna.UI2.WinForms.Guna2Button()
        Me.FontAwesome6 = New Voting_SystemVB.FontAwesome()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Admin Settings"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(40, 86)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(924, 452)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnUpdateAccount)
        Me.Panel1.Controls.Add(Me.FontAwesome1)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 119)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(95, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Change your Username or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fullname here"
        '
        'BtnUpdateAccount
        '
        Me.BtnUpdateAccount.Animated = True
        Me.BtnUpdateAccount.CheckedState.Parent = Me.BtnUpdateAccount
        Me.BtnUpdateAccount.CustomImages.Parent = Me.BtnUpdateAccount
        Me.BtnUpdateAccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdateAccount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnUpdateAccount.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateAccount.HoverState.Parent = Me.BtnUpdateAccount
        Me.BtnUpdateAccount.Location = New System.Drawing.Point(0, 83)
        Me.BtnUpdateAccount.Name = "BtnUpdateAccount"
        Me.BtnUpdateAccount.ShadowDecoration.Parent = Me.BtnUpdateAccount
        Me.BtnUpdateAccount.Size = New System.Drawing.Size(301, 36)
        Me.BtnUpdateAccount.TabIndex = 2
        Me.BtnUpdateAccount.Text = "Update Account"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Brown
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BtnChangePassword)
        Me.Panel2.Controls.Add(Me.FontAwesome2)
        Me.Panel2.Location = New System.Drawing.Point(319, 6)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 119)
        Me.Panel2.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(-212, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 38)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Change your Username or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fullname here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(84, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "You can update your password " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "here."
        '
        'BtnChangePassword
        '
        Me.BtnChangePassword.Animated = True
        Me.BtnChangePassword.CheckedState.Parent = Me.BtnChangePassword
        Me.BtnChangePassword.CustomImages.Parent = Me.BtnChangePassword
        Me.BtnChangePassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnChangePassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnChangePassword.ForeColor = System.Drawing.Color.White
        Me.BtnChangePassword.HoverState.Parent = Me.BtnChangePassword
        Me.BtnChangePassword.Location = New System.Drawing.Point(0, 83)
        Me.BtnChangePassword.Name = "BtnChangePassword"
        Me.BtnChangePassword.ShadowDecoration.Parent = Me.BtnChangePassword
        Me.BtnChangePassword.Size = New System.Drawing.Size(301, 36)
        Me.BtnChangePassword.TabIndex = 2
        Me.BtnChangePassword.Text = "Change Password"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.ButtonAddAdmin)
        Me.Panel3.Controls.Add(Me.FontAwesome3)
        Me.Panel3.Location = New System.Drawing.Point(319, 137)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(301, 119)
        Me.Panel3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(79, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Add new Admin to help facilitate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the election."
        '
        'ButtonAddAdmin
        '
        Me.ButtonAddAdmin.Animated = True
        Me.ButtonAddAdmin.CheckedState.Parent = Me.ButtonAddAdmin
        Me.ButtonAddAdmin.CustomImages.Parent = Me.ButtonAddAdmin
        Me.ButtonAddAdmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAddAdmin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonAddAdmin.ForeColor = System.Drawing.Color.White
        Me.ButtonAddAdmin.HoverState.Parent = Me.ButtonAddAdmin
        Me.ButtonAddAdmin.Location = New System.Drawing.Point(0, 83)
        Me.ButtonAddAdmin.Name = "ButtonAddAdmin"
        Me.ButtonAddAdmin.ShadowDecoration.Parent = Me.ButtonAddAdmin
        Me.ButtonAddAdmin.Size = New System.Drawing.Size(301, 36)
        Me.ButtonAddAdmin.TabIndex = 2
        Me.ButtonAddAdmin.Text = "Add Admin"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.BtnRecover)
        Me.Panel4.Controls.Add(Me.FontAwesome4)
        Me.Panel4.Location = New System.Drawing.Point(6, 268)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(301, 119)
        Me.Panel4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(79, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 30)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Reset the password of sub admin " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "account incase they forgot."
        '
        'BtnRecover
        '
        Me.BtnRecover.Animated = True
        Me.BtnRecover.CheckedState.Parent = Me.BtnRecover
        Me.BtnRecover.CustomImages.Parent = Me.BtnRecover
        Me.BtnRecover.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRecover.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnRecover.ForeColor = System.Drawing.Color.White
        Me.BtnRecover.HoverState.Parent = Me.BtnRecover
        Me.BtnRecover.Location = New System.Drawing.Point(0, 83)
        Me.BtnRecover.Name = "BtnRecover"
        Me.BtnRecover.ShadowDecoration.Parent = Me.BtnRecover
        Me.BtnRecover.Size = New System.Drawing.Size(301, 36)
        Me.BtnRecover.TabIndex = 2
        Me.BtnRecover.Text = "Recover Account"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Purple
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.BtnUpdatePrivileges)
        Me.Panel5.Controls.Add(Me.FontAwesome5)
        Me.Panel5.Location = New System.Drawing.Point(319, 268)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(301, 119)
        Me.Panel5.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(95, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 30)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Limit the access of the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sub admin"
        '
        'BtnUpdatePrivileges
        '
        Me.BtnUpdatePrivileges.Animated = True
        Me.BtnUpdatePrivileges.CheckedState.Parent = Me.BtnUpdatePrivileges
        Me.BtnUpdatePrivileges.CustomImages.Parent = Me.BtnUpdatePrivileges
        Me.BtnUpdatePrivileges.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdatePrivileges.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnUpdatePrivileges.ForeColor = System.Drawing.Color.White
        Me.BtnUpdatePrivileges.HoverState.Parent = Me.BtnUpdatePrivileges
        Me.BtnUpdatePrivileges.Location = New System.Drawing.Point(0, 83)
        Me.BtnUpdatePrivileges.Name = "BtnUpdatePrivileges"
        Me.BtnUpdatePrivileges.ShadowDecoration.Parent = Me.BtnUpdatePrivileges
        Me.BtnUpdatePrivileges.Size = New System.Drawing.Size(301, 36)
        Me.BtnUpdatePrivileges.TabIndex = 2
        Me.BtnUpdatePrivileges.Text = "Update Privileges"
        '
        'FontAwesome1
        '
        Me.FontAwesome1.AutoSize = True
        Me.FontAwesome1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FontAwesome1.Font = New System.Drawing.Font("Font Awesome 5 Free Solid", 32.0!)
        Me.FontAwesome1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.FontAwesome1.HoverColor = System.Drawing.Color.Empty
        Me.FontAwesome1.IsHoverable = False
        Me.FontAwesome1.Location = New System.Drawing.Point(15, 24)
        Me.FontAwesome1.Name = "FontAwesome1"
        Me.FontAwesome1.Size = New System.Drawing.Size(74, 46)
        Me.FontAwesome1.TabIndex = 1
        Me.FontAwesome1.Text = "user-edit"
        '
        'FontAwesome2
        '
        Me.FontAwesome2.AutoSize = True
        Me.FontAwesome2.Font = New System.Drawing.Font("Font Awesome 5 Free Solid", 32.0!)
        Me.FontAwesome2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.FontAwesome2.HoverColor = System.Drawing.Color.Empty
        Me.FontAwesome2.IsHoverable = False
        Me.FontAwesome2.Location = New System.Drawing.Point(15, 24)
        Me.FontAwesome2.Name = "FontAwesome2"
        Me.FontAwesome2.Size = New System.Drawing.Size(63, 46)
        Me.FontAwesome2.TabIndex = 1
        Me.FontAwesome2.Text = "key"
        '
        'FontAwesome3
        '
        Me.FontAwesome3.AutoSize = True
        Me.FontAwesome3.Font = New System.Drawing.Font("Font Awesome 5 Free Solid", 32.0!)
        Me.FontAwesome3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.FontAwesome3.HoverColor = System.Drawing.Color.Empty
        Me.FontAwesome3.IsHoverable = False
        Me.FontAwesome3.Location = New System.Drawing.Point(15, 24)
        Me.FontAwesome3.Name = "FontAwesome3"
        Me.FontAwesome3.Size = New System.Drawing.Size(58, 46)
        Me.FontAwesome3.TabIndex = 1
        Me.FontAwesome3.Text = "plus-square"
        '
        'FontAwesome4
        '
        Me.FontAwesome4.AutoSize = True
        Me.FontAwesome4.Font = New System.Drawing.Font("Font Awesome 5 Free Solid", 32.0!)
        Me.FontAwesome4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.FontAwesome4.HoverColor = System.Drawing.Color.Empty
        Me.FontAwesome4.IsHoverable = False
        Me.FontAwesome4.Location = New System.Drawing.Point(15, 24)
        Me.FontAwesome4.Name = "FontAwesome4"
        Me.FontAwesome4.Size = New System.Drawing.Size(68, 46)
        Me.FontAwesome4.TabIndex = 1
        Me.FontAwesome4.Text = "lock-open"
        '
        'FontAwesome5
        '
        Me.FontAwesome5.AutoSize = True
        Me.FontAwesome5.Font = New System.Drawing.Font("Font Awesome 5 Free Solid", 32.0!)
        Me.FontAwesome5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.FontAwesome5.HoverColor = System.Drawing.Color.Empty
        Me.FontAwesome5.IsHoverable = False
        Me.FontAwesome5.Location = New System.Drawing.Point(15, 24)
        Me.FontAwesome5.Name = "FontAwesome5"
        Me.FontAwesome5.Size = New System.Drawing.Size(74, 46)
        Me.FontAwesome5.TabIndex = 1
        Me.FontAwesome5.Text = "user-cog"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.BtnViewPrivileges)
        Me.Panel6.Controls.Add(Me.FontAwesome6)
        Me.Panel6.Location = New System.Drawing.Point(6, 137)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(301, 119)
        Me.Panel6.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(95, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "View Your Privileges as an Admin"
        '
        'BtnViewPrivileges
        '
        Me.BtnViewPrivileges.Animated = True
        Me.BtnViewPrivileges.CheckedState.Parent = Me.BtnViewPrivileges
        Me.BtnViewPrivileges.CustomImages.Parent = Me.BtnViewPrivileges
        Me.BtnViewPrivileges.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnViewPrivileges.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnViewPrivileges.ForeColor = System.Drawing.Color.White
        Me.BtnViewPrivileges.HoverState.Parent = Me.BtnViewPrivileges
        Me.BtnViewPrivileges.Location = New System.Drawing.Point(0, 83)
        Me.BtnViewPrivileges.Name = "BtnViewPrivileges"
        Me.BtnViewPrivileges.ShadowDecoration.Parent = Me.BtnViewPrivileges
        Me.BtnViewPrivileges.Size = New System.Drawing.Size(301, 36)
        Me.BtnViewPrivileges.TabIndex = 2
        Me.BtnViewPrivileges.Text = "View Privileges"
        '
        'FontAwesome6
        '
        Me.FontAwesome6.AutoSize = True
        Me.FontAwesome6.Font = New System.Drawing.Font("Font Awesome 5 Free Solid", 32.0!)
        Me.FontAwesome6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FontAwesome6.HoverColor = System.Drawing.Color.Empty
        Me.FontAwesome6.IsHoverable = False
        Me.FontAwesome6.Location = New System.Drawing.Point(15, 24)
        Me.FontAwesome6.Name = "FontAwesome6"
        Me.FontAwesome6.Size = New System.Drawing.Size(63, 46)
        Me.FontAwesome6.TabIndex = 1
        Me.FontAwesome6.Text = "list"
        '
        'ManageAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManageAdmin"
        Me.Size = New System.Drawing.Size(985, 560)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnUpdateAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FontAwesome1 As Voting_SystemVB.FontAwesome
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnChangePassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FontAwesome2 As Voting_SystemVB.FontAwesome
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonAddAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FontAwesome3 As Voting_SystemVB.FontAwesome
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnRecover As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FontAwesome4 As Voting_SystemVB.FontAwesome
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnUpdatePrivileges As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FontAwesome5 As Voting_SystemVB.FontAwesome
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnViewPrivileges As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FontAwesome6 As Voting_SystemVB.FontAwesome

End Class
