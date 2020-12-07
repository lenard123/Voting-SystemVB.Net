<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomeEnded
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.President = New Guna.UI2.WinForms.Guna2Button()
        Me.VPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.Secretary = New Guna.UI2.WinForms.Guna2Button()
        Me.Treasurer = New Guna.UI2.WinForms.Guna2Button()
        Me.Auditor = New Guna.UI2.WinForms.Guna2Button()
        Me.PRO = New Guna.UI2.WinForms.Guna2Button()
        Me.ShowCandidates = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelChart = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ViewChart = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LoadingPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2WinProgressIndicator1 = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.BackgroundWorkerFetchResult = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.ShowCandidates.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelChart.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadingPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(88, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 157)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 112)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(20)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(649, 40)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(2, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(637, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "(2020 Student Council Election)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(637, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Congratulations To All the winner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.AutoScroll = True
        Me.MainPanel.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.MainPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.MainPanel.Controls.Add(Me.LoadingPanel)
        Me.MainPanel.Location = New System.Drawing.Point(37, 25)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(864, 430)
        Me.MainPanel.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(833, 929)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel3.Controls.Add(Me.ShowCandidates)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(3, 166)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(827, 386)
        Me.Panel3.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.President)
        Me.FlowLayoutPanel2.Controls.Add(Me.VPresident)
        Me.FlowLayoutPanel2.Controls.Add(Me.Secretary)
        Me.FlowLayoutPanel2.Controls.Add(Me.Treasurer)
        Me.FlowLayoutPanel2.Controls.Add(Me.Auditor)
        Me.FlowLayoutPanel2.Controls.Add(Me.PRO)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(13, 116)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(148, 262)
        Me.FlowLayoutPanel2.TabIndex = 35
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
        'ShowCandidates
        '
        Me.ShowCandidates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowCandidates.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ShowCandidates.Controls.Add(Me.Panel4)
        Me.ShowCandidates.Controls.Add(Me.ViewChart)
        Me.ShowCandidates.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ShowCandidates.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowCandidates.ForeColor = System.Drawing.Color.White
        Me.ShowCandidates.Location = New System.Drawing.Point(168, 116)
        Me.ShowCandidates.Margin = New System.Windows.Forms.Padding(4)
        Me.ShowCandidates.Name = "ShowCandidates"
        Me.ShowCandidates.ShadowDecoration.Parent = Me.ShowCandidates
        Me.ShowCandidates.Size = New System.Drawing.Size(655, 266)
        Me.ShowCandidates.TabIndex = 34
        Me.ShowCandidates.Text = "Results as of 6:00am"
        Me.ShowCandidates.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.PanelChart)
        Me.Panel4.Location = New System.Drawing.Point(14, 54)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(628, 195)
        Me.Panel4.TabIndex = 22
        '
        'PanelChart
        '
        Me.PanelChart.Controls.Add(Me.Chart1)
        Me.PanelChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChart.Location = New System.Drawing.Point(0, 0)
        Me.PanelChart.Name = "PanelChart"
        Me.PanelChart.Size = New System.Drawing.Size(628, 195)
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
        Me.Chart1.Size = New System.Drawing.Size(628, 195)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'ViewChart
        '
        Me.ViewChart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewChart.AutoSize = True
        Me.ViewChart.BackColor = System.Drawing.Color.Transparent
        Me.ViewChart.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewChart.Location = New System.Drawing.Point(508, 54)
        Me.ViewChart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ViewChart.Name = "ViewChart"
        Me.ViewChart.Size = New System.Drawing.Size(69, 17)
        Me.ViewChart.TabIndex = 21
        Me.ViewChart.Text = "Bar Chart"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(311, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Final Vote Counts"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(3, 558)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 368)
        Me.Panel2.TabIndex = 3
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.Panel5)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(13, 30)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(810, 318)
        Me.Guna2GroupBox1.TabIndex = 35
        Me.Guna2GroupBox1.Text = "Parties"
        Me.Guna2GroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(14, 54)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(783, 247)
        Me.Panel5.TabIndex = 22
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Chart2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(783, 247)
        Me.Panel6.TabIndex = 1
        '
        'Chart2
        '
        ChartArea2.Name = "ChartAreaBar"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend2"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(0, 0)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Size = New System.Drawing.Size(783, 247)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(663, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Bar Chart"
        '
        'LoadingPanel
        '
        Me.LoadingPanel.Controls.Add(Me.Label3)
        Me.LoadingPanel.Controls.Add(Me.Guna2WinProgressIndicator1)
        Me.LoadingPanel.Location = New System.Drawing.Point(0, 0)
        Me.LoadingPanel.Name = "LoadingPanel"
        Me.LoadingPanel.Size = New System.Drawing.Size(841, 430)
        Me.LoadingPanel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(317, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 60)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fetching Final Results" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please Wait"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2WinProgressIndicator1
        '
        Me.Guna2WinProgressIndicator1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2WinProgressIndicator1.CircleSize = 1.0!
        Me.Guna2WinProgressIndicator1.Location = New System.Drawing.Point(346, 77)
        Me.Guna2WinProgressIndicator1.Name = "Guna2WinProgressIndicator1"
        Me.Guna2WinProgressIndicator1.Size = New System.Drawing.Size(156, 156)
        Me.Guna2WinProgressIndicator1.TabIndex = 0
        '
        'BackgroundWorkerFetchResult
        '
        '
        'AdminHomeEnded
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "AdminHomeEnded"
        Me.Size = New System.Drawing.Size(916, 481)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ShowCandidates.ResumeLayout(False)
        Me.ShowCandidates.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.PanelChart.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadingPanel.ResumeLayout(False)
        Me.LoadingPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents President As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Secretary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Treasurer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Auditor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PRO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ShowCandidates As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PanelChart As System.Windows.Forms.Panel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ViewChart As System.Windows.Forms.Label
    Friend WithEvents LoadingPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Guna2WinProgressIndicator1 As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents BackgroundWorkerFetchResult As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
