<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class markRoll
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
        Me.totalAbsent = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.totalPresent = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.coachOfSession = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.sessionType = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.sessionDate = New System.Windows.Forms.Label()
        Me.lblNewRoll = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblYearGroups = New System.Windows.Forms.Label()
        Me.coachNotes = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ToolTipListView = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblY7 = New System.Windows.Forms.Label()
        Me.lblY8 = New System.Windows.Forms.Label()
        Me.lblY12 = New System.Windows.Forms.Label()
        Me.lblY9 = New System.Windows.Forms.Label()
        Me.lblY10 = New System.Windows.Forms.Label()
        Me.lblY11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'totalAbsent
        '
        Me.totalAbsent.AutoSize = True
        Me.totalAbsent.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.totalAbsent.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAbsent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalAbsent.Location = New System.Drawing.Point(187, 214)
        Me.totalAbsent.Name = "totalAbsent"
        Me.totalAbsent.Size = New System.Drawing.Size(18, 20)
        Me.totalAbsent.TabIndex = 63
        Me.totalAbsent.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(20, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 20)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Absent Students"
        '
        'totalPresent
        '
        Me.totalPresent.AutoSize = True
        Me.totalPresent.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.totalPresent.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPresent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalPresent.Location = New System.Drawing.Point(187, 185)
        Me.totalPresent.Name = "totalPresent"
        Me.totalPresent.Size = New System.Drawing.Size(18, 20)
        Me.totalPresent.TabIndex = 61
        Me.totalPresent.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 20)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Present Students"
        '
        'coachOfSession
        '
        Me.coachOfSession.AutoSize = True
        Me.coachOfSession.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.coachOfSession.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coachOfSession.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.coachOfSession.Location = New System.Drawing.Point(178, 151)
        Me.coachOfSession.Name = "coachOfSession"
        Me.coachOfSession.Size = New System.Drawing.Size(96, 20)
        Me.coachOfSession.TabIndex = 59
        Me.coachOfSession.Text = "Session type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Coach of Session:"
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(337, 37)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(337, 331)
        Me.ListView1.TabIndex = 57
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'sessionType
        '
        Me.sessionType.AutoSize = True
        Me.sessionType.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.sessionType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sessionType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sessionType.Location = New System.Drawing.Point(178, 116)
        Me.sessionType.Name = "sessionType"
        Me.sessionType.Size = New System.Drawing.Size(96, 20)
        Me.sessionType.TabIndex = 56
        Me.sessionType.Text = "Session type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Session type:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(45, 382)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 47)
        Me.btnCancel.TabIndex = 54
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(553, 392)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 47)
        Me.btnSave.TabIndex = 53
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'sessionDate
        '
        Me.sessionDate.AutoSize = True
        Me.sessionDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.sessionDate.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sessionDate.ForeColor = System.Drawing.Color.White
        Me.sessionDate.Location = New System.Drawing.Point(26, 65)
        Me.sessionDate.Name = "sessionDate"
        Me.sessionDate.Size = New System.Drawing.Size(74, 37)
        Me.sessionDate.TabIndex = 52
        Me.sessionDate.Text = "Date"
        '
        'lblNewRoll
        '
        Me.lblNewRoll.AutoSize = True
        Me.lblNewRoll.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblNewRoll.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewRoll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNewRoll.Location = New System.Drawing.Point(16, 5)
        Me.lblNewRoll.Name = "lblNewRoll"
        Me.lblNewRoll.Size = New System.Drawing.Size(204, 54)
        Me.lblNewRoll.TabIndex = 51
        Me.lblNewRoll.Text = "Mark Roll"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Year Groups:"
        '
        'lblYearGroups
        '
        Me.lblYearGroups.AutoSize = True
        Me.lblYearGroups.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblYearGroups.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearGroups.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblYearGroups.Location = New System.Drawing.Point(173, 238)
        Me.lblYearGroups.Name = "lblYearGroups"
        Me.lblYearGroups.Size = New System.Drawing.Size(13, 20)
        Me.lblYearGroups.TabIndex = 66
        Me.lblYearGroups.Text = "."
        '
        'coachNotes
        '
        Me.coachNotes.Location = New System.Drawing.Point(26, 294)
        Me.coachNotes.Name = "coachNotes"
        Me.coachNotes.Size = New System.Drawing.Size(286, 74)
        Me.coachNotes.TabIndex = 67
        Me.coachNotes.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Notes (optional)"
        '
        'ToolTipListView
        '
        '
        'lblY7
        '
        Me.lblY7.AutoSize = True
        Me.lblY7.Location = New System.Drawing.Point(207, 399)
        Me.lblY7.Name = "lblY7"
        Me.lblY7.Size = New System.Drawing.Size(13, 13)
        Me.lblY7.TabIndex = 69
        Me.lblY7.Text = "0"
        Me.lblY7.Visible = False
        '
        'lblY8
        '
        Me.lblY8.AutoSize = True
        Me.lblY8.Location = New System.Drawing.Point(253, 399)
        Me.lblY8.Name = "lblY8"
        Me.lblY8.Size = New System.Drawing.Size(13, 13)
        Me.lblY8.TabIndex = 69
        Me.lblY8.Text = "0"
        Me.lblY8.Visible = False
        '
        'lblY12
        '
        Me.lblY12.AutoSize = True
        Me.lblY12.Location = New System.Drawing.Point(477, 399)
        Me.lblY12.Name = "lblY12"
        Me.lblY12.Size = New System.Drawing.Size(13, 13)
        Me.lblY12.TabIndex = 70
        Me.lblY12.Text = "0"
        Me.lblY12.Visible = False
        '
        'lblY9
        '
        Me.lblY9.AutoSize = True
        Me.lblY9.Location = New System.Drawing.Point(298, 399)
        Me.lblY9.Name = "lblY9"
        Me.lblY9.Size = New System.Drawing.Size(13, 13)
        Me.lblY9.TabIndex = 71
        Me.lblY9.Text = "0"
        Me.lblY9.Visible = False
        '
        'lblY10
        '
        Me.lblY10.AutoSize = True
        Me.lblY10.Location = New System.Drawing.Point(359, 399)
        Me.lblY10.Name = "lblY10"
        Me.lblY10.Size = New System.Drawing.Size(13, 13)
        Me.lblY10.TabIndex = 72
        Me.lblY10.Text = "0"
        Me.lblY10.Visible = False
        '
        'lblY11
        '
        Me.lblY11.AutoSize = True
        Me.lblY11.Location = New System.Drawing.Point(421, 399)
        Me.lblY11.Name = "lblY11"
        Me.lblY11.Size = New System.Drawing.Size(13, 13)
        Me.lblY11.TabIndex = 73
        Me.lblY11.Text = "0"
        Me.lblY11.Visible = False
        '
        'markRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.lblY11)
        Me.Controls.Add(Me.lblY10)
        Me.Controls.Add(Me.lblY9)
        Me.Controls.Add(Me.lblY12)
        Me.Controls.Add(Me.lblY8)
        Me.Controls.Add(Me.lblY7)
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
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.sessionType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.sessionDate)
        Me.Controls.Add(Me.lblNewRoll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "markRoll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "markRoll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents totalAbsent As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents totalPresent As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents coachOfSession As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents sessionType As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents sessionDate As Label
    Friend WithEvents lblNewRoll As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblYearGroups As Label
    Friend WithEvents coachNotes As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ToolTipListView As ToolTip
    Friend WithEvents lblY7 As Label
    Friend WithEvents lblY8 As Label
    Friend WithEvents lblY12 As Label
    Friend WithEvents lblY9 As Label
    Friend WithEvents lblY10 As Label
    Friend WithEvents lblY11 As Label
End Class
