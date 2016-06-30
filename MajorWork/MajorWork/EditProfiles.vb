Public Class EditProfiles
    Private Sub EditProfiles_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ProfilesView.Button1.BackColor = schoolBlue
    End Sub
    'Private Sub EditDatabase()
    '    Try
    '        Dim DBConn As OleDbConnection
    '        Dim dbCommand As New OleDbCommand()
    '        Dim strFN, strLN, strAdd, strCty, strSt As String
    '        Dim strDept, strPath As String
    '        strFN = txtFN.Text
    '        strLN = txtLN.Text
    '        strAdd = txtAdd.Text
    '        strCty = txtCty.Text
    '        strSt = txtSt.Text
    '        strDept = txtDept.Text
    '        strPath = txtPath.Text
    '        DBConn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" _
    '        & "DATA SOURCE=" _
    '        & strPath)
    '        dbCommand.CommandText = "Update Employee Set " _
    '        & "FName='" & strFN & "', " _
    '        & "LName='" & strLN & "', " _
    '        & "Address='" & strAdd & "', " _
    '        & "City='" & strCty & "', " _
    '        & "State='" & strSt & "', " _
    '        & "DeptId='" & strDept & "' " _
    '        & "WHERE idEmp=" & cboId.Text
    '        dbCommand.Connection = DBConn
    '        dbCommand.Connection.Open()
    '        dbCommand.ExecuteNonQuery()
    '        DBConn.Close()
    '        txtError.Text = "Guardado satisfactoriamente."
    '    Catch err As System.Exception
    '        txtError.Text = err.Message
    '    End Try
    'End Sub
End Class