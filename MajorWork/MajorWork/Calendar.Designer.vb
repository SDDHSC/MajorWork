<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendar
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
        Me.resultsList = New System.Windows.Forms.ListView()
        Me.EventName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthName = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'resultsList
        '
        Me.resultsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EventName})
        Me.resultsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.resultsList.Location = New System.Drawing.Point(557, 121)
        Me.resultsList.Name = "resultsList"
        Me.resultsList.Size = New System.Drawing.Size(92, 114)
        Me.resultsList.TabIndex = 21
        Me.resultsList.UseCompatibleStateImageBehavior = False
        Me.resultsList.View = System.Windows.Forms.View.Details
        '
        'EventName
        '
        Me.EventName.Text = "EventName"
        Me.EventName.Width = 153
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(569, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "New Event"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(566, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Date clicked"
        '
        'MonthName
        '
        Me.MonthName.AutoSize = True
        Me.MonthName.Location = New System.Drawing.Point(579, 35)
        Me.MonthName.Name = "MonthName"
        Me.MonthName.Size = New System.Drawing.Size(65, 13)
        Me.MonthName.TabIndex = 18
        Me.MonthName.Text = "MonthName"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(650, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(550, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(694, 437)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 15
        Me.MonthCalendar1.Visible = False
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.resultsList)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calendar"
        Me.Text = "Calendar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents resultsList As System.Windows.Forms.ListView
    Friend WithEvents EventName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MonthName As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar

End Class
