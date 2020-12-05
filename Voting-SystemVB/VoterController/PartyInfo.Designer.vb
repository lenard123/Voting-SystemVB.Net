<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartyInfo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelSub = New System.Windows.Forms.Panel()
        Me.PanelNoParty = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.LabelDesc = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelPRO = New System.Windows.Forms.Label()
        Me.LabelAuditor = New System.Windows.Forms.Label()
        Me.LabelTreasurer = New System.Windows.Forms.Label()
        Me.LabelSecretary = New System.Windows.Forms.Label()
        Me.LabelVicePresident = New System.Windows.Forms.Label()
        Me.Label1President = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelParty = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelLoading = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2WinProgressIndicator1 = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.BackgroundWorkerFetch = New System.ComponentModel.BackgroundWorker()
        Me.PanelMain.SuspendLayout()
        Me.PanelSub.SuspendLayout()
        Me.PanelNoParty.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLoading.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(36, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(437, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Display informations about the Parties and display its members"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Party Informations"
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.Controls.Add(Me.PanelSub)
        Me.PanelMain.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelMain.Location = New System.Drawing.Point(40, 101)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(830, 364)
        Me.PanelMain.TabIndex = 12
        '
        'PanelSub
        '
        Me.PanelSub.Controls.Add(Me.Panel1)
        Me.PanelSub.Controls.Add(Me.PanelLoading)
        Me.PanelSub.Controls.Add(Me.PanelNoParty)
        Me.PanelSub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSub.Location = New System.Drawing.Point(230, 0)
        Me.PanelSub.Name = "PanelSub"
        Me.PanelSub.Size = New System.Drawing.Size(600, 364)
        Me.PanelSub.TabIndex = 9
        '
        'PanelNoParty
        '
        Me.PanelNoParty.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelNoParty.Controls.Add(Me.Label3)
        Me.PanelNoParty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNoParty.Location = New System.Drawing.Point(0, 0)
        Me.PanelNoParty.Name = "PanelNoParty"
        Me.PanelNoParty.Size = New System.Drawing.Size(600, 364)
        Me.PanelNoParty.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(129, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 45)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "There is no Party Added"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Panel1.Controls.Add(Me.LabelDesc)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.LabelPRO)
        Me.Panel1.Controls.Add(Me.LabelAuditor)
        Me.Panel1.Controls.Add(Me.LabelTreasurer)
        Me.Panel1.Controls.Add(Me.LabelSecretary)
        Me.Panel1.Controls.Add(Me.LabelVicePresident)
        Me.Panel1.Controls.Add(Me.Label1President)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LabelParty)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 364)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.ImageLocation = "images\default\error.jpg"
        Me.PictureBox1.Location = New System.Drawing.Point(24, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Separator1.Location = New System.Drawing.Point(24, 155)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(542, 10)
        Me.Guna2Separator1.TabIndex = 1
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelDesc.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LabelDesc.Location = New System.Drawing.Point(265, 52)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(145, 21)
        Me.LabelDesc.TabIndex = 0
        Me.LabelDesc.Text = "Sample Description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Location = New System.Drawing.Point(25, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "P.R.O."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label9.Location = New System.Drawing.Point(25, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Auditor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Location = New System.Drawing.Point(25, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Treasurer:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(25, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Secretary:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(25, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Vice President:"
        '
        'LabelPRO
        '
        Me.LabelPRO.AutoSize = True
        Me.LabelPRO.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelPRO.ForeColor = System.Drawing.Color.White
        Me.LabelPRO.Location = New System.Drawing.Point(142, 329)
        Me.LabelPRO.Name = "LabelPRO"
        Me.LabelPRO.Size = New System.Drawing.Size(162, 21)
        Me.LabelPRO.TabIndex = 0
        Me.LabelPRO.Text = "Lenard Mangay-ayam"
        '
        'LabelAuditor
        '
        Me.LabelAuditor.AutoSize = True
        Me.LabelAuditor.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelAuditor.ForeColor = System.Drawing.Color.White
        Me.LabelAuditor.Location = New System.Drawing.Point(142, 298)
        Me.LabelAuditor.Name = "LabelAuditor"
        Me.LabelAuditor.Size = New System.Drawing.Size(162, 21)
        Me.LabelAuditor.TabIndex = 0
        Me.LabelAuditor.Text = "Lenard Mangay-ayam"
        '
        'LabelTreasurer
        '
        Me.LabelTreasurer.AutoSize = True
        Me.LabelTreasurer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelTreasurer.ForeColor = System.Drawing.Color.White
        Me.LabelTreasurer.Location = New System.Drawing.Point(142, 267)
        Me.LabelTreasurer.Name = "LabelTreasurer"
        Me.LabelTreasurer.Size = New System.Drawing.Size(162, 21)
        Me.LabelTreasurer.TabIndex = 0
        Me.LabelTreasurer.Text = "Lenard Mangay-ayam"
        '
        'LabelSecretary
        '
        Me.LabelSecretary.AutoSize = True
        Me.LabelSecretary.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelSecretary.ForeColor = System.Drawing.Color.White
        Me.LabelSecretary.Location = New System.Drawing.Point(142, 236)
        Me.LabelSecretary.Name = "LabelSecretary"
        Me.LabelSecretary.Size = New System.Drawing.Size(162, 21)
        Me.LabelSecretary.TabIndex = 0
        Me.LabelSecretary.Text = "Lenard Mangay-ayam"
        '
        'LabelVicePresident
        '
        Me.LabelVicePresident.AutoSize = True
        Me.LabelVicePresident.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelVicePresident.ForeColor = System.Drawing.Color.White
        Me.LabelVicePresident.Location = New System.Drawing.Point(142, 205)
        Me.LabelVicePresident.Name = "LabelVicePresident"
        Me.LabelVicePresident.Size = New System.Drawing.Size(162, 21)
        Me.LabelVicePresident.TabIndex = 0
        Me.LabelVicePresident.Text = "Lenard Mangay-ayam"
        '
        'Label1President
        '
        Me.Label1President.AutoSize = True
        Me.Label1President.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1President.ForeColor = System.Drawing.Color.White
        Me.Label1President.Location = New System.Drawing.Point(142, 174)
        Me.Label1President.Name = "Label1President"
        Me.Label1President.Size = New System.Drawing.Size(162, 21)
        Me.Label1President.TabIndex = 0
        Me.Label1President.Text = "Lenard Mangay-ayam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(25, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "President:"
        '
        'LabelParty
        '
        Me.LabelParty.AutoSize = True
        Me.LabelParty.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.LabelParty.ForeColor = System.Drawing.Color.White
        Me.LabelParty.Location = New System.Drawing.Point(263, 20)
        Me.LabelParty.Name = "LabelParty"
        Me.LabelParty.Size = New System.Drawing.Size(163, 32)
        Me.LabelParty.TabIndex = 0
        Me.LabelParty.Text = "SAMPLE TITLE"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(230, 364)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'PanelLoading
        '
        Me.PanelLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelLoading.Controls.Add(Me.Guna2WinProgressIndicator1)
        Me.PanelLoading.Controls.Add(Me.Label4)
        Me.PanelLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLoading.Location = New System.Drawing.Point(0, 0)
        Me.PanelLoading.Name = "PanelLoading"
        Me.PanelLoading.Size = New System.Drawing.Size(600, 364)
        Me.PanelLoading.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(271, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 45)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Loading..."
        '
        'Guna2WinProgressIndicator1
        '
        Me.Guna2WinProgressIndicator1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2WinProgressIndicator1.CircleSize = 1.0!
        Me.Guna2WinProgressIndicator1.Location = New System.Drawing.Point(165, 126)
        Me.Guna2WinProgressIndicator1.Name = "Guna2WinProgressIndicator1"
        Me.Guna2WinProgressIndicator1.Size = New System.Drawing.Size(90, 90)
        Me.Guna2WinProgressIndicator1.TabIndex = 8
        '
        'BackgroundWorkerFetch
        '
        '
        'PartyInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PartyInfo"
        Me.Size = New System.Drawing.Size(938, 489)
        Me.PanelMain.ResumeLayout(False)
        Me.PanelSub.ResumeLayout(False)
        Me.PanelNoParty.ResumeLayout(False)
        Me.PanelNoParty.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLoading.ResumeLayout(False)
        Me.PanelLoading.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents PanelSub As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents LabelDesc As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelPRO As System.Windows.Forms.Label
    Friend WithEvents LabelAuditor As System.Windows.Forms.Label
    Friend WithEvents LabelTreasurer As System.Windows.Forms.Label
    Friend WithEvents LabelSecretary As System.Windows.Forms.Label
    Friend WithEvents LabelVicePresident As System.Windows.Forms.Label
    Friend WithEvents Label1President As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelParty As System.Windows.Forms.Label
    Friend WithEvents PanelNoParty As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelLoading As System.Windows.Forms.Panel
    Friend WithEvents Guna2WinProgressIndicator1 As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorkerFetch As System.ComponentModel.BackgroundWorker

End Class
