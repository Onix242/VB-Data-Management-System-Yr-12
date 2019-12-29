<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblClasscode = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.cmbSport = New System.Windows.Forms.ComboBox()
        Me.txtClasscode = New System.Windows.Forms.TextBox()
        Me.txtTeamname = New System.Windows.Forms.TextBox()
        Me.lblTeamname = New System.Windows.Forms.Label()
        Me.lblSport = New System.Windows.Forms.Label()
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.btnDelentry = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnaphylacticDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OtherNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MCAbsenteeDataSet = New MCAbsentee.MCAbsenteeDataSet()
        Me.cmbTeamname = New System.Windows.Forms.ComboBox()
        Me.btnFullreset = New System.Windows.Forms.Button()
        Me.lblVisiblerows = New System.Windows.Forms.Label()
        Me.btnTemp = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnRedo = New System.Windows.Forms.Button()
        Me.Student_DataTableAdapter = New MCAbsentee.MCAbsenteeDataSetTableAdapters.Student_DataTableAdapter()
        Me.Student_Data_BadmintonTableAdapter = New MCAbsentee.MCAbsenteeDataSetTableAdapters.Student_Data_BadmintonTableAdapter()
        Me.StudentDataBadmintonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCAbsenteeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataBadmintonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuUndo, Me.mnuRedo, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1044, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(98, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuUndo
        '
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.Size = New System.Drawing.Size(48, 20)
        Me.mnuUndo.Text = "&Undo"
        '
        'mnuRedo
        '
        Me.mnuRedo.Name = "mnuRedo"
        Me.mnuRedo.Size = New System.Drawing.Size(46, 20)
        Me.mnuRedo.Text = "&Redo"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "&Exit"
        '
        'lblClasscode
        '
        Me.lblClasscode.AutoSize = True
        Me.lblClasscode.Location = New System.Drawing.Point(12, 90)
        Me.lblClasscode.Name = "lblClasscode"
        Me.lblClasscode.Size = New System.Drawing.Size(59, 13)
        Me.lblClasscode.TabIndex = 1
        Me.lblClasscode.Text = "Classcode:"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(34, 48)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(52, 13)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "Welcome"
        '
        'cmbSport
        '
        Me.cmbSport.FormattingEnabled = True
        Me.cmbSport.Items.AddRange(New Object() {"Soccer", "Hockey", "Football", "Badminton", "Cross Country"})
        Me.cmbSport.Location = New System.Drawing.Point(53, 162)
        Me.cmbSport.Name = "cmbSport"
        Me.cmbSport.Size = New System.Drawing.Size(123, 21)
        Me.cmbSport.TabIndex = 11
        '
        'txtClasscode
        '
        Me.txtClasscode.Location = New System.Drawing.Point(78, 87)
        Me.txtClasscode.MaxLength = 6
        Me.txtClasscode.Name = "txtClasscode"
        Me.txtClasscode.Size = New System.Drawing.Size(98, 20)
        Me.txtClasscode.TabIndex = 12
        '
        'txtTeamname
        '
        Me.txtTeamname.Location = New System.Drawing.Point(686, 119)
        Me.txtTeamname.Name = "txtTeamname"
        Me.txtTeamname.Size = New System.Drawing.Size(184, 20)
        Me.txtTeamname.TabIndex = 13
        '
        'lblTeamname
        '
        Me.lblTeamname.AutoSize = True
        Me.lblTeamname.Location = New System.Drawing.Point(12, 128)
        Me.lblTeamname.Name = "lblTeamname"
        Me.lblTeamname.Size = New System.Drawing.Size(63, 13)
        Me.lblTeamname.TabIndex = 14
        Me.lblTeamname.Text = "Teamname:"
        '
        'lblSport
        '
        Me.lblSport.AutoSize = True
        Me.lblSport.Location = New System.Drawing.Point(12, 165)
        Me.lblSport.Name = "lblSport"
        Me.lblSport.Size = New System.Drawing.Size(35, 13)
        Me.lblSport.TabIndex = 15
        Me.lblSport.Text = "Sport:"
        '
        'btnAddEntry
        '
        Me.btnAddEntry.Location = New System.Drawing.Point(15, 214)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(89, 23)
        Me.btnAddEntry.TabIndex = 17
        Me.btnAddEntry.Text = "Add New Entry"
        Me.btnAddEntry.UseVisualStyleBackColor = True
        '
        'btnDelentry
        '
        Me.btnDelentry.Location = New System.Drawing.Point(110, 214)
        Me.btnDelentry.Name = "btnDelentry"
        Me.btnDelentry.Size = New System.Drawing.Size(89, 23)
        Me.btnDelentry.TabIndex = 18
        Me.btnDelentry.Text = "Delete An Entry"
        Me.btnDelentry.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(205, 217)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(156, 20)
        Me.txtSearch.TabIndex = 19
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(768, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "+"
        '
        'dgvStudent
        '
        Me.dgvStudent.AllowUserToAddRows = False
        Me.dgvStudent.AllowUserToDeleteRows = False
        Me.dgvStudent.AutoGenerateColumns = False
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.YrDataGridViewTextBoxColumn, Me.FormDataGridViewTextBoxColumn, Me.AnaphylacticDataGridViewTextBoxColumn, Me.OtherNotesDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Sport})
        Me.dgvStudent.DataSource = Me.StudentDataBindingSource
        Me.dgvStudent.Location = New System.Drawing.Point(15, 243)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.Size = New System.Drawing.Size(747, 311)
        Me.dgvStudent.TabIndex = 21
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Frozen = True
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.MaxInputLength = 6
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Frozen = True
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.MaxInputLength = 50
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Frozen = True
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.MaxInputLength = 50
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'YrDataGridViewTextBoxColumn
        '
        Me.YrDataGridViewTextBoxColumn.DataPropertyName = "Yr"
        Me.YrDataGridViewTextBoxColumn.HeaderText = "Yr"
        Me.YrDataGridViewTextBoxColumn.MaxInputLength = 2
        Me.YrDataGridViewTextBoxColumn.Name = "YrDataGridViewTextBoxColumn"
        Me.YrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'FormDataGridViewTextBoxColumn
        '
        Me.FormDataGridViewTextBoxColumn.DataPropertyName = "Form"
        Me.FormDataGridViewTextBoxColumn.HeaderText = "Form"
        Me.FormDataGridViewTextBoxColumn.MaxInputLength = 5
        Me.FormDataGridViewTextBoxColumn.Name = "FormDataGridViewTextBoxColumn"
        '
        'AnaphylacticDataGridViewTextBoxColumn
        '
        Me.AnaphylacticDataGridViewTextBoxColumn.DataPropertyName = "Anaphylactic"
        Me.AnaphylacticDataGridViewTextBoxColumn.HeaderText = "Anaphylactic"
        Me.AnaphylacticDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Yes", "No"})
        Me.AnaphylacticDataGridViewTextBoxColumn.Name = "AnaphylacticDataGridViewTextBoxColumn"
        Me.AnaphylacticDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AnaphylacticDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'OtherNotesDataGridViewTextBoxColumn
        '
        Me.OtherNotesDataGridViewTextBoxColumn.DataPropertyName = "Other Notes"
        Me.OtherNotesDataGridViewTextBoxColumn.HeaderText = "Other Notes"
        Me.OtherNotesDataGridViewTextBoxColumn.MaxInputLength = 100
        Me.OtherNotesDataGridViewTextBoxColumn.Name = "OtherNotesDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Class Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Class Code"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 7
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Team Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Team Name"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 9
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'Sport
        '
        Me.Sport.DataPropertyName = "Sport"
        Me.Sport.HeaderText = "Sport"
        Me.Sport.MaxInputLength = 13
        Me.Sport.Name = "Sport"
        Me.Sport.Visible = False
        '
        'StudentDataBindingSource
        '
        Me.StudentDataBindingSource.DataMember = "Student Data"
        Me.StudentDataBindingSource.DataSource = Me.MCAbsenteeDataSet
        '
        'MCAbsenteeDataSet
        '
        Me.MCAbsenteeDataSet.DataSetName = "MCAbsenteeDataSet"
        Me.MCAbsenteeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbTeamname
        '
        Me.cmbTeamname.FormattingEnabled = True
        Me.cmbTeamname.Items.AddRange(New Object() {"1sts", "2nds", "3rds Blue"})
        Me.cmbTeamname.Location = New System.Drawing.Point(78, 125)
        Me.cmbTeamname.Name = "cmbTeamname"
        Me.cmbTeamname.Size = New System.Drawing.Size(149, 21)
        Me.cmbTeamname.TabIndex = 22
        '
        'btnFullreset
        '
        Me.btnFullreset.Location = New System.Drawing.Point(659, 214)
        Me.btnFullreset.Name = "btnFullreset"
        Me.btnFullreset.Size = New System.Drawing.Size(103, 23)
        Me.btnFullreset.TabIndex = 23
        Me.btnFullreset.Text = "Full Reset Filter"
        Me.btnFullreset.UseVisualStyleBackColor = True
        '
        'lblVisiblerows
        '
        Me.lblVisiblerows.AutoSize = True
        Me.lblVisiblerows.Location = New System.Drawing.Point(768, 267)
        Me.lblVisiblerows.Name = "lblVisiblerows"
        Me.lblVisiblerows.Size = New System.Drawing.Size(10, 13)
        Me.lblVisiblerows.TabIndex = 24
        Me.lblVisiblerows.Text = "-"
        Me.lblVisiblerows.UseMnemonic = False
        '
        'btnTemp
        '
        Me.btnTemp.Location = New System.Drawing.Point(795, 243)
        Me.btnTemp.Name = "btnTemp"
        Me.btnTemp.Size = New System.Drawing.Size(75, 23)
        Me.btnTemp.TabIndex = 25
        Me.btnTemp.Text = "visible"
        Me.btnTemp.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(501, 214)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 26
        Me.btnUndo.Text = "Undo Filter"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnRedo
        '
        Me.btnRedo.Location = New System.Drawing.Point(582, 214)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(75, 23)
        Me.btnRedo.TabIndex = 27
        Me.btnRedo.Text = "Redo Filter"
        Me.btnRedo.UseVisualStyleBackColor = True
        '
        'Student_DataTableAdapter
        '
        Me.Student_DataTableAdapter.ClearBeforeFill = True
        '
        'Student_Data_BadmintonTableAdapter
        '
        Me.Student_Data_BadmintonTableAdapter.ClearBeforeFill = True
        '
        'StudentDataBadmintonBindingSource
        '
        Me.StudentDataBadmintonBindingSource.DataMember = "Student Data Badminton"
        Me.StudentDataBadmintonBindingSource.DataSource = Me.MCAbsenteeDataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 566)
        Me.Controls.Add(Me.btnRedo)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnTemp)
        Me.Controls.Add(Me.lblVisiblerows)
        Me.Controls.Add(Me.btnFullreset)
        Me.Controls.Add(Me.cmbTeamname)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelentry)
        Me.Controls.Add(Me.btnAddEntry)
        Me.Controls.Add(Me.lblSport)
        Me.Controls.Add(Me.lblTeamname)
        Me.Controls.Add(Me.txtTeamname)
        Me.Controls.Add(Me.txtClasscode)
        Me.Controls.Add(Me.cmbSport)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblClasscode)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Absentee (Coach)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCAbsenteeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataBadmintonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuUndo As ToolStripMenuItem
    Friend WithEvents mnuRedo As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents lblClasscode As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents cmbSport As ComboBox
    Friend WithEvents txtClasscode As TextBox
    Friend WithEvents txtTeamname As TextBox
    Friend WithEvents lblTeamname As Label
    Friend WithEvents lblSport As Label
    Friend WithEvents MCAbsenteeDataSet As MCAbsenteeDataSet
    Friend WithEvents StudentDataBindingSource As BindingSource
    Friend WithEvents Student_DataTableAdapter As MCAbsenteeDataSetTableAdapters.Student_DataTableAdapter
    Friend WithEvents btnAddEntry As Button
    Friend WithEvents btnDelentry As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents cmbTeamname As ComboBox
    Friend WithEvents btnFullreset As Button
    Friend WithEvents lblVisiblerows As Label
    Friend WithEvents btnTemp As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnRedo As Button
    Friend WithEvents Student_Data_BadmintonTableAdapter As MCAbsenteeDataSetTableAdapters.Student_Data_BadmintonTableAdapter
    Friend WithEvents StudentDataBadmintonBindingSource As BindingSource
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnaphylacticDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents OtherNotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Sport As DataGridViewTextBoxColumn
End Class
