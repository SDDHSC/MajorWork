Public Class Main
    Dim dictButtonForm As Dictionary(Of String, Form)
    Dim currentForm As Form
    Dim currentButton As Button

    Public Sub ButtonClick(sender As Button, e As EventArgs) Handles calendarButton.Click, resultsButton.Click, attendanceButton.Click, profilesButton.Click, ChangePasswordButton.Click, loginButton.Click
        Dim logout = True
        If sender.Text = "Logout" Then
            If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                accessLevel = 0
                sender.Text = "Login"
            Else
                logout = False
            End If
        End If
        If currentForm IsNot dictButtonForm(sender.Text) Then
            currentButton.BackColor = schoolBlue
            currentButton = sender
            currentButton.BackColor = schoolBrown

            currentForm.hide()
            currentForm = dictButtonForm(sender.Text)
            currentForm.toplevel = False
            Me.Panel1.Controls.Add(currentForm)
            currentForm.Show()
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim buttonList = New List(Of Button) From {calendarButton, resultsButton, attendanceButton, profilesButton, ChangePasswordButton}
        dictButtonForm = New Dictionary(Of String, Form) From {{loginButton.Text(), Login}, {calendarButton.Text(), Calendar}, {resultsButton.Text(), results},
                                                                {attendanceButton.Text(), Attendance}, {profilesButton.Text(), ProfilesView},
                                                                {ChangePasswordButton.Text(), resetPassword}}
        BackColor = schoolBlue
        For Each button In buttonList
            button.backColor = schoolBlue
        Next
        currentForm = Login
        currentButton = loginButton

        currentForm.TopLevel = False
        Me.Panel1.Controls.Add(currentForm)
        currentForm.show()
        loginButton.BackColor = schoolBrown
        currentButton = loginButton
    End Sub
End Class
