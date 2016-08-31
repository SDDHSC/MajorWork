Public Class Main
    Dim formTexts As New List(Of String) From {"Calendar", "Results", "Attendance", "Profiles", "Reset Password"}
    Dim mainForms As New List(Of Form) From {Calendar, results, Attendance, ProfilesView, resetPassword}

    Private Sub ButtonClick(sender As Button, e As EventArgs) Handles calendarButton.Click, resultsButton.Click, attendanceButton.Click, profilesButton.Click, ChangePasswordButton.Click
        Dim currentForm = mainForms(formTexts.FindIndex(Function(value As String)
                                                            Return value = sender.Text
                                                        End Function))
        For Each form In mainForms
            form.Hide()
        Next
        currentForm.TopLevel = False
        Me.Panel1.Controls.Add(currentForm)
        currentForm.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        BackColor = schoolBlue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Results.MdiParent = Me
        Results.Show()
    End Sub

    Private Sub settingsButton_Click(sender As Object, e As EventArgs) Handles settingsButton.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles resultsButton.Click, profilesButton.Click, calendarButton.Click, attendanceButton.Click

    End Sub
End Class
