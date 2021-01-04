Imports Guna.UI2.WinForms

Public Class ManageVoters

    Implements MainControl

    Private ResultSet As New List(Of Student)
    Private Filter = "All"
    Private PreviousFilter As Guna2Button
    Private Shared Instance As ManageVoters
    Public FilterVoter As Integer = 0

    Public Shared Function GetInstance() As ManageVoters
        If IsNothing(Instance) Then
            Instance = New ManageVoters()
            Instance.DoubleBuffered = True
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

    Private Sub ManageVoters_Refresh() Implements MainControl.RefreshControl
        If Not Election.HasNotStarted Then
            ButtonAddVoter.Visible = False
        End If

        If IsNothing(PreviousFilter) Then PreviousFilter = ButtonFilterAll
        RefreshStudent()
    End Sub

    Public Sub RefreshStudent()
        If BackgroundWorkerRefreshStudent.IsBusy Then Return
        BackgroundWorkerRefreshStudent.RunWorkerAsync()
    End Sub

    Private Sub LoadStudent()
        StudentDataGridView.DataSource = FilteredResultSet
    End Sub

    Private Sub ButtonFilter_Click(sender As Guna2Button, e As EventArgs) Handles ButtonFilterAll.Click, ButtonFilter1st.Click, ButtonFilter4th.Click, ButtonFilter3rd.Click, ButtonFilter2nd.Click
        If (sender.Equals(PreviousFilter)) Then Return

        PreviousFilter.FillColor = SystemColors.Control
        PreviousFilter.ForeColor = SystemColors.ControlDarkDark

        sender.FillColor = Color.FromArgb(255, 164, 91)
        sender.ForeColor = Color.White
        PreviousFilter = sender
        Filter = sender.Text

        LoadStudent()
    End Sub

    Private Sub ButtonAddVoter_Click(sender As Object, e As EventArgs) Handles ButtonAddVoter.Click
        Dim add As New AddVoter()
        add.ShowPopup()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        FilterVoter = 0
        RefreshStudent()
    End Sub

    Private Sub StudentDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellDoubleClick
        If TypeOf FilteredResultSet(e.RowIndex) Is Student Then
            If Election.HasNotStarted Then
                Dim update As New UpdateVoter(FilteredResultSet(e.RowIndex))
                update.ShowPopup()
            Else
                VotersInfo.ShowPopup(FilteredResultSet(e.RowIndex))
            End If
        End If
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextSearch.Text.Trim.ToUpper.Equals("DONE VOTERS") Then
            FilterVoter = 1
            LabelResult.Text = "Showing Voters who already voted"
            LoadStudent()
        ElseIf TextSearch.Text.Trim.ToUpper.Equals("REMAINING VOTERS") Then
            FilterVoter = 2
            LabelResult.Text = "Showing Voters who haven't voted yet"
            LoadStudent()
        ElseIf Not TextSearch.Text.Trim.Equals("") And Not BackgroundWorkerSearch.IsBusy Then
            FilterVoter = 0
            LabelResult.Text = "Searching..."
            BackgroundWorkerSearch.RunWorkerAsync(TextSearch.Text)
        End If
    End Sub

    Private Sub BackgroundWorkerRefreshStudent_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerRefreshStudent.DoWork
        ResultSet = Student.GetAll()
    End Sub

    Private Sub BackgroundWorkerLoadStudent_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerRefreshStudent.RunWorkerCompleted
        LoadStudent()
    End Sub

    Private Sub BackgroundWorkerSearch_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSearch.DoWork
        ResultSet = Student.Search(e.Argument)
        e.Result = e.Argument
    End Sub

    Private Sub BackgroundWorkerSearch_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerSearch.RunWorkerCompleted
        LoadStudent()
        LabelResult.Text = "Search Results for: """ & e.Result & """"
    End Sub
End Class
