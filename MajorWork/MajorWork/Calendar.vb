﻿Imports System.Data.OleDb
Public Class Calendar
    Dim dName = {"m", "tu", "w", "th", "f", "sa", "su"}
    Dim days As New List(Of Label)
    Dim pDays As New List(Of Panel)
    Dim monthValue = 0
    Dim fakeDate As Date
    Dim hPanel = New Panel

    Dim adp As New OleDbDataAdapter
    Dim conDatabase As OleDbConnection
    Dim dataResults As New DataSet()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Panel1.BackColor = skyOrange

        Dim connectstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\rowingDatabase (1).accdb" ' address of database
        conDatabase = New OleDbConnection(connectstring)
        conDatabase.Open()
        adp = New OleDbDataAdapter()
        adp.SelectCommand = New OleDbCommand()
        With adp.SelectCommand
            .Connection = conDatabase
            .CommandText = "select * from " + "tbEvents" 'table name
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With


        hPanel.name = ""
        fakeDate = Today.Date
        For x = 0 To 5
            For y = 0 To 6

                Dim p = New Panel
                p.Size = New Size(65, 65)
                p.Location = New Point(y * 70 + 10, x * 70 + 10)
                p.BackColor = schoolBlue
                p.Name = dName(y).ToString + (x + 1).ToString

                Dim l = New Label
                l.Location = New Point(y * 70 + 10, x * 70 + 10)
                'l.Location = New Point(5, 5)
                l.Size = New Size(40, 30)
                l.BackColor = schoolBlue

                l.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)

                l.Name = dName(y).ToString + (x + 1).ToString
                p.Name = dName(y).ToString + (x + 1).ToString

                AddHandler p.Click, AddressOf Panel_Click
                AddHandler l.Click, AddressOf Panel_Click

                AddHandler p.MouseEnter, AddressOf Panel1_Hover
                AddHandler l.MouseEnter, AddressOf Panel1_Hover

                AddHandler p.MouseLeave, AddressOf Panel1_leave
                AddHandler l.MouseLeave, AddressOf Panel1_leave

                'p.Controls.Add(l)
                Me.Controls.Add(l)
                days.Add(l)
                Me.Controls.Add(p)
                pDays.Add(p)
            Next
        Next
        ReloadCal(fakeDate, fakeDate.Day)

    End Sub

    Public Sub ReloadCal(ByVal ldate As Date, ByVal Selected As Integer)
        On Error Resume Next
        cleartxt()
        MonthName.Text = monthstr(ldate.Month)
        Dim fdate As DayOfWeek = GetFirstOfMonthDay(ldate)
        Dim idate As Integer = 1
        Dim row As Integer = 1
        Do
            getlabel(fdate, row).Text = idate

            getlabel(fdate, row).ForeColor = Color.White
            If idate = Selected Then
                getlabel(fdate, row).ForeColor = Color.OrangeRed
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

        For Each x In Me.Controls
            If x.GetType() Is GetType(Label) Then
                If x.Text = "" Then
                    Dim labelIndex = (days.IndexOf(x))

                    days(labelIndex).BackColor = Color.Gray
                    pDays(labelIndex).BackColor = Color.Gray
                Else
                    Dim labelIndex = (days.IndexOf(x))

                    days(labelIndex).BackColor = schoolBlue
                    pDays(labelIndex).BackColor = schoolBlue
                End If
            End If
        Next
    End Sub

    Private Sub cleartxt()
        For Each x As Label In days
            x.Text = ""
        Next
    End Sub

    Function getlabel(ByVal day As DayOfWeek, ByVal row As Integer) As System.Windows.Forms.Label
        Select Case day
            Case DayOfWeek.Monday
                Return days((row - 1) * 7 + 0)
            Case DayOfWeek.Tuesday
                Return days((row - 1) * 7 + 1)
            Case DayOfWeek.Wednesday
                Return days((row - 1) * 7 + 2)
            Case DayOfWeek.Thursday
                Return days((row - 1) * 7 + 3)
            Case DayOfWeek.Friday
                Return days((row - 1) * 7 + 4)
            Case DayOfWeek.Saturday
                Return days((row - 1) * 7 + 5)
            Case DayOfWeek.Sunday
                Return days((row - 1) * 7 + 6)
        End Select

        Return days((row - 1) * 7 + 0)
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
        If month > 12 Then
            month -= 12
        ElseIf month < 1 Then
            month += 12
        End If

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

    Private Sub Panel_Click(sender As Object, e As MouseEventArgs)
        Dim pIndex = 0
        Dim hIndex = 0

        If hPanel.name <> "" Then
            If sender.backcolor <> Color.Gray Then
                hPanel.BackColor = schoolBlue
                hIndex = (pDays.IndexOf(hPanel))
                days(hIndex).BackColor = schoolBlue
            End If
        End If

        If sender.GetType() = GetType(Panel) Then
            pIndex = (pDays.IndexOf(sender))
            If sender.backcolor <> Color.Gray Then
                pDays(pIndex).BackColor = skyOrange
                days(pIndex).BackColor = skyOrange
                hPanel = pDays(pIndex)
            End If
        ElseIf sender.GetType() = GetType(Label) Then
            pIndex = (days.IndexOf(sender))

            If sender.backcolor <> Color.Gray Then
                pDays(pIndex).BackColor = skyOrange
                days(pIndex).BackColor = skyOrange
                hPanel = pDays(pIndex)
            End If
        End If

        If days(pIndex).Text <> "" Then
            Label1.Text = days(pIndex).Text + "/" + CStr(fakeDate.Month) + "/" + CStr(fakeDate.Year)
        End If

        resultsList.Items.Clear()
        Dim reader As OleDbDataReader = adp.SelectCommand.ExecuteReader()
        While reader.Read() 'every time it runs reader.read, it moves onto the next record
            Dim row(1) As String 'row(1) is a list of strings that is two long, because index at 0 
            row(0) = CStr(reader(6)) 'reader(1) gets the value at 1 of the current record
            Dim itm = New ListViewItem(row)

            If CStr(reader(1)) = Label1.Text Then
                resultsList.Items.Add(itm)
            End If
        End While
        reader.Close()
    End Sub

    Private Sub Panel1_Hover(sender As Object, e As EventArgs)
        Dim pIndex = 0

        If sender.GetType() = GetType(Panel) Then
            pIndex = (pDays.IndexOf(sender))
            If sender.name <> hPanel.name Then
                pDays(pIndex).BackColor = DeepBlue
                days(pIndex).BackColor = DeepBlue
            End If

        ElseIf sender.GetType() = GetType(Label) Then
            pIndex = (days.IndexOf(sender))
            If sender.name <> hPanel.name Then
                pDays(pIndex).BackColor = DeepBlue
                days(pIndex).BackColor = DeepBlue
            End If
        End If

        If days(pIndex).Text = "" Then
            days(pIndex).BackColor = Color.Gray
            pDays(pIndex).BackColor = Color.Gray
        End If
    End Sub

    Private Sub Panel1_leave(sender As Object, e As EventArgs)
        Dim pIndex = 0

        If sender.GetType() = GetType(Panel) Then
            pIndex = (pDays.IndexOf(sender))

            If sender.name <> hPanel.name Then
                pDays(pIndex).BackColor = schoolBlue
                days(pIndex).BackColor = schoolBlue
            End If
        ElseIf sender.GetType() = GetType(Label) Then
            pIndex = (days.IndexOf(sender))
            If sender.name <> hPanel.name Then
                pDays(pIndex).BackColor = schoolBlue
                days(pIndex).BackColor = schoolBlue
            End If
        End If

        If days(pIndex).Text = "" Then
            days(pIndex).BackColor = Color.Gray
            pDays(pIndex).BackColor = Color.Gray
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fakeDate = fakeDate.AddMonths(1)
        ReloadCal(fakeDate, fakeDate.Day)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fakeDate = fakeDate.AddMonths(-1)
        ReloadCal(fakeDate, fakeDate.Day)
    End Sub
End Class