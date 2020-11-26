Public Class MaterialTextbox

    Private _Min As Integer = 0
    Private _Max As Integer = 32767
    Private _Exact As Integer = 0
    Private _IsRequired As Boolean = False
    Private _FieldName As String = "Field"
    Private _IdleColor As Color = Color.Gray
    Private _ActiveColor As Color = Color.Blue
    Private _ErrorColor As Color = Color.Red
    Private _Numeric As Boolean = False

    Public Property Numeric As Boolean
        Get
            Return _Numeric
        End Get
        Set(value As Boolean)
            _Numeric = value
        End Set
    End Property

    Public Property IsRequired As Boolean
        Get
            Return _IsRequired
        End Get
        Set(value As Boolean)
            _IsRequired = value
        End Set
    End Property

    Public Property ErrorColor As Color
        Get
            Return _ErrorColor
        End Get
        Set(value As Color)
            LabelError.ForeColor = value
            _ErrorColor = value
        End Set
    End Property

    Public Property FieldName As String
        Get
            Return _FieldName
        End Get
        Set(value As String)
            _FieldName = value
        End Set
    End Property

    Public Property ActiveColor As Color
        Get
            Return _ActiveColor
        End Get
        Set(value As Color)
            _ActiveColor = value
        End Set
    End Property

    Public Property IdleColor As Color
        Get
            Return _IdleColor
        End Get
        Set(value As Color)
            Underline.BackColor = value
            _IdleColor = value
        End Set
    End Property

    Public Property Min As Integer
        Get
            Return _Min
        End Get
        Set(value As Integer)
            If value < 0 Then
                value = 0
            ElseIf value > Max Then
                value = Max
            End If
            _Min = value
        End Set
    End Property

    Public Property Max As Integer
        Get
            Return _Max
        End Get
        Set(value As Integer)
            If value < _Min Then
                value = _Min
            ElseIf value < 0 Then
                value = 32767
            End If
            TextField.MaxLength = value
            _Max = value
        End Set
    End Property


    Public Property Exact As Integer
        Get
            Return Exact
        End Get
        Set(value As Integer)
            If value < 0 Then
                value = 0
            End If
            _Min = value
        End Set
    End Property

    Private Sub TextField_Enter(sender As Object, e As EventArgs) Handles TextField.Enter
        Underline.BackColor = _ActiveColor
    End Sub

    Private Sub TextField_Leave(sender As Object, e As EventArgs) Handles TextField.Leave
        ValidateField()
    End Sub

    Private Function ValidateField() As Boolean
        Underline.BackColor = ErrorColor
        Dim length = TextField.TextLength

        If IsRequired Or length > 0 Then
            If length.Equals(0) Then
                LabelError.Text = FieldName & " field is required."
                Return False
            ElseIf Not Exact.Equals(0) And Not length.Equals(Exact) Then
                LabelError.Text = FieldName & " field must have exactly " & Exact & " character(s)."
                Return False
            ElseIf Not Min.Equals(0) And length < Min Then
                LabelError.Text = FieldName & " field must have atleast " & Min & " character(s)."
                Return False
            End If
        End If

        LabelError.Text = ""
        Underline.BackColor = IdleColor
        Return True
    End Function

    Private Sub TextField_KeyUp(sender As Object, e As KeyPressEventArgs) Handles TextField.KeyPress
        If Numeric Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub
End Class
