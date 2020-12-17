<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoteCount
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim StripLine2 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelDesc = New System.Windows.Forms.Label()
        Me.PositionGroup = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVicePresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSecretary = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonTreasurer = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonAuditor = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonPRO = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PositionGroup.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Vote Count"
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelDesc.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LabelDesc.Location = New System.Drawing.Point(36, 64)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(149, 19)
        Me.LabelDesc.TabIndex = 2
        Me.LabelDesc.Text = "Results as of 6:54 am"
        '
        'PositionGroup
        '
        Me.PositionGroup.Controls.Add(Me.BtnRefresh)
        Me.PositionGroup.Controls.Add(Me.ButtonPresident)
        Me.PositionGroup.Controls.Add(Me.ButtonVicePresident)
        Me.PositionGroup.Controls.Add(Me.ButtonSecretary)
        Me.PositionGroup.Controls.Add(Me.ButtonTreasurer)
        Me.PositionGroup.Controls.Add(Me.ButtonAuditor)
        Me.PositionGroup.Controls.Add(Me.ButtonPRO)
        Me.PositionGroup.Location = New System.Drawing.Point(40, 101)
        Me.PositionGroup.Name = "PositionGroup"
        Me.PositionGroup.Size = New System.Drawing.Size(889, 37)
        Me.PositionGroup.TabIndex = 3
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Animated = True
        Me.BtnRefresh.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnRefresh.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.CheckedState.Parent = Me.BtnRefresh
        Me.BtnRefresh.CustomImages.Parent = Me.BtnRefresh
        Me.BtnRefresh.FillColor = System.Drawing.Color.Empty
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.HoverState.Parent = Me.BtnRefresh
        Me.BtnRefresh.Location = New System.Drawing.Point(3, 3)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.ShadowDecoration.Parent = Me.BtnRefresh
        Me.BtnRefresh.Size = New System.Drawing.Size(110, 34)
        Me.BtnRefresh.TabIndex = 6
        Me.BtnRefresh.Tag = "6"
        Me.BtnRefresh.Text = "Refresh"
        '
        'ButtonPresident
        '
        Me.ButtonPresident.Animated = True
        Me.ButtonPresident.BorderRadius = 10
        Me.ButtonPresident.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonPresident.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonPresident.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonPresident.CheckedState.Parent = Me.ButtonPresident
        Me.ButtonPresident.CustomImages.Parent = Me.ButtonPresident
        Me.ButtonPresident.FillColor = System.Drawing.Color.Empty
        Me.ButtonPresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonPresident.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonPresident.HoverState.Parent = Me.ButtonPresident
        Me.ButtonPresident.Location = New System.Drawing.Point(119, 3)
        Me.ButtonPresident.Name = "ButtonPresident"
        Me.ButtonPresident.ShadowDecoration.Parent = Me.ButtonPresident
        Me.ButtonPresident.Size = New System.Drawing.Size(110, 34)
        Me.ButtonPresident.TabIndex = 0
        Me.ButtonPresident.Tag = "1"
        Me.ButtonPresident.Text = "President"
        '
        'ButtonVicePresident
        '
        Me.ButtonVicePresident.Animated = True
        Me.ButtonVicePresident.BorderRadius = 10
        Me.ButtonVicePresident.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonVicePresident.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonVicePresident.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonVicePresident.CheckedState.Parent = Me.ButtonVicePresident
        Me.ButtonVicePresident.CustomImages.Parent = Me.ButtonVicePresident
        Me.ButtonVicePresident.FillColor = System.Drawing.Color.Empty
        Me.ButtonVicePresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVicePresident.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonVicePresident.HoverState.Parent = Me.ButtonVicePresident
        Me.ButtonVicePresident.Location = New System.Drawing.Point(235, 3)
        Me.ButtonVicePresident.Name = "ButtonVicePresident"
        Me.ButtonVicePresident.ShadowDecoration.Parent = Me.ButtonVicePresident
        Me.ButtonVicePresident.Size = New System.Drawing.Size(110, 34)
        Me.ButtonVicePresident.TabIndex = 1
        Me.ButtonVicePresident.Tag = "2"
        Me.ButtonVicePresident.Text = "Vice President"
        '
        'ButtonSecretary
        '
        Me.ButtonSecretary.Animated = True
        Me.ButtonSecretary.BorderRadius = 10
        Me.ButtonSecretary.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonSecretary.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonSecretary.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonSecretary.CheckedState.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.CustomImages.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.FillColor = System.Drawing.Color.Empty
        Me.ButtonSecretary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSecretary.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonSecretary.HoverState.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.Location = New System.Drawing.Point(351, 3)
        Me.ButtonSecretary.Name = "ButtonSecretary"
        Me.ButtonSecretary.ShadowDecoration.Parent = Me.ButtonSecretary
        Me.ButtonSecretary.Size = New System.Drawing.Size(110, 34)
        Me.ButtonSecretary.TabIndex = 2
        Me.ButtonSecretary.Tag = "3"
        Me.ButtonSecretary.Text = "Secretary"
        '
        'ButtonTreasurer
        '
        Me.ButtonTreasurer.Animated = True
        Me.ButtonTreasurer.BorderRadius = 10
        Me.ButtonTreasurer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonTreasurer.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonTreasurer.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonTreasurer.CheckedState.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.CustomImages.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.FillColor = System.Drawing.Color.Empty
        Me.ButtonTreasurer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonTreasurer.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonTreasurer.HoverState.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.Location = New System.Drawing.Point(467, 3)
        Me.ButtonTreasurer.Name = "ButtonTreasurer"
        Me.ButtonTreasurer.ShadowDecoration.Parent = Me.ButtonTreasurer
        Me.ButtonTreasurer.Size = New System.Drawing.Size(110, 34)
        Me.ButtonTreasurer.TabIndex = 3
        Me.ButtonTreasurer.Tag = "4"
        Me.ButtonTreasurer.Text = "Treasurer"
        '
        'ButtonAuditor
        '
        Me.ButtonAuditor.Animated = True
        Me.ButtonAuditor.BorderRadius = 10
        Me.ButtonAuditor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonAuditor.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonAuditor.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonAuditor.CheckedState.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.CustomImages.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.FillColor = System.Drawing.Color.Empty
        Me.ButtonAuditor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonAuditor.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonAuditor.HoverState.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.Location = New System.Drawing.Point(583, 3)
        Me.ButtonAuditor.Name = "ButtonAuditor"
        Me.ButtonAuditor.ShadowDecoration.Parent = Me.ButtonAuditor
        Me.ButtonAuditor.Size = New System.Drawing.Size(110, 34)
        Me.ButtonAuditor.TabIndex = 4
        Me.ButtonAuditor.Tag = "5"
        Me.ButtonAuditor.Text = "Auditor"
        '
        'ButtonPRO
        '
        Me.ButtonPRO.Animated = True
        Me.ButtonPRO.BorderRadius = 10
        Me.ButtonPRO.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonPRO.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonPRO.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonPRO.CheckedState.Parent = Me.ButtonPRO
        Me.ButtonPRO.CustomImages.Parent = Me.ButtonPRO
        Me.ButtonPRO.FillColor = System.Drawing.Color.Empty
        Me.ButtonPRO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonPRO.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonPRO.HoverState.Parent = Me.ButtonPRO
        Me.ButtonPRO.Location = New System.Drawing.Point(699, 3)
        Me.ButtonPRO.Name = "ButtonPRO"
        Me.ButtonPRO.ShadowDecoration.Parent = Me.ButtonPRO
        Me.ButtonPRO.Size = New System.Drawing.Size(110, 34)
        Me.ButtonPRO.TabIndex = 5
        Me.ButtonPRO.Tag = "6"
        Me.ButtonPRO.Text = "P.R.O"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.AutoScroll = True
        Me.Guna2Panel1.Controls.Add(Me.Chart1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(40, 161)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(889, 358)
        Me.Guna2Panel1.TabIndex = 4
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.White
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.White
        ChartArea2.Area3DStyle.Inclination = 10
        ChartArea2.Area3DStyle.IsRightAngleAxes = False
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisX.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.InterlacedColor = System.Drawing.Color.White
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisY.LineColor = System.Drawing.Color.White
        StripLine2.BackColor = System.Drawing.Color.White
        StripLine2.BorderColor = System.Drawing.Color.White
        ChartArea2.AxisY.StripLines.Add(StripLine2)
        ChartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BorderColor = System.Drawing.Color.White
        ChartArea2.Name = "ChartAreaBar"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.Transparent
        Legend2.ForeColor = System.Drawing.Color.White
        Legend2.Name = "Legend2"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(22, 25)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartAreaBar"
        Series2.Legend = "Legend2"
        Series2.Name = "Series2"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(851, 311)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'VoteCount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PositionGroup)
        Me.Controls.Add(Me.LabelDesc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VoteCount"
        Me.Size = New System.Drawing.Size(974, 557)
        Me.PositionGroup.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelDesc As System.Windows.Forms.Label
    Friend WithEvents PositionGroup As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVicePresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSecretary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonTreasurer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonAuditor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonPRO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents BtnRefresh As Guna.UI2.WinForms.Guna2Button

End Class
