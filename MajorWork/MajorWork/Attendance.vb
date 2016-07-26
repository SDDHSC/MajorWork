Public Class Attendance
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        styleForm(Me)
        mainPanelCheck.Hide()
        Absences.TopLevel = False
        MainAttendance.TopLevel = False
        newRoll.TopLevel = False
        markRoll.TopLevel = False
        Panel1.Controls.Add(Absences)
        Panel1.Controls.Add(MainAttendance)
        Panel1.Controls.Add(newRoll)
        Panel1.Controls.Add(markRoll)

        MainAttendance.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub mainPanelCheck_TextChanged(sender As Object, e As EventArgs) Handles mainPanelCheck.TextChanged
        If mainPanelCheck.Text = "newRoll Cancel" Or mainPanelCheck.Text = "attendance show" Or   'stick forms to panel
            mainPanelCheck.Text = "markRoll Save" Then
            MainAttendance.TopLevel = False
            Panel1.Controls.Add(MainAttendance)
            MainAttendance.Show()
        End If
        mainPanelCheck.Text = ""
    End Sub
End Class