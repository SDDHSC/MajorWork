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
        Me.txtDivision = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txt2k = New System.Windows.Forms.TextBox()
        Me.txtBeep = New System.Windows.Forms.TextBox()
        Me.txtSide = New System.Windows.Forms.TextBox()
        Me.txtSeat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Division"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2k Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Beep Test"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Preferred Side"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Preferred Seat"
        '
        'txtDivision
        '
        Me.txtDivision.Location = New System.Drawing.Point(168, 78)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(100, 20)
        Me.txtDivision.TabIndex = 8
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(167, 104)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 9
        '
        'txt2k
        '
        Me.txt2k.Location = New System.Drawing.Point(167, 130)
        Me.txt2k.Name = "txt2k"
        Me.txt2k.Size = New System.Drawing.Size(100, 20)
        Me.txt2k.TabIndex = 10
        '
        'txtBeep
        '
        Me.txtBeep.Location = New System.Drawing.Point(167, 156)
        Me.txtBeep.Name = "txtBeep"
        Me.txtBeep.Size = New System.Drawing.Size(100, 20)
        Me.txtBeep.TabIndex = 11
        '
        'txtSide
        '
        Me.txtSide.Location = New System.Drawing.Point(167, 182)
        Me.txtSide.Name = "txtSide"
        Me.txtSide.Size = New System.Drawing.Size(100, 20)
        Me.txtSide.TabIndex = 12
        '
        'txtSeat
        '
        Me.txtSeat.Location = New System.Drawing.Point(168, 208)
        Me.txtSeat.Name = "txtSeat"
        Me.txtSeat.Size = New System.Drawing.Size(100, 20)
        Me.txtSeat.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "BLACKALL, Manning"
        '
        'EditProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 232)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSeat)
        Me.Controls.Add(Me.txtSide)
        Me.Controls.Add(Me.txtBeep)
        Me.Controls.Add(Me.txt2k)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtDivision)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditProfiles"
        Me.Text = "EditProfiles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDivision As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txt2k As TextBox
    Friend WithEvents txtBeep As TextBox
    Friend WithEvents txtSide As TextBox
    Friend WithEvents txtSeat As TextBox
    Friend WithEvents Label7 As Label
End Class
