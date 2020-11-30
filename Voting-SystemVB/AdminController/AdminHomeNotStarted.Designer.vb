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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pictureparty = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Auditor = New System.Windows.Forms.Label()
        Me.Treasurer = New System.Windows.Forms.Label()
        Me.Secretary = New System.Windows.Forms.Label()
        Me.VicePresident = New System.Windows.Forms.Label()
        Me.President = New System.Windows.Forms.Label()
        Me.TotalVoters = New System.Windows.Forms.TextBox()
        Me.Remaining = New System.Windows.Forms.TextBox()
        Me.TotalCandidates = New Guna.UI2.WinForms.Guna2Button()
        Me.TotalParties = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pictureparty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pictureparty)
        Me.GroupBox1.Controls.Add(Me.Auditor)
        Me.GroupBox1.Controls.Add(Me.Treasurer)
        Me.GroupBox1.Controls.Add(Me.Secretary)
        Me.GroupBox1.Controls.Add(Me.VicePresident)
        Me.GroupBox1.Controls.Add(Me.President)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(242, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 366)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Candidates"
        '
        'pictureparty
        '
        Me.pictureparty.FillColor = System.Drawing.Color.CornflowerBlue
        Me.pictureparty.Location = New System.Drawing.Point(339, 105)
        Me.pictureparty.Name = "pictureparty"
        Me.pictureparty.ShadowDecoration.Parent = Me.pictureparty
        Me.pictureparty.Size = New System.Drawing.Size(235, 149)
        Me.pictureparty.TabIndex = 5
        Me.pictureparty.TabStop = False
        '
        'Auditor
        '
        Me.Auditor.AutoSize = True
        Me.Auditor.Location = New System.Drawing.Point(55, 290)
        Me.Auditor.Name = "Auditor"
        Me.Auditor.Size = New System.Drawing.Size(86, 21)
        Me.Auditor.TabIndex = 4
        Me.Auditor.Text = "Auditor: 7"
        '
        'Treasurer
        '
        Me.Treasurer.AutoSize = True
        Me.Treasurer.Location = New System.Drawing.Point(55, 233)
        Me.Treasurer.Name = "Treasurer"
        Me.Treasurer.Size = New System.Drawing.Size(97, 21)
        Me.Treasurer.TabIndex = 3
        Me.Treasurer.Text = "Treasurer: 9"
        '
        'Secretary
        '
        Me.Secretary.AutoSize = True
        Me.Secretary.Location = New System.Drawing.Point(55, 178)
        Me.Secretary.Name = "Secretary"
        Me.Secretary.Size = New System.Drawing.Size(101, 21)
        Me.Secretary.TabIndex = 2
        Me.Secretary.Text = "Secretary: 8"
        '
        'VicePresident
        '
        Me.VicePresident.AutoSize = True
        Me.VicePresident.Location = New System.Drawing.Point(55, 124)
        Me.VicePresident.Name = "VicePresident"
        Me.VicePresident.Size = New System.Drawing.Size(145, 21)
        Me.VicePresident.TabIndex = 1
        Me.VicePresident.Text = "Vice President: 12"
        '
        'President
        '
        Me.President.AutoSize = True
        Me.President.Location = New System.Drawing.Point(55, 73)
        Me.President.Name = "President"
        Me.President.Size = New System.Drawing.Size(107, 21)
        Me.President.TabIndex = 0
        Me.President.Text = "President: 12"
        '
        'TotalVoters
        '
        Me.TotalVoters.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalVoters.Location = New System.Drawing.Point(336, 441)
        Me.TotalVoters.Name = "TotalVoters"
        Me.TotalVoters.Size = New System.Drawing.Size(204, 23)
        Me.TotalVoters.TabIndex = 8
        Me.TotalVoters.Text = "Total Voters: 200"
        Me.TotalVoters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Remaining
        '
        Me.Remaining.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remaining.Location = New System.Drawing.Point(565, 441)
        Me.Remaining.Name = "Remaining"
        Me.Remaining.Size = New System.Drawing.Size(204, 23)
        Me.Remaining.TabIndex = 9
        Me.Remaining.Text = "Remaining Votes: 78"
        Me.Remaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalCandidates
        '
        Me.TotalCandidates.CheckedState.Parent = Me.TotalCandidates
        Me.TotalCandidates.CustomImages.Parent = Me.TotalCandidates
        Me.TotalCandidates.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TotalCandidates.ForeColor = System.Drawing.Color.White
        Me.TotalCandidates.HoverState.Parent = Me.TotalCandidates
        Me.TotalCandidates.Location = New System.Drawing.Point(32, 138)
        Me.TotalCandidates.Name = "TotalCandidates"
        Me.TotalCandidates.ShadowDecoration.Parent = Me.TotalCandidates
        Me.TotalCandidates.Size = New System.Drawing.Size(180, 45)
        Me.TotalCandidates.TabIndex = 12
        Me.TotalCandidates.Text = "View Total Candidates"
        '
        'TotalParties
        '
        Me.TotalParties.CheckedState.Parent = Me.TotalParties
        Me.TotalParties.CustomImages.Parent = Me.TotalParties
        Me.TotalParties.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TotalParties.ForeColor = System.Drawing.Color.White
        Me.TotalParties.HoverState.Parent = Me.TotalParties
        Me.TotalParties.Location = New System.Drawing.Point(32, 260)
        Me.TotalParties.Name = "TotalParties"
        Me.TotalParties.ShadowDecoration.Parent = Me.TotalParties
        Me.TotalParties.Size = New System.Drawing.Size(180, 45)
        Me.TotalParties.TabIndex = 13
        Me.TotalParties.Text = "View Total Parties"
        '
        'AdminHomeNotStarted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TotalParties)
        Me.Controls.Add(Me.TotalCandidates)
        Me.Controls.Add(Me.Remaining)
        Me.Controls.Add(Me.TotalVoters)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AdminHomeNotStarted"
        Me.Size = New System.Drawing.Size(1066, 601)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pictureparty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Auditor As System.Windows.Forms.Label
    Friend WithEvents Treasurer As System.Windows.Forms.Label
    Friend WithEvents Secretary As System.Windows.Forms.Label
    Friend WithEvents VicePresident As System.Windows.Forms.Label
    Friend WithEvents President As System.Windows.Forms.Label
    Friend WithEvents TotalVoters As System.Windows.Forms.TextBox
    Friend WithEvents Remaining As System.Windows.Forms.TextBox
    Friend WithEvents TotalCandidates As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TotalParties As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pictureparty As Guna.UI2.WinForms.Guna2PictureBox
End Class
