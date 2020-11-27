<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingScreen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelProgressBar = New System.Windows.Forms.Panel()
        Me.PanelProgress = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelProgressBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(190, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supreme Student Council "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(258, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Election System"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(273, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Loading, Please wait..."
        '
        'PanelProgressBar
        '
        Me.PanelProgressBar.Controls.Add(Me.PanelProgress)
        Me.PanelProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProgressBar.Location = New System.Drawing.Point(0, 214)
        Me.PanelProgressBar.Name = "PanelProgressBar"
        Me.PanelProgressBar.Size = New System.Drawing.Size(752, 3)
        Me.PanelProgressBar.TabIndex = 3
        '
        'PanelProgress
        '
        Me.PanelProgress.BackColor = System.Drawing.Color.Maroon
        Me.PanelProgress.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelProgress.Location = New System.Drawing.Point(0, 0)
        Me.PanelProgress.Name = "PanelProgress"
        Me.PanelProgress.Size = New System.Drawing.Size(10, 3)
        Me.PanelProgress.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'LoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Controls.Add(Me.PanelProgressBar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoadingScreen"
        Me.Size = New System.Drawing.Size(752, 217)
        Me.PanelProgressBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelProgressBar As System.Windows.Forms.Panel
    Friend WithEvents PanelProgress As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
