<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingControl
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
        Me.Guna2WinProgressIndicator1 = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guna2WinProgressIndicator1
        '
        Me.Guna2WinProgressIndicator1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2WinProgressIndicator1.AutoStart = True
        Me.Guna2WinProgressIndicator1.CircleSize = 1.0!
        Me.Guna2WinProgressIndicator1.Location = New System.Drawing.Point(436, 165)
        Me.Guna2WinProgressIndicator1.Name = "Guna2WinProgressIndicator1"
        Me.Guna2WinProgressIndicator1.Size = New System.Drawing.Size(141, 141)
        Me.Guna2WinProgressIndicator1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(407, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loading, Please wait...."
        '
        'LoadingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2WinProgressIndicator1)
        Me.Name = "LoadingControl"
        Me.Size = New System.Drawing.Size(974, 557)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2WinProgressIndicator1 As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
