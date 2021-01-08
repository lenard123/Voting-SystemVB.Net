<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewElection
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
        Me.BtnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.SwitchDeleteWorker = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.SwitchKeepVoter = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BWKeepVoters = New System.ComponentModel.BackgroundWorker()
        Me.BWDeleteAdmin = New System.ComponentModel.BackgroundWorker()
        Me.BWNewElection = New System.ComponentModel.BackgroundWorker()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.BtnSubmit)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnClose)
        Me.Guna2GroupBox1.Controls.Add(Me.SwitchDeleteWorker)
        Me.Guna2GroupBox1.Controls.Add(Me.SwitchKeepVoter)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(349, 239)
        Me.Guna2GroupBox1.TabIndex = 28
        Me.Guna2GroupBox1.Text = "New Election"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.CheckedState.Parent = Me.BtnSubmit
        Me.BtnSubmit.CustomImages.Parent = Me.BtnSubmit
        Me.BtnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSubmit.ForeColor = System.Drawing.Color.White
        Me.BtnSubmit.HoverState.Parent = Me.BtnSubmit
        Me.BtnSubmit.Location = New System.Drawing.Point(186, 168)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.ShadowDecoration.Parent = Me.BtnSubmit
        Me.BtnSubmit.Size = New System.Drawing.Size(137, 37)
        Me.BtnSubmit.TabIndex = 30
        Me.BtnSubmit.Text = "Confirm"
        '
        'BtnClose
        '
        Me.BtnClose.Animated = True
        Me.BtnClose.CheckedState.Parent = Me.BtnClose
        Me.BtnClose.CustomImages.Parent = Me.BtnClose
        Me.BtnClose.FillColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnClose.ForeColor = System.Drawing.Color.DimGray
        Me.BtnClose.HoverState.Parent = Me.BtnClose
        Me.BtnClose.Location = New System.Drawing.Point(36, 168)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.ShadowDecoration.Parent = Me.BtnClose
        Me.BtnClose.Size = New System.Drawing.Size(137, 37)
        Me.BtnClose.TabIndex = 29
        Me.BtnClose.Text = "Close"
        '
        'SwitchDeleteWorker
        '
        Me.SwitchDeleteWorker.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SwitchDeleteWorker.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SwitchDeleteWorker.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SwitchDeleteWorker.CheckedState.InnerColor = System.Drawing.Color.White
        Me.SwitchDeleteWorker.CheckedState.Parent = Me.SwitchDeleteWorker
        Me.SwitchDeleteWorker.Location = New System.Drawing.Point(36, 107)
        Me.SwitchDeleteWorker.Name = "SwitchDeleteWorker"
        Me.SwitchDeleteWorker.ShadowDecoration.Parent = Me.SwitchDeleteWorker
        Me.SwitchDeleteWorker.Size = New System.Drawing.Size(35, 20)
        Me.SwitchDeleteWorker.TabIndex = 1
        Me.SwitchDeleteWorker.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SwitchDeleteWorker.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SwitchDeleteWorker.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SwitchDeleteWorker.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.SwitchDeleteWorker.UncheckedState.Parent = Me.SwitchDeleteWorker
        '
        'SwitchKeepVoter
        '
        Me.SwitchKeepVoter.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SwitchKeepVoter.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SwitchKeepVoter.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SwitchKeepVoter.CheckedState.InnerColor = System.Drawing.Color.White
        Me.SwitchKeepVoter.CheckedState.Parent = Me.SwitchKeepVoter
        Me.SwitchKeepVoter.Location = New System.Drawing.Point(36, 81)
        Me.SwitchKeepVoter.Name = "SwitchKeepVoter"
        Me.SwitchKeepVoter.ShadowDecoration.Parent = Me.SwitchKeepVoter
        Me.SwitchKeepVoter.Size = New System.Drawing.Size(35, 20)
        Me.SwitchKeepVoter.TabIndex = 1
        Me.SwitchKeepVoter.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SwitchKeepVoter.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SwitchKeepVoter.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SwitchKeepVoter.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.SwitchKeepVoter.UncheckedState.Parent = Me.SwitchKeepVoter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(77, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "- Delete Sub Admin?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(77, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "- Keep Voters?"
        '
        'BWKeepVoters
        '
        Me.BWKeepVoters.WorkerReportsProgress = True
        '
        'BWDeleteAdmin
        '
        '
        'BWNewElection
        '
        '
        'NewElection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "NewElection"
        Me.Size = New System.Drawing.Size(349, 239)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents SwitchDeleteWorker As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents SwitchKeepVoter As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BWKeepVoters As System.ComponentModel.BackgroundWorker
    Friend WithEvents BWDeleteAdmin As System.ComponentModel.BackgroundWorker
    Friend WithEvents BWNewElection As System.ComponentModel.BackgroundWorker

End Class
