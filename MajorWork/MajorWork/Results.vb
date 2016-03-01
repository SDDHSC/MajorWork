Public Class results
    Private Sub results_Load(sender As Object, e As EventArgs) Handles Me.Load
        resultsProfile.TopLevel = False
        resultsRace.TopLevel = False
        Panel1.Controls.Add(resultsRace)
        resultsRace.Show()
    End Sub
End Class