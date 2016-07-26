Imports System
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
        styleForm(Me)
        PictureBox1.Image = pbImage1
        loginattempts = 0
        lockedOut = False
        loginSuccess = False
        tempUsername = ""
        tempPassword = ""


        Dim tmpsource() As Byte
        Dim tmpHash() As Byte

        'hash all items in database
        loadDatabase()
        Dim tbLogin As DataTable = dataNames.Tables("tbLogin")

        For Each row In tbLogin.Rows
            MessageBox.Show(row.item(4))
            If row.item(4) <> "True" Or row.item(4) Is Nothing Then

                tmpsource = ASCIIEncoding.ASCII.GetBytes(row.item(2))
                tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpsource)
                tempPassword = ByteArrayToString(tmpHash)
                Try
                    'Dim command As String
                    'command = "INSERT INTO tbLogin(pWord) VALUES (@first)"
                    'Dim cmd As OleDbCommand
                    'cmd = New OleDbCommand(command, conNames)
                    'cmd.Parameters.AddWithValue("pWord", tempPassword)
                    'cmd.ExecuteNonQuery()
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

    End Sub


    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If

    End Sub

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



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.ForeColor = Color.Brown

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ForgotPassword.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles AnimationRowingTimer.Tick
        'animation for rowing images
        If PictureBox1.Image Is pbImage1 Then
            PictureBox1.Image = pbImage2
        Else
            PictureBox1.Image = pbImage1
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
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
        accesslevel = 0
        'main.show()
        'me.hide()
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
            If txtUsername.Text = row.item(1) Then  'checks password and gives appropriate feedback 
                If tempUsername = row.item(2) Then
                    loginSuccess = True
                    accesslevel = row.item(3)
                    lblLoginFeedback.Text = "Success"
                Else
                    lblLoginFeedback.Text = "incorrect password"
                    loginattempts += 1
                    If loginattempts = 4 Then
                        lblLoginFeedback.Text = "incorrect password: one more attempt"
                    Else
                        If loginattempts > 4 Then
                            lblLoginFeedback.Text = "incorrect password: no more attempts. program locked"
                            lockedOut = True
                        End If
                    End If
                End If
            Else
                lblLoginFeedback.Text = "incorrect username"
            End If
        Next
        If loginSuccess = True Then
            'main.show()
            'me.hide()
        End If
    End Sub
    Sub loadDatabase()
        Dim connectString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data source = " & Environment.CurrentDirectory & "\rowingDatabase.mdb"
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
End Class
