'make Graphics Nice
Imports System.Data.OleDb
Public Class ProfilesView
    'Lists populated with database data
    Dim IDNum As New List(Of Int32)                             'List of IDs in integer form
    Public IDStr As New List(Of String)                            'List of IDs in string form
    Dim gName As New List(Of String)                            'List of Last Names in string form
    Dim sName As New List(Of String)                            'List of First Names in string form
    Dim yGroup As New List(Of String)                           'List of year groups in string form
    Dim rClass As New List(Of String)                           'List of roll classes in string form
    Public Sorted As New List(Of Integer)                          'Sorted list of indexes
    Dim SortList As New List(Of String)                         'Temporary list used to sort database list without changing indexes
    Dim SortArray() As Object = {gName, sName, rClass, IDStr}   'Array matching the sort combo box index to its respective list 
    Dim position As Integer = 0                                 'Position to start index search, used when there are multiple people with the same primary value
    Dim FirstPanel As Boolean = True                            'Boolean showing whether the panel being filled is the first panel
    Dim SearchList As New List(Of String)                       'Temporary list used to get sorted values prior to being filtered by the search module
    Dim FilterList As New List(Of Integer)                      'Temporary list used to get searched and sorted values prior to being filtered by the filter module
    Dim yearGroups() As Integer = {0, 1, 10, 9, 8}              'Array matching FilterBox selected index to its respective yGroup value
    Private Sub ProfilesView_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadDatabase()
        SortBox.SelectedIndex = 0       'Ensures SortBox is set to Last Name by default
        FilterBox.SelectedIndex = 0     'Ensures FilterBox is set to All Years by default
        SearchBox.Focus()               'Ensures the focus is on the search box when the form loads, so you can type straight away
    End Sub
    Public Sub ReadDatabase() 'Reads the database, and populates the data strings
        'Clears all the data strings
        IDNum.Clear()
        IDStr.Clear()
        gName.Clear()
        sName.Clear()
        yGroup.Clear()
        rClass.Clear()
        'Reads Database
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, sName, gName, rClass, Group FROM tbProfiles", conn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            'Add's the data from each field to the relevanet list, line by line
                            IDNum.Add(dr.GetInt32(0))
                            IDStr.Add(dr.GetInt32(0).ToString)
                            gName.Add(dr.GetString(2))
                            sName.Add(dr.GetString(1))
                            yGroup.Add(dr.GetString(4))
                            rClass.Add(dr.GetString(3))
                        Loop
                    End If
                End Using
            End Using
        End Using
    End Sub
    Public Sub FillPanels() 'Creates Panels and populate them with data
        SortRowers()
        FilterRowers()
        RowerBox.Controls.Clear() 'Ensures the flow layout panel is empty
        For Each rower As Integer In Sorted 'Every Index in Sorted (All indexes matching the search and filters)
            'Creates the panels
            Dim testPanel As New Panel With
                {
                    .Height = 50,
                    .Width = 140,
                    .BackColor = schoolBlue,
                    .Name = rower.ToString,
                    .Tag = "NotCLicked"
                }
            'Creates the ID Label
            Dim testID As New Label With
                {
                    .Text = IDStr(rower),
                    .Font = New Font("Segoe UI", 9.75, FontStyle.Bold),
                    .Location = New Point(0, 0),
                    .Name = "rID" + rower.ToString
                }
            'Creates the Name Label
            Dim testName As New Label With
                {
                    .Text = gName(rower).ToUpper + ", " + sName(rower),
                    .Font = New Font("Segoe UI", 8),
                    .Location = New Point(0, 20),
                    .Name = "rName" + rower.ToString
                }
            'If the name doesn't fit, splits name in two
            If testName.Text.Length > 14 Then
                testName.Text = gName(rower).ToUpper + ", "
                Dim testName2 As New Label With
                {
                    .Text = sName(rower),
                    .Font = New Font("Segoe UI", 8),
                    .Location = New Point(0, 33),
                    .Name = "rName2" + rower.ToString
                }
                testPanel.Controls.Add(testName2)
                AddHandler testName2.MouseClick, AddressOf RowerPanelTextClicked
                AddHandler testName2.MouseEnter, AddressOf RowerPanelTextEnter
                AddHandler testName2.MouseLeave, AddressOf RowerPanelTextExit
            End If
            Dim testRollClass As New Label With
                {
                    .Text = rClass(rower),
                    .Font = New Font("Segoe UI", 9.75, FontStyle.Bold),
                    .Location = New Point(110, 0),
                    .Name = "rRollClass" + rower.ToString
                }
            'Adds Mouse Click/Enter/Exit to every panel, and maps it all to the same sub
            AddHandler testPanel.MouseClick, AddressOf RowerPanelClicked
            AddHandler testID.MouseClick, AddressOf RowerPanelTextClicked
            AddHandler testName.MouseClick, AddressOf RowerPanelTextClicked
            AddHandler testRollClass.MouseClick, AddressOf RowerPanelTextClicked
            AddHandler testPanel.MouseEnter, AddressOf RowerPanelEnter
            AddHandler testPanel.MouseLeave, AddressOf RowerPanelExit
            AddHandler testName.MouseEnter, AddressOf RowerPanelTextEnter
            AddHandler testName.MouseLeave, AddressOf RowerPanelTextExit
            AddHandler testID.MouseEnter, AddressOf RowerPanelTextEnter
            AddHandler testID.MouseLeave, AddressOf RowerPanelTextExit
            AddHandler testRollClass.MouseEnter, AddressOf RowerPanelTextEnter
            AddHandler testRollClass.MouseLeave, AddressOf RowerPanelTextExit
            RowerBox.Controls.Add(testPanel) 'adds the panels to the box
            testPanel.Controls.Add(testID) 'adds the text to the panels
            testPanel.Controls.Add(testName) 'adds the text to the panels
            testPanel.Controls.Add(testRollClass)
        Next
        'Checks if there are values matching the search
        If Sorted.Count < 1 Then
            lblNoValues.Visible = True
            Beep()
        Else
            lblNoValues.Visible = False
            RowerPanelClicked(RowerBox.Controls.Item(0), EventArgs.Empty) 'If there are values, set's the first panel to it's 'clicked' state
        End If
    End Sub
    Private Sub SortRowers() 'Sorts and Filters the data to be created
        'Clears all the lists used in the process and resets variables
        Sorted.Clear()
        SortList.Clear()
        SearchList.Clear()
        FilterList.Clear()
        FirstPanel = True
        'Adds the data from the column that is being sorted by
        For i As Integer = 0 To IDStr.Count - 1
            Select Case SortBox.SelectedIndex
                Case 1
                    SortList.Add(sName(i))
                Case 2
                    SortList.Add(rClass(i))
                Case 3
                    SortList.Add(IDStr(i))
                Case Else
                    SortList.Add(gName(i))
            End Select
        Next
        SortList.Sort() 'Sorts the temporary list
        'Adds the correct index to FilterList, avoids duplication
        For Each st As String In SortList
            If FirstPanel = True Then
                FilterList.Add(SortArray(SortBox.SelectedIndex).IndexOf(st))
            ElseIf st = gName(FilterList.Last) Or st = sName(FilterList.Last) Or st = rClass(FilterList.Last) Then
                position = FilterList.Last + 1
                If SortArray(SortBox.SelectedIndex).IndexOf(st, position) <> -1 Then
                    FilterList.Add(SortArray(SortBox.SelectedIndex).IndexOf(st, position))
                End If
            Else
                FilterList.Add(SortArray(SortBox.SelectedIndex).IndexOf(st))
            End If
            FirstPanel = False
        Next
    End Sub
    Private Sub FilterRowers() 'Filters the list of indexes by search query and by the year group selected
        For Each num As Integer In FilterList
            If FilterBox.SelectedIndex <> 0 Then
                If CInt(yGroup(num)) = yearGroups(FilterBox.SelectedIndex) Then
                    If gName(num).ToLower.Contains(SearchBox.Text.ToLower) Or sName(num).ToLower.Contains(SearchBox.Text.ToLower) Or IDStr(num).ToLower.Contains(SearchBox.Text.ToLower) Then
                        Sorted.Add(num)
                    End If
                End If
            Else
                If gName(num).ToLower.Contains(SearchBox.Text.ToLower) Or sName(num).ToLower.Contains(SearchBox.Text.ToLower) Or IDStr(num).ToLower.Contains(SearchBox.Text.ToLower) Then
                    Sorted.Add(num)
                End If
            End If
        Next
    End Sub 'Populate Details Field
    Private Sub FillDetails(index As Integer) 'Populate Details Field
        'Get databasable info
        lblID.Text = "ID: " + IDStr(index)
        lblsName.Text = gName(index)
        lblfName.Text = sName(index)
        lblrClass.Text = "Class: " + rClass(index)
        Select Case yGroup(index)
            Case "8"
                lblGroup.Text = "Year 8 Quads"
            Case "9"
                lblGroup.Text = "Year 9 Quads"
            Case "10"
                lblGroup.Text = "Year 10 Eights"
            Case "1"
                lblGroup.Text = "1st VIII"
        End Select
        Try
            Dim dbConn As OleDbConnection
            Dim dbCommand As New OleDbCommand()
            Dim strPath As String
            strPath = "|DataDirectory|\rowingDatabase (1).accdb"
            dbConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                                    & "DATA SOURCE=" _
                                    & strPath)
            dbCommand.CommandText = "SELECT * FROM tbProfiles WHERE ID=" &
                                    IDStr(index)
            dbCommand.Connection = dbConn
            dbConn.Open()
            Dim dbDR As OleDb.OleDbDataReader = dbCommand.ExecuteReader
            While dbDR.Read
                lblWeight.Text = "Weight: " + dbDR("Weight").ToString + "kg"
                lbl2k.Text = "2km Time: " + dbDR("2k")
                lblBeep.Text = "Beep Test Score: " + dbDR("Beep").ToString
                Select Case dbDR("Seat")
                    Case 0
                        lblPosition.Text = "Preferred Seat: Stroke"
                    Case 1
                        lblPosition.Text = "Preferred Seat: 2 Man"
                    Case 2
                        lblPosition.Text = "Preferred Seat: 3 Man"
                    Case 3
                        lblPosition.Text = "Preferred Seat: 4 Man"
                    Case 4
                        lblPosition.Text = "Preferred Seat: 5 Man"
                    Case 5
                        lblPosition.Text = "Preferred Seat: 6 Man"
                    Case 6
                        lblPosition.Text = "Preferred Seat: 7 Man"
                    Case 7
                        lblPosition.Text = "Preferred Seat: Bow"
                    Case Else
                        lblPosition.Text = "Preferred Seat: Coxswain"
                End Select
                Select Case dbDR("Side")
                    Case 0
                        lblSide.Text = "Preferred Seat: Stroke"
                    Case 1
                        lblSide.Text = "Preferred Seat: Bow"
                    Case Else
                        lblSide.Text = "Preferred Seat: N/A"
                End Select
            End While
            dbConn.Close()
        Catch err As System.Exception
            MsgBox(err.Message)
        End Try
        lblEmail.Text = IDStr(index) + "@student.sbhs.nsw.edu.au"
        'Generate random data that looks legit
        Randomize()
        lblTrAtPc.Text = "Training Attendance: " + CInt(Int((100 * Rnd()) + 1)).ToString + "%"
        Randomize()
        lblRaAtPc.Text = "Race Attendance: " + CInt(Int((100 * Rnd()) + 1)).ToString + "%"
    End Sub
    'Highlighting
    Private Sub RowerPanelEnter(sender As Object, e As EventArgs)
        If sender.Tag <> "Clicked" Then
            Dim entered As Panel = sender
            entered.BackColor = skyYellow
        End If
    End Sub
    Private Sub RowerPanelTextEnter(sender As Object, e As EventArgs) 'Because text blocks the mouse enter part of the label
        RowerPanelEnter(sender.Parent, e)
    End Sub
    Private Sub RowerPanelExit(sender As Object, e As EventArgs)
        Dim exited As Panel = sender
        If exited.Tag <> "Clicked" Then
            exited.BackColor = schoolBlue
        End If
    End Sub
    Private Sub RowerPanelTextExit(sender As Object, e As EventArgs) 'Because text blocks the mouse exit part of the label
        RowerPanelExit(sender.Parent, e)
    End Sub
    'Click
    Private Sub RowerPanelTextClicked(sender As Object, e As EventArgs) 'Because text blocks the mouse click part of the label
        RowerPanelClicked(sender.Parent, e)
    End Sub
    Public Sub RowerPanelClicked(sender As Object, e As EventArgs)
        For Each i As Panel In RowerBox.Controls
            i.Tag = "NotClicked"                                    'Totally Legit boolean
            i.BackColor = schoolBlue
        Next
        Dim clicked As Panel = sender
        clicked.Tag = "Clicked"
        clicked.BackColor = skyOrange
        Dim index = CInt(clicked.Name)
        FillDetails(index)
        SelectedRower = IDStr(index)
    End Sub
    'Edit Button Higlighting
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        If Button1.BackColor <> skyOrange Then
            Button1.BackColor = skyYellow
        End If
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        If Button1.BackColor <> skyOrange Then
            Button1.BackColor = schoolBlue
        End If
    End Sub
    Private Sub SortBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SortBox.SelectedIndexChanged 'If combobox is changed, refresh panels
        RowerBox.Controls.Clear() 'Clear all the panels
        FillPanels()
        RowerBox.Focus()
    End Sub
    Private Sub FilterBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterBox.SelectedIndexChanged 'If combobox is changed, refresh panels
        RowerBox.Controls.Clear() 'Clear all the panels
        FillPanels()
        RowerBox.Focus()
    End Sub
    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged  'If text is changed, refresh panels
        RowerBox.Controls.Clear() 'Clear all the panels
        FillPanels()
    End Sub
    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click 'Theoretically launches your mail client, with the compose email window open, and the adress field pre-filled
        Dim adress As String = "mailto:" + lblEmail.Text
        Process.Start(adress)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditProfiles.Show()
        Button1.BackColor = skyOrange
    End Sub
    Private Sub ProfilesView_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        RowerBox.Focus()
    End Sub
    Private Sub ProfilesView_Click(sender As Object, e As EventArgs) Handles Me.Click
        RowerBox.Focus()
    End Sub
End Class