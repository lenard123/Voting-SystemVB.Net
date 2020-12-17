<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomeStarted
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
        Me.VPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.Secretary = New Guna.UI2.WinForms.Guna2Button()
        Me.Treasurer = New Guna.UI2.WinForms.Guna2Button()
        Me.Auditor = New Guna.UI2.WinForms.Guna2Button()
        Me.PRO = New Guna.UI2.WinForms.Guna2Button()
        Me.ViewChart = New System.Windows.Forms.Label()
        Me.ShowCandidates = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.ButtonRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelChart = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TotalVotersCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalVotersCount = New System.Windows.Forms.Label()
        Me.AlreadyVotedCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AlreadyVotedCount = New System.Windows.Forms.Label()
        Me.RemainingVotersCircle = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RemainingVotersCount = New System.Windows.Forms.Label()
        Me.BackgroundWorkerInit = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerRefresh = New System.ComponentModel.BackgroundWorker()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.President = New Guna.UI2.WinForms.Guna2Button()
        Me.ShowCandidates.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelChart.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TotalVotersCircle.SuspendLayout()
        Me.AlreadyVotedCircle.SuspendLayout()
        Me.RemainingVotersCircle.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VPresident
        '
        Me.VPresident.Animated = True
        Me.VPresident.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.VPresident.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.VPresident.CheckedState.ForeColor = System.Drawing.Color.White
        Me.VPresident.CheckedState.Parent = Me.VPresident
        Me.VPresident.CustomImages.Parent = Me.VPresident
        Me.VPresident.FillColor = System.Drawing.Color.White
        Me.VPresident.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VPresident.ForeColor = System.Drawing.Color.Black
        Me.VPresident.HoverState.Parent = Me.VPresident
        Me.VPresident.Location = New System.Drawing.Point(0, 37)
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
        Me.Secretary.Animated = True
        Me.Secretary.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Secretary.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Secretary.CheckedState.ForeColor = System.Drawing.Color.White
        Me.Secretary.CheckedState.Parent = Me.Secretary
        Me.Secretary.CustomImages.Parent = Me.Secretary
        Me.Secretary.FillColor = System.Drawing.Color.White
        Me.Secretary.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Secretary.ForeColor = System.Drawing.Color.Black
        Me.Secretary.HoverState.Parent = Me.Secretary
        Me.Secretary.Location = New System.Drawing.Point(0, 74)
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
        Me.Treasurer.Animated = True
        Me.Treasurer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Treasurer.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Treasurer.CheckedState.ForeColor = System.Drawing.Color.White
        Me.Treasurer.CheckedState.Parent = Me.Treasurer
        Me.Treasurer.CustomImages.Parent = Me.Treasurer
        Me.Treasurer.FillColor = System.Drawing.Color.White
        Me.Treasurer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Treasurer.ForeColor = System.Drawing.Color.Black
        Me.Treasurer.HoverState.Parent = Me.Treasurer
        Me.Treasurer.Location = New System.Drawing.Point(0, 111)
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
        Me.Auditor.Animated = True
        Me.Auditor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Auditor.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Auditor.CheckedState.ForeColor = System.Drawing.Color.White
        Me.Auditor.CheckedState.Parent = Me.Auditor
        Me.Auditor.CustomImages.Parent = Me.Auditor
        Me.Auditor.FillColor = System.Drawing.Color.White
        Me.Auditor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Auditor.ForeColor = System.Drawing.Color.Black
        Me.Auditor.HoverState.Parent = Me.Auditor
        Me.Auditor.Location = New System.Drawing.Point(0, 148)
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
        Me.PRO.Animated = True
        Me.PRO.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.PRO.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.PRO.CheckedState.ForeColor = System.Drawing.Color.White
        Me.PRO.CheckedState.Parent = Me.PRO
        Me.PRO.CustomImages.Parent = Me.PRO
        Me.PRO.FillColor = System.Drawing.Color.White
        Me.PRO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRO.ForeColor = System.Drawing.Color.Black
        Me.PRO.HoverState.Parent = Me.PRO
        Me.PRO.Location = New System.Drawing.Point(0, 185)
        Me.PRO.Margin = New System.Windows.Forms.Padding(0)
        Me.PRO.Name = "PRO"
        Me.PRO.ShadowDecoration.Parent = Me.PRO
        Me.PRO.Size = New System.Drawing.Size(144, 37)
        Me.PRO.TabIndex = 18
        Me.PRO.Tag = "6"
        Me.PRO.Text = "P.R.O."
        '
        'ViewChart
        '
        Me.ViewChart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewChart.AutoSize = True
        Me.ViewChart.BackColor = System.Drawing.Color.Transparent
        Me.ViewChart.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewChart.Location = New System.Drawing.Point(567, 54)
        Me.ViewChart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ViewChart.Name = "ViewChart"
        Me.ViewChart.Size = New System.Drawing.Size(69, 17)
        Me.ViewChart.TabIndex = 21
        Me.ViewChart.Text = "Bar Chart"
        '
        'ShowCandidates
        '
        Me.ShowCandidates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowCandidates.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ShowCandidates.Controls.Add(Me.ButtonRefresh)
        Me.ShowCandidates.Controls.Add(Me.Panel1)
        Me.ShowCandidates.Controls.Add(Me.ViewChart)
        Me.ShowCandidates.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ShowCandidates.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowCandidates.ForeColor = System.Drawing.Color.White
        Me.ShowCandidates.Location = New System.Drawing.Point(180, 193)
        Me.ShowCandidates.Margin = New System.Windows.Forms.Padding(4)
        Me.ShowCandidates.Name = "ShowCandidates"
        Me.ShowCandidates.ShadowDecoration.Parent = Me.ShowCandidates
        Me.ShowCandidates.Size = New System.Drawing.Size(714, 265)
        Me.ShowCandidates.TabIndex = 22
        Me.ShowCandidates.Text = "Results as of 6:00am"
        Me.ShowCandidates.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRefresh.Animated = True
        Me.ButtonRefresh.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRefresh.BorderRadius = 5
        Me.ButtonRefresh.Checked = True
        Me.ButtonRefresh.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRefresh.CheckedState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.CustomImages.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.FillColor = System.Drawing.Color.Empty
        Me.ButtonRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.White
        Me.ButtonRefresh.HoverState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Location = New System.Drawing.Point(598, 7)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.ShadowDecoration.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Size = New System.Drawing.Size(103, 26)
        Me.ButtonRefresh.TabIndex = 23
        Me.ButtonRefresh.Text = "Refresh"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PanelChart)
        Me.Panel1.Location = New System.Drawing.Point(14, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 194)
        Me.Panel1.TabIndex = 22
        '
        'PanelChart
        '
        Me.PanelChart.Controls.Add(Me.Chart1)
        Me.PanelChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChart.Location = New System.Drawing.Point(0, 0)
        Me.PanelChart.Name = "PanelChart"
        Me.PanelChart.Size = New System.Drawing.Size(687, 194)
        Me.PanelChart.TabIndex = 1
        '
        'Chart1
        '
        ChartArea1.Name = "ChartAreaBar"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend2"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartAreaBar"
        Series1.Legend = "Legend2"
        Series1.Name = "Series2"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(687, 194)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'TotalVotersCircle
        '
        Me.TotalVotersCircle.AccessibleName = "TotalVotersCircle"
        Me.TotalVotersCircle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TotalVotersCircle.Animated = True
        Me.TotalVotersCircle.AnimationSpeed = 2.0!
        Me.TotalVotersCircle.Controls.Add(Me.Label1)
        Me.TotalVotersCircle.Controls.Add(Me.TotalVotersCount)
        Me.TotalVotersCircle.FillThickness = 10
        Me.TotalVotersCircle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TotalVotersCircle.Location = New System.Drawing.Point(213, 12)
        Me.TotalVotersCircle.Name = "TotalVotersCircle"
        Me.TotalVotersCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TotalVotersCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TotalVotersCircle.ProgressThickness = 10
        Me.TotalVotersCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.TotalVotersCircle.ShadowDecoration.Parent = Me.TotalVotersCircle
        Me.TotalVotersCircle.Size = New System.Drawing.Size(153, 153)
        Me.TotalVotersCircle.TabIndex = 30
        Me.TotalVotersCircle.Value = 100
        '
        'Label1
        '
        Me.Label1.AccessibleName = "TotalVotersDesc"
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
        'TotalVotersCount
        '
        Me.TotalVotersCount.AccessibleName = "TotalVotersCount"
        Me.TotalVotersCount.BackColor = System.Drawing.Color.Transparent
        Me.TotalVotersCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.TotalVotersCount.Location = New System.Drawing.Point(3, 45)
        Me.TotalVotersCount.Name = "TotalVotersCount"
        Me.TotalVotersCount.Size = New System.Drawing.Size(147, 38)
        Me.TotalVotersCount.TabIndex = 0
        Me.TotalVotersCount.Text = "0"
        Me.TotalVotersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AlreadyVotedCircle
        '
        Me.AlreadyVotedCircle.AccessibleName = "AlreadyVotedCircle"
        Me.AlreadyVotedCircle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AlreadyVotedCircle.AnimationSpeed = 2.0!
        Me.AlreadyVotedCircle.Controls.Add(Me.Label2)
        Me.AlreadyVotedCircle.Controls.Add(Me.AlreadyVotedCount)
        Me.AlreadyVotedCircle.FillThickness = 10
        Me.AlreadyVotedCircle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlreadyVotedCircle.Location = New System.Drawing.Point(396, 12)
        Me.AlreadyVotedCircle.Name = "AlreadyVotedCircle"
        Me.AlreadyVotedCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.AlreadyVotedCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.AlreadyVotedCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
        Me.AlreadyVotedCircle.ProgressThickness = 10
        Me.AlreadyVotedCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.AlreadyVotedCircle.ShadowDecoration.Parent = Me.AlreadyVotedCircle
        Me.AlreadyVotedCircle.Size = New System.Drawing.Size(153, 153)
        Me.AlreadyVotedCircle.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AccessibleName = "AlreadyVotedDesc"
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
        'AlreadyVotedCount
        '
        Me.AlreadyVotedCount.AccessibleName = "AlreadyVotedCount"
        Me.AlreadyVotedCount.BackColor = System.Drawing.Color.Transparent
        Me.AlreadyVotedCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AlreadyVotedCount.Location = New System.Drawing.Point(3, 45)
        Me.AlreadyVotedCount.Name = "AlreadyVotedCount"
        Me.AlreadyVotedCount.Size = New System.Drawing.Size(147, 38)
        Me.AlreadyVotedCount.TabIndex = 0
        Me.AlreadyVotedCount.Text = "0"
        Me.AlreadyVotedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RemainingVotersCircle
        '
        Me.RemainingVotersCircle.AccessibleName = "RemainingVotersCircle"
        Me.RemainingVotersCircle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RemainingVotersCircle.AnimationSpeed = 2.0!
        Me.RemainingVotersCircle.Controls.Add(Me.Label4)
        Me.RemainingVotersCircle.Controls.Add(Me.RemainingVotersCount)
        Me.RemainingVotersCircle.FillThickness = 10
        Me.RemainingVotersCircle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.RemainingVotersCircle.Location = New System.Drawing.Point(579, 12)
        Me.RemainingVotersCircle.Name = "RemainingVotersCircle"
        Me.RemainingVotersCircle.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.RemainingVotersCircle.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.RemainingVotersCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
        Me.RemainingVotersCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Square
        Me.RemainingVotersCircle.ProgressThickness = 10
        Me.RemainingVotersCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.RemainingVotersCircle.ShadowDecoration.Parent = Me.RemainingVotersCircle
        Me.RemainingVotersCircle.Size = New System.Drawing.Size(153, 153)
        Me.RemainingVotersCircle.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AccessibleName = "RemainingVotersDesc"
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
        'RemainingVotersCount
        '
        Me.RemainingVotersCount.AccessibleName = "RemainingVotersCount"
        Me.RemainingVotersCount.BackColor = System.Drawing.Color.Transparent
        Me.RemainingVotersCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.RemainingVotersCount.Location = New System.Drawing.Point(0, 45)
        Me.RemainingVotersCount.Name = "RemainingVotersCount"
        Me.RemainingVotersCount.Size = New System.Drawing.Size(150, 38)
        Me.RemainingVotersCount.TabIndex = 0
        Me.RemainingVotersCount.Text = "0"
        Me.RemainingVotersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundWorkerInit
        '
        '
        'BackgroundWorkerRefresh
        '
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Separator1.Location = New System.Drawing.Point(32, 171)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(862, 10)
        Me.Guna2Separator1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.President)
        Me.FlowLayoutPanel1.Controls.Add(Me.VPresident)
        Me.FlowLayoutPanel1.Controls.Add(Me.Secretary)
        Me.FlowLayoutPanel1.Controls.Add(Me.Treasurer)
        Me.FlowLayoutPanel1.Controls.Add(Me.Auditor)
        Me.FlowLayoutPanel1.Controls.Add(Me.PRO)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(32, 196)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(141, 262)
        Me.FlowLayoutPanel1.TabIndex = 33
        '
        'President
        '
        Me.President.Animated = True
        Me.President.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.President.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.President.CheckedState.ForeColor = System.Drawing.Color.White
        Me.President.CheckedState.Parent = Me.President
        Me.President.CustomImages.Parent = Me.President
        Me.President.FillColor = System.Drawing.Color.White
        Me.President.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.President.ForeColor = System.Drawing.Color.Black
        Me.President.HoverState.Parent = Me.President
        Me.President.Location = New System.Drawing.Point(0, 0)
        Me.President.Margin = New System.Windows.Forms.Padding(0)
        Me.President.Name = "President"
        Me.President.ShadowDecoration.Parent = Me.President
        Me.President.Size = New System.Drawing.Size(144, 37)
        Me.President.TabIndex = 19
        Me.President.Tag = "1"
        Me.President.Text = "President"
        '
        'AdminHomeStarted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.RemainingVotersCircle)
        Me.Controls.Add(Me.AlreadyVotedCircle)
        Me.Controls.Add(Me.TotalVotersCircle)
        Me.Controls.Add(Me.ShowCandidates)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminHomeStarted"
        Me.Size = New System.Drawing.Size(916, 481)
        Me.ShowCandidates.ResumeLayout(False)
        Me.ShowCandidates.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelChart.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TotalVotersCircle.ResumeLayout(False)
        Me.TotalVotersCircle.PerformLayout()
        Me.AlreadyVotedCircle.ResumeLayout(False)
        Me.AlreadyVotedCircle.PerformLayout()
        Me.RemainingVotersCircle.ResumeLayout(False)
        Me.RemainingVotersCircle.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Secretary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Treasurer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Auditor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PRO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ViewChart As System.Windows.Forms.Label
    Friend WithEvents ShowCandidates As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TotalVotersCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AlreadyVotedCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AlreadyVotedCount As System.Windows.Forms.Label
    Friend WithEvents RemainingVotersCircle As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RemainingVotersCount As System.Windows.Forms.Label
    Friend WithEvents TotalVotersCount As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelChart As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorkerInit As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerRefresh As System.ComponentModel.BackgroundWorker
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents President As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonRefresh As Guna.UI2.WinForms.Guna2Button
End Class
