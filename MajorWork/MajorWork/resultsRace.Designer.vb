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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rowerListView)
        Me.Panel1.Controls.Add(Me.eventDateSearchCheck)
        Me.Panel1.Controls.Add(Me.eventNameSearchCheck)
        Me.Panel1.Controls.Add(Me.eventDateSearch)
        Me.Panel1.Controls.Add(Me.raceListView)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.eventListView)
        Me.Panel1.Controls.Add(Me.eventNameSearch)
        Me.Panel1.Location = New System.Drawing.Point(7, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 406)
        Me.Panel1.TabIndex = 59
        '
        'rowerListView
        '
        Me.rowerListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Rowers})
        Me.rowerListView.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rowerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.rowerListView.Location = New System.Drawing.Point(545, 167)
        Me.rowerListView.Name = "rowerListView"
        Me.rowerListView.Size = New System.Drawing.Size(143, 236)
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
        Me.eventDateSearchCheck.Location = New System.Drawing.Point(282, 52)
        Me.eventDateSearchCheck.Name = "eventDateSearchCheck"
        Me.eventDateSearchCheck.Size = New System.Drawing.Size(21, 20)
        Me.eventDateSearchCheck.TabIndex = 57
        Me.eventDateSearchCheck.UseVisualStyleBackColor = True
        '
        'eventNameSearchCheck
        '
        Me.eventNameSearchCheck.Location = New System.Drawing.Point(282, 26)
        Me.eventNameSearchCheck.Name = "eventNameSearchCheck"
        Me.eventNameSearchCheck.Size = New System.Drawing.Size(21, 20)
        Me.eventNameSearchCheck.TabIndex = 0
        Me.eventNameSearchCheck.UseVisualStyleBackColor = True
        '
        'eventDateSearch
        '
        Me.eventDateSearch.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.eventDateSearch.Location = New System.Drawing.Point(308, 52)
        Me.eventDateSearch.Name = "eventDateSearch"
        Me.eventDateSearch.Size = New System.Drawing.Size(98, 22)
        Me.eventDateSearch.TabIndex = 56
        '
        'raceListView
        '
        Me.raceListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.raceName, Me.raceTime, Me.raceDistance, Me.position, Me.squad})
        Me.raceListView.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raceListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.raceListView.HideSelection = False
        Me.raceListView.Location = New System.Drawing.Point(0, 167)
        Me.raceListView.Name = "raceListView"
        Me.raceListView.Size = New System.Drawing.Size(541, 236)
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
        Me.Label3.Location = New System.Drawing.Point(281, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Filters"
        '
        'eventListView
        '
        Me.eventListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Races, Me.Time, Me.eventID})
        Me.eventListView.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.eventListView.HideSelection = False
        Me.eventListView.Location = New System.Drawing.Point(0, 3)
        Me.eventListView.Name = "eventListView"
        Me.eventListView.Size = New System.Drawing.Size(276, 158)
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
        Me.eventNameSearch.Location = New System.Drawing.Point(308, 25)
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
        Me.Label2.Size = New System.Drawing.Size(136, 30)
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
        Me.editRace.Location = New System.Drawing.Point(541, 5)
        Me.editRace.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.editRace.Name = "editRace"
        Me.editRace.Size = New System.Drawing.Size(72, 25)
        Me.editRace.TabIndex = 60
        Me.editRace.Text = "Edit Entry"
        Me.editRace.UseVisualStyleBackColor = True
        '
        'analysisButton
        '
        Me.analysisButton.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.analysisButton.Location = New System.Drawing.Point(459, 5)
        Me.analysisButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.analysisButton.Name = "analysisButton"
        Me.analysisButton.Size = New System.Drawing.Size(78, 25)
        Me.analysisButton.TabIndex = 61
        Me.analysisButton.Text = "Print Analysis"
        Me.analysisButton.UseVisualStyleBackColor = True
        '
        'analysisPrint
        '
        Me.analysisPrint.DocumentName = "Race Analysis"
        '
        'resultsRace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.analysisButton)
        Me.Controls.Add(Me.editRace)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.raceNewEntry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
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
End Class
