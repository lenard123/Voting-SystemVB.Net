Imports Guna.UI2.WinForms

Public Class UploadDatabase

    Public Shared Popup As ModalPopup

    Public Shared Sub ShowPopup()
        Popup = New ModalPopup()
        Popup.Init(New UploadDatabase)
        Popup.ShowPopup()
    End Sub

    Dim SelectedDatabase As DatabaseType = DatabaseType.NONE
    Dim CONNECTION_ACCESS As OleDb.OleDbConnection
    Dim DB_SCHEMA As Dictionary(Of String, List(Of String))
    Dim KEEP_OLD_DATA As Boolean

    Private Sub CBDatabaseType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBDatabaseType.SelectedIndexChanged
        DisableControls()
        TextDBPath.Text = "Click here to Upload database"
        Select Case CBDatabaseType.SelectedIndex
            Case 0
                SelectedDatabase = DatabaseType.NONE
            Case 2
                TextDBPath.Enabled = True
                SelectedDatabase = DatabaseType.ACCDB
                OpenFileDialogDatabase.Filter = "MS Access Database |*.accdb"
            Case Else
                Alert.ShowAlert("Selected Database is currently not supported", Alert.AlertType.Error)
        End Select
    End Sub

    Sub PopulateTableNames()
        If IsNothing(DB_SCHEMA) Then Return
        Dim dt As New DataTable
        dt.Columns.Add("item")
        dt.Rows.Add("Select table")
        For Each item In DB_SCHEMA
            dt.Rows.Add(item.Key)
        Next
        CBTables.DataSource = dt
        CBTables.DisplayMember = "item"
    End Sub

    Sub PupulateColumnNames()
        If IsNothing(DB_SCHEMA) And Not DB_SCHEMA.ContainsKey(CBTables.Text) Then Return
        Dim columns = New List(Of String)
        columns.Add("Select Column")
        columns.AddRange(DB_SCHEMA(CBTables.Text))

        CBStudentID.DataSource = columns.ToList()
        CBFirstname.DataSource = columns.ToList()
        CBLastname.DataSource = columns.ToList()
        CBCourse.DataSource = columns.ToList()
        CBYear.DataSource = columns.ToList()
        CBSection.DataSource = columns.ToList()

    End Sub

    Sub DisableControls()
        TextDBPath.Enabled = False
        CBTables.Enabled = False
        CBStudentID.Enabled = False
        CBFirstname.Enabled = False
        CBLastname.Enabled = False
        CBCourse.Enabled = False
        CBYear.Enabled = False
        CBSection.Enabled = False
        ButtonReplace.Enabled = False
        ButtonIgnore.Enabled = False
    End Sub

    Sub EnableControls()
        TextDBPath.Enabled = True
        CBTables.Enabled = True
        CBStudentID.Enabled = True
        CBFirstname.Enabled = True
        CBLastname.Enabled = True
        CBCourse.Enabled = True
        CBYear.Enabled = True
        CBSection.Enabled = True
        ButtonReplace.Enabled = True
        ButtonIgnore.Enabled = True
    End Sub

    Private Sub TextDBPath_TextClick(sender As Object, e As EventArgs) Handles TextDBPath.Click
        If OpenFileDialogDatabase.ShowDialog() = DialogResult.OK Then
            TextDBPath.Text = OpenFileDialogDatabase.FileName
            BackgroundWorkerTestConnection.RunWorkerAsync(GetConnectionString())
        End If
    End Sub

    Function GetConnectionString() As String
        Return "Provider=" & GetProvider(SelectedDatabase) & ";Data Source=""" & TextDBPath.Text & """;Ole DB Services=-1"
    End Function

    Enum TestConnectionState
        CONNECTING
        FAILED
        GETTING_DATABASE_SCHEMA
        SUCCESS
    End Enum

    Private Sub BackgroundWorkerTestConnection_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerTestConnection.DoWork
        BackgroundWorkerTestConnection.ReportProgress(0, TestConnectionState.CONNECTING)
        Select Case SelectedDatabase
            Case 2
                CONNECTION_ACCESS = New OleDb.OleDbConnection(e.Argument)
                Try
                    CONNECTION_ACCESS.Open()
                    CONNECTION_ACCESS.Close()
                    BackgroundWorkerTestConnection.ReportProgress(1, TestConnectionState.GETTING_DATABASE_SCHEMA)
                    DB_SCHEMA = GetDBSchema(DatabaseType.ACCDB, CONNECTION_ACCESS)
                    e.Result = TestConnectionState.SUCCESS
                Catch ex As Exception
                    e.Result = TestConnectionState.FAILED
                End Try
        End Select
    End Sub

    Private Sub BackgroundWorkerTestConnection_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerTestConnection.RunWorkerCompleted
        PanelTestConnectionLoadng.Visible = False
        Select Case e.Result
            Case TestConnectionState.SUCCESS
                Alert.ShowAlert("Connected to database", Alert.AlertType.Success)
                EnableControls()
                PopulateTableNames()
            Case TestConnectionState.FAILED
                Alert.ShowAlert("Failed to connect to database", Alert.AlertType.Error)
        End Select
    End Sub

    Private Sub BackgroundWorkerTestConnection_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorkerTestConnection.ProgressChanged
        PanelTestConnectionLoadng.Visible = True
        Select Case e.UserState
            Case TestConnectionState.CONNECTING
                PanelTestConnectionLoadng.Controls(1).Text = "Establashing Connection. please wait..."
            Case TestConnectionState.GETTING_DATABASE_SCHEMA
                PanelTestConnectionLoadng.Controls(1).Text = "Getting Database Schema"
        End Select
    End Sub

    Private Sub CBTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTables.SelectedValueChanged
        If CBTables.SelectedIndex > 0 Then
            PupulateColumnNames()
        End If
    End Sub

    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        If Not Admin.GetCurrentUser().CanDoAll() Then
            Alert.ShowAlert("You don't have a privilege to perform this action", Alert.AlertType.Error)
        End If
        If BackgroundWorkerUpload.IsBusy Then Return
        If ValidateFields() Then
            KEEP_OLD_DATA = ButtonIgnore.Checked

            Dim args As New List(Of String)
            args.Add(CountAllQuery())
            args.Add(FetchAllQuery())

            Panel2.Visible = True

            BackgroundWorkerUpload.RunWorkerAsync(args)

        End If
    End Sub

    Function CountAllQuery() As String
        Dim query = "SELECT COUNT(*) FROM [STUDENT]"
        Return query.Replace("STUDENT", CBTables.Text)
    End Function

    Function FetchAllQuery() As String
        Dim query = "SELECT [STUDENT_ID],[FIRSTNAME],[LASTNAME],[COURSE],[YEAR],[SECTION] FROM [STUDENTS]"
        query = query.Replace("STUDENT_ID", CBStudentID.Text)
        query = query.Replace("FIRSTNAME", CBFirstname.Text)
        query = query.Replace("LASTNAME", CBLastname.Text)
        query = query.Replace("COURSE", CBCourse.Text)
        query = query.Replace("YEAR", CBYear.Text)
        query = query.Replace("SECTION", CBSection.Text)
        query = query.Replace("STUDENTS", CBTables.Text)
        Return query
    End Function

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If BackgroundWorkerUpload.IsBusy Then Return
        Popup.ClosePopup()
    End Sub

    Function ValidateFields() As Boolean
        If Not IsNothing(DB_SCHEMA) AndAlso DB_SCHEMA.ContainsKey(CBTables.Text) Then
            If ValidColumns(CBStudentID, "StudentID") AndAlso
                ValidColumns(CBFirstname, "Firstname") AndAlso
                ValidColumns(CBLastname, "Lastname") AndAlso
                ValidColumns(CBCourse, "Course") AndAlso
                ValidColumns(CBYear, "Year") AndAlso
                ValidColumns(CBSection, "Section") Then
                Return True
            Else
                Return False
            End If
        Else
            Alert.ShowAlert("No table selected", Alert.AlertType.Error)
            Return False
        End If
    End Function

    Function ValidColumns(cb As Guna2ComboBox, fieldname As String) As Boolean
        If Not DB_SCHEMA(CBTables.Text).Contains(cb.Text) Then
            Alert.ShowAlert("Invalid " & fieldname & " column", Alert.AlertType.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub BackgroundWorkerUpload_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerUpload.DoWork
        Dim args = DirectCast(e.Argument, List(Of String))
        Dim CountRows = 0
        Dim Counter = 0
        Select Case SelectedDatabase
            Case DatabaseType.ACCDB
                CONNECTION_ACCESS.Open()
                Using Cmd As New OleDb.OleDbCommand()
                    Cmd.CommandText = args(0)
                    Cmd.Connection = CONNECTION_ACCESS
                    CountRows = Integer.Parse(Cmd.ExecuteScalar())
                    BackgroundWorkerUpload.ReportProgress(Counter / CountRows * 100, "Uploading " & Counter & " out of " & CountRows & " records")

                    Cmd.CommandText = args(1)
                    Using Reader = Cmd.ExecuteReader()
                        While Reader.Read()
                            Dim student_id = Reader.GetString(0)
                            Dim firstname = Reader.GetString(1)
                            Dim lastname = Reader.GetString(2)
                            Dim course = Reader.GetString(3)
                            Dim year = Reader.GetString(4)
                            Dim section = Reader.GetString(5)

                            Dim iStudent = Student.Find(student_id)
                            Dim isDuplicate = Not IsNothing(iStudent)

                            If isDuplicate And KEEP_OLD_DATA Then
                                Counter += 1
                                BackgroundWorkerUpload.ReportProgress(Counter / CountRows * 100, "Uploading " & Counter & " out of " & CountRows & " records")
                                Continue While
                            End If

                            If IsNothing(iStudent) Then
                                iStudent = New Student()
                            End If

                            iStudent.StudentId = student_id
                            iStudent.Firstname = firstname
                            iStudent.Lastname = lastname
                            iStudent.Course = course
                            iStudent.YearLevel = year
                            iStudent.Section = section

                            If isDuplicate Then
                                iStudent.Update()
                            Else
                                iStudent.Save()
                            End If

                            Counter += 1
                            BackgroundWorkerUpload.ReportProgress(Counter / CountRows * 100, "Uploading " & Counter & " out of " & CountRows & " records")

                        End While
                    End Using
                End Using
                CONNECTION_ACCESS.Close()
        End Select
    End Sub

    Private Sub BackgroundWorkerUpload_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorkerUpload.ProgressChanged
        Guna2CircleProgressBar2.Value = e.ProgressPercentage
        Label12.Text = e.UserState
    End Sub
End Class
