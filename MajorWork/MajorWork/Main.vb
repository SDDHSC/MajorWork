Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Calendar.MdiParent = Me
        Calendar.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        styleForm(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Results.MdiParent = Me
        Results.Show()
    End Sub
End Class
