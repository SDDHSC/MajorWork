﻿Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.OleDb
Public Class Login
    Dim pbImage1 As Image = My.Resources.rowing1
    Dim pbImage2 As Image = My.Resources.rowing2
    Dim accesslevel As Integer
    Dim tempUsername As String
    Dim tempPassword As String
    Dim loginSuccess As Boolean
    Dim loginattempts As Integer
    Dim lockedOut As Boolean
    Dim adpNamesUser As New OleDbDataAdapter
    Dim conNames As OleDbConnection
    Dim dataNames As New DataSet()

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = pbImage1
        loginattempts = 0
        lockedOut = False
        loginSuccess = False
        tempUsername = ""
        tempPassword = ""

        Dim tmpsource() As Byte
        Dim tmpHash() As Byte

        'hash all items in database if not already hashed
        loadDatabase()
        Dim tbLogin As DataTable = dataNames.Tables("tbLogin")
        For Each row In tbLogin.Rows
            If row.item(4) <> "True" Or row.item(4) Is Nothing Then
                tmpsource = ASCIIEncoding.ASCII.GetBytes(row.item(2))
                tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpsource)
                tempPassword = ByteArrayToString(tmpHash)
                Try
                    Dim cb As New OleDb.OleDbCommandBuilder(adpNamesUser)
                    row.item(2) = tempPassword
                    row.item(4) = "True"
                    adpNamesUser.Update(dataNames, "tbLogin")
                Catch exceptionobject As Exception
                    MessageBox.Show(exceptionobject.Message)
                End Try
                tempPassword = ""

            End If

        Next

        buttonStyle(btnLogin)
        buttonStyle(btnExit)

    End Sub

    'allows form to be moved around

    'Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

    '    If e.Button = MouseButtons.Left Then
    '        MoveForm = True
    '        MoveForm_MousePosition = e.Location
    '    End If

    'End Sub

    'Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

    '    If MoveForm Then
    '        Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
    '    End If

    'End Sub

    'Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

    '    If e.Button = MouseButtons.Left Then
    '        MoveForm = False
    '    End If

    'End Sub

    'focuses textbox and clearly switches username/password
    Private Sub txtUsername_lostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        tempUsername = txtUsername.Text
        If tempUsername = "" Then
            txtUsername.ForeColor = Color.Gray
            txtUsername.Text = "Username"
            txtUsername.PasswordChar = ""
        End If
    End Sub
    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        txtUsername.Text = tempUsername
        If txtUsername.Focused = True Then
            txtUsername.ForeColor = Color.Black
            txtUsername.MaxLength = 15
        End If
    End Sub
    Private Sub txtPassword_lostfocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        tempPassword = txtPassword.Text
        If tempPassword = "" Then
            txtPassword.ForeColor = Color.Gray
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
        End If
    End Sub
    Private Sub txtPassword_gotfocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.Text = tempPassword
        If txtPassword.Focused = True Then
            txtPassword.ForeColor = Color.Black
            txtPassword.PasswordChar = "*"
            txtPassword.MaxLength = 15
        End If
    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        openForm(Me, New ForgotPassword)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles AnimationRowingTimer.Tick
        'animation for rowing images
        If PictureBox1.Image Is pbImage1 Then
            PictureBox1.Image = pbImage2
        Else
            PictureBox1.Image = pbImage1
        End If
    End Sub

    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
        'converts hashed (encrypted) passwords to strings
        Dim i As Integer
        Dim sOutput As New StringBuilder(arrInput.Length)
        For i = 0 To arrInput.Length - 1
            sOutput.Append(arrInput(i).ToString("X2"))
        Next
        Return sOutput.ToString()
    End Function
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        loginConfirmation()
    End Sub


    Private Sub guestSignIn_Click(sender As Object, e As EventArgs) Handles guestSignIn.Click
        currentForm = New Calendar
        Main.buttonClick(Main.calendarButton)
        Main.accessLabel.Text = "Welcome: Guest"
        Main.loginButton.Text = "Logout"
    End Sub
    Sub loginConfirmation()
        'connect to database/table
        loadDatabase()

        Dim tbLogin As DataTable = dataNames.Tables("tbLogin")
        Dim tmpsource() As Byte
        Dim tmpHash() As Byte


        For Each row In tbLogin.Rows
            Dim tempUsername As String = txtPassword.Text   'hashes input password
            tmpsource = ASCIIEncoding.ASCII.GetBytes(tempUsername)
            tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpsource)
            tempUsername = ByteArrayToString(tmpHash)
            If txtUsername.Text = row.item(1) Then 'checks if username is in database
                If tempUsername = row.item(2) Then 'checks password and gives appropriate feedback 
                    loginSuccess = True
                    accesslevel = row.item(3)
                    GlobalVariables.accessLevel = accesslevel
                    Exit For
                End If
            End If
        Next

        If loginSuccess = True Then
            currentForm = Calendar
            Main.buttonClick(Main.calendarButton)
            Main.accessLabel.Text = "Welcome: " + tempUsername
            Main.loginButton.Text = "Logout"
        Else
            MessageBox.Show("Incorrect Username")
            loginattempts = loginattempts + 1
            If loginattempts = 4 Then
                MessageBox.Show("Incorrect password: one more attempt")
            Else
                If loginattempts > 4 Then
                    MessageBox.Show("Incorrect password: no more attempts. Program closed")
                    'lockedOut = True
                    Application.Exit()
                End If
            End If
        End If
    End Sub
    Sub loadDatabase()
        Dim connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb"
        conNames = New OleDbConnection(connectString)
        conNames.Open()
        adpNamesUser = New OleDbDataAdapter()
        adpNamesUser.SelectCommand = New OleDbCommand()
        With adpNamesUser.SelectCommand
            .Connection = conNames
            .CommandText = "select * FROM tbLogin"
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With
        adpNamesUser.Fill(dataNames, "tbLogin")
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginConfirmation()
        End If
    End Sub
    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginConfirmation()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim saveConfirm As Integer = MessageBox.Show("Are you sure? Changes cannot be undone", "Confirm", MessageBoxButtons.YesNo)
        If saveConfirm = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
