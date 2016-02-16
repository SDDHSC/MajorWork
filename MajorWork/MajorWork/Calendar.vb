Imports System.IO
Public Class Calendar

    Dim msgBoxResponse As MsgBoxResult
    Dim eventDate As String
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        eventDate = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        Try
            If File.Exists(eventDate & ".txt") = True Then
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                TextBox1.Enabled = True
                TextBox1.Show()
                Button1.Enabled = True
                Button1.Show()
                Button2.Enabled = True
                Button2.Show()
                TextBox1.Text = File.ReadAllText(eventDate & ".txt")
            Else
                msgBoxResponse = MsgBox("Would you Like To enter appointments for this date", MsgBoxStyle.YesNo)
                If msgBoxResponse = MsgBoxResult.Yes Then
                    MonthCalendar1.Enabled = False
                    MonthCalendar1.Hide()
                    TextBox1.Enabled = True
                    TextBox1.Show()
                    TextBox1.Text = ""
                    Button1.Enabled = True
                    Button1.Show()
                    Button2.Enabled = True
                    Button2.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Enabled = False
        TextBox1.Hide()
        Button1.Enabled = False
        Button1.Hide()
        Button2.Enabled = False
        Button2.Hide()
        MonthCalendar1.Enabled = True
        MonthCalendar1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Then
                If File.Exists(eventDate & ".txt") = True Then
                    File.Delete(eventDate & ".txt")
                End If
            End If
            If TextBox1.Text.Length > 0 Then
                File.WriteAllText(eventDate & ".txt", TextBox1.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msgBoxResponse1 As MsgBoxResult
        eventDate = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        If Date.Today = MonthCalendar1.TodayDate And File.Exists(eventDate & ".txt") = True Then
            msgBoxResponse1 = MsgBox("You have appointments set for today. Would you like to view them?", MsgBoxStyle.YesNo)
            If msgBoxResponse1 = MsgBoxResult.Yes Then
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                TextBox1.Enabled = True
                TextBox1.Show()
                Button1.Enabled = True
                Button1.Show()
                Button2.Enabled = True
                Button2.Show()
                TextBox1.Text = File.ReadAllText(eventDate & ".txt")
            End If
        End If

    End Sub
End Class