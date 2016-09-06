<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Absences
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
        Me.components = New System.ComponentModel.Container()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ListAbsence = New System.Windows.Forms.ListView()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.absenceDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.absenceName = New System.Windows.Forms.TextBox()
        Me.absenceYear = New System.Windows.Forms.ComboBox()
        Me.absenceSession = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAttendance = New System.Windows.Forms.Label()
        Me.btncreateNewRoll = New System.Windows.Forms.Button()
        Me.emptyCheck = New System.Windows.Forms.Timer(Me.components)
        Me.dateCheck = New System.Windows.Forms.CheckBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblInfo3 = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.FilterInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(834, 112)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 46)
        Me.btnReset.TabIndex = 47
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'ListAbsence
        '
        Me.ListAbsence.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListAbsence.GridLines = True
        Me.ListAbsence.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListAbsence.Location = New System.Drawing.Point(34, 229)
        Me.ListAbsence.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListAbsence.Name = "ListAbsence"
        Me.ListAbsence.Size = New System.Drawing.Size(979, 429)
        Me.ListAbsence.TabIndex = 46
        Me.ListAbsence.UseCompatibleStateImageBehavior = False
        '
        'btnAttendance
        '
        Me.btnAttendance.Location = New System.Drawing.Point(834, 32)
        Me.btnAttendance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(166, 54)
        Me.btnAttendance.TabIndex = 38
        Me.btnAttendance.Text = "Attendances"
        Me.btnAttendance.UseVisualStyleBackColor = True
        '
        'absenceDateTimePicker
        '
        Me.absenceDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absenceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.absenceDateTimePicker.Location = New System.Drawing.Point(183, 118)
        Me.absenceDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.absenceDateTimePicker.Name = "absenceDateTimePicker"
        Me.absenceDateTimePicker.Size = New System.Drawing.Size(151, 33)
        Me.absenceDateTimePicker.TabIndex = 45
        '
        'absenceName
        '
        Me.absenceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absenceName.Location = New System.Drawing.Point(568, 178)
        Me.absenceName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.absenceName.Name = "absenceName"
        Me.absenceName.Size = New System.Drawing.Size(430, 33)
        Me.absenceName.TabIndex = 44
        '
        'absenceYear
        '
        Me.absenceYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.absenceYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absenceYear.FormattingEnabled = True
        Me.absenceYear.Items.AddRange(New Object() {"All Yrs", "7", "8", "9", "10", "11", "12"})
        Me.absenceYear.Location = New System.Drawing.Point(663, 115)
        Me.absenceYear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.absenceYear.Name = "absenceYear"
        Me.absenceYear.Size = New System.Drawing.Size(100, 37)
        Me.absenceYear.TabIndex = 43
        '
        'absenceSession
        '
        Me.absenceSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.absenceSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absenceSession.FormattingEnabled = True
        Me.absenceSession.Items.AddRange(New Object() {"All Sessions", "Erg", "Running", "Rowing", "Weights", "Other"})
        Me.absenceSession.Location = New System.Drawing.Point(388, 115)
        Me.absenceSession.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.absenceSession.Name = "absenceSession"
        Me.absenceSession.Size = New System.Drawing.Size(198, 37)
        Me.absenceSession.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(27, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 41)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Filters"
        '
        'lblAttendance
        '
        Me.lblAttendance.AutoSize = True
        Me.lblAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblAttendance.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAttendance.Location = New System.Drawing.Point(20, 11)
        Me.lblAttendance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(295, 81)
        Me.lblAttendance.TabIndex = 40
        Me.lblAttendance.Text = "Absences"
        '
        'btncreateNewRoll
        '
        Me.btncreateNewRoll.Location = New System.Drawing.Point(568, 32)
        Me.btncreateNewRoll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncreateNewRoll.Name = "btncreateNewRoll"
        Me.btncreateNewRoll.Size = New System.Drawing.Size(196, 54)
        Me.btncreateNewRoll.TabIndex = 39
        Me.btncreateNewRoll.Text = "Create new roll"
        Me.btncreateNewRoll.UseVisualStyleBackColor = True
        '
        'emptyCheck
        '
        Me.emptyCheck.Enabled = True
        Me.emptyCheck.Interval = 1000
        '
        'dateCheck
        '
        Me.dateCheck.AutoSize = True
        Me.dateCheck.Location = New System.Drawing.Point(152, 126)
        Me.dateCheck.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dateCheck.Name = "dateCheck"
        Me.dateCheck.Size = New System.Drawing.Size(22, 21)
        Me.dateCheck.TabIndex = 49
        Me.dateCheck.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(27, 171)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(492, 41)
        Me.lblSearch.TabIndex = 48
        Me.lblSearch.Text = "Search for first name OR last name"
        '
        'lblInfo3
        '
        Me.lblInfo3.AutoSize = True
        Me.lblInfo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInfo3.Location = New System.Drawing.Point(774, 86)
        Me.lblInfo3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo3.Name = "lblInfo3"
        Me.lblInfo3.Size = New System.Drawing.Size(242, 29)
        Me.lblInfo3.TabIndex = 54
        Me.lblInfo3.Text = "Reset clears all filters"
        Me.lblInfo3.Visible = False
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInfo2.Location = New System.Drawing.Point(303, 85)
        Me.lblInfo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(414, 29)
        Me.lblInfo2.TabIndex = 53
        Me.lblInfo2.Text = "Select a row in drop box to apply filter"
        Me.lblInfo2.Visible = False
        '
        'FilterInfo
        '
        Me.FilterInfo.AutoSize = True
        Me.FilterInfo.BackColor = System.Drawing.Color.White
        Me.FilterInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FilterInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterInfo.Location = New System.Drawing.Point(986, 118)
        Me.FilterInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FilterInfo.Name = "FilterInfo"
        Me.FilterInfo.Size = New System.Drawing.Size(27, 31)
        Me.FilterInfo.TabIndex = 55
        Me.FilterInfo.Text = "?"
        '
        'Absences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 692)
        Me.Controls.Add(Me.FilterInfo)
        Me.Controls.Add(Me.lblInfo3)
        Me.Controls.Add(Me.lblInfo2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.ListAbsence)
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.absenceDateTimePicker)
        Me.Controls.Add(Me.absenceName)
        Me.Controls.Add(Me.absenceYear)
        Me.Controls.Add(Me.absenceSession)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAttendance)
        Me.Controls.Add(Me.btncreateNewRoll)
        Me.Controls.Add(Me.dateCheck)
        Me.Controls.Add(Me.lblSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Absences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Absences"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents ListAbsence As ListView
    Friend WithEvents btnAttendance As Button
    Friend WithEvents absenceDateTimePicker As DateTimePicker
    Friend WithEvents absenceName As TextBox
    Friend WithEvents absenceYear As ComboBox
    Friend WithEvents absenceSession As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents btncreateNewRoll As Button
    Friend WithEvents emptyCheck As Timer
    Friend WithEvents dateCheck As CheckBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblInfo3 As Label
    Friend WithEvents lblInfo2 As Label
    Friend WithEvents FilterInfo As Label
End Class
