
Imports Guna.UI2.WinForms

Public Class UpdatePrivileges

    Private Shared Popup As ModalPopup
    Private Admins As List(Of Admin)

    Private SwitchPrivileges As New Dictionary(Of Guna2ToggleSwitch, Integer)
    Private Priviliges As New List(Of Integer)

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup
        Popup.Init(New UpdatePrivileges)
        Popup.ShowPopup()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Popup.ClosePopup()
    End Sub

    Private Sub UpdatePrivileges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPrivileges.Add(Guna2ToggleSwitch1, 2)
        SwitchPrivileges.Add(Guna2ToggleSwitch4, 5)
        SwitchPrivileges.Add(Guna2ToggleSwitch2, 3)
        SwitchPrivileges.Add(Guna2ToggleSwitch5, 7)
        SwitchPrivileges.Add(Guna2ToggleSwitch3, 4)
        SwitchPrivileges.Add(Guna2ToggleSwitch9, 10)
        SwitchPrivileges.Add(Guna2ToggleSwitch6, 8)

        CBUsername.DataSource = GetDataTable()
        CBUsername.DisplayMember = "username"

    End Sub

    Private Function GetDataTable() As DataTable
        Dim Result As New DataTable
        Admins = Admin.GetAll()
        Result.Columns.Add("username")
        Result.Rows.Add("Select Sub Admin Username")
        For Each iAdmin In Admins
            If iAdmin.Username.Equals(Admin.GetCurrentUser().Username) Then Continue For
            Result.Rows.Add(iAdmin.Username)
        Next
        Return Result
    End Function

    Private Sub CBUsername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUsername.SelectedIndexChanged
        Dim sAdmin = GetSelected()
        If IsNothing(sAdmin) Then
            TextFullname.Text = ""
            Priviliges.Clear()
            SwitchToggles()
        Else
            TextFullname.Text = sAdmin.Fullname
            sAdmin.FetchPrivilege()
            Priviliges = sAdmin.Privileges
            SwitchToggles()
        End If
    End Sub

    Private Sub SwitchToggles()
        For Each toggle In SwitchPrivileges
            Debug.WriteLine(Priviliges.Find(Function(i) i.Equals(toggle.Value)))
            toggle.Key.Checked = (Priviliges.Find(Function(i) i.Equals(toggle.Value))) > 0
        Next
    End Sub

    Private Function GetSelected() As Admin
        Return Admins.Find((Function(a) a.Username.Equals(CBUsername.Text)))
    End Function

    Private Sub togglePrivileges(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged, Guna2ToggleSwitch9.CheckedChanged, Guna2ToggleSwitch6.CheckedChanged, Guna2ToggleSwitch5.CheckedChanged, Guna2ToggleSwitch4.CheckedChanged, Guna2ToggleSwitch3.CheckedChanged, Guna2ToggleSwitch2.CheckedChanged
        Dim aSender = DirectCast(sender, Guna2ToggleSwitch)
        If aSender.Checked Then
            Priviliges.Add(SwitchPrivileges(aSender))
        Else
            Priviliges.Remove(SwitchPrivileges(aSender))
        End If
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If Not ValidateForm() Then Return

        If Admin.UpdatePrivileges(CBUsername.Text, Priviliges) Then
            Alert.ShowAlert("Admin Privileges updated successfully", Alert.AlertType.Success)
            Popup.ClosePopup()
        Else
            Alert.ShowAlert("An error occured", Alert.AlertType.Error)
        End If

    End Sub

    Private Function ValidateForm() As Boolean

        If IsNothing(GetSelected()) Then
            Alert.ShowAlert("Select a Username first", Alert.AlertType.Error)
            Return False
        End If

        If Not Admin.GetCurrentUser().ComparePassword(TextYourPassword.Text) Then
            Alert.ShowAlert("Wrong Password", Alert.AlertType.Error)
            Return False
        End If
        Return True
    End Function

End Class
