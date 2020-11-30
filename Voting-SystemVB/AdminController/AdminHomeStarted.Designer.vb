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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FontAwesome1 = New Voting_SystemVB.FontAwesome()
        Me.LabelVotersCount = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.FontAwesome2 = New Voting_SystemVB.FontAwesome()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelDoneVoters = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2ImageButton2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonPRO = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonAuditor = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonTreasurer = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSecretary = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2ShadowPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.FontAwesome3 = New Voting_SystemVB.FontAwesome()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelRemainingVoters = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2ImageButton3 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ResultPanel = New System.Windows.Forms.Panel()
        Me.ChartVoteCount = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ButtonRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DisplayPieChart = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.LabelLastUpdate = New Guna.UI2.WinForms.Guna2Chip()
        Me.Panel1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2ShadowPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Guna2ShadowPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ResultPanel.SuspendLayout()
        CType(Me.ChartVoteCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2ImageButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 32)
        Me.Panel1.TabIndex = 0
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = Global.Voting_SystemVB.My.Resources.Resources.arrow_circle_right_white
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(15, 15)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(152, 9)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(15, 15)
        Me.Guna2ImageButton1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(93, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "More Info"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.FontAwesome1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LabelVotersCount)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Panel1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(28, 28)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(279, 127)
        Me.Guna2ShadowPanel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total No. of Voters"
        '
        'FontAwesome1
        '
        Me.FontAwesome1.AutoSize = True
        Me.FontAwesome1.Font = New System.Drawing.Font("Font Awesome 5 Free Solid", 36.0!)
        Me.FontAwesome1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.FontAwesome1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.FontAwesome1.Location = New System.Drawing.Point(169, 22)
        Me.FontAwesome1.Name = "FontAwesome1"
        Me.FontAwesome1.Size = New System.Drawing.Size(82, 51)
        Me.FontAwesome1.TabIndex = 4
        Me.FontAwesome1.Text = "users"
        '
        'LabelVotersCount
        '
        Me.LabelVotersCount.AutoSize = True
        Me.LabelVotersCount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelVotersCount.ForeColor = System.Drawing.Color.White
        Me.LabelVotersCount.Location = New System.Drawing.Point(12, 22)
        Me.LabelVotersCount.Name = "LabelVotersCount"
        Me.LabelVotersCount.Size = New System.Drawing.Size(29, 32)
        Me.LabelVotersCount.TabIndex = 3
        Me.LabelVotersCount.Text = "0"
        '
        'Guna2ShadowPanel2
        '
        Me.Guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel2.Controls.Add(Me.FontAwesome2)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label4)
        Me.Guna2ShadowPanel2.Controls.Add(Me.LabelDoneVoters)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Panel2)
        Me.Guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2ShadowPanel2.Location = New System.Drawing.Point(28, 168)
        Me.Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Me.Guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel2.Size = New System.Drawing.Size(279, 127)
        Me.Guna2ShadowPanel2.TabIndex = 5
        '
        'FontAwesome2
        '
        Me.FontAwesome2.AutoSize = True
        Me.FontAwesome2.Font = New System.Drawing.Font("Font Awesome 5 Free Solid", 36.0!)
        Me.FontAwesome2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.FontAwesome2.HoverColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.FontAwesome2.Location = New System.Drawing.Point(181, 22)
        Me.FontAwesome2.Name = "FontAwesome2"
        Me.FontAwesome2.Size = New System.Drawing.Size(70, 51)
        Me.FontAwesome2.TabIndex = 4
        Me.FontAwesome2.Text = "check-double"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Voters who already voted"
        '
        'LabelDoneVoters
        '
        Me.LabelDoneVoters.AutoSize = True
        Me.LabelDoneVoters.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelDoneVoters.ForeColor = System.Drawing.Color.White
        Me.LabelDoneVoters.Location = New System.Drawing.Point(12, 22)
        Me.LabelDoneVoters.Name = "LabelDoneVoters"
        Me.LabelDoneVoters.Size = New System.Drawing.Size(29, 32)
        Me.LabelDoneVoters.TabIndex = 3
        Me.LabelDoneVoters.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Guna2ImageButton2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(5, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 32)
        Me.Panel2.TabIndex = 0
        '
        'Guna2ImageButton2
        '
        Me.Guna2ImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton2.CheckedState.Parent = Me.Guna2ImageButton2
        Me.Guna2ImageButton2.HoverState.Parent = Me.Guna2ImageButton2
        Me.Guna2ImageButton2.Image = Global.Voting_SystemVB.My.Resources.Resources.arrow_circle_right_white
        Me.Guna2ImageButton2.ImageSize = New System.Drawing.Size(15, 15)
        Me.Guna2ImageButton2.Location = New System.Drawing.Point(152, 9)
        Me.Guna2ImageButton2.Name = "Guna2ImageButton2"
        Me.Guna2ImageButton2.PressedState.Parent = Me.Guna2ImageButton2
        Me.Guna2ImageButton2.Size = New System.Drawing.Size(15, 15)
        Me.Guna2ImageButton2.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(93, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "More Info"
        '
        'ButtonPRO
        '
        Me.ButtonPRO.CheckedState.Parent = Me.ButtonPRO
        Me.ButtonPRO.CustomImages.Parent = Me.ButtonPRO
        Me.ButtonPRO.FillColor = System.Drawing.Color.White
        Me.ButtonPRO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonPRO.ForeColor = System.Drawing.Color.Black
        Me.ButtonPRO.HoverState.Parent = Me.ButtonPRO
        Me.ButtonPRO.Location = New System.Drawing.Point(410, 0)
        Me.ButtonPRO.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPRO.Name = "ButtonPRO"
        Me.ButtonPRO.ShadowDecoration.Parent = Me.ButtonPRO
        Me.ButtonPRO.Size = New System.Drawing.Size(82, 28)
        Me.ButtonPRO.TabIndex = 7
        Me.ButtonPRO.Tag = "6"
        Me.ButtonPRO.Text = "P.R.O."
        '
        'ButtonAuditor
        '
        Me.ButtonAuditor.CheckedState.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.CustomImages.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.FillColor = System.Drawing.Color.White
        Me.ButtonAuditor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonAuditor.ForeColor = System.Drawing.Color.Black
        Me.ButtonAuditor.HoverState.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.Location = New System.Drawing.Point(328, 0)
        Me.ButtonAuditor.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonAuditor.Name = "ButtonAuditor"
        Me.ButtonAuditor.ShadowDecoration.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.Size = New System.Drawing.Size(82, 28)
        Me.ButtonAuditor.TabIndex = 8
        Me.ButtonAuditor.Tag = "5"
        Me.ButtonAuditor.Text = "Auditor"
        '
        'ButtonTreasurer
        '
        Me.ButtonTreasurer.CheckedState.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.CustomImages.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.FillColor = System.Drawing.Color.White
        Me.ButtonTreasurer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonTreasurer.ForeColor = System.Drawing.Color.Black
        Me.ButtonTreasurer.HoverState.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.Location = New System.Drawing.Point(246, 0)
        Me.ButtonTreasurer.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonTreasurer.Name = "ButtonTreasurer"
        Me.ButtonTreasurer.ShadowDecoration.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.Size = New System.Drawing.Size(82, 28)
        Me.ButtonTreasurer.TabIndex = 9
        Me.ButtonTreasurer.Tag = "4"
        Me.ButtonTreasurer.Text = "Treasurer"
        '
        'ButtonSecretary
        '
        Me.ButtonSecretary.CheckedState.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.CustomImages.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.FillColor = System.Drawing.Color.White
        Me.ButtonSecretary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSecretary.ForeColor = System.Drawing.Color.Black
        Me.ButtonSecretary.HoverState.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.Location = New System.Drawing.Point(164, 0)
        Me.ButtonSecretary.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonSecretary.Name = "ButtonSecretary"
        Me.ButtonSecretary.ShadowDecoration.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.Size = New System.Drawing.Size(82, 28)
        Me.ButtonSecretary.TabIndex = 10
        Me.ButtonSecretary.Tag = "3"
        Me.ButtonSecretary.Text = "Secretary"
        '
        'ButtonVPresident
        '
        Me.ButtonVPresident.CheckedState.Parent = Me.ButtonVPresident
        Me.ButtonVPresident.CustomImages.Parent = Me.ButtonVPresident
        Me.ButtonVPresident.FillColor = System.Drawing.Color.White
        Me.ButtonVPresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVPresident.ForeColor = System.Drawing.Color.Black
        Me.ButtonVPresident.HoverState.Parent = Me.ButtonVPresident
        Me.ButtonVPresident.Location = New System.Drawing.Point(82, 0)
        Me.ButtonVPresident.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVPresident.Name = "ButtonVPresident"
        Me.ButtonVPresident.ShadowDecoration.Parent = Me.ButtonVPresident
        Me.ButtonVPresident.Size = New System.Drawing.Size(82, 28)
        Me.ButtonVPresident.TabIndex = 11
        Me.ButtonVPresident.Tag = "2"
        Me.ButtonVPresident.Text = "Vice President"
        '
        'ButtonPresident
        '
        Me.ButtonPresident.CheckedState.Parent = Me.ButtonPresident
        Me.ButtonPresident.CustomImages.Parent = Me.ButtonPresident
        Me.ButtonPresident.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ButtonPresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonPresident.ForeColor = System.Drawing.Color.White
        Me.ButtonPresident.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ButtonPresident.HoverState.Parent = Me.ButtonPresident
        Me.ButtonPresident.Location = New System.Drawing.Point(0, 0)
        Me.ButtonPresident.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPresident.Name = "ButtonPresident"
        Me.ButtonPresident.ShadowDecoration.Parent = Me.ButtonPresident
        Me.ButtonPresident.Size = New System.Drawing.Size(82, 28)
        Me.ButtonPresident.TabIndex = 12
        Me.ButtonPresident.Tag = "1"
        Me.ButtonPresident.Text = "President"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonPresident)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonVPresident)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonSecretary)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonTreasurer)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonAuditor)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonPRO)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(323, 33)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(492, 28)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Guna2ShadowPanel3
        '
        Me.Guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel3.Controls.Add(Me.FontAwesome3)
        Me.Guna2ShadowPanel3.Controls.Add(Me.Label7)
        Me.Guna2ShadowPanel3.Controls.Add(Me.LabelRemainingVoters)
        Me.Guna2ShadowPanel3.Controls.Add(Me.Panel3)
        Me.Guna2ShadowPanel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2ShadowPanel3.Location = New System.Drawing.Point(28, 308)
        Me.Guna2ShadowPanel3.Name = "Guna2ShadowPanel3"
        Me.Guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel3.Size = New System.Drawing.Size(279, 127)
        Me.Guna2ShadowPanel3.TabIndex = 6
        '
        'FontAwesome3
        '
        Me.FontAwesome3.AutoSize = True
        Me.FontAwesome3.Font = New System.Drawing.Font("Font Awesome 5 Free Solid", 36.0!)
        Me.FontAwesome3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.FontAwesome3.HoverColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.FontAwesome3.Location = New System.Drawing.Point(169, 22)
        Me.FontAwesome3.Name = "FontAwesome3"
        Me.FontAwesome3.Size = New System.Drawing.Size(82, 51)
        Me.FontAwesome3.TabIndex = 4
        Me.FontAwesome3.Text = "vote-yea"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Remaing Voters"
        '
        'LabelRemainingVoters
        '
        Me.LabelRemainingVoters.AutoSize = True
        Me.LabelRemainingVoters.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelRemainingVoters.ForeColor = System.Drawing.Color.White
        Me.LabelRemainingVoters.Location = New System.Drawing.Point(12, 22)
        Me.LabelRemainingVoters.Name = "LabelRemainingVoters"
        Me.LabelRemainingVoters.Size = New System.Drawing.Size(29, 32)
        Me.LabelRemainingVoters.TabIndex = 3
        Me.LabelRemainingVoters.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Guna2ImageButton3)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(5, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(269, 32)
        Me.Panel3.TabIndex = 0
        '
        'Guna2ImageButton3
        '
        Me.Guna2ImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton3.CheckedState.Parent = Me.Guna2ImageButton3
        Me.Guna2ImageButton3.HoverState.Parent = Me.Guna2ImageButton3
        Me.Guna2ImageButton3.Image = Global.Voting_SystemVB.My.Resources.Resources.arrow_circle_right_white
        Me.Guna2ImageButton3.ImageSize = New System.Drawing.Size(15, 15)
        Me.Guna2ImageButton3.Location = New System.Drawing.Point(152, 9)
        Me.Guna2ImageButton3.Name = "Guna2ImageButton3"
        Me.Guna2ImageButton3.PressedState.Parent = Me.Guna2ImageButton3
        Me.Guna2ImageButton3.Size = New System.Drawing.Size(15, 15)
        Me.Guna2ImageButton3.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(93, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "More Info"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.ResultPanel)
        Me.Panel4.Controls.Add(Me.Guna2Separator1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.LabelLastUpdate)
        Me.Panel4.Location = New System.Drawing.Point(323, 61)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(558, 399)
        Me.Panel4.TabIndex = 7
        '
        'ResultPanel
        '
        Me.ResultPanel.AutoScroll = True
        Me.ResultPanel.Controls.Add(Me.ChartVoteCount)
        Me.ResultPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultPanel.Location = New System.Drawing.Point(0, 64)
        Me.ResultPanel.Name = "ResultPanel"
        Me.ResultPanel.Size = New System.Drawing.Size(558, 335)
        Me.ResultPanel.TabIndex = 7
        '
        'ChartVoteCount
        '
        ChartArea1.Name = "ChartAreaDonut"
        ChartArea2.Name = "ChartAreaBar"
        Me.ChartVoteCount.ChartAreas.Add(ChartArea1)
        Me.ChartVoteCount.ChartAreas.Add(ChartArea2)
        Me.ChartVoteCount.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Legend2.Enabled = False
        Legend2.Name = "Legend2"
        Me.ChartVoteCount.Legends.Add(Legend1)
        Me.ChartVoteCount.Legends.Add(Legend2)
        Me.ChartVoteCount.Location = New System.Drawing.Point(0, 0)
        Me.ChartVoteCount.Name = "ChartVoteCount"
        Series1.ChartArea = "ChartAreaDonut"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartAreaBar"
        Series2.Legend = "Legend2"
        Series2.Name = "Series2"
        Me.ChartVoteCount.Series.Add(Series1)
        Me.ChartVoteCount.Series.Add(Series2)
        Me.ChartVoteCount.Size = New System.Drawing.Size(558, 335)
        Me.ChartVoteCount.TabIndex = 0
        Me.ChartVoteCount.Text = "Chart1"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 54)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(558, 10)
        Me.Guna2Separator1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ButtonRefresh)
        Me.Panel5.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel5.Controls.Add(Me.DisplayPieChart)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 23)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(558, 31)
        Me.Panel5.TabIndex = 6
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BorderRadius = 10
        Me.ButtonRefresh.CheckedState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.CustomImages.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.White
        Me.ButtonRefresh.HoverState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Location = New System.Drawing.Point(478, 5)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.ShadowDecoration.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Size = New System.Drawing.Size(77, 20)
        Me.ButtonRefresh.TabIndex = 6
        Me.ButtonRefresh.Text = "Refresh"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 8)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(93, 19)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "Display Chart:"
        '
        'DisplayPieChart
        '
        Me.DisplayPieChart.Checked = True
        Me.DisplayPieChart.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayPieChart.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayPieChart.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.DisplayPieChart.CheckedState.InnerColor = System.Drawing.Color.White
        Me.DisplayPieChart.CheckedState.Parent = Me.DisplayPieChart
        Me.DisplayPieChart.Location = New System.Drawing.Point(111, 6)
        Me.DisplayPieChart.Name = "DisplayPieChart"
        Me.DisplayPieChart.ShadowDecoration.Parent = Me.DisplayPieChart
        Me.DisplayPieChart.Size = New System.Drawing.Size(35, 20)
        Me.DisplayPieChart.TabIndex = 4
        Me.DisplayPieChart.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DisplayPieChart.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DisplayPieChart.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.DisplayPieChart.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.DisplayPieChart.UncheckedState.Parent = Me.DisplayPieChart
        '
        'LabelLastUpdate
        '
        Me.LabelLastUpdate.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelLastUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.LabelLastUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelLastUpdate.ForeColor = System.Drawing.Color.White
        Me.LabelLastUpdate.Location = New System.Drawing.Point(0, 0)
        Me.LabelLastUpdate.Name = "LabelLastUpdate"
        Me.LabelLastUpdate.ShadowDecoration.Parent = Me.LabelLastUpdate
        Me.LabelLastUpdate.Size = New System.Drawing.Size(558, 23)
        Me.LabelLastUpdate.TabIndex = 2
        Me.LabelLastUpdate.Text = "Result As of: November 11, 2020 7:16 am"
        Me.LabelLastUpdate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'AdminHomeStarted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Guna2ShadowPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Guna2ShadowPanel2)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Name = "AdminHomeStarted"
        Me.Size = New System.Drawing.Size(913, 481)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.Guna2ShadowPanel2.ResumeLayout(False)
        Me.Guna2ShadowPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel3.ResumeLayout(False)
        Me.Guna2ShadowPanel3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResultPanel.ResumeLayout(False)
        CType(Me.ChartVoteCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents FontAwesome1 As Voting_SystemVB.FontAwesome
    Friend WithEvents LabelVotersCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FontAwesome2 As Voting_SystemVB.FontAwesome
    Friend WithEvents LabelDoneVoters As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Guna2ImageButton2 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonPRO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonAuditor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonTreasurer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSecretary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Guna2ShadowPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents FontAwesome3 As Voting_SystemVB.FontAwesome
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelRemainingVoters As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Guna2ImageButton3 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LabelLastUpdate As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents ResultPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ButtonRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DisplayPieChart As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents ChartVoteCount As System.Windows.Forms.DataVisualization.Charting.Chart

End Class
