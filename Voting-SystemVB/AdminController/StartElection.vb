Public Class StartElection

    Dim IsValidName = False
    Dim IsValidPassword = False
    Private Shared Instance As StartElection

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Guna2DateTimePicker1.MaxDate = Date.Now().AddMonths(1)
        Guna2DateTimePicker1.MinDate = Date.Now().AddDays(1)

    End Sub

    Public Shared Function GetInstance() As StartElection
        If IsNothing(Instance) Then
            Instance = New StartElection()
        End If
        Return Instance
    End Function

    Private Async Sub StartElection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadCandidates()
    End Sub

    Private Async Function LoadCandidates() As Task
        Dim Tasks = New List(Of Task(Of List(Of Candidate)))
        Tasks.Add(Candidate.GetAllByPositionAsync(Position.PRESIDENT_ID))
        Tasks.Add(Candidate.GetAllByPositionAsync(Position.VICE_PRESIDENT_ID))
        Tasks.Add(Candidate.GetAllByPositionAsync(Position.SECRETARY_ID))
        Tasks.Add(Candidate.GetAllByPositionAsync(Position.TREASURER_ID))
        Tasks.Add(Candidate.GetAllByPositionAsync(Position.AUDITOR_ID))
        Tasks.Add(Candidate.GetAllByPositionAsync(Position.PRO_ID))
        Dim Result = Await Task.WhenAll(Tasks)
        Dim Names() As String = {"President", "Vice President", "Secretary", "Treasurer", "Auditor", "P.R.O."}
        For I As Integer = 0 To 5
            FlowLayoutPanel1.Controls.Add(New CandidatesList(Result(I), Names(I), CandidatesList.CandidateType.Text))
        Next
    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If ValidateForm() Then
            If Election.StartElection(TextName.Text, GetEndDate()) Then
                Alert.ShowAlert("Election successfully started", Alert.AlertType.Success)
                AdminPanel.GetInstance().RefreshState()
                AdminPanel.GetInstance().LoadControl(AdminPanel.GetInstance().AdminHomeControl())
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

    Private Sub StartElection_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        TextPassword.Text = ""
        TextName.Text = ""
        TextPassword.BorderColor = Color.FromArgb(217, 221, 226)
        TextName.BorderColor = Color.FromArgb(217, 221, 226)
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        If Not IsNothing(AdminPanel.GetInstance()) Then
            AdminPanel.GetInstance().LoadControl(AdminPanel.GetInstance().AdminHomeControl())
        End If
    End Sub
End Class
