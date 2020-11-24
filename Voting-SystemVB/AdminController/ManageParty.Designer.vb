<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageParty
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.PartyDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.PartyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.PartyDataGridView)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(36, 58)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(838, 400)
        Me.Guna2ShadowPanel1.TabIndex = 6
        '
        'PartyDataGridView
        '
        Me.PartyDataGridView.AllowUserToAddRows = False
        Me.PartyDataGridView.AllowUserToDeleteRows = False
        Me.PartyDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.PartyDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PartyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PartyDataGridView.AutoGenerateColumns = False
        Me.PartyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PartyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PartyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PartyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PartyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PartyDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PartyDataGridView.ColumnHeadersHeight = 40
        Me.PartyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.PartyDataGridView.DataSource = Me.PartyBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PartyDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.PartyDataGridView.EnableHeadersVisualStyles = False
        Me.PartyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PartyDataGridView.Location = New System.Drawing.Point(12, 11)
        Me.PartyDataGridView.MultiSelect = False
        Me.PartyDataGridView.Name = "PartyDataGridView"
        Me.PartyDataGridView.ReadOnly = True
        Me.PartyDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PartyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.PartyDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PartyDataGridView.RowTemplate.Height = 40
        Me.PartyDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PartyDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PartyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PartyDataGridView.Size = New System.Drawing.Size(816, 377)
        Me.PartyDataGridView.TabIndex = 4
        Me.PartyDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.PartyDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.PartyDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.PartyDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.PartyDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.PartyDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.PartyDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.PartyDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PartyDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.PartyDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PartyDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.PartyDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.PartyDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PartyDataGridView.ThemeStyle.HeaderStyle.Height = 40
        Me.PartyDataGridView.ThemeStyle.ReadOnly = True
        Me.PartyDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.PartyDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PartyDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.PartyDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.PartyDataGridView.ThemeStyle.RowsStyle.Height = 40
        Me.PartyDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PartyDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(33, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Manage Party"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd.BorderRadius = 10
        Me.ButtonAdd.CheckedState.Parent = Me.ButtonAdd
        Me.ButtonAdd.CustomImages.Parent = Me.ButtonAdd
        Me.ButtonAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ButtonAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.HoverState.Parent = Me.ButtonAdd
        Me.ButtonAdd.Location = New System.Drawing.Point(684, 7)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.ShadowDecoration.Parent = Me.ButtonAdd
        Me.ButtonAdd.Size = New System.Drawing.Size(180, 45)
        Me.ButtonAdd.TabIndex = 8
        Me.ButtonAdd.Text = "Add Party"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRefresh.BorderRadius = 10
        Me.ButtonRefresh.BorderThickness = 1
        Me.ButtonRefresh.CheckedState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.CustomImages.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.FillColor = System.Drawing.Color.White
        Me.ButtonRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.Black
        Me.ButtonRefresh.HoverState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Location = New System.Drawing.Point(494, 7)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.ShadowDecoration.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Size = New System.Drawing.Size(180, 45)
        Me.ButtonRefresh.TabIndex = 8
        Me.ButtonRefresh.Text = "Refresh"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PartyBindingSource
        '
        Me.PartyBindingSource.DataSource = GetType(Voting_SystemVB.Party)
        '
        'ManageParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Name = "ManageParty"
        Me.Size = New System.Drawing.Size(913, 481)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.PartyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents PartyDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PartyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
