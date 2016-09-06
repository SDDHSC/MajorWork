<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resetPassword
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.newPassword = New System.Windows.Forms.Label()
        Me.confirmPassword = New System.Windows.Forms.Label()
        Me.btnNext1 = New System.Windows.Forms.Button()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.groupNewPasswords = New System.Windows.Forms.GroupBox()
        Me.currentDetails = New System.Windows.Forms.GroupBox()
        Me.newUser = New System.Windows.Forms.Button()
        Me.groupNewPasswords.SuspendLayout()
        Me.currentDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 47)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Change Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(9, 158)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(260, 33)
        Me.txtConfirmPassword.TabIndex = 21
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(14, 71)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(260, 33)
        Me.txtNewPassword.TabIndex = 20
        '
        'newPassword
        '
        Me.newPassword.AutoSize = True
        Me.newPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPassword.Location = New System.Drawing.Point(9, 38)
        Me.newPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.newPassword.Name = "newPassword"
        Me.newPassword.Size = New System.Drawing.Size(174, 29)
        Me.newPassword.TabIndex = 19
        Me.newPassword.Text = "New password"
        '
        'confirmPassword
        '
        Me.confirmPassword.AutoSize = True
        Me.confirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPassword.Location = New System.Drawing.Point(9, 126)
        Me.confirmPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.confirmPassword.Name = "confirmPassword"
        Me.confirmPassword.Size = New System.Drawing.Size(208, 29)
        Me.confirmPassword.TabIndex = 18
        Me.confirmPassword.Text = "Confirm password"
        '
        'btnNext1
        '
        Me.btnNext1.Location = New System.Drawing.Point(898, 615)
        Me.btnNext1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNext1.Name = "btnNext1"
        Me.btnNext1.Size = New System.Drawing.Size(112, 35)
        Me.btnNext1.TabIndex = 22
        Me.btnNext1.Text = "Next"
        Me.btnNext1.UseVisualStyleBackColor = True
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(9, 162)
        Me.txtCurrentPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(260, 33)
        Me.txtCurrentPassword.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 29)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Enter current password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(9, 75)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(260, 33)
        Me.txtUsername.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 29)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Enter username"
        '
        'groupNewPasswords
        '
        Me.groupNewPasswords.Controls.Add(Me.newPassword)
        Me.groupNewPasswords.Controls.Add(Me.confirmPassword)
        Me.groupNewPasswords.Controls.Add(Me.txtNewPassword)
        Me.groupNewPasswords.Controls.Add(Me.txtConfirmPassword)
        Me.groupNewPasswords.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupNewPasswords.ForeColor = System.Drawing.Color.White
        Me.groupNewPasswords.Location = New System.Drawing.Point(45, 388)
        Me.groupNewPasswords.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupNewPasswords.Name = "groupNewPasswords"
        Me.groupNewPasswords.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupNewPasswords.Size = New System.Drawing.Size(525, 215)
        Me.groupNewPasswords.TabIndex = 42
        Me.groupNewPasswords.TabStop = False
        Me.groupNewPasswords.Text = "Enter new passwords"
        '
        'currentDetails
        '
        Me.currentDetails.Controls.Add(Me.txtUsername)
        Me.currentDetails.Controls.Add(Me.Label2)
        Me.currentDetails.Controls.Add(Me.txtCurrentPassword)
        Me.currentDetails.Controls.Add(Me.Label3)
        Me.currentDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentDetails.ForeColor = System.Drawing.Color.White
        Me.currentDetails.Location = New System.Drawing.Point(45, 118)
        Me.currentDetails.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.currentDetails.Name = "currentDetails"
        Me.currentDetails.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.currentDetails.Size = New System.Drawing.Size(525, 231)
        Me.currentDetails.TabIndex = 43
        Me.currentDetails.TabStop = False
        Me.currentDetails.Text = "Enter current username and password"
        '
        'newUser
        '
        Me.newUser.Location = New System.Drawing.Point(831, 26)
        Me.newUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.newUser.Name = "newUser"
        Me.newUser.Size = New System.Drawing.Size(180, 66)
        Me.newUser.TabIndex = 45
        Me.newUser.Text = "Create new user"
        Me.newUser.UseVisualStyleBackColor = True
        '
        'resetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 692)
        Me.Controls.Add(Me.newUser)
        Me.Controls.Add(Me.currentDetails)
        Me.Controls.Add(Me.groupNewPasswords)
        Me.Controls.Add(Me.btnNext1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "resetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "resetPassword"
        Me.groupNewPasswords.ResumeLayout(False)
        Me.groupNewPasswords.PerformLayout()
        Me.currentDetails.ResumeLayout(False)
        Me.currentDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents newPassword As Label
    Friend WithEvents confirmPassword As Label
    Friend WithEvents btnNext1 As Button
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents groupNewPasswords As GroupBox
    Friend WithEvents currentDetails As GroupBox
    Friend WithEvents newUser As Button
End Class
