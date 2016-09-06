Imports System.Data.OleDb
Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Public Class resetPassword
    Dim adpNamesUser As New OleDbDataAdapter
    Dim conNames As OleDbConnection
    Dim dataNames As New DataSet()
    Dim currentPasswordChecked As Boolean = False
    Dim foundUser As Boolean = False
    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        If currentPasswordChecked = False Then
            loadDatabase()

            Dim tmpsource() As Byte     'hashes input password
            Dim tmpHash() As Byte
            Dim tempPassword As String = txtCurrentPassword.Text
            tmpsource = ASCIIEncoding.ASCII.GetBytes(tempPassword)
            tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpsource)
            tempPassword = ByteArrayToString(tmpHash)

            Dim tbLogin As DataTable = dataNames.Tables("tbLogin")
            For Each row In tbLogin.Rows
                If foundUser = False Then
                    If txtUsername.Text = row.item(1) And tempPassword = row.item(2) Then
                        foundUser = True
                    Else
                        foundUser = False
                    End If
                End If
            Next

            If foundUser = True Then   'username and password entered correctly
                txtUsername.Enabled = False
                txtCurrentPassword.Enabled = False
                txtNewPassword.Enabled = True
                txtConfirmPassword.Enabled = True
                currentPasswordChecked = True
                currentDetails.ForeColor = Color.DimGray
                groupNewPasswords.ForeColor = Color.White
            Else        'username and password entered incorrectly
                MessageBox.Show("Incorrect username or password. Try again.", "Try again")
            End If
        ElseIf currentPasswordChecked = True Then
            If txtConfirmPassword.Text = txtNewPassword.Text Then
                If txtConfirmPassword.Text = "" Then
                    MessageBox.Show("Enter a password", "Confirm")
                Else
                    Dim saveConfirm As Integer = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo)
                    If saveConfirm = DialogResult.Yes Then
                        Dim tbLogin As DataTable = dataNames.Tables("tbLogin")
                        Dim tmpsource() As Byte
                        Dim tmpHash() As Byte
                        Dim tempPassword As String = ""

                        For Each row In tbLogin.Rows
                            If row.item(1) = txtUsername.Text Then 'sucessfully changes password     
                                tmpsource = ASCIIEncoding.ASCII.GetBytes(txtNewPassword.Text)
                                tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpsource)
                                tempPassword = ByteArrayToString(tmpHash)
                                Try
                                    Dim cb As New OleDbCommandBuilder(adpNamesUser)
                                    row.item(2) = tempPassword
                                    row.item(4) = "True"
                                    adpNamesUser.Update(dataNames, "tbLogin")
                                    MessageBox.Show("Successfully changed password", "Success")
                                    currentForm = New Calendar
                                    Main.buttonClick(Main.calendarButton)
                                Catch
                                    MessageBox.Show("Failed to change password", "Fail")
                                End Try
                            End If
                        Next
                    End If
                End If
            Else
                MessageBox.Show("The two entered passwords do not match. Try again", "Same password") 'ADD ICON
                txtConfirmPassword.Text = ""
                txtNewPassword.Text = ""
            End If
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
    Private Sub resetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        styleForm(Me)
        txtUsername.Enabled = True
        txtCurrentPassword.Enabled = True
        txtNewPassword.Enabled = False
        txtConfirmPassword.Enabled = False
        txtCurrentPassword.PasswordChar = "*"
        txtConfirmPassword.PasswordChar = "*"
        txtNewPassword.PasswordChar = "*"
        groupNewPasswords.ForeColor = Color.DimGray
        currentDetails.ForeColor = Color.White
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

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub

    Private Sub newUser_Click(sender As Object, e As EventArgs) Handles newUser.Click
        openForm(Me, New createUser)
    End Sub
End Class