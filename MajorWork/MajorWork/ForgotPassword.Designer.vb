<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Me.back = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.currentDetails = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.SecurityQuestions = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.groupNewPasswords = New System.Windows.Forms.GroupBox()
        Me.newPassword = New System.Windows.Forms.Label()
        Me.confirmPassword = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.currentDetails.SuspendLayout()
        Me.groupNewPasswords.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Forgot password? Reset here"
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(12, 399)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(90, 39)
        Me.back.TabIndex = 10
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(602, 399)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(86, 39)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'currentDetails
        '
        Me.currentDetails.Controls.Add(Me.Label3)
        Me.currentDetails.Controls.Add(Me.txtSecurityAnswer)
        Me.currentDetails.Controls.Add(Me.SecurityQuestions)
        Me.currentDetails.Controls.Add(Me.Label2)
        Me.currentDetails.Controls.Add(Me.txtUsername)
        Me.currentDetails.Controls.Add(Me.Label4)
        Me.currentDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentDetails.ForeColor = System.Drawing.Color.White
        Me.currentDetails.Location = New System.Drawing.Point(18, 75)
        Me.currentDetails.Name = "currentDetails"
        Me.currentDetails.Size = New System.Drawing.Size(350, 297)
        Me.currentDetails.TabIndex = 44
        Me.currentDetails.TabStop = False
        Me.currentDetails.Text = "Enter current username and password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Answer"
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(18, 224)
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(175, 24)
        Me.txtSecurityAnswer.TabIndex = 34
        '
        'SecurityQuestions
        '
        Me.SecurityQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SecurityQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityQuestions.Location = New System.Drawing.Point(18, 132)
        Me.SecurityQuestions.Name = "SecurityQuestions"
        Me.SecurityQuestions.Size = New System.Drawing.Size(311, 28)
        Me.SecurityQuestions.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Security Question"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(18, 49)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(175, 24)
        Me.txtUsername.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 18)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Enter username"
        '
        'groupNewPasswords
        '
        Me.groupNewPasswords.Controls.Add(Me.newPassword)
        Me.groupNewPasswords.Controls.Add(Me.confirmPassword)
        Me.groupNewPasswords.Controls.Add(Me.txtNewPassword)
        Me.groupNewPasswords.Controls.Add(Me.txtConfirmPassword)
        Me.groupNewPasswords.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupNewPasswords.ForeColor = System.Drawing.Color.White
        Me.groupNewPasswords.Location = New System.Drawing.Point(400, 75)
        Me.groupNewPasswords.Name = "groupNewPasswords"
        Me.groupNewPasswords.Size = New System.Drawing.Size(244, 297)
        Me.groupNewPasswords.TabIndex = 45
        Me.groupNewPasswords.TabStop = False
        Me.groupNewPasswords.Text = "Enter new passwords"
        '
        'newPassword
        '
        Me.newPassword.AutoSize = True
        Me.newPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPassword.Location = New System.Drawing.Point(6, 25)
        Me.newPassword.Name = "newPassword"
        Me.newPassword.Size = New System.Drawing.Size(107, 18)
        Me.newPassword.TabIndex = 19
        Me.newPassword.Text = "New password"
        '
        'confirmPassword
        '
        Me.confirmPassword.AutoSize = True
        Me.confirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPassword.Location = New System.Drawing.Point(6, 82)
        Me.confirmPassword.Name = "confirmPassword"
        Me.confirmPassword.Size = New System.Drawing.Size(130, 18)
        Me.confirmPassword.TabIndex = 18
        Me.confirmPassword.Text = "Confirm password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(9, 46)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(175, 24)
        Me.txtNewPassword.TabIndex = 20
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(6, 103)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(175, 24)
        Me.txtConfirmPassword.TabIndex = 21
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.groupNewPasswords)
        Me.Controls.Add(Me.currentDetails)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPassword"
        Me.Text = "ForgotPassword"
        Me.currentDetails.ResumeLayout(False)
        Me.currentDetails.PerformLayout()
        Me.groupNewPasswords.ResumeLayout(False)
        Me.groupNewPasswords.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents back As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents currentDetails As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents groupNewPasswords As GroupBox
    Friend WithEvents newPassword As Label
    Friend WithEvents confirmPassword As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents SecurityQuestions As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSecurityAnswer As TextBox
End Class
