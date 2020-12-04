<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartElection
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
        Me.ErrorName = New System.Windows.Forms.Label()
        Me.LabelLoading = New System.Windows.Forms.Label()
        Me.Guna2WinProgressIndicator1 = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.ButtonCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonStart = New Guna.UI2.WinForms.Guna2Button()
        Me.TextPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton3 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.TextName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorPassword = New System.Windows.Forms.Label()
        Me.BackgroundWorkerStartElection = New System.ComponentModel.BackgroundWorker()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.ErrorName)
        Me.Guna2GroupBox1.Controls.Add(Me.LabelLoading)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2WinProgressIndicator1)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonStart)
        Me.Guna2GroupBox1.Controls.Add(Me.TextPassword)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Panel2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2GroupBox1.Controls.Add(Me.TextName)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(519, 528)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "START ELECTION"
        '
        'ErrorName
        '
        Me.ErrorName.AutoSize = True
        Me.ErrorName.BackColor = System.Drawing.Color.Transparent
        Me.ErrorName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorName.ForeColor = System.Drawing.Color.Red
        Me.ErrorName.Location = New System.Drawing.Point(31, 136)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.Size = New System.Drawing.Size(0, 13)
        Me.ErrorName.TabIndex = 21
        '
        'LabelLoading
        '
        Me.LabelLoading.AutoSize = True
        Me.LabelLoading.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoading.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelLoading.ForeColor = System.Drawing.Color.Black
        Me.LabelLoading.Location = New System.Drawing.Point(79, 444)
        Me.LabelLoading.Name = "LabelLoading"
        Me.LabelLoading.Size = New System.Drawing.Size(85, 19)
        Me.LabelLoading.TabIndex = 20
        Me.LabelLoading.Text = "Please wait..."
        Me.LabelLoading.Visible = False
        '
        'Guna2WinProgressIndicator1
        '
        Me.Guna2WinProgressIndicator1.CircleSize = 0.01!
        Me.Guna2WinProgressIndicator1.Location = New System.Drawing.Point(43, 438)
        Me.Guna2WinProgressIndicator1.Name = "Guna2WinProgressIndicator1"
        Me.Guna2WinProgressIndicator1.Size = New System.Drawing.Size(30, 30)
        Me.Guna2WinProgressIndicator1.TabIndex = 19
        Me.Guna2WinProgressIndicator1.Visible = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Animated = True
        Me.ButtonCancel.BorderColor = System.Drawing.Color.LightGray
        Me.ButtonCancel.CheckedState.Parent = Me.ButtonCancel
        Me.ButtonCancel.CustomImages.Parent = Me.ButtonCancel
        Me.ButtonCancel.FillColor = System.Drawing.Color.White
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonCancel.ForeColor = System.Drawing.Color.Gray
        Me.ButtonCancel.HoverState.Parent = Me.ButtonCancel
        Me.ButtonCancel.Location = New System.Drawing.Point(251, 443)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.ShadowDecoration.Parent = Me.ButtonCancel
        Me.ButtonCancel.Size = New System.Drawing.Size(106, 23)
        Me.ButtonCancel.TabIndex = 11
        Me.ButtonCancel.Text = "CANCEL"
        '
        'ButtonStart
        '
        Me.ButtonStart.Animated = True
        Me.ButtonStart.CheckedState.Parent = Me.ButtonStart
        Me.ButtonStart.CustomImages.Parent = Me.ButtonStart
        Me.ButtonStart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonStart.ForeColor = System.Drawing.Color.White
        Me.ButtonStart.HoverState.Parent = Me.ButtonStart
        Me.ButtonStart.Location = New System.Drawing.Point(363, 433)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.ShadowDecoration.Parent = Me.ButtonStart
        Me.ButtonStart.Size = New System.Drawing.Size(118, 37)
        Me.ButtonStart.TabIndex = 12
        Me.ButtonStart.Text = "START ELECTION"
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
        Me.TextPassword.Location = New System.Drawing.Point(35, 343)
        Me.TextPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextPassword.PlaceholderText = "For Security Reason"
        Me.TextPassword.SelectedText = ""
        Me.TextPassword.ShadowDecoration.Parent = Me.TextPassword
        Me.TextPassword.Size = New System.Drawing.Size(446, 36)
        Me.TextPassword.TabIndex = 10
        Me.TextPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Guna2RadioButton1)
        Me.Panel2.Controls.Add(Me.Guna2RadioButton3)
        Me.Panel2.Controls.Add(Me.Guna2RadioButton2)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(35, 224)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 79)
        Me.Panel2.TabIndex = 8
        '
        'Guna2RadioButton1
        '
        Me.Guna2RadioButton1.AutoSize = True
        Me.Guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton1.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2RadioButton1.Name = "Guna2RadioButton1"
        Me.Guna2RadioButton1.Size = New System.Drawing.Size(167, 25)
        Me.Guna2RadioButton1.TabIndex = 6
        Me.Guna2RadioButton1.Text = "07:00 am (Morning)"
        Me.Guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton1.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UseVisualStyleBackColor = True
        '
        'Guna2RadioButton3
        '
        Me.Guna2RadioButton3.AutoSize = True
        Me.Guna2RadioButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton3.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton3.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton3.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton3.Location = New System.Drawing.Point(3, 51)
        Me.Guna2RadioButton3.Name = "Guna2RadioButton3"
        Me.Guna2RadioButton3.Size = New System.Drawing.Size(163, 25)
        Me.Guna2RadioButton3.TabIndex = 6
        Me.Guna2RadioButton3.Text = "06:00 pm (Evening)"
        Me.Guna2RadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton3.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton3.UseVisualStyleBackColor = True
        '
        'Guna2RadioButton2
        '
        Me.Guna2RadioButton2.AutoSize = True
        Me.Guna2RadioButton2.Checked = True
        Me.Guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton2.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton2.Location = New System.Drawing.Point(3, 27)
        Me.Guna2RadioButton2.Name = "Guna2RadioButton2"
        Me.Guna2RadioButton2.Size = New System.Drawing.Size(178, 25)
        Me.Guna2RadioButton2.TabIndex = 6
        Me.Guna2RadioButton2.TabStop = True
        Me.Guna2RadioButton2.Text = "12:00 pm (Afternoon)"
        Me.Guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton2.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UseVisualStyleBackColor = True
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2DateTimePicker1.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2DateTimePicker1.BorderThickness = 1
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(35, 181)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(446, 37)
        Me.Guna2DateTimePicker1.TabIndex = 2
        Me.Guna2DateTimePicker1.Value = New Date(2020, 12, 4, 13, 44, 45, 554)
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
        Me.TextName.Location = New System.Drawing.Point(35, 99)
        Me.TextName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextName.Name = "TextName"
        Me.TextName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextName.PlaceholderText = ""
        Me.TextName.SelectedText = ""
        Me.TextName.ShadowDecoration.Parent = Me.TextName
        Me.TextName.Size = New System.Drawing.Size(446, 36)
        Me.TextName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "End Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(79, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(324, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Note: You Can not manually Stop the Election"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Election Name"
        '
        'ErrorPassword
        '
        Me.ErrorPassword.AutoSize = True
        Me.ErrorPassword.BackColor = System.Drawing.Color.Transparent
        Me.ErrorPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorPassword.ForeColor = System.Drawing.Color.Red
        Me.ErrorPassword.Location = New System.Drawing.Point(35, 384)
        Me.ErrorPassword.Name = "ErrorPassword"
        Me.ErrorPassword.Size = New System.Drawing.Size(0, 13)
        Me.ErrorPassword.TabIndex = 22
        '
        'BackgroundWorkerStartElection
        '
        '
        'StartElection1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "StartElection1"
        Me.Size = New System.Drawing.Size(519, 528)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton3 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents TextPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LabelLoading As System.Windows.Forms.Label
    Friend WithEvents Guna2WinProgressIndicator1 As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorName As System.Windows.Forms.Label
    Friend WithEvents ErrorPassword As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorkerStartElection As System.ComponentModel.BackgroundWorker

End Class
