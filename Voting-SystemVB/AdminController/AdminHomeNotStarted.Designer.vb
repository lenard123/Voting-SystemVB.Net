<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomeNotStarted
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
        Me.Card2 = New Voting_SystemVB.Card()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Card1 = New Voting_SystemVB.Card()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.VoterCount = New System.Windows.Forms.Label()
        Me.PROCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PresidentCount = New System.Windows.Forms.Label()
        Me.AuditorCount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ViceCount = New System.Windows.Forms.Label()
        Me.TreasurerCount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SecretaryCount = New System.Windows.Forms.Label()
        Me.Card2.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Card1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Card2
        '
        Me.Card2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Card2.BackColor = System.Drawing.Color.White
        Me.Card2.BGColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Card2.Controls.Add(Me.Guna2DataGridView1)
        Me.Card2.Controls.Add(Me.Label2)
        Me.Card2.Location = New System.Drawing.Point(361, 12)
        Me.Card2.Name = "Card2"
        Me.Card2.Size = New System.Drawing.Size(501, 374)
        Me.Card2.TabIndex = 2
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2DataGridView1.AutoGenerateColumns = False
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 30
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleDataGridViewTextBoxColumn, Me.StartedDataGridViewTextBoxColumn, Me.EndedDataGridViewTextBoxColumn})
        Me.Guna2DataGridView1.DataSource = Me.ElectionBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(27, 57)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(452, 297)
        Me.Guna2DataGridView1.TabIndex = 1
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.SystemColors.Info
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'StartedDataGridViewTextBoxColumn
        '
        Me.StartedDataGridViewTextBoxColumn.DataPropertyName = "Started"
        Me.StartedDataGridViewTextBoxColumn.HeaderText = "Started"
        Me.StartedDataGridViewTextBoxColumn.Name = "StartedDataGridViewTextBoxColumn"
        Me.StartedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndedDataGridViewTextBoxColumn
        '
        Me.EndedDataGridViewTextBoxColumn.DataPropertyName = "Ended"
        Me.EndedDataGridViewTextBoxColumn.HeaderText = "Ended"
        Me.EndedDataGridViewTextBoxColumn.Name = "EndedDataGridViewTextBoxColumn"
        Me.EndedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ElectionBindingSource
        '
        Me.ElectionBindingSource.DataSource = GetType(Voting_SystemVB.Election)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(21, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Previous Election"
        '
        'Card1
        '
        Me.Card1.BackColor = System.Drawing.Color.White
        Me.Card1.BGColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Card1.Controls.Add(Me.Guna2Button1)
        Me.Card1.Controls.Add(Me.VoterCount)
        Me.Card1.Controls.Add(Me.PROCount)
        Me.Card1.Controls.Add(Me.Label1)
        Me.Card1.Controls.Add(Me.Label3)
        Me.Card1.Controls.Add(Me.Label13)
        Me.Card1.Controls.Add(Me.PresidentCount)
        Me.Card1.Controls.Add(Me.AuditorCount)
        Me.Card1.Controls.Add(Me.Label5)
        Me.Card1.Controls.Add(Me.Label11)
        Me.Card1.Controls.Add(Me.ViceCount)
        Me.Card1.Controls.Add(Me.TreasurerCount)
        Me.Card1.Controls.Add(Me.Label7)
        Me.Card1.Controls.Add(Me.Label9)
        Me.Card1.Controls.Add(Me.SecretaryCount)
        Me.Card1.Location = New System.Drawing.Point(19, 12)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(322, 374)
        Me.Card1.TabIndex = 1
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(81, 281)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(129, 36)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Start Election"
        '
        'VoterCount
        '
        Me.VoterCount.AutoSize = True
        Me.VoterCount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VoterCount.Location = New System.Drawing.Point(155, 40)
        Me.VoterCount.Name = "VoterCount"
        Me.VoterCount.Size = New System.Drawing.Size(77, 25)
        Me.VoterCount.TabIndex = 0
        Me.VoterCount.Text = "0 Voter"
        '
        'PROCount
        '
        Me.PROCount.AutoSize = True
        Me.PROCount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PROCount.Location = New System.Drawing.Point(155, 232)
        Me.PROCount.Name = "PROCount"
        Me.PROCount.Size = New System.Drawing.Size(127, 25)
        Me.PROCount.TabIndex = 0
        Me.PROCount.Text = "Total Voters: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(17, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Voters: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(17, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "President:  "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label13.Location = New System.Drawing.Point(17, 232)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "P.R.O.:"
        '
        'PresidentCount
        '
        Me.PresidentCount.AutoSize = True
        Me.PresidentCount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PresidentCount.Location = New System.Drawing.Point(155, 72)
        Me.PresidentCount.Name = "PresidentCount"
        Me.PresidentCount.Size = New System.Drawing.Size(162, 25)
        Me.PresidentCount.TabIndex = 0
        Me.PresidentCount.Text = "500 Candidate(s)"
        '
        'AuditorCount
        '
        Me.AuditorCount.AutoSize = True
        Me.AuditorCount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.AuditorCount.Location = New System.Drawing.Point(155, 200)
        Me.AuditorCount.Name = "AuditorCount"
        Me.AuditorCount.Size = New System.Drawing.Size(127, 25)
        Me.AuditorCount.TabIndex = 0
        Me.AuditorCount.Text = "Total Voters: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(17, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Vice President:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label11.Location = New System.Drawing.Point(17, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Auditor:"
        '
        'ViceCount
        '
        Me.ViceCount.AutoSize = True
        Me.ViceCount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ViceCount.Location = New System.Drawing.Point(155, 104)
        Me.ViceCount.Name = "ViceCount"
        Me.ViceCount.Size = New System.Drawing.Size(127, 25)
        Me.ViceCount.TabIndex = 0
        Me.ViceCount.Text = "Total Voters: "
        '
        'TreasurerCount
        '
        Me.TreasurerCount.AutoSize = True
        Me.TreasurerCount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TreasurerCount.Location = New System.Drawing.Point(155, 168)
        Me.TreasurerCount.Name = "TreasurerCount"
        Me.TreasurerCount.Size = New System.Drawing.Size(127, 25)
        Me.TreasurerCount.TabIndex = 0
        Me.TreasurerCount.Text = "Total Voters: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label7.Location = New System.Drawing.Point(17, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Secretary: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(17, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Treasurer: "
        '
        'SecretaryCount
        '
        Me.SecretaryCount.AutoSize = True
        Me.SecretaryCount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.SecretaryCount.Location = New System.Drawing.Point(155, 136)
        Me.SecretaryCount.Name = "SecretaryCount"
        Me.SecretaryCount.Size = New System.Drawing.Size(127, 25)
        Me.SecretaryCount.TabIndex = 0
        Me.SecretaryCount.Text = "Total Voters: "
        '
        'AdminHomeNotStarted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Card2)
        Me.Controls.Add(Me.Card1)
        Me.Name = "AdminHomeNotStarted"
        Me.Size = New System.Drawing.Size(878, 402)
        Me.Card2.ResumeLayout(False)
        Me.Card2.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Card1.ResumeLayout(False)
        Me.Card1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VoterCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PresidentCount As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ViceCount As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SecretaryCount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TreasurerCount As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AuditorCount As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PROCount As System.Windows.Forms.Label
    Friend WithEvents Card1 As Voting_SystemVB.Card
    Friend WithEvents Card2 As Voting_SystemVB.Card
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ElectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button

End Class
