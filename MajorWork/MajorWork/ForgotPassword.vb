Imports System.Data.OleDb
Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Public Class ForgotPassword
    Dim usernameApproved As Boolean = False

    Dim adpNamesUser As New OleDbDataAdapter
    Dim conNames As OleDbConnection
    Dim dataNames As New DataSet()
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        openForm(Me, New Login)
    End Sub
    'customised button
    Public Sub buttonStyle(button As Button)
        button.FlatStyle = FlatStyle.Flat
        button.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
        button.ForeColor = Color.White
        button.BackColor = schoolBlue
        button.UseVisualStyleBackColor = True
    End Sub
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        groupNewPasswords.Enabled = False
        currentDetails.Enabled = True

        'init drop box
        SecurityQuestions.Items.Add("What is your favourite colour?")
        SecurityQuestions.Items.Add("What was your first pet?")
        SecurityQuestions.Items.Add("What was the suburb of your first home?")
        SecurityQuestions.Items.Add("What was your first teacher's name?")
        SecurityQuestions.Text = "What is your favourite colour?"

        'visually hides the password
        txtNewPassword.PasswordChar = "*"
        txtConfirmPassword.PasswordChar = "*"

        'set custom button
        buttonStyle(back)
        buttonStyle(btnNext)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'database connection
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

        If usernameApproved = False Then
            For Each row In table.Rows
                'appropriate user with correct security question and answer
                If txtUsername.Text = row.item(1) And SecurityQuestions.Text = row.item(5) And txtSecurityAnswer.Text = row.item(6) Then
                    usernameApproved = True
                    groupNewPasswords.Enabled = True
                    currentDetails.Enabled = False
                End If
            Next
            If usernameApproved = False Then
                MessageBox.Show("Incorrect Information")
            End If
        Else
            'check passwords match
            If txtConfirmPassword.Text = txtNewPassword.Text Then
                If txtConfirmPassword.Text = "" Then
                    MessageBox.Show("Enter a password", "Confirm")
                Else
                    Dim tbLogin As DataTable = dataNames.Tables("tbLogin")
                        Dim tmpsource() As Byte
                        Dim tmpHash() As Byte
                        Dim tempPassword As String = ""

                    For Each row In tbLogin.Rows
                        If row.item(1) = txtUsername.Text Then 'sucessfully changes password     
                            tmpsource = ASCIIEncoding.ASCII.GetBytes(txtNewPassword.Text) 'encrypt password
                            tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpsource)
                            tempPassword = ByteArrayToString(tmpHash)
                            Try
                                Dim cb As New OleDb.OleDbCommandBuilder(adpNamesUser) 'update database
                                row.item(2) = tempPassword
                                row.item(4) = "True"
                                adpNamesUser.Update(dataNames, "tbLogin")
                                MessageBox.Show("Successfully changed password. Restart program to apply changed password.", "Success")
                                openForm(Me, New Login)
                            Catch
                                MessageBox.Show("Failed to change password", "Fail")
                            End Try
                        End If
                    Next
                End If
            Else
                MessageBox.Show("Passwords do not match", "Confirm")
            End If
        End If
    End Sub
    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
        'converts hashed (encrypted) password to string
        Dim i As Integer
        Dim sOutput As New StringBuilder(arrInput.Length)
        For i = 0 To arrInput.Length - 1
            sOutput.Append(arrInput(i).ToString("X2"))
        Next
        Return sOutput.ToString()
    End Function
End Class