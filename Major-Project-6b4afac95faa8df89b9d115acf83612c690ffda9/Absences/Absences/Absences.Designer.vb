<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Absences
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.attendanceDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.attendanceName = New System.Windows.Forms.TextBox()
        Me.attendanceYear = New System.Windows.Forms.ComboBox()
        Me.attendanceSession = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAttendance = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'attendanceDateTimePicker
        '
        Me.attendanceDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendanceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.attendanceDateTimePicker.Location = New System.Drawing.Point(242, 103)
        Me.attendanceDateTimePicker.Name = "attendanceDateTimePicker"
        Me.attendanceDateTimePicker.Size = New System.Drawing.Size(102, 24)
        Me.attendanceDateTimePicker.TabIndex = 21
        '
        'attendanceName
        '
        Me.attendanceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendanceName.Location = New System.Drawing.Point(88, 102)
        Me.attendanceName.Name = "attendanceName"
        Me.attendanceName.Size = New System.Drawing.Size(132, 24)
        Me.attendanceName.TabIndex = 20
        '
        'attendanceYear
        '
        Me.attendanceYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.attendanceYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendanceYear.FormattingEnabled = True
        Me.attendanceYear.Location = New System.Drawing.Point(510, 100)
        Me.attendanceYear.Name = "attendanceYear"
        Me.attendanceYear.Size = New System.Drawing.Size(67, 26)
        Me.attendanceYear.TabIndex = 19
        '
        'attendanceSession
        '
        Me.attendanceSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.attendanceSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendanceSession.FormattingEnabled = True
        Me.attendanceSession.Location = New System.Drawing.Point(366, 101)
        Me.attendanceSession.Name = "attendanceSession"
        Me.attendanceSession.Size = New System.Drawing.Size(121, 26)
        Me.attendanceSession.TabIndex = 18
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.18518!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.81482!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(21, 164)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.56604!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.43396!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(556, 212)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Filters"
        '
        'lblAttendance
        '
        Me.lblAttendance.AutoSize = True
        Me.lblAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblAttendance.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAttendance.Location = New System.Drawing.Point(12, 28)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(199, 54)
        Me.lblAttendance.TabIndex = 15
        Me.lblAttendance.Text = "Absences"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(333, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 35)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Create new roll"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnAttendance
        '
        Me.btnAttendance.Location = New System.Drawing.Point(470, 47)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(131, 35)
        Me.btnAttendance.TabIndex = 13
        Me.btnAttendance.Text = "Attendances"
        Me.btnAttendance.UseVisualStyleBackColor = True
        '
        'Absences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(612, 412)
        Me.Controls.Add(Me.attendanceDateTimePicker)
        Me.Controls.Add(Me.attendanceName)
        Me.Controls.Add(Me.attendanceYear)
        Me.Controls.Add(Me.attendanceSession)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAttendance)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnAttendance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Absences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Absences"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents attendanceDateTimePicker As DateTimePicker
    Friend WithEvents attendanceName As TextBox
    Friend WithEvents attendanceYear As ComboBox
    Friend WithEvents attendanceSession As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAttendance As Button
End Class
