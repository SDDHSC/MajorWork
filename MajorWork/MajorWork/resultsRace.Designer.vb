<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resultsRace
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
        Me.rowerListView = New System.Windows.Forms.ListView()
        Me.Rowers = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eventDateSearchCheck = New System.Windows.Forms.CheckBox()
        Me.eventNameSearchCheck = New System.Windows.Forms.CheckBox()
        Me.eventDateSearch = New System.Windows.Forms.DateTimePicker()
        Me.raceListView = New System.Windows.Forms.ListView()
        Me.raceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.raceTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.raceDistance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.squad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.eventListView = New System.Windows.Forms.ListView()
        Me.Races = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eventID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eventNameSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.raceNewEntry = New System.Windows.Forms.Button()
        Me.editRace = New System.Windows.Forms.Button()
        Me.analysisButton = New System.Windows.Forms.Button()
        Me.analysisPrint = New System.Drawing.Printing.PrintDocument()
        Me.FilterInfo = New System.Windows.Forms.Label()
        Me.info1 = New System.Windows.Forms.Label()
        Me.info6 = New System.Windows.Forms.Label()
        Me.info5 = New System.Windows.Forms.Label()
        Me.info3 = New System.Windows.Forms.Label()
        Me.info4 = New System.Windows.Forms.Label()
        Me.info2 = New System.Windows.Forms.Label()
        Me.info7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rowerListView
        '
        Me.rowerListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.rowerListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Rowers})
        Me.rowerListView.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rowerListView.FullRowSelect = True
        Me.rowerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.rowerListView.Location = New System.Drawing.Point(554, 201)
        Me.rowerListView.Name = "rowerListView"
        Me.rowerListView.Size = New System.Drawing.Size(143, 211)
        Me.rowerListView.TabIndex = 58
        Me.rowerListView.UseCompatibleStateImageBehavior = False
        Me.rowerListView.View = System.Windows.Forms.View.Details
        '
        'Rowers
        '
        Me.Rowers.Text = "Rowers"
        Me.Rowers.Width = 200
        '
        'eventDateSearchCheck
        '
        Me.eventDateSearchCheck.Location = New System.Drawing.Point(291, 86)
        Me.eventDateSearchCheck.Name = "eventDateSearchCheck"
        Me.eventDateSearchCheck.Size = New System.Drawing.Size(21, 20)
        Me.eventDateSearchCheck.TabIndex = 57
        Me.eventDateSearchCheck.UseVisualStyleBackColor = True
        '
        'eventNameSearchCheck
        '
        Me.eventNameSearchCheck.Location = New System.Drawing.Point(291, 60)
        Me.eventNameSearchCheck.Name = "eventNameSearchCheck"
        Me.eventNameSearchCheck.Size = New System.Drawing.Size(21, 20)
        Me.eventNameSearchCheck.TabIndex = 0
        Me.eventNameSearchCheck.UseVisualStyleBackColor = True
        '
        'eventDateSearch
        '
        Me.eventDateSearch.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.eventDateSearch.Location = New System.Drawing.Point(317, 86)
        Me.eventDateSearch.Name = "eventDateSearch"
        Me.eventDateSearch.Size = New System.Drawing.Size(98, 22)
        Me.eventDateSearch.TabIndex = 56
        '
        'raceListView
        '
        Me.raceListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.raceListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.raceName, Me.raceTime, Me.raceDistance, Me.position, Me.squad})
        Me.raceListView.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raceListView.FullRowSelect = True
        Me.raceListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.raceListView.HideSelection = False
        Me.raceListView.Location = New System.Drawing.Point(9, 201)
        Me.raceListView.Name = "raceListView"
        Me.raceListView.Size = New System.Drawing.Size(541, 211)
        Me.raceListView.TabIndex = 55
        Me.raceListView.UseCompatibleStateImageBehavior = False
        Me.raceListView.View = System.Windows.Forms.View.Details
        '
        'raceName
        '
        Me.raceName.Text = "Race Name"
        Me.raceName.Width = 83
        '
        'raceTime
        '
        Me.raceTime.Text = "Time"
        Me.raceTime.Width = 93
        '
        'raceDistance
        '
        Me.raceDistance.Text = "Distance"
        Me.raceDistance.Width = 115
        '
        'position
        '
        Me.position.Text = "Position"
        Me.position.Width = 117
        '
        'squad
        '
        Me.squad.Text = "Squad"
        Me.squad.Width = 163
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(290, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Filters"
        '
        'eventListView
        '
        Me.eventListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.eventListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Races, Me.Time, Me.eventID})
        Me.eventListView.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventListView.FullRowSelect = True
        Me.eventListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.eventListView.HideSelection = False
        Me.eventListView.Location = New System.Drawing.Point(9, 38)
        Me.eventListView.Name = "eventListView"
        Me.eventListView.Size = New System.Drawing.Size(276, 159)
        Me.eventListView.TabIndex = 54
        Me.eventListView.UseCompatibleStateImageBehavior = False
        Me.eventListView.View = System.Windows.Forms.View.Details
        '
        'Races
        '
        Me.Races.Text = "Name Of Event"
        Me.Races.Width = 206
        '
        'Time
        '
        Me.Time.Text = "Date"
        Me.Time.Width = 200
        '
        'eventID
        '
        Me.eventID.Text = "eventID"
        Me.eventID.Width = 0
        '
        'eventNameSearch
        '
        Me.eventNameSearch.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventNameSearch.ForeColor = System.Drawing.Color.Gray
        Me.eventNameSearch.Location = New System.Drawing.Point(317, 59)
        Me.eventNameSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.eventNameSearch.Name = "eventNameSearch"
        Me.eventNameSearch.Size = New System.Drawing.Size(98, 21)
        Me.eventNameSearch.TabIndex = 45
        Me.eventNameSearch.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 30)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Event Results"
        '
        'raceNewEntry
        '
        Me.raceNewEntry.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raceNewEntry.Location = New System.Drawing.Point(617, 5)
        Me.raceNewEntry.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.raceNewEntry.Name = "raceNewEntry"
        Me.raceNewEntry.Size = New System.Drawing.Size(72, 25)
        Me.raceNewEntry.TabIndex = 57
        Me.raceNewEntry.Text = "New Entry"
        Me.raceNewEntry.UseVisualStyleBackColor = True
        '
        'editRace
        '
        Me.editRace.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editRace.Location = New System.Drawing.Point(527, 5)
        Me.editRace.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.editRace.Name = "editRace"
        Me.editRace.Size = New System.Drawing.Size(72, 25)
        Me.editRace.TabIndex = 60
        Me.editRace.Text = "Edit Entry"
        Me.editRace.UseVisualStyleBackColor = True
        '
        'analysisButton
        '
        Me.analysisButton.Enabled = False
        Me.analysisButton.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.analysisButton.Location = New System.Drawing.Point(432, 5)
        Me.analysisButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.analysisButton.Name = "analysisButton"
        Me.analysisButton.Size = New System.Drawing.Size(78, 25)
        Me.analysisButton.TabIndex = 61
        Me.analysisButton.Text = "Generate Analysis"
        Me.analysisButton.UseVisualStyleBackColor = True
        '
        'analysisPrint
        '
        Me.analysisPrint.DocumentName = "Race Analysis"
        '
        'FilterInfo
        '
        Me.FilterInfo.AutoSize = True
        Me.FilterInfo.BackColor = System.Drawing.Color.White
        Me.FilterInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FilterInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterInfo.Location = New System.Drawing.Point(409, 7)
        Me.FilterInfo.Name = "FilterInfo"
        Me.FilterInfo.Size = New System.Drawing.Size(20, 22)
        Me.FilterInfo.TabIndex = 62
        Me.FilterInfo.Text = "?"
        '
        'info1
        '
        Me.info1.AutoSize = True
        Me.info1.BackColor = System.Drawing.Color.Transparent
        Me.info1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info1.Location = New System.Drawing.Point(55, 84)
        Me.info1.Name = "info1"
        Me.info1.Size = New System.Drawing.Size(189, 38)
        Me.info1.TabIndex = 64
        Me.info1.Text = "↖" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click an Event to Display Races" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.info1.Visible = False
        '
        'info6
        '
        Me.info6.AutoSize = True
        Me.info6.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info6.Location = New System.Drawing.Point(66, 246)
        Me.info6.Name = "info6"
        Me.info6.Size = New System.Drawing.Size(186, 38)
        Me.info6.TabIndex = 66
        Me.info6.Text = "↖" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click a Race to Display Rowers"
        Me.info6.Visible = False
        '
        'info5
        '
        Me.info5.AutoSize = True
        Me.info5.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info5.Location = New System.Drawing.Point(287, 109)
        Me.info5.Name = "info5"
        Me.info5.Size = New System.Drawing.Size(151, 38)
        Me.info5.TabIndex = 67
        Me.info5.Text = "↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use Filters to Sort Events"
        Me.info5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info5.Visible = False
        '
        'info3
        '
        Me.info3.AutoSize = True
        Me.info3.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info3.Location = New System.Drawing.Point(524, 32)
        Me.info3.Name = "info3"
        Me.info3.Size = New System.Drawing.Size(93, 57)
        Me.info3.TabIndex = 68
        Me.info3.Text = "↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edit the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selected Event"
        Me.info3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.info3.Visible = False
        '
        'info4
        '
        Me.info4.AutoSize = True
        Me.info4.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info4.Location = New System.Drawing.Point(621, 32)
        Me.info4.Name = "info4"
        Me.info4.Size = New System.Drawing.Size(72, 57)
        Me.info4.TabIndex = 69
        Me.info4.Text = "↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Create a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Event"
        Me.info4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.info4.Visible = False
        '
        'info2
        '
        Me.info2.AutoSize = True
        Me.info2.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info2.Location = New System.Drawing.Point(439, 30)
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(75, 57)
        Me.info2.TabIndex = 70
        Me.info2.Text = "↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Generate a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Report"
        Me.info2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.info2.Visible = False
        '
        'info7
        '
        Me.info7.AutoSize = True
        Me.info7.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info7.Location = New System.Drawing.Point(761, 130)
        Me.info7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info7.Name = "info7"
        Me.info7.Size = New System.Drawing.Size(282, 28)
        Me.info7.TabIndex = 71
        Me.info7.Text = "Access Level 2 or Above Needed"
        Me.info7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info7.Visible = False
        '
        'resultsRace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        '<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(700, 450)
        '======
        Me.ClientSize = New System.Drawing.Size(1050, 692)
        Me.Controls.Add(Me.info7)
        '>>>>> origin/master
        Me.Controls.Add(Me.info2)
        Me.Controls.Add(Me.info4)
        Me.Controls.Add(Me.info3)
        Me.Controls.Add(Me.info5)
        Me.Controls.Add(Me.info6)
        Me.Controls.Add(Me.info1)
        Me.Controls.Add(Me.FilterInfo)
        Me.Controls.Add(Me.rowerListView)
        Me.Controls.Add(Me.analysisButton)
        Me.Controls.Add(Me.eventDateSearchCheck)
        Me.Controls.Add(Me.editRace)
        Me.Controls.Add(Me.eventNameSearchCheck)
        Me.Controls.Add(Me.eventDateSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.raceListView)
        Me.Controls.Add(Me.raceNewEntry)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.eventListView)
        Me.Controls.Add(Me.eventNameSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "resultsRace"
        Me.Text = "raceResults"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents eventDateSearchCheck As CheckBox
    Friend WithEvents eventNameSearchCheck As CheckBox
    Friend WithEvents eventDateSearch As DateTimePicker
    Friend WithEvents raceName As ColumnHeader
    Friend WithEvents raceTime As ColumnHeader
    Friend WithEvents raceDistance As ColumnHeader
    Friend WithEvents position As ColumnHeader
    Friend WithEvents squad As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents eventListView As ListView
    Friend WithEvents Races As ColumnHeader
    Friend WithEvents Time As ColumnHeader
    Friend WithEvents eventID As ColumnHeader
    Friend WithEvents eventNameSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents raceNewEntry As Button
    Friend WithEvents editRace As Button
    Friend WithEvents raceListView As ListView
    Friend WithEvents rowerListView As ListView
    Friend WithEvents Rowers As ColumnHeader
    Friend WithEvents analysisButton As Button
    Friend WithEvents analysisPrint As Printing.PrintDocument
    Friend WithEvents FilterInfo As Label
    Friend WithEvents info1 As Label
    Friend WithEvents info6 As Label
    Friend WithEvents info5 As Label
    Friend WithEvents info3 As Label
    Friend WithEvents info4 As Label
    Friend WithEvents info2 As Label
    Friend WithEvents info7 As Label
End Class
