Public Class FontAwesome

    Inherits Label

    Private _HoverColor As Color
    Private _DefaultColor As Color

    Public Property HoverColor As Color
        Get
            If IsNothing(_HoverColor) Then Return ForeColor
            Return _HoverColor
        End Get
        Set(value As Color)
            _HoverColor = value
        End Set
    End Property

    Public Sub New()
        Me.Font = GetFontAwesomeSolid(12)
    End Sub

    Private Sub FontAwesome_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Me._DefaultColor = ForeColor
        Me.ForeColor = HoverColor
    End Sub


    Private Sub FontAwesome_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.ForeColor = _DefaultColor
    End Sub
End Class
