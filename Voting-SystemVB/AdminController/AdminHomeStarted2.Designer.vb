<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomeStarted2
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.President = New Guna.UI2.WinForms.Guna2Button()
        Me.VPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.Secretary = New Guna.UI2.WinForms.Guna2Button()
        Me.Treasurer = New Guna.UI2.WinForms.Guna2Button()
        Me.Auditor = New Guna.UI2.WinForms.Guna2Button()
        Me.PRO = New Guna.UI2.WinForms.Guna2Button()
        Me.DisplayPieChart = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.ViewChart = New System.Windows.Forms.Label()
        Me.ButtonRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.ShowCandidates = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2CircleProgressBar2 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2CircleProgressBar3 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoadingPanel = New System.Windows.Forms.Panel()
        Me.PanelChart = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ShowCandidates.SuspendLayout()
        Me.Guna2CircleProgressBar1.SuspendLayout()
        Me.Guna2CircleProgressBar2.SuspendLayout()
        Me.Guna2CircleProgressBar3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelChart.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'President
        '
        Me.President.CheckedState.Parent = Me.President
        Me.President.CustomImages.Parent = Me.President
        Me.President.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.President.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.President.ForeColor = System.Drawing.Color.White
        Me.President.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.President.HoverState.Parent = Me.President
        Me.President.Location = New System.Drawing.Point(32, 193)
        Me.President.Margin = New System.Windows.Forms.Padding(0)
        Me.President.Name = "President"
        Me.President.ShadowDecoration.Parent = Me.President
        Me.President.Size = New System.Drawing.Size(144, 37)
        Me.President.TabIndex = 13
        Me.President.Tag = "1"
        Me.President.Text = "President"
        '
        'VPresident
        '
        Me.VPresident.CheckedState.Parent = Me.VPresident
        Me.VPresident.CustomImages.Parent = Me.VPresident
        Me.VPresident.FillColor = System.Drawing.Color.White
        Me.VPresident.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VPresident.ForeColor = System.Drawing.Color.Black
        Me.VPresident.HoverState.Parent = Me.VPresident
        Me.VPresident.Location = New System.Drawing.Point(32, 233)
        Me.VPresident.Margin = New System.Windows.Forms.Padding(0)
        Me.VPresident.Name = "VPresident"
        Me.VPresident.ShadowDecoration.Parent = Me.VPresident
        Me.VPresident.Size = New System.Drawing.Size(144, 37)
        Me.VPresident.TabIndex = 14
        Me.VPresident.Tag = "2"
        Me.VPresident.Text = "Vice President"
        '
        'Secretary
        '
        Me.Secretary.CheckedState.Parent = Me.Secretary
        Me.Secretary.CustomImages.Parent = Me.Secretary
        Me.Secretary.FillColor = System.Drawing.Color.White
        Me.Secretary.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Secretary.ForeColor = System.Drawing.Color.Black
        Me.Secretary.HoverState.Parent = Me.Secretary
        Me.Secretary.Location = New System.Drawing.Point(32, 380)
        Me.Secretary.Margin = New System.Windows.Forms.Padding(0)
        Me.Secretary.Name = "Secretary"
        Me.Secretary.ShadowDecoration.Parent = Me.Secretary
        Me.Secretary.Size = New System.Drawing.Size(144, 37)
        Me.Secretary.TabIndex = 15
        Me.Secretary.Tag = "3"
        Me.Secretary.Text = "Secretary"
        '
        'Treasurer
        '
        Me.Treasurer.CheckedState.Parent = Me.Treasurer
        Me.Treasurer.CustomImages.Parent = Me.Treasurer
        Me.Treasurer.FillColor = System.Drawing.Color.White
        Me.Treasurer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Treasurer.ForeColor = System.Drawing.Color.Black
        Me.Treasurer.HoverState.Parent = Me.Treasurer
        Me.Treasurer.Location = New System.Drawing.Point(32, 343)
        Me.Treasurer.Margin = New System.Windows.Forms.Padding(0)
        Me.Treasurer.Name = "Treasurer"
        Me.Treasurer.ShadowDecoration.Parent = Me.Treasurer
        Me.Treasurer.Size = New System.Drawing.Size(144, 37)
        Me.Treasurer.TabIndex = 16
        Me.Treasurer.Tag = "4"
        Me.Treasurer.Text = "Treasurer"
        '
        'Auditor
        '
        Me.Auditor.CheckedState.Parent = Me.Auditor
        Me.Auditor.CustomImages.Parent = Me.Auditor
        Me.Auditor.FillColor = System.Drawing.Color.White
        Me.Auditor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Auditor.ForeColor = System.Drawing.Color.Black
        Me.Auditor.HoverState.Parent = Me.Auditor
        Me.Auditor.Location = New System.Drawing.Point(32, 270)
        Me.Auditor.Margin = New System.Windows.Forms.Padding(0)
        Me.Auditor.Name = "Auditor"
        Me.Auditor.ShadowDecoration.Parent = Me.Auditor
        Me.Auditor.Size = New System.Drawing.Size(144, 37)
        Me.Auditor.TabIndex = 17
        Me.Auditor.Tag = "5"
        Me.Auditor.Text = "Auditor"
        '
        'PRO
        '
        Me.PRO.CheckedState.Parent = Me.PRO
        Me.PRO.CustomImages.Parent = Me.PRO
        Me.PRO.FillColor = System.Drawing.Color.White
        Me.PRO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRO.ForeColor = System.Drawing.Color.Black
        Me.PRO.HoverState.Parent = Me.PRO
        Me.PRO.Location = New System.Drawing.Point(32, 306)
        Me.PRO.Margin = New System.Windows.Forms.Padding(0)
        Me.PRO.Name = "PRO"
        Me.PRO.ShadowDecoration.Parent = Me.PRO
        Me.PRO.Size = New System.Drawing.Size(144, 37)
        Me.PRO.TabIndex = 18
        Me.PRO.Tag = "6"
        Me.PRO.Text = "P.R.O."
        '
        'DisplayPieChart
        '
        Me.DisplayPieChart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayPieChart.Checked = True
        Me.DisplayPieChart.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayPieChart.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayPieChart.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.DisplayPieChart.CheckedState.InnerColor = System.Drawing.Color.White
        Me.DisplayPieChart.CheckedState.Parent = Me.DisplayPieChart
        Me.DisplayPieChart.Location = New System.Drawing.Point(572, 51)
        Me.DisplayPieChart.Margin = New System.Windows.Forms.Padding(4)
        Me.DisplayPieChart.Name = "DisplayPieChart"
        Me.DisplayPieChart.ShadowDecoration.Parent = Me.DisplayPieChart
        Me.DisplayPieChart.Size = New System.Drawing.Size(45, 20)
        Me.DisplayPieChart.TabIndex = 19
        Me.DisplayPieChart.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DisplayPieChart.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DisplayPieChart.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.DisplayPieChart.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.DisplayPieChart.UncheckedState.Parent = Me.DisplayPieChart
        '
        'ViewChart
        '
        Me.ViewChart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewChart.AutoSize = True
        Me.ViewChart.BackColor = System.Drawing.Color.Transparent
        Me.ViewChart.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewChart.Location = New System.Drawing.Point(483, 54)
        Me.ViewChart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ViewChart.Name = "ViewChart"
        Me.ViewChart.Size = New System.Drawing.Size(69, 17)
        Me.ViewChart.TabIndex = 21
        Me.ViewChart.Text = "Bar Chart"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BorderRadius = 10
        Me.ButtonRefresh.CheckedState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.CustomImages.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.White
        Me.ButtonRefresh.HoverState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Location = New System.Drawing.Point(14, 45)
        Me.ButtonRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.ShadowDecoration.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Size = New System.Drawing.Size(103, 26)
        Me.ButtonRefresh.TabIndex = 20
        Me.ButtonRefresh.Text = "Refresh"
        '
        'ShowCandidates
        '
        Me.ShowCandidates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowCandidates.Controls.Add(Me.Panel1)
        Me.ShowCandidates.Controls.Add(Me.ButtonRefresh)
        Me.ShowCandidates.Controls.Add(Me.ViewChart)
        Me.ShowCandidates.Controls.Add(Me.DisplayPieChart)
        Me.ShowCandidates.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowCandidates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowCandidates.Location = New System.Drawing.Point(180, 193)
        Me.ShowCandidates.Margin = New System.Windows.Forms.Padding(4)
        Me.ShowCandidates.Name = "ShowCandidates"
        Me.ShowCandidates.ShadowDecoration.Parent = Me.ShowCandidates
        Me.ShowCandidates.Size = New System.Drawing.Size(630, 265)
        Me.ShowCandidates.TabIndex = 22
        Me.ShowCandidates.Text = "Show Candidates"
        Me.ShowCandidates.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2CircleProgressBar1
        '
        Me.Guna2CircleProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2CircleProgressBar1.Controls.Add(Me.Label1)
        Me.Guna2CircleProgressBar1.Controls.Add(Me.Label6)
        Me.Guna2CircleProgressBar1.FillThickness = 10
        Me.Guna2CircleProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2CircleProgressBar1.Location = New System.Drawing.Point(213, 20)
        Me.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Guna2CircleProgressBar1.ProgressThickness = 10
        Me.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar1.ShadowDecoration.Parent = Me.Guna2CircleProgressBar1
        Me.Guna2CircleProgressBar1.Size = New System.Drawing.Size(153, 153)
        Me.Guna2CircleProgressBar1.TabIndex = 30
        Me.Guna2CircleProgressBar1.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(25, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Number of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Voters"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(38, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 38)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "100"
        '
        'Guna2CircleProgressBar2
        '
        Me.Guna2CircleProgressBar2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2CircleProgressBar2.Controls.Add(Me.Label2)
        Me.Guna2CircleProgressBar2.Controls.Add(Me.Label3)
        Me.Guna2CircleProgressBar2.FillThickness = 10
        Me.Guna2CircleProgressBar2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2CircleProgressBar2.Location = New System.Drawing.Point(396, 20)
        Me.Guna2CircleProgressBar2.Name = "Guna2CircleProgressBar2"
        Me.Guna2CircleProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Guna2CircleProgressBar2.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Guna2CircleProgressBar2.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
        Me.Guna2CircleProgressBar2.ProgressThickness = 10
        Me.Guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar2.ShadowDecoration.Parent = Me.Guna2CircleProgressBar2
        Me.Guna2CircleProgressBar2.Size = New System.Drawing.Size(153, 153)
        Me.Guna2CircleProgressBar2.TabIndex = 31
        Me.Guna2CircleProgressBar2.Value = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(21, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 34)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Students Already " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Voted"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(51, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 38)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "35"
        '
        'Guna2CircleProgressBar3
        '
        Me.Guna2CircleProgressBar3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2CircleProgressBar3.Controls.Add(Me.Label4)
        Me.Guna2CircleProgressBar3.Controls.Add(Me.Label5)
        Me.Guna2CircleProgressBar3.FillThickness = 10
        Me.Guna2CircleProgressBar3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2CircleProgressBar3.Location = New System.Drawing.Point(579, 20)
        Me.Guna2CircleProgressBar3.Name = "Guna2CircleProgressBar3"
        Me.Guna2CircleProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2CircleProgressBar3.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2CircleProgressBar3.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
        Me.Guna2CircleProgressBar3.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Square
        Me.Guna2CircleProgressBar3.ProgressThickness = 10
        Me.Guna2CircleProgressBar3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar3.ShadowDecoration.Parent = Me.Guna2CircleProgressBar3
        Me.Guna2CircleProgressBar3.Size = New System.Drawing.Size(153, 153)
        Me.Guna2CircleProgressBar3.TabIndex = 32
        Me.Guna2CircleProgressBar3.Value = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(23, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Remaining Voters"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(51, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 38)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "75"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PanelChart)
        Me.Panel1.Controls.Add(Me.LoadingPanel)
        Me.Panel1.Location = New System.Drawing.Point(14, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 170)
        Me.Panel1.TabIndex = 22
        '
        'LoadingPanel
        '
        Me.LoadingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoadingPanel.Location = New System.Drawing.Point(0, 0)
        Me.LoadingPanel.Name = "LoadingPanel"
        Me.LoadingPanel.Size = New System.Drawing.Size(603, 170)
        Me.LoadingPanel.TabIndex = 0
        '
        'PanelChart
        '
        Me.PanelChart.Controls.Add(Me.Chart1)
        Me.PanelChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChart.Location = New System.Drawing.Point(0, 0)
        Me.PanelChart.Name = "PanelChart"
        Me.PanelChart.Size = New System.Drawing.Size(603, 170)
        Me.PanelChart.TabIndex = 1
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(19, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(573, 144)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'AdminHomeStarted2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2CircleProgressBar3)
        Me.Controls.Add(Me.Guna2CircleProgressBar2)
        Me.Controls.Add(Me.Guna2CircleProgressBar1)
        Me.Controls.Add(Me.ShowCandidates)
        Me.Controls.Add(Me.PRO)
        Me.Controls.Add(Me.Auditor)
        Me.Controls.Add(Me.Treasurer)
        Me.Controls.Add(Me.Secretary)
        Me.Controls.Add(Me.VPresident)
        Me.Controls.Add(Me.President)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminHomeStarted2"
        Me.Size = New System.Drawing.Size(916, 481)
        Me.ShowCandidates.ResumeLayout(False)
        Me.ShowCandidates.PerformLayout()
        Me.Guna2CircleProgressBar1.ResumeLayout(False)
        Me.Guna2CircleProgressBar1.PerformLayout()
        Me.Guna2CircleProgressBar2.ResumeLayout(False)
        Me.Guna2CircleProgressBar2.PerformLayout()
        Me.Guna2CircleProgressBar3.ResumeLayout(False)
        Me.Guna2CircleProgressBar3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelChart.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents President As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Secretary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Treasurer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Auditor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PRO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DisplayPieChart As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents ViewChart As System.Windows.Forms.Label
    Friend WithEvents ButtonRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ShowCandidates As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2CircleProgressBar2 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Guna2CircleProgressBar3 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelChart As System.Windows.Forms.Panel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents LoadingPanel As System.Windows.Forms.Panel
End Class
