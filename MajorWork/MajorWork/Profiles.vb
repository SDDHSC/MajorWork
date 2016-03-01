Public Class Profiles
    Private Sub Profiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_rowingDatabase__1_DataSet.tbProfiles' table. You can move, or remove it, as needed.
        Me.TbProfilesTableAdapter.Fill(Me._rowingDatabase__1_DataSet.tbProfiles)
        styleForm(Me)

    End Sub
End Class