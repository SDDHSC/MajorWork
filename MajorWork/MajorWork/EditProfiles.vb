Imports System.Data.OleDb
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
    Public Sub FillData()
        Try
            Dim dbConn As OleDbConnection
            Dim dbCommand As New OleDbCommand()
            Dim strPath As String

            strPath = "|DataDirectory|\rowingDatabase (1).accdb"
            dbConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
                                    & "DATA SOURCE=" _
                                    & strPath)
            dbCommand.CommandText = "SELECT * FROM tbProfiles WHERE ID=" &
                                    SelectedRower
            dbCommand.Connection = dbConn
            dbConn.Open()
            Dim dbDR As OleDb.OleDbDataReader = dbCommand.ExecuteReader

            While dbDR.Read
                lblName.Text = dbDR("gName".ToString).ToUpper + ", " + dbDR("sName".ToString)
                'txtFN.Text = dbDR("FName".ToString)
                'txtLN.Text = dbDR("LName".ToString)
                'txtAdd.Text = dbDR("Address".ToString)
                'txtCty.Text = dbDR("City".ToString)
                'txtSt.Text = dbDR("State".ToString)
                'txtDept.Text = dbDR("DeptId".ToString)
            End While

            dbConn.Close()

            'btnEdit.Enabled = True
            'btnDelete.Enabled = True

        Catch err As System.Exception
            MsgBox(err.Message)
        End Try
    End Sub

    Private Sub EditProfiles_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillData()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class