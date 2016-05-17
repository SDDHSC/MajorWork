Imports System.Data.OleDb
Public Class ProfilesView
    Private Sub ProfilesView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim SelectedID As Integer = 400052841
        Dim IDNum As New List(Of Int32)
        Dim IDStr As New List(Of String)
        Dim gName As New List(Of String)
        Dim sName As New List(Of String)
        Dim yGroup As New List(Of String)
        Dim rClass As New List(Of String)
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb") 'add your access file to bin\debug and then repalce \athelte with \(name of your file)
            conn.Open() 'open the connection to the database
            Using cmd As New OleDbCommand("SELECT ID, sName, gName, rClass, Group FROM tbProfiles", conn) '*takes the column with correct rows
                'cmd.Parameters.Add(New OleDbParameter("madeupVariable", "variableYouNeedToFind")) 'maps your variable to that string
                Using dr = cmd.ExecuteReader() 'reads the database
                    If dr.HasRows Then 'checks if there are records that fulfill your criteria
                        Do While dr.Read() 'while loop that goes to eof
                            '*your function to perform*
                            '(access columns with dr(*index*) Or dr(*fieldName*))
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
        Dim i As Integer = 0
        'For Each ID As String In IDStr
        '    Dim lbl As New Label
        '    lbl.Size = New System.Drawing.Size(159, 23) 'set your size (if required)
        '    lbl.Location = New System.Drawing.Point(12, 180) 'set your location
        '    lbl.Text = "label text goes here" 'set the text for your label
        '    Me.Controls.Add(lbl)  'add your new control to your forms control collection
        '    lbl.Name = "DspRow" + i.ToString
        '    i = i + 1
        'Next

        For x As Integer = 0 To IDNum.Count - 1
            Dim testPanel As New Panel With
                {
                    .Height = 50,
                    .Width = 140,
                    .BackColor = schoolBlue,
                    .Name = "rPanel" + x.ToString
                }
            Dim testID As New Label With
                {
                    .Text = IDStr(x),
                    .Font = New Drawing.Font("Segoe UI", 9.75, FontStyle.Bold),
                    .Location = New Point(0, 0),
                    .Name = "rID" + x.ToString
                }
            Dim testName As New Label With
                {
                    .Text = gName(x).ToUpper + ", " + sName(x),
                    .Font = New Drawing.Font("Segoe UI", 8.75),
                    .Location = New Point(0, 20),
                    .Name = "rName" + x.ToString
                }
            RowerBox.Controls.Add(testPanel)
            testPanel.Controls.Add(testID)
            testPanel.Controls.Add(testName)
        Next



    End Sub
End Class