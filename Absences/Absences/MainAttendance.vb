Public Class MainAttendance
    Private Sub MainAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Attendance.MdiParent = Me
        Absences.MdiParent = Me
        newRoll.MdiParent = Me
        Attendance.Show()
    End Sub
End Class