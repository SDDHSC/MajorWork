Imports System.Data.OleDb
Public Class MainAttendance
    Dim adpUser As New OleDbDataAdapter
    Dim conAttendance As OleDbConnection
    Dim dataAttendance As New DataSet()
    Dim listViewEmpty As Boolean = True
    Dim initialising = True
    Private Sub MainAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim Key(0) As DataColumn 'only ione column in the primary key
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb"

        conAttendance = New OleDbConnection(connectString)
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


        Dim header1, header2, header3, header4, header5 As ColumnHeader
        header1 = New ColumnHeader
        header2 = New ColumnHeader
        header3 = New ColumnHeader
        header4 = New ColumnHeader
        header5 = New ColumnHeader
        header1.Text = "Session"
        header1.TextAlign = HorizontalAlignment.Left
        header1.Width = 100
        header2.Text = "Date"
        header2.TextAlign = HorizontalAlignment.Left
        header2.Width = 110
        header3.Text = "Coach of Session"
        header3.TextAlign = HorizontalAlignment.Left
        header3.Width = 150
        header4.Text = "Absent"
        header4.TextAlign = HorizontalAlignment.Left
        header4.Width = 90
        header5.Text = "Present"
        header5.TextAlign = HorizontalAlignment.Left
        header5.Width = 90
        listAttendance.Columns.Add(header1)
        listAttendance.Columns.Add(header2)
        listAttendance.Columns.Add(header3)
        listAttendance.Columns.Add(header4)
        listAttendance.Columns.Add(header5)

        'add items to combo boxes
        'year groups
        coachOfSession.Items.Add("All coaches")
        coachOfSession.Items.Add("Coach #1")
        coachOfSession.Items.Add("Coach #2")
        coachOfSession.Items.Add("Coach #3")
        coachOfSession.SelectedIndex = 0


        'session types
        attendanceSession.Items.Add("All Sessions")
        attendanceSession.Items.Add("Erg")
        attendanceSession.Items.Add("Running")
        attendanceSession.Items.Add("Rowing")
        attendanceSession.Items.Add("Weights")
        attendanceSession.Items.Add("Other")
        attendanceSession.SelectedIndex = 0
        initialising = False

        attendanceSession.SelectedIndex = 0
        coachOfSession.SelectedIndex = 0
        listAttendance.Items.Clear()
        listAttendance.View = View.Details
        Dim table As DataTable = dataAttendance.Tables("tblattendance")

        For Each row In table.Rows
            AddlistAttendance(row)
        Next

        attendanceDateTimePicker.Enabled = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Absences.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        newRoll.Show()
        Me.Close()
    End Sub

    Private Sub attendanceDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles attendanceDateTimePicker.ValueChanged
        Dim table As DataTable = dataAttendance.Tables("tblAttendance")
        listAttendance.Items.Clear()
        listAttendance.View = View.Details


        For Each row In table.Rows
            If attendanceSession.SelectedItem.ToString = "All Sessions" Then
                If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then
                    If coachOfSession.SelectedItem.ToString = "All coaches" Then
                        AddlistAttendance(row)
                    Else
                        If coachOfSession.SelectedItem.ToString = row.item(3) Then
                            AddlistAttendance(row)
                        End If
                    End If
                End If
            Else
                If attendanceSession.SelectedItem.ToString = row.item(3) Then
                    If coachOfSession.SelectedItem.ToString = "All coaches" Then
                        If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then
                            AddlistAttendance(row)
                        End If
                    Else
                        If coachOfSession.SelectedItem.ToString = row.item(3) Then
                            If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then
                                AddlistAttendance(row)
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub coachofsession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coachOfSession.SelectedIndexChanged
        Dim table As DataTable = dataAttendance.Tables("tblAttendance")
        listAttendance.Items.Clear()
        listAttendance.View = View.Details


        For Each row In table.Rows
            If attendanceDateTimePicker.Enabled = True Then
                If coachOfSession.SelectedItem.ToString = "All coaches" Then
                    If initialising Then
                        If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then

                            AddlistAttendance(row)
                        End If
                    ElseIf (attendanceSession.SelectedItem IsNot Nothing) Then

                        If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then

                            AddlistAttendance(row)
                        End If

                    ElseIf (attendanceSession.SelectedItem IsNot Nothing) Then

                        If attendanceSession.SelectedItem.ToString = row.item(1) Then
                            If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then
                                AddlistAttendance(row)
                            End If
                        End If


                    End If

                Else
                    If coachOfSession.SelectedItem.ToString = row.item(3) Then
                        If attendanceSession.SelectedItem.ToString = "All Sessions" Then
                            If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then
                                AddlistAttendance(row)
                            End If
                        Else
                            If attendanceSession.SelectedItem.ToString = row.item(1) Then
                                If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then
                                    AddlistAttendance(row)
                                End If
                            End If
                        End If
                    End If
                End If
            Else 'if date not enabled
                If coachOfSession.SelectedItem.ToString = "All coaches" Then
                    If initialising Then
                        AddlistAttendance(row)
                    ElseIf (attendanceSession.SelectedItem IsNot Nothing) Then
                        AddlistAttendance(row)

                    ElseIf (attendanceSession.SelectedItem IsNot Nothing) Then

                        If attendanceSession.SelectedItem.ToString = row.item(1) Then
                            AddlistAttendance(row)
                        End If


                    End If

                Else
                    If coachOfSession.SelectedItem.ToString = row.item(3) Then
                        If attendanceSession.SelectedItem.ToString = "All Sessions" Then
                            AddlistAttendance(row)
                        Else
                            If attendanceSession.SelectedItem.ToString = row.item(1) Then
                                If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then
                                    AddlistAttendance(row)
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Next
    End Sub

    Private Sub attendanceSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles attendanceSession.SelectedIndexChanged
        Dim table As DataTable = dataAttendance.Tables("tblAttendance")
        listAttendance.Items.Clear()
        listAttendance.View = View.Details


        For Each row In table.Rows
            If attendanceDateTimePicker.Enabled = True Then
                If attendanceSession.SelectedItem.ToString = "All Sessions" Then
                    If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then
                        If (coachOfSession.SelectedItem IsNot Nothing) Then

                            If coachOfSession.SelectedItem.ToString = row.item(3) Then
                                AddlistAttendance(row)
                            Else

                                If coachOfSession.SelectedItem.ToString = "All coaches" Then
                                    AddlistAttendance(row)
                                End If
                            End If
                        End If
                    End If
                Else
                    If attendanceSession.SelectedItem.ToString = row.item(1) Then
                        If coachOfSession.SelectedItem.ToString = "All coaches" Then
                            If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then
                                AddlistAttendance(row)
                            End If
                        Else
                            If coachOfSession.SelectedItem.ToString = row.item(3) Then
                                If attendanceDateTimePicker.Enabled = True And attendanceDateTimePicker.Value.Date = row.item(2) Then
                                    AddlistAttendance(row)
                                End If
                            End If
                        End If
                    End If
                End If
            Else 'if date time picker not enabled
                If attendanceSession.SelectedItem.ToString = "All Sessions" Then
                    If (coachOfSession.SelectedItem IsNot Nothing) Then

                        If coachOfSession.SelectedItem.ToString = row.item(3) Then
                            AddlistAttendance(row)
                        Else

                            If coachOfSession.SelectedItem.ToString = "All coaches" Then
                                AddlistAttendance(row)
                            End If
                        End If
                    End If

                Else
                    If attendanceSession.SelectedItem.ToString = row.item(1) Then
                        If coachOfSession.SelectedItem.ToString = "All coaches" Then
                            AddlistAttendance(row)

                        Else
                            If coachOfSession.SelectedItem.ToString = row.item(3) Then
                                AddlistAttendance(row)
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Sub AddlistAttendance(row As Object)
        'Adds items to datagrid
        Dim tempstring As String = row.item("Sessions")
        Dim item1 As New ListViewItem(tempstring)
        item1.SubItems.Add(row.item("Dates"))
        item1.SubItems.Add(row.item("coachOfSession"))
        item1.SubItems.Add(row.item("totalAbsences"))
        item1.SubItems.Add(row.item("totalPresent"))

        listAttendance.Items.AddRange(New ListViewItem() {item1})
        'End If
    End Sub
    Private Sub displayAll_Click(sender As Object, e As EventArgs) Handles displayAll.Click
        attendanceSession.SelectedIndex = 0
        coachOfSession.SelectedIndex = 0
        listAttendance.Items.Clear()
        listAttendance.View = View.Details
        attendanceDateTimePicker.Enabled = False
        dateCheck.Checked = False
        Dim table As DataTable = dataAttendance.Tables("tblattendance")

        For Each row In table.Rows
            AddlistAttendance(row)
        Next
    End Sub

    Private Sub emptyCheck_Tick(sender As Object, e As EventArgs)
        If listAttendance.Items.Count = 0 Then
            attendanceSession.SelectedIndex = 0
            coachOfSession.SelectedIndex = 0
            listAttendance.Items.Clear()
            listAttendance.View = View.Details
            attendanceDateTimePicker.Enabled = False
            Dim table As DataTable = dataAttendance.Tables("tblattendance")

            For Each row In table.Rows
                AddlistAttendance(row)
            Next
            MessageBox.Show("No attendances to show", "Names", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dateCheck_CheckedChanged(sender As Object, e As EventArgs) Handles dateCheck.CheckedChanged
        If dateCheck.Checked = True Then
            attendanceDateTimePicker.Enabled = True
        Else
            attendanceDateTimePicker.Enabled = False
        End If
    End Sub
End Class