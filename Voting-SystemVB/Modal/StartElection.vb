Public Class StartElection

    Implements MainControl

    Dim IsValidName = False
    Dim IsValidPassword = False
    Dim Candidates As Dictionary(Of Integer, List(Of Candidate))
    Private Shared Instance As StartElection

    Public Shared Function GetInstance() As StartElection
        If IsNothing(Instance) Then
            Instance = New StartElection()
        End If
        Return Instance
    End Function

    Private Sub StartElection_Refresh() Implements MainControl.RefreshControl
        TextPassword.Text = ""
        TextName.Text = ""
        TextPassword.BorderColor = Color.FromArgb(217, 221, 226)
        TextName.BorderColor = Color.FromArgb(217, 221, 226)
        ' Add any initialization after the InitializeComponent() call.
        Guna2DateTimePicker1.MaxDate = Date.Now().AddMonths(1)
        Guna2DateTimePicker1.MinDate = Date.Now().AddDays(1)

        StartLoading()
        BackgroundWorkerLoad.RunWorkerAsync()
        'Await LoadCandidates()
    End Sub

    Sub StartLoading()
        LabelLoading.Visible = True
        Guna2WinProgressIndicator1.Visible = True
        Guna2WinProgressIndicator1.Start()
        ButtonCancel.Enabled = False
        ButtonStart.Enabled = False
    End Sub
    Sub StopLoading()
        LabelLoading.Visible = False
        Guna2WinProgressIndicator1.Visible = False
        Guna2WinProgressIndicator1.Stop()
        ButtonCancel.Enabled = True
        ButtonStart.Enabled = True
    End Sub

    'Private Async Function LoadCandidates() As Task
    '    Dim Result As New List(Of List(Of Candidate))

    '    Result.Add(Await Candidate.GetAllByPositionAsync(Position.PRESIDENT_ID))
    '    Result.Add(Await Candidate.GetAllByPositionAsync(Position.VICE_PRESIDENT_ID))
    '    Result.Add(Await Candidate.GetAllByPositionAsync(Position.SECRETARY_ID))
    '    Result.Add(Await Candidate.GetAllByPositionAsync(Position.TREASURER_ID))
    '    Result.Add(Await Candidate.GetAllByPositionAsync(Position.AUDITOR_ID))
    '    Result.Add(Await Candidate.GetAllByPositionAsync(Position.PRO_ID))

    '    Dim Names() As String = {"President", "Vice President", "Secretary", "Treasurer", "Auditor", "P.R.O."}
    '    For I As Integer = 0 To 5
    '        FlowLayoutPanel1.Controls.Add(New CandidatesList(Result(I), Names(I), CandidatesList.CandidateType.Text))
    '    Next
    'End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If ValidateForm() Then
            If Election.StartElection(TextName.Text, GetEndDate()) Then
                Alert.ShowAlert("Election successfully started", Alert.AlertType.Success)
                AdminPanel.GetInstance().Admin_Panel_Reload()
                Dispose()
            Else
                Alert.ShowAlert("Election failed to start", Alert.AlertType.Error)
            End If
        End If
    End Sub

    Public Function GetEndDate() As Date
        Dim Hour As Double = 0D
        If Guna2RadioButton1.Checked Then Hour = 7
        If Guna2RadioButton2.Checked Then Hour = 12
        If Guna2RadioButton3.Checked Then Hour = 18
        Dim eDate = Guna2DateTimePicker1.Value
        Dim Res = New Date(eDate.Year, eDate.Month, eDate.Day, Hour, 0, 0)
        Return Res
    End Function

    Private Function ValidateForm() As Boolean
        TextName_Leave(Nothing, Nothing)
        TextPassword_Leave(Nothing, Nothing)
        Return IsValidName And IsValidPassword
    End Function

    Private Sub TextName_Leave(sender As Object, e As EventArgs) Handles TextName.Leave
        IsValidName = Util.Validator("Name", TextName, ErrorName, "required")
    End Sub

    Private Sub TextPassword_Leave(sender As Object, e As EventArgs) Handles TextPassword.Leave
        IsValidPassword = Util.Validator("Password", TextPassword, ErrorPassword, "required")
        If IsValidPassword Then
            If Not Admin.GetCurrentUser().ComparePassword(TextPassword.Text) Then
                IsValidPassword = False
                TextPassword.BorderColor = Color.Red
                ErrorPassword.Text = "Password not match"
            End If
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        AdminPanel.GetInstance().ButtonHome.PerformClick()
    End Sub

    Private Sub BackgroundWorkerLoad_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerLoad.DoWork
        Candidates = Candidate.GetAll2()
    End Sub

    Private Sub BackgroundWorkerLoad_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerLoad.RunWorkerCompleted
        StopLoading()
        For Each item In Candidates
            FlowLayoutPanel1.Controls.Add(New CandidatesList(item.Value, Position.GetName(item.Key), CandidatesList.CandidateType.Text))
        Next
    End Sub
End Class
