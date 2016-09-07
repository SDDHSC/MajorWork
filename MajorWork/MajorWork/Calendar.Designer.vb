<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.resultsList = New System.Windows.Forms.ListView()
        Me.EventName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNewEvent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthName = New System.Windows.Forms.Label()
        Me.monthMinus = New System.Windows.Forms.Button()
        Me.monthPlus = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.info1 = New System.Windows.Forms.Label()
        Me.info2 = New System.Windows.Forms.Label()
        Me.filterinfo = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.printUpcoming = New System.Windows.Forms.Button()
        Me.info3 = New System.Windows.Forms.Label()
        Me.info4 = New System.Windows.Forms.Label()
        Me.info5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'resultsList
        '
        Me.resultsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EventName})
        Me.resultsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.resultsList.Location = New System.Drawing.Point(552, 99)
        Me.resultsList.Name = "resultsList"
        Me.resultsList.Size = New System.Drawing.Size(92, 114)
        Me.resultsList.TabIndex = 21
        Me.resultsList.UseCompatibleStateImageBehavior = False
        Me.resultsList.View = System.Windows.Forms.View.Details
        '
        'EventName
        '
        Me.EventName.Text = "EventName"
        Me.EventName.Width = 153
        '
        'btnNewEvent
        '
        Me.btnNewEvent.Location = New System.Drawing.Point(558, 260)
        Me.btnNewEvent.Name = "btnNewEvent"
        Me.btnNewEvent.Size = New System.Drawing.Size(75, 23)
        Me.btnNewEvent.TabIndex = 20
        Me.btnNewEvent.Text = "New Event"
        Me.btnNewEvent.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(556, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 19
        '
        'MonthName
        '
        Me.MonthName.AutoSize = True
        Me.MonthName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthName.Location = New System.Drawing.Point(557, 44)
        Me.MonthName.Name = "MonthName"
        Me.MonthName.Size = New System.Drawing.Size(96, 20)
        Me.MonthName.TabIndex = 18
        Me.MonthName.Text = "MonthName"
        '
        'monthMinus
        '
        Me.monthMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthMinus.Location = New System.Drawing.Point(647, 39)
        Me.monthMinus.Name = "monthMinus"
        Me.monthMinus.Size = New System.Drawing.Size(30, 30)
        Me.monthMinus.TabIndex = 17
        Me.monthMinus.Text = ">"
        Me.monthMinus.UseVisualStyleBackColor = True
        '
        'monthPlus
        '
        Me.monthPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthPlus.Location = New System.Drawing.Point(516, 39)
        Me.monthPlus.Name = "monthPlus"
        Me.monthPlus.Size = New System.Drawing.Size(30, 30)
        Me.monthPlus.TabIndex = 16
        Me.monthPlus.Text = "<"
        Me.monthPlus.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(694, 437)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 15
        Me.MonthCalendar1.Visible = False
        '
        'info1
        '
        Me.info1.AutoSize = True
        Me.info1.Location = New System.Drawing.Point(419, 33)
        Me.info1.Name = "info1"
        Me.info1.Size = New System.Drawing.Size(85, 39)
        Me.info1.TabIndex = 22
        Me.info1.Text = "Click < and > to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cycle through →" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "months"
        Me.info1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info1.Visible = False
        '
        'info2
        '
        Me.info2.AutoSize = True
        Me.info2.Location = New System.Drawing.Point(466, 237)
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(80, 39)
        Me.info2.TabIndex = 23
        Me.info2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to create " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a new event →"
        Me.info2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.info2.Visible = False
        '
        'filterinfo
        '
        Me.filterinfo.AutoSize = True
        Me.filterinfo.BackColor = System.Drawing.SystemColors.Control
        Me.filterinfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.filterinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filterinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterinfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.filterinfo.Location = New System.Drawing.Point(642, 400)
        Me.filterinfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.filterinfo.Name = "filterinfo"
        Me.filterinfo.Size = New System.Drawing.Size(47, 41)
        Me.filterinfo.TabIndex = 24
        Me.filterinfo.Text = "Hover " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Help"
        Me.filterinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'printUpcoming
        '
        Me.printUpcoming.Location = New System.Drawing.Point(552, 317)
        Me.printUpcoming.Name = "printUpcoming"
        Me.printUpcoming.Size = New System.Drawing.Size(87, 39)
        Me.printUpcoming.TabIndex = 25
        Me.printUpcoming.Text = "Print Upcoming Events"
        Me.printUpcoming.UseVisualStyleBackColor = True
        '
        'info3
        '
        Me.info3.AutoSize = True
        Me.info3.Location = New System.Drawing.Point(452, 327)
        Me.info3.Name = "info3"
        Me.info3.Size = New System.Drawing.Size(92, 26)
        Me.info3.TabIndex = 70
        Me.info3.Text = "Click to print all →" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "upcoming events"
        Me.info3.Visible = False
        '
        'info4
        '
        Me.info4.AutoSize = True
        Me.info4.Location = New System.Drawing.Point(410, 153)
        Me.info4.Name = "info4"
        Me.info4.Size = New System.Drawing.Size(93, 39)
        Me.info4.TabIndex = 71
        Me.info4.Text = "    Click on a day " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "← to view events " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on that date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.info4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info4.Visible = False
        '
        'info5
        '
        Me.info5.AutoSize = True
        Me.info5.Location = New System.Drawing.Point(550, 166)
        Me.info5.Name = "info5"
        Me.info5.Size = New System.Drawing.Size(97, 39)
        Me.info5.TabIndex = 72
        Me.info5.Text = "↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click desired event" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to view details"
        Me.info5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info5.Visible = False
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.info5)
        Me.Controls.Add(Me.info4)
        Me.Controls.Add(Me.info3)
        Me.Controls.Add(Me.printUpcoming)
        Me.Controls.Add(Me.filterinfo)
        Me.Controls.Add(Me.info2)
        Me.Controls.Add(Me.info1)
        Me.Controls.Add(Me.resultsList)
        Me.Controls.Add(Me.btnNewEvent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthName)
        Me.Controls.Add(Me.monthMinus)
        Me.Controls.Add(Me.monthPlus)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calendar"
        Me.Text = "Calendar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents resultsList As System.Windows.Forms.ListView
    Friend WithEvents EventName As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNewEvent As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MonthName As System.Windows.Forms.Label
    Friend WithEvents monthMinus As System.Windows.Forms.Button
    Friend WithEvents monthPlus As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents info1 As System.Windows.Forms.Label
    Friend WithEvents info2 As System.Windows.Forms.Label
    Friend WithEvents filterinfo As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents printUpcoming As Button
    Friend WithEvents info3 As System.Windows.Forms.Label
    Friend WithEvents info4 As System.Windows.Forms.Label
    Friend WithEvents info5 As System.Windows.Forms.Label
End Class
