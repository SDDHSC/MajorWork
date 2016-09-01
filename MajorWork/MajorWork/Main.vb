Public Class Main
    Dim formTexts As New List(Of String) From {"Calendar", "Results", "Attendance", "Profiles", "Reset Password"}
    Dim buttonList
    Dim mainForms As New List(Of Form) From {Calendar, results, Attendance, ProfilesView, resetPassword}
    Dim currentForm = Login

    Private Sub ButtonClick(sender As Button, e As EventArgs) Handles calendarButton.Click, resultsButton.Click, attendanceButton.Click, profilesButton.Click, ChangePasswordButton.Click, loginButton.Click
        currentForm = mainForms(formTexts.FindIndex(Function(value As String)
                                                        Return value = sender.Text
                                                    End Function))
        For Each button In buttonList
            button.BackColor = schoolBlue
        Next
        sender.BackColor = schoolBrown
        For Each form In mainForms
            form.Hide()
        Next
        currentForm.TopLevel = False
        Me.Panel1.Controls.Add(currentForm)
        currentForm.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        buttonList = New List(Of Button) From {calendarButton, resultsButton, attendanceButton, profilesButton, ChangePasswordButton}
        'BackColor = schoolBlue
        loginButton.BackColor = schoolBlue
        calendarButton.BackColor = schoolBlue
        resultsButton.BackColor = schoolBlue
        attendanceButton.BackColor = schoolBlue
        profilesButton.BackColor = schoolBlue
        ChangePasswordButton.BackColor = schoolBlue
        'ButtonClick(loginButton, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Results.MdiParent = Me
        Results.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles resultsButton.Click, ChangePasswordButton.Click, calendarButton.Click, attendanceButton.Click

    End Sub
End Class
