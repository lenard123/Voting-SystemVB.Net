
Imports System.Windows.Forms

Public Class Main
    Inherits Form

    Public Shared Instance As Main
    Private Shared ActiveChild As UserControl

    Public Sub New()

        FormBorderStyle = Windows.Forms.FormBorderStyle.None

        ' Add any initialization after the InitializeComponent() call.
        Instance = Me
        'Console.WriteLine(Date.Now().Millisecond)
        LoadControl(New LoadingScreen())
    End Sub

    Public Shared Sub RestoreWindowState()
        Instance.WindowState = FormWindowState.Normal
        Instance.CenterToScreen()
    End Sub


    Public Shared Sub LoadControl(Child As UserControl)
        ActiveChild = Child
        Instance.Controls.Clear()
        Instance.Size = Child.Size
        Child.Dock = DockStyle.Fill
        Child.Location = New Point(0, 0)
        Instance.Controls.Add(Child)
        Instance.CenterToScreen()
        If TypeOf Child Is MainControl Then
            DirectCast(Child, MainControl).RefreshControl()
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Main
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "Main"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
End Class
