<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVoter
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
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.TextStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorStudentID = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TextFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorFirstname = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TextLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorLastname = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ErrorYear = New System.Windows.Forms.Label()
        Me.ErrorCourse = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ErrorSection = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBSection = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(156, 63)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "<h1>Register Voter</h1>"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Separator1.Location = New System.Drawing.Point(3, 72)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(491, 10)
        Me.Guna2Separator1.TabIndex = 1
        '
        'TextStudentID
        '
        Me.TextStudentID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.TextStudentID.Location = New System.Drawing.Point(3, 140)
        Me.TextStudentID.MaxLength = 10
        Me.TextStudentID.Name = "TextStudentID"
        Me.TextStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextStudentID.PlaceholderText = "(e.g. 20200000-C)"
        Me.TextStudentID.SelectedText = ""
        Me.TextStudentID.ShadowDecoration.Parent = Me.TextStudentID
        Me.TextStudentID.Size = New System.Drawing.Size(491, 36)
        Me.TextStudentID.TabIndex = 0
        '
        'ErrorStudentID
        '
        Me.ErrorStudentID.AutoSize = True
        Me.ErrorStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorStudentID.ForeColor = System.Drawing.Color.Red
        Me.ErrorStudentID.Location = New System.Drawing.Point(128, 226)
        Me.ErrorStudentID.Name = "ErrorStudentID"
        Me.ErrorStudentID.Size = New System.Drawing.Size(0, 13)
        Me.ErrorStudentID.TabIndex = 4
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(3, 107)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(99, 27)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "Student ID<font color=""red"">*</font>"
        '
        'TextFirstname
        '
        Me.TextFirstname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.TextFirstname.Location = New System.Drawing.Point(3, 234)
        Me.TextFirstname.MaxLength = 20
        Me.TextFirstname.Name = "TextFirstname"
        Me.TextFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextFirstname.PlaceholderText = "(e.g. John)"
        Me.TextFirstname.SelectedText = ""
        Me.TextFirstname.ShadowDecoration.Parent = Me.TextFirstname
        Me.TextFirstname.Size = New System.Drawing.Size(491, 36)
        Me.TextFirstname.TabIndex = 1
        '
        'ErrorFirstname
        '
        Me.ErrorFirstname.AutoSize = True
        Me.ErrorFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorFirstname.ForeColor = System.Drawing.Color.Red
        Me.ErrorFirstname.Location = New System.Drawing.Point(128, 324)
        Me.ErrorFirstname.Name = "ErrorFirstname"
        Me.ErrorFirstname.Size = New System.Drawing.Size(0, 13)
        Me.ErrorFirstname.TabIndex = 4
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(3, 205)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(93, 27)
        Me.Guna2HtmlLabel3.TabIndex = 5
        Me.Guna2HtmlLabel3.Text = "Firstname<font color=""red"">*</font>"
        '
        'TextLastname
        '
        Me.TextLastname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.TextLastname.Location = New System.Drawing.Point(3, 332)
        Me.TextLastname.MaxLength = 20
        Me.TextLastname.Name = "TextLastname"
        Me.TextLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextLastname.PlaceholderText = "(e.g. John)"
        Me.TextLastname.SelectedText = ""
        Me.TextLastname.ShadowDecoration.Parent = Me.TextLastname
        Me.TextLastname.Size = New System.Drawing.Size(491, 36)
        Me.TextLastname.TabIndex = 2
        '
        'ErrorLastname
        '
        Me.ErrorLastname.AutoSize = True
        Me.ErrorLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorLastname.ForeColor = System.Drawing.Color.Red
        Me.ErrorLastname.Location = New System.Drawing.Point(128, 422)
        Me.ErrorLastname.Name = "ErrorLastname"
        Me.ErrorLastname.Size = New System.Drawing.Size(0, 13)
        Me.ErrorLastname.TabIndex = 4
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(3, 303)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(91, 27)
        Me.Guna2HtmlLabel4.TabIndex = 5
        Me.Guna2HtmlLabel4.Text = "Lastname<font color=""red"">*</font>"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(3, 403)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(97, 27)
        Me.Guna2HtmlLabel5.TabIndex = 5
        Me.Guna2HtmlLabel5.Text = "Year Level<font color=""red"">*</font>"
        '
        'CBYear
        '
        Me.CBYear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.CBYear.Location = New System.Drawing.Point(3, 432)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.ShadowDecoration.Parent = Me.CBYear
        Me.CBYear.Size = New System.Drawing.Size(491, 36)
        Me.CBYear.TabIndex = 3
        '
        'ErrorYear
        '
        Me.ErrorYear.AutoSize = True
        Me.ErrorYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorYear.ForeColor = System.Drawing.Color.Red
        Me.ErrorYear.Location = New System.Drawing.Point(128, 523)
        Me.ErrorYear.Name = "ErrorYear"
        Me.ErrorYear.Size = New System.Drawing.Size(0, 13)
        Me.ErrorYear.TabIndex = 4
        '
        'ErrorCourse
        '
        Me.ErrorCourse.AutoSize = True
        Me.ErrorCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorCourse.ForeColor = System.Drawing.Color.Red
        Me.ErrorCourse.Location = New System.Drawing.Point(128, 622)
        Me.ErrorCourse.Name = "ErrorCourse"
        Me.ErrorCourse.Size = New System.Drawing.Size(0, 13)
        Me.ErrorCourse.TabIndex = 4
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(3, 502)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(70, 27)
        Me.Guna2HtmlLabel6.TabIndex = 5
        Me.Guna2HtmlLabel6.Text = "Course<font color=""red"">*</font>"
        '
        'CBCourse
        '
        Me.CBCourse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.CBCourse.Location = New System.Drawing.Point(3, 531)
        Me.CBCourse.Name = "CBCourse"
        Me.CBCourse.ShadowDecoration.Parent = Me.CBCourse
        Me.CBCourse.Size = New System.Drawing.Size(491, 36)
        Me.CBCourse.TabIndex = 4
        '
        'ErrorSection
        '
        Me.ErrorSection.AutoSize = True
        Me.ErrorSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorSection.ForeColor = System.Drawing.Color.Red
        Me.ErrorSection.Location = New System.Drawing.Point(128, 721)
        Me.ErrorSection.Name = "ErrorSection"
        Me.ErrorSection.Size = New System.Drawing.Size(0, 13)
        Me.ErrorSection.TabIndex = 4
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(3, 601)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(73, 27)
        Me.Guna2HtmlLabel7.TabIndex = 5
        Me.Guna2HtmlLabel7.Text = "Section<font color=""red"">*</font>"
        '
        'CBSection
        '
        Me.CBSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.CBSection.Location = New System.Drawing.Point(3, 630)
        Me.CBSection.Name = "CBSection"
        Me.CBSection.ShadowDecoration.Parent = Me.CBSection
        Me.CBSection.Size = New System.Drawing.Size(491, 36)
        Me.CBSection.TabIndex = 5
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Separator2.Location = New System.Drawing.Point(3, 694)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(491, 10)
        Me.Guna2Separator2.TabIndex = 7
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDiscard.BorderRadius = 5
        Me.ButtonDiscard.BorderThickness = 1
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.White
        Me.ButtonDiscard.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Black
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(248, 719)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(246, 45)
        Me.ButtonDiscard.TabIndex = 7
        Me.ButtonDiscard.Text = "Discard"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSubmit.CheckedState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.CustomImages.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ButtonSubmit.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.White
        Me.ButtonSubmit.HoverState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Image = Global.Voting_SystemVB.My.Resources.Resources.check
        Me.ButtonSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonSubmit.ImageOffset = New System.Drawing.Point(1, 1)
        Me.ButtonSubmit.Location = New System.Drawing.Point(3, 719)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.ShadowDecoration.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Size = New System.Drawing.Size(237, 45)
        Me.ButtonSubmit.TabIndex = 6
        Me.ButtonSubmit.Text = "Submit"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ButtonDiscard)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.ButtonSubmit)
        Me.Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Panel1.Controls.Add(Me.Guna2Separator2)
        Me.Panel1.Controls.Add(Me.TextStudentID)
        Me.Panel1.Controls.Add(Me.CBSection)
        Me.Panel1.Controls.Add(Me.TextFirstname)
        Me.Panel1.Controls.Add(Me.CBCourse)
        Me.Panel1.Controls.Add(Me.TextLastname)
        Me.Panel1.Controls.Add(Me.CBYear)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel1.Location = New System.Drawing.Point(11, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 785)
        Me.Panel1.TabIndex = 8
        '
        'AddVoter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ErrorSection)
        Me.Controls.Add(Me.ErrorCourse)
        Me.Controls.Add(Me.ErrorYear)
        Me.Controls.Add(Me.ErrorLastname)
        Me.Controls.Add(Me.ErrorFirstname)
        Me.Controls.Add(Me.ErrorStudentID)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddVoter"
        Me.Size = New System.Drawing.Size(527, 531)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents TextStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorStudentID As System.Windows.Forms.Label
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TextFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorFirstname As System.Windows.Forms.Label
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TextLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorLastname As System.Windows.Forms.Label
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CBYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ErrorYear As System.Windows.Forms.Label
    Friend WithEvents ErrorCourse As System.Windows.Forms.Label
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CBCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ErrorSection As System.Windows.Forms.Label
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CBSection As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents ButtonSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
