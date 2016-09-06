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

            txtEName.Enabled = False
            cmbDay.Enabled = False
            cmbMonth.Enabled = False
            cmbYear.Enabled = False
            txtLocation.Enabled = False
            numHour.Enabled = False
            numMinute.Enabled = False
            cmbAm.Enabled = False
            cboxParticipants1.Enabled = False
            cboxParticipants2.Enabled = False
            cboxParticipants3.Enabled = False
            btnCancel.Text = "Back"
            btnFinish.Visible = False



            'If accessLevel > 0 Then
            btnEdit.Visible = True
            btnDelete.Visible = True
            'Else
            'btnEdit.Visible = False
            'btnDelete.Visible = False

            ' End If

        Else
            btnEdit.Visible = False
            btnDelete.Visible = False
        End If

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        WebBrowser1.Navigate("https://www.google.com.au/maps/search/" + txtLocation.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim strUrl As String
        strUrl = WebBrowser1.Url.ToString()
        MsgBox(strUrl)
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        If eventSelected = True Then
            updateR()
        Else
            newr()
        End If

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

        strPath = "|DataDirectory|\rowingDatabase (1).accdb"

        Dim conDatabase = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                            & "DATA SOURCE=" _
                            & strPath)
        Dim DBInsert As New OleDbCommand(Sql, conDatabase)

        conDatabase.Open()

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

    Public Sub updateR()
        Dim dataResults As New DataSet()
        Dim strLocation, strEDate, strSTime, strParticipants, strWLocation, streventID, strEName, strPath, strUrl, strMinute As String
        Dim maxEventID As Integer = 0
        Dim DBConn As OleDbConnection
        Dim dbCommand As New OleDbCommand()



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

        Try
            strPath = "|DataDirectory|\rowingDatabase (1).accdb"
            DBConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                                    & "DATA SOURCE=" _
                                    & strPath)
            dbCommand.CommandText = "Update [tbEvents] Set " _
            & "[Location]='" & strLocation & "', " _
            & "[eDate]='" & strEDate & "', " _
            & "[sTime]='" & strSTime & "', " _
            & "[Participants]='" & strParticipants & "', " _
            & "[wLocation]='" & strWLocation & "', " _
            & "[eName]='" & strEName & "' " _
            & "WHERE [eventID]=" & selectedEvent(5)

            MsgBox(dbCommand.CommandText)

            dbCommand.Connection = DBConn
            dbCommand.Connection.Open()
            dbCommand.ExecuteNonQuery()
            DBConn.Close()


        Catch err As System.Exception
            MsgBox(err.Message)
        End Try


        eventSelected = False
        Me.Close()

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        eventSelected = False
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtEName.Enabled = True
        cmbDay.Enabled = True
        cmbMonth.Enabled = True
        cmbYear.Enabled = True
        txtLocation.Enabled = True
        numHour.Enabled = True
        numMinute.Enabled = True
        cmbAm.Enabled = True
        cboxParticipants1.Enabled = True
        cboxParticipants2.Enabled = True
        cboxParticipants3.Enabled = True
        btnCancel.Text = "Cancel"
        btnFinish.Visible = True
        btnEdit.Visible = False


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim DBConn As OleDbConnection
        Dim dbCommand As New OleDbCommand()

        Dim Response = MsgBox("Are you sure you want to delete this event?", MsgBoxStyle.YesNo, Title:="Delete")

        If Response = vbYes Then


            Try
                Dim strPath As String = "|DataDirectory|\rowingDatabase (1).accdb"
                DBConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                                        & "DATA SOURCE=" _
                                        & strPath)
                dbCommand.CommandText = "Delete from [tbEvents] WHERE eventID=" & selectedEvent(5)


                dbCommand.Connection = DBConn
                dbCommand.Connection.Open()
                dbCommand.ExecuteNonQuery()
                DBConn.Close()


            Catch err As System.Exception
                MsgBox(err.Message)
            End Try
        End If

        eventSelected = False
        Me.Close()
    End Sub
End Class