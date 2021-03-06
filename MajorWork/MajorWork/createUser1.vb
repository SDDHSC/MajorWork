﻿Imports System.Data.OleDb
Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Public Class createUser
    Dim adpNamesUser As New OleDbDataAdapter
    Dim conNames As OleDbConnection
    Dim dataNames As New DataSet()

    Dim usedUsername As Boolean = False

    Dim approvedUsername As Boolean = False
    Dim approvedSecurityQuestion As Boolean = False
    Dim approvedpassword As Boolean = False
    Dim approvedAccessLevel As Boolean = False
    Private Sub newUser_Click(sender As Object, e As EventArgs) Handles newUser.Click
        resetPassword.TopLevel = False

        Main.Panel1.Controls.Add(resetPassword)

        resetPassword.Show()
        Me.Close()
    End Sub

    Private Sub createUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add elements to drop box for security questions
        securityQuestions.Items.Add("What is your favourite colour?")
        securityQuestions.Items.Add("What was your first pet?")
        securityQuestions.Items.Add("What was the suburb of your first home?")
        securityQuestions.Items.Add("What was your first teacher's name?")
        securityQuestions.Text = "What is your favourite colour?"

        txtNewPassword.PasswordChar = "*"
        txtConfirmPassword.PasswordChar = "*"
        buttonStyle(newUser)
        buttonStyle(saveNewUser)
    End Sub

    Private Sub saveNewUser_Click(sender As Object, e As EventArgs) Handles saveNewUser.Click
        approvedUsername = False
        approvedSecurityQuestion = False
        approvedpassword = False
        approvedAccessLevel = False
        Dim saveConfirm As Integer = MessageBox.Show("Are you sure you want to create this user? Changes cannot be undone", "Confirm", MessageBoxButtons.YesNo)
        If saveConfirm = DialogResult.Yes Then
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
            Dim table As DataTable = dataNames.Tables("tbLogin")

            checkUsername(table, approvedUsername)
            enterPassword(table)
            checkSecurityQuestionAnswer()
            userLevelSet(table)
            If approvedAccessLevel = True And approvedSecurityQuestion = True And approvedUsername = True And approvedpassword = True Then
                Try
                    Dim command As String
                    command = "INSERT INTO tbLogin(uName, pWord, aLevel, Hashed, Question, Answer) VALUES (@uname, @pword, @alevel, @hashed, @question, @answer)"
                    Dim cmd As OleDbCommand
                    cmd = New OleDbCommand(command, conNames)
                    cmd.Parameters.AddWithValue("uName", lblUsername.Text)
                    cmd.Parameters.AddWithValue("pWord", lblPassword.Text)
                    cmd.Parameters.AddWithValue("aLevel", lblUserLevel.Text)
                    cmd.Parameters.AddWithValue("Hashed", lblHashed.Text)
                    cmd.Parameters.AddWithValue("Question", lblSecurityQuestion.Text)
                    cmd.Parameters.AddWithValue("Answer", lblSecurityAnswer.Text)
                    cmd.ExecuteNonQuery()


                Catch exceptionobject As Exception
                    MessageBox.Show(exceptionobject.Message)
                End Try
            End If

        End If

        If approvedAccessLevel = True And approvedSecurityQuestion = True And approvedUsername = True And approvedpassword = True Then
            MessageBox.Show("User created!")
            resetPassword.TopLevel = False

            Main.Panel1.Controls.Add(resetPassword)

            resetPassword.Show()
            Me.Close()
        End If
    End Sub
    Sub checkUsername(table, approvedUserName)
        If txtUsername.Text = "" Then
            MessageBox.Show("Enter Username")
            currentDetails.ForeColor = Color.Red
        Else
            For Each row In table.rows
                If txtUsername.Text = row.item(1) Then
                    usedUsername = True
                    approvedUserName = True
                    currentDetails.ForeColor = Color.White
                End If
            Next
            If usedUsername = True Then
                MessageBox.Show("Username already used")
                currentDetails.ForeColor = Color.Red
            Else
                lblUsername.Text = txtUsername.Text
            End If
        End If
    End Sub
    Sub userLevelSet(table)
        If lblUserLevel.Text = "Blank" Then
            MessageBox.Show("Select a user level")
            userLevel.ForeColor = Color.Red
        Else
            approvedAccessLevel = True
        End If
    End Sub
    Sub checkSecurityQuestionAnswer()
        If txtConfirmAnswer.Text = "" Or txtNewAnswer.Text = "" Then
            MessageBox.Show("Enter an answer", "Confirm")
            groupSecurityQuestions.ForeColor = Color.Red
        Else
            'hash security question answer if client wants to
            'Dim tbLogin As DataTable = dataNames.Tables("tbLogin")
            'Dim tmpsource() As Byte
            'Dim tmpHash() As Byte
            'Dim tempAnswer As String = ""

            'tmpsource = ASCIIEncoding.ASCII.GetBytes(txtNewAnswer.Text)
            'tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpsource)
            'tempAnswer = ByteArrayToString(tmpHash)
            If txtConfirmAnswer.Text = txtNewAnswer.Text Then
                lblSecurityQuestion.Text = securityQuestions.Text
                lblSecurityAnswer.Text = txtNewAnswer.Text
                Try
                    'insert into database
                Catch
                    MessageBox.Show("Failed to change password", "Fail")
                End Try
            Else
                MessageBox.Show("Security Question answers do not match", "Not matched")
                groupSecurityQuestions.ForeColor = Color.Red
            End If

        End If
    End Sub
    Sub enterPassword(table)
        If txtConfirmPassword.Text = txtNewPassword.Text Then
            If txtConfirmPassword.Text = "" Then
                MessageBox.Show("Enter a password", "Confirm")
                groupPassword.ForeColor = Color.Red
            Else
                Dim tbLogin As DataTable = dataNames.Tables("tbLogin")
                Dim tmpsource() As Byte
                Dim tmpHash() As Byte
                Dim tempPassword As String = ""

                tmpsource = ASCIIEncoding.ASCII.GetBytes(txtNewPassword.Text)
                tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpsource)
                tempPassword = ByteArrayToString(tmpHash)
                Try
                    lblHashed.Text = "True"
                    lblPassword.Text = tempPassword
                Catch
                    MessageBox.Show("Failed to change password", "Fail")
                End Try
            End If
        Else
            MessageBox.Show("The two entered passwords do not match.", "Same password") 'ADD ICON
            groupPassword.ForeColor = Color.Red
            txtConfirmPassword.Text = ""
            txtNewPassword.Text = ""
        End If
    End Sub
    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Dim i As Integer
        Dim sOutput As New StringBuilder(arrInput.Length)
        For i = 0 To arrInput.Length - 1
            sOutput.Append(arrInput(i).ToString("X2"))
        Next
        Return sOutput.ToString()
    End Function
    Private Sub btnAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles btnAdmin.CheckedChanged
        lblUserLevel.Text = "3"

    End Sub

    Private Sub btnCoach_CheckedChanged(sender As Object, e As EventArgs) Handles btnCoach.CheckedChanged
        lblUserLevel.Text = "2"
    End Sub

    Private Sub btnStudent_CheckedChanged(sender As Object, e As EventArgs) Handles btnStudent.CheckedChanged
        lblUserLevel.Text = "1"
    End Sub
End Class