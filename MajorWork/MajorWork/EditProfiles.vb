Imports System.Data.OleDb
Public Class EditProfiles
    Private Sub EditProfiles_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillData()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ProfilesView.ButtonFix()
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SideSeatValid As Boolean = False
        Dim TimeValid As Boolean = False
        Select Case cmbSide.SelectedIndex
            Case 0
                If cmbSeat.SelectedIndex Mod 2 <> 0 Then
                    Select Case MsgBox("Preferred side and preferred seat do not match. Are you sure you want to continue?", MsgBoxStyle.YesNo)
                        Case MsgBoxResult.Yes
                            SideSeatValid = True
                        Case Else
                            SideSeatValid = False
                    End Select
                Else
                    SideSeatValid = True
                End If
            Case 1
                If cmbSeat.SelectedIndex Mod 2 = 0 Then
                    Select Case MsgBox("Preferred side and preferred seat do not match. Are you sure you want to continue?", MsgBoxStyle.YesNo)
                        Case MsgBoxResult.Yes
                            SideSeatValid = True
                        Case Else
                            SideSeatValid = False
                    End Select
                Else
                    SideSeatValid = True
                End If
            Case Else
                SideSeatValid = True
        End Select
        Try
            Val(txt2k.Text(0))
            Val(txt2k.Text(1))
            Val(txt2k.Text(3))
            Val(txt2k.Text(4))
            TimeValid = True
        Catch ex As Exception
            MsgBox("2k time must be in MM:SS format. You must fix this before you can save.")
        End Try
        If TimeValid = True Then
            If SideSeatValid = True Then
                CheckChanges()
                SaveData()
            End If
        End If
    End Sub
    Private Sub EditProfiles_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim tempStr = SelectedRower
        ProfilesView.Button1.BackColor = schoolBlue
        ProfilesView.ReadDatabase()
        ProfilesView.SortBox.SelectedIndex = 0
        ProfilesView.FilterBox.SelectedIndex = 0
        ProfilesView.FillPanels()
        ProfilesView.RowerPanelClicked(ProfilesView.RowerBox.Controls.Item(ProfilesView.Sorted.IndexOf(ProfilesView.IDStr.IndexOf(tempStr))), EventArgs.Empty)
    End Sub
    Private Sub SaveData()
        Try
            Dim DBConn As OleDbConnection
            Dim dbCommand As New OleDbCommand()
            Dim strWeight, str2k, strBeep, strDiv, strSeat As String
            Dim strSide, strPath As String
            strWeight = numWeight.Value.ToString
            str2k = txt2k.Text
            strBeep = numBeep.Value.ToString
            Select Case cmbDivision.SelectedIndex
                Case 0
                    strDiv = 8.ToString
                Case 1
                    strDiv = 9.ToString
                Case 2
                    strDiv = 10.ToString
                Case Else
                    strDiv = 1.ToString
            End Select
            strSeat = cmbSeat.SelectedIndex.ToString
            strSide = cmbSide.SelectedIndex.ToString
            strPath = "|DataDirectory|\rowingDatabase (1).accdb"
            DBConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                                    & "DATA SOURCE=" _
                                    & strPath)
            dbCommand.CommandText = "Update [tbProfiles] Set " _
            & "[Weight]='" & strWeight & "', " _
            & "[2k]='" & str2k & "', " _
            & "[Beep]='" & strBeep & "', " _
            & "[Group]='" & strDiv & "', " _
            & "[Seat]='" & strSeat & "', " _
            & "[Side]='" & strSide & "' " _
            & "WHERE [ID]=" & SelectedRower
            dbCommand.Connection = DBConn
            dbCommand.Connection.Open()
            dbCommand.ExecuteNonQuery()
            DBConn.Close()
            Me.Close()
        Catch err As System.Exception
            MsgBox(err.Message)
        End Try
        ProfilesView.ButtonFix()
        Me.Close()
    End Sub
    Dim oWeight As Integer
    Dim o2k As String
    Dim oBeep As Integer
    Dim oSeat As Integer
    Dim oSide As Integer
    Dim oGroup As Integer
    Public Sub FillData()
        Try
            Dim dbConn As OleDbConnection
            Dim dbCommand As New OleDbCommand()
            Dim strPath As String
            strPath = "|DataDirectory|\rowingDatabase (1).accdb"
            dbConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                                    & "DATA SOURCE=" _
                                    & strPath)
            dbCommand.CommandText = "SELECT * FROM tbProfiles WHERE ID=" &
                                    SelectedRower
            dbCommand.Connection = dbConn
            dbConn.Open()
            Dim dbDR As OleDb.OleDbDataReader = dbCommand.ExecuteReader
            While dbDR.Read
                lblName.Text = dbDR("gName".ToString).ToUpper + ", " + dbDR("sName".ToString)
                numWeight.Value = dbDR("Weight")
                txt2k.Text = dbDR("2k".ToString)
                numBeep.Value = dbDR("Beep")
                Select Case dbDR("Group")
                    Case 1
                        cmbDivision.SelectedIndex = 3
                        oGroup = 3
                    Case 8
                        cmbDivision.SelectedIndex = 0
                        oGroup = 0
                    Case 9
                        cmbDivision.SelectedIndex = 1
                        oGroup = 1
                    Case 10
                        cmbDivision.SelectedIndex = 2
                        oGroup = 2
                End Select
                cmbSeat.SelectedIndex = dbDR("Seat")
                cmbSide.SelectedIndex = dbDR("Side")
            End While
            dbConn.Close()
        Catch err As System.Exception
            MsgBox(err.Message)
        End Try
        oWeight = numWeight.Value
        o2k = txt2k.Text
        oBeep = numBeep.Value
        oSeat = cmbSeat.SelectedIndex
        oSide = cmbSide.SelectedIndex
    End Sub
    Private Sub CheckChanges()
        If numWeight.Value <> oWeight Then
            LogChanges("W(" + oWeight.ToString + ">" + numWeight.Value.ToString + ")")
        End If
        If txt2k.Text <> o2k Then
            LogChanges("2(" + o2k + ">" + txt2k.Text + ")")
        End If
        If numBeep.Value <> oBeep Then
            LogChanges("B(" + oBeep.ToString + ">" + numBeep.Value.ToString + ")")
        End If
        If cmbSeat.SelectedIndex <> oSeat Then
            LogChanges("P(" + oSeat.ToString + ">" + cmbSeat.SelectedIndex.ToString + ")")
        End If
        If cmbSide.SelectedIndex <> oSide Then
            LogChanges("S(" + oSide.ToString + ">" + cmbSide.SelectedIndex.ToString + ")")
        End If
        If cmbDivision.SelectedIndex <> oGroup Then
            LogChanges("D(" + oGroup.ToString + ">" + cmbDivision.SelectedIndex.ToString + ")")
        End If
    End Sub
    Private Sub LogChanges(Change As String)
        Dim strPath As String = My.Application.Info.DirectoryPath + "\Log.txt"
        My.Computer.FileSystem.WriteAllText(strPath, SelectedRower & "@" & String.Format("{0:dd/MM/yyyy}", DateTime.Now) & "=" & Change & ",", True)
    End Sub
End Class