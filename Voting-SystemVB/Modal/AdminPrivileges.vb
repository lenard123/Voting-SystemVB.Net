Imports Guna.UI2.WinForms

Public Class AdminPrivileges

    Private Shared Popup As ModalPopup
    Private SwitchPrivileges As New Dictionary(Of Guna2ToggleSwitch, Integer)
    Private Priviliges As New List(Of Integer)

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup
        Popup.Init(New AdminPrivileges)
        Popup.ShowPopup()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Popup.ClosePopup()
    End Sub

    Private Sub AdminPrivileges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPrivileges.Add(Guna2ToggleSwitch1, 2)
        SwitchPrivileges.Add(Guna2ToggleSwitch4, 5)
        SwitchPrivileges.Add(Guna2ToggleSwitch2, 3)
        SwitchPrivileges.Add(Guna2ToggleSwitch5, 7)
        SwitchPrivileges.Add(Guna2ToggleSwitch3, 4)
        SwitchPrivileges.Add(Guna2ToggleSwitch9, 10)
        SwitchPrivileges.Add(Guna2ToggleSwitch6, 8)

        Priviliges = Admin.GetCurrentUser().Privileges
        SwitchToggles()

    End Sub

    Private Sub SwitchToggles()
        For Each toggle In SwitchPrivileges
            Debug.WriteLine(Priviliges.Find(Function(i) i.Equals(toggle.Value)))
            toggle.Key.Checked = (Priviliges.Find(Function(i) i.Equals(toggle.Value))) > 0 Or Admin.GetCurrentUser().CanDoAll()
        Next
    End Sub

    Private Sub ToggleSwitch(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged, Guna2ToggleSwitch9.CheckedChanged, Guna2ToggleSwitch6.CheckedChanged, Guna2ToggleSwitch5.CheckedChanged, Guna2ToggleSwitch4.CheckedChanged, Guna2ToggleSwitch3.CheckedChanged, Guna2ToggleSwitch2.CheckedChanged
        Dim cSender = DirectCast(sender, Guna2ToggleSwitch)
        If cSender.Checked <> (Priviliges.Find(Function(i) i.Equals(SwitchPrivileges(cSender))) > 0 Or Admin.GetCurrentUser().CanDoAll()) Then
            cSender.Checked = Not cSender.Checked
        End If
    End Sub
End Class
