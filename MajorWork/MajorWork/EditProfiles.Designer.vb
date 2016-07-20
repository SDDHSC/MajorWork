<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProfiles
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt2k = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.numWeight = New System.Windows.Forms.NumericUpDown()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbDivision = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.numBeep = New System.Windows.Forms.NumericUpDown()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmbSide = New System.Windows.Forms.ComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmbSeat = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.numBeep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Division"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2k Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Beep Test"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Preferred Side"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Preferred Seat"
        '
        'txt2k
        '
        Me.txt2k.Location = New System.Drawing.Point(8, 67)
        Me.txt2k.Name = "txt2k"
        Me.txt2k.Size = New System.Drawing.Size(168, 20)
        Me.txt2k.TabIndex = 10
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(60, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(195, 25)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "BLACKALL, Manning"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 50)
        Me.Panel1.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.numWeight)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(12, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(182, 91)
        Me.Panel3.TabIndex = 17
        '
        'numWeight
        '
        Me.numWeight.Location = New System.Drawing.Point(8, 68)
        Me.numWeight.Name = "numWeight"
        Me.numWeight.Size = New System.Drawing.Size(168, 20)
        Me.numWeight.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.cmbDivision)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(206, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(182, 91)
        Me.Panel4.TabIndex = 18
        '
        'cmbDivision
        '
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(8, 67)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(171, 21)
        Me.cmbDivision.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel5.Controls.Add(Me.txt2k)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(12, 165)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(182, 91)
        Me.Panel5.TabIndex = 18
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel6.Controls.Add(Me.numBeep)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(206, 165)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(182, 91)
        Me.Panel6.TabIndex = 18
        '
        'numBeep
        '
        Me.numBeep.Location = New System.Drawing.Point(8, 68)
        Me.numBeep.Name = "numBeep"
        Me.numBeep.Size = New System.Drawing.Size(168, 20)
        Me.numBeep.TabIndex = 12
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel7.Controls.Add(Me.cmbSide)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Location = New System.Drawing.Point(12, 262)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(182, 91)
        Me.Panel7.TabIndex = 19
        '
        'cmbSide
        '
        Me.cmbSide.FormattingEnabled = True
        Me.cmbSide.Location = New System.Drawing.Point(8, 63)
        Me.cmbSide.Name = "cmbSide"
        Me.cmbSide.Size = New System.Drawing.Size(168, 21)
        Me.cmbSide.TabIndex = 13
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel8.Controls.Add(Me.cmbSeat)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Location = New System.Drawing.Point(206, 262)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(182, 91)
        Me.Panel8.TabIndex = 20
        '
        'cmbSeat
        '
        Me.cmbSeat.FormattingEnabled = True
        Me.cmbSeat.Location = New System.Drawing.Point(8, 63)
        Me.cmbSeat.Name = "cmbSeat"
        Me.cmbSeat.Size = New System.Drawing.Size(168, 21)
        Me.cmbSeat.TabIndex = 14
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(10, 359)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(184, 79)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(206, 359)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(182, 79)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'EditProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 450)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditProfiles"
        Me.Text = "EditProfiles"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.numBeep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt2k As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents numWeight As NumericUpDown
    Friend WithEvents cmbDivision As ComboBox
    Friend WithEvents numBeep As NumericUpDown
    Friend WithEvents cmbSide As ComboBox
    Friend WithEvents cmbSeat As ComboBox
End Class
