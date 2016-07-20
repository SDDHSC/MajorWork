'Allow Profile editing
'make Graphics Nice
Imports System.Data.OleDb
Public Class ProfilesView
    'Lists populated with database data
    Dim IDNum As New List(Of Int32)
    Dim IDStr As New List(Of String)
    Dim gName As New List(Of String)
    Dim sName As New List(Of String)
    Dim yGroup As New List(Of String)
    Dim rClass As New List(Of String)

    Dim Sorted As New List(Of Integer)                          'Sorted list of indexes
    Dim TempList As New List(Of String)                         'Temporary list used to sort database list without changing indexes
    Dim SortArray() As Object = {gName, sName, rClass, IDStr}   'Array matching the sort combo box index to its respective list 
    Dim SearchList As New List(Of String)                       'Temporary list used to search database list without changing indexes 
    Dim Loaded As Boolean = False                               'Because things break if certain lines of code run on load (no fucking clue why, this shifty workaround is only solution i can find)
    Dim position As Integer = 0                                 'Position to start index search, used when there are multiple people with the same primary value
    Dim FirstPanel As Boolean = True                            'Boolean showing whether the panel being filled is the first panel
    Dim ListOTemp As New List(Of String)                        'Temporary list used to get sorted values prior to being filtered by the search module
    Private Sub ProfilesView_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadDatabase()

        'Set ComboBoxes to First Index (so that they're not blank)
        SortBox.SelectedIndex = 0
        FilterBox.SelectedIndex = 0

        'Load Panels
        FillPanels()
        Loaded = True

        SearchBox.Focus()                                       'Ensures the focus is on the search box when the form loads, so you can type straight away
    End Sub
    Private Sub ReadDatabase() 'Reads the database, and populates the data strings
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
    Private Sub FillPanels() 'Creates Panels and populate them with data
        SortAndFilter()
        SearchFilter()
        RowerBox.Controls.Clear() 'Ensures the flow layout panel is empty
        For Each rower As Integer In Sorted 'Every Index in Sorted (All indexes or all indexes matching search, just in a sorted order)
            'Creates the panels
            Dim testPanel As New Panel With
                {
                    .Height = 50,
                    .Width = 140,
                    .BackColor = schoolBlue,
                    .Name = rower.ToString,
                    .Tag = "NotCLicked" 'Totally a Boolean
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
            'Adds Mouse Click/Enter/Exit to every panel, and maps it all to the same sub
            AddHandler testPanel.MouseClick, AddressOf RowerPanelClicked
            AddHandler testID.MouseClick, AddressOf RowerPanelTextClicked
            AddHandler testName.MouseClick, AddressOf RowerPanelTextClicked
            AddHandler testPanel.MouseEnter, AddressOf RowerPanelEnter
            AddHandler testPanel.MouseLeave, AddressOf RowerPanelExit
            AddHandler testName.MouseEnter, AddressOf RowerPanelTextEnter
            AddHandler testName.MouseLeave, AddressOf RowerPanelTextExit
            AddHandler testID.MouseEnter, AddressOf RowerPanelTextEnter
            AddHandler testID.MouseLeave, AddressOf RowerPanelTextExit
            RowerBox.Controls.Add(testPanel) 'adds the panels to the box
            testPanel.Controls.Add(testID) 'adds the text to the panels
            testPanel.Controls.Add(testName) 'adds the text to the panels
        Next
        'Checks if there are values matching the search
        If Sorted.Count < 1 Then
            lblNoValues.Visible = True
            Beep()
        Else
            lblNoValues.Visible = False
        End If

        Sorted.Clear() 'Clears the sorted list
    End Sub
    Private Sub SortAndFilter() 'Sorts and Filters the data to be created
        'Clears all the lists used in the process
        Sorted.Clear()
        SearchList.Clear()
        TempList.Clear()
        ListOTemp.Clear()
        FirstPanel = True

        If Loaded = True Then 'Sort by selected sort type
            For Each st As String In SortArray(SortBox.SelectedIndex)
                TempList.Add(st)
            Next
        Else 'On load, sort by lastname by default
            For Each x As String In SortArray(0)
                TempList.Add(x)
            Next
        End If

        TempList.Sort() 'Sorts the temporary list

        'Filter by year group. Could be cleaned up but ceebs
        For Each i As String In TempList
            Select Case FilterBox.SelectedIndex
                Case 1
                    If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i)) = 1 Then
                        Sort(i)
                    End If
                Case 2
                    If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i)) = 10 Then
                        Sort(i)
                    End If
                Case 3
                    If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i)) = 9 Then
                        Sort(i)
                    End If
                Case 4
                    If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i)) = 8 Then
                        Sort(i)
                    End If
                Case Else
                    Sort(i)
            End Select
        Next
    End Sub
    Private Sub SearchFilter() 'Filters the remaining items by matching it to search box
        For Each num As Integer In ListOTemp
            If gName(num).ToLower.Contains(SearchBox.Text.ToLower) Or sName(num).ToLower.Contains(SearchBox.Text.ToLower) Or IDStr(num).ToLower.Contains(SearchBox.Text.ToLower) Then
                Sorted.Add(num)
            End If
        Next
        ListOTemp.Clear()
    End Sub
    Private Sub Sort(i As String) 'Checks for duplicates, and adds to TempOList
        If FirstPanel = True Then
            ListOTemp.Add(SortArray(SortBox.SelectedIndex).IndexOf(i))
        ElseIf i = gName(ListOTemp.Last) Or i = sName(ListOTemp.Last) Or i = rClass(ListOTemp.Last) Then
            position = ListOTemp.Last + 1
            If SortArray(SortBox.SelectedIndex).IndexOf(i, position) <> -1 Then
                ListOTemp.Add(SortArray(SortBox.SelectedIndex).IndexOf(i, position))
            End If
        Else
            ListOTemp.Add(SortArray(SortBox.SelectedIndex).IndexOf(i))
        End If
        FirstPanel = False
    End Sub
    'Populate Details Field
    Private Sub FillDetails(index As Integer)
        'Get databasable info
        Dim str2k As String
        Dim numWeight, numBeep, numSeat, numSide As Integer

        lblID.Text = "ID: " + IDStr(index)
        lblsName.Text = gName(index)
        lblfName.Text = sName(index)
        lblrClass.Text = "Class: " + rClass(index)
        'Convert Integer to actual term
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
        'Generate random data that looks legit
        Randomize()
        numWeight = CInt(Int((60 * Rnd()) + 40))
        lblWeight.Text = "Weight: " + numWeight.ToString + "kg"
        Randomize()
        str2k = "0" + CInt(Int((6 * Rnd()) + 4)).ToString + ":" + CInt(Int((50 * Rnd()) + 10)).ToString
        lbl2k.Text = "2km Time: " + str2k
        Randomize()
        numBeep = CDec((Int((100 * Rnd()) + 40)) / 10)
        lblBeep.Text = "Beep Test Score: " + numBeep.ToString
        Randomize()
        numSeat = CInt(7 * Rnd())
        lblPosition.Text = "Preferred Side: Stroke"
        Randomize()
        numSide = CInt(1 * Rnd())
        lblSide.Text = "Preferred Position: Stroke"
        Randomize()
        lblTrAtPc.Text = "Training Attendance: " + CInt(Int((100 * Rnd()) + 1)).ToString + "%"
        Randomize()
        lblRaAtPc.Text = "Race Attendance: " + CInt(Int((100 * Rnd()) + 1)).ToString + "%"
        'Email is based off ID number, so is actually legit
        lblEmail.Text = IDStr(index) + "@student.sbhs.nsw.edu.au"

        Try
            Dim DBConn As OleDbConnection
            Dim dbCommand As New OleDbCommand()

            DBConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
            & "DATA SOURCE=" _
            & "|DataDirectory|\rowingDatabase (1).accdb")
            dbCommand.CommandText = "Update tbProfiles Set " _
            & "Weight='" & numWeight & "', " _
            & "2k='" & str2k & "', " _
            & "Beep='" & numBeep & "', " _
            & "Side='" & numSide & "', " _
            & "Seat='" & numSeat & "' " _
            & "WHERE ID=" & IDStr(index)
                                                                         +
            dbCommand.Connection = DBConn
            dbCommand.Connection.Open()
            dbCommand.ExecuteNonQuery()
            DBConn.Close()
            MsgBox("Guardado satisfactoriamente.")
        Catch err As System.Exception
            MsgBox(err.Message)
        End Try
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
    Private Sub RowerPanelClicked(sender As Object, e As EventArgs)
        For Each i As Panel In RowerBox.Controls
            i.Tag = "NotClicked"
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