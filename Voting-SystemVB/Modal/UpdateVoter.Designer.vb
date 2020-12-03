<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateVoter
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBSection = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ErrorSection = New System.Windows.Forms.Label()
        Me.ErrorYear = New System.Windows.Forms.Label()
        Me.CBCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ErrorCourse = New System.Windows.Forms.Label()
        Me.CBYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ErrorLastname = New System.Windows.Forms.Label()
        Me.TextLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ErrorFirstname = New System.Windows.Forms.Label()
        Me.TextFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ErrorStudentID = New System.Windows.Forms.Label()
        Me.TextStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonUpdateCandidate = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonRegisterCandidate = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.BackgroundWorkerUpdate = New System.ComponentModel.BackgroundWorker()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.Panel3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator3)
        Me.Guna2GroupBox1.Controls.Add(Me.Panel2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(614, 531)
        Me.Guna2GroupBox1.TabIndex = 1
        Me.Guna2GroupBox1.Text = "Update Voter"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Guna2Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(614, 423)
        Me.Panel3.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.CBSection)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.ErrorSection)
        Me.Guna2Panel1.Controls.Add(Me.ErrorYear)
        Me.Guna2Panel1.Controls.Add(Me.CBCourse)
        Me.Guna2Panel1.Controls.Add(Me.ErrorCourse)
        Me.Guna2Panel1.Controls.Add(Me.CBYear)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.ErrorLastname)
        Me.Guna2Panel1.Controls.Add(Me.TextLastname)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.ErrorFirstname)
        Me.Guna2Panel1.Controls.Add(Me.TextFirstname)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.ErrorStudentID)
        Me.Guna2Panel1.Controls.Add(Me.TextStudentID)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(590, 654)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(22, 567)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(73, 27)
        Me.Guna2HtmlLabel7.TabIndex = 5
        Me.Guna2HtmlLabel7.Text = "Section<font color=""red"">*</font>"
        '
        'CBSection
        '
        Me.CBSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBSection.Animated = True
        Me.CBSection.BackColor = System.Drawing.Color.Transparent
        Me.CBSection.BorderRadius = 5
        Me.CBSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSection.FocusedColor = System.Drawing.Color.Empty
        Me.CBSection.FocusedState.Parent = Me.CBSection
        Me.CBSection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBSection.FormattingEnabled = True
        Me.CBSection.HoverState.Parent = Me.CBSection
        Me.CBSection.ItemHeight = 30
        Me.CBSection.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CBSection.ItemsAppearance.Parent = Me.CBSection
        Me.CBSection.Location = New System.Drawing.Point(22, 600)
        Me.CBSection.Name = "CBSection"
        Me.CBSection.ShadowDecoration.Parent = Me.CBSection
        Me.CBSection.Size = New System.Drawing.Size(545, 36)
        Me.CBSection.TabIndex = 5
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(22, 460)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(70, 27)
        Me.Guna2HtmlLabel6.TabIndex = 5
        Me.Guna2HtmlLabel6.Text = "Course<font color=""red"">*</font>"
        '
        'ErrorSection
        '
        Me.ErrorSection.AutoSize = True
        Me.ErrorSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorSection.ForeColor = System.Drawing.Color.Red
        Me.ErrorSection.Location = New System.Drawing.Point(22, 639)
        Me.ErrorSection.Name = "ErrorSection"
        Me.ErrorSection.Size = New System.Drawing.Size(0, 13)
        Me.ErrorSection.TabIndex = 11
        '
        'ErrorYear
        '
        Me.ErrorYear.AutoSize = True
        Me.ErrorYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorYear.ForeColor = System.Drawing.Color.Red
        Me.ErrorYear.Location = New System.Drawing.Point(19, 424)
        Me.ErrorYear.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.ErrorYear.Name = "ErrorYear"
        Me.ErrorYear.Size = New System.Drawing.Size(0, 13)
        Me.ErrorYear.TabIndex = 9
        '
        'CBCourse
        '
        Me.CBCourse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBCourse.Animated = True
        Me.CBCourse.BackColor = System.Drawing.Color.Transparent
        Me.CBCourse.BorderRadius = 5
        Me.CBCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCourse.FocusedColor = System.Drawing.Color.Empty
        Me.CBCourse.FocusedState.Parent = Me.CBCourse
        Me.CBCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBCourse.FormattingEnabled = True
        Me.CBCourse.HoverState.Parent = Me.CBCourse
        Me.CBCourse.ItemHeight = 30
        Me.CBCourse.Items.AddRange(New Object() {"BSCS", "BSIT", "BSIS", "BSEMC"})
        Me.CBCourse.ItemsAppearance.Parent = Me.CBCourse
        Me.CBCourse.Location = New System.Drawing.Point(22, 493)
        Me.CBCourse.Name = "CBCourse"
        Me.CBCourse.ShadowDecoration.Parent = Me.CBCourse
        Me.CBCourse.Size = New System.Drawing.Size(545, 36)
        Me.CBCourse.TabIndex = 4
        '
        'ErrorCourse
        '
        Me.ErrorCourse.AutoSize = True
        Me.ErrorCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorCourse.ForeColor = System.Drawing.Color.Red
        Me.ErrorCourse.Location = New System.Drawing.Point(22, 532)
        Me.ErrorCourse.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.ErrorCourse.Name = "ErrorCourse"
        Me.ErrorCourse.Size = New System.Drawing.Size(0, 13)
        Me.ErrorCourse.TabIndex = 10
        '
        'CBYear
        '
        Me.CBYear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBYear.Animated = True
        Me.CBYear.BackColor = System.Drawing.Color.Transparent
        Me.CBYear.BorderRadius = 5
        Me.CBYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBYear.FocusedColor = System.Drawing.Color.Empty
        Me.CBYear.FocusedState.Parent = Me.CBYear
        Me.CBYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBYear.FormattingEnabled = True
        Me.CBYear.HoverState.Parent = Me.CBYear
        Me.CBYear.ItemHeight = 30
        Me.CBYear.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.CBYear.ItemsAppearance.Parent = Me.CBYear
        Me.CBYear.Location = New System.Drawing.Point(22, 385)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.ShadowDecoration.Parent = Me.CBYear
        Me.CBYear.Size = New System.Drawing.Size(545, 36)
        Me.CBYear.TabIndex = 3
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(22, 355)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(97, 27)
        Me.Guna2HtmlLabel5.TabIndex = 5
        Me.Guna2HtmlLabel5.Text = "Year Level<font color=""red"">*</font>"
        '
        'ErrorLastname
        '
        Me.ErrorLastname.AutoSize = True
        Me.ErrorLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorLastname.ForeColor = System.Drawing.Color.Red
        Me.ErrorLastname.Location = New System.Drawing.Point(19, 320)
        Me.ErrorLastname.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.ErrorLastname.Name = "ErrorLastname"
        Me.ErrorLastname.Size = New System.Drawing.Size(0, 13)
        Me.ErrorLastname.TabIndex = 8
        '
        'TextLastname
        '
        Me.TextLastname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextLastname.Animated = True
        Me.TextLastname.BorderRadius = 5
        Me.TextLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextLastname.DefaultText = ""
        Me.TextLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextLastname.DisabledState.Parent = Me.TextLastname
        Me.TextLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextLastname.FocusedState.Parent = Me.TextLastname
        Me.TextLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextLastname.HoverState.Parent = Me.TextLastname
        Me.TextLastname.Location = New System.Drawing.Point(22, 275)
        Me.TextLastname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TextLastname.Name = "TextLastname"
        Me.TextLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextLastname.PlaceholderText = "(e.g. John)"
        Me.TextLastname.SelectedText = ""
        Me.TextLastname.ShadowDecoration.Parent = Me.TextLastname
        Me.TextLastname.Size = New System.Drawing.Size(545, 35)
        Me.TextLastname.TabIndex = 2
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(22, 245)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(91, 27)
        Me.Guna2HtmlLabel4.TabIndex = 5
        Me.Guna2HtmlLabel4.Text = "Lastname<font color=""red"">*</font>"
        '
        'ErrorFirstname
        '
        Me.ErrorFirstname.AutoSize = True
        Me.ErrorFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorFirstname.ForeColor = System.Drawing.Color.Red
        Me.ErrorFirstname.Location = New System.Drawing.Point(19, 207)
        Me.ErrorFirstname.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.ErrorFirstname.Name = "ErrorFirstname"
        Me.ErrorFirstname.Size = New System.Drawing.Size(0, 13)
        Me.ErrorFirstname.TabIndex = 7
        '
        'TextFirstname
        '
        Me.TextFirstname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextFirstname.Animated = True
        Me.TextFirstname.BorderRadius = 5
        Me.TextFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextFirstname.DefaultText = ""
        Me.TextFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextFirstname.DisabledState.Parent = Me.TextFirstname
        Me.TextFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFirstname.FocusedState.Parent = Me.TextFirstname
        Me.TextFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFirstname.HoverState.Parent = Me.TextFirstname
        Me.TextFirstname.Location = New System.Drawing.Point(22, 162)
        Me.TextFirstname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TextFirstname.Name = "TextFirstname"
        Me.TextFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextFirstname.PlaceholderText = "(e.g. John)"
        Me.TextFirstname.SelectedText = ""
        Me.TextFirstname.ShadowDecoration.Parent = Me.TextFirstname
        Me.TextFirstname.Size = New System.Drawing.Size(545, 41)
        Me.TextFirstname.TabIndex = 1
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(22, 132)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(93, 27)
        Me.Guna2HtmlLabel3.TabIndex = 5
        Me.Guna2HtmlLabel3.Text = "Firstname<font color=""red"">*</font>"
        '
        'ErrorStudentID
        '
        Me.ErrorStudentID.AutoSize = True
        Me.ErrorStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorStudentID.ForeColor = System.Drawing.Color.Red
        Me.ErrorStudentID.Location = New System.Drawing.Point(19, 98)
        Me.ErrorStudentID.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.ErrorStudentID.Name = "ErrorStudentID"
        Me.ErrorStudentID.Size = New System.Drawing.Size(0, 13)
        Me.ErrorStudentID.TabIndex = 6
        '
        'TextStudentID
        '
        Me.TextStudentID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextStudentID.Animated = True
        Me.TextStudentID.BorderRadius = 5
        Me.TextStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextStudentID.DefaultText = ""
        Me.TextStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextStudentID.DisabledState.Parent = Me.TextStudentID
        Me.TextStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextStudentID.FocusedState.Parent = Me.TextStudentID
        Me.TextStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextStudentID.HoverState.Parent = Me.TextStudentID
        Me.TextStudentID.Location = New System.Drawing.Point(22, 53)
        Me.TextStudentID.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TextStudentID.Name = "TextStudentID"
        Me.TextStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextStudentID.PlaceholderText = "(e.g. 20200000-C)"
        Me.TextStudentID.SelectedText = ""
        Me.TextStudentID.ShadowDecoration.Parent = Me.TextStudentID
        Me.TextStudentID.Size = New System.Drawing.Size(545, 43)
        Me.TextStudentID.TabIndex = 0
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(22, 23)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(99, 27)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "Student ID<font color=""red"">*</font>"
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Separator3.Location = New System.Drawing.Point(0, 471)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(614, 10)
        Me.Guna2Separator3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 481)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(614, 50)
        Me.Panel2.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonSubmit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonUpdateCandidate)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonRegisterCandidate)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonDiscard)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(614, 50)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSubmit.Animated = True
        Me.ButtonSubmit.CheckedState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.CustomImages.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ButtonSubmit.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.White
        Me.ButtonSubmit.HoverState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonSubmit.ImageOffset = New System.Drawing.Point(1, 1)
        Me.ButtonSubmit.ImageSize = New System.Drawing.Size(15, 15)
        Me.ButtonSubmit.Location = New System.Drawing.Point(475, 6)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.ShadowDecoration.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Size = New System.Drawing.Size(118, 38)
        Me.ButtonSubmit.TabIndex = 0
        Me.ButtonSubmit.Text = "Submit"
        '
        'ButtonUpdateCandidate
        '
        Me.ButtonUpdateCandidate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonUpdateCandidate.Animated = True
        Me.ButtonUpdateCandidate.BorderColor = System.Drawing.Color.Gray
        Me.ButtonUpdateCandidate.BorderThickness = 1
        Me.ButtonUpdateCandidate.CheckedState.Parent = Me.ButtonUpdateCandidate
        Me.ButtonUpdateCandidate.CustomImages.Parent = Me.ButtonUpdateCandidate
        Me.ButtonUpdateCandidate.FillColor = System.Drawing.Color.White
        Me.ButtonUpdateCandidate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonUpdateCandidate.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonUpdateCandidate.HoverState.Parent = Me.ButtonUpdateCandidate
        Me.ButtonUpdateCandidate.Location = New System.Drawing.Point(298, 6)
        Me.ButtonUpdateCandidate.Name = "ButtonUpdateCandidate"
        Me.ButtonUpdateCandidate.ShadowDecoration.Parent = Me.ButtonUpdateCandidate
        Me.ButtonUpdateCandidate.Size = New System.Drawing.Size(171, 38)
        Me.ButtonUpdateCandidate.TabIndex = 2
        Me.ButtonUpdateCandidate.Text = "Update Candidate Info"
        Me.ButtonUpdateCandidate.Visible = False
        '
        'ButtonRegisterCandidate
        '
        Me.ButtonRegisterCandidate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRegisterCandidate.Animated = True
        Me.ButtonRegisterCandidate.BorderColor = System.Drawing.Color.Gray
        Me.ButtonRegisterCandidate.BorderThickness = 1
        Me.ButtonRegisterCandidate.CheckedState.Parent = Me.ButtonRegisterCandidate
        Me.ButtonRegisterCandidate.CustomImages.Parent = Me.ButtonRegisterCandidate
        Me.ButtonRegisterCandidate.FillColor = System.Drawing.Color.White
        Me.ButtonRegisterCandidate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonRegisterCandidate.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonRegisterCandidate.HoverState.Parent = Me.ButtonRegisterCandidate
        Me.ButtonRegisterCandidate.Location = New System.Drawing.Point(151, 6)
        Me.ButtonRegisterCandidate.Name = "ButtonRegisterCandidate"
        Me.ButtonRegisterCandidate.ShadowDecoration.Parent = Me.ButtonRegisterCandidate
        Me.ButtonRegisterCandidate.Size = New System.Drawing.Size(141, 38)
        Me.ButtonRegisterCandidate.TabIndex = 3
        Me.ButtonRegisterCandidate.Text = "Register Candidate"
        Me.ButtonRegisterCandidate.Visible = False
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.Transparent
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(43, 13)
        Me.ButtonDiscard.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(102, 23)
        Me.ButtonDiscard.TabIndex = 1
        Me.ButtonDiscard.Text = "Discard"
        '
        'BackgroundWorkerUpdate
        '
        '
        'UpdateVoter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "UpdateVoter"
        Me.Size = New System.Drawing.Size(614, 531)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CBSection As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ErrorSection As System.Windows.Forms.Label
    Friend WithEvents ErrorYear As System.Windows.Forms.Label
    Friend WithEvents CBCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ErrorCourse As System.Windows.Forms.Label
    Friend WithEvents CBYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ErrorLastname As System.Windows.Forms.Label
    Friend WithEvents TextLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ErrorFirstname As System.Windows.Forms.Label
    Friend WithEvents TextFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ErrorStudentID As System.Windows.Forms.Label
    Friend WithEvents TextStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BackgroundWorkerUpdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonUpdateCandidate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonRegisterCandidate As Guna.UI2.WinForms.Guna2Button

End Class
