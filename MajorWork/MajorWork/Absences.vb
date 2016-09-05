Imports System.Data.OleDb
Public Class Absences
    Dim adpAbsenceUser As New OleDbDataAdapter
    Dim conAbsence As OleDbConnection
    Dim dataAbsence As New DataSet()

    Dim listViewEmpty As Boolean = True
    Dim initialising = True
    Dim listViewEmptyCheck = False

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Attendance.Show()
        Attendance.mainPanelCheck.Text = "attendance show"
        Me.Hide()
    End Sub

    Private Sub Absences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialise database (establish connection, load data)
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb"
        conAbsence = New OleDbConnection(connectString)
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

        'construct table for data
        Dim header1, header2, header3, header4, header5 As ColumnHeader
        header1 = New ColumnHeader
        header2 = New ColumnHeader
        header3 = New ColumnHeader
        header4 = New ColumnHeader
        header5 = New ColumnHeader
        header1.Text = "First Name"
        header1.TextAlign = HorizontalAlignment.Left
        header1.Width = 160
        header2.Text = "Last Name"
        header2.TextAlign = HorizontalAlignment.Left
        header2.Width = 160
        header3.Text = "Session"
        header3.TextAlign = HorizontalAlignment.Left
        header3.Width = 80
        header4.Text = "Date"
        header4.TextAlign = HorizontalAlignment.Left
        header4.Width = 90
        header5.Text = "Year"
        header5.TextAlign = HorizontalAlignment.Left
        header5.Width = 45
        ListAbsence.Columns.Add(header1)
        ListAbsence.Columns.Add(header2)
        ListAbsence.Columns.Add(header3)
        ListAbsence.Columns.Add(header4)
        ListAbsence.Columns.Add(header5)


        'ADDS ITEMS TO COMBO BOXES
        'session types
        absenceSession.Text = "All Sessions"

        'fills table with all absences
        absenceYear.Text = "All Yrs"
        initialising = False
        absenceDateTimePicker.Enabled = False
        Reset()


    End Sub

    Private Sub btncreateNewRoll_Click(sender As Object, e As EventArgs) Handles btncreateNewRoll.Click
        newRoll.Show()
        Me.Hide()
    End Sub

    Private Sub absenceDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles absenceDateTimePicker.ValueChanged
        'filters all cases for combo box selections
        Dim table As DataTable = dataAbsence.Tables("tblAbsence")
        ListAbsence.Items.Clear()
        ListAbsence.View = View.Details
        For Each row In table.Rows
            If absenceSession.SelectedItem.ToString = "All Sessions" Then
                If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then
                    If absenceYear.SelectedItem.ToString = "All Yrs" Then
                        AddlistAbsence(row)
                    Else
                        If absenceYear.SelectedItem.ToString = row.item(5) Then
                            AddlistAbsence(row)
                        End If
                    End If
                End If
            Else
                If absenceSession.SelectedItem.ToString = row.item(3) Then
                    If absenceYear.SelectedItem.ToString = "All Yrs" Then
                        If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then
                            AddlistAbsence(row)
                        End If
                    Else
                        If absenceYear.SelectedItem.ToString = row.item(5) Then
                            If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then
                                AddlistAbsence(row)
                            End If
                        End If
                    End If
                End If
            End If
        Next


    End Sub

    Private Sub absenceSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles absenceSession.SelectedIndexChanged, absenceSession.SelectedIndexChanged
        'filters all cases for combo box selections
        Dim table As DataTable = dataAbsence.Tables("tblAbsence")
        ListAbsence.Items.Clear()
        ListAbsence.View = View.Details
        For Each row In table.Rows
            If absenceDateTimePicker.Enabled = True Then
                If absenceSession.SelectedItem.ToString = "All Sessions" Then
                    If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then
                        If initialising Then

                        ElseIf (absenceYear.SelectedItem IsNot Nothing And absenceYear.SelectedItem.ToString = "All Yrs") Then

                            AddlistAbsence(row)
                        Else
                            If absenceYear.SelectedItem.ToString = row.item(5) Then
                                AddlistAbsence(row)
                            End If
                        End If
                    End If
                Else
                    If absenceSession.SelectedItem.ToString = row.item(3) Then
                        If absenceYear.SelectedItem.ToString = "All Yrs" Then
                            If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then
                                AddlistAbsence(row)
                            End If
                        Else
                            If absenceYear.SelectedItem.ToString = row.item(5) Then
                                If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then
                                    AddlistAbsence(row)
                                End If
                            End If
                        End If
                    End If
                End If
            Else 'date time picker not enabled
                If absenceSession.SelectedItem.ToString = "All Sessions" Then
                    If initialising Then

                    ElseIf (absenceYear.SelectedItem IsNot Nothing And absenceYear.SelectedItem.ToString = "All Yrs") Then

                        AddlistAbsence(row)
                    Else
                        If absenceYear.SelectedItem.ToString = row.item(5) Then
                            AddlistAbsence(row)
                        End If
                    End If
                Else
                    If absenceSession.SelectedItem.ToString = row.item(3) Then
                        If absenceYear.SelectedItem.ToString = "All Yrs" Then
                            AddlistAbsence(row)
                        Else
                            If absenceYear.SelectedItem.ToString = row.item(5) Then
                                AddlistAbsence(row)
                            End If
                        End If
                    End If
                End If
            End If

        Next

    End Sub

    Private Sub absenceYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles absenceYear.SelectedIndexChanged
        'filters all cases for combo box selections

        Dim table As DataTable = dataAbsence.Tables("tblabsence")
        ListAbsence.Items.Clear()
        ListAbsence.View = View.Details

        For Each row In table.Rows
            If absenceDateTimePicker.Enabled = True Then
                If absenceYear.SelectedItem.ToString = "All Yrs" Then
                    If row.item(5) > 6 And row.item(5) < 13 Then
                        If initialising Then
                            If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then

                                AddlistAbsence(row)
                            End If
                        ElseIf (absenceSession.SelectedItem IsNot Nothing And absenceSession.SelectedItem.ToString = "All Sessions") Then

                            If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then

                                AddlistAbsence(row)
                            End If
                        Else
                            If absenceSession.SelectedItem.ToString = row.item(3) Then
                                If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then
                                    AddlistAbsence(row)
                                End If
                            End If
                        End If
                    End If
                Else
                    If absenceYear.SelectedItem.ToString = row.item(5) Then
                        If absenceSession.SelectedItem.ToString = "All Sessions" Then
                            If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then
                                AddlistAbsence(row)
                            End If
                        Else
                            If absenceSession.SelectedItem.ToString = row.item(3) Then
                                If absenceDateTimePicker.Enabled = True And absenceDateTimePicker.Value.Date = row.item(4) Then
                                    AddlistAbsence(row)
                                End If
                            End If
                        End If
                    End If
                End If
            Else 'date time picker not enabled
                If absenceYear.SelectedItem.ToString = "All Yrs" Then
                    If row.item(5) > 6 And row.item(5) < 13 Then
                        If initialising Then
                            AddlistAbsence(row)

                        ElseIf (absenceSession.SelectedItem IsNot Nothing And absenceSession.SelectedItem.ToString = "All Sessions") Then

                            AddlistAbsence(row)

                        Else
                            If absenceSession.SelectedItem.ToString = row.item(3) Then
                                AddlistAbsence(row)

                            End If
                        End If
                    End If
                Else
                    If absenceYear.SelectedItem.ToString = row.item(5) Then
                        If absenceSession.SelectedItem.ToString = "All Sessions" Then
                            AddlistAbsence(row)

                        Else
                            If absenceSession.SelectedItem.ToString = row.item(3) Then
                                AddlistAbsence(row)
                            End If
                        End If
                    End If
                End If
            End If

        Next


    End Sub

    Private Sub absenceName_TextChanged(sender As Object, e As EventArgs) Handles absenceName.TextChanged, absenceName.TextChanged
        'search function for first name, last name and ID num
        ListAbsence.Items.Clear()
        ListAbsence.View = View.Details
        Dim table As DataTable = dataAbsence.Tables("tblabsence")

        For Each row In table.Rows
            If absenceDateTimePicker.Enabled = True Then
                If absenceDateTimePicker.Enabled = True And absenceSession.SelectedItem.ToString = "All Sessions" Then
                    If absenceYear.SelectedItem.ToString = row.item(5) Then
                        If absenceDateTimePicker.Value.Date = row.item(4) Then
                            SearchBar(row)
                        End If
                    Else
                        If absenceYear.SelectedItem.ToString = "All Yrs" Then
                            If absenceDateTimePicker.Value.Date = row.item(4) Then
                                SearchBar(row)
                            End If
                        End If
                    End If
                Else
                    If absenceDateTimePicker.Enabled = True And absenceSession.SelectedItem.ToString = row.item(3) Then
                        If absenceYear.SelectedItem.ToString = "All Yrs" Then
                            If absenceDateTimePicker.Value.Date = row.item(4) Then
                                SearchBar(row)
                            End If
                        Else
                            If absenceYear.SelectedItem.ToString = row.item(5) Then
                                If absenceDateTimePicker.Value.Date = row.item(4) Then
                                    SearchBar(row)
                                End If
                            End If
                        End If
                    End If
                End If
            Else 'date time picker not selected
                If absenceSession.SelectedItem.ToString = "All Sessions" Then
                    If absenceYear.SelectedItem.ToString = row.item(5) Then
                        SearchBar(row)
                    Else
                        If absenceYear.SelectedItem.ToString = "All Yrs" Then
                            SearchBar(row)
                        End If
                    End If
                Else
                    If absenceSession.SelectedItem.ToString = row.item(3) Then
                        If absenceYear.SelectedItem.ToString = "All Yrs" Then
                            SearchBar(row)
                        Else
                            If absenceYear.SelectedItem.ToString = row.item(5) Then
                                SearchBar(row)
                            End If
                        End If
                    End If
                End If
            End If

        Next



    End Sub
    Sub AddlistAbsence(row As Object)
        'function for adding data from database to table
        Dim tempstring As String = row.item("Given")
        Dim item1 As New ListViewItem(tempstring)
        item1.SubItems.Add(row.item("Family"))
        item1.SubItems.Add(row.item("Sessions"))
        item1.SubItems.Add(row.item("Dates"))
        item1.SubItems.Add(row.item("SchoolYr") + row.item("SchoolHouse"))
        ListAbsence.Items.AddRange(New ListViewItem() {item1})
    End Sub
    Sub Reset()
        'clears all values in filters, setting everything to default
        absenceSession.SelectedIndex = 0
        absenceYear.SelectedIndex = 0
        absenceName.Clear()
        ListAbsence.Items.Clear()
        absenceDateTimePicker.Enabled = False
        dateCheck.Checked = False
        ListAbsence.View = View.Details
        absenceName.Text = ""
        Dim table As DataTable = dataAbsence.Tables("tblabsence")


        For Each row In table.Rows
            AddlistAbsence(row)
        Next
    End Sub
    Sub SearchBar(row As Object)
        'search function for either first name, last name or ID num
        Dim fName As Boolean = False
        Dim lName As Boolean = False
        Dim IDNum As Boolean = False


        If InStr(1, row.Item(1), absenceName.Text) = 1 Or InStr(1, LCase(row.Item(1)), absenceName.Text) = 1 Then 'needs to be part of the string
            fName = True
        Else
            fName = False
        End If
        If InStr(1, row.Item(2), absenceName.Text) = 1 Or InStr(1, LCase(row.Item(2)), absenceName.Text) = 1 Then 'needs to be part of the string
            lName = True
        Else
            lName = False
        End If

        If InStr(1, row.Item(7), absenceName.Text) = 1 Then 'needs to be part of the string
            IDNum = True
        Else
            IDNum = False
        End If

        'if data contains information from search bar, it is added to the list
        If fName = True Or lName = True Or IDNum = True Then
            AddlistAbsence(row)
        End If
    End Sub

    Private Sub displayAll_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset button click, set everything to default
        Reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        absenceSession.SelectedIndex = 0
        absenceYear.SelectedIndex = 0
        ListAbsence.Items.Clear()
        ListAbsence.View = View.Details
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles emptyCheck.Tick
        'constantly checks if there's no results
        If initialising = False Then
            If ListAbsence.Items.Count = 0 Then
                Reset()
                MessageBox.Show("No absences to show", "Names", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dateCheck_CheckedChanged(sender As Object, e As EventArgs) Handles dateCheck.CheckedChanged
        'enables date when clicked
        If dateCheck.Checked = True Then
            absenceDateTimePicker.Enabled = True
            MessageBox.Show("Select a date")
        Else
            absenceDateTimePicker.Enabled = False
            'absenceName.Enabled = True
        End If
    End Sub
    Private Sub FilterInfo_MouseHover(sender As Object, e As EventArgs) Handles FilterInfo.MouseHover
        'on screen help for user
        lblInfo2.Show()
        lblInfo3.Show()
    End Sub

    Private Sub FilterInfo_MouseLeave(sender As Object, e As EventArgs) Handles FilterInfo.MouseLeave
        'on screen help for user
        lblInfo2.Hide()
        lblInfo3.Hide()
    End Sub
End Class