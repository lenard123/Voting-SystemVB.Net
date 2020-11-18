Public Class Main

    Public Shared Instance As Main


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Instance = Me

        LoadControl(New LoadingScreen)
    End Sub

    Public Shared Sub LoadControl(Child As UserControl)
        Instance.Controls.Clear()
        Instance.Size = Child.Size
        Child.Location = New Point(0, 0)
        Instance.Controls.Add(Child)
        Instance.CenterToScreen()
    End Sub




End Class
