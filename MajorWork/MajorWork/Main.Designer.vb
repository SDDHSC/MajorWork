<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.calendarButton = New System.Windows.Forms.Button()
        Me.resultsButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.attendanceButton = New System.Windows.Forms.Button()
        Me.profilesButton = New System.Windows.Forms.Button()
        Me.settingsButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'calendarButton
        '
        Me.calendarButton.Location = New System.Drawing.Point(12, 102)
        Me.calendarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.calendarButton.Name = "calendarButton"
        Me.calendarButton.Size = New System.Drawing.Size(130, 97)
        Me.calendarButton.TabIndex = 0
        Me.calendarButton.Text = "Calendar"
        Me.calendarButton.UseVisualStyleBackColor = True
        '
        'resultsButton
        '
        Me.resultsButton.Location = New System.Drawing.Point(12, 208)
        Me.resultsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.resultsButton.Name = "resultsButton"
        Me.resultsButton.Size = New System.Drawing.Size(130, 97)
        Me.resultsButton.TabIndex = 3
        Me.resultsButton.Text = "Results"
        Me.resultsButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 12)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(58, 80)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Logout"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'attendanceButton
        '
        Me.attendanceButton.Location = New System.Drawing.Point(12, 314)
        Me.attendanceButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.attendanceButton.Name = "attendanceButton"
        Me.attendanceButton.Size = New System.Drawing.Size(130, 97)
        Me.attendanceButton.TabIndex = 5
        Me.attendanceButton.Text = "Attendance"
        Me.attendanceButton.UseVisualStyleBackColor = True
        '
        'profilesButton
        '
        Me.profilesButton.Location = New System.Drawing.Point(12, 422)
        Me.profilesButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.profilesButton.Name = "profilesButton"
        Me.profilesButton.Size = New System.Drawing.Size(130, 97)
        Me.profilesButton.TabIndex = 6
        Me.profilesButton.Text = "Profiles"
        Me.profilesButton.UseVisualStyleBackColor = True
        '
        'settingsButton
        '
        Me.settingsButton.Location = New System.Drawing.Point(80, 12)
        Me.settingsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.settingsButton.Name = "settingsButton"
        Me.settingsButton.Size = New System.Drawing.Size(63, 80)
        Me.settingsButton.TabIndex = 7
        Me.settingsButton.Text = "Settings"
        Me.settingsButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(150, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 692)
        Me.Panel1.TabIndex = 8
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.settingsButton)
        Me.Controls.Add(Me.profilesButton)
        Me.Controls.Add(Me.attendanceButton)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.resultsButton)
        Me.Controls.Add(Me.calendarButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents calendarButton As Button
    Friend WithEvents resultsButton As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents attendanceButton As Button
    Friend WithEvents profilesButton As Button
    Friend WithEvents settingsButton As Button
    Friend WithEvents Panel1 As Panel
End Class
