Imports System.Data.OleDb
Public Class ProfilesView
    Dim IDNum As New List(Of Int32)
    Dim IDStr As New List(Of String)
    Dim gName As New List(Of String)
    Dim sName As New List(Of String)
    Dim yGroup As New List(Of String)
    Dim rClass As New List(Of String)
    Dim Alphebetised As New List(Of Integer)
    Dim TempList As New List(Of String)
    Dim SortArray() As Object = {gName, sName, rClass, IDStr}
    Dim Loaded As Boolean = False
    Private Sub ProfilesView_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Read Database
        Me.TbProfilesTableAdapter.Fill(Me._rowingDatabase__1_DataSet.tbProfiles)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, sName, gName, rClass, Group FROM tbProfiles", conn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
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
        'Set ComboBoxes to First Index
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
    Private Sub RowerPanelTextEnter(sender As Object, e As EventArgs)
        RowerPanelEnter(sender.Parent, e)
    End Sub
    Private Sub RowerPanelExit(sender As Object, e As EventArgs)
        Dim exited As Panel = sender
        If exited.Tag <> "Clicked" Then
            exited.BackColor = schoolBlue
        End If
    End Sub
    Private Sub RowerPanelTextExit(sender As Object, e As EventArgs)
        RowerPanelExit(sender.Parent, e)
    End Sub
    'Click
    Private Sub RowerPanelTextClicked(sender As Object, e As EventArgs)
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
        lblEmail.Text = IDStr(index) + "@student.sbhs.nsw.edu.au"
    End Sub
    'Create and Populate Panels
    Private Sub FillPanels()
        RowerBox.Controls.Clear()
        SortAndFilter()
        For Each rower As Integer In Alphebetised '= 0 To IDNum.Count - 1
            Dim testPanel As New Panel With
                {
                    .Height = 50,
                    .Width = 140,
                    .BackColor = schoolBlue,
                    .Name = rower.ToString,
                    .Tag = "NotCLicked"
                }
            Dim testID As New Label With
                {
                    .Text = IDStr(rower),
                    .Font = New Drawing.Font("Segoe UI", 9.75, FontStyle.Bold),
                    .Location = New Point(0, 0),
                    .Name = "rID" + rower.ToString
                }
            Dim testName As New Label With
                {
                    .Text = gName(rower).ToUpper + ", " + sName(rower),
                    .Font = New Drawing.Font("Segoe UI", 8),
                    .Location = New Point(0, 20),
                    .Name = "rName" + rower.ToString
                }
            If testName.Text.Length > 15 Then
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
            AddHandler testPanel.MouseClick, AddressOf RowerPanelClicked
            AddHandler testID.MouseClick, AddressOf RowerPanelTextClicked
            AddHandler testName.MouseClick, AddressOf RowerPanelTextClicked
            AddHandler testPanel.MouseEnter, AddressOf RowerPanelEnter
            AddHandler testPanel.MouseLeave, AddressOf RowerPanelExit
            AddHandler testName.MouseEnter, AddressOf RowerPanelTextEnter
            AddHandler testName.MouseLeave, AddressOf RowerPanelTextExit
            AddHandler testID.MouseEnter, AddressOf RowerPanelTextEnter
            AddHandler testID.MouseLeave, AddressOf RowerPanelTextExit
            RowerBox.Controls.Add(testPanel)
            testPanel.Controls.Add(testID)
            testPanel.Controls.Add(testName)
        Next
    End Sub
    Private Sub SortAndFilter()
        If Loaded = True Then
            Alphebetised.Clear()
            TempList.Clear()
            For Each x As String In SortArray(SortBox.SelectedIndex)
                TempList.Add(x)
            Next
        Else
            For Each x As String In SortArray(0)
                TempList.Add(x)
            Next
        End If
        TempList.Sort()
        For Each i As String In TempList
            Select Case FilterBox.SelectedIndex
                Case 1
                    If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i)) = 1 Then
                        Alphebetised.Add(SortArray(SortBox.SelectedIndex).IndexOf(i))
                    End If
                Case 2
                    If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i)) = 10 Then
                        Alphebetised.Add(SortArray(SortBox.SelectedIndex).IndexOf(i))
                    End If
                Case 3
                    If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i)) = 9 Then
                        Alphebetised.Add(SortArray(SortBox.SelectedIndex).IndexOf(i))
                    End If
                Case 4
                    If yGroup(SortArray(SortBox.SelectedIndex).IndexOf(i)) = 8 Then
                        Alphebetised.Add(SortArray(SortBox.SelectedIndex).IndexOf(i))
                    End If
                Case Else
                    Alphebetised.Add(SortArray(SortBox.SelectedIndex).IndexOf(i))
            End Select
        Next
    End Sub
    Private Sub SortBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SortBox.SelectedIndexChanged
        FillPanels()
    End Sub
    Private Sub FilterBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterBox.SelectedIndexChanged
        FillPanels()
    End Sub
End Class