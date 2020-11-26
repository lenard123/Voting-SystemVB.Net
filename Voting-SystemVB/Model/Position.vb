Public Class Position

    Public Shared ReadOnly PRESIDENT_ID = 1
    Public Shared ReadOnly VICE_PRESIDENT_ID = 2
    Public Shared ReadOnly SECRETARY_ID = 3
    Public Shared ReadOnly TREASURER_ID = 4
    Public Shared ReadOnly AUDITOR_ID = 5
    Public Shared ReadOnly PRO_ID = 6

    Public Shared Function GetDatatable() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("name")
        dt.Columns.Add("id")

        dt.Rows.Add("President", PRESIDENT_ID)
        dt.Rows.Add("Vice President", VICE_PRESIDENT_ID)
        dt.Rows.Add("Secretary", SECRETARY_ID)
        dt.Rows.Add("Treasurer", TREASURER_ID)
        dt.Rows.Add("Auditor", AUDITOR_ID)
        dt.Rows.Add("P.R.O.", PRO_ID)

        Return dt
    End Function

End Class
