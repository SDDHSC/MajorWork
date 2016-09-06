Public Class Main
    Dim currentButton As Button
    Dim buttonList As Button()

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = Icon.FromHandle(My.Resources.BlankProfilePicture.GetHicon)
        buttonList = {calendarButton, resultsButton, attendanceButton, profilesButton, ChangePasswordButton}

        BackColor = schoolBlue
        For Each button In buttonList
            button.BackColor = schoolBlue
            button.Enabled = False
        Next
        currentForm = New Login
        currentButton = loginButton

        currentForm.TopLevel = False
        Me.Panel1.Controls.Add(currentForm)
        currentForm.Show()
        loginButton.BackColor = schoolBrown
        currentButton = loginButton
    End Sub

    Private Sub loginClick(sender As Button, e As EventArgs) Handles loginButton.Click
        If sender.Text = "Logout" Then
            If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                accessLevel = 0
                sender.Text = "Login"
                currentForm = New Login
                buttonClick(sender)
                accessLabel.Text = "No User Logged In"
            End If
        Else
            currentForm = New Login
            buttonClick(sender)
        End If
    End Sub
    Private Sub calendarButton_Click(sender As Object, e As EventArgs) Handles calendarButton.Click
        currentForm = New Calendar
        buttonClick(sender)
    End Sub
    Private Sub attendanceButton_Click(sender As Object, e As EventArgs) Handles attendanceButton.Click
        currentForm = New MainAttendance
        buttonClick(sender)
    End Sub
    Private Sub ChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordButton.Click
        currentForm = New resetPassword
        buttonClick(sender)
    End Sub
    Private Sub profilesButton_Click(sender As Object, e As EventArgs) Handles profilesButton.Click
        currentForm = New ProfilesView
        buttonClick(sender)
    End Sub
    Private Sub resultsButton_Click(sender As Object, e As EventArgs) Handles resultsButton.Click
        currentForm = New resultsRace
        buttonClick(sender)
    End Sub

    Public Sub buttonClick(button As Button)
        If button IsNot currentButton Then
            currentButton.BackColor = schoolBlue
            currentButton = button
            currentButton.BackColor = schoolBrown

            My.Application.OpenForms.Cast(Of Form)() _
          .Except({Me}) _
          .ToList() _
          .ForEach(Sub(form) form.Close())

            currentForm.TopLevel = False
            Me.Panel1.Controls.Add(currentForm)
            currentForm.Show()
        End If
    End Sub

    Private Sub accessLabel_Click(sender As Object, e As EventArgs) Handles accessLabel.TextChanged
        Try
            Dim temp
            If sender.Text <> "No User Logged In" Then
                temp = True
            Else
                temp = False
            End If

            For Each button In buttonList
                button.Enabled = True
            Next
        Catch
        End Try
    End Sub


End Class
