
Imports Guna.UI2.WinForms

Public Class ManageVoters

    Private ResultSet As List(Of Student)
    Private Filter = "All"
    Private PreviousFilter As Guna2Button

    Private ReadOnly Property FilteredResultSet As List(Of Student)
        Get
            If Filter.Equals("All") Then Return ResultSet
            Dim _FilteredRS = New List(Of Student)
            For Each Item In ResultSet
                If Filter.Equals(Item.YearLevel) Then
                    _FilteredRS.Add(Item)
                End If
            Next
            Return _FilteredRS
        End Get
    End Property

    Private Sub ManageVoters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudent()
        PreviousFilter = ButtonFilterAll
    End Sub

    Private Async Sub LoadStudent()
        ResultSet = Await Student.GetAllAsync()
        StudentDataGridView.DataSource = FilteredResultSet
        DataStatus.Text = ""
    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilterAll.Click, ButtonFilter1st.Click, ButtonFilter4th.Click, ButtonFilter3rd.Click, ButtonFilter2nd.Click
        If (sender.Equals(PreviousFilter)) Then Return
        PreviousFilter.FillColor = SystemColors.Control
        PreviousFilter.ForeColor = SystemColors.ControlDarkDark
        If (sender.Equals(ButtonFilterAll)) Then
            ButtonFilterAll.FillColor = Color.FromArgb(255, 164, 91)
            ButtonFilterAll.ForeColor = Color.White
            PreviousFilter = ButtonFilterAll
            Filter = "All"
        ElseIf sender.Equals(ButtonFilter1st) Then
            ButtonFilter1st.FillColor = Color.FromArgb(255, 164, 91)
            ButtonFilter1st.ForeColor = Color.White
            PreviousFilter = ButtonFilter1st
            Filter = "1st year"
        ElseIf sender.Equals(ButtonFilter2nd) Then
            ButtonFilter2nd.FillColor = Color.FromArgb(255, 164, 91)
            ButtonFilter2nd.ForeColor = Color.White
            PreviousFilter = ButtonFilter2nd
            Filter = "2nd year"
        ElseIf sender.Equals(ButtonFilter3rd) Then
            ButtonFilter3rd.FillColor = Color.FromArgb(255, 164, 91)
            ButtonFilter3rd.ForeColor = Color.White
            PreviousFilter = ButtonFilter3rd
            Filter = "3rd year"
        ElseIf sender.Equals(ButtonFilter4th) Then
            ButtonFilter4th.FillColor = Color.FromArgb(255, 164, 91)
            ButtonFilter4th.ForeColor = Color.White
            PreviousFilter = ButtonFilter4th
            Filter = "4th year"
            LoadStudent()
        End If
        LoadStudent()
    End Sub

    Private Sub ButtonAddVoter_Click(sender As Object, e As EventArgs) Handles ButtonAddVoter.Click
        Dim add As New AddVoter()
        add.ShowPopup()
        LoadStudent()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        DataStatus.Text = "Loading data..."
        LoadStudent()
    End Sub

    Private Sub StudentDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellDoubleClick
        Alert.setAlert(FilteredResultSet(e.RowIndex).Fullname, Alert.AlertType.Info)
        '        Dim update As New UpdateVoter()
    End Sub
End Class
