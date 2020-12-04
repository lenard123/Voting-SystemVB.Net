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
        Me.SampleDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.StartElection = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TotalVoters = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.RemainingVotes = New Guna.UI2.WinForms.Guna2Button()
        Me.ShowCandidates.SuspendLayout()
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
        Me.President.Location = New System.Drawing.Point(45, 156)
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
        Me.VPresident.Location = New System.Drawing.Point(45, 196)
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
        Me.Secretary.Location = New System.Drawing.Point(45, 343)
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
        Me.Treasurer.Location = New System.Drawing.Point(45, 306)
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
        Me.Auditor.Location = New System.Drawing.Point(45, 233)
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
        Me.PRO.Location = New System.Drawing.Point(45, 269)
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
        Me.DisplayPieChart.Checked = True
        Me.DisplayPieChart.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayPieChart.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayPieChart.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.DisplayPieChart.CheckedState.InnerColor = System.Drawing.Color.White
        Me.DisplayPieChart.CheckedState.Parent = Me.DisplayPieChart
        Me.DisplayPieChart.Location = New System.Drawing.Point(560, 51)
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
        Me.ViewChart.AutoSize = True
        Me.ViewChart.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewChart.Location = New System.Drawing.Point(471, 54)
        Me.ViewChart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ViewChart.Name = "ViewChart"
        Me.ViewChart.Size = New System.Drawing.Size(81, 17)
        Me.ViewChart.TabIndex = 21
        Me.ViewChart.Text = "View Chart"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BorderRadius = 10
        Me.ButtonRefresh.CheckedState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.CustomImages.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.White
        Me.ButtonRefresh.HoverState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Location = New System.Drawing.Point(502, 251)
        Me.ButtonRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.ShadowDecoration.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Size = New System.Drawing.Size(103, 26)
        Me.ButtonRefresh.TabIndex = 20
        Me.ButtonRefresh.Text = "Refresh"
        '
        'ShowCandidates
        '
        Me.ShowCandidates.Controls.Add(Me.SampleDate)
        Me.ShowCandidates.Controls.Add(Me.ButtonRefresh)
        Me.ShowCandidates.Controls.Add(Me.ViewChart)
        Me.ShowCandidates.Controls.Add(Me.DisplayPieChart)
        Me.ShowCandidates.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowCandidates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowCandidates.Location = New System.Drawing.Point(193, 156)
        Me.ShowCandidates.Margin = New System.Windows.Forms.Padding(4)
        Me.ShowCandidates.Name = "ShowCandidates"
        Me.ShowCandidates.ShadowDecoration.Parent = Me.ShowCandidates
        Me.ShowCandidates.Size = New System.Drawing.Size(623, 291)
        Me.ShowCandidates.TabIndex = 22
        Me.ShowCandidates.Text = "Show Candidates"
        Me.ShowCandidates.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'SampleDate
        '
        Me.SampleDate.CheckedState.Parent = Me.SampleDate
        Me.SampleDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.SampleDate.HoverState.Parent = Me.SampleDate
        Me.SampleDate.Location = New System.Drawing.Point(407, 0)
        Me.SampleDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.SampleDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.SampleDate.Name = "SampleDate"
        Me.SampleDate.ShadowDecoration.Parent = Me.SampleDate
        Me.SampleDate.Size = New System.Drawing.Size(216, 39)
        Me.SampleDate.TabIndex = 23
        Me.SampleDate.Value = New Date(2020, 12, 3, 18, 11, 41, 741)
        '
        'StartElection
        '
        Me.StartElection.CheckedState.Parent = Me.StartElection
        Me.StartElection.CustomImages.Parent = Me.StartElection
        Me.StartElection.FillColor = System.Drawing.Color.LightGreen
        Me.StartElection.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartElection.ForeColor = System.Drawing.Color.Black
        Me.StartElection.HoverState.Parent = Me.StartElection
        Me.StartElection.Location = New System.Drawing.Point(684, 37)
        Me.StartElection.Name = "StartElection"
        Me.StartElection.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.StartElection.ShadowDecoration.Parent = Me.StartElection
        Me.StartElection.Size = New System.Drawing.Size(94, 96)
        Me.StartElection.TabIndex = 24
        Me.StartElection.Text = "Start Election"
        '
        'TotalVoters
        '
        Me.TotalVoters.BorderRadius = 10
        Me.TotalVoters.CheckedState.Parent = Me.TotalVoters
        Me.TotalVoters.CustomImages.Parent = Me.TotalVoters
        Me.TotalVoters.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.TotalVoters.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalVoters.ForeColor = System.Drawing.Color.White
        Me.TotalVoters.HoverState.Parent = Me.TotalVoters
        Me.TotalVoters.Location = New System.Drawing.Point(45, 63)
        Me.TotalVoters.Name = "TotalVoters"
        Me.TotalVoters.ShadowDecoration.Parent = Me.TotalVoters
        Me.TotalVoters.Size = New System.Drawing.Size(180, 70)
        Me.TotalVoters.TabIndex = 25
        Me.TotalVoters.Text = "Total Voters"
        Me.TotalVoters.TextOffset = New System.Drawing.Point(0, 20)
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(442, 63)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 70)
        Me.Guna2Button1.TabIndex = 26
        Me.Guna2Button1.Text = "Already Voted"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, 20)
        '
        'RemainingVotes
        '
        Me.RemainingVotes.BorderRadius = 10
        Me.RemainingVotes.CheckedState.Parent = Me.RemainingVotes
        Me.RemainingVotes.CustomImages.Parent = Me.RemainingVotes
        Me.RemainingVotes.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.RemainingVotes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemainingVotes.ForeColor = System.Drawing.Color.White
        Me.RemainingVotes.HoverState.Parent = Me.RemainingVotes
        Me.RemainingVotes.Location = New System.Drawing.Point(245, 63)
        Me.RemainingVotes.Name = "RemainingVotes"
        Me.RemainingVotes.ShadowDecoration.Parent = Me.RemainingVotes
        Me.RemainingVotes.Size = New System.Drawing.Size(180, 70)
        Me.RemainingVotes.TabIndex = 27
        Me.RemainingVotes.Text = "Remaining Votes"
        Me.RemainingVotes.TextOffset = New System.Drawing.Point(0, 20)
        '
        'AdminHomeNotStarted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RemainingVotes)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.TotalVoters)
        Me.Controls.Add(Me.StartElection)
        Me.Controls.Add(Me.ShowCandidates)
        Me.Controls.Add(Me.PRO)
        Me.Controls.Add(Me.Auditor)
        Me.Controls.Add(Me.Treasurer)
        Me.Controls.Add(Me.Secretary)
        Me.Controls.Add(Me.VPresident)
        Me.Controls.Add(Me.President)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminHomeNotStarted"
        Me.Size = New System.Drawing.Size(1421, 786)
        Me.ShowCandidates.ResumeLayout(False)
        Me.ShowCandidates.PerformLayout()
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
    Friend WithEvents SampleDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents StartElection As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TotalVoters As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RemainingVotes As Guna.UI2.WinForms.Guna2Button
End Class
