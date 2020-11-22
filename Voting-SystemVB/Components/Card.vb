Public Class Card
    Inherits Panel

    Private head As New Panel

    Public Property BGColor As Color
        Get
            Return head.BackColor
        End Get
        Set(value As Color)
            head.BackColor = value
        End Set
    End Property

    Public Sub New()
        BackColor = Color.White
        head.Dock = DockStyle.Top
        head.Height = 5
        head.BackColor = Color.FromArgb(255, 164, 91)
        Controls.Add(head)
    End Sub

End Class
