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
    Dim position As Integer = 0
    Private Sub ProfilesView_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Read Database
        Me.TbProfilesTableAdapter.Fill(Me._rowingDatabase__1_DataSet.tbProfiles)
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
        'Set ComboBoxes to First Index (so that they're not blank)
        SortBox.SelectedIndex = 0
        FilterBox.SelectedIndex = 0
        'Load Panels
        FillPanels()
        Loaded = True
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
    End Sub
    'Populate Details Field
    Private Sub FillDetails(index As Integer)
        'Get databasable info
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
        lblWeight.Text = "Weight: " + CInt(Int((60 * Rnd()) + 40)).ToString + "kg"
        Randomize()
        lbl2k.Text = "2km Time: " + "0" + CInt(Int((6 * Rnd()) + 4)).ToString + ":" + CInt(Int((50 * Rnd()) + 10)).ToString
        Randomize()
        lblBeep.Text = "Beep Test Score: " + CDec((Int((100 * Rnd()) + 40)) / 10).ToString
        lblPosition.Text = "Preferred Side: Stroke"
        lblSide.Text = "Preferred Position: Stroke"
        Randomize()
        lblTrAtPc.Text = "Training Attendance: " + CInt(Int((100 * Rnd()) + 1)).ToString + "%"
        Randomize()
        lblRaAtPc.Text = "Race Attendance: " + CInt(Int((100 * Rnd()) + 1)).ToString + "%"
        'Email is based off ID number, so is actually legit
        lblEmail.Text = IDStr(index) + "@student.sbhs.nsw.edu.au"
    End Sub
    'Create and Populate Panels
    Private Sub FillPanels()
        SortAndFilter()
        RowerBox.Controls.Clear() 'Clear all the panels
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
                    .Font = New Drawing.Font("Segoe UI", 9.75, FontStyle.Bold),
                    .Location = New Point(0, 0),
                    .Name = "rID" + rower.ToString
                }
            'Creates the Name Label
            Dim testName As New Label With
                {
                    .Text = gName(rower).ToUpper + ", " + sName(rower),
                    .Font = New Drawing.Font("Segoe UI", 8),
                    .Location = New Point(0, 20),
                    .Name = "rName" + rower.ToString
                }
            'If the name doesn't fit, splits name in two
            If testName.Text.Length > 14 Then
                testName.Text = gName(rower).ToUpper + ", "
                Dim testName2 As New Label With
                {
                    .Text = sName(rower),
                    .Font = New Drawing.Font("Segoe UI", 8),
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
    End Sub
    Private Sub SortAndFilter() 'Exactly what it says, but also search
        RowerBox.Controls.Clear() 'Clear all the panels
        If Loaded = True Then
            'Clears lists of previous search/sort/filter
            SearchList.Clear()
            Sorted.Clear()
            TempList.Clear()
            'Adds all the strings from the List appropriate to the sort type
            For Each st As String In SortArray(SortBox.SelectedIndex)
                SearchList.Add(st)
            Next
            'If the text in the search box is contatined within any of the displayed data, add it to the to be sorted list
            For i As Integer = 0 To IDNum.Count - 1
                If gName(i).ToLower.Contains(SearchBox.Text.ToLower) Or sName(i).ToLower.Contains(SearchBox.Text.ToLower) Or IDStr(i).ToLower.Contains(SearchBox.Text.ToLower) Then
                    TempList.Add(SearchList(i))
                End If
            Next
        Else 'On load, sort by lastname by default
            For Each x As String In SortArray(0)
                TempList.Add(x)
            Next
        End If
        TempList.Sort() 'Exactly what you'd think
        'Filter by year group. Could be cleaned up but ceebs
        'position = 0
        'For Each i As String In TempList
        'While position < IDNum.Count - 1
        'position = getLiteratura.IndexOf("ISBN", position)
        'If position <> -1 Then
        '    Dim endPosition As Integer = getLiteratura.IndexOf(".", position + 1)
        '    If endPosition <> -1 Then
        '        isbns.Add(getLiteratura.Substring(position + 5, endPosition - position - 5))
        '    End If
        '    position = endPosition
        'End If
        '        Select Case FilterBox.SelectedIndex
        '            Case 1
        '                If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i, position)) = 1 Then
        '                    Sorted.Add(SortArray(SortBox.SelectedIndex).IndexOf(i, position))
        '                End If
        '            Case 2
        '                If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i, position)) = 10 Then
        '                    Sorted.Add(SortArray(SortBox.SelectedIndex).IndexOf(i, position))
        '                End If
        '            Case 3
        '                If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i, position)) = 9 Then
        '                    Sorted.Add(SortArray(SortBox.SelectedIndex).IndexOf(i, position))
        '                End If
        '            Case 4
        '                If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i, position)) = 8 Then
        '                    Sorted.Add(SortArray(SortBox.SelectedIndex).IndexOf(i, position))
        '                End If
        '            Case Else
        '                Sorted.Add(SortArray(SortBox.SelectedIndex).IndexOf(i, position)) 'This line, and the similar ones above, Add the indexes of the data being displayed to a list, in the order that it's sorted
        '        End Select
        '        position += 1
        '    End While
        'Next
    End Sub
    Private Sub SortBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SortBox.SelectedIndexChanged 'If combobox is changed, refresh panels
        RowerBox.Controls.Clear() 'Clear all the panels
        FillPanels()
    End Sub
    Private Sub FilterBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterBox.SelectedIndexChanged 'If combobox is changed, refresh panels
        RowerBox.Controls.Clear() 'Clear all the panels
        FillPanels()
    End Sub
    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged  'If text is changed, refresh panels
        RowerBox.Controls.Clear() 'Clear all the panels
        FillPanels()
    End Sub
    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click 'Theoretically launches your mail client, with the compose email window open, and the adress field pre-filled
        Dim adress As String = "mailto:" + lblEmail.Text
        Process.Start(adress)
    End Sub
End Class