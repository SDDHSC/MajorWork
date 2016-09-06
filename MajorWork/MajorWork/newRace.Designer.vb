<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newRace
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.yearCounter = New System.Windows.Forms.NumericUpDown()
        Me.gradeCombo = New System.Windows.Forms.ComboBox()
        Me.crewCounter = New System.Windows.Forms.NumericUpDown()
        Me.boatCombo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.distCounter = New System.Windows.Forms.NumericUpDown()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nameRace = New System.Windows.Forms.TextBox()
        Me.addRace = New System.Windows.Forms.Button()
        Me.rowerList = New System.Windows.Forms.ListView()
        Me.rowers = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.infoList = New System.Windows.Forms.ListView()
        Me.raceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.raceTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.raceDistance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.squad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.minCounter = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.secCounter = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.posCounter = New System.Windows.Forms.NumericUpDown()
        Me.particiCounter = New System.Windows.Forms.NumericUpDown()
        Me.addRower = New System.Windows.Forms.Button()
        Me.searchRower = New System.Windows.Forms.TextBox()
        Me.deleteRower = New System.Windows.Forms.Button()
        Me.finish = New System.Windows.Forms.Button()
        Me.deleteRace = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eventNameBox = New System.Windows.Forms.TextBox()
        Me.eventTime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.yearCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crewCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.distCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.secCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.posCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.particiCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(461, 467)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 21)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Boat:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(461, 403)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 21)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Crew:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(383, 467)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 21)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "Grade:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(387, 403)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 21)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Year:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(401, 378)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 25)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Squad"
        '
        'yearCounter
        '
        Me.yearCounter.Location = New System.Drawing.Point(380, 433)
        Me.yearCounter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.yearCounter.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.yearCounter.Name = "yearCounter"
        Me.yearCounter.Size = New System.Drawing.Size(62, 26)
        Me.yearCounter.TabIndex = 76
        Me.yearCounter.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'gradeCombo
        '
        Me.gradeCombo.FormattingEnabled = True
        Me.gradeCombo.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12"})
        Me.gradeCombo.Location = New System.Drawing.Point(380, 495)
        Me.gradeCombo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gradeCombo.Name = "gradeCombo"
        Me.gradeCombo.Size = New System.Drawing.Size(62, 28)
        Me.gradeCombo.TabIndex = 78
        '
        'crewCounter
        '
        Me.crewCounter.Location = New System.Drawing.Point(457, 433)
        Me.crewCounter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.crewCounter.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.crewCounter.Name = "crewCounter"
        Me.crewCounter.Size = New System.Drawing.Size(62, 26)
        Me.crewCounter.TabIndex = 79
        Me.crewCounter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'boatCombo
        '
        Me.boatCombo.DisplayMember = "Eight"
        Me.boatCombo.FormattingEnabled = True
        Me.boatCombo.Items.AddRange(New Object() {"Eight", "Quad", "Four", "Double", "Single"})
        Me.boatCombo.Location = New System.Drawing.Point(457, 495)
        Me.boatCombo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.boatCombo.Name = "boatCombo"
        Me.boatCombo.Size = New System.Drawing.Size(62, 28)
        Me.boatCombo.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(148, 378)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 25)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Distance(m):"
        '
        'distCounter
        '
        Me.distCounter.Location = New System.Drawing.Point(175, 431)
        Me.distCounter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.distCounter.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.distCounter.Name = "distCounter"
        Me.distCounter.Size = New System.Drawing.Size(62, 26)
        Me.distCounter.TabIndex = 70
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Location = New System.Drawing.Point(843, 622)
        Me.cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(94, 53)
        Me.cancel.TabIndex = 98
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(556, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Add Race:"
        '
        'nameRace
        '
        Me.nameRace.Location = New System.Drawing.Point(555, 205)
        Me.nameRace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nameRace.Name = "nameRace"
        Me.nameRace.Size = New System.Drawing.Size(137, 26)
        Me.nameRace.TabIndex = 57
        '
        'addRace
        '
        Me.addRace.Location = New System.Drawing.Point(555, 244)
        Me.addRace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addRace.Name = "addRace"
        Me.addRace.Size = New System.Drawing.Size(72, 29)
        Me.addRace.TabIndex = 59
        Me.addRace.Text = "Add"
        Me.addRace.UseVisualStyleBackColor = True
        '
        'rowerList
        '
        Me.rowerList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.rowerList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.rowers})
        Me.rowerList.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rowerList.FullRowSelect = True
        Me.rowerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.rowerList.HideSelection = False
        Me.rowerList.Location = New System.Drawing.Point(704, 111)
        Me.rowerList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rowerList.Name = "rowerList"
        Me.rowerList.Size = New System.Drawing.Size(188, 262)
        Me.rowerList.TabIndex = 62
        Me.rowerList.UseCompatibleStateImageBehavior = False
        Me.rowerList.View = System.Windows.Forms.View.Details
        '
        'rowers
        '
        Me.rowers.Text = "Rowers"
        Me.rowers.Width = 180
        '
        'infoList
        '
        Me.infoList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.infoList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.raceName, Me.raceTime, Me.raceDistance, Me.position, Me.squad})
        Me.infoList.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoList.FullRowSelect = True
        Me.infoList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.infoList.HideSelection = False
        Me.infoList.Location = New System.Drawing.Point(9, 111)
        Me.infoList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.infoList.Name = "infoList"
        Me.infoList.Size = New System.Drawing.Size(539, 262)
        Me.infoList.TabIndex = 94
        Me.infoList.UseCompatibleStateImageBehavior = False
        Me.infoList.View = System.Windows.Forms.View.Details
        '
        'raceName
        '
        Me.raceName.Text = "Race Name"
        Me.raceName.Width = 74
        '
        'raceTime
        '
        Me.raceTime.Text = "Time"
        Me.raceTime.Width = 63
        '
        'raceDistance
        '
        Me.raceDistance.Text = "Distance"
        Me.raceDistance.Width = 82
        '
        'position
        '
        Me.position.Text = "Position"
        Me.position.Width = 103
        '
        'squad
        '
        Me.squad.Text = "Squad"
        Me.squad.Width = 117
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(276, 378)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 25)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Position:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 378)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 25)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Race Time:"
        '
        'minCounter
        '
        Me.minCounter.Location = New System.Drawing.Point(52, 429)
        Me.minCounter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.minCounter.Name = "minCounter"
        Me.minCounter.Size = New System.Drawing.Size(62, 26)
        Me.minCounter.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 404)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Mins"
        '
        'secCounter
        '
        Me.secCounter.Location = New System.Drawing.Point(53, 493)
        Me.secCounter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.secCounter.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.secCounter.Name = "secCounter"
        Me.secCounter.Size = New System.Drawing.Size(62, 26)
        Me.secCounter.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 468)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Secs"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 468)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 20)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "of"
        '
        'posCounter
        '
        Me.posCounter.Location = New System.Drawing.Point(290, 431)
        Me.posCounter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.posCounter.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.posCounter.Name = "posCounter"
        Me.posCounter.Size = New System.Drawing.Size(62, 26)
        Me.posCounter.TabIndex = 72
        Me.posCounter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'particiCounter
        '
        Me.particiCounter.Location = New System.Drawing.Point(290, 497)
        Me.particiCounter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.particiCounter.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.particiCounter.Name = "particiCounter"
        Me.particiCounter.Size = New System.Drawing.Size(62, 26)
        Me.particiCounter.TabIndex = 74
        Me.particiCounter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'addRower
        '
        Me.addRower.Location = New System.Drawing.Point(899, 247)
        Me.addRower.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addRower.Name = "addRower"
        Me.addRower.Size = New System.Drawing.Size(72, 29)
        Me.addRower.TabIndex = 62
        Me.addRower.Text = "Add"
        Me.addRower.UseVisualStyleBackColor = True
        '
        'searchRower
        '
        Me.searchRower.Location = New System.Drawing.Point(899, 208)
        Me.searchRower.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.searchRower.Name = "searchRower"
        Me.searchRower.Size = New System.Drawing.Size(137, 26)
        Me.searchRower.TabIndex = 60
        '
        'deleteRower
        '
        Me.deleteRower.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteRower.Location = New System.Drawing.Point(899, 111)
        Me.deleteRower.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deleteRower.Name = "deleteRower"
        Me.deleteRower.Size = New System.Drawing.Size(140, 56)
        Me.deleteRower.TabIndex = 86
        Me.deleteRower.Text = "Delete Selected Rower"
        Me.deleteRower.UseVisualStyleBackColor = True
        '
        'finish
        '
        Me.finish.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finish.Location = New System.Drawing.Point(945, 622)
        Me.finish.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(94, 53)
        Me.finish.TabIndex = 96
        Me.finish.Text = "Finish"
        Me.finish.UseVisualStyleBackColor = True
        '
        'deleteRace
        '
        Me.deleteRace.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteRace.Location = New System.Drawing.Point(556, 111)
        Me.deleteRace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deleteRace.Name = "deleteRace"
        Me.deleteRace.Size = New System.Drawing.Size(140, 56)
        Me.deleteRace.TabIndex = 95
        Me.deleteRace.Text = "Delete Selected Race"
        Me.deleteRace.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name of Event:"
        '
        'eventNameBox
        '
        Me.eventNameBox.Location = New System.Drawing.Point(22, 44)
        Me.eventNameBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eventNameBox.Name = "eventNameBox"
        Me.eventNameBox.Size = New System.Drawing.Size(148, 26)
        Me.eventNameBox.TabIndex = 0
        '
        'eventTime
        '
        Me.eventTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.eventTime.Location = New System.Drawing.Point(203, 44)
        Me.eventTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eventTime.Name = "eventTime"
        Me.eventTime.Size = New System.Drawing.Size(123, 26)
        Me.eventTime.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date of Event"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(900, 175)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 25)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Add Rower:"
        '
        'newRace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1050, 692)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.posCounter)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.yearCounter)
        Me.Controls.Add(Me.distCounter)
        Me.Controls.Add(Me.gradeCombo)
        Me.Controls.Add(Me.particiCounter)
        Me.Controls.Add(Me.crewCounter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boatCombo)
        Me.Controls.Add(Me.minCounter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.secCounter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.eventNameBox)
        Me.Controls.Add(Me.addRower)
        Me.Controls.Add(Me.eventTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.searchRower)
        Me.Controls.Add(Me.nameRace)
        Me.Controls.Add(Me.addRace)
        Me.Controls.Add(Me.rowerList)
        Me.Controls.Add(Me.deleteRower)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.infoList)
        Me.Controls.Add(Me.deleteRace)
        Me.Controls.Add(Me.finish)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newRace"
        Me.Text = "newRace"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.yearCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crewCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.distCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.secCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.posCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.particiCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents yearCounter As NumericUpDown
    Friend WithEvents gradeCombo As ComboBox
    Friend WithEvents crewCounter As NumericUpDown
    Friend WithEvents boatCombo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents distCounter As NumericUpDown
    Friend WithEvents cancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents nameRace As TextBox
    Friend WithEvents addRace As Button
    Friend WithEvents rowerList As ListView
    Friend WithEvents rowers As ColumnHeader
    Friend WithEvents infoList As ListView
    Friend WithEvents raceName As ColumnHeader
    Friend WithEvents raceTime As ColumnHeader
    Friend WithEvents raceDistance As ColumnHeader
    Friend WithEvents position As ColumnHeader
    Friend WithEvents squad As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents addRower As Button
    Friend WithEvents searchRower As TextBox
    Friend WithEvents deleteRower As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents minCounter As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents secCounter As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents posCounter As NumericUpDown
    Friend WithEvents particiCounter As NumericUpDown
    Friend WithEvents finish As Button
    Friend WithEvents deleteRace As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents eventNameBox As TextBox
    Friend WithEvents eventTime As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label16 As Label
End Class
