<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CandidateList1
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
        Me.BorderTop = New System.Windows.Forms.Panel()
        Me.LabelPositionName = New System.Windows.Forms.Label()
        Me.BorderLeft = New System.Windows.Forms.Panel()
        Me.BorderRight = New System.Windows.Forms.Panel()
        Me.BorderBottom = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BorderTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorderTop
        '
        Me.BorderTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BorderTop.Controls.Add(Me.LabelPositionName)
        Me.BorderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderTop.Location = New System.Drawing.Point(0, 0)
        Me.BorderTop.Name = "BorderTop"
        Me.BorderTop.Size = New System.Drawing.Size(445, 40)
        Me.BorderTop.TabIndex = 0
        '
        'LabelPositionName
        '
        Me.LabelPositionName.AutoSize = True
        Me.LabelPositionName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelPositionName.ForeColor = System.Drawing.Color.White
        Me.LabelPositionName.Location = New System.Drawing.Point(12, 11)
        Me.LabelPositionName.Name = "LabelPositionName"
        Me.LabelPositionName.Size = New System.Drawing.Size(66, 19)
        Me.LabelPositionName.TabIndex = 0
        Me.LabelPositionName.Text = "President"
        '
        'BorderLeft
        '
        Me.BorderLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.BorderLeft.Location = New System.Drawing.Point(0, 40)
        Me.BorderLeft.Name = "BorderLeft"
        Me.BorderLeft.Size = New System.Drawing.Size(1, 110)
        Me.BorderLeft.TabIndex = 1
        '
        'BorderRight
        '
        Me.BorderRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BorderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderRight.Location = New System.Drawing.Point(444, 40)
        Me.BorderRight.Name = "BorderRight"
        Me.BorderRight.Size = New System.Drawing.Size(1, 110)
        Me.BorderRight.TabIndex = 2
        '
        'BorderBottom
        '
        Me.BorderBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BorderBottom.Location = New System.Drawing.Point(1, 149)
        Me.BorderBottom.Name = "BorderBottom"
        Me.BorderBottom.Size = New System.Drawing.Size(443, 1)
        Me.BorderBottom.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 40)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(20)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(443, 109)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'CandidateList1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.BorderBottom)
        Me.Controls.Add(Me.BorderRight)
        Me.Controls.Add(Me.BorderLeft)
        Me.Controls.Add(Me.BorderTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.MinimumSize = New System.Drawing.Size(445, 0)
        Me.Name = "CandidateList1"
        Me.Size = New System.Drawing.Size(445, 150)
        Me.BorderTop.ResumeLayout(False)
        Me.BorderTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BorderTop As System.Windows.Forms.Panel
    Friend WithEvents BorderLeft As System.Windows.Forms.Panel
    Friend WithEvents BorderRight As System.Windows.Forms.Panel
    Friend WithEvents BorderBottom As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelPositionName As System.Windows.Forms.Label

End Class
