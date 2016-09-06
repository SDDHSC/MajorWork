<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainAttendanceExtra
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.coachNotes = New System.Windows.Forms.RichTextBox()
        Me.lblYearGroups = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalAbsent = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.totalPresent = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.coachOfSession = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sessionType = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sessionDate = New System.Windows.Forms.Label()
        Me.lblNewRoll = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(33, 603)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(141, 55)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(564, 423)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 31)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Notes"
        '
        'coachNotes
        '
        Me.coachNotes.Location = New System.Drawing.Point(570, 458)
        Me.coachNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.coachNotes.Name = "coachNotes"
        Me.coachNotes.ReadOnly = True
        Me.coachNotes.Size = New System.Drawing.Size(427, 198)
        Me.coachNotes.TabIndex = 81
        Me.coachNotes.Text = ""
        '
        'lblYearGroups
        '
        Me.lblYearGroups.AutoSize = True
        Me.lblYearGroups.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblYearGroups.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearGroups.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblYearGroups.Location = New System.Drawing.Point(790, 372)
        Me.lblYearGroups.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYearGroups.Name = "lblYearGroups"
        Me.lblYearGroups.Size = New System.Drawing.Size(20, 31)
        Me.lblYearGroups.TabIndex = 80
        Me.lblYearGroups.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(562, 372)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 31)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Year Groups:"
        '
        'totalAbsent
        '
        Me.totalAbsent.AutoSize = True
        Me.totalAbsent.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.totalAbsent.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAbsent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalAbsent.Location = New System.Drawing.Point(878, 322)
        Me.totalAbsent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.totalAbsent.Name = "totalAbsent"
        Me.totalAbsent.Size = New System.Drawing.Size(27, 31)
        Me.totalAbsent.TabIndex = 78
        Me.totalAbsent.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(798, 291)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 31)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Absent Students"
        '
        'totalPresent
        '
        Me.totalPresent.AutoSize = True
        Me.totalPresent.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.totalPresent.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPresent.ForeColor = System.Drawing.Color.White
        Me.totalPresent.Location = New System.Drawing.Point(636, 322)
        Me.totalPresent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.totalPresent.Name = "totalPresent"
        Me.totalPresent.Size = New System.Drawing.Size(27, 31)
        Me.totalPresent.TabIndex = 76
        Me.totalPresent.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(562, 291)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 31)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Present Students"
        '
        'coachOfSession
        '
        Me.coachOfSession.AutoSize = True
        Me.coachOfSession.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.coachOfSession.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coachOfSession.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.coachOfSession.Location = New System.Drawing.Point(798, 238)
        Me.coachOfSession.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.coachOfSession.Name = "coachOfSession"
        Me.coachOfSession.Size = New System.Drawing.Size(147, 31)
        Me.coachOfSession.TabIndex = 74
        Me.coachOfSession.Text = "Session type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(562, 238)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 31)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Coach of Session:"
        '
        'sessionType
        '
        Me.sessionType.AutoSize = True
        Me.sessionType.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.sessionType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sessionType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sessionType.Location = New System.Drawing.Point(798, 185)
        Me.sessionType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sessionType.Name = "sessionType"
        Me.sessionType.Size = New System.Drawing.Size(147, 31)
        Me.sessionType.TabIndex = 72
        Me.sessionType.Text = "Session type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(562, 185)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 31)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Session type:"
        '
        'sessionDate
        '
        Me.sessionDate.AutoSize = True
        Me.sessionDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.sessionDate.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sessionDate.ForeColor = System.Drawing.Color.White
        Me.sessionDate.Location = New System.Drawing.Point(570, 106)
        Me.sessionDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sessionDate.Name = "sessionDate"
        Me.sessionDate.Size = New System.Drawing.Size(111, 55)
        Me.sessionDate.TabIndex = 70
        Me.sessionDate.Text = "Date"
        '
        'lblNewRoll
        '
        Me.lblNewRoll.AutoSize = True
        Me.lblNewRoll.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblNewRoll.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewRoll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNewRoll.Location = New System.Drawing.Point(555, 23)
        Me.lblNewRoll.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewRoll.Name = "lblNewRoll"
        Me.lblNewRoll.Size = New System.Drawing.Size(356, 81)
        Me.lblNewRoll.TabIndex = 69
        Me.lblNewRoll.Text = "Attendance"
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(33, 71)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(504, 507)
        Me.ListView1.TabIndex = 83
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'mainAttendanceExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 692)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.coachNotes)
        Me.Controls.Add(Me.lblYearGroups)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.totalAbsent)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.totalPresent)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.coachOfSession)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sessionType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sessionDate)
        Me.Controls.Add(Me.lblNewRoll)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainAttendanceExtra"
        Me.Text = "mainAttendanceExtra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents coachNotes As RichTextBox
    Friend WithEvents lblYearGroups As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents totalAbsent As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents totalPresent As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents coachOfSession As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sessionType As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sessionDate As Label
    Friend WithEvents lblNewRoll As Label
    Friend WithEvents ListView1 As ListView
End Class
