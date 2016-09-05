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
        Me.btnReset.Location = New System.Drawing.Point(556, 73)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(67, 30)
        Me.btnReset.TabIndex = 47
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'ListAbsence
        '
        Me.ListAbsence.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListAbsence.GridLines = True
        Me.ListAbsence.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListAbsence.Location = New System.Drawing.Point(23, 149)
        Me.ListAbsence.Name = "ListAbsence"
        Me.ListAbsence.Size = New System.Drawing.Size(654, 280)
        Me.ListAbsence.TabIndex = 46
        Me.ListAbsence.UseCompatibleStateImageBehavior = False
        '
        'btnAttendance
        '
        Me.btnAttendance.Location = New System.Drawing.Point(556, 21)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(111, 35)
        Me.btnAttendance.TabIndex = 38
        Me.btnAttendance.Text = "Attendances"
        Me.btnAttendance.UseVisualStyleBackColor = True
        '
        'absenceDateTimePicker
        '
        Me.absenceDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absenceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.absenceDateTimePicker.Location = New System.Drawing.Point(122, 77)
        Me.absenceDateTimePicker.Name = "absenceDateTimePicker"
        Me.absenceDateTimePicker.Size = New System.Drawing.Size(102, 24)
        Me.absenceDateTimePicker.TabIndex = 45
        '
        'absenceName
        '
        Me.absenceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absenceName.Location = New System.Drawing.Point(379, 116)
        Me.absenceName.Name = "absenceName"
        Me.absenceName.Size = New System.Drawing.Size(288, 24)
        Me.absenceName.TabIndex = 44
        '
        'absenceYear
        '
        Me.absenceYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.absenceYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absenceYear.FormattingEnabled = True
        Me.absenceYear.Items.AddRange(New Object() {"All Yrs", "7", "8", "9", "10", "11", "12"})
        Me.absenceYear.Location = New System.Drawing.Point(442, 75)
        Me.absenceYear.Name = "absenceYear"
        Me.absenceYear.Size = New System.Drawing.Size(68, 26)
        Me.absenceYear.TabIndex = 43
        '
        'absenceSession
        '
        Me.absenceSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.absenceSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absenceSession.FormattingEnabled = True
        Me.absenceSession.Items.AddRange(New Object() {"All Sessions", "Erg", "Running", "Rowing", "Weights", "Other"})
        Me.absenceSession.Location = New System.Drawing.Point(259, 75)
        Me.absenceSession.Name = "absenceSession"
        Me.absenceSession.Size = New System.Drawing.Size(133, 26)
        Me.absenceSession.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Filters"
        '
        'lblAttendance
        '
        Me.lblAttendance.AutoSize = True
        Me.lblAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblAttendance.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAttendance.Location = New System.Drawing.Point(13, 7)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(199, 54)
        Me.lblAttendance.TabIndex = 40
        Me.lblAttendance.Text = "Absences"
        '
        'btncreateNewRoll
        '
        Me.btncreateNewRoll.Location = New System.Drawing.Point(379, 21)
        Me.btncreateNewRoll.Name = "btncreateNewRoll"
        Me.btncreateNewRoll.Size = New System.Drawing.Size(131, 35)
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
        Me.dateCheck.Location = New System.Drawing.Point(101, 82)
        Me.dateCheck.Name = "dateCheck"
        Me.dateCheck.Size = New System.Drawing.Size(15, 14)
        Me.dateCheck.TabIndex = 49
        Me.dateCheck.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(18, 111)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(329, 28)
        Me.lblSearch.TabIndex = 48
        Me.lblSearch.Text = "Search for first name OR last name"
        '
        'lblInfo3
        '
        Me.lblInfo3.AutoSize = True
        Me.lblInfo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInfo3.Location = New System.Drawing.Point(516, 56)
        Me.lblInfo3.Name = "lblInfo3"
        Me.lblInfo3.Size = New System.Drawing.Size(148, 18)
        Me.lblInfo3.TabIndex = 54
        Me.lblInfo3.Text = "Reset clears all filters"
        Me.lblInfo3.Visible = False
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInfo2.Location = New System.Drawing.Point(202, 55)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(253, 18)
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
        Me.FilterInfo.Location = New System.Drawing.Point(657, 77)
        Me.FilterInfo.Name = "FilterInfo"
        Me.FilterInfo.Size = New System.Drawing.Size(20, 22)
        Me.FilterInfo.TabIndex = 55
        Me.FilterInfo.Text = "?"
        '
        'Absences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 450)
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
        Me.Name = "Absences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Absences"
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
