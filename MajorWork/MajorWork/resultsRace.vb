Imports System.Data.OleDb

Public Class resultsRace
    'Database connecting variables
    Dim adp As New OleDbDataAdapter
    Dim conDatabase As OleDbConnection
    Dim dataResults As New DataSet()

    Dim eventsList As List(Of String()) = New List(Of String())     'List of events and their races
    Dim selectedIndex As Integer                                    'Identifies which event is currently selected                       '

    Dim eventNameBool As Boolean = False                            'Whether the name filter is activated
    Dim eventDateBool As Boolean = False                            'Whether the date filter is activated

    Private Sub resultsRace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = schoolBlue                                                  'Sets backColour to the default school blue

        'Connecting to the database and retrieving information
        Dim connectstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=|DataDirectory|\rowingDatabase (1).accdb"      'Sets location of database
        conDatabase = New OleDbConnection(connectstring)
        conDatabase.Open()
        adp = New OleDbDataAdapter()
        adp.SelectCommand = New OleDbCommand()
        With adp.SelectCommand
            .Connection = conDatabase
            .CommandText = "select * from Races"                                'Selects from table
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With
        Dim reader As OleDbDataReader = adp.SelectCommand.ExecuteReader()
        While reader.Read()
            Dim row(9) As String
            For i = 0 To 9
                row(i) = reader(i)                                              'Gets data from database
            Next
            eventsList.Add(row)                                                 'Transers data to local array 'eventsList'
        End While
        reader.Close()

        eventsRefresh()
    End Sub

    Public Sub eventsRefresh() 'Refreshing the control 'eventListView', the ListView that displays a list of events
        eventListView.Items.Clear()
        For i = 0 To (eventsList.Count() - 1)
            If (eventNameBool = True And InStr(eventsList(i)(1).ToLower(), eventNameSearch.Text.ToLower()) Or eventNameSearch.Text = "Name") Or Not eventNameBool Then
                If (eventDateBool = True And eventsList(i)(2) = eventDateSearch.Value.ToString("dd/MM/yyyy")) Or Not eventDateBool Then
                    Dim row(2) As String
                    row(0) = eventsList(i)(1)           'The name of the event
                    row(1) = eventsList(i)(2)           'The date of the event
                    row(2) = eventsList(i)(0)           'The ID of the event, i.e. its position in an unfiltered eventListView
                    Dim itm = New ListViewItem(row)
                    eventListView.Items.Add(itm)         'Display the event
                End If
            End If
        Next
    End Sub

    Private Sub eventListView_SelectedIndexChanged(sender As ListView, e As EventArgs) Handles eventListView.ItemSelectionChanged
        selectedIndex = sender.FocusedItem.Index                            'Sets the selectedIndex variable to reflect selected event
        racesRefresh(eventListView.Items(selectedIndex).SubItems(2).Text)
    End Sub

    Public Sub racesRefresh(ID) 'Refreshing the control 'raceListview', the ListView that displays the races of the selected event
        raceListView.Items.Clear()
        For i = 0 To CInt(eventsList(ID - 1)(3)) - 1                        'Add rows into raceListview, specified by the "Number of Races" column in the database
            Dim row(6) As String
            Dim itm = New ListViewItem(row)
            raceListView.Items.Add(itm)
        Next
        For i = 4 To 8                                                      'Splits each element of the selected event into its separate race infos and changes the existing row
            Dim temp = Split(eventsList(ID - 1)(i).Trim({"["c, "]"c}), "|") 'Database elements are formated like [Race1 Info|Race2 info|Race3 info]
            For j = 0 To (CInt(eventsList(ID - 1)(3)) - 1)
                raceListView.Items(j).SubItems.Item(i - 4).Text = temp(j)
            Next
        Next
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

    Private Sub eventNameSearch_TextChanged_1(sender As Object, e As EventArgs) Handles eventNameSearch.TextChanged, eventDateSearch.ValueChanged
        If eventNameBool Then
            eventsRefresh()
        End If
    End Sub

    Private Sub eventNameSearchCheck_CheckedChanged_1(sender As Object, e As EventArgs) Handles eventNameSearchCheck.CheckedChanged
        eventNameBool = Not eventNameBool
        eventsRefresh()
    End Sub

    Private Sub raceNewEntry_Click_1(sender As Object, e As EventArgs) Handles raceNewEntry.Click
        raceEditInfo = Nothing
        newRace.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles editRace.Click
        raceEditInfo = eventsList(selectedIndex)
        newRace.Show()
        Me.Hide()
    End Sub

    Private Sub raceListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles raceListView.SelectedIndexChanged
        rowerRefresh(eventListView.Items(selectedIndex).SubItems(2).Text, raceListView.FocusedItem.Index)
    End Sub

    Private Sub rowerRefresh(eventID, raceID)
        rowerListView.Items.Clear()
        Dim temp = Split(Split(eventsList(CInt(eventID) - 1)(9).Trim({"["c, "]"c}), "|")(raceID), ",")
        For i = 0 To temp.Length - 1
            Dim row(1) As String
            row(0) = temp(i)
            Dim itm As New ListViewItem(row)
            rowerListView.Items.Add(itm)
        Next
    End Sub
End Class