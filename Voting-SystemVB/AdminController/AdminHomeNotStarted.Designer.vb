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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHomeNotStarted))
        Me.ElectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonStartElection = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.ElectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElectionBindingSource
        '
        Me.ElectionBindingSource.DataSource = GetType(Voting_SystemVB.Election)
        '
        'ButtonStartElection
        '
        Me.ButtonStartElection.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonStartElection.BorderRadius = 20
        Me.ButtonStartElection.BorderThickness = 1
        Me.ButtonStartElection.CheckedState.Parent = Me.ButtonStartElection
        Me.ButtonStartElection.CustomImages.Parent = Me.ButtonStartElection
        Me.ButtonStartElection.FillColor = System.Drawing.Color.White
        Me.ButtonStartElection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonStartElection.ForeColor = System.Drawing.Color.Black
        Me.ButtonStartElection.HoverState.Parent = Me.ButtonStartElection
        Me.ButtonStartElection.Image = CType(resources.GetObject("ButtonStartElection.Image"), System.Drawing.Image)
        Me.ButtonStartElection.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ButtonStartElection.ImageOffset = New System.Drawing.Point(10, 0)
        Me.ButtonStartElection.Location = New System.Drawing.Point(31, 324)
        Me.ButtonStartElection.Name = "ButtonStartElection"
        Me.ButtonStartElection.ShadowDecoration.Parent = Me.ButtonStartElection
        Me.ButtonStartElection.Size = New System.Drawing.Size(155, 45)
        Me.ButtonStartElection.TabIndex = 2
        Me.ButtonStartElection.Text = "Start Election"
        Me.ButtonStartElection.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonStartElection.TextOffset = New System.Drawing.Point(10, 0)
        '
        'AdminHomeNotStarted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonStartElection)
        Me.Name = "AdminHomeNotStarted"
        Me.Size = New System.Drawing.Size(878, 402)
        CType(Me.ElectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ElectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonStartElection As Guna.UI2.WinForms.Guna2Button

End Class
