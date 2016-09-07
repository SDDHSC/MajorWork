<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewEvent
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
        Me.cmbAm = New System.Windows.Forms.ComboBox()
        Me.numMinute = New System.Windows.Forms.NumericUpDown()
        Me.numHour = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.cboxParticipants3 = New System.Windows.Forms.CheckBox()
        Me.cboxParticipants2 = New System.Windows.Forms.CheckBox()
        Me.cboxParticipants1 = New System.Windows.Forms.CheckBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.txtEName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboxParticipants4 = New System.Windows.Forms.CheckBox()
        Me.info2 = New System.Windows.Forms.Label()
        Me.info4 = New System.Windows.Forms.Label()
        Me.info5 = New System.Windows.Forms.Label()
        Me.info7 = New System.Windows.Forms.Label()
        Me.info6 = New System.Windows.Forms.Label()
        Me.info8 = New System.Windows.Forms.Label()
        Me.info1 = New System.Windows.Forms.Label()
        Me.info3 = New System.Windows.Forms.Label()
        Me.info10 = New System.Windows.Forms.Label()
        Me.info9 = New System.Windows.Forms.Label()
        Me.filterinfo = New System.Windows.Forms.Label()
        CType(Me.numMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAm
        '
        Me.cmbAm.FormattingEnabled = True
        Me.cmbAm.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbAm.Location = New System.Drawing.Point(632, 22)
        Me.cmbAm.Name = "cmbAm"
        Me.cmbAm.Size = New System.Drawing.Size(52, 21)
        Me.cmbAm.TabIndex = 55
        Me.cmbAm.Text = "AM"
        '
        'numMinute
        '
        Me.numMinute.Location = New System.Drawing.Point(563, 22)
        Me.numMinute.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.numMinute.Name = "numMinute"
        Me.numMinute.Size = New System.Drawing.Size(63, 20)
        Me.numMinute.TabIndex = 54
        '
        'numHour
        '
        Me.numHour.Location = New System.Drawing.Point(494, 22)
        Me.numHour.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numHour.Name = "numHour"
        Me.numHour.Size = New System.Drawing.Size(63, 20)
        Me.numHour.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(350, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 32)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Start Time:"
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(603, 110)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 51
        Me.btnFinish.Text = "Save"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(18, 139)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(664, 256)
        Me.WebBrowser1.TabIndex = 50
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020", "2021"})
        Me.cmbYear.Location = New System.Drawing.Point(278, 56)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(52, 21)
        Me.cmbYear.TabIndex = 49
        Me.cmbYear.Text = "Year"
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbMonth.Location = New System.Drawing.Point(220, 56)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(52, 21)
        Me.cmbMonth.TabIndex = 48
        Me.cmbMonth.Text = "Month"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(367, 110)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(54, 23)
        Me.Search.TabIndex = 46
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(162, 104)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(199, 29)
        Me.txtLocation.TabIndex = 45
        '
        'cboxParticipants3
        '
        Me.cboxParticipants3.AutoSize = True
        Me.cboxParticipants3.Location = New System.Drawing.Point(497, 81)
        Me.cboxParticipants3.Name = "cboxParticipants3"
        Me.cboxParticipants3.Size = New System.Drawing.Size(77, 17)
        Me.cboxParticipants3.TabIndex = 44
        Me.cboxParticipants3.Text = "Year 10 8s"
        Me.cboxParticipants3.UseVisualStyleBackColor = True
        '
        'cboxParticipants2
        '
        Me.cboxParticipants2.AutoSize = True
        Me.cboxParticipants2.Location = New System.Drawing.Point(591, 58)
        Me.cboxParticipants2.Name = "cboxParticipants2"
        Me.cboxParticipants2.Size = New System.Drawing.Size(91, 17)
        Me.cboxParticipants2.TabIndex = 43
        Me.cboxParticipants2.Text = "Year 9 Quads"
        Me.cboxParticipants2.UseVisualStyleBackColor = True
        '
        'cboxParticipants1
        '
        Me.cboxParticipants1.AutoSize = True
        Me.cboxParticipants1.Location = New System.Drawing.Point(497, 58)
        Me.cboxParticipants1.Name = "cboxParticipants1"
        Me.cboxParticipants1.Size = New System.Drawing.Size(91, 17)
        Me.cboxParticipants1.TabIndex = 42
        Me.cboxParticipants1.Text = "Year 8 Quads"
        Me.cboxParticipants1.UseVisualStyleBackColor = True
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDay.Location = New System.Drawing.Point(162, 56)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(52, 21)
        Me.cmbDay.TabIndex = 41
        Me.cmbDay.Text = "Day"
        '
        'txtEName
        '
        Me.txtEName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEName.Location = New System.Drawing.Point(162, 13)
        Me.txtEName.Name = "txtEName"
        Me.txtEName.Size = New System.Drawing.Size(119, 29)
        Me.txtEName.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(350, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 32)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Participants:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 32)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 32)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 32)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Event:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(526, 110)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 57
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(604, 110)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 58
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(445, 110)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 59
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cboxParticipants4
        '
        Me.cboxParticipants4.AutoSize = True
        Me.cboxParticipants4.Location = New System.Drawing.Point(591, 81)
        Me.cboxParticipants4.Name = "cboxParticipants4"
        Me.cboxParticipants4.Size = New System.Drawing.Size(59, 17)
        Me.cboxParticipants4.TabIndex = 60
        Me.cboxParticipants4.Text = "1st VIII"
        Me.cboxParticipants4.UseVisualStyleBackColor = True
        '
        'info2
        '
        Me.info2.AutoSize = True
        Me.info2.Location = New System.Drawing.Point(84, 7)
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(72, 39)
        Me.info2.TabIndex = 61
        Me.info2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter new  →" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "event name"
        Me.info2.Visible = False
        '
        'info4
        '
        Me.info4.AutoSize = True
        Me.info4.Location = New System.Drawing.Point(82, 93)
        Me.info4.Name = "info4"
        Me.info4.Size = New System.Drawing.Size(74, 39)
        Me.info4.TabIndex = 63
        Me.info4.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter new →" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "event location"
        Me.info4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info4.Visible = False
        '
        'info5
        '
        Me.info5.AutoSize = True
        Me.info5.Location = New System.Drawing.Point(353, 140)
        Me.info5.Name = "info5"
        Me.info5.Size = New System.Drawing.Size(82, 52)
        Me.info5.TabIndex = 64
        Me.info5.Text = "↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click search to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "find location on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "google maps"
        Me.info5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info5.Visible = False
        '
        'info7
        '
        Me.info7.AutoSize = True
        Me.info7.Location = New System.Drawing.Point(606, 140)
        Me.info7.Name = "info7"
        Me.info7.Size = New System.Drawing.Size(72, 39)
        Me.info7.TabIndex = 65
        Me.info7.Text = "↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to finish " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and save"
        Me.info7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info7.Visible = False
        '
        'info6
        '
        Me.info6.AutoSize = True
        Me.info6.Location = New System.Drawing.Point(529, 140)
        Me.info6.Name = "info6"
        Me.info6.Size = New System.Drawing.Size(72, 39)
        Me.info6.TabIndex = 66
        Me.info6.Text = "↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to return" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to calendar"
        Me.info6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info6.Visible = False
        '
        'info8
        '
        Me.info8.AutoSize = True
        Me.info8.Location = New System.Drawing.Point(377, 56)
        Me.info8.Name = "info8"
        Me.info8.Size = New System.Drawing.Size(111, 26)
        Me.info8.TabIndex = 67
        Me.info8.Text = "Select participants  →" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of new event"
        Me.info8.Visible = False
        '
        'info1
        '
        Me.info1.AutoSize = True
        Me.info1.Location = New System.Drawing.Point(399, 13)
        Me.info1.Name = "info1"
        Me.info1.Size = New System.Drawing.Size(89, 26)
        Me.info1.TabIndex = 68
        Me.info1.Text = "Select start time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of event name →" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.info1.Visible = False
        '
        'info3
        '
        Me.info3.AutoSize = True
        Me.info3.Location = New System.Drawing.Point(78, 58)
        Me.info3.Name = "info3"
        Me.info3.Size = New System.Drawing.Size(78, 26)
        Me.info3.TabIndex = 69
        Me.info3.Text = "Select date  →" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of new event"
        Me.info3.Visible = False
        '
        'info10
        '
        Me.info10.AutoSize = True
        Me.info10.Location = New System.Drawing.Point(608, 140)
        Me.info10.Name = "info10"
        Me.info10.Size = New System.Drawing.Size(67, 39)
        Me.info10.TabIndex = 70
        Me.info10.Text = "↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "event details"
        Me.info10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info10.Visible = False
        '
        'info9
        '
        Me.info9.AutoSize = True
        Me.info9.Location = New System.Drawing.Point(454, 140)
        Me.info9.Name = "info9"
        Me.info9.Size = New System.Drawing.Size(66, 39)
        Me.info9.TabIndex = 71
        Me.info9.Text = "↑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "delete event"
        Me.info9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info9.Visible = False
        '
        'filterinfo
        '
        Me.filterinfo.AutoSize = True
        Me.filterinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterinfo.Location = New System.Drawing.Point(304, 9)
        Me.filterinfo.Name = "filterinfo"
        Me.filterinfo.Size = New System.Drawing.Size(45, 39)
        Me.filterinfo.TabIndex = 72
        Me.filterinfo.Text = "Hover " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Help"
        Me.filterinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.filterinfo)
        Me.Controls.Add(Me.info9)
        Me.Controls.Add(Me.info10)
        Me.Controls.Add(Me.info3)
        Me.Controls.Add(Me.info1)
        Me.Controls.Add(Me.info8)
        Me.Controls.Add(Me.info6)
        Me.Controls.Add(Me.info7)
        Me.Controls.Add(Me.info5)
        Me.Controls.Add(Me.info4)
        Me.Controls.Add(Me.info2)
        Me.Controls.Add(Me.cboxParticipants4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cmbAm)
        Me.Controls.Add(Me.numMinute)
        Me.Controls.Add(Me.numHour)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.cboxParticipants3)
        Me.Controls.Add(Me.cboxParticipants2)
        Me.Controls.Add(Me.cboxParticipants1)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.txtEName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewEvent"
        Me.Text = "NewEvent"
        CType(Me.numMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbAm As System.Windows.Forms.ComboBox
    Friend WithEvents numMinute As System.Windows.Forms.NumericUpDown
    Friend WithEvents numHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents cboxParticipants3 As System.Windows.Forms.CheckBox
    Friend WithEvents cboxParticipants2 As System.Windows.Forms.CheckBox
    Friend WithEvents cboxParticipants1 As System.Windows.Forms.CheckBox
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents txtEName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cboxParticipants4 As System.Windows.Forms.CheckBox
    Friend WithEvents info2 As System.Windows.Forms.Label
    Friend WithEvents info4 As System.Windows.Forms.Label
    Friend WithEvents info5 As System.Windows.Forms.Label
    Friend WithEvents info7 As System.Windows.Forms.Label
    Friend WithEvents info6 As System.Windows.Forms.Label
    Friend WithEvents info8 As System.Windows.Forms.Label
    Friend WithEvents info1 As System.Windows.Forms.Label
    Friend WithEvents info3 As System.Windows.Forms.Label
    Friend WithEvents info10 As System.Windows.Forms.Label
    Friend WithEvents info9 As System.Windows.Forms.Label
    Friend WithEvents filterinfo As System.Windows.Forms.Label
End Class