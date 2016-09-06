Public Class resetPasswordPanel
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub resetPasswordPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        styleForm(Me)
        resetPassword.TopLevel = False
        Panel1.Controls.Add(resetPassword)

        resetPassword.Show()
    End Sub
End Class