Imports System.Data.OleDb

Public Class newRace
    Dim selectedIndex As Integer = 0                            'Selected index of the 'infoList' listView
    Dim eventsList As List(Of String()) = New List(Of String()) 'List of the events on display
    Dim infoLabels As New List(Of Label)                        'List of the help labels

    Private Sub newRace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoLabels = New List(Of Label) From {info1, info2, info3, info4, info5, info6, info7}  'Populates the infoLabels list
        styleForm(Me)   'Styles the form default

        If raceEditInfo IsNot Nothing Then 'If there is any prior info to load
            eventNameBox.Text = raceEditInfo(1) 'Loads event Name
            eventTime.Text = raceEditInfo(2)    'Loads event Date
            Dim tempList As New List(Of Array)
            For i = 0 To 5
                tempList.Add(Split(raceEditInfo(i + 4).Trim({"["c, "]"c}), "|"))
            Next
            For i = 0 To CInt(raceEditInfo(3)) - 1
                Dim row(5) As String
                For j = 0 To 5
                    row(j) = tempList(j)(i)
                Next
                eventsList.Add(row)
            Next
            refreshInfoList(infoList)
        End If

    End Sub

    Private Sub raceSelect(sender As ListView, e As EventArgs) Handles infoList.SelectedIndexChanged
        If infoList.SelectedIndices.Count <> 0 Then
            selectedIndex = infoList.SelectedIndices(0)                         'Sets selectedIndex to the appropriate number
        Else
            selectedIndex = 0
        End If
        Dim selectedItem = infoList.Items(selectedIndex)                        'Sets selectedItem as a temporary item to save space

        minCounter.Value = CInt(Split(selectedItem.SubItems(1).Text, ":")(0))   'Sets all the controls to appropriate values
        secCounter.Value = CInt(Split(selectedItem.SubItems(1).Text, ":")(1))
        distCounter.Value = CInt(selectedItem.SubItems(2).Text)
        particiCounter.Value = CInt(Split(selectedItem.SubItems(3).Text, " of ")(1))
        posCounter.Value = ordinalConvert(Split(selectedItem.SubItems(3).Text, " of ")(0))
        Dim temp = Split(selectedItem.SubItems(4).Text, " ")
        yearCounter.Value = CInt(temp(0))
        gradeCombo.SelectedItem = temp(1).Trim("Y")
        crewCounter.Value = ordinalConvert(temp(2))
        boatCombo.SelectedItem = temp(3)

        refreshRowerList(rowerList) 'refreshes the rowerList based on the selectedIndex
    End Sub

    'For refreshing the display of ListViews based on EventsList
    Private Sub refreshRowerList(list)
        list.Items.Clear()
        If eventsList.Count <> 0 Then
            For Each rower In Split(eventsList(selectedIndex)(5), ",")
                Dim itm As ListViewItem = New ListViewItem(rower)
                list.Items.Add(itm)
            Next
        End If
    End Sub             'Refreshing the rower listView
    Private Sub refreshInfoList(list As ListView)
        list.Items.Clear()
        For Each blank In eventsList
            Dim itm As ListViewItem = New ListViewItem(blank)
            list.Items.Add(itm)
        Next
    End Sub  'Refreshing the events listView

    'These are activated by the user editing stuff. They change values in eventsList
    Private Sub posCounter_ValueChanged(sender As Object, e As EventArgs) Handles posCounter.ValueChanged
        If eventsList.Count <> 0 Then
            eventsList(selectedIndex)(3) = ordinalConvert(posCounter.Value) + " of " + CStr(particiCounter.Value)
        End If
        refreshInfoList(infoList)
    End Sub
    Private Sub particiCounter_ValueChanged(sender As Object, e As EventArgs) Handles particiCounter.ValueChanged
        If posCounter.Value > particiCounter.Value Then
            posCounter.Value = particiCounter.Value
        End If
        posCounter.Maximum = particiCounter.Value
        If eventsList.Count <> 0 Then
            eventsList(selectedIndex)(3) = ordinalConvert(posCounter.Value) + " of " + CStr(particiCounter.Value)
        End If

        refreshInfoList(infoList)
    End Sub
    Private Sub minCounter_ValueChanged(sender As Object, e As EventArgs) Handles minCounter.ValueChanged, secCounter.ValueChanged
        If secCounter.Value = 60 And minCounter.Value <> minCounter.Maximum Then
            secCounter.Value = 0
            minCounter.Value = minCounter.Value + 1
        End If
        If eventsList.Count <> 0 Then
            Dim temp = ""
            If minCounter.Value < 10 Then
                temp += "0"
            End If
            temp += CStr(minCounter.Value) + ":"
            If secCounter.Value < 10 Then
                temp += "0"
            End If
            temp += CStr(secCounter.Value)
            eventsList(selectedIndex)(1) = temp
        End If

        refreshInfoList(infoList)
    End Sub
    Private Sub distCounter_ValueChanged(sender As Object, e As EventArgs) Handles distCounter.ValueChanged
        If eventsList.Count <> 0 Then
            eventsList(selectedIndex)(2) = distCounter.Value
        End If

        refreshInfoList(infoList)
    End Sub
    Private Sub yearCounter_ValueChanged(sender As Object, e As EventArgs) Handles yearCounter.ValueChanged, gradeCombo.SelectedValueChanged, crewCounter.ValueChanged, boatCombo.SelectedValueChanged
        If eventsList.Count <> 0 Then
            eventsList(selectedIndex)(4) = CStr(yearCounter.Value) + " Y" + CStr(gradeCombo.SelectedItem) + " " + CStr(ordinalConvert(crewCounter.Value)) + " " + CStr(boatCombo.SelectedItem)
        End If

        refreshInfoList(infoList)
    End Sub

    'Adding or deleting rowers
    Private Sub addRower_Click(sender As Object, e As EventArgs) Handles addRower.Click
        If searchRower.Text.Trim <> "" And eventsList.Count <> 0 Then
            If eventsList(selectedIndex)(5) <> "" Then
                eventsList(selectedIndex)(5) += ","
            End If
            eventsList(selectedIndex)(5) += searchRower.Text.Trim()
            searchRower.Text = ""

            refreshRowerList(rowerList)
            refreshInfoList(infoList)
        End If
    End Sub
    Private Sub searchRower_TextChanged(sender As Object, e As EventArgs) Handles searchRower.TextChanged
        'Data validation
        Dim theText As String = sender.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = sender.SelectionStart
        Dim Change As Integer
        Dim charactersDisallowed As String = "|,"

        For x As Integer = 0 To sender.Text.Length - 1
            Letter = sender.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        sender.Text = theText
        sender.Select(SelectionIndex - Change, 0)
    End Sub
    Private Sub namerower_KeyPress(sender As Object, e As KeyEventArgs) Handles searchRower.KeyDown
        If e.KeyCode = Keys.Enter Then
            addRower.PerformClick()
        End If
    End Sub
    Private Sub deleteRower_Click(sender As Object, e As EventArgs) Handles deleteRower.Click
        If rowerList.SelectedIndices.Count <> 0 Then

            Dim temp = Split(eventsList(selectedIndex)(5), ",")
            temp(rowerList.SelectedIndices(0)) = Nothing
            Dim temp2 = ""
            For i = 0 To temp.Length - 1
                If temp(i) IsNot Nothing Then
                    temp2 += temp(i) + ","
                End If
            Next
            temp2 = temp2.Trim(",")
            eventsList(selectedIndex)(5) = temp2

            refreshRowerList(rowerList)
            refreshInfoList(infoList)
        End If
    End Sub

    'Adding or deleting races
    Private Sub addRace_Click(sender As Object, e As EventArgs) Handles addRace.Click
        If nameRace.Text().Trim <> "" Then
            Dim row(6) As String
            row(0) = nameRace.Text()
            row(1) = "00:00"
            row(2) = "0"
            row(3) = "1st of 1"
            row(4) = "2016 Y7 1st Quad"
            row(5) = ""
            eventsList.Add(row)
            refreshInfoList(infoList)
            nameRace.Text = ""
            infoList.FocusedItem = infoList.Items(infoList.Items.Count - 1)
            infoList.Focus()
            raceSelect(infoList, e)
        End If
    End Sub
    Private Sub nameRace_TextChanged(sender As Object, e As EventArgs) Handles nameRace.TextChanged
        'Data validation
        Dim theText As String = sender.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = sender.SelectionStart
        Dim Change As Integer
        Dim charactersDisallowed As String = "|"

        For x As Integer = 0 To sender.Text.Length - 1
            Letter = sender.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        sender.Text = theText
        sender.Select(SelectionIndex - Change, 0)
    End Sub
    Private Sub nameRace_KeyPress(sender As Object, e As KeyEventArgs) Handles nameRace.KeyDown
        If e.KeyCode = Keys.Enter Then
            addRace.PerformClick()
        End If
    End Sub
    Private Sub deleteRace_Click(sender As Object, e As EventArgs) Handles deleteRace.Click
        If eventsList.Count() <> 0 Then
            eventsList.RemoveAt(selectedIndex)
            If selectedIndex = eventsList.Count() Then
                selectedIndex -= 1
            End If
            refreshInfoList(infoList)
            refreshRowerList(rowerList)
        End If
    End Sub

    'Discarding changes
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            eventsList.Clear()
            openForm(Me, New resultsRace)
        End If
    End Sub

    'Submitting changes
    Private Sub finish_Click(sender As Object, e As EventArgs) Handles finish.Click
        'Data validation
        Dim dataValid = True
        If eventNameBox.Text.Trim() = "" Then
            dataValid = False
            MsgBox("Error: Event Name Blank")
            eventNameBox.Focus()
        ElseIf eventTime.Value > DateTime.now Then
            dataValid = False
            MsgBox("Error: Date is in Future")
            eventTime.Focus()
        ElseIf eventsList.Count = 0 Then
            dataValid = False
            MsgBox("Error: No Races")
            nameRace.Focus()
        Else
            For i = 0 To eventsList.Count - 1
                If eventsList(i)(5).Trim() = "" Then
                    dataValid = False
                    MsgBox("Error: No Rowers for " + eventsList(i)(0))
                    rowerList.Focus()
                    Exit For
                End If
            Next
        End If


        If dataValid Then
            Dim raceArray = New List(Of String) From {"", "", "", "", "", "", ""}
            For i = 0 To eventsList.Count - 1
                For j = 0 To 5
                    raceArray(j) += eventsList(i)(j)
                    If i <> eventsList.Count - 1 Then
                        raceArray(j) += "|"
                    End If
                Next
            Next

            Dim query As String = ""
            Dim ID As Integer
            If raceEditInfo IsNot Nothing Then
                query = "UPDATE [Races] " +
                          "SET " +
                          "[EventName]= @EventName," +
                          "[EventDate] = @EventDate," +
                          "[RaceNum] = @RaceNum," +
                          "[RaceName] = @RaceName," +
                          "[RaceTime] = @RaceTime," +
                          "[Distance] = @Distance," +
                          "[Position] = @Position," +
                          "[Crew] = @Crew," +
                          "[CrewMembers] = @CrewMembers " +
                          "WHERE [ID] = " + raceEditInfo(0)
            Else
                query = "INSERT INTO [Races] ([ID], [EventName], [EventDate], [RaceNum], [RaceName], [RaceTime], [Distance], [Position], [Crew], [CrewMembers]) " +
                          "VALUES (@ID, @EventName, @EventDate, @RaceNum, @RaceName, @RaceTime, @Distance, @Position, @Crew, @CrewMembers)"
                ID = eventIDnum + 1
            End If

            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=|DataDirectory|\rowingDatabase (1).accdb")
                Using comm As New OleDbCommand(query, conn)
                    With comm
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@ID", ID)
                        .Parameters.AddWithValue("@EventName", eventNameBox.Text)
                        .Parameters.AddWithValue("@EventDate", eventTime.Value.ToShortDateString)
                        .Parameters.AddWithValue("@RaceNum", CStr(eventsList.Count))
                        .Parameters.AddWithValue("@RaceName", raceArray(0))
                        .Parameters.AddWithValue("@RaceTime", raceArray(1))
                        .Parameters.AddWithValue("@Distance", raceArray(2))
                        .Parameters.AddWithValue("@Position", raceArray(3))
                        .Parameters.AddWithValue("@Crew", raceArray(4))
                        .Parameters.AddWithValue("@CrewMembers", raceArray(5))
                    End With
                    Try
                        conn.Open()
                        comm.ExecuteNonQuery()
                    Catch ex As OleDbException
                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                    End Try
                End Using
            End Using
            openForm(Me, New resultsRace)
        End If
    End Sub

    'Help Icon
    Private Sub FilterInfo_Enter(sender As Object, e As EventArgs) Handles FilterInfo.MouseEnter
        For Each label As Label In infoLabels
            label.Visible = True
            label.ForeColor = Color.Black
        Next
    End Sub
    Private Sub FilterInfo_Leave(sender As Object, e As EventArgs) Handles FilterInfo.MouseLeave
        For Each label As Label In infoLabels
            label.Visible = False
        Next
    End Sub
End Class