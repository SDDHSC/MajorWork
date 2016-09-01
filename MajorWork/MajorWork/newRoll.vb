Public Class newRoll
    Public myY7 As Integer
    Public myY8 As Integer
    Public myY9 As Integer
    Public myY10 As Integer
    Public myY11 As Integer
    Public myY12 As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Attendance.Show()
        Attendance.mainPanelCheck.Text = "newRoll Cancel"
        Me.Hide()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim radiopass As Boolean
        Dim checkpass As Boolean

        'Adds form to panel again after markroll.close()
        markRoll.TopLevel = False
        Attendance.Panel1.Controls.Add(markRoll)

        'Sets values in the markRoll form
        markRoll.sessionDate.Text = DateTimePicker1.Value
        If Erg.Checked = True Then
            markRoll.sessionType.Text = "Erg"
        End If
        If Running.Checked = True Then
            markRoll.sessionType.Text = "Running"
        End If
        If Rowing.Checked = True Then
            markRoll.sessionType.Text = "Rowing"
        End If
        If Weights.Checked = True Then
            markRoll.sessionType.Text = "Weights"
        End If
        If Other.Checked = True Then
            markRoll.sessionType.Text = "Other"
        End If

        markRoll.coachOfSession.Text = coachOfSession.Text

        'makes sure a button has to be selected in year group and session type
        If Year7.Checked = False And Year11.Checked = False And Year10.Checked = False And Year12.Checked = False And Year9.Checked = False And Year8.Checked = False Then
            checkpass = False
            lblCheckboxes.Show()
            MessageBox.Show("Select a year group", "Year Group", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        Else
            checkpass = True
            lblCheckboxes.Hide()
        End If

        If Erg.Checked = False And Running.Checked = False And Rowing.Checked = False And Weights.Checked = False And Other.Checked = False Then
            radiopass = False
            lblRadiobtn.Show()
            MessageBox.Show("Select a session type", "Session Type", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        Else
            radiopass = True
            lblRadiobtn.Hide()
        End If


        'MAKE MORE EFFICIENT. checks what buttons are selected, passes onto next form
        If Year7.Checked = True Then
            myY7 = 7
            markRoll.lblYearGroups.Text = markRoll.lblYearGroups.Text + ", " + "7"
        End If
        If Year8.Checked = True Then
            myY8 = 8
            markRoll.lblYearGroups.Text = markRoll.lblYearGroups.Text + ", " + "8"
        End If
        If Year9.Checked = True Then
            myY9 = 9
            markRoll.lblYearGroups.Text = markRoll.lblYearGroups.Text + ", " + "9"
        End If
        If Year10.Checked = True Then
            myY10 = 10
            markRoll.lblYearGroups.Text = markRoll.lblYearGroups.Text + ", " + "10"
        End If
        If Year11.Checked = True Then
            myY11 = 11
            markRoll.lblYearGroups.Text = markRoll.lblYearGroups.Text + ", " + "11"
        End If
        If Year12.Checked = True Then
            myY12 = 12
            markRoll.lblYearGroups.Text = markRoll.lblYearGroups.Text + ", " + "12"
        End If


        If radiopass = True And checkpass = True Then
            markRoll.lblYearGroups.Text = markRoll.lblYearGroups.Text.Remove(0, 3)
            markRoll.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub newRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRadiobtn.Hide()
        lblCheckboxes.Hide()

        'automatically pick todays date
        'dim [date] As DateTime = dateTimePicker1.Value.[Date]

        DateTimePicker1.Value = Now()
        DateTimePicker1.Value = Format(DateTimePicker1.Value, "dd-MM-yyyy")

        coachOfSession.Items.Add("Coach #1")
        coachOfSession.Items.Add("Coach #2")
        coachOfSession.Items.Add("Coach #3")
        coachOfSession.Text = "Coach #1"
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        lblRadiobtn.Hide()
    End Sub

    Private Sub yearGroups_Enter(sender As Object, e As EventArgs) Handles yearGroups.Enter
        lblCheckboxes.Hide()
    End Sub
End Class