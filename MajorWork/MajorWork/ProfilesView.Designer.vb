<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfilesView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RowerBox = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRaAtPc = New System.Windows.Forms.Label()
        Me.lblTrAtPc = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblSide = New System.Windows.Forms.Label()
        Me.lblBeep = New System.Windows.Forms.Label()
        Me.lbl2k = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblrClass = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lblsName = New System.Windows.Forms.Label()
        Me.lblfName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.SortBox = New System.Windows.Forms.ComboBox()
        Me.FilterBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._rowingDatabase__1_DataSet = New MajorWork._rowingDatabase__1_DataSet()
        Me.TbProfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProfilesTableAdapter = New MajorWork._rowingDatabase__1_DataSetTableAdapters.tbProfilesTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.lblNoValues = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me._rowingDatabase__1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RowerBox
        '
        Me.RowerBox.AutoScroll = True
        Me.RowerBox.Location = New System.Drawing.Point(15, 65)
        Me.RowerBox.Name = "RowerBox"
        Me.RowerBox.Size = New System.Drawing.Size(464, 373)
        Me.RowerBox.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblRaAtPc)
        Me.Panel1.Controls.Add(Me.lblTrAtPc)
        Me.Panel1.Controls.Add(Me.lblPosition)
        Me.Panel1.Controls.Add(Me.lblSide)
        Me.Panel1.Controls.Add(Me.lblBeep)
        Me.Panel1.Controls.Add(Me.lbl2k)
        Me.Panel1.Controls.Add(Me.lblWeight)
        Me.Panel1.Controls.Add(Me.lblrClass)
        Me.Panel1.Controls.Add(Me.lblGroup)
        Me.Panel1.Controls.Add(Me.lblsName)
        Me.Panel1.Controls.Add(Me.lblfName)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(485, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 426)
        Me.Panel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(7, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(293, 62)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(60, 343)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(190, 13)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.TabStop = True
        Me.lblEmail.Text = "430227866@student.sbhs.nsw.edu.au"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Email:"
        '
        'lblRaAtPc
        '
        Me.lblRaAtPc.AutoSize = True
        Me.lblRaAtPc.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblRaAtPc.Location = New System.Drawing.Point(3, 309)
        Me.lblRaAtPc.Name = "lblRaAtPc"
        Me.lblRaAtPc.Size = New System.Drawing.Size(172, 21)
        Me.lblRaAtPc.TabIndex = 12
        Me.lblRaAtPc.Text = "Race Attendance: 100%"
        '
        'lblTrAtPc
        '
        Me.lblTrAtPc.AutoSize = True
        Me.lblTrAtPc.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTrAtPc.Location = New System.Drawing.Point(3, 281)
        Me.lblTrAtPc.Name = "lblTrAtPc"
        Me.lblTrAtPc.Size = New System.Drawing.Size(195, 21)
        Me.lblTrAtPc.TabIndex = 11
        Me.lblTrAtPc.Text = "Training Attendance: 100%"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblPosition.Location = New System.Drawing.Point(3, 253)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(184, 21)
        Me.lblPosition.TabIndex = 10
        Me.lblPosition.Text = "Preferred Position: 3 Seat"
        '
        'lblSide
        '
        Me.lblSide.AutoSize = True
        Me.lblSide.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblSide.Location = New System.Drawing.Point(3, 225)
        Me.lblSide.Name = "lblSide"
        Me.lblSide.Size = New System.Drawing.Size(160, 21)
        Me.lblSide.TabIndex = 9
        Me.lblSide.Text = "Preferred Side: Stroke"
        '
        'lblBeep
        '
        Me.lblBeep.AutoSize = True
        Me.lblBeep.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblBeep.Location = New System.Drawing.Point(3, 197)
        Me.lblBeep.Name = "lblBeep"
        Me.lblBeep.Size = New System.Drawing.Size(111, 21)
        Me.lblBeep.TabIndex = 8
        Me.lblBeep.Text = "Beep Test: 12.4"
        '
        'lbl2k
        '
        Me.lbl2k.AutoSize = True
        Me.lbl2k.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl2k.Location = New System.Drawing.Point(3, 169)
        Me.lbl2k.Name = "lbl2k"
        Me.lbl2k.Size = New System.Drawing.Size(137, 21)
        Me.lbl2k.TabIndex = 7
        Me.lbl2k.Text = "2km Time: 6:23:45"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(3, 141)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(101, 21)
        Me.lblWeight.TabIndex = 6
        Me.lblWeight.Text = "Weight: 60kg"
        '
        'lblrClass
        '
        Me.lblrClass.AutoSize = True
        Me.lblrClass.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblrClass.Location = New System.Drawing.Point(119, 85)
        Me.lblrClass.Name = "lblrClass"
        Me.lblrClass.Size = New System.Drawing.Size(79, 21)
        Me.lblrClass.TabIndex = 5
        Me.lblrClass.Text = "Class: 12E"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblGroup.Location = New System.Drawing.Point(119, 113)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(108, 21)
        Me.lblGroup.TabIndex = 4
        Me.lblGroup.Text = "Year 10 Eights"
        '
        'lblsName
        '
        Me.lblsName.AutoSize = True
        Me.lblsName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblsName.Location = New System.Drawing.Point(119, 29)
        Me.lblsName.Name = "lblsName"
        Me.lblsName.Size = New System.Drawing.Size(72, 21)
        Me.lblsName.TabIndex = 3
        Me.lblsName.Text = "Manning"
        '
        'lblfName
        '
        Me.lblfName.AutoSize = True
        Me.lblfName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblfName.Location = New System.Drawing.Point(119, 57)
        Me.lblfName.Name = "lblfName"
        Me.lblfName.Size = New System.Drawing.Size(82, 21)
        Me.lblfName.TabIndex = 2
        Me.lblfName.Text = "BLACKALL"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblID.Location = New System.Drawing.Point(119, 1)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(113, 21)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID: 430227866"
        '
        'SortBox
        '
        Me.SortBox.FormattingEnabled = True
        Me.SortBox.Items.AddRange(New Object() {"By Last Name", "By First Name", "By Roll Class", "By ID Number"})
        Me.SortBox.Location = New System.Drawing.Point(62, 38)
        Me.SortBox.Name = "SortBox"
        Me.SortBox.Size = New System.Drawing.Size(180, 21)
        Me.SortBox.TabIndex = 3
        '
        'FilterBox
        '
        Me.FilterBox.FormattingEnabled = True
        Me.FilterBox.Items.AddRange(New Object() {"All Years", "1st VIII", "Year 10 Eights", "Year 9 Quads", "Year 8 Quads"})
        Me.FilterBox.Location = New System.Drawing.Point(302, 38)
        Me.FilterBox.Name = "FilterBox"
        Me.FilterBox.Size = New System.Drawing.Size(180, 21)
        Me.FilterBox.TabIndex = 4
        Me.FilterBox.Text = "All Years"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sort:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Filter:"
        '
        '_rowingDatabase__1_DataSet
        '
        Me._rowingDatabase__1_DataSet.DataSetName = "_rowingDatabase__1_DataSet"
        Me._rowingDatabase__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbProfilesBindingSource
        '
        Me.TbProfilesBindingSource.DataMember = "tbProfiles"
        Me.TbProfilesBindingSource.DataSource = Me._rowingDatabase__1_DataSet
        '
        'TbProfilesTableAdapter
        '
        Me.TbProfilesTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Search:"
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(62, 12)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(417, 20)
        Me.SearchBox.TabIndex = 8
        '
        'lblNoValues
        '
        Me.lblNoValues.AutoSize = True
        Me.lblNoValues.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoValues.Location = New System.Drawing.Point(155, 75)
        Me.lblNoValues.Name = "lblNoValues"
        Me.lblNoValues.Size = New System.Drawing.Size(153, 37)
        Me.lblNoValues.TabIndex = 9
        Me.lblNoValues.Text = "No Results"
        Me.lblNoValues.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ProfilesView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNoValues)
        Me.Controls.Add(Me.SortBox)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FilterBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RowerBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProfilesView"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._rowingDatabase__1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RowerBox As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SortBox As ComboBox
    Friend WithEvents FilterBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRaAtPc As Label
    Friend WithEvents lblTrAtPc As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblSide As Label
    Friend WithEvents lblBeep As Label
    Friend WithEvents lbl2k As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblrClass As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents lblsName As Label
    Friend WithEvents lblfName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblEmail As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents _rowingDatabase__1_DataSet As _rowingDatabase__1_DataSet
    Friend WithEvents TbProfilesBindingSource As BindingSource
    Friend WithEvents TbProfilesTableAdapter As _rowingDatabase__1_DataSetTableAdapters.tbProfilesTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblNoValues As Label
End Class
