﻿Public Class newRace
    Dim selectedIndex As Integer = 0
    Dim eventsList As List(Of String()) = New List(Of String())

    Private Sub newRace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = schoolBlue
        If raceEditInfo IsNot Nothing Then
            eventNameBox.Text = raceEditInfo(1)
            eventTime.Text = raceEditInfo(2)
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
            allEdit.Visible = True
        End If

    End Sub

    Private Sub addRace_Click(sender As Object, e As EventArgs) Handles addRace.Click
        If nameRace.Text().Trim <> "" Then
            Dim row(6) As String
            row(0) = nameRace.Text()
            row(1) = "0:0"
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

    Private Sub raceSelect(sender As ListView, e As EventArgs) Handles infoList.SelectedIndexChanged
        'Try
        selectedIndex = infoList.SelectedIndices(0)
            Dim selectedItem = infoList.Items(selectedIndex)

            minCounter.Value = CInt(Split(selectedItem.SubItems(1).Text, ":")(0))
            secCounter.Value = CInt(Split(selectedItem.SubItems(1).Text, ":")(1))

            distCounter.Value = CInt(selectedItem.SubItems(2).Text)


        particiCounter.Value = CInt(Split(selectedItem.SubItems(3).Text, " of ")(1))
        posCounter.Value = ordinalConvert(Split(selectedItem.SubItems(3).Text, " of ")(0))

        Dim temp = Split(selectedItem.SubItems(4).Text, " ")
            yearCounter.Value = CInt(temp(0))
            gradeCombo.SelectedItem = temp(1).Trim("Y")
        crewCounter.Value = ordinalConvert(temp(2))

        refreshRowerList(rowerList)
        'Catch
        'End Try
    End Sub

    Private Sub refreshRowerList(list)
        list.Items.Clear()
        For Each rower In Split(eventsList(selectedIndex)(5), ",")
            Dim itm As ListViewItem = New ListViewItem(rower)
            list.Items.Add(itm)
        Next
    End Sub

    Public Function ordinalConvert(val)
        If TypeOf (val) Is String Then
            Return val.substring(0, val.length - 2)
        Else
            If val Mod 10 = 1 And val Mod 100 <> 11 Then
                Return (CStr(val) + "st")
            ElseIf val Mod 10 = 2 And val Mod 100 <> 12 Then
                Return (CStr(val) + "nd")
            ElseIf val Mod 10 = 3 And val Mod 100 <> 13 Then
                Return (CStr(val) + "rd")
            Else
                Return (CStr(val) + "th")
            End If
        End If

    End Function

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

    Private Sub refreshInfoList(list As ListView)
        list.Items.Clear()
        For Each blank In eventsList
            Dim itm As ListViewItem = New ListViewItem(blank)
            list.Items.Add(itm)
        Next
    End Sub

    Private Sub nameRace_KeyPress(sender As Object, e As KeyEventArgs) Handles nameRace.KeyDown
        If e.KeyCode = Keys.Enter Then
            addRace.PerformClick()
        End If
    End Sub

    Private Sub nameRce_KeyPress(sender As Object, e As KeyEventArgs) Handles searchRower.KeyDown
        If e.KeyCode = Keys.Enter Then
            addRower.PerformClick()
        End If
    End Sub

    Private Sub minCounter_ValueChanged(sender As Object, e As EventArgs) Handles minCounter.ValueChanged, secCounter.ValueChanged
        If secCounter.Value = 60 And minCounter.Value <> minCounter.Maximum Then
            secCounter.Value = 0
            minCounter.Value = minCounter.Value + 1
        End If
        If eventsList.Count <> 0 Then
            eventsList(selectedIndex)(1) = CStr(minCounter.Value) + ":" + CStr(secCounter.Value)
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

    Private Sub addRower_Click(sender As Object, e As EventArgs) Handles addRower.Click
        If searchRower.Text <> "" Then
            eventsList(selectedIndex)(5) += "," + searchRower.Text
            searchRower.Text = ""

            refreshRowerList(rowerList)
            refreshInfoList(infoList)
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

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            eventsList.Clear()
            Me.Close()
            resultsRace.Show()
        End If
    End Sub

    Private Sub deleteRace_Click(sender As Object, e As EventArgs) Handles deleteRace.Click
        If eventsList.Count() <> 0 Then
            eventsList.RemoveAt(selectedIndex)
            refreshInfoList(infoList)
        End If
    End Sub
End Class