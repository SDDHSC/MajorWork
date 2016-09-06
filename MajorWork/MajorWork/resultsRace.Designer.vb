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
        Me.SuspendLayout()
        '
        'rowerListView
        '
        Me.rowerListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.rowerListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Rowers})
        Me.rowerListView.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rowerListView.FullRowSelect = True
        Me.rowerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.rowerListView.Location = New System.Drawing.Point(831, 310)
        Me.rowerListView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rowerListView.Name = "rowerListView"
        Me.rowerListView.Size = New System.Drawing.Size(212, 361)
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
        Me.eventDateSearchCheck.Location = New System.Drawing.Point(436, 133)
        Me.eventDateSearchCheck.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eventDateSearchCheck.Name = "eventDateSearchCheck"
        Me.eventDateSearchCheck.Size = New System.Drawing.Size(32, 31)
        Me.eventDateSearchCheck.TabIndex = 57
        Me.eventDateSearchCheck.UseVisualStyleBackColor = True
        '
        'eventNameSearchCheck
        '
        Me.eventNameSearchCheck.Location = New System.Drawing.Point(436, 93)
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
        Me.eventDateSearch.Location = New System.Drawing.Point(475, 133)
        Me.eventDateSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eventDateSearch.Name = "eventDateSearch"
        Me.eventDateSearch.Size = New System.Drawing.Size(145, 29)
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
        Me.raceListView.Location = New System.Drawing.Point(13, 310)
        Me.raceListView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.raceListView.Name = "raceListView"
        Me.raceListView.Size = New System.Drawing.Size(810, 361)
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
        Me.Label3.Location = New System.Drawing.Point(435, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 31)
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
        Me.eventListView.Location = New System.Drawing.Point(13, 58)
        Me.eventListView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eventListView.Name = "eventListView"
        Me.eventListView.Size = New System.Drawing.Size(412, 241)
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
        Me.eventNameSearch.Location = New System.Drawing.Point(475, 91)
        Me.eventNameSearch.Name = "eventNameSearch"
        Me.eventNameSearch.Size = New System.Drawing.Size(145, 28)
        Me.eventNameSearch.TabIndex = 45
        Me.eventNameSearch.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 45)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Event Results"
        '
        'raceNewEntry
        '
        Me.raceNewEntry.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raceNewEntry.Location = New System.Drawing.Point(926, 8)
        Me.raceNewEntry.Name = "raceNewEntry"
        Me.raceNewEntry.Size = New System.Drawing.Size(108, 38)
        Me.raceNewEntry.TabIndex = 57
        Me.raceNewEntry.Text = "New Entry"
        Me.raceNewEntry.UseVisualStyleBackColor = True
        '
        'editRace
        '
        Me.editRace.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editRace.Location = New System.Drawing.Point(812, 8)
        Me.editRace.Name = "editRace"
        Me.editRace.Size = New System.Drawing.Size(108, 38)
        Me.editRace.TabIndex = 60
        Me.editRace.Text = "Edit Entry"
        Me.editRace.UseVisualStyleBackColor = True
        '
        'analysisButton
        '
        Me.analysisButton.Enabled = False
        Me.analysisButton.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.analysisButton.Location = New System.Drawing.Point(688, 8)
        Me.analysisButton.Name = "analysisButton"
        Me.analysisButton.Size = New System.Drawing.Size(117, 38)
        Me.analysisButton.TabIndex = 61
        Me.analysisButton.Text = "Generate Analysis"
        Me.analysisButton.UseVisualStyleBackColor = True
        '
        'analysisPrint
        '
        Me.analysisPrint.DocumentName = "Race Analysis"
        '
        'resultsRace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1050, 692)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
End Class
