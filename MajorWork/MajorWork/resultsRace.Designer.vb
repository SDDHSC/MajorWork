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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.eventDateSearchCheck = New System.Windows.Forms.CheckBox()
        Me.eventNameSearchCheck = New System.Windows.Forms.CheckBox()
        Me.eventDateSearch = New System.Windows.Forms.DateTimePicker()
        Me.infoList = New System.Windows.Forms.ListView()
        Me.raceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.raceTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.raceDistance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.squad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.crew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resultsList = New System.Windows.Forms.ListView()
        Me.Races = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eventID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eventNameSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.raceNewEntry = New System.Windows.Forms.Button()
        Me.raceAnalysis = New System.Windows.Forms.Button()
        Me.editRace = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.eventDateSearchCheck)
        Me.Panel1.Controls.Add(Me.eventNameSearchCheck)
        Me.Panel1.Controls.Add(Me.eventDateSearch)
        Me.Panel1.Controls.Add(Me.infoList)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.resultsList)
        Me.Panel1.Controls.Add(Me.eventNameSearch)
        Me.Panel1.Location = New System.Drawing.Point(10, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 625)
        Me.Panel1.TabIndex = 59
        '
        'eventDateSearchCheck
        '
        Me.eventDateSearchCheck.Location = New System.Drawing.Point(423, 80)
        Me.eventDateSearchCheck.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eventDateSearchCheck.Name = "eventDateSearchCheck"
        Me.eventDateSearchCheck.Size = New System.Drawing.Size(32, 31)
        Me.eventDateSearchCheck.TabIndex = 57
        Me.eventDateSearchCheck.UseVisualStyleBackColor = True
        '
        'eventNameSearchCheck
        '
        Me.eventNameSearchCheck.Location = New System.Drawing.Point(423, 40)
        Me.eventNameSearchCheck.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eventNameSearchCheck.Name = "eventNameSearchCheck"
        Me.eventNameSearchCheck.Size = New System.Drawing.Size(32, 31)
        Me.eventNameSearchCheck.TabIndex = 0
        Me.eventNameSearchCheck.UseVisualStyleBackColor = True
        '
        'eventDateSearch
        '
        Me.eventDateSearch.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.eventDateSearch.Location = New System.Drawing.Point(462, 80)
        Me.eventDateSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eventDateSearch.Name = "eventDateSearch"
        Me.eventDateSearch.Size = New System.Drawing.Size(145, 29)
        Me.eventDateSearch.TabIndex = 56
        '
        'infoList
        '
        Me.infoList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.raceName, Me.raceTime, Me.raceDistance, Me.position, Me.squad, Me.crew})
        Me.infoList.Location = New System.Drawing.Point(0, 257)
        Me.infoList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.infoList.Name = "infoList"
        Me.infoList.Size = New System.Drawing.Size(1024, 361)
        Me.infoList.TabIndex = 55
        Me.infoList.UseCompatibleStateImageBehavior = False
        Me.infoList.View = System.Windows.Forms.View.Details
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
        Me.position.Width = 195
        '
        'squad
        '
        Me.squad.Text = "Squad"
        Me.squad.Width = 213
        '
        'crew
        '
        Me.crew.Text = "Rowers"
        Me.crew.Width = 319
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(422, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 31)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Filters"
        '
        'resultsList
        '
        Me.resultsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Races, Me.Time, Me.eventID})
        Me.resultsList.Location = New System.Drawing.Point(0, 5)
        Me.resultsList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.resultsList.Name = "resultsList"
        Me.resultsList.Size = New System.Drawing.Size(412, 241)
        Me.resultsList.TabIndex = 54
        Me.resultsList.UseCompatibleStateImageBehavior = False
        Me.resultsList.View = System.Windows.Forms.View.Details
        '
        'Races
        '
        Me.Races.Text = "Name Of Event"
        Me.Races.Width = 136
        '
        'Time
        '
        Me.Time.Text = "Date"
        Me.Time.Width = 84
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
        Me.eventNameSearch.Location = New System.Drawing.Point(462, 38)
        Me.eventNameSearch.Name = "eventNameSearch"
        Me.eventNameSearch.Size = New System.Drawing.Size(145, 28)
        Me.eventNameSearch.TabIndex = 45
        Me.eventNameSearch.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 45)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Race Results"
        '
        'raceNewEntry
        '
        Me.raceNewEntry.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raceNewEntry.Location = New System.Drawing.Point(817, 8)
        Me.raceNewEntry.Name = "raceNewEntry"
        Me.raceNewEntry.Size = New System.Drawing.Size(108, 38)
        Me.raceNewEntry.TabIndex = 57
        Me.raceNewEntry.Text = "New Entry"
        Me.raceNewEntry.UseVisualStyleBackColor = True
        '
        'raceAnalysis
        '
        Me.raceAnalysis.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raceAnalysis.Location = New System.Drawing.Point(931, 8)
        Me.raceAnalysis.Name = "raceAnalysis"
        Me.raceAnalysis.Size = New System.Drawing.Size(108, 38)
        Me.raceAnalysis.TabIndex = 56
        Me.raceAnalysis.Text = "Analysis"
        Me.raceAnalysis.UseVisualStyleBackColor = True
        '
        'editRace
        '
        Me.editRace.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editRace.Location = New System.Drawing.Point(703, 8)
        Me.editRace.Name = "editRace"
        Me.editRace.Size = New System.Drawing.Size(108, 38)
        Me.editRace.TabIndex = 60
        Me.editRace.Text = "Edit Entry"
        Me.editRace.UseVisualStyleBackColor = True
        '
        'resultsRace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1050, 692)
        Me.Controls.Add(Me.editRace)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.raceNewEntry)
        Me.Controls.Add(Me.raceAnalysis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "resultsRace"
        Me.Text = "raceResults"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents eventDateSearchCheck As CheckBox
    Friend WithEvents eventNameSearchCheck As CheckBox
    Friend WithEvents eventDateSearch As DateTimePicker
    Friend WithEvents infoList As ListView
    Friend WithEvents raceName As ColumnHeader
    Friend WithEvents raceTime As ColumnHeader
    Friend WithEvents raceDistance As ColumnHeader
    Friend WithEvents position As ColumnHeader
    Friend WithEvents squad As ColumnHeader
    Friend WithEvents crew As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents resultsList As ListView
    Friend WithEvents Races As ColumnHeader
    Friend WithEvents Time As ColumnHeader
    Friend WithEvents eventID As ColumnHeader
    Friend WithEvents eventNameSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents raceNewEntry As Button
    Friend WithEvents raceAnalysis As Button
    Friend WithEvents editRace As Button
End Class
