Imports System.Data.OleDb
Public Class mainAttendanceExtra
    Dim adpUser As New OleDbDataAdapter
    Dim conAttendance As OleDbConnection
    Dim dataAttendance As New DataSet()
    Dim listViewEmpty As Boolean = True
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Dim adpNamesUser As New OleDbDataAdapter

    Dim conNames As OleDbConnection
    Dim dataNames As New DataSet()
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainAttendance.Show()
        Me.Hide()
    End Sub

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If

    End Sub

    Private Sub mainAttendanceExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Items.Clear()
        Dim header1, header2, header3 As ColumnHeader
        header1 = New ColumnHeader
        header2 = New ColumnHeader
        header3 = New ColumnHeader
        header1.Text = "First Name"
        header1.TextAlign = HorizontalAlignment.Left
        header1.Width = 116
        header2.Text = "Last Name"
        header2.TextAlign = HorizontalAlignment.Left
        header2.Width = 116
        header3.Text = "Year"
        header3.TextAlign = HorizontalAlignment.Left
        header3.Width = 41
        ListView1.Columns.Add(header1)
        ListView1.Columns.Add(header2)
        ListView1.Columns.Add(header3)

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

        Dim tableAttendance As DataTable = dataAttendance.Tables("tblAttendance")
        For Each row In tableAttendance.Rows
            If row.item(1) = sessionType.Text And row.item(2) = sessionDate.Text And row.item(3) = coachOfSession.Text And
                row.item(4) = totalAbsent.Text And row.item(5) = totalPresent.Text Then
                lblYearGroups.Text = row.item(6)
                coachNotes.Text = row.item(7)
            End If
        Next

        Dim connectProfilesString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb"
        conNames = New OleDbConnection(connectProfilesString)
        conNames.Open()
        adpNamesUser = New OleDbDataAdapter()
        adpNamesUser.SelectCommand = New OleDbCommand()
        Console.WriteLine(conAttendance)
        With adpNamesUser.SelectCommand
            .Connection = conNames
            .CommandText = "select * FROM tbProfiles"
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With
        adpNamesUser.Fill(dataNames, "tbProfiles")


        Dim tableProfiles As DataTable = dataNames.Tables("tbProfiles")
        'Gets year groups that were present (from database)
        Dim yrGroupSearch As String = lblYearGroups.Text
        Dim yrGroupSearchList As New List(Of String)(yrGroupSearch.Split(","))
        'For Each elem As String In yrGroupSearchList
        '    MessageBox.Show(elem)
        'Next

        For Each elem As String In yrGroupSearchList
            For Each row In tableProfiles.Rows
                If elem.Contains(row.item(4)) Then
                    addListRow(row) 'get from markroll
                End If
            Next
        Next


        'highlight the people who were absent

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
End Class