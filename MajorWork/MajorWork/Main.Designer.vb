﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.loginButton = New System.Windows.Forms.Button()
        Me.attendanceButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChangePasswordButton = New System.Windows.Forms.Button()
        Me.profilesButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'calendarButton
        '
        Me.calendarButton.FlatAppearance.BorderSize = 0
        Me.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calendarButton.Location = New System.Drawing.Point(-1, 200)
        Me.calendarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.calendarButton.Name = "calendarButton"
        Me.calendarButton.Size = New System.Drawing.Size(153, 100)
        Me.calendarButton.TabIndex = 0
        Me.calendarButton.Text = "Calendar"
        Me.calendarButton.UseVisualStyleBackColor = True
        '
        'resultsButton
        '
        Me.resultsButton.FlatAppearance.BorderSize = 0
        Me.resultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resultsButton.Location = New System.Drawing.Point(-1, 300)
        Me.resultsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.resultsButton.Name = "resultsButton"
        Me.resultsButton.Size = New System.Drawing.Size(153, 100)
        Me.resultsButton.TabIndex = 3
        Me.resultsButton.Text = "Results"
        Me.resultsButton.UseVisualStyleBackColor = True
        '
        'loginButton
        '
        Me.loginButton.FlatAppearance.BorderSize = 0
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginButton.Location = New System.Drawing.Point(-1, 100)
        Me.loginButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(153, 100)
        Me.loginButton.TabIndex = 4
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'attendanceButton
        '
        Me.attendanceButton.FlatAppearance.BorderSize = 0
        Me.attendanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.attendanceButton.Location = New System.Drawing.Point(-1, 400)
        Me.attendanceButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.attendanceButton.Name = "attendanceButton"
        Me.attendanceButton.Size = New System.Drawing.Size(153, 100)
        Me.attendanceButton.TabIndex = 5
        Me.attendanceButton.Text = "Attendance"
        Me.attendanceButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(150, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 692)
        Me.Panel1.TabIndex = 8
        '
        'ChangePasswordButton
        '
        Me.ChangePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangePasswordButton.FlatAppearance.BorderSize = 0
        Me.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangePasswordButton.Location = New System.Drawing.Point(-1, 592)
        Me.ChangePasswordButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChangePasswordButton.Name = "ChangePasswordButton"
        Me.ChangePasswordButton.Size = New System.Drawing.Size(153, 100)
        Me.ChangePasswordButton.TabIndex = 9
        Me.ChangePasswordButton.Text = "Change Password"
        Me.ChangePasswordButton.UseVisualStyleBackColor = False
        '
        'profilesButton
        '
        Me.profilesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profilesButton.FlatAppearance.BorderSize = 0
        Me.profilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profilesButton.Location = New System.Drawing.Point(-1, 500)
        Me.profilesButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.profilesButton.Name = "profilesButton"
        Me.profilesButton.Size = New System.Drawing.Size(153, 100)
        Me.profilesButton.TabIndex = 13
        Me.profilesButton.Text = "Profiles"
        Me.profilesButton.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.profilesButton)
        Me.Controls.Add(Me.ChangePasswordButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.attendanceButton)
        Me.Controls.Add(Me.loginButton)
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
    Friend WithEvents loginButton As Button
    Friend WithEvents attendanceButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChangePasswordButton As Button
    Friend WithEvents profilesButton As Button
End Class
