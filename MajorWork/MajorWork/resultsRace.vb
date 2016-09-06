Imports System.Data.OleDb

Public Class resultsRace
    'Database connecting variables
    Dim adp As New OleDbDataAdapter
    Dim conDatabase As OleDbConnection
    Dim dataResults As New DataSet()

    Dim eventsList As List(Of String()) = New List(Of String())     'List of events and their races
    Dim selectedIndex As Integer                                    'Identifies which event is currently selected

    Private Sub resultsRace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eventIDnum = 0
        BackColor = schoolBlue                                                  'Sets backColour to the default school blue
        styleForm(Me)

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
            If eventIDnum < CInt(reader(0)) Then
                eventIDnum = CInt(reader(0))
            End If
            Dim row(9) As String
            For i = 0 To 9
                row(i) = reader(i)                                              'Gets data from database
            Next
            eventsList.Add(row)                                                 'Transers data to local array 'eventsList'
        End While
        reader.Close()

        eventsRefresh()
    End Sub

    'Preventing listViews headers from being resized
    Private Sub ListView1_ColumnWidthChanging(ByVal Sender As Object, ByVal e As ColumnWidthChangingEventArgs) Handles eventListView.ColumnWidthChanging, raceListView.ColumnWidthChanging, rowerListView.ColumnWidthChanging
        For DCol = 0 To 4 'Max no. of columns
            If e.ColumnIndex = DCol Then
                e.Cancel = True
                e.NewWidth = Sender.Columns(DCol).Width
            End If
        Next DCol
    End Sub

    'Search filters
    Private Sub eventSearch_GotFocus(sender As TextBox, e As EventArgs) Handles eventNameSearch.GotFocus
        If sender.Text = "Name" Then
            sender.Text = ""
            sender.ForeColor = Color.Black
            sender.Font = New Font("Segoe UI", 8, FontStyle.Regular)
            eventsRefresh()
        End If
    End Sub   'When the name filter gains focus, the grey "Name" disappears
    Private Sub searchLostFocus(sender As TextBox, e As EventArgs) Handles eventNameSearch.LostFocus
        If sender.Text = "" Then
            sender.Text = "Name"
            sender.ForeColor = Color.Gray
            sender.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        End If
    End Sub       'When the name filter loses focus, the grey "Name" appears if the textbox is blank
    Private Sub filterChange(sender As Object, e As EventArgs) Handles eventNameSearchCheck.CheckedChanged, eventDateSearchCheck.CheckedChanged, eventNameSearch.TextChanged, eventDateSearch.ValueChanged
        eventsRefresh()
    End Sub 'When either filter is activated or changed, refresh the eventsListView

    'ListView selection changes
    Private Sub eventListView_SelectedIndexChanged(sender As ListView, e As EventArgs) Handles eventListView.SelectedIndexChanged
        selectedIndex = sender.FocusedItem.Index
        racesRefresh(eventListView.Items(selectedIndex).SubItems(2).Text)
    End Sub 'Sets the selectedIndex variable to reflect selected event and refreshs the raceListView
    Private Sub raceListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles raceListView.SelectedIndexChanged
        rowerRefresh(eventListView.Items(selectedIndex).SubItems(2).Text, raceListView.FocusedItem.Index)
    End Sub     'Refreshs the rowerListView if the race selection changes
    Public Sub eventsRefresh()
        eventListView.Items.Clear()
        For i = 0 To (eventsList.Count() - 1)
            If (eventNameSearchCheck.Checked = True And InStr(eventsList(i)(1).ToLower(), eventNameSearch.Text.ToLower()) Or eventNameSearch.Text = "Name") Or Not eventNameSearchCheck.Checked Then
                If (eventDateSearchCheck.Checked = True And eventsList(i)(2) = eventDateSearch.Value.ToString("dd/MM/yyyy")) Or Not eventDateSearchCheck.Checked Then
                    Dim row(2) As String
                    row(0) = eventsList(i)(1)           'The name of the event
                    row(1) = eventsList(i)(2)           'The date of the event
                    row(2) = eventsList(i)(0)           'The ID of the event, i.e. its position in an unfiltered eventListView
                    Dim itm = New ListViewItem(row)
                    eventListView.Items.Add(itm)         'Display the event
                End If
            End If
        Next
    End Sub                 'Displays the event details
    Public Sub racesRefresh(ID)
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
    End Sub                'Displays the races of the selected event
    Private Sub rowerRefresh(eventID, raceID)
        rowerListView.Items.Clear()
        Dim temp = Split(Split(eventsList(CInt(eventID) - 1)(9).Trim({"["c, "]"c}), "|")(raceID), ",")
        For i = 0 To temp.Length - 1
            Dim row(1) As String
            row(0) = temp(i)
            Dim itm As New ListViewItem(row)
            rowerListView.Items.Add(itm)
        Next
    End Sub  'Displays the rowers of the selected race

    'Buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles editRace.Click
        raceEditInfo = eventsList(selectedIndex)
        openForm(Me, New newRace)
    End Sub
    Private Sub raceNewEntry_Click_1(sender As Object, e As EventArgs) Handles raceNewEntry.Click
        raceEditInfo = Nothing
        openForm(Me, New newRace)
    End Sub
    Private Sub anaylisis_click(sender As Object, e As EventArgs) Handles analysisButton.Click
        analysisPrint.Print()
    End Sub

    Private Sub analysisPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles analysisPrint.PrintPage
        Dim printFont As Font
        Dim printString As String
        With e.Graphics
            printFont = New Font("Arial", 14, FontStyle.Bold)
            .DrawString("Rowing Events Analysis:", printFont, Brushes.Black, 40, 100)




            e.HasMorePages = False
        End With
    End Sub
End Class