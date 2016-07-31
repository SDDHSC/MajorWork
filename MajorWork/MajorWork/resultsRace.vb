Imports System.Data.OleDb
'NOTE TO SELF:
'Edit squad format in database


Public Class resultsRace
    Dim adp As New OleDbDataAdapter
    Dim conDatabase As OleDbConnection
    Dim dataResults As New DataSet()

    Dim eventsList As List(Of String()) = New List(Of String())

    Dim eventNameBool As Boolean = False
    Dim eventDateBool As Boolean = False

    Private Sub resultsRace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; " +
                                      "Data Source=" + "C:\Users\Joshua King\Documents\School\Software\results\results\WindowsApplication2\resultsDatabase.accdb"
        conDatabase = New OleDbConnection(connectstring)
        conDatabase.Open()
        adp = New OleDbDataAdapter()
        adp.SelectCommand = New OleDbCommand()
        With adp.SelectCommand
            .Connection = conDatabase
            .CommandText = "select * from Races"
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With
        Dim reader As OleDbDataReader = adp.SelectCommand.ExecuteReader()
        While reader.Read()
            Dim row(10) As String
            For i = 0 To 9
                row(i) = reader(i)
            Next
            eventsList.Add(row)
        End While
        reader.Close()

        eventsRefresh()
    End Sub

    Public Sub eventsRefresh()
        resultsList.Items.Clear()
        For i = 0 To (eventsList.Count() - 1)
            If (eventNameBool = True And InStr(eventsList(i)(1).ToLower(), eventNameSearch.Text.ToLower()) Or eventNameSearch.Text = "Name") Or Not eventNameBool Then
                If (eventDateBool = True And eventsList(i)(2) = eventDateSearch.Value.ToString("dd/MM/yyyy")) Or Not eventDateBool Then
                    Dim row(2) As String
                    row(0) = eventsList(i)(1)
                    row(1) = eventsList(i)(2)
                    row(2) = eventsList(i)(0)
                    Dim itm = New ListViewItem(row)
                    resultsList.Items.Add(itm)
                End If
            End If
        Next
    End Sub

    Public Sub racesRefresh(index)
        infoList.Items.Clear()
        For i = 0 To CInt(eventsList(index - 1)(3))
            Dim row(6) As String
            Dim itm = New ListViewItem(row)
            infoList.Items.Add(itm)
        Next
        For i = 4 To 9
            Dim temp = Split(eventsList(index - 1)(i).Trim({"["c, "]"c}), "|")
            For j = 0 To (CInt(eventsList(index - 1)(3)) - 1)
                infoList.Items(j).SubItems.Item(i - 4).Text = temp(j)
            Next
        Next

    End Sub

    Private Sub resultsList_SelectedIndexChanged(sender As ListView, e As EventArgs) Handles resultsList.ItemActivate
        Dim index = sender.FocusedItem.Index
        index = resultsList.Items(index).SubItems(2).Text
        racesRefresh(index)

    End Sub

    Private Sub TextBox2_TextChanged(sender As TextBox, e As EventArgs) Handles eventNameSearch.GotFocus
        If sender.Text = "Name" Then
            sender.Text = ""
            sender.ForeColor = Color.Black
            sender.Font = Font
            eventsRefresh()
        End If
    End Sub

    Private Sub searchLostFocus(sender As TextBox, e As EventArgs) Handles eventNameSearch.LostFocus
        If sender.Text = "" Then
            sender.Text = "Name"
            sender.ForeColor = Color.Gray
            sender.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        End If
    End Sub

    Private Sub eventNameSearch_TextChanged_1(sender As Object, e As EventArgs) Handles eventNameSearch.TextChanged
        If eventNameBool Then
            eventsRefresh()
        End If
    End Sub

    Private Sub eventNameSearchCheck_CheckedChanged_1(sender As Object, e As EventArgs) Handles eventNameSearchCheck.CheckedChanged
        eventNameBool = Not eventNameBool
        eventsRefresh()
    End Sub

    Private Sub eventDateSearchCheck_CheckedChanged_1(sender As Object, e As EventArgs) Handles eventDateSearchCheck.CheckedChanged
        eventDateBool = Not eventDateBool
        eventsRefresh()
    End Sub

    Private Sub eventDateSearch_ValueChanged_1(sender As Object, e As EventArgs) Handles eventDateSearch.ValueChanged
        If eventDateBool Then
            eventsRefresh()
        End If
    End Sub

    Private Sub raceNewEntry_Click_1(sender As Object, e As EventArgs) Handles raceNewEntry.Click
        newRace.Show()
        Me.Hide()
    End Sub
End Class