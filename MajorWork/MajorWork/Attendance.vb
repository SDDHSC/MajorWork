Public Class Attendance
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'init panels
        styleForm(Me)
        mainPanelCheck.Hide()
        openForm(Me, New MainAttendance)
    End Sub

    Private Sub mainPanelCheck_TextChanged(sender As Object, e As EventArgs) Handles mainPanelCheck.TextChanged
        'stick forms to panel
        If mainPanelCheck.Text = "newRoll Cancel" Or mainPanelCheck.Text = "attendance show" Or
            mainPanelCheck.Text = "markRoll Save" Then
            openForm(Me, New MainAttendance)
        End If
        mainPanelCheck.Text = ""
    End Sub
End Class