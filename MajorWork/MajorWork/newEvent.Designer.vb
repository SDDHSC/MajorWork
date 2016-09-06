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
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.cmbAm = New System.Windows.Forms.ComboBox()
        Me.numMinute = New System.Windows.Forms.NumericUpDown()
        Me.numHour = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        CType(Me.numMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(522, 49)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(156, 64)
        Me.txtError.TabIndex = 56
        '
        'cmbAm
        '
        Me.cmbAm.FormattingEnabled = True
        Me.cmbAm.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbAm.Location = New System.Drawing.Point(606, 23)
        Me.cmbAm.Name = "cmbAm"
        Me.cmbAm.Size = New System.Drawing.Size(52, 21)
        Me.cmbAm.TabIndex = 55
        '
        'numMinute
        '
        Me.numMinute.Location = New System.Drawing.Point(537, 23)
        Me.numMinute.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.numMinute.Name = "numMinute"
        Me.numMinute.Size = New System.Drawing.Size(63, 20)
        Me.numMinute.TabIndex = 54
        '
        'numHour
        '
        Me.numHour.Location = New System.Drawing.Point(468, 23)
        Me.numHour.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numHour.Name = "numHour"
        Me.numHour.Size = New System.Drawing.Size(63, 20)
        Me.numHour.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 32)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Start Time:"
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(607, 117)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 51
        Me.btnFinish.Text = "Save"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(18, 148)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(474, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Get URL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(417, 119)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(54, 23)
        Me.Search.TabIndex = 46
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(162, 113)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(249, 29)
        Me.txtLocation.TabIndex = 45
        '
        'cboxParticipants3
        '
        Me.cboxParticipants3.AutoSize = True
        Me.cboxParticipants3.Location = New System.Drawing.Point(356, 90)
        Me.cboxParticipants3.Name = "cboxParticipants3"
        Me.cboxParticipants3.Size = New System.Drawing.Size(77, 17)
        Me.cboxParticipants3.TabIndex = 44
        Me.cboxParticipants3.Text = "Year 10 8s"
        Me.cboxParticipants3.UseVisualStyleBackColor = True
        '
        'cboxParticipants2
        '
        Me.cboxParticipants2.AutoSize = True
        Me.cboxParticipants2.Location = New System.Drawing.Point(259, 90)
        Me.cboxParticipants2.Name = "cboxParticipants2"
        Me.cboxParticipants2.Size = New System.Drawing.Size(91, 17)
        Me.cboxParticipants2.TabIndex = 43
        Me.cboxParticipants2.Text = "Year 9 Quads"
        Me.cboxParticipants2.UseVisualStyleBackColor = True
        '
        'cboxParticipants1
        '
        Me.cboxParticipants1.AutoSize = True
        Me.cboxParticipants1.Location = New System.Drawing.Point(162, 91)
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
        Me.Label5.Location = New System.Drawing.Point(18, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 32)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Participants:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 107)
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
        'NewEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 415)
        Me.Controls.Add(Me.txtError)
        Me.Controls.Add(Me.cmbAm)
        Me.Controls.Add(Me.numMinute)
        Me.Controls.Add(Me.numHour)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents txtError As System.Windows.Forms.TextBox
      Friend WithEvents cmbAm As System.Windows.Forms.ComboBox
      Friend WithEvents numMinute As System.Windows.Forms.NumericUpDown
      Friend WithEvents numHour As System.Windows.Forms.NumericUpDown
      Friend WithEvents Label4 As System.Windows.Forms.Label
      Friend WithEvents btnFinish As System.Windows.Forms.Button
      Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
      Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
      Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
      Friend WithEvents Button1 As System.Windows.Forms.Button
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
  End Class