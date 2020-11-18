Public Class Student

    Private _Id As Integer
    Private _StudentId, _Fullname, _Firstname, _Lastname, _Course, _Section, _YearLevel As String

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property StudentId As String
        Get
            Return _StudentId
        End Get
        Set(value As String)
            _StudentId = value
        End Set
    End Property
    Public ReadOnly Property Fullname As String
        Get
            Return _Firstname & " " & _Lastname
        End Get
    End Property

    Public Property Firstname As String
        Get
            Return _Firstname
        End Get
        Set(value As String)
            _Firstname = value
        End Set
    End Property

    Public Property Lastname As String
        Get
            Return _Lastname
        End Get
        Set(value As String)
            _Lastname = value
        End Set
    End Property

    Public Property Course As String
        Get
            Return _Course
        End Get
        Set(value As String)
            _Course = value
        End Set
    End Property

    Public Property YearLevel As String
        Get
            Return _YearLevel & " year"
        End Get
        Set(value As String)
            _YearLevel = value
        End Set
    End Property

    Public Property Section As String
        Get
            Return _Section
        End Get
        Set(value As String)
            _Section = value
        End Set
    End Property

End Class
