Module CustomExceptions

    Public Class ElectionHasNotStartedException : Inherits ApplicationException
        Public Sub New()
            MyBase.New("Election has not started yet")
        End Sub
    End Class

    Public Class ElectionAlreadyStartedException : Inherits ApplicationException
        Public Sub New()
            MyBase.New("Election has already started")
        End Sub
    End Class

    Public Class StudentNotExistsException : Inherits ApplicationException
        Public Sub New()
            MyBase.New("Student does not exists in the database")
        End Sub
    End Class

    Public Class AdminNotExistsException : Inherits ApplicationException
        Public Sub New()
            MyBase.New("The Username does not exists in the database")
        End Sub
    End Class

    Public Class InvalidPasswordException : Inherits ApplicationException
        Public Sub New()
            MyBase.New("Password not match")
        End Sub
    End Class

    Public Class InvalidPrivilegeException : Inherits ApplicationException
        Public Sub New()
            MyBase.New("You don't have a privilege to perform this action")
        End Sub
    End Class

    Public Class NotLoggedInException : Inherits ApplicationException
        Public Sub New()
            MyBase.New("You have to login first")
        End Sub
    End Class

    Public Class AlreadyVotedException : Inherits ApplicationException
        Public Sub New()
            MyBase.New("You already voted, you can only vote once")
        End Sub
    End Class

End Module
