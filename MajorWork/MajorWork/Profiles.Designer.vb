<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profiles
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._rowingDatabase__1_DataSet = New MajorWork._rowingDatabase__1_DataSet()
        Me.TbProfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProfilesTableAdapter = New MajorWork._rowingDatabase__1_DataSetTableAdapters.tbProfilesTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rowingDatabase__1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.GNameDataGridViewTextBoxColumn, Me.SNameDataGridViewTextBoxColumn, Me.RClassDataGridViewTextBoxColumn, Me.GroupDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbProfilesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(676, 426)
        Me.DataGridView1.TabIndex = 0
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'GNameDataGridViewTextBoxColumn
        '
        Me.GNameDataGridViewTextBoxColumn.DataPropertyName = "gName"
        Me.GNameDataGridViewTextBoxColumn.HeaderText = "gName"
        Me.GNameDataGridViewTextBoxColumn.Name = "GNameDataGridViewTextBoxColumn"
        '
        'SNameDataGridViewTextBoxColumn
        '
        Me.SNameDataGridViewTextBoxColumn.DataPropertyName = "sName"
        Me.SNameDataGridViewTextBoxColumn.HeaderText = "sName"
        Me.SNameDataGridViewTextBoxColumn.Name = "SNameDataGridViewTextBoxColumn"
        '
        'RClassDataGridViewTextBoxColumn
        '
        Me.RClassDataGridViewTextBoxColumn.DataPropertyName = "rClass"
        Me.RClassDataGridViewTextBoxColumn.HeaderText = "rClass"
        Me.RClassDataGridViewTextBoxColumn.Name = "RClassDataGridViewTextBoxColumn"
        '
        'GroupDataGridViewTextBoxColumn
        '
        Me.GroupDataGridViewTextBoxColumn.DataPropertyName = "Group"
        Me.GroupDataGridViewTextBoxColumn.HeaderText = "Group"
        Me.GroupDataGridViewTextBoxColumn.Name = "GroupDataGridViewTextBoxColumn"
        '
        'Profiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profiles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rowingDatabase__1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _rowingDatabase__1_DataSet As _rowingDatabase__1_DataSet
    Friend WithEvents TbProfilesBindingSource As BindingSource
    Friend WithEvents TbProfilesTableAdapter As _rowingDatabase__1_DataSetTableAdapters.tbProfilesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
