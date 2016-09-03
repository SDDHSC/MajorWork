Public Class Main
    Dim dictButtonForm As Dictionary(Of Button, Form)
    Dim currentForm = Login
    Dim currentButton
    Dim formList As New List(Of Form) From {Login, Calendar, results, Attendance, ProfilesView, resetPassword}

    Private Sub ButtonClick(sender As Button, e As EventArgs) Handles calendarButton.Click, resultsButton.Click, attendanceButton.Click, profilesButton.Click, ChangePasswordButton.Click, loginButton.Click
        If currentForm IsNot dictButtonForm(sender) Then
            currentButton.BackColor = schoolBlue
            currentButton = sender
            currentButton.BackColor = schoolBrown

            currentForm.hide()
            currentForm = dictButtonForm(sender)
            currentForm.Show()
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim buttonList = New List(Of Button) From {calendarButton, resultsButton, attendanceButton, profilesButton, ChangePasswordButton}
        dictButtonForm = New Dictionary(Of Button, Form) From {{loginButton, Login}, {calendarButton, Calendar}, {resultsButton, results},
                                                                {attendanceButton, Attendance}, {profilesButton, ProfilesView}, {ChangePasswordButton, resetPassword}}
        BackColor = schoolBlue
        For Each button In buttonList
            button.backColor = schoolBlue
        Next
        For Each form In formList
            form.TopLevel = False
            Me.Panel1.Controls.Add(form)
        Next
        Login.Show()
        loginButton.BackColor = schoolBrown
        currentButton = loginButton
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Results.MdiParent = Me
        Results.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
