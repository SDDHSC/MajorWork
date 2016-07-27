Imports System.Data.OleDb
Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Public Class resetPassword
    Dim adpNamesUser As New OleDbDataAdapter
    Dim conNames As OleDbConnection
    Dim dataNames As New DataSet()
    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        Dim saveConfirm As Integer = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo)
        If saveConfirm = DialogResult.Yes Then
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

            Dim tbLogin As DataTable = dataNames.Tables("tbLogin")
            Dim tmpsource() As Byte
            Dim tmpHash() As Byte
            Dim tempPassword As String = ""

            For Each row In tbLogin.Rows
                'tmpsource = ASCIIEncoding.ASCII.GetBytes(txtNewPassword) 'txtbox
                'tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpsource)
                'tempPassword = ByteArrayToString(tmpHash)
                'Try
                '    'Dim command As String
                '    'command = "INSERT INTO tbLogin(pWord) VALUES (@first)"
                '    'Dim cmd As OleDbCommand
                '    'cmd = New OleDbCommand(command, conNames)
                '    'cmd.Parameters.AddWithValue("pWord", tempPassword)
                '    'cmd.ExecuteNonQuery()
                '    Dim cb As New OleDb.OleDbCommandBuilder(adpNamesUser)
                '    row.item(2) = tempPassword
                '    row.item(4) = "True"
                '    adpNamesUser.Update(dataNames, "tbLogin")
                'Catch

                'End Try
            Next

        End If
    End Sub

    Private Sub resetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class