<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageVoters
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageVoters))
        Me.ButtonSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonFilterAll = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonFilter1st = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonFilter2nd = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonFilter3rd = New Guna.UI2.WinForms.Guna2Button()
        Me.StudentDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.StudentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ButtonAddVoter = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.ButtonRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.TextSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonFilter4th = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSearch.CheckedState.Parent = Me.ButtonSearch
        Me.ButtonSearch.CustomBorderColor = System.Drawing.Color.Blue
        Me.ButtonSearch.CustomImages.Parent = Me.ButtonSearch
        Me.ButtonSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.HoverState.Parent = Me.ButtonSearch
        Me.ButtonSearch.Location = New System.Drawing.Point(777, 45)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.ShadowDecoration.Parent = Me.ButtonSearch
        Me.ButtonSearch.Size = New System.Drawing.Size(117, 36)
        Me.ButtonSearch.TabIndex = 1
        Me.ButtonSearch.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filters:"
        '
        'ButtonFilterAll
        '
        Me.ButtonFilterAll.BorderRadius = 15
        Me.ButtonFilterAll.CheckedState.Parent = Me.ButtonFilterAll
        Me.ButtonFilterAll.CustomImages.Parent = Me.ButtonFilterAll
        Me.ButtonFilterAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonFilterAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonFilterAll.ForeColor = System.Drawing.Color.White
        Me.ButtonFilterAll.HoverState.Parent = Me.ButtonFilterAll
        Me.ButtonFilterAll.Location = New System.Drawing.Point(3, 3)
        Me.ButtonFilterAll.Name = "ButtonFilterAll"
        Me.ButtonFilterAll.ShadowDecoration.Parent = Me.ButtonFilterAll
        Me.ButtonFilterAll.Size = New System.Drawing.Size(76, 29)
        Me.ButtonFilterAll.TabIndex = 3
        Me.ButtonFilterAll.Text = "ALL"
        '
        'ButtonFilter1st
        '
        Me.ButtonFilter1st.BorderRadius = 15
        Me.ButtonFilter1st.CheckedState.Parent = Me.ButtonFilter1st
        Me.ButtonFilter1st.CustomImages.Parent = Me.ButtonFilter1st
        Me.ButtonFilter1st.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonFilter1st.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonFilter1st.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonFilter1st.HoverState.Parent = Me.ButtonFilter1st
        Me.ButtonFilter1st.Location = New System.Drawing.Point(85, 3)
        Me.ButtonFilter1st.Name = "ButtonFilter1st"
        Me.ButtonFilter1st.ShadowDecoration.Parent = Me.ButtonFilter1st
        Me.ButtonFilter1st.Size = New System.Drawing.Size(76, 29)
        Me.ButtonFilter1st.TabIndex = 3
        Me.ButtonFilter1st.Text = "1st Year"
        '
        'ButtonFilter2nd
        '
        Me.ButtonFilter2nd.BorderRadius = 15
        Me.ButtonFilter2nd.CheckedState.Parent = Me.ButtonFilter2nd
        Me.ButtonFilter2nd.CustomImages.Parent = Me.ButtonFilter2nd
        Me.ButtonFilter2nd.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonFilter2nd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonFilter2nd.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonFilter2nd.HoverState.Parent = Me.ButtonFilter2nd
        Me.ButtonFilter2nd.Location = New System.Drawing.Point(167, 3)
        Me.ButtonFilter2nd.Name = "ButtonFilter2nd"
        Me.ButtonFilter2nd.ShadowDecoration.Parent = Me.ButtonFilter2nd
        Me.ButtonFilter2nd.Size = New System.Drawing.Size(76, 29)
        Me.ButtonFilter2nd.TabIndex = 3
        Me.ButtonFilter2nd.Text = "2nd Year"
        '
        'ButtonFilter3rd
        '
        Me.ButtonFilter3rd.BorderRadius = 15
        Me.ButtonFilter3rd.CheckedState.Parent = Me.ButtonFilter3rd
        Me.ButtonFilter3rd.CustomImages.Parent = Me.ButtonFilter3rd
        Me.ButtonFilter3rd.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonFilter3rd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonFilter3rd.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonFilter3rd.HoverState.Parent = Me.ButtonFilter3rd
        Me.ButtonFilter3rd.Location = New System.Drawing.Point(249, 3)
        Me.ButtonFilter3rd.Name = "ButtonFilter3rd"
        Me.ButtonFilter3rd.ShadowDecoration.Parent = Me.ButtonFilter3rd
        Me.ButtonFilter3rd.Size = New System.Drawing.Size(76, 29)
        Me.ButtonFilter3rd.TabIndex = 3
        Me.ButtonFilter3rd.Text = "3rd Year"
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AllowUserToAddRows = False
        Me.StudentDataGridView.AllowUserToDeleteRows = False
        Me.StudentDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StudentDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.StudentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StudentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StudentDataGridView.ColumnHeadersHeight = 40
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIdDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.YearLevelDataGridViewTextBoxColumn, Me.SectionDataGridViewTextBoxColumn})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.StudentDataGridView.EnableHeadersVisualStyles = False
        Me.StudentDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.StudentDataGridView.Location = New System.Drawing.Point(12, 11)
        Me.StudentDataGridView.MultiSelect = False
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.ReadOnly = True
        Me.StudentDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.StudentDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.StudentDataGridView.RowTemplate.Height = 40
        Me.StudentDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentDataGridView.Size = New System.Drawing.Size(859, 336)
        Me.StudentDataGridView.TabIndex = 4
        Me.StudentDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.StudentDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.Height = 40
        Me.StudentDataGridView.ThemeStyle.ReadOnly = True
        Me.StudentDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StudentDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.StudentDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.StudentDataGridView.ThemeStyle.RowsStyle.Height = 40
        Me.StudentDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.StudentDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'StudentIdDataGridViewTextBoxColumn
        '
        Me.StudentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId"
        Me.StudentIdDataGridViewTextBoxColumn.HeaderText = "StudentId"
        Me.StudentIdDataGridViewTextBoxColumn.Name = "StudentIdDataGridViewTextBoxColumn"
        Me.StudentIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "Fullname"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearLevelDataGridViewTextBoxColumn
        '
        Me.YearLevelDataGridViewTextBoxColumn.DataPropertyName = "YearLevel"
        Me.YearLevelDataGridViewTextBoxColumn.HeaderText = "YearLevel"
        Me.YearLevelDataGridViewTextBoxColumn.Name = "YearLevelDataGridViewTextBoxColumn"
        Me.YearLevelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "Section"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SectionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "Section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        Me.SectionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataSource = GetType(Voting_SystemVB.Student)
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.ButtonAddVoter)
        Me.Guna2ShadowPanel1.Controls.Add(Me.StudentDataGridView)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(13, 104)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(881, 359)
        Me.Guna2ShadowPanel1.TabIndex = 5
        '
        'ButtonAddVoter
        '
        Me.ButtonAddVoter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddVoter.CheckedState.Parent = Me.ButtonAddVoter
        Me.ButtonAddVoter.CustomImages.Parent = Me.ButtonAddVoter
        Me.ButtonAddVoter.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ButtonAddVoter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonAddVoter.ForeColor = System.Drawing.Color.White
        Me.ButtonAddVoter.HoverState.Parent = Me.ButtonAddVoter
        Me.ButtonAddVoter.Image = Global.Voting_SystemVB.My.Resources.Resources.plus_white
        Me.ButtonAddVoter.ImageOffset = New System.Drawing.Point(1, 1)
        Me.ButtonAddVoter.ImageSize = New System.Drawing.Size(25, 25)
        Me.ButtonAddVoter.Location = New System.Drawing.Point(797, 297)
        Me.ButtonAddVoter.Name = "ButtonAddVoter"
        Me.ButtonAddVoter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ButtonAddVoter.ShadowDecoration.Parent = Me.ButtonAddVoter
        Me.ButtonAddVoter.Size = New System.Drawing.Size(50, 50)
        Me.ButtonAddVoter.TabIndex = 6
        Me.Guna2HtmlToolTip1.SetToolTip(Me.ButtonAddVoter, "Add Student")
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.StudentDataGridView
        '
        'Guna2HtmlToolTip1
        '
        Me.Guna2HtmlToolTip1.AllowLinksHandling = True
        Me.Guna2HtmlToolTip1.IsBalloon = True
        Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRefresh.BorderRadius = 5
        Me.ButtonRefresh.BorderThickness = 1
        Me.ButtonRefresh.CheckedState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.CustomImages.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.FillColor = System.Drawing.Color.White
        Me.ButtonRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.Black
        Me.ButtonRefresh.HoverState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Location = New System.Drawing.Point(657, 44)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.ShadowDecoration.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Size = New System.Drawing.Size(114, 36)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.Text = "Refresh"
        '
        'TextSearch
        '
        Me.TextSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextSearch.BorderRadius = 8
        Me.TextSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextSearch.DefaultText = ""
        Me.TextSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextSearch.DisabledState.Parent = Me.TextSearch
        Me.TextSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextSearch.FocusedState.Parent = Me.TextSearch
        Me.TextSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextSearch.HoverState.Parent = Me.TextSearch
        Me.TextSearch.IconLeft = CType(resources.GetObject("TextSearch.IconLeft"), System.Drawing.Image)
        Me.TextSearch.Location = New System.Drawing.Point(13, 3)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TextSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextSearch.PlaceholderText = "    Search Voters Here"
        Me.TextSearch.SelectedText = ""
        Me.TextSearch.ShadowDecoration.Parent = Me.TextSearch
        Me.TextSearch.Size = New System.Drawing.Size(881, 36)
        Me.TextSearch.TabIndex = 0
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelResult.Location = New System.Drawing.Point(36, 82)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(213, 19)
        Me.LabelResult.TabIndex = 6
        Me.LabelResult.Text = "Search Results for: ""Lenard"""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonFilterAll)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonFilter1st)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonFilter2nd)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonFilter3rd)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonFilter4th)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(71, 44)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(417, 35)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'ButtonFilter4th
        '
        Me.ButtonFilter4th.BorderRadius = 15
        Me.ButtonFilter4th.CheckedState.Parent = Me.ButtonFilter4th
        Me.ButtonFilter4th.CustomImages.Parent = Me.ButtonFilter4th
        Me.ButtonFilter4th.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonFilter4th.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonFilter4th.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonFilter4th.HoverState.Parent = Me.ButtonFilter4th
        Me.ButtonFilter4th.Location = New System.Drawing.Point(331, 3)
        Me.ButtonFilter4th.Name = "ButtonFilter4th"
        Me.ButtonFilter4th.ShadowDecoration.Parent = Me.ButtonFilter4th
        Me.ButtonFilter4th.Size = New System.Drawing.Size(76, 29)
        Me.ButtonFilter4th.TabIndex = 3
        Me.ButtonFilter4th.Text = "4th Year"
        '
        'ManageVoters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextSearch)
        Me.Name = "ManageVoters"
        Me.Size = New System.Drawing.Size(913, 481)
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ButtonSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonFilterAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonFilter1st As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonFilter2nd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonFilter3rd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents StudentDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ButtonAddVoter As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ButtonRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LabelResult As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonFilter4th As Guna.UI2.WinForms.Guna2Button

End Class
