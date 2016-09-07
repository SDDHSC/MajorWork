Imports System.Data.OleDb
Public Class NewEvent
    Dim dataResults As New DataSet()
    Dim eLocation, eventID, eDate, Participants, wLocation, sTime As String             'Defines all the elements of the database as string
    Dim infoLabels As List(Of Label)                                                    'list of labels used for help text
    Dim locationSearched As Boolean = False

    Public Property Url As Uri

    Private Sub NewEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load     'Loads NewEvent Form either reading info from a selected event or blank to create a new event
        Me.TopMost = True

        infoLabels = New List(Of Label) From {info1, info2, info3, info4, info5, info6, info7, info8, info9, info10, info11} 'Is a list of labels used for help text

        If eventSelected = True Then                                                    'If there was an event selected then NewEvent is repurposed to show details as opposed to create them

            WebBrowser1.Navigate(selectedEvent(4))                                      'Navigates the web-browser to the google maps URL of the location they selected earlier
            txtLocation.Text = selectedEvent(0)

            Dim splitDate As String() = selectedEvent(1).Split(New Char() {"/"c})       'splits the date into 3 individual sections
            cmbDay.Text = splitDate(0)
            cmbMonth.Text = splitDate(1)
            cmbYear.Text = splitDate(2)

            Dim splitTime As String() = selectedEvent(2).Split(New Char() {"."c})       'Splits the time into 3 individual sections
            numHour.Value = splitTime(0)
            numMinute.Value = splitTime(1)
            cmbAm.Text = splitTime(2)

            If selectedEvent(3).Contains("Y8") = True Then                              'Checks for participation by crew group
                cboxParticipants1.CheckState = CheckState.Checked
            End If
            If selectedEvent(3).Contains("Y9") = True Then
                cboxParticipants2.CheckState = CheckState.Checked
            End If
            If selectedEvent(3).Contains("Y10") = True Then
                cboxParticipants3.CheckState = CheckState.Checked
            End If
            If selectedEvent(3).Contains("1st") = True Then
                cboxParticipants4.CheckState = CheckState.Checked
            End If

            txtEName.Text = selectedEvent(6)

            txtEName.Enabled = False                                                    'disables all elements on the form to make it view only
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
            cboxParticipants4.Enabled = False
            btnCancel.Text = "Back"
            btnFinish.Visible = False
            btnSearch.Enabled = False
            btnSearch.Visible = False
            FilterInfo.Enabled = False
            FilterInfo.Visible = False

            If accessLevel > 0 Then                                                     'If access level is high enough show the "delete" and "edit" event buttons
                btnEdit.Visible = True
                btnDelete.Visible = True
            Else
                btnEdit.Visible = False
                btnDelete.Visible = False

            End If
        Else
            btnEdit.Visible = False                                                     'If an event has not been selected do not show the delete or edit button regardless of accesslevel as an event is being created
            btnDelete.Visible = False
        End If
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles btnSearch.Click     'On click of the "search" button navigates the user to the google maps page of the location they entered
        WebBrowser1.Navigate("https://www.google.com.au/maps/search/" + txtLocation.Text)
        locationSearched = True
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click   'When the user clicks "Save" it checks that all feilds are filled out


        'If txtEName.Text = "" Or locationSearched = False Or (String.IsNullOrEmpty(cmbDay.Text)) = True Or (String.IsNullOrEmpty(cmbMonth.Text)) = True Or (String.IsNullOrEmpty(cmbYear.Text)) = True Or numHour.Value = 0 And cboxParticipants1.CheckState = 0 And cboxParticipants2.CheckState = 0 And cboxParticipants3.CheckState = 0 And cboxParticipants4.CheckState = 0 Then
        If txtEName.Text = "" Or locationSearched = False Or (String.IsNullOrEmpty(cmbDay.Text)) = True Or (String.IsNullOrEmpty(cmbMonth.Text)) = True Or (String.IsNullOrEmpty(cmbYear.Text)) = True Or numHour.Value = 0 Or (cboxParticipants1.Checked = False And cboxParticipants2.Checked = False And cboxParticipants3.Checked = False And cboxParticipants4.Checked = False) Then

            Dim Response = MsgBox("You must complete all fields to save this event.", MsgBoxStyle.OkOnly, Title:="Incomplete Field")
            'If all field are not completed an error prompt will appear promting the user to fill all fields
        Else
            If eventSelected = True Then                                                'If an event has been slected the record is updated
                updateR()
            Else
                newr()                                                                  'If a new event is being created a new record is added
            End If

            Me.Close()                                                                  'Closes on completion 
        End If
    End Sub

    Public Sub newr()
        Dim dataResults As New DataSet()
        Dim strLocation, strEDate, strSTime, strParticipants, strWLocation, streventID, strEName, strPath, strUrl, strMinute As String 'Defines all the string versions of the elements of a new event record
        Dim maxEventID As Integer = 0                                                   'Defines the variable used to show the highest eventID in theDB

        strUrl = WebBrowser1.Url.ToString()
        strLocation = txtLocation.Text
        strEDate = CStr(cmbDay.Text) + "/" + CStr(cmbMonth.Text) + "/" + CStr(cmbYear.Text)

        strMinute = numMinute.Value                                                     'Alters the minutes value from "0" to "00" if it is simply left as "0"
        If numMinute.Value = 0 Then
            strMinute = "00"
        End If

        strSTime = CStr(numHour.Value) + "." + strMinute + "." + CStr(cmbAm.Text)       'Time is created by combining the 3 individual values of hour, minute and AM/PM
        strParticipants = ""
        strWLocation = strUrl
        strEName = txtEName.Text
        streventID = CStr(newEventID() + 1)

        If cboxParticipants1.Checked = True Then                                        'Checks which checkboxes are selected and adds the appropriate values to strParticipants
            strParticipants += "Y8/"
        End If
        If cboxParticipants2.Checked = True Then
            strParticipants += "Y9/"
        End If
        If cboxParticipants3.Checked = True Then
            strParticipants += "Y10/"
        End If
        If cboxParticipants4.Checked = True Then
            strParticipants += "1st/"
        End If
        'SQL statement used to insert the information defined above into the DB
        Dim Sql = "INSERT INTO [tbEvents] ([Location],[eDate],[sTime],[Participants],[wLocation],[eventID],[eName]) VALUES (@Location, @eDate, @sTime, @Participants, @wLocation, @eventID, @eName)"

        strPath = "|DataDirectory|\rowingDatabase (1).accdb"                            'Location of the DB to be connected to

        Dim conDatabase = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                            & "DATA SOURCE=" _
                            & strPath)                                                  'Creates a connection with the DB
        Dim DBInsert As New OleDbCommand(Sql, conDatabase)                              'Sets DBInsert as a command which uses the connection defined above and the SQL statement defined above

        conDatabase.Open()                                                              'Opens DB

        Try
            DBInsert.Parameters.AddWithValue("@Location", strLocation)                  'Adds values to corresponding columns in the DB
            DBInsert.Parameters.AddWithValue("@eDate", strEDate)
            DBInsert.Parameters.AddWithValue("@sTime", strSTime)
            DBInsert.Parameters.AddWithValue("@Participants", strParticipants)
            DBInsert.Parameters.AddWithValue("@wLocation", strWLocation)
            DBInsert.Parameters.AddWithValue("@eventID", streventID)
            DBInsert.Parameters.AddWithValue("@eName", strEName)

            DBInsert.ExecuteNonQuery()                                                  'Executes SQL query

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message.ToString(), "Error Message")                              'Presents error message in case of error
        End Try
        conDatabase.Close()                                                             'Closes the connection to the DB

        MsgBox("New event successfully added")                                          'User feedback confirming the success of their addition
    End Sub

    Public Sub updateR()
        Dim dataResults As New DataSet()
        Dim strLocation, strEDate, strSTime, strParticipants, strWLocation, streventID, strEName, strPath, strUrl, strMinute As String 'Defines all the string versions of the elements of a new event record
        Dim maxEventID As Integer = 0                                                   'Defines the variable used to show the highest eventID in theDB
        Dim DBConn As OleDbConnection                                                   'Defines DBConn as connection to a DB
        Dim dbCommand As New OleDbCommand()                                             'Defines dbCommand as a DB command

        strUrl = WebBrowser1.Url.ToString()
        strLocation = txtLocation.Text
        strEDate = CStr(cmbDay.Text) + "/" + CStr(cmbMonth.Text) + "/" + CStr(cmbYear.Text) 'Date is created by combinign the 3 individual values of day, month and year

        strMinute = numMinute.Value
        If numMinute.Value = 0 Then
            strMinute = "00"
        End If

        strSTime = CStr(numHour.Value) + "." + strMinute + "." + CStr(cmbAm.Text)       'Time is created by combining the 3 individual values of hour, minute and AM/PM
        strParticipants = ""
        strWLocation = strUrl
        strEName = txtEName.Text
        streventID = CStr(newEventID() + 1)

        If cboxParticipants1.Checked = True Then                                        'Checks which checkboxes are selected and adds the appropriate values to strParticipants
            strParticipants += "Y8/"
        End If
        If cboxParticipants2.Checked = True Then
            strParticipants += "Y9/"
        End If
        If cboxParticipants3.Checked = True Then
            strParticipants += "Y10/"
        End If
        If cboxParticipants4.Checked = True Then
            strParticipants += "1st/"
        End If

        Try
            strPath = "|DataDirectory|\rowingDatabase (1).accdb"                        'Location of the DB to be connected to
            DBConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                                    & "DATA SOURCE=" _
                                    & strPath)                                          'Creates a connection with the DB
            dbCommand.CommandText = "Update [tbEvents] Set " _
            & "[Location]='" & strLocation & "', " _
            & "[eDate]='" & strEDate & "', " _
            & "[sTime]='" & strSTime & "', " _
            & "[Participants]='" & strParticipants & "', " _
            & "[wLocation]='" & strWLocation & "', " _
            & "[eName]='" & strEName & "' " _
            & "WHERE [eventID]=" & selectedEvent(5)                                     'updates values in the corresponding columns in the DB

            dbCommand.Connection = DBConn
            dbCommand.Connection.Open()                                                 'Opens connection to the DB
            dbCommand.ExecuteNonQuery()                                                 'Executes SQL comment
            DBConn.Close()                                                              'Closes connection to the DB

        Catch err As System.Exception                                                   'Prompts the users with a message box detailing any errors that may have occured
            MsgBox(err.Message)
        End Try

        eventSelected = False                                                           'Sets eventSelected to false as we return to the Calendar form
        MsgBox("Event successfully updated")                                            'User feedback confirming the success of their addition
    End Sub

    Private Function newEventID()
        Dim strPath As String
        Dim maxEventID As Integer = 0
        strPath = "|DataDirectory|\rowingDatabase (1).accdb"                            'Location of the DB
        Dim conDatabase = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                            & "DATA SOURCE=" _
                            & strPath)                                                  'Defines conDatabase as the connection to the DB located above 

        conDatabase.Open()                                                              'Opens connection to the DB

        Dim adp As New OleDbDataAdapter
        adp = New OleDbDataAdapter()
        adp.SelectCommand = New OleDbCommand()
        With adp.SelectCommand
            .Connection = conDatabase
            .CommandText = "select * from tbEvents"                                     'table name
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With

        Dim reader As OleDbDataReader = adp.SelectCommand.ExecuteReader()

        While reader.Read()                                                             'every time it runs reader.read, it moves onto the next record
            Dim row(1) As String                                                        'row(1) is a list of strings that is two long, because index at 0 
            row(0) = CStr(reader(5))                                                    'reader(1) gets the value at 1 of the current record

            If CInt(reader(5)) > maxEventID Then                                        'If the the eventID of the current event is larger than MaxEventID then MaxEventID becomes that higher value
                maxEventID = reader(5)
            End If
        End While
        Return maxEventID                                                               'Returns "maxEventID" which is the largest eventID value in the DB

        reader.Close()                                                                  'Closes reader
        conDatabase.Close()                                                             'Closes connection to the DB
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        eventSelected = False                                                           'If the user clicks cancel after entering the newEvent form eventSelected is reverted
        Me.Close()                                                                      'Closes newEvent form
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click   'Clicking the edit button unlocks all feilds to allow for changes
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
        cboxParticipants4.Enabled = True
        btnCancel.Text = "Cancel"
        btnFinish.Visible = True
        btnEdit.Visible = False                                                         'Hides the edit button once selected
        btnSearch.Enabled = True
        btnSearch.Visible = True
        FilterInfo.Enabled = True
        FilterInfo.Visible = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'When the user clicks the delete button they prompted if they are sure. Upon confirmation the selected record is deleted
        Dim DBConn As OleDbConnection                                                   'DBConn defined as connection to a DB
        Dim dbCommand As New OleDbCommand()

        Dim Response = MsgBox("Are you sure you wish to delete this event?", MsgBoxStyle.YesNo, Title:="Delete")
        If Response = vbYes Then                                                        'Prompts the user if they are sure they wish to delete the event, If yes is selected it is deleted from the DB
            Try
                Dim strPath As String = "|DataDirectory|\rowingDatabase (1).accdb"      'Location of the DB
                DBConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                                        & "DATA SOURCE=" _
                                        & strPath)                                      'DBConn defined as the connection to DB specified above
                dbCommand.CommandText = "Delete from [tbEvents] WHERE eventID=" & selectedEvent(5) 'SQL statement to delete the event from the DB

                dbCommand.Connection = DBConn
                dbCommand.Connection.Open()                                             'Opens connection to the DB
                dbCommand.ExecuteNonQuery()                                             'Executes SQL comment
                DBConn.Close()                                                          'Closes connection to the DB

            Catch err As System.Exception                                               'Prompts the users with a message box detailing any errors that may have occured
                MsgBox(err.Message)
            End Try
        End If

        eventSelected = False                                                           'Sets eventSelected to false as we return to the Calendar form
        Me.Close()                                                                      'Closes newEvent Form
    End Sub

    Private Sub FilterInfo_Enter(sender As Object, e As EventArgs) Handles FilterInfo.MouseEnter 'Mouse Hover shows the help text
        For Each label As Label In infoLabels                                           'Goes through every label in the list InfoLabels and makes them visible 
            label.Visible = True
            label.ForeColor = Color.Black
        Next

        If eventSelected = True And accessLevel > 0 Then                                'If accesslevel allows makes visible the help for the delete button
            info9.Visible = True
        Else
            info9.Visible = False
        End If

        Label1.Visible = False                                                          'Hides all major labels while help is being shown to reduce clutter on screen
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub FilterInfo_Leave(sender As Object, e As EventArgs) Handles FilterInfo.MouseLeave  'Mouse leave hides the help text
        For Each label As Label In infoLabels                                           'Goes through every label in the list InfoLabels and makes them invisible
            label.Visible = False
        Next

        Label1.Visible = True                                                           'Reveals all major labels now that help is no longer being shown
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
    End Sub

    Private Sub newEvent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocation.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            WebBrowser1.Navigate("https://www.google.com.au/maps/search/" + txtLocation.Text)
            locationSearched = True
        End If
    End Sub
End Class