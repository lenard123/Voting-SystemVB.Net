
Imports Guna.UI2.WinForms

Public Class ManageVoters

    Private ResultSet As New List(Of Student)
    Private Filter = "All"
    Private PreviousFilter As Guna2Button
    Private Shared Instance As ManageVoters
    Public FilterVoter As Integer = 0

    Public Shared Function GetInstance() As ManageVoters
        If IsNothing(Instance) Then
            Instance = New ManageVoters()
        End If
        Return Instance
    End Function

    Private ReadOnly Property FilteredResultSet As List(Of Student)
        Get
            If FilterVoter = 0 Then
                LabelResult.Text = ""
                If Filter.Equals("All") Then
                    Return ResultSet
                End If
            End If
            Dim _FilteredRS = New List(Of Student)
            For Each Item In ResultSet
                If IsValidItem(Item) Then
                    _FilteredRS.Add(Item)
                End If
            Next
            Return _FilteredRS
        End Get
    End Property

    Public Function IsValidItem(item As Student) As Boolean
        If Not Filter.Equals(item.YearLevel) And Not Filter.Equals("All") Then Return False
        If Election.IsOngoing Then
            If FilterVoter = 1 And Not item.HasVoted Then Return False
            If FilterVoter = 2 And item.HasVoted Then Return False
        End If
        Return True
    End Function

    Private Async Sub ManageVoters_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If Not Election.HasNotStarted Then
            ButtonAddVoter.Visible = False
        End If

        If IsNothing(PreviousFilter) Then PreviousFilter = ButtonFilterAll
        Await RefreshStudent()
    End Sub

    Public Async Function RefreshStudent() As Task
        ResultSet = Await Student.GetAllAsync()
        LoadStudent()
    End Function

    Private Sub LoadStudent()
        StudentDataGridView.DataSource = FilteredResultSet
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
        End If
        LoadStudent()
    End Sub

    Private Sub ButtonAddVoter_Click(sender As Object, e As EventArgs) Handles ButtonAddVoter.Click
        Dim add As New AddVoter(Me)
        add.ShowPopup()
    End Sub

    Private Async Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        FilterVoter = 0
        Await RefreshStudent()
    End Sub

    Private Sub StudentDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellDoubleClick
        If Election.HasNotStarted Then
            Dim update As New UpdateVoter(FilteredResultSet(e.RowIndex), Me)
            update.ShowPopup()
        End If
    End Sub

    Private Async Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextSearch.Text.Trim.ToUpper.Equals("DONE VOTERS") Then
            FilterVoter = 1
            LabelResult.Text = "Showing Voters who already voted"
        ElseIf TextSearch.Text.Trim.ToUpper.Equals("REMAINING VOTERS") Then
            FilterVoter = 2
            LabelResult.Text = "Showing Voters who haven't voted yet"
        ElseIf Not TextSearch.Text.Trim.Equals("") Then
            FilterVoter = 0
            LabelResult.Text = "Searching..."
            ResultSet = Await Student.SearchAsync(TextSearch.Text)
            LabelResult.Text = "Search Results for: """ & TextSearch.Text & """"
        End If
        LoadStudent()
    End Sub

End Class
