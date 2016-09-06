<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createUser
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
        Me.lblHashed = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblSecurityAnswer = New System.Windows.Forms.Label()
        Me.lblUserLevel = New System.Windows.Forms.Label()
        Me.btnStudent = New System.Windows.Forms.RadioButton()
        Me.btnCoach = New System.Windows.Forms.RadioButton()
        Me.btnAdmin = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSecurityQuestion = New System.Windows.Forms.Label()
        Me.userLevel = New System.Windows.Forms.GroupBox()
        Me.saveNewUser = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConfirmAnswer = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.securityQuestions = New System.Windows.Forms.ComboBox()
        Me.Answer = New System.Windows.Forms.Label()
        Me.answerAgain = New System.Windows.Forms.Label()
        Me.txtNewAnswer = New System.Windows.Forms.TextBox()
        Me.groupSecurityQuestions = New System.Windows.Forms.GroupBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.groupPassword = New System.Windows.Forms.GroupBox()
        Me.currentDetails = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newUser = New System.Windows.Forms.Button()
        Me.userLevel.SuspendLayout()
        Me.groupSecurityQuestions.SuspendLayout()
        Me.groupPassword.SuspendLayout()
        Me.currentDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHashed
        '
        Me.lblHashed.AutoSize = True
        Me.lblHashed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblHashed.Location = New System.Drawing.Point(651, 244)
        Me.lblHashed.Name = "lblHashed"
        Me.lblHashed.Size = New System.Drawing.Size(34, 13)
        Me.lblHashed.TabIndex = 69
        Me.lblHashed.Text = "Blank"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(651, 106)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(34, 13)
        Me.lblUsername.TabIndex = 67
        Me.lblUsername.Text = "Blank"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(651, 159)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(34, 13)
        Me.lblPassword.TabIndex = 66
        Me.lblPassword.Text = "Blank"
        '
        'lblSecurityAnswer
        '
        Me.lblSecurityAnswer.AutoSize = True
        Me.lblSecurityAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblSecurityAnswer.Location = New System.Drawing.Point(651, 310)
        Me.lblSecurityAnswer.Name = "lblSecurityAnswer"
        Me.lblSecurityAnswer.Size = New System.Drawing.Size(34, 13)
        Me.lblSecurityAnswer.TabIndex = 65
        Me.lblSecurityAnswer.Text = "Blank"
        '
        'lblUserLevel
        '
        Me.lblUserLevel.AutoSize = True
        Me.lblUserLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblUserLevel.Location = New System.Drawing.Point(651, 345)
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(34, 13)
        Me.lblUserLevel.TabIndex = 64
        Me.lblUserLevel.Text = "Blank"
        '
        'btnStudent
        '
        Me.btnStudent.AutoSize = True
        Me.btnStudent.Location = New System.Drawing.Point(12, 114)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(92, 28)
        Me.btnStudent.TabIndex = 26
        Me.btnStudent.TabStop = True
        Me.btnStudent.Text = "Student"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'btnCoach
        '
        Me.btnCoach.AutoSize = True
        Me.btnCoach.Location = New System.Drawing.Point(12, 72)
        Me.btnCoach.Name = "btnCoach"
        Me.btnCoach.Size = New System.Drawing.Size(83, 28)
        Me.btnCoach.TabIndex = 25
        Me.btnCoach.TabStop = True
        Me.btnCoach.Text = "Coach"
        Me.btnCoach.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.AutoSize = True
        Me.btnAdmin.Location = New System.Drawing.Point(12, 28)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(137, 28)
        Me.btnAdmin.TabIndex = 24
        Me.btnAdmin.TabStop = True
        Me.btnAdmin.Text = "Administrator"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 19
        '
        'lblSecurityQuestion
        '
        Me.lblSecurityQuestion.AutoSize = True
        Me.lblSecurityQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblSecurityQuestion.Location = New System.Drawing.Point(651, 272)
        Me.lblSecurityQuestion.Name = "lblSecurityQuestion"
        Me.lblSecurityQuestion.Size = New System.Drawing.Size(34, 13)
        Me.lblSecurityQuestion.TabIndex = 68
        Me.lblSecurityQuestion.Text = "Blank"
        '
        'userLevel
        '
        Me.userLevel.Controls.Add(Me.btnStudent)
        Me.userLevel.Controls.Add(Me.btnCoach)
        Me.userLevel.Controls.Add(Me.btnAdmin)
        Me.userLevel.Controls.Add(Me.Label5)
        Me.userLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLevel.ForeColor = System.Drawing.Color.White
        Me.userLevel.Location = New System.Drawing.Point(428, 230)
        Me.userLevel.Name = "userLevel"
        Me.userLevel.Size = New System.Drawing.Size(217, 157)
        Me.userLevel.TabIndex = 62
        Me.userLevel.TabStop = False
        Me.userLevel.Text = "User Level"
        '
        'saveNewUser
        '
        Me.saveNewUser.Location = New System.Drawing.Point(568, 395)
        Me.saveNewUser.Name = "saveNewUser"
        Me.saveNewUser.Size = New System.Drawing.Size(120, 43)
        Me.saveNewUser.TabIndex = 63
        Me.saveNewUser.Text = "Save"
        Me.saveNewUser.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "New password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Confirm password"
        '
        'txtConfirmAnswer
        '
        Me.txtConfirmAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmAnswer.Location = New System.Drawing.Point(6, 163)
        Me.txtConfirmAnswer.Name = "txtConfirmAnswer"
        Me.txtConfirmAnswer.Size = New System.Drawing.Size(351, 24)
        Me.txtConfirmAnswer.TabIndex = 21
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Select Security Question"
        '
        'securityQuestions
        '
        Me.securityQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.securityQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.securityQuestions.FormattingEnabled = True
        Me.securityQuestions.Location = New System.Drawing.Point(9, 45)
        Me.securityQuestions.Name = "securityQuestions"
        Me.securityQuestions.Size = New System.Drawing.Size(348, 28)
        Me.securityQuestions.TabIndex = 22
        '
        'Answer
        '
        Me.Answer.AutoSize = True
        Me.Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer.Location = New System.Drawing.Point(6, 90)
        Me.Answer.Name = "Answer"
        Me.Answer.Size = New System.Drawing.Size(57, 18)
        Me.Answer.TabIndex = 19
        Me.Answer.Text = "Answer"
        '
        'answerAgain
        '
        Me.answerAgain.AutoSize = True
        Me.answerAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerAgain.Location = New System.Drawing.Point(6, 142)
        Me.answerAgain.Name = "answerAgain"
        Me.answerAgain.Size = New System.Drawing.Size(114, 18)
        Me.answerAgain.TabIndex = 18
        Me.answerAgain.Text = "Confirm Answer"
        '
        'txtNewAnswer
        '
        Me.txtNewAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewAnswer.Location = New System.Drawing.Point(9, 111)
        Me.txtNewAnswer.Name = "txtNewAnswer"
        Me.txtNewAnswer.Size = New System.Drawing.Size(348, 24)
        Me.txtNewAnswer.TabIndex = 20
        '
        'groupSecurityQuestions
        '
        Me.groupSecurityQuestions.Controls.Add(Me.Label6)
        Me.groupSecurityQuestions.Controls.Add(Me.securityQuestions)
        Me.groupSecurityQuestions.Controls.Add(Me.Answer)
        Me.groupSecurityQuestions.Controls.Add(Me.answerAgain)
        Me.groupSecurityQuestions.Controls.Add(Me.txtNewAnswer)
        Me.groupSecurityQuestions.Controls.Add(Me.txtConfirmAnswer)
        Me.groupSecurityQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupSecurityQuestions.ForeColor = System.Drawing.Color.White
        Me.groupSecurityQuestions.Location = New System.Drawing.Point(28, 185)
        Me.groupSecurityQuestions.Name = "groupSecurityQuestions"
        Me.groupSecurityQuestions.Size = New System.Drawing.Size(373, 202)
        Me.groupSecurityQuestions.TabIndex = 60
        Me.groupSecurityQuestions.TabStop = False
        Me.groupSecurityQuestions.Text = "Security Question"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(6, 49)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(286, 24)
        Me.txtUsername.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Enter username"
        '
        'groupPassword
        '
        Me.groupPassword.Controls.Add(Me.Label2)
        Me.groupPassword.Controls.Add(Me.Label4)
        Me.groupPassword.Controls.Add(Me.txtNewPassword)
        Me.groupPassword.Controls.Add(Me.txtConfirmPassword)
        Me.groupPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPassword.ForeColor = System.Drawing.Color.White
        Me.groupPassword.Location = New System.Drawing.Point(428, 63)
        Me.groupPassword.Name = "groupPassword"
        Me.groupPassword.Size = New System.Drawing.Size(217, 140)
        Me.groupPassword.TabIndex = 61
        Me.groupPassword.TabStop = False
        Me.groupPassword.Text = "Password"
        '
        'currentDetails
        '
        Me.currentDetails.Controls.Add(Me.txtUsername)
        Me.currentDetails.Controls.Add(Me.Label3)
        Me.currentDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentDetails.ForeColor = System.Drawing.Color.White
        Me.currentDetails.Location = New System.Drawing.Point(28, 63)
        Me.currentDetails.Name = "currentDetails"
        Me.currentDetails.Size = New System.Drawing.Size(373, 100)
        Me.currentDetails.TabIndex = 59
        Me.currentDetails.TabStop = False
        Me.currentDetails.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 31)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Create New User"
        '
        'newUser
        '
        Me.newUser.Location = New System.Drawing.Point(556, 10)
        Me.newUser.Name = "newUser"
        Me.newUser.Size = New System.Drawing.Size(120, 43)
        Me.newUser.TabIndex = 57
        Me.newUser.Text = "Back"
        Me.newUser.UseVisualStyleBackColor = True
        '
        'createUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.lblHashed)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblSecurityAnswer)
        Me.Controls.Add(Me.lblUserLevel)
        Me.Controls.Add(Me.lblSecurityQuestion)
        Me.Controls.Add(Me.userLevel)
        Me.Controls.Add(Me.saveNewUser)
        Me.Controls.Add(Me.groupSecurityQuestions)
        Me.Controls.Add(Me.groupPassword)
        Me.Controls.Add(Me.currentDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newUser)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "createUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CreateUser"
        Me.userLevel.ResumeLayout(False)
        Me.userLevel.PerformLayout()
        Me.groupSecurityQuestions.ResumeLayout(False)
        Me.groupSecurityQuestions.PerformLayout()
        Me.groupPassword.ResumeLayout(False)
        Me.groupPassword.PerformLayout()
        Me.currentDetails.ResumeLayout(False)
        Me.currentDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHashed As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblSecurityAnswer As Label
    Friend WithEvents lblUserLevel As Label
    Friend WithEvents btnStudent As RadioButton
    Friend WithEvents btnCoach As RadioButton
    Friend WithEvents btnAdmin As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSecurityQuestion As Label
    Friend WithEvents userLevel As GroupBox
    Friend WithEvents saveNewUser As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfirmAnswer As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents securityQuestions As ComboBox
    Friend WithEvents Answer As Label
    Friend WithEvents answerAgain As Label
    Friend WithEvents txtNewAnswer As TextBox
    Friend WithEvents groupSecurityQuestions As GroupBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents groupPassword As GroupBox
    Friend WithEvents currentDetails As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents newUser As Button
End Class
