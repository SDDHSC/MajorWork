<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfilesView
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
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RowerBox = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(485, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 367)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'RowerBox
        '
        Me.RowerBox.AutoScroll = True
        Me.RowerBox.Location = New System.Drawing.Point(12, 12)
        Me.RowerBox.Name = "RowerBox"
        Me.RowerBox.Size = New System.Drawing.Size(467, 367)
        Me.RowerBox.TabIndex = 1
        '
        'ProfilesView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 391)
        Me.Controls.Add(Me.RowerBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ProfilesView"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RowerBox As FlowLayoutPanel
    Friend WithEvents TextBox1 As RichTextBox
End Class
