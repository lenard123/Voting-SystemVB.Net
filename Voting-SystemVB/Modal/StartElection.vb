Public Class StartElection

    Private Shared Popup As ModalPopup

    Dim IsValidName As Boolean = False
    Dim IsValidPassword As Boolean = False

    Dim Title As String
    Dim EndDate As Date

    Private Sub StartElection1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextName.Text = Date.Now().Year & " Student Council Election"
        Guna2DateTimePicker1.MaxDate = Date.Now().AddMonths(1)
        Guna2DateTimePicker1.MinDate = Date.Now().AddDays(1)

    End Sub

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup
        Popup.Init(New StartElection)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Popup.ClosePopup()
    End Sub

    Private Sub TextName_Leave(sender As Object, e As EventArgs) Handles TextName.Leave
        IsValidName = Util.Validator("Name", TextName, ErrorName, "required", "min:6")
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

    Public Function GetEndDate() As Date
        Dim Hour As Double = 0D
        If Guna2RadioButton1.Checked Then Hour = 7
        If Guna2RadioButton2.Checked Then Hour = 12
        If Guna2RadioButton3.Checked Then Hour = 18
        Dim eDate = Guna2DateTimePicker1.Value
        Dim Res = New Date(eDate.Year, eDate.Month, eDate.Day, Hour, 0, 0)
        Return Res
    End Function

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

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        TextName_Leave(sender, e)
        TextPassword_Leave(sender, e)
        If IsValidName And IsValidPassword Then
            Title = TextName.Text
            EndDate = GetEndDate()
            StartLoading()
            BackgroundWorkerStartElection.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorkerStartElection_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerStartElection.DoWork
        e.Result = Election.StartElection(Title, EndDate)
        Election.GetCurrentElectionF()
    End Sub

    Private Sub BackgroundWorkerStartElection_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerStartElection.RunWorkerCompleted
        StopLoading()
        If e.Result Then
            Popup.ClosePopup()
            AdminPanel.GetInstance().ActivePage = Nothing
            Alert.ShowAlert("Election has started Successfully", Alert.AlertType.Success)
            AdminPanel.GetInstance().Admin_Panel_Reload()
        Else
            Alert.ShowAlert("An error occurred", Alert.AlertType.Error)
        End If
    End Sub
End Class
