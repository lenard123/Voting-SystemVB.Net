<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CandidateCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CandidateCard))
        Me.LabelFullname = New System.Windows.Forms.Label()
        Me.LabelTagline = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelParty = New System.Windows.Forms.Label()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.LabelYear = New System.Windows.Forms.Label()
        Me.LabelPosition = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ButtonEdit = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LabelStudentID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelFullname
        '
        Me.LabelFullname.AutoSize = True
        Me.LabelFullname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelFullname.Location = New System.Drawing.Point(16, 201)
        Me.LabelFullname.Name = "LabelFullname"
        Me.LabelFullname.Size = New System.Drawing.Size(187, 19)
        Me.LabelFullname.TabIndex = 1
        Me.LabelFullname.Text = "Lenard Mangay-ayam"
        '
        'LabelTagline
        '
        Me.LabelTagline.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTagline.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LabelTagline.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTagline.Location = New System.Drawing.Point(17, 337)
        Me.LabelTagline.Name = "LabelTagline"
        Me.LabelTagline.Size = New System.Drawing.Size(254, 33)
        Me.LabelTagline.TabIndex = 1
        Me.LabelTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(16, 242)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(255, 10)
        Me.Guna2Separator1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Course:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Year:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Party:"
        '
        'LabelParty
        '
        Me.LabelParty.AutoSize = True
        Me.LabelParty.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelParty.ForeColor = System.Drawing.Color.Black
        Me.LabelParty.Location = New System.Drawing.Point(65, 255)
        Me.LabelParty.Name = "LabelParty"
        Me.LabelParty.Size = New System.Drawing.Size(101, 19)
        Me.LabelParty.TabIndex = 1
        Me.LabelParty.Text = "Independent"
        '
        'LabelCourse
        '
        Me.LabelCourse.AutoSize = True
        Me.LabelCourse.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelCourse.ForeColor = System.Drawing.Color.Black
        Me.LabelCourse.Location = New System.Drawing.Point(82, 274)
        Me.LabelCourse.Name = "LabelCourse"
        Me.LabelCourse.Size = New System.Drawing.Size(42, 19)
        Me.LabelCourse.TabIndex = 1
        Me.LabelCourse.Text = "BSCS"
        '
        'LabelYear
        '
        Me.LabelYear.AutoSize = True
        Me.LabelYear.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelYear.ForeColor = System.Drawing.Color.Black
        Me.LabelYear.Location = New System.Drawing.Point(65, 293)
        Me.LabelYear.Name = "LabelYear"
        Me.LabelYear.Size = New System.Drawing.Size(70, 19)
        Me.LabelYear.TabIndex = 1
        Me.LabelYear.Text = "2nd Year"
        '
        'LabelPosition
        '
        Me.LabelPosition.AutoSize = True
        Me.LabelPosition.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelPosition.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelPosition.Location = New System.Drawing.Point(16, 220)
        Me.LabelPosition.Name = "LabelPosition"
        Me.LabelPosition.Size = New System.Drawing.Size(95, 19)
        Me.LabelPosition.TabIndex = 1
        Me.LabelPosition.Text = "For President"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.ButtonEdit)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LabelTagline)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LabelStudentID)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LabelYear)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LabelCourse)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LabelFullname)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LabelParty)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LabelPosition)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(286, 384)
        Me.Guna2ShadowPanel1.TabIndex = 3
        '
        'ButtonEdit
        '
        Me.ButtonEdit.CheckedState.Parent = Me.ButtonEdit
        Me.ButtonEdit.CustomImages.Parent = Me.ButtonEdit
        Me.ButtonEdit.FillColor = System.Drawing.Color.Transparent
        Me.ButtonEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.HoverState.Parent = Me.ButtonEdit
        Me.ButtonEdit.Image = CType(resources.GetObject("ButtonEdit.Image"), System.Drawing.Image)
        Me.ButtonEdit.ImageSize = New System.Drawing.Size(24, 24)
        Me.ButtonEdit.Location = New System.Drawing.Point(72, 163)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ButtonEdit.ShadowDecoration.Parent = Me.ButtonEdit
        Me.ButtonEdit.Size = New System.Drawing.Size(24, 24)
        Me.ButtonEdit.TabIndex = 5
        Me.ButtonEdit.Visible = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Gray
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(20, 125)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(77, 73)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 6
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(274, 148)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'LabelStudentID
        '
        Me.LabelStudentID.AutoSize = True
        Me.LabelStudentID.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LabelStudentID.ForeColor = System.Drawing.Color.Black
        Me.LabelStudentID.Location = New System.Drawing.Point(102, 314)
        Me.LabelStudentID.Name = "LabelStudentID"
        Me.LabelStudentID.Size = New System.Drawing.Size(89, 19)
        Me.LabelStudentID.TabIndex = 1
        Me.LabelStudentID.Text = "20191012-C"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "StudentID:"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 75
        Me.Guna2Elipse1.TargetControl = Me.Guna2PictureBox2
        '
        'CandidateCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.MaximumSize = New System.Drawing.Size(286, 384)
        Me.Name = "CandidateCard"
        Me.Size = New System.Drawing.Size(286, 384)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelFullname As System.Windows.Forms.Label
    Friend WithEvents LabelTagline As System.Windows.Forms.Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelParty As System.Windows.Forms.Label
    Friend WithEvents LabelCourse As System.Windows.Forms.Label
    Friend WithEvents LabelYear As System.Windows.Forms.Label
    Friend WithEvents LabelPosition As System.Windows.Forms.Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents LabelStudentID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonEdit As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox

End Class
