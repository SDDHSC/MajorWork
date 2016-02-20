Imports System.IO
Public Class Calendar

    Public Sub ReloadCal(ByVal ldate As Date, ByVal Selected As Integer)
        On Error Resume Next
        Me.clearall()
        MonthName.Text = monthstr(ldate.Month)
        Dim fdate As DayOfWeek = GetFirstOfMonthDay(ldate)
        Dim idate As Integer = 1
        Dim row As Integer = 1
        Do
            getlabel(fdate, row).Text = idate
            getlabel(fdate, row).ForeColor = Label18.ForeColor
            If idate = Selected Then
                getlabel(fdate, row).ForeColor = Color.Red
            End If
            If fdate = DayOfWeek.Sunday Then
                row += 1
            End If
            fdate = tdate(fdate)
            idate += 1
            If idate = Date.DaysInMonth(ldate.Year, ldate.Month) + 1 Then
                Exit Do
            End If
        Loop
    End Sub


    Sub clearall()
        su1.Text = ""
        su2.Text = ""
        su3.Text = ""
        su4.Text = ""
        su5.Text = ""
        su6.Text = ""

        m1.Text = ""
        m2.Text = ""
        m3.Text = ""
        m4.Text = ""
        m5.Text = ""
        m6.Text = ""

        tu1.Text = ""
        tu2.Text = ""
        tu3.Text = ""
        tu4.Text = ""
        tu5.Text = ""
        tu6.Text = ""

        w1.Text = ""
        w2.Text = ""
        w3.Text = ""
        w4.Text = ""
        w5.Text = ""
        w6.Text = ""

        th1.Text = ""
        th2.Text = ""
        th3.Text = ""
        th4.Text = ""
        th5.Text = ""
        th6.Text = ""

        f1.Text = ""
        f2.Text = ""
        f3.Text = ""
        f4.Text = ""
        f5.Text = ""
        f6.Text = ""

        sa1.Text = ""
        sa2.Text = ""
        sa3.Text = ""
        sa4.Text = ""
        sa5.Text = ""
        sa6.Text = ""
    End Sub

    Function getlabel(ByVal day As DayOfWeek, ByVal row As Integer) As System.Windows.Forms.Label
        Select Case day
            Case DayOfWeek.Sunday
                Select Case row
                    Case 1
                        Return su1
                    Case 2
                        Return su2
                    Case 3
                        Return su3
                    Case 4
                        Return su4
                    Case 5
                        Return su5
                    Case 6
                        Return su6
                End Select
            Case DayOfWeek.Monday
                Select Case row
                    Case 1
                        Return m1
                    Case 2
                        Return m2
                    Case 3
                        Return m3
                    Case 4
                        Return m4
                    Case 5
                        Return m5
                    Case 6
                        Return m6
                End Select
            Case DayOfWeek.Tuesday
                Select Case row
                    Case 1
                        Return tu1
                    Case 2
                        Return tu2
                    Case 3
                        Return tu3
                    Case 4
                        Return tu4
                    Case 5
                        Return tu5
                    Case 6
                        Return tu6
                End Select
            Case DayOfWeek.Wednesday
                Select Case row
                    Case 1
                        Return w1
                    Case 2
                        Return w2
                    Case 3
                        Return w3
                    Case 4
                        Return w4
                    Case 5
                        Return w5
                    Case 6
                        Return w6
                End Select
            Case DayOfWeek.Thursday
                Select Case row
                    Case 1
                        Return th1
                    Case 2
                        Return th2
                    Case 3
                        Return th3
                    Case 4
                        Return th4
                    Case 5
                        Return th5
                    Case 6
                        Return th6
                End Select
            Case DayOfWeek.Friday
                Select Case row
                    Case 1
                        Return f1
                    Case 2
                        Return f2
                    Case 3
                        Return f3
                    Case 4
                        Return f4
                    Case 5
                        Return f5
                    Case 6
                        Return f6
                End Select
            Case DayOfWeek.Saturday
                Select Case row
                    Case 1
                        Return sa1
                    Case 2
                        Return sa2
                    Case 3
                        Return sa3
                    Case 4
                        Return sa4
                    Case 5
                        Return sa5
                    Case 6
                        Return sa6
                End Select
        End Select

        Return Label18

    End Function

    Private Function GetFirstOfMonthDay(ByVal ThisDay As Date) As DayOfWeek
        Dim tday As DayOfWeek = ThisDay.DayOfWeek
        Dim tint As Integer = ThisDay.Day
        If tint = 1 Then
            Return tday
            Exit Function
        End If
        Do
            tint -= 1
            tday = ydate(tday)
            If tint = 1 Then Exit Do
        Loop
        Return tday
    End Function

    Private Function ydate(ByVal tday As DayOfWeek) As DayOfWeek
        Dim rday As DayOfWeek
        Select Case tday
            Case DayOfWeek.Sunday
                rday = DayOfWeek.Saturday
            Case DayOfWeek.Monday
                rday = DayOfWeek.Sunday
            Case DayOfWeek.Tuesday
                rday = DayOfWeek.Monday
            Case DayOfWeek.Wednesday
                rday = DayOfWeek.Tuesday
            Case DayOfWeek.Thursday
                rday = DayOfWeek.Wednesday
            Case DayOfWeek.Friday
                rday = DayOfWeek.Thursday
            Case DayOfWeek.Saturday
                rday = DayOfWeek.Friday
        End Select
        Return rday
    End Function

    Private Function tdate(ByVal tday As DayOfWeek) As DayOfWeek
        Dim rday As DayOfWeek
        Select Case tday
            Case DayOfWeek.Sunday
                rday = DayOfWeek.Monday
            Case DayOfWeek.Monday
                rday = DayOfWeek.Tuesday
            Case DayOfWeek.Tuesday
                rday = DayOfWeek.Wednesday
            Case DayOfWeek.Wednesday
                rday = DayOfWeek.Thursday
            Case DayOfWeek.Thursday
                rday = DayOfWeek.Friday
            Case DayOfWeek.Friday
                rday = DayOfWeek.Saturday
            Case DayOfWeek.Saturday
                rday = DayOfWeek.Sunday
        End Select
        Return rday
    End Function

    Public Function monthstr(ByVal month As Integer) As String

        Select Case month
            Case 1
                Return "January"
            Case 2
                Return "Febuary"
            Case 3
                Return "March"
            Case 4
                Return "April"
            Case 5
                Return "May"
            Case 6
                Return "June"
            Case 7
                Return "July"
            Case 8
                Return "August"
            Case 9
                Return "September"
            Case 10
                Return "October"
            Case 11
                Return "November"
            Case 12
                Return "December"
        End Select

        Return ("Error")

    End Function

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

    Private Sub Calendar_Load1(sender As Object, e As EventArgs) Handles MyBase.Load

        ReloadCal(Now, Now.Day)
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