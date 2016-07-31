Public Class results
    Private Sub results_Load(sender As Object, e As EventArgs) Handles Me.Load
        resultsRace.TopLevel = False
        newRace.TopLevel = False
        Panel1.Controls.Add(resultsRace)
        Panel1.Controls.Add(newRace)
        resultsRace.Show()
    End Sub
End Class