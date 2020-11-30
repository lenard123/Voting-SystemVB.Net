Public Class Position

    Public Shared ReadOnly PRESIDENT_ID = 1
    Public Shared ReadOnly VICE_PRESIDENT_ID = 2
    Public Shared ReadOnly SECRETARY_ID = 3
    Public Shared ReadOnly TREASURER_ID = 4
    Public Shared ReadOnly AUDITOR_ID = 5
    Public Shared ReadOnly PRO_ID = 6

    Private Shared AllPositions As List(Of Integer)

    Public Shared Function GetAll() As List(Of Integer)
        If IsNothing(AllPositions) Then
            Dim Res = New List(Of Integer)
            Res.Add(PRESIDENT_ID)
            Res.Add(VICE_PRESIDENT_ID)
            Res.Add(SECRETARY_ID)
            Res.Add(TREASURER_ID)
            Res.Add(AUDITOR_ID)
            Res.Add(PRO_ID)
            AllPositions = Res
        End If
        Return AllPositions
    End Function

    Public Shared Function GetDatatable() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("name")
        dt.Columns.Add("id")

        For Each PositionId In GetAll()
            dt.Rows.Add(GetName(PositionId), PositionId)
        Next

        Return dt
    End Function

    Public Shared Function GetName(Id As Integer) As String
        Select Id
            Case PRESIDENT_ID
                Return "President"
            Case VICE_PRESIDENT_ID
                Return "Vice President"
            Case SECRETARY_ID
                Return "Secretary"
            Case TREASURER_ID
                Return "Treasurer"
            Case AUDITOR_ID
                Return "Auditor"
            Case PRO_ID
                Return "P.R.O."
        End Select
        Return ""
    End Function

End Class
