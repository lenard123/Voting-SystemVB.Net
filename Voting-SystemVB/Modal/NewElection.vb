Public Class NewElection

    Private AlertLoading As Alert

    Private Shared Popup As ModalPopup
    Private Shared Voters As List(Of Student)

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup
        Popup.Init(New NewElection)
        Popup.ShowPopup()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Popup.ClosePopup()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        AlertLoading = Alert.ShowAlert("Loading, Please wait", Alert.AlertType.Info)
        BWNewElection.RunWorkerAsync(SwitchKeepVoter.Checked)
    End Sub

    Private Sub BWKeepVoters_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWKeepVoters.DoWork
        If Not IsNothing(Voters) Then
            Dim i = 1
            For Each Voter In Voters
                BWKeepVoters.ReportProgress(i / Voters.Count * 100)
                Voter.Save()
                i = i + 1
            Next
        End If
    End Sub

    Private Sub BWKeepVoters_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BWKeepVoters.ProgressChanged
        AlertLoading.setMessage("Keeping Voters - " & e.ProgressPercentage & "%")
    End Sub


    Private Sub BWKeepVoters_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BWKeepVoters.RunWorkerCompleted
        If SwitchDeleteWorker.Checked Then
            AlertLoading.setMessage("Removing Admin")
        End If
        BWDeleteAdmin.RunWorkerAsync(SwitchDeleteWorker.Checked)
    End Sub

    Private Sub BWDeleteAdmin_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWDeleteAdmin.DoWork
        If e.Argument Then
            Dim admins = Admin.GetAll()
            For Each iAdmin In admins
                If iAdmin.Username.Equals(Admin.GetCurrentUser().Username) Then Continue For
                iAdmin.delete()
            Next
        End If
    End Sub

    Private Sub BWDeleteAdmin_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BWDeleteAdmin.RunWorkerCompleted
        Alert.ShowAlert("New Election created", Alert.AlertType.Success)
        AlertLoading.CloseAlert()
        Popup.ClosePopup()
        AdminPanel.GetInstance().ActivePage = Nothing
        AdminPanel.GetInstance().Admin_Panel_Reload()
    End Sub

    Private Sub BWNewElection_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWNewElection.DoWork
        If e.Argument Then
            Voters = Student.GetAll()
        End If
        Election.NewElection()
    End Sub

    Private Sub BWNewElection_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BWNewElection.RunWorkerCompleted
        AlertLoading.setMessage("Keeping voters")
        BWKeepVoters.RunWorkerAsync()
    End Sub

End Class
