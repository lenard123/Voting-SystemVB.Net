<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadDatabase
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
        Me.OpenFileDialogDatabase = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorkerTestConnection = New System.ComponentModel.BackgroundWorker()
        Me.PanelTestConnectionLoadng = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBDatabaseType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBTables = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBStudentID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TextDBPath = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBFirstname = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBLastname = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBSection = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.ButtonImport = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonReplace = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonIgnore = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2CircleProgressBar2 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BackgroundWorkerUpload = New System.ComponentModel.BackgroundWorker()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.PanelTestConnectionLoadng.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.Panel1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(952, 579)
        Me.Guna2GroupBox1.TabIndex = 21
        Me.Guna2GroupBox1.Text = "Import Students Database"
        '
        'BackgroundWorkerTestConnection
        '
        Me.BackgroundWorkerTestConnection.WorkerReportsProgress = True
        '
        'PanelTestConnectionLoadng
        '
        Me.PanelTestConnectionLoadng.AutoSize = True
        Me.PanelTestConnectionLoadng.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTestConnectionLoadng.BackColor = System.Drawing.Color.Transparent
        Me.PanelTestConnectionLoadng.Controls.Add(Me.Guna2CircleProgressBar1)
        Me.PanelTestConnectionLoadng.Controls.Add(Me.Label3)
        Me.PanelTestConnectionLoadng.Location = New System.Drawing.Point(22, 87)
        Me.PanelTestConnectionLoadng.Name = "PanelTestConnectionLoadng"
        Me.PanelTestConnectionLoadng.Size = New System.Drawing.Size(275, 30)
        Me.PanelTestConnectionLoadng.TabIndex = 6
        Me.PanelTestConnectionLoadng.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(30, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Establashing Connection. please wait..."
        '
        'Guna2CircleProgressBar1
        '
        Me.Guna2CircleProgressBar1.Animated = True
        Me.Guna2CircleProgressBar1.FillThickness = 6
        Me.Guna2CircleProgressBar1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.ProgressThickness = 6
        Me.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar1.ShadowDecoration.Parent = Me.Guna2CircleProgressBar1
        Me.Guna2CircleProgressBar1.Size = New System.Drawing.Size(24, 24)
        Me.Guna2CircleProgressBar1.TabIndex = 4
        Me.Guna2CircleProgressBar1.Value = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(18, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Type of Database"
        '
        'CBDatabaseType
        '
        Me.CBDatabaseType.Animated = True
        Me.CBDatabaseType.BackColor = System.Drawing.Color.Transparent
        Me.CBDatabaseType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBDatabaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDatabaseType.FocusedColor = System.Drawing.Color.Empty
        Me.CBDatabaseType.FocusedState.Parent = Me.CBDatabaseType
        Me.CBDatabaseType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBDatabaseType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBDatabaseType.FormattingEnabled = True
        Me.CBDatabaseType.HoverState.Parent = Me.CBDatabaseType
        Me.CBDatabaseType.ItemHeight = 30
        Me.CBDatabaseType.Items.AddRange(New Object() {"(SELECT DATABASE TYPE)", "MS ACCESS (2002 - 2003 MDB)", "MS ACCESS (2007 ACCDB)", "MS EXCEL"})
        Me.CBDatabaseType.ItemsAppearance.Parent = Me.CBDatabaseType
        Me.CBDatabaseType.Location = New System.Drawing.Point(22, 45)
        Me.CBDatabaseType.Name = "CBDatabaseType"
        Me.CBDatabaseType.ShadowDecoration.Parent = Me.CBDatabaseType
        Me.CBDatabaseType.Size = New System.Drawing.Size(415, 36)
        Me.CBDatabaseType.StartIndex = 0
        Me.CBDatabaseType.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(466, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Upload File"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(18, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Select Student Table"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(18, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "StudentID Column"
        '
        'CBTables
        '
        Me.CBTables.Animated = True
        Me.CBTables.BackColor = System.Drawing.Color.Transparent
        Me.CBTables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTables.FocusedColor = System.Drawing.Color.Empty
        Me.CBTables.FocusedState.Parent = Me.CBTables
        Me.CBTables.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBTables.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBTables.FormattingEnabled = True
        Me.CBTables.HoverState.Parent = Me.CBTables
        Me.CBTables.ItemHeight = 30
        Me.CBTables.ItemsAppearance.Parent = Me.CBTables
        Me.CBTables.Location = New System.Drawing.Point(22, 159)
        Me.CBTables.Name = "CBTables"
        Me.CBTables.ShadowDecoration.Parent = Me.CBTables
        Me.CBTables.Size = New System.Drawing.Size(863, 36)
        Me.CBTables.TabIndex = 8
        '
        'CBStudentID
        '
        Me.CBStudentID.Animated = True
        Me.CBStudentID.BackColor = System.Drawing.Color.Transparent
        Me.CBStudentID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStudentID.FocusedColor = System.Drawing.Color.Empty
        Me.CBStudentID.FocusedState.Parent = Me.CBStudentID
        Me.CBStudentID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBStudentID.FormattingEnabled = True
        Me.CBStudentID.HoverState.Parent = Me.CBStudentID
        Me.CBStudentID.ItemHeight = 30
        Me.CBStudentID.ItemsAppearance.Parent = Me.CBStudentID
        Me.CBStudentID.Location = New System.Drawing.Point(22, 236)
        Me.CBStudentID.Name = "CBStudentID"
        Me.CBStudentID.ShadowDecoration.Parent = Me.CBStudentID
        Me.CBStudentID.Size = New System.Drawing.Size(275, 36)
        Me.CBStudentID.TabIndex = 8
        '
        'TextDBPath
        '
        Me.TextDBPath.Animated = True
        Me.TextDBPath.BackColor = System.Drawing.Color.Transparent
        Me.TextDBPath.BorderColor = System.Drawing.Color.LightGray
        Me.TextDBPath.BorderThickness = 1
        Me.TextDBPath.CheckedState.Parent = Me.TextDBPath
        Me.TextDBPath.CustomImages.Parent = Me.TextDBPath
        Me.TextDBPath.FillColor = System.Drawing.Color.White
        Me.TextDBPath.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextDBPath.ForeColor = System.Drawing.Color.DimGray
        Me.TextDBPath.HoverState.Parent = Me.TextDBPath
        Me.TextDBPath.Location = New System.Drawing.Point(470, 45)
        Me.TextDBPath.Name = "TextDBPath"
        Me.TextDBPath.ShadowDecoration.Parent = Me.TextDBPath
        Me.TextDBPath.Size = New System.Drawing.Size(415, 36)
        Me.TextDBPath.TabIndex = 9
        Me.TextDBPath.Text = "Click here to Upload database"
        Me.TextDBPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(318, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Firstname Column"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(610, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Lastname Column"
        '
        'CBFirstname
        '
        Me.CBFirstname.Animated = True
        Me.CBFirstname.BackColor = System.Drawing.Color.Transparent
        Me.CBFirstname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBFirstname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFirstname.FocusedColor = System.Drawing.Color.Empty
        Me.CBFirstname.FocusedState.Parent = Me.CBFirstname
        Me.CBFirstname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBFirstname.FormattingEnabled = True
        Me.CBFirstname.HoverState.Parent = Me.CBFirstname
        Me.CBFirstname.ItemHeight = 30
        Me.CBFirstname.ItemsAppearance.Parent = Me.CBFirstname
        Me.CBFirstname.Location = New System.Drawing.Point(322, 236)
        Me.CBFirstname.Name = "CBFirstname"
        Me.CBFirstname.ShadowDecoration.Parent = Me.CBFirstname
        Me.CBFirstname.Size = New System.Drawing.Size(275, 36)
        Me.CBFirstname.TabIndex = 11
        '
        'CBLastname
        '
        Me.CBLastname.Animated = True
        Me.CBLastname.BackColor = System.Drawing.Color.Transparent
        Me.CBLastname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBLastname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBLastname.FocusedColor = System.Drawing.Color.Empty
        Me.CBLastname.FocusedState.Parent = Me.CBLastname
        Me.CBLastname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBLastname.FormattingEnabled = True
        Me.CBLastname.HoverState.Parent = Me.CBLastname
        Me.CBLastname.ItemHeight = 30
        Me.CBLastname.ItemsAppearance.Parent = Me.CBLastname
        Me.CBLastname.Location = New System.Drawing.Point(614, 236)
        Me.CBLastname.Name = "CBLastname"
        Me.CBLastname.ShadowDecoration.Parent = Me.CBLastname
        Me.CBLastname.Size = New System.Drawing.Size(275, 36)
        Me.CBLastname.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(21, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Course Column"
        '
        'CBCourse
        '
        Me.CBCourse.Animated = True
        Me.CBCourse.BackColor = System.Drawing.Color.Transparent
        Me.CBCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCourse.FocusedColor = System.Drawing.Color.Empty
        Me.CBCourse.FocusedState.Parent = Me.CBCourse
        Me.CBCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBCourse.FormattingEnabled = True
        Me.CBCourse.HoverState.Parent = Me.CBCourse
        Me.CBCourse.ItemHeight = 30
        Me.CBCourse.ItemsAppearance.Parent = Me.CBCourse
        Me.CBCourse.Location = New System.Drawing.Point(25, 315)
        Me.CBCourse.Name = "CBCourse"
        Me.CBCourse.ShadowDecoration.Parent = Me.CBCourse
        Me.CBCourse.Size = New System.Drawing.Size(275, 36)
        Me.CBCourse.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.ButtonIgnore)
        Me.Panel1.Controls.Add(Me.ButtonReplace)
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.ButtonImport)
        Me.Panel1.Controls.Add(Me.Guna2Separator2)
        Me.Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Panel1.Controls.Add(Me.CBSection)
        Me.Panel1.Controls.Add(Me.CBYear)
        Me.Panel1.Controls.Add(Me.CBCourse)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CBLastname)
        Me.Panel1.Controls.Add(Me.CBFirstname)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextDBPath)
        Me.Panel1.Controls.Add(Me.CBStudentID)
        Me.Panel1.Controls.Add(Me.CBTables)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CBDatabaseType)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PanelTestConnectionLoadng)
        Me.Panel1.Location = New System.Drawing.Point(15, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 529)
        Me.Panel1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(318, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 21)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Year Column"
        '
        'CBYear
        '
        Me.CBYear.Animated = True
        Me.CBYear.BackColor = System.Drawing.Color.Transparent
        Me.CBYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBYear.FocusedColor = System.Drawing.Color.Empty
        Me.CBYear.FocusedState.Parent = Me.CBYear
        Me.CBYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBYear.FormattingEnabled = True
        Me.CBYear.HoverState.Parent = Me.CBYear
        Me.CBYear.ItemHeight = 30
        Me.CBYear.ItemsAppearance.Parent = Me.CBYear
        Me.CBYear.Location = New System.Drawing.Point(322, 315)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.ShadowDecoration.Parent = Me.CBYear
        Me.CBYear.Size = New System.Drawing.Size(275, 36)
        Me.CBYear.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(610, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 21)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Section"
        '
        'CBSection
        '
        Me.CBSection.Animated = True
        Me.CBSection.BackColor = System.Drawing.Color.Transparent
        Me.CBSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSection.FocusedColor = System.Drawing.Color.Empty
        Me.CBSection.FocusedState.Parent = Me.CBSection
        Me.CBSection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBSection.FormattingEnabled = True
        Me.CBSection.HoverState.Parent = Me.CBSection
        Me.CBSection.ItemHeight = 30
        Me.CBSection.ItemsAppearance.Parent = Me.CBSection
        Me.CBSection.Location = New System.Drawing.Point(614, 315)
        Me.CBSection.Name = "CBSection"
        Me.CBSection.ShadowDecoration.Parent = Me.CBSection
        Me.CBSection.Size = New System.Drawing.Size(275, 36)
        Me.CBSection.TabIndex = 13
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(22, 123)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(863, 8)
        Me.Guna2Separator1.TabIndex = 14
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(26, 427)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(863, 8)
        Me.Guna2Separator2.TabIndex = 15
        '
        'ButtonImport
        '
        Me.ButtonImport.Animated = True
        Me.ButtonImport.CheckedState.Parent = Me.ButtonImport
        Me.ButtonImport.CustomImages.Parent = Me.ButtonImport
        Me.ButtonImport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonImport.ForeColor = System.Drawing.Color.White
        Me.ButtonImport.HoverState.Parent = Me.ButtonImport
        Me.ButtonImport.Location = New System.Drawing.Point(705, 453)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.ShadowDecoration.Parent = Me.ButtonImport
        Me.ButtonImport.Size = New System.Drawing.Size(180, 45)
        Me.ButtonImport.TabIndex = 16
        Me.ButtonImport.Text = "Start Import"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(588, 466)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(106, 22)
        Me.Guna2Button2.TabIndex = 16
        Me.Guna2Button2.Text = "Cancel"
        '
        'ButtonReplace
        '
        Me.ButtonReplace.Animated = True
        Me.ButtonReplace.BorderColor = System.Drawing.Color.LightGray
        Me.ButtonReplace.BorderThickness = 1
        Me.ButtonReplace.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonReplace.Checked = True
        Me.ButtonReplace.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonReplace.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonReplace.CheckedState.Parent = Me.ButtonReplace
        Me.ButtonReplace.CustomImages.Parent = Me.ButtonReplace
        Me.ButtonReplace.FillColor = System.Drawing.Color.White
        Me.ButtonReplace.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonReplace.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonReplace.HoverState.Parent = Me.ButtonReplace
        Me.ButtonReplace.Location = New System.Drawing.Point(209, 380)
        Me.ButtonReplace.Name = "ButtonReplace"
        Me.ButtonReplace.ShadowDecoration.Parent = Me.ButtonReplace
        Me.ButtonReplace.Size = New System.Drawing.Size(130, 30)
        Me.ButtonReplace.TabIndex = 17
        Me.ButtonReplace.Text = "Replace Original"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(22, 383)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 21)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Handle Duplicate Entries:"
        '
        'ButtonIgnore
        '
        Me.ButtonIgnore.Animated = True
        Me.ButtonIgnore.BorderColor = System.Drawing.Color.LightGray
        Me.ButtonIgnore.BorderThickness = 1
        Me.ButtonIgnore.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonIgnore.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonIgnore.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonIgnore.CheckedState.Parent = Me.ButtonIgnore
        Me.ButtonIgnore.CustomImages.Parent = Me.ButtonIgnore
        Me.ButtonIgnore.FillColor = System.Drawing.Color.White
        Me.ButtonIgnore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonIgnore.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonIgnore.HoverState.Parent = Me.ButtonIgnore
        Me.ButtonIgnore.Location = New System.Drawing.Point(345, 380)
        Me.ButtonIgnore.Name = "ButtonIgnore"
        Me.ButtonIgnore.ShadowDecoration.Parent = Me.ButtonIgnore
        Me.ButtonIgnore.Size = New System.Drawing.Size(178, 30)
        Me.ButtonIgnore.TabIndex = 17
        Me.ButtonIgnore.Text = "Ignore Entry if already existed"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2CircleProgressBar2)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(26, 453)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(556, 45)
        Me.Panel2.TabIndex = 19
        Me.Panel2.Visible = False
        '
        'Guna2CircleProgressBar2
        '
        Me.Guna2CircleProgressBar2.Animated = True
        Me.Guna2CircleProgressBar2.FillThickness = 10
        Me.Guna2CircleProgressBar2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Guna2CircleProgressBar2.ForeColor = System.Drawing.Color.Black
        Me.Guna2CircleProgressBar2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CircleProgressBar2.Name = "Guna2CircleProgressBar2"
        Me.Guna2CircleProgressBar2.ProgressThickness = 10
        Me.Guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar2.ShadowDecoration.Parent = Me.Guna2CircleProgressBar2
        Me.Guna2CircleProgressBar2.ShowPercentage = True
        Me.Guna2CircleProgressBar2.Size = New System.Drawing.Size(45, 45)
        Me.Guna2CircleProgressBar2.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(51, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 21)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Year Column"
        '
        'BackgroundWorkerUpload
        '
        Me.BackgroundWorkerUpload.WorkerReportsProgress = True
        '
        'UploadDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "UploadDatabase"
        Me.Size = New System.Drawing.Size(952, 579)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.PanelTestConnectionLoadng.ResumeLayout(False)
        Me.PanelTestConnectionLoadng.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents OpenFileDialogDatabase As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BackgroundWorkerTestConnection As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CBCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBLastname As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBFirstname As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextDBPath As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBStudentID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBTables As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBDatabaseType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelTestConnectionLoadng As System.Windows.Forms.Panel
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBSection As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonImport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButtonIgnore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonReplace As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Guna2CircleProgressBar2 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorkerUpload As System.ComponentModel.BackgroundWorker

End Class
