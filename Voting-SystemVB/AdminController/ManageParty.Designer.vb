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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.BackgroundWorkerRefresh = New System.ComponentModel.BackgroundWorker()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelParty = New System.Windows.Forms.Label()
        Me.ButtonRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelSub = New System.Windows.Forms.Panel()
        Me.PanelNoParty = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorkerFetchMember = New System.ComponentModel.BackgroundWorker()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.PanelSub.SuspendLayout()
        Me.PanelNoParty.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(34, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Manage Party"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd.Animated = True
        Me.ButtonAdd.CheckedState.Parent = Me.ButtonAdd
        Me.ButtonAdd.CustomImages.Parent = Me.ButtonAdd
        Me.ButtonAdd.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonAdd.HoverState.Parent = Me.ButtonAdd
        Me.ButtonAdd.Location = New System.Drawing.Point(0, 103)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.ShadowDecoration.Parent = Me.ButtonAdd
        Me.ButtonAdd.Size = New System.Drawing.Size(220, 45)
        Me.ButtonAdd.TabIndex = 8
        Me.ButtonAdd.Text = "Add Party"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRefresh.Animated = True
        Me.ButtonRefresh.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRefresh.BorderColor = System.Drawing.Color.LightGray
        Me.ButtonRefresh.BorderThickness = 1
        Me.ButtonRefresh.CheckedState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.CustomImages.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.FillColor = System.Drawing.Color.White
        Me.ButtonRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.Gray
        Me.ButtonRefresh.HoverState.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Location = New System.Drawing.Point(455, 19)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.ShadowDecoration.Parent = Me.ButtonRefresh
        Me.ButtonRefresh.Size = New System.Drawing.Size(110, 36)
        Me.ButtonRefresh.TabIndex = 8
        Me.ButtonRefresh.Text = "Refresh"
        '
        'BackgroundWorkerRefresh
        '
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonAdd)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(230, 380)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2Separator2)
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
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LabelParty)
        Me.Panel1.Controls.Add(Me.ButtonRemove)
        Me.Panel1.Controls.Add(Me.ButtonUpdate)
        Me.Panel1.Controls.Add(Me.ButtonRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 380)
        Me.Panel1.TabIndex = 10
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Separator2.Location = New System.Drawing.Point(365, 85)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(200, 10)
        Me.Guna2Separator2.TabIndex = 2
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Separator1.Location = New System.Drawing.Point(27, 85)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(200, 10)
        Me.Guna2Separator1.TabIndex = 1
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelDesc.ForeColor = System.Drawing.Color.Gray
        Me.LabelDesc.Location = New System.Drawing.Point(27, 44)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(126, 19)
        Me.LabelDesc.TabIndex = 0
        Me.LabelDesc.Text = "Sample Description"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(28, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "P.R.O."
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(28, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Auditor:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(28, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Treasurer:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(28, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Secretary:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(28, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Vice President:"
        '
        'LabelPRO
        '
        Me.LabelPRO.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelPRO.AutoSize = True
        Me.LabelPRO.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelPRO.ForeColor = System.Drawing.Color.Black
        Me.LabelPRO.Location = New System.Drawing.Point(145, 287)
        Me.LabelPRO.Name = "LabelPRO"
        Me.LabelPRO.Size = New System.Drawing.Size(162, 21)
        Me.LabelPRO.TabIndex = 0
        Me.LabelPRO.Text = "Lenard Mangay-ayam"
        '
        'LabelAuditor
        '
        Me.LabelAuditor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelAuditor.AutoSize = True
        Me.LabelAuditor.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelAuditor.ForeColor = System.Drawing.Color.Black
        Me.LabelAuditor.Location = New System.Drawing.Point(145, 256)
        Me.LabelAuditor.Name = "LabelAuditor"
        Me.LabelAuditor.Size = New System.Drawing.Size(162, 21)
        Me.LabelAuditor.TabIndex = 0
        Me.LabelAuditor.Text = "Lenard Mangay-ayam"
        '
        'LabelTreasurer
        '
        Me.LabelTreasurer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTreasurer.AutoSize = True
        Me.LabelTreasurer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelTreasurer.ForeColor = System.Drawing.Color.Black
        Me.LabelTreasurer.Location = New System.Drawing.Point(145, 225)
        Me.LabelTreasurer.Name = "LabelTreasurer"
        Me.LabelTreasurer.Size = New System.Drawing.Size(162, 21)
        Me.LabelTreasurer.TabIndex = 0
        Me.LabelTreasurer.Text = "Lenard Mangay-ayam"
        '
        'LabelSecretary
        '
        Me.LabelSecretary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelSecretary.AutoSize = True
        Me.LabelSecretary.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelSecretary.ForeColor = System.Drawing.Color.Black
        Me.LabelSecretary.Location = New System.Drawing.Point(145, 194)
        Me.LabelSecretary.Name = "LabelSecretary"
        Me.LabelSecretary.Size = New System.Drawing.Size(162, 21)
        Me.LabelSecretary.TabIndex = 0
        Me.LabelSecretary.Text = "Lenard Mangay-ayam"
        '
        'LabelVicePresident
        '
        Me.LabelVicePresident.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelVicePresident.AutoSize = True
        Me.LabelVicePresident.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelVicePresident.ForeColor = System.Drawing.Color.Black
        Me.LabelVicePresident.Location = New System.Drawing.Point(145, 163)
        Me.LabelVicePresident.Name = "LabelVicePresident"
        Me.LabelVicePresident.Size = New System.Drawing.Size(162, 21)
        Me.LabelVicePresident.TabIndex = 0
        Me.LabelVicePresident.Text = "Lenard Mangay-ayam"
        '
        'Label1President
        '
        Me.Label1President.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1President.AutoSize = True
        Me.Label1President.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1President.ForeColor = System.Drawing.Color.Black
        Me.Label1President.Location = New System.Drawing.Point(145, 132)
        Me.Label1President.Name = "Label1President"
        Me.Label1President.Size = New System.Drawing.Size(162, 21)
        Me.Label1President.TabIndex = 0
        Me.Label1President.Text = "Lenard Mangay-ayam"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(28, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "President:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(239, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Representatives"
        '
        'LabelParty
        '
        Me.LabelParty.AutoSize = True
        Me.LabelParty.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.LabelParty.Location = New System.Drawing.Point(27, 19)
        Me.LabelParty.Name = "LabelParty"
        Me.LabelParty.Size = New System.Drawing.Size(115, 25)
        Me.LabelParty.TabIndex = 0
        Me.LabelParty.Text = "Sample Title"
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRemove.Animated = True
        Me.ButtonRemove.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRemove.BorderColor = System.Drawing.Color.LightGray
        Me.ButtonRemove.CheckedState.Parent = Me.ButtonRemove
        Me.ButtonRemove.CustomImages.Parent = Me.ButtonRemove
        Me.ButtonRemove.FillColor = System.Drawing.Color.White
        Me.ButtonRemove.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ButtonRemove.HoverState.Parent = Me.ButtonRemove
        Me.ButtonRemove.Location = New System.Drawing.Point(339, 335)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.ShadowDecoration.Parent = Me.ButtonRemove
        Me.ButtonRemove.Size = New System.Drawing.Size(110, 36)
        Me.ButtonRemove.TabIndex = 8
        Me.ButtonRemove.Text = "Remove Party"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonUpdate.Animated = True
        Me.ButtonUpdate.BackColor = System.Drawing.Color.Transparent
        Me.ButtonUpdate.BorderColor = System.Drawing.Color.LightGray
        Me.ButtonUpdate.CheckedState.Parent = Me.ButtonUpdate
        Me.ButtonUpdate.CustomImages.Parent = Me.ButtonUpdate
        Me.ButtonUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.HoverState.Parent = Me.ButtonUpdate
        Me.ButtonUpdate.Location = New System.Drawing.Point(455, 335)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.ShadowDecoration.Parent = Me.ButtonUpdate
        Me.ButtonUpdate.Size = New System.Drawing.Size(110, 36)
        Me.ButtonUpdate.TabIndex = 8
        Me.ButtonUpdate.Text = "Update"
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.Controls.Add(Me.PanelSub)
        Me.PanelMain.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelMain.Location = New System.Drawing.Point(38, 76)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(837, 380)
        Me.PanelMain.TabIndex = 11
        '
        'PanelSub
        '
        Me.PanelSub.Controls.Add(Me.Panel1)
        Me.PanelSub.Controls.Add(Me.PanelNoParty)
        Me.PanelSub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSub.Location = New System.Drawing.Point(230, 0)
        Me.PanelSub.Name = "PanelSub"
        Me.PanelSub.Size = New System.Drawing.Size(607, 380)
        Me.PanelSub.TabIndex = 9
        '
        'PanelNoParty
        '
        Me.PanelNoParty.BackColor = System.Drawing.Color.White
        Me.PanelNoParty.Controls.Add(Me.Guna2Button1)
        Me.PanelNoParty.Controls.Add(Me.Guna2Button2)
        Me.PanelNoParty.Controls.Add(Me.Label2)
        Me.PanelNoParty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNoParty.Location = New System.Drawing.Point(0, 0)
        Me.PanelNoParty.Name = "PanelNoParty"
        Me.PanelNoParty.Size = New System.Drawing.Size(607, 380)
        Me.PanelNoParty.TabIndex = 12
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(187, 179)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(110, 36)
        Me.Guna2Button1.TabIndex = 9
        Me.Guna2Button1.Text = "Add"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2Button2.BorderThickness = 1
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Gray
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(303, 179)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(110, 36)
        Me.Guna2Button2.TabIndex = 10
        Me.Guna2Button2.Text = "Refresh"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(130, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(361, 45)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "There is no Party Added"
        '
        'BackgroundWorkerFetchMember
        '
        '
        'ManageParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManageParty"
        Me.Size = New System.Drawing.Size(913, 481)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelSub.ResumeLayout(False)
        Me.PanelNoParty.ResumeLayout(False)
        Me.PanelNoParty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BackgroundWorkerRefresh As System.ComponentModel.BackgroundWorker
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents LabelDesc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelParty As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelSecretary As System.Windows.Forms.Label
    Friend WithEvents LabelVicePresident As System.Windows.Forms.Label
    Friend WithEvents Label1President As System.Windows.Forms.Label
    Friend WithEvents LabelPRO As System.Windows.Forms.Label
    Friend WithEvents LabelAuditor As System.Windows.Forms.Label
    Friend WithEvents LabelTreasurer As System.Windows.Forms.Label
    Friend WithEvents PanelSub As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorkerFetchMember As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelNoParty As System.Windows.Forms.Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
