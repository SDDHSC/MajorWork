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
        Me.txtError.Location = New System.Drawing.Point(783, 75)
        Me.txtError.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(232, 96)
        Me.txtError.TabIndex = 56
        '
        'cmbAm
        '
        Me.cmbAm.FormattingEnabled = True
        Me.cmbAm.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbAm.Location = New System.Drawing.Point(909, 35)
        Me.cmbAm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbAm.Name = "cmbAm"
        Me.cmbAm.Size = New System.Drawing.Size(76, 28)
        Me.cmbAm.TabIndex = 55
        '
        'numMinute
        '
        Me.numMinute.Location = New System.Drawing.Point(806, 35)
        Me.numMinute.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numMinute.Name = "numMinute"
        Me.numMinute.Size = New System.Drawing.Size(94, 26)
        Me.numMinute.TabIndex = 54
        '
        'numHour
        '
        Me.numHour.Location = New System.Drawing.Point(702, 35)
        Me.numHour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numHour.Name = "numHour"
        Me.numHour.Size = New System.Drawing.Size(94, 26)
        Me.numHour.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(486, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 48)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Start Time:"
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(910, 180)
        Me.btnFinish.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(112, 35)
        Me.btnFinish.TabIndex = 51
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(27, 228)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(30, 31)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(996, 394)
        Me.WebBrowser1.TabIndex = 50
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cmbYear.Location = New System.Drawing.Point(417, 86)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(76, 28)
        Me.cmbYear.TabIndex = 49
        Me.cmbYear.Text = "Year"
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbMonth.Location = New System.Drawing.Point(330, 86)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(76, 28)
        Me.cmbMonth.TabIndex = 48
        Me.cmbMonth.Text = "Month"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(711, 183)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Get URL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(626, 183)
        Me.Search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(81, 35)
        Me.Search.TabIndex = 46
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(243, 174)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(372, 39)
        Me.txtLocation.TabIndex = 45
        '
        'cboxParticipants3
        '
        Me.cboxParticipants3.AutoSize = True
        Me.cboxParticipants3.Location = New System.Drawing.Point(534, 138)
        Me.cboxParticipants3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboxParticipants3.Name = "cboxParticipants3"
        Me.cboxParticipants3.Size = New System.Drawing.Size(112, 24)
        Me.cboxParticipants3.TabIndex = 44
        Me.cboxParticipants3.Text = "Year 10 8s"
        Me.cboxParticipants3.UseVisualStyleBackColor = True
        '
        'cboxParticipants2
        '
        Me.cboxParticipants2.AutoSize = True
        Me.cboxParticipants2.Location = New System.Drawing.Point(388, 138)
        Me.cboxParticipants2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboxParticipants2.Name = "cboxParticipants2"
        Me.cboxParticipants2.Size = New System.Drawing.Size(133, 24)
        Me.cboxParticipants2.TabIndex = 43
        Me.cboxParticipants2.Text = "Year 9 Quads"
        Me.cboxParticipants2.UseVisualStyleBackColor = True
        '
        'cboxParticipants1
        '
        Me.cboxParticipants1.AutoSize = True
        Me.cboxParticipants1.Location = New System.Drawing.Point(243, 140)
        Me.cboxParticipants1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboxParticipants1.Name = "cboxParticipants1"
        Me.cboxParticipants1.Size = New System.Drawing.Size(133, 24)
        Me.cboxParticipants1.TabIndex = 42
        Me.cboxParticipants1.Text = "Year 8 Quads"
        Me.cboxParticipants1.UseVisualStyleBackColor = True
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDay.Location = New System.Drawing.Point(243, 86)
        Me.cmbDay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(76, 28)
        Me.cmbDay.TabIndex = 41
        Me.cmbDay.Text = "Day"
        '
        'txtEName
        '
        Me.txtEName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEName.Location = New System.Drawing.Point(243, 20)
        Me.txtEName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEName.Name = "txtEName"
        Me.txtEName.Size = New System.Drawing.Size(176, 39)
        Me.txtEName.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 118)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 48)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Participants:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 48)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 48)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 48)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Event:"
        '
        'NewEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 638)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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