Public Class formLogin
    Dim accesslevel As Integer

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        accesslevel = 0
        'mainmenu.show()
        Me.Hide()

    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Focus = True Then
            txtUsername.ForeColor = Color.Black
            txtUsername.Text = ""
        Else
            txtUsername.ForeColor = Color.Gray
            txtUsername.Text = "Username"
        End If

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.ForeColor = Color.Brown

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Image = My.Resources.rowing2
        WasteTime(1)
        PictureBox1.Image = My.Resources.rowing1
    End Sub
    Private Sub WasteTime(ByVal N As Integer)
        Dim Start As Date
        Start = TimeOfDay
        Do
        Loop Until DateDiff(DateInterval.Second, Start, TimeOfDay) >= N
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
