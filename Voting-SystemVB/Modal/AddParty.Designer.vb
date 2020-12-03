<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddParty
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
        Me.GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.ButtonClear = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBPresident = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TextName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TextDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBVicePresident = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBSecretary = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBAuditor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBTreasurer = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBPRO = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2WinProgressIndicator1 = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelLoading = New System.Windows.Forms.Label()
        Me.BackgroundWorkerFetchCandidate = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorName = New System.Windows.Forms.Label()
        Me.BackgroundWorkerSave = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ErrorName)
        Me.GroupBox1.Controls.Add(Me.Guna2WinProgressIndicator1)
        Me.GroupBox1.Controls.Add(Me.ButtonDiscard)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.TextDescription)
        Me.GroupBox1.Controls.Add(Me.TextName)
        Me.GroupBox1.Controls.Add(Me.CBTreasurer)
        Me.GroupBox1.Controls.Add(Me.LabelLoading)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CBPRO)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CBAuditor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CBSecretary)
        Me.GroupBox1.Controls.Add(Me.CBVicePresident)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CBPresident)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.Guna2PictureBox1)
        Me.GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.ShadowDecoration.Parent = Me.GroupBox1
        Me.GroupBox1.Size = New System.Drawing.Size(847, 555)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.Tag = "6"
        Me.GroupBox1.Text = "Add Party"
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
        Me.ButtonClear.Location = New System.Drawing.Point(21, 212)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.ShadowDecoration.Parent = Me.ButtonClear
        Me.ButtonClear.Size = New System.Drawing.Size(220, 27)
        Me.ButtonClear.TabIndex = 11
        Me.ButtonClear.Text = "Clear Picture"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(257, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "President"
        '
        'CBPresident
        '
        Me.CBPresident.BackColor = System.Drawing.Color.Transparent
        Me.CBPresident.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBPresident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPresident.FocusedColor = System.Drawing.Color.Empty
        Me.CBPresident.FocusedState.Parent = Me.CBPresident
        Me.CBPresident.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBPresident.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBPresident.FormattingEnabled = True
        Me.CBPresident.HoverState.Parent = Me.CBPresident
        Me.CBPresident.ItemHeight = 30
        Me.CBPresident.ItemsAppearance.Parent = Me.CBPresident
        Me.CBPresident.Location = New System.Drawing.Point(261, 81)
        Me.CBPresident.Name = "CBPresident"
        Me.CBPresident.ShadowDecoration.Parent = Me.CBPresident
        Me.CBPresident.Size = New System.Drawing.Size(554, 36)
        Me.CBPresident.TabIndex = 15
        Me.CBPresident.Tag = "1"
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
        Me.TextName.Location = New System.Drawing.Point(21, 283)
        Me.TextName.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextName.Name = "TextName"
        Me.TextName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextName.PlaceholderText = ""
        Me.TextName.SelectedText = ""
        Me.TextName.ShadowDecoration.Parent = Me.TextName
        Me.TextName.Size = New System.Drawing.Size(220, 36)
        Me.TextName.TabIndex = 16
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(21, 57)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(220, 149)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'TextDescription
        '
        Me.TextDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextDescription.DefaultText = ""
        Me.TextDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextDescription.DisabledState.Parent = Me.TextDescription
        Me.TextDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextDescription.FocusedState.Parent = Me.TextDescription
        Me.TextDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextDescription.HoverState.Parent = Me.TextDescription
        Me.TextDescription.Location = New System.Drawing.Point(21, 370)
        Me.TextDescription.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextDescription.Multiline = True
        Me.TextDescription.Name = "TextDescription"
        Me.TextDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextDescription.PlaceholderText = ""
        Me.TextDescription.SelectedText = ""
        Me.TextDescription.ShadowDecoration.Parent = Me.TextDescription
        Me.TextDescription.Size = New System.Drawing.Size(220, 121)
        Me.TextDescription.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(257, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Vice President"
        '
        'CBVicePresident
        '
        Me.CBVicePresident.BackColor = System.Drawing.Color.Transparent
        Me.CBVicePresident.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBVicePresident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBVicePresident.FocusedColor = System.Drawing.Color.Empty
        Me.CBVicePresident.FocusedState.Parent = Me.CBVicePresident
        Me.CBVicePresident.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBVicePresident.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBVicePresident.FormattingEnabled = True
        Me.CBVicePresident.HoverState.Parent = Me.CBVicePresident
        Me.CBVicePresident.ItemHeight = 30
        Me.CBVicePresident.ItemsAppearance.Parent = Me.CBVicePresident
        Me.CBVicePresident.Location = New System.Drawing.Point(261, 151)
        Me.CBVicePresident.Name = "CBVicePresident"
        Me.CBVicePresident.ShadowDecoration.Parent = Me.CBVicePresident
        Me.CBVicePresident.Size = New System.Drawing.Size(554, 36)
        Me.CBVicePresident.TabIndex = 15
        Me.CBVicePresident.Tag = "2"
        '
        'CBSecretary
        '
        Me.CBSecretary.BackColor = System.Drawing.Color.Transparent
        Me.CBSecretary.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBSecretary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSecretary.FocusedColor = System.Drawing.Color.Empty
        Me.CBSecretary.FocusedState.Parent = Me.CBSecretary
        Me.CBSecretary.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBSecretary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBSecretary.FormattingEnabled = True
        Me.CBSecretary.HoverState.Parent = Me.CBSecretary
        Me.CBSecretary.ItemHeight = 30
        Me.CBSecretary.ItemsAppearance.Parent = Me.CBSecretary
        Me.CBSecretary.Location = New System.Drawing.Point(261, 227)
        Me.CBSecretary.Name = "CBSecretary"
        Me.CBSecretary.ShadowDecoration.Parent = Me.CBSecretary
        Me.CBSecretary.Size = New System.Drawing.Size(554, 36)
        Me.CBSecretary.TabIndex = 15
        Me.CBSecretary.Tag = "3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(257, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Auditor"
        '
        'CBAuditor
        '
        Me.CBAuditor.BackColor = System.Drawing.Color.Transparent
        Me.CBAuditor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBAuditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAuditor.FocusedColor = System.Drawing.Color.Empty
        Me.CBAuditor.FocusedState.Parent = Me.CBAuditor
        Me.CBAuditor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBAuditor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBAuditor.FormattingEnabled = True
        Me.CBAuditor.HoverState.Parent = Me.CBAuditor
        Me.CBAuditor.ItemHeight = 30
        Me.CBAuditor.ItemsAppearance.Parent = Me.CBAuditor
        Me.CBAuditor.Location = New System.Drawing.Point(261, 370)
        Me.CBAuditor.Name = "CBAuditor"
        Me.CBAuditor.ShadowDecoration.Parent = Me.CBAuditor
        Me.CBAuditor.Size = New System.Drawing.Size(554, 36)
        Me.CBAuditor.TabIndex = 15
        Me.CBAuditor.Tag = "5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(257, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Treasurer"
        '
        'CBTreasurer
        '
        Me.CBTreasurer.BackColor = System.Drawing.Color.Transparent
        Me.CBTreasurer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBTreasurer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTreasurer.FocusedColor = System.Drawing.Color.Empty
        Me.CBTreasurer.FocusedState.Parent = Me.CBTreasurer
        Me.CBTreasurer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBTreasurer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBTreasurer.FormattingEnabled = True
        Me.CBTreasurer.HoverState.Parent = Me.CBTreasurer
        Me.CBTreasurer.ItemHeight = 30
        Me.CBTreasurer.ItemsAppearance.Parent = Me.CBTreasurer
        Me.CBTreasurer.Location = New System.Drawing.Point(261, 299)
        Me.CBTreasurer.Name = "CBTreasurer"
        Me.CBTreasurer.ShadowDecoration.Parent = Me.CBTreasurer
        Me.CBTreasurer.Size = New System.Drawing.Size(554, 36)
        Me.CBTreasurer.TabIndex = 15
        Me.CBTreasurer.Tag = "4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(257, 431)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 21)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "P.R.O."
        '
        'CBPRO
        '
        Me.CBPRO.BackColor = System.Drawing.Color.Transparent
        Me.CBPRO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBPRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPRO.FocusedColor = System.Drawing.Color.Empty
        Me.CBPRO.FocusedState.Parent = Me.CBPRO
        Me.CBPRO.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBPRO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBPRO.FormattingEnabled = True
        Me.CBPRO.HoverState.Parent = Me.CBPRO
        Me.CBPRO.ItemHeight = 30
        Me.CBPRO.ItemsAppearance.Parent = Me.CBPRO
        Me.CBPRO.Location = New System.Drawing.Point(261, 455)
        Me.CBPRO.Name = "CBPRO"
        Me.CBPRO.ShadowDecoration.Parent = Me.CBPRO
        Me.CBPRO.Size = New System.Drawing.Size(554, 36)
        Me.CBPRO.TabIndex = 15
        Me.CBPRO.Tag = "6"
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
        Me.ButtonDiscard.Location = New System.Drawing.Point(586, 514)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(85, 24)
        Me.ButtonDiscard.TabIndex = 18
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
        Me.ButtonSave.Location = New System.Drawing.Point(683, 507)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.ShadowDecoration.Parent = Me.ButtonSave
        Me.ButtonSave.Size = New System.Drawing.Size(132, 37)
        Me.ButtonSave.TabIndex = 19
        Me.ButtonSave.Text = "Save"
        '
        'Guna2WinProgressIndicator1
        '
        Me.Guna2WinProgressIndicator1.CircleSize = 0.01!
        Me.Guna2WinProgressIndicator1.Location = New System.Drawing.Point(21, 514)
        Me.Guna2WinProgressIndicator1.Name = "Guna2WinProgressIndicator1"
        Me.Guna2WinProgressIndicator1.Size = New System.Drawing.Size(30, 30)
        Me.Guna2WinProgressIndicator1.TabIndex = 0
        Me.Guna2WinProgressIndicator1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(257, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Secretary"
        '
        'LabelLoading
        '
        Me.LabelLoading.AutoSize = True
        Me.LabelLoading.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoading.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelLoading.ForeColor = System.Drawing.Color.Black
        Me.LabelLoading.Location = New System.Drawing.Point(57, 517)
        Me.LabelLoading.Name = "LabelLoading"
        Me.LabelLoading.Size = New System.Drawing.Size(96, 21)
        Me.LabelLoading.TabIndex = 14
        Me.LabelLoading.Text = "Please wait..."
        Me.LabelLoading.Visible = False
        '
        'BackgroundWorkerFetchCandidate
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPG(*.JPG)|*.jpg"
        '
        'ErrorName
        '
        Me.ErrorName.AutoSize = True
        Me.ErrorName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorName.ForeColor = System.Drawing.Color.Red
        Me.ErrorName.Location = New System.Drawing.Point(18, 322)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.Size = New System.Drawing.Size(0, 13)
        Me.ErrorName.TabIndex = 20
        '
        'BackgroundWorkerSave
        '
        '
        'AddParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddParty"
        Me.Size = New System.Drawing.Size(847, 555)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ButtonClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBPresident As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBTreasurer As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBPRO As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBAuditor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBSecretary As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBVicePresident As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2WinProgressIndicator1 As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents LabelLoading As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorkerFetchCandidate As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ErrorName As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorkerSave As System.ComponentModel.BackgroundWorker

End Class
