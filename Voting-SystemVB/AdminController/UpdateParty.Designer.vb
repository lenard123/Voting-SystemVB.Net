<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateParty
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextDesccription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CBPRO = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBAuditor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBTreasurer = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBSecretary = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBVicePresident = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBPresident = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSave = New Guna.UI2.WinForms.Guna2Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonClear = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSelectPicture = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.TextDesccription)
        Me.Panel1.Controls.Add(Me.CBPRO)
        Me.Panel1.Controls.Add(Me.CBAuditor)
        Me.Panel1.Controls.Add(Me.CBTreasurer)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CBSecretary)
        Me.Panel1.Controls.Add(Me.CBVicePresident)
        Me.Panel1.Controls.Add(Me.CBPresident)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextName)
        Me.Panel1.Controls.Add(Me.ErrorName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(217, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 385)
        Me.Panel1.TabIndex = 14
        '
        'TextDesccription
        '
        Me.TextDesccription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextDesccription.BorderRadius = 5
        Me.TextDesccription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextDesccription.DefaultText = ""
        Me.TextDesccription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextDesccription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextDesccription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextDesccription.DisabledState.Parent = Me.TextDesccription
        Me.TextDesccription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextDesccription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextDesccription.FocusedState.Parent = Me.TextDesccription
        Me.TextDesccription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextDesccription.HoverState.Parent = Me.TextDesccription
        Me.TextDesccription.Location = New System.Drawing.Point(23, 113)
        Me.TextDesccription.Name = "TextDesccription"
        Me.TextDesccription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextDesccription.PlaceholderText = ""
        Me.TextDesccription.SelectedText = ""
        Me.TextDesccription.ShadowDecoration.Parent = Me.TextDesccription
        Me.TextDesccription.Size = New System.Drawing.Size(604, 36)
        Me.TextDesccription.TabIndex = 12
        '
        'CBPRO
        '
        Me.CBPRO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBPRO.BackColor = System.Drawing.Color.Transparent
        Me.CBPRO.BorderRadius = 5
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
        Me.CBPRO.Location = New System.Drawing.Point(23, 617)
        Me.CBPRO.Name = "CBPRO"
        Me.CBPRO.ShadowDecoration.Parent = Me.CBPRO
        Me.CBPRO.Size = New System.Drawing.Size(604, 36)
        Me.CBPRO.TabIndex = 13
        '
        'CBAuditor
        '
        Me.CBAuditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBAuditor.BackColor = System.Drawing.Color.Transparent
        Me.CBAuditor.BorderRadius = 5
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
        Me.CBAuditor.Location = New System.Drawing.Point(23, 533)
        Me.CBAuditor.Name = "CBAuditor"
        Me.CBAuditor.ShadowDecoration.Parent = Me.CBAuditor
        Me.CBAuditor.Size = New System.Drawing.Size(604, 36)
        Me.CBAuditor.TabIndex = 13
        '
        'CBTreasurer
        '
        Me.CBTreasurer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBTreasurer.BackColor = System.Drawing.Color.Transparent
        Me.CBTreasurer.BorderRadius = 5
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
        Me.CBTreasurer.Location = New System.Drawing.Point(23, 445)
        Me.CBTreasurer.Name = "CBTreasurer"
        Me.CBTreasurer.ShadowDecoration.Parent = Me.CBTreasurer
        Me.CBTreasurer.Size = New System.Drawing.Size(604, 36)
        Me.CBTreasurer.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(18, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Description"
        '
        'CBSecretary
        '
        Me.CBSecretary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBSecretary.BackColor = System.Drawing.Color.Transparent
        Me.CBSecretary.BorderRadius = 5
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
        Me.CBSecretary.Location = New System.Drawing.Point(23, 359)
        Me.CBSecretary.Name = "CBSecretary"
        Me.CBSecretary.ShadowDecoration.Parent = Me.CBSecretary
        Me.CBSecretary.Size = New System.Drawing.Size(604, 36)
        Me.CBSecretary.TabIndex = 13
        '
        'CBVicePresident
        '
        Me.CBVicePresident.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBVicePresident.BackColor = System.Drawing.Color.Transparent
        Me.CBVicePresident.BorderRadius = 5
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
        Me.CBVicePresident.Location = New System.Drawing.Point(23, 279)
        Me.CBVicePresident.Name = "CBVicePresident"
        Me.CBVicePresident.ShadowDecoration.Parent = Me.CBVicePresident
        Me.CBVicePresident.Size = New System.Drawing.Size(604, 36)
        Me.CBVicePresident.TabIndex = 13
        '
        'CBPresident
        '
        Me.CBPresident.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBPresident.BackColor = System.Drawing.Color.Transparent
        Me.CBPresident.BorderRadius = 5
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
        Me.CBPresident.Location = New System.Drawing.Point(23, 195)
        Me.CBPresident.Name = "CBPresident"
        Me.CBPresident.ShadowDecoration.Parent = Me.CBPresident
        Me.CBPresident.Size = New System.Drawing.Size(604, 36)
        Me.CBPresident.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(18, 589)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 25)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "P.R.O."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label8.Location = New System.Drawing.Point(18, 505)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Auditor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label7.Location = New System.Drawing.Point(18, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Treasurer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(18, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Secretary"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(18, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Vice President"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(18, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "President"
        '
        'TextName
        '
        Me.TextName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextName.BorderRadius = 5
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
        Me.TextName.Location = New System.Drawing.Point(23, 32)
        Me.TextName.Name = "TextName"
        Me.TextName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextName.PlaceholderText = ""
        Me.TextName.SelectedText = ""
        Me.TextName.ShadowDecoration.Parent = Me.TextName
        Me.TextName.Size = New System.Drawing.Size(604, 36)
        Me.TextName.TabIndex = 12
        '
        'ErrorName
        '
        Me.ErrorName.AutoSize = True
        Me.ErrorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorName.ForeColor = System.Drawing.Color.Red
        Me.ErrorName.Location = New System.Drawing.Point(219, 106)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.Size = New System.Drawing.Size(0, 13)
        Me.ErrorName.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(18, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Party Name*"
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.BorderThickness = 1
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.White
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Black
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(24, 296)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(187, 45)
        Me.ButtonDiscard.TabIndex = 14
        Me.ButtonDiscard.Text = "Discard"
        '
        'ButtonSave
        '
        Me.ButtonSave.CheckedState.Parent = Me.ButtonSave
        Me.ButtonSave.CustomImages.Parent = Me.ButtonSave
        Me.ButtonSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ButtonSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.HoverState.Parent = Me.ButtonSave
        Me.ButtonSave.Location = New System.Drawing.Point(24, 245)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.ShadowDecoration.Parent = Me.ButtonSave
        Me.ButtonSave.Size = New System.Drawing.Size(187, 45)
        Me.ButtonSave.TabIndex = 14
        Me.ButtonSave.Text = "Update"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitle.Location = New System.Drawing.Point(19, 24)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(152, 30)
        Me.LabelTitle.TabIndex = 8
        Me.LabelTitle.Text = "Update Party"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Location = New System.Drawing.Point(24, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ButtonClear
        '
        Me.ButtonClear.CheckedState.Parent = Me.ButtonClear
        Me.ButtonClear.CustomImages.Parent = Me.ButtonClear
        Me.ButtonClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ButtonClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.HoverState.Parent = Me.ButtonClear
        Me.ButtonClear.Location = New System.Drawing.Point(121, 207)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.ShadowDecoration.Parent = Me.ButtonClear
        Me.ButtonClear.Size = New System.Drawing.Size(90, 27)
        Me.ButtonClear.TabIndex = 10
        Me.ButtonClear.Text = "Clear Picture"
        '
        'ButtonSelectPicture
        '
        Me.ButtonSelectPicture.CheckedState.Parent = Me.ButtonSelectPicture
        Me.ButtonSelectPicture.CustomImages.Parent = Me.ButtonSelectPicture
        Me.ButtonSelectPicture.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSelectPicture.ForeColor = System.Drawing.Color.White
        Me.ButtonSelectPicture.HoverState.Parent = Me.ButtonSelectPicture
        Me.ButtonSelectPicture.Location = New System.Drawing.Point(24, 207)
        Me.ButtonSelectPicture.Name = "ButtonSelectPicture"
        Me.ButtonSelectPicture.ShadowDecoration.Parent = Me.ButtonSelectPicture
        Me.ButtonSelectPicture.Size = New System.Drawing.Size(91, 27)
        Me.ButtonSelectPicture.TabIndex = 10
        Me.ButtonSelectPicture.Text = "Select Picture"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPG(*.JPG)|*.jpg"
        '
        'UpdateParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.ButtonSelectPicture)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonClear)
        Me.Name = "UpdateParty"
        Me.Size = New System.Drawing.Size(913, 481)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextDesccription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBPRO As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBAuditor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBTreasurer As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBSecretary As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBVicePresident As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBPresident As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonSelectPicture As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
