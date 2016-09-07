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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthName = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.info1 = New System.Windows.Forms.Label()
        Me.info2 = New System.Windows.Forms.Label()
        Me.filterinfo = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.printUpcoming = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'resultsList
        '
        Me.resultsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EventName})
        Me.resultsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.resultsList.Location = New System.Drawing.Point(836, 248)
        Me.resultsList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.resultsList.Name = "resultsList"
        Me.resultsList.Size = New System.Drawing.Size(136, 173)
        Me.resultsList.TabIndex = 21
        Me.resultsList.UseCompatibleStateImageBehavior = False
        Me.resultsList.View = System.Windows.Forms.View.Details
        '
        'EventName
        '
        Me.EventName.Text = "EventName"
        Me.EventName.Width = 153
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(854, 462)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 35)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "New Event"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(849, 191)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Date clicked"
        '
        'MonthName
        '
        Me.MonthName.AutoSize = True
        Me.MonthName.Location = New System.Drawing.Point(868, 115)
        Me.MonthName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MonthName.Name = "MonthName"
        Me.MonthName.Size = New System.Drawing.Size(96, 20)
        Me.MonthName.TabIndex = 18
        Me.MonthName.Text = "MonthName"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(975, 106)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 35)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(825, 106)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(1041, 672)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 15
        Me.MonthCalendar1.Visible = False
        '
        'info1
        '
        Me.info1.AutoSize = True
        Me.info1.Location = New System.Drawing.Point(831, 14)
        Me.info1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info1.Name = "info1"
        Me.info1.Size = New System.Drawing.Size(160, 60)
        Me.info1.TabIndex = 22
        Me.info1.Text = "    Click < and > to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cycle through months" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 ↓"
        Me.info1.Visible = False
        '
        'info2
        '
        Me.info2.AutoSize = True
        Me.info2.Location = New System.Drawing.Point(861, 517)
        Me.info2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(113, 60)
        Me.info2.TabIndex = 23
        Me.info2.Text = "          ↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to create " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a new event"
        Me.info2.Visible = False
        '
        'filterinfo
        '
        Me.filterinfo.AutoSize = True
        Me.filterinfo.Location = New System.Drawing.Point(964, 603)
        Me.filterinfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.filterinfo.Name = "filterinfo"
        Me.filterinfo.Size = New System.Drawing.Size(55, 60)
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
        Me.printUpcoming.Location = New System.Drawing.Point(825, 603)
        Me.printUpcoming.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.printUpcoming.Name = "printUpcoming"
        Me.printUpcoming.Size = New System.Drawing.Size(131, 60)
        Me.printUpcoming.TabIndex = 25
        Me.printUpcoming.Text = "Print Upcoming Events"
        Me.printUpcoming.UseVisualStyleBackColor = True
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 692)
        Me.Controls.Add(Me.printUpcoming)
        Me.Controls.Add(Me.filterinfo)
        Me.Controls.Add(Me.info2)
        Me.Controls.Add(Me.info1)
        Me.Controls.Add(Me.resultsList)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Calendar"
        Me.Text = "Calendar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents resultsList As System.Windows.Forms.ListView
    Friend WithEvents EventName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MonthName As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents info1 As System.Windows.Forms.Label
    Friend WithEvents info2 As System.Windows.Forms.Label
    Friend WithEvents filterinfo As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents printUpcoming As Button
End Class
