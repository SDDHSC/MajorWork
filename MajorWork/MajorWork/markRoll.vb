Imports System.Data.OleDb
Public Class markRoll
    'MAKE MORE EFFICIENT connects this form to previous form. 
    Public y7 As Integer
    Public y8 As Integer
    Public y9 As Integer
    Public y10 As Integer
    Public y11 As Integer
    Public y12 As Integer
    Dim adpNamesUser As New OleDbDataAdapter
    Dim conNames As OleDbConnection
    Dim dataNames As New DataSet()

    Dim adpAbsenceUser As New OleDbDataAdapter
    Dim conAbsence As OleDbConnection
    Dim dataAbsence As New DataSet()

    Dim adpUser As New OleDbDataAdapter
    Dim conAttendance As OleDbConnection
    Dim dataAttendance As New DataSet()
    'Preventing listViews headers from being resized
    Private Sub ListView1_ColumnWidthChanging(ByVal Sender As Object, ByVal E As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles ListView1.ColumnWidthChanging
        For DCol = 0 To 4
            If E.ColumnIndex = DCol Then
                E.Cancel = True
                E.NewWidth = Sender.Columns(DCol).Width
            End If
        Next DCol
    End Sub
    Private Sub markRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'takes year values from previous form
        y7 = lblY7.Text
        y8 = lblY8.Text
        y9 = lblY9.Text
        y10 = lblY10.Text
        y11 = lblY11.Text
        y12 = lblY12.Text

        'tooltip initialise
        ToolTipListView.SetToolTip(ListView1, "Double click to mark absent")

        'init database
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb"
        conNames = New OleDbConnection(connectString)
        conNames.Open()
        adpNamesUser = New OleDbDataAdapter()
        adpNamesUser.SelectCommand = New OleDbCommand()
        With adpNamesUser.SelectCommand
            .Connection = conNames
            .CommandText = "select * FROM tbProfiles"
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With
        adpNamesUser.Fill(dataNames, "tbProfiles")



        'add item to listview table
        Dim table As DataTable = dataNames.Tables("tbProfiles")

        ListView1.View = View.Details
        For Each row In table.Rows

            If y7 > 0 And y7 = row.item(4) Then
                addListRow(row)
                totalPresent.Text += 1
            End If
        Next
        For Each row In table.Rows
            If y8 > 0 And y8 = row.item(4) Then
                addListRow(row)
                totalPresent.Text += 1
            End If
        Next
        For Each row In table.Rows
            If y9 > 0 And y9 = row.item(4) Then
                addListRow(row)
                totalPresent.Text += 1
            End If
        Next
        For Each row In table.Rows
            If y10 > 0 And y10 = row.item(4) Then
                addListRow(row)
                totalPresent.Text += 1
            End If
        Next
        For Each row In table.Rows
            If y11 > 0 And y11 = row.item(4) Then
                addListRow(row)
                totalPresent.Text += 1
            End If
        Next
        For Each row In table.Rows
            If y12 > 0 And y12 = row.item(4) Then
                addListRow(row)
                totalPresent.Text += 1
            End If
        Next

        'construct table
        Dim header1, header2, header3 As ColumnHeader
        header1 = New ColumnHeader
        header2 = New ColumnHeader
        header3 = New ColumnHeader
        header1.Text = "Last Name"
        header1.TextAlign = HorizontalAlignment.Left
        header1.Width = 116
        header2.Text = "First Name"
        header2.TextAlign = HorizontalAlignment.Left
        header2.Width = 116
        header3.Text = "Year"
        header3.TextAlign = HorizontalAlignment.Left
        header3.Width = 41
        ListView1.Columns.Add(header1)
        ListView1.Columns.Add(header2)
        ListView1.Columns.Add(header3)

        buttonStyle(btnCancel)
        buttonStyle(btnSave)

    End Sub
    Sub addListRow(row As Object)
        Dim tempstring As String = row.item("gName")
        Dim item1 As New ListViewItem(tempstring)
        item1.SubItems.Add(row.item("sName"))
        item1.SubItems.Add(row.item("Group"))
        item1.SubItems.Add(row.item("House"))
        item1.SubItems.Add(row.item("ID"))
        ListView1.Items.AddRange(New ListViewItem() {item1})
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        openForm(Me, New newRoll)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim saveConfirm As Integer = MessageBox.Show("Are you sure? Changes cannot be undone", "Confirm", MessageBoxButtons.YesNo)
        If saveConfirm = DialogResult.Yes Then
            'establishes connections with databases
            Dim connectAbsenceString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb"
            conAbsence = New OleDbConnection(connectAbsenceString)
            conAbsence.Open()
            adpAbsenceUser = New OleDbDataAdapter()
            adpAbsenceUser.SelectCommand = New OleDbCommand()
            With adpAbsenceUser.SelectCommand
                .Connection = conAbsence
                .CommandText = "select * FROM tblAbsence"
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            adpAbsenceUser.Fill(dataAbsence, "tblAbsence")

            Dim connectAttendanceString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb"
            conAttendance = New OleDbConnection(connectAttendanceString)
            conAttendance.Open()
            adpUser = New OleDbDataAdapter()
            adpUser.SelectCommand = New OleDbCommand()
            With adpUser.SelectCommand
                .Connection = conAttendance
                .CommandText = "select * FROM tblAttendance"
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            adpUser.Fill(dataAttendance, "tblAttendance")

            'inserts details into attendance database
            Try
                Dim command As String
                command = "INSERT INTO tblAttendance(Sessions, Dates, coachOfSession, totalAbsences, totalPresent, YearsPresent, Notes) VALUES (@sessions, @dates, @coachOfSession, @totalabsences, @totalPresent, @YearsPresent, @Notes)"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(command, conAttendance)
                cmd.Parameters.AddWithValue("Sessions", sessionType.Text)
                cmd.Parameters.AddWithValue("Dates", sessionDate.Text)
                cmd.Parameters.AddWithValue("coachOfSession", coachOfSession.Text)
                cmd.Parameters.AddWithValue("totalAbsences", totalAbsent.Text)
                cmd.Parameters.AddWithValue("totalPresent", totalPresent.Text)
                cmd.Parameters.AddWithValue("YearsPresent", lblYearGroups.Text)
                cmd.Parameters.AddWithValue("Notes", coachNotes.Text)
                cmd.ExecuteNonQuery()
            Catch exceptionobject As Exception
                MessageBox.Show(exceptionobject.Message)
            End Try
            'records all absentees who have been ticked
            For i = 0 To (ListView1.Items.Count - 1)
                If ListView1.Items(i).Checked = True Then
                    Try
                        Dim commandAbsence As String
                        commandAbsence = "INSERT INTO tblAbsence(Given, Family, Sessions, Dates, SchoolYr,SchoolHouse, SchoolIDNum) VALUES (@first, @last, @sessions, @dates, @group, @house, @IDnum)"
                        Dim cmdAbsence As OleDbCommand
                        cmdAbsence = New OleDbCommand(commandAbsence, conAbsence)
                        cmdAbsence.Parameters.AddWithValue("Given", ListView1.Items(i).SubItems(0).Text)
                        cmdAbsence.Parameters.AddWithValue("Family", ListView1.Items(i).SubItems(1).Text)
                        cmdAbsence.Parameters.AddWithValue("Sessions", sessionType.Text)
                        cmdAbsence.Parameters.AddWithValue("Dates", sessionDate.Text)
                        cmdAbsence.Parameters.AddWithValue("School", ListView1.Items(i).SubItems(2).Text)
                        cmdAbsence.Parameters.AddWithValue("SchoolHouse", ListView1.Items(i).SubItems(3).Text)
                        cmdAbsence.Parameters.AddWithValue("SchoolIDNum", ListView1.Items(i).SubItems(4).Text)
                        cmdAbsence.ExecuteNonQuery()
                    Catch exceptionobject As Exception
                        MessageBox.Show(exceptionobject.Message)
                    End Try
                End If
            Next
            conAttendance.Close()
            conAbsence.Close()

            openForm(Me, New MainAttendance)
        End If
    End Sub

    Private Sub ListView1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListView1.ItemChecked
        'when someone is checked, absent += 1
        totalAbsent.Text = 0
        totalPresent.Text = 0
        For i = 0 To (ListView1.Items.Count - 1)
            If ListView1.Items(i).Checked = False Then
                totalPresent.Text += 1
            End If
        Next
        For i = 0 To (ListView1.Items.Count - 1)
            If ListView1.Items(i).Checked = True Then
                totalAbsent.Text += 1
            End If
        Next
    End Sub

    Private Sub ToolTipListView_Popup(sender As Object, e As PopupEventArgs) Handles ToolTipListView.Popup

    End Sub
End Class