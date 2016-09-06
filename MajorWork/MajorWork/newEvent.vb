Imports System.Data.OleDb
Public Class NewEvent
    Dim dataResults As New DataSet()
    Dim eLocation, eventID, eDate, Participants, wLocation, sTime As String

    Public Property Url As Uri

    Private Sub NewEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If eventSelected = True Then

            WebBrowser1.Navigate(selectedEvent(4))
            txtLocation.Text = selectedEvent(0)

            Dim splitDate As String() = selectedEvent(1).Split(New Char() {"/"c})
            MsgBox(splitDate(0))
            MsgBox(splitDate(1))
            MsgBox(splitDate(2))

            cmbDay.Text = splitDate(0)
            cmbMonth.Text = splitDate(1)
            cmbYear.Text = splitDate(2)

            Dim splitTime As String() = selectedEvent(2).Split(New Char() {"."c})
            numHour.Value = splitTime(0)
            numMinute.Value = splitTime(1)
            cmbAm.Text = splitTime(2)

            If selectedEvent(3).Contains("Y8") = True Then
                cboxParticipants1.CheckState = CheckState.Checked
            End If
            If selectedEvent(3).Contains("Y9") = True Then
                cboxParticipants2.CheckState = CheckState.Checked
            End If
            If selectedEvent(3).Contains("Y10") = True Then
                cboxParticipants3.CheckState = CheckState.Checked
            End If

            txtEName.Text = selectedEvent(6)

        End If
        eventSelected = False
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        WebBrowser1.Navigate("https://www.google.com.au/maps/search/" + txtLocation.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strUrl As String
        strUrl = WebBrowser1.Url.ToString()
        MsgBox(strUrl)
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        newr()
        Me.Close()
    End Sub

    Public Sub newr()
        Dim dataResults As New DataSet()
        Dim strLocation, strEDate, strSTime, strParticipants, strWLocation, streventID, strEName, strPath, strUrl, strMinute As String
        Dim maxEventID As Integer = 0

        strUrl = WebBrowser1.Url.ToString()
        strLocation = txtLocation.Text
        strEDate = CStr(cmbDay.Text) + "/" + CStr(cmbMonth.Text) + "/" + CStr(cmbYear.Text)

        strMinute = numMinute.Value
        If numMinute.Value = 0 Then
            strMinute = "00"
        End If

        strSTime = CStr(numHour.Value) + "." + strMinute + "." + CStr(cmbAm.Text)
        strParticipants = ""
        strWLocation = strUrl
        strEName = txtEName.Text
        streventID = CStr(newEventID() + 1)

        If cboxParticipants1.Checked = True Then
            strParticipants += "Y8/"
        End If
        If cboxParticipants2.Checked = True Then
            strParticipants += "Y9/"
        End If
        If cboxParticipants3.Checked = True Then
            strParticipants += "Y10/"
        End If

        Dim Sql = "INSERT INTO [tbEvents] ([Location],[eDate],[sTime],[Participants],[wLocation],[eventID],[eName]) VALUES (@Location, @eDate, @sTime, @Participants, @wLocation, @eventID, @eName)"

        'strPath = "|DataDirectory|\rowingDatabase (1).accdb"
        strPath = "|DataDirectory|\rowingDatabase (1).accdb"

        Dim conDatabase = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                            & "DATA SOURCE=" _
                            & strPath)
        Dim DBInsert As New OleDbCommand(Sql, conDatabase)

        conDatabase.Open()
        'MsgBox(DBInsert)
        Try
            DBInsert.Parameters.AddWithValue("@Location", strLocation)
            DBInsert.Parameters.AddWithValue("@eDate", strEDate)
            DBInsert.Parameters.AddWithValue("@sTime", strSTime)
            DBInsert.Parameters.AddWithValue("@Participants", strParticipants)
            DBInsert.Parameters.AddWithValue("@wLocation", strWLocation)
            DBInsert.Parameters.AddWithValue("@eventID", streventID)
            DBInsert.Parameters.AddWithValue("@eName", strEName)

            DBInsert.ExecuteNonQuery()

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message.ToString(), "Error Message")
        End Try
        conDatabase.Close()

        MsgBox("Completed insert")
    End Sub

    Private Function newEventID()
        Dim strPath As String
        Dim maxEventID As Integer = 0
        strPath = "|DataDirectory|\rowingDatabase (1).accdb"
        Dim conDatabase = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                            & "DATA SOURCE=" _
                            & strPath)

        conDatabase.Open()

        Dim adp As New OleDbDataAdapter
        adp = New OleDbDataAdapter()
        adp.SelectCommand = New OleDbCommand()
        With adp.SelectCommand
            .Connection = conDatabase
            .CommandText = "select * from tbEvents" 'table name
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With

        Dim reader As OleDbDataReader = adp.SelectCommand.ExecuteReader()

        While reader.Read() 'every time it runs reader.read, it moves onto the next record
            Dim row(1) As String 'row(1) is a list of strings that is two long, because index at 0 
            row(0) = CStr(reader(5)) 'reader(1) gets the value at 1 of the current record

            If CInt(reader(5)) > maxEventID Then
                maxEventID = reader(5)
            End If
        End While
        Return maxEventID

        reader.Close()
        conDatabase.Close()
    End Function
End Class