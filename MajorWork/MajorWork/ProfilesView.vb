Imports System.Data.OleDb
Public Class ProfilesView
    Private Sub RowerPanelEnter(sender As Object, e As EventArgs)
        Dim entered As Panel = sender
        entered.BackColor = skyOrange
    End Sub
    Private Sub RowerPanelExit(sender As Object, e As EventArgs)
        Dim exited As Panel = sender
        exited.BackColor = schoolBlue
    End Sub
    Private Sub ProfilesView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim SelectedID As Integer = 400052841
        Dim IDNum As New List(Of Int32)
        Dim IDStr As New List(Of String)
        Dim gName As New List(Of String)
        Dim sName As New List(Of String)
        Dim yGroup As New List(Of String)
        Dim rClass As New List(Of String)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb")
            conn.Open()
            Using cmd As New OleDbCommand("SELECT ID, sName, gName, rClass, Group FROM tbProfiles", conn)
                Using dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        Do While dr.Read()
                            TextBox1.Text += dr.GetInt32(0).ToString + "    " + dr.GetString(1) + " " + dr.GetString(2) & vbCrLf
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
        For rower As Integer = 0 To IDNum.Count - 1
            Dim testPanel As New Panel With
                {
                    .Height = 50,
                    .Width = 140,
                    .BackColor = schoolBlue,
                    .Name = "rPanel" + rower.ToString
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
                'AddHandler testName2.MouseClick, AddressOf RowerPanelClicked
            End If
            'AddHandler testPanel.MouseClick, AddressOf RowerPanelClicked
            AddHandler testPanel.MouseEnter, AddressOf RowerPanelEnter
            AddHandler testPanel.MouseLeave, AddressOf RowerPanelExit
            'AddHandler testID.MouseClick, AddressOf RowerPanelClicked
            'AddHandler testName.MouseClick, AddressOf RowerPanelClicked
            RowerBox.Controls.Add(testPanel)
            testPanel.Controls.Add(testID)
            testPanel.Controls.Add(testName)
            testPanel.BringToFront()
        Next
    End Sub
End Class