<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newRoll
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.coachOfSession = New System.Windows.Forms.ComboBox()
        Me.lblNewRoll = New System.Windows.Forms.Label()
        Me.Year7 = New System.Windows.Forms.CheckBox()
        Me.yearGroups = New System.Windows.Forms.GroupBox()
        Me.Year8 = New System.Windows.Forms.CheckBox()
        Me.Year9 = New System.Windows.Forms.CheckBox()
        Me.Year12 = New System.Windows.Forms.CheckBox()
        Me.Year10 = New System.Windows.Forms.CheckBox()
        Me.Year11 = New System.Windows.Forms.CheckBox()
        Me.Other = New System.Windows.Forms.RadioButton()
        Me.Weights = New System.Windows.Forms.RadioButton()
        Me.Rowing = New System.Windows.Forms.RadioButton()
        Me.Running = New System.Windows.Forms.RadioButton()
        Me.Erg = New System.Windows.Forms.RadioButton()
        Me.lblRadiobtn = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCheckboxes = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.yearGroups.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.coachOfSession)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(407, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 103)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Coach of Session"
        '
        'coachOfSession
        '
        Me.coachOfSession.FormattingEnabled = True
        Me.coachOfSession.Location = New System.Drawing.Point(17, 29)
        Me.coachOfSession.Name = "coachOfSession"
        Me.coachOfSession.Size = New System.Drawing.Size(194, 32)
        Me.coachOfSession.TabIndex = 0
        '
        'lblNewRoll
        '
        Me.lblNewRoll.AutoSize = True
        Me.lblNewRoll.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblNewRoll.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewRoll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNewRoll.Location = New System.Drawing.Point(19, 14)
        Me.lblNewRoll.Name = "lblNewRoll"
        Me.lblNewRoll.Size = New System.Drawing.Size(326, 54)
        Me.lblNewRoll.TabIndex = 40
        Me.lblNewRoll.Text = "Create New Roll"
        '
        'Year7
        '
        Me.Year7.AutoSize = True
        Me.Year7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Year7.Location = New System.Drawing.Point(23, 27)
        Me.Year7.Name = "Year7"
        Me.Year7.Size = New System.Drawing.Size(66, 20)
        Me.Year7.TabIndex = 23
        Me.Year7.Text = "Year 7"
        Me.Year7.UseVisualStyleBackColor = True
        '
        'yearGroups
        '
        Me.yearGroups.Controls.Add(Me.Year8)
        Me.yearGroups.Controls.Add(Me.Year9)
        Me.yearGroups.Controls.Add(Me.Year12)
        Me.yearGroups.Controls.Add(Me.Year10)
        Me.yearGroups.Controls.Add(Me.Year11)
        Me.yearGroups.Controls.Add(Me.Year7)
        Me.yearGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearGroups.ForeColor = System.Drawing.Color.White
        Me.yearGroups.Location = New System.Drawing.Point(41, 83)
        Me.yearGroups.Name = "yearGroups"
        Me.yearGroups.Size = New System.Drawing.Size(156, 280)
        Me.yearGroups.TabIndex = 41
        Me.yearGroups.TabStop = False
        Me.yearGroups.Text = "Year Group"
        '
        'Year8
        '
        Me.Year8.AutoSize = True
        Me.Year8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Year8.Location = New System.Drawing.Point(23, 68)
        Me.Year8.Name = "Year8"
        Me.Year8.Size = New System.Drawing.Size(66, 20)
        Me.Year8.TabIndex = 28
        Me.Year8.Text = "Year 8"
        Me.Year8.UseVisualStyleBackColor = True
        '
        'Year9
        '
        Me.Year9.AutoSize = True
        Me.Year9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Year9.Location = New System.Drawing.Point(23, 113)
        Me.Year9.Name = "Year9"
        Me.Year9.Size = New System.Drawing.Size(66, 20)
        Me.Year9.TabIndex = 27
        Me.Year9.Text = "Year 9"
        Me.Year9.UseVisualStyleBackColor = True
        '
        'Year12
        '
        Me.Year12.AutoSize = True
        Me.Year12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Year12.Location = New System.Drawing.Point(23, 244)
        Me.Year12.Name = "Year12"
        Me.Year12.Size = New System.Drawing.Size(73, 20)
        Me.Year12.TabIndex = 26
        Me.Year12.Text = "Year 12"
        Me.Year12.UseVisualStyleBackColor = True
        '
        'Year10
        '
        Me.Year10.AutoSize = True
        Me.Year10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Year10.Location = New System.Drawing.Point(23, 158)
        Me.Year10.Name = "Year10"
        Me.Year10.Size = New System.Drawing.Size(73, 20)
        Me.Year10.TabIndex = 25
        Me.Year10.Text = "Year 10"
        Me.Year10.UseVisualStyleBackColor = True
        '
        'Year11
        '
        Me.Year11.AutoSize = True
        Me.Year11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Year11.Location = New System.Drawing.Point(23, 200)
        Me.Year11.Name = "Year11"
        Me.Year11.Size = New System.Drawing.Size(73, 20)
        Me.Year11.TabIndex = 24
        Me.Year11.Text = "Year 11"
        Me.Year11.UseVisualStyleBackColor = True
        '
        'Other
        '
        Me.Other.AutoSize = True
        Me.Other.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Other.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Other.Location = New System.Drawing.Point(20, 242)
        Me.Other.Name = "Other"
        Me.Other.Size = New System.Drawing.Size(59, 21)
        Me.Other.TabIndex = 22
        Me.Other.TabStop = True
        Me.Other.Text = "Other"
        Me.Other.UseVisualStyleBackColor = True
        '
        'Weights
        '
        Me.Weights.AutoSize = True
        Me.Weights.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Weights.Location = New System.Drawing.Point(20, 187)
        Me.Weights.Name = "Weights"
        Me.Weights.Size = New System.Drawing.Size(73, 21)
        Me.Weights.TabIndex = 21
        Me.Weights.TabStop = True
        Me.Weights.Text = "Weights"
        Me.Weights.UseVisualStyleBackColor = True
        '
        'Rowing
        '
        Me.Rowing.AutoSize = True
        Me.Rowing.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rowing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rowing.Location = New System.Drawing.Point(20, 127)
        Me.Rowing.Name = "Rowing"
        Me.Rowing.Size = New System.Drawing.Size(69, 21)
        Me.Rowing.TabIndex = 20
        Me.Rowing.TabStop = True
        Me.Rowing.Text = "Rowing"
        Me.Rowing.UseVisualStyleBackColor = True
        '
        'Running
        '
        Me.Running.AutoSize = True
        Me.Running.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Running.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Running.Location = New System.Drawing.Point(20, 72)
        Me.Running.Name = "Running"
        Me.Running.Size = New System.Drawing.Size(73, 21)
        Me.Running.TabIndex = 19
        Me.Running.TabStop = True
        Me.Running.Text = "Running"
        Me.Running.UseVisualStyleBackColor = True
        '
        'Erg
        '
        Me.Erg.AutoSize = True
        Me.Erg.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Erg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Erg.Location = New System.Drawing.Point(20, 21)
        Me.Erg.Name = "Erg"
        Me.Erg.Size = New System.Drawing.Size(46, 21)
        Me.Erg.TabIndex = 17
        Me.Erg.TabStop = True
        Me.Erg.Text = "Erg"
        Me.Erg.UseVisualStyleBackColor = True
        '
        'lblRadiobtn
        '
        Me.lblRadiobtn.AutoSize = True
        Me.lblRadiobtn.ForeColor = System.Drawing.Color.Red
        Me.lblRadiobtn.Location = New System.Drawing.Point(249, 369)
        Me.lblRadiobtn.Name = "lblRadiobtn"
        Me.lblRadiobtn.Size = New System.Drawing.Size(107, 13)
        Me.lblRadiobtn.TabIndex = 46
        Me.lblRadiobtn.Text = "Select a session type"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(540, 393)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(131, 39)
        Me.btnCreate.TabIndex = 44
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(41, 393)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(131, 39)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Other)
        Me.GroupBox1.Controls.Add(Me.Weights)
        Me.GroupBox1.Controls.Add(Me.Rowing)
        Me.GroupBox1.Controls.Add(Me.Running)
        Me.GroupBox1.Controls.Add(Me.Erg)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(215, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 280)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Session Type"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(7, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(205, 26)
        Me.DateTimePicker1.TabIndex = 26
        Me.DateTimePicker1.Value = New Date(2016, 3, 1, 0, 0, 0, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(407, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 171)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date"
        '
        'lblCheckboxes
        '
        Me.lblCheckboxes.AutoSize = True
        Me.lblCheckboxes.ForeColor = System.Drawing.Color.Red
        Me.lblCheckboxes.Location = New System.Drawing.Point(80, 369)
        Me.lblCheckboxes.Name = "lblCheckboxes"
        Me.lblCheckboxes.Size = New System.Drawing.Size(99, 13)
        Me.lblCheckboxes.TabIndex = 47
        Me.lblCheckboxes.Text = "Select a year group"
        '
        'newRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblNewRoll)
        Me.Controls.Add(Me.yearGroups)
        Me.Controls.Add(Me.lblRadiobtn)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblCheckboxes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newRoll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "newRoll"
        Me.GroupBox3.ResumeLayout(False)
        Me.yearGroups.ResumeLayout(False)
        Me.yearGroups.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents coachOfSession As ComboBox
    Friend WithEvents lblNewRoll As Label
    Friend WithEvents Year7 As CheckBox
    Friend WithEvents yearGroups As GroupBox
    Friend WithEvents Year8 As CheckBox
    Friend WithEvents Year9 As CheckBox
    Friend WithEvents Year12 As CheckBox
    Friend WithEvents Year10 As CheckBox
    Friend WithEvents Year11 As CheckBox
    Friend WithEvents Other As RadioButton
    Friend WithEvents Weights As RadioButton
    Friend WithEvents Rowing As RadioButton
    Friend WithEvents Running As RadioButton
    Friend WithEvents Erg As RadioButton
    Friend WithEvents lblRadiobtn As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCheckboxes As Label
End Class
