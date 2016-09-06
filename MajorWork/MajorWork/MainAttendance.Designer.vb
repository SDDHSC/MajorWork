<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainAttendance
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
        Me.dateCheck = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.listAttendance = New System.Windows.Forms.ListView()
        Me.attendanceDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.coachOfSession = New System.Windows.Forms.ComboBox()
        Me.attendanceSession = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAttendance = New System.Windows.Forms.Label()
        Me.createNewRoll = New System.Windows.Forms.Button()
        Me.btnAbsences = New System.Windows.Forms.Button()
        Me.emptyCheck = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTipAttendance = New System.Windows.Forms.ToolTip(Me.components)
        Me.FilterInfo = New System.Windows.Forms.Label()
        Me.ToolTipFilterInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblInfo1 = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.lblInfo3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dateCheck
        '
        Me.dateCheck.AutoSize = True
        Me.dateCheck.Location = New System.Drawing.Point(94, 88)
        Me.dateCheck.Name = "dateCheck"
        Me.dateCheck.Size = New System.Drawing.Size(15, 14)
        Me.dateCheck.TabIndex = 48
        Me.dateCheck.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(540, 79)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(79, 28)
        Me.btnReset.TabIndex = 47
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'listAttendance
        '
        Me.listAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listAttendance.FullRowSelect = True
        Me.listAttendance.GridLines = True
        Me.listAttendance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listAttendance.Location = New System.Drawing.Point(21, 134)
        Me.listAttendance.Name = "listAttendance"
        Me.listAttendance.Size = New System.Drawing.Size(659, 305)
        Me.listAttendance.TabIndex = 46
        Me.ToolTipAttendance.SetToolTip(Me.listAttendance, "Double click for more information")
        Me.listAttendance.UseCompatibleStateImageBehavior = False
        '
        'attendanceDateTimePicker
        '
        Me.attendanceDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendanceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.attendanceDateTimePicker.Location = New System.Drawing.Point(115, 83)
        Me.attendanceDateTimePicker.Name = "attendanceDateTimePicker"
        Me.attendanceDateTimePicker.Size = New System.Drawing.Size(102, 24)
        Me.attendanceDateTimePicker.TabIndex = 45
        '
        'coachOfSession
        '
        Me.coachOfSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.coachOfSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coachOfSession.FormattingEnabled = True
        Me.coachOfSession.Location = New System.Drawing.Point(400, 81)
        Me.coachOfSession.Name = "coachOfSession"
        Me.coachOfSession.Size = New System.Drawing.Size(104, 26)
        Me.coachOfSession.TabIndex = 44
        '
        'attendanceSession
        '
        Me.attendanceSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.attendanceSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendanceSession.FormattingEnabled = True
        Me.attendanceSession.Location = New System.Drawing.Point(245, 81)
        Me.attendanceSession.Name = "attendanceSession"
        Me.attendanceSession.Size = New System.Drawing.Size(121, 26)
        Me.attendanceSession.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Filters"
        '
        'lblAttendance
        '
        Me.lblAttendance.AutoSize = True
        Me.lblAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblAttendance.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAttendance.Location = New System.Drawing.Point(12, 12)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(241, 54)
        Me.lblAttendance.TabIndex = 41
        Me.lblAttendance.Text = "Attendance"
        '
        'createNewRoll
        '
        Me.createNewRoll.Location = New System.Drawing.Point(400, 22)
        Me.createNewRoll.Name = "createNewRoll"
        Me.createNewRoll.Size = New System.Drawing.Size(131, 35)
        Me.createNewRoll.TabIndex = 40
        Me.createNewRoll.Text = "Create new roll"
        Me.createNewRoll.UseVisualStyleBackColor = True
        '
        'btnAbsences
        '
        Me.btnAbsences.Location = New System.Drawing.Point(581, 22)
        Me.btnAbsences.Name = "btnAbsences"
        Me.btnAbsences.Size = New System.Drawing.Size(107, 35)
        Me.btnAbsences.TabIndex = 39
        Me.btnAbsences.Text = "Absences"
        Me.btnAbsences.UseVisualStyleBackColor = True
        '
        'emptyCheck
        '
        Me.emptyCheck.Enabled = True
        Me.emptyCheck.Interval = 1000
        '
        'ToolTipAttendance
        '
        Me.ToolTipAttendance.AutoPopDelay = 10000
        Me.ToolTipAttendance.InitialDelay = 500
        Me.ToolTipAttendance.ReshowDelay = 100
        '
        'FilterInfo
        '
        Me.FilterInfo.AutoSize = True
        Me.FilterInfo.BackColor = System.Drawing.Color.White
        Me.FilterInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FilterInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterInfo.Location = New System.Drawing.Point(651, 82)
        Me.FilterInfo.Name = "FilterInfo"
        Me.FilterInfo.Size = New System.Drawing.Size(20, 22)
        Me.FilterInfo.TabIndex = 49
        Me.FilterInfo.Text = "?"
        '
        'ToolTipFilterInfo
        '
        Me.ToolTipFilterInfo.AutoPopDelay = 10000
        Me.ToolTipFilterInfo.InitialDelay = 500
        Me.ToolTipFilterInfo.ReshowDelay = 100
        '
        'lblInfo1
        '
        Me.lblInfo1.AutoSize = True
        Me.lblInfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInfo1.Location = New System.Drawing.Point(18, 113)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(317, 18)
        Me.lblInfo1.TabIndex = 50
        Me.lblInfo1.Text = "Double click event in table for more information"
        Me.lblInfo1.Visible = False
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInfo2.Location = New System.Drawing.Point(190, 60)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(253, 18)
        Me.lblInfo2.TabIndex = 51
        Me.lblInfo2.Text = "Select a row in drop box to apply filter"
        Me.lblInfo2.Visible = False
        '
        'lblInfo3
        '
        Me.lblInfo3.AutoSize = True
        Me.lblInfo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInfo3.Location = New System.Drawing.Point(503, 60)
        Me.lblInfo3.Name = "lblInfo3"
        Me.lblInfo3.Size = New System.Drawing.Size(148, 18)
        Me.lblInfo3.TabIndex = 52
        Me.lblInfo3.Text = "Reset clears all filters"
        Me.lblInfo3.Visible = False
        '
        'MainAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.lblInfo3)
        Me.Controls.Add(Me.lblInfo2)
        Me.Controls.Add(Me.lblInfo1)
        Me.Controls.Add(Me.FilterInfo)
        Me.Controls.Add(Me.dateCheck)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.listAttendance)
        Me.Controls.Add(Me.attendanceDateTimePicker)
        Me.Controls.Add(Me.coachOfSession)
        Me.Controls.Add(Me.attendanceSession)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAttendance)
        Me.Controls.Add(Me.createNewRoll)
        Me.Controls.Add(Me.btnAbsences)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MainAttendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dateCheck As CheckBox
    Friend WithEvents btnReset As Button
    Friend WithEvents listAttendance As ListView
    Friend WithEvents attendanceDateTimePicker As DateTimePicker
    Friend WithEvents coachOfSession As ComboBox
    Friend WithEvents attendanceSession As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents createNewRoll As Button
    Friend WithEvents btnAbsences As Button
    Friend WithEvents emptyCheck As Timer
    Friend WithEvents ToolTipAttendance As ToolTip
    Friend WithEvents FilterInfo As Label
    Friend WithEvents ToolTipFilterInfo As ToolTip
    Friend WithEvents lblInfo1 As Label
    Friend WithEvents lblInfo2 As Label
    Friend WithEvents lblInfo3 As Label
End Class
