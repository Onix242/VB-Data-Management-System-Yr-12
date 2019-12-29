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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbSport = New System.Windows.Forms.ComboBox()
        Me.lblTeamname = New System.Windows.Forms.Label()
        Me.lblSport = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.tmrCountEdits = New System.Windows.Forms.Timer(Me.components)
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.cmbTeamname = New System.Windows.Forms.ComboBox()
        Me.btnFullreset = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnRedo = New System.Windows.Forms.Button()
        Me.tmrFilter = New System.Windows.Forms.Timer(Me.components)
        Me.lblTotalEntries = New System.Windows.Forms.Label()
        Me.lblTotalEntriesDisplay = New System.Windows.Forms.Label()
        Me.lblVisibleRowsDisplay = New System.Windows.Forms.Label()
        Me.lblVisibleRows = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblHelpInstruction = New System.Windows.Forms.Label()
        Me.lblDataGridInstructions = New System.Windows.Forms.Label()
        Me.lblFilterInstruction = New System.Windows.Forms.Label()
        Me.lblSearchInstruction = New System.Windows.Forms.Label()
        Me.lblUndoRedoInstruction = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblTeamInstruction = New System.Windows.Forms.Label()
        Me.StudentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MCAbsenteeDataSet = New MCAbsentee.MCAbsenteeDataSet()
        Me.Student_DataTableAdapter = New MCAbsentee.MCAbsenteeDataSetTableAdapters.Student_DataTableAdapter()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AnaphylacticDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OtherNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCAbsenteeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RosyBrown
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuUndo, Me.mnuRedo, Me.mnuHelp, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1153, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(43, 20)
        Me.mnuSave.Text = "&Save"
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
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "&Exit"
        '
        'cmbSport
        '
        Me.cmbSport.FormattingEnabled = True
        Me.cmbSport.Items.AddRange(New Object() {"Soccer", "Hockey", "Football", "Badminton", "Cross Country"})
        Me.cmbSport.Location = New System.Drawing.Point(64, 150)
        Me.cmbSport.Name = "cmbSport"
        Me.cmbSport.Size = New System.Drawing.Size(123, 21)
        Me.cmbSport.TabIndex = 4
        '
        'lblTeamname
        '
        Me.lblTeamname.AutoSize = True
        Me.lblTeamname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblTeamname.Location = New System.Drawing.Point(19, 126)
        Me.lblTeamname.Name = "lblTeamname"
        Me.lblTeamname.Size = New System.Drawing.Size(74, 15)
        Me.lblTeamname.TabIndex = 1
        Me.lblTeamname.Text = "Teamname:"
        '
        'lblSport
        '
        Me.lblSport.AutoSize = True
        Me.lblSport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblSport.Location = New System.Drawing.Point(19, 153)
        Me.lblSport.Name = "lblSport"
        Me.lblSport.Size = New System.Drawing.Size(39, 15)
        Me.lblSport.TabIndex = 3
        Me.lblSport.Text = "Sport:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(409, 161)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(156, 20)
        Me.txtSearch.TabIndex = 6
        '
        'tmrCountEdits
        '
        '
        'dgvStudent
        '
        Me.dgvStudent.AllowUserToAddRows = False
        Me.dgvStudent.AllowUserToDeleteRows = False
        Me.dgvStudent.AutoGenerateColumns = False
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.YrDataGridViewTextBoxColumn, Me.FormDataGridViewTextBoxColumn, Me.AnaphylacticDataGridViewTextBoxColumn, Me.OtherNotesDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Sport, Me.DataGridViewComboBoxColumn1, Me.DataGridViewComboBoxColumn2})
        Me.dgvStudent.DataSource = Me.StudentDataBindingSource
        Me.dgvStudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvStudent.Location = New System.Drawing.Point(200, 191)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.Size = New System.Drawing.Size(948, 311)
        Me.dgvStudent.TabIndex = 10
        '
        'cmbTeamname
        '
        Me.cmbTeamname.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StudentDataBindingSource, "Team Name", True))
        Me.cmbTeamname.FormattingEnabled = True
        Me.cmbTeamname.Items.AddRange(New Object() {"1sts", "2nds", "3rds Red", "3rds Blue", "3rds Gold", "4ths Red", "4ths Blue", "4ths Gold"})
        Me.cmbTeamname.Location = New System.Drawing.Point(99, 123)
        Me.cmbTeamname.Name = "cmbTeamname"
        Me.cmbTeamname.Size = New System.Drawing.Size(149, 21)
        Me.cmbTeamname.TabIndex = 2
        '
        'btnFullreset
        '
        Me.btnFullreset.Location = New System.Drawing.Point(839, 163)
        Me.btnFullreset.Name = "btnFullreset"
        Me.btnFullreset.Size = New System.Drawing.Size(103, 23)
        Me.btnFullreset.TabIndex = 9
        Me.btnFullreset.Text = "Full Reset Filter"
        Me.btnFullreset.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(681, 163)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 7
        Me.btnUndo.Text = "Undo Filter"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnRedo
        '
        Me.btnRedo.Location = New System.Drawing.Point(762, 163)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(75, 23)
        Me.btnRedo.TabIndex = 8
        Me.btnRedo.Text = "Redo Filter"
        Me.btnRedo.UseVisualStyleBackColor = True
        '
        'tmrFilter
        '
        '
        'lblTotalEntries
        '
        Me.lblTotalEntries.AutoSize = True
        Me.lblTotalEntries.Location = New System.Drawing.Point(12, 191)
        Me.lblTotalEntries.Name = "lblTotalEntries"
        Me.lblTotalEntries.Size = New System.Drawing.Size(141, 13)
        Me.lblTotalEntries.TabIndex = 11
        Me.lblTotalEntries.Text = "Number of total valid entries:"
        '
        'lblTotalEntriesDisplay
        '
        Me.lblTotalEntriesDisplay.AutoSize = True
        Me.lblTotalEntriesDisplay.Location = New System.Drawing.Point(159, 191)
        Me.lblTotalEntriesDisplay.Name = "lblTotalEntriesDisplay"
        Me.lblTotalEntriesDisplay.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalEntriesDisplay.TabIndex = 12
        Me.lblTotalEntriesDisplay.Text = "V"
        '
        'lblVisibleRowsDisplay
        '
        Me.lblVisibleRowsDisplay.AutoSize = True
        Me.lblVisibleRowsDisplay.Location = New System.Drawing.Point(175, 214)
        Me.lblVisibleRowsDisplay.Name = "lblVisibleRowsDisplay"
        Me.lblVisibleRowsDisplay.Size = New System.Drawing.Size(15, 13)
        Me.lblVisibleRowsDisplay.TabIndex = 14
        Me.lblVisibleRowsDisplay.Text = "U"
        '
        'lblVisibleRows
        '
        Me.lblVisibleRows.AutoSize = True
        Me.lblVisibleRows.Location = New System.Drawing.Point(12, 214)
        Me.lblVisibleRows.Name = "lblVisibleRows"
        Me.lblVisibleRows.Size = New System.Drawing.Size(162, 13)
        Me.lblVisibleRows.TabIndex = 13
        Me.lblVisibleRows.Text = "Number of total unfiltered entries:"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(9, 39)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(266, 32)
        Me.lblWelcome.TabIndex = 21
        Me.lblWelcome.Text = "Attendance Record"
        '
        'lblHelpInstruction
        '
        Me.lblHelpInstruction.AutoSize = True
        Me.lblHelpInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpInstruction.Location = New System.Drawing.Point(225, 0)
        Me.lblHelpInstruction.Name = "lblHelpInstruction"
        Me.lblHelpInstruction.Size = New System.Drawing.Size(249, 26)
        Me.lblHelpInstruction.TabIndex = 15
        Me.lblHelpInstruction.Text = "Help Notes:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double click ""Help"" to hide all instructions"
        Me.lblHelpInstruction.Visible = False
        '
        'lblDataGridInstructions
        '
        Me.lblDataGridInstructions.AutoSize = True
        Me.lblDataGridInstructions.Location = New System.Drawing.Point(12, 241)
        Me.lblDataGridInstructions.Name = "lblDataGridInstructions"
        Me.lblDataGridInstructions.Size = New System.Drawing.Size(170, 91)
        Me.lblDataGridInstructions.TabIndex = 20
        Me.lblDataGridInstructions.Text = resources.GetString("lblDataGridInstructions.Text")
        Me.lblDataGridInstructions.Visible = False
        '
        'lblFilterInstruction
        '
        Me.lblFilterInstruction.AutoSize = True
        Me.lblFilterInstruction.Location = New System.Drawing.Point(655, 53)
        Me.lblFilterInstruction.Name = "lblFilterInstruction"
        Me.lblFilterInstruction.Size = New System.Drawing.Size(353, 91)
        Me.lblFilterInstruction.TabIndex = 19
        Me.lblFilterInstruction.Text = resources.GetString("lblFilterInstruction.Text")
        Me.lblFilterInstruction.Visible = False
        '
        'lblSearchInstruction
        '
        Me.lblSearchInstruction.AutoSize = True
        Me.lblSearchInstruction.Location = New System.Drawing.Point(351, 65)
        Me.lblSearchInstruction.Name = "lblSearchInstruction"
        Me.lblSearchInstruction.Size = New System.Drawing.Size(214, 91)
        Me.lblSearchInstruction.TabIndex = 18
        Me.lblSearchInstruction.Text = resources.GetString("lblSearchInstruction.Text")
        Me.lblSearchInstruction.Visible = False
        '
        'lblUndoRedoInstruction
        '
        Me.lblUndoRedoInstruction.AutoSize = True
        Me.lblUndoRedoInstruction.Location = New System.Drawing.Point(12, 24)
        Me.lblUndoRedoInstruction.Name = "lblUndoRedoInstruction"
        Me.lblUndoRedoInstruction.Size = New System.Drawing.Size(352, 52)
        Me.lblUndoRedoInstruction.TabIndex = 16
        Me.lblUndoRedoInstruction.Text = resources.GetString("lblUndoRedoInstruction.Text")
        Me.lblUndoRedoInstruction.Visible = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(357, 162)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(46, 15)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "Search"
        '
        'lblTeamInstruction
        '
        Me.lblTeamInstruction.AutoSize = True
        Me.lblTeamInstruction.Location = New System.Drawing.Point(22, 81)
        Me.lblTeamInstruction.Name = "lblTeamInstruction"
        Me.lblTeamInstruction.Size = New System.Drawing.Size(215, 39)
        Me.lblTeamInstruction.TabIndex = 17
        Me.lblTeamInstruction.Text = "To Search for respective sport team:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Make sure to set values in the comboboxes," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for each Teamname and Sport"
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
        'Student_DataTableAdapter
        '
        Me.Student_DataTableAdapter.ClearBeforeFill = True
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Frozen = True
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.MaxInputLength = 6
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Frozen = True
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.MaxInputLength = 50
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SurnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.MaxInputLength = 50
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'YrDataGridViewTextBoxColumn
        '
        Me.YrDataGridViewTextBoxColumn.DataPropertyName = "Yr"
        Me.YrDataGridViewTextBoxColumn.HeaderText = "Yr"
        Me.YrDataGridViewTextBoxColumn.MaxInputLength = 2
        Me.YrDataGridViewTextBoxColumn.Name = "YrDataGridViewTextBoxColumn"
        Me.YrDataGridViewTextBoxColumn.ReadOnly = True
        Me.YrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.YrDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FormDataGridViewTextBoxColumn
        '
        Me.FormDataGridViewTextBoxColumn.DataPropertyName = "Form"
        Me.FormDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FormDataGridViewTextBoxColumn.HeaderText = "Form"
        Me.FormDataGridViewTextBoxColumn.Items.AddRange(New Object() {"12MSC", "11BOA", "11JWO"})
        Me.FormDataGridViewTextBoxColumn.Name = "FormDataGridViewTextBoxColumn"
        Me.FormDataGridViewTextBoxColumn.ReadOnly = True
        Me.FormDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'AnaphylacticDataGridViewTextBoxColumn
        '
        Me.AnaphylacticDataGridViewTextBoxColumn.DataPropertyName = "Anaphylactic"
        Me.AnaphylacticDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.AnaphylacticDataGridViewTextBoxColumn.HeaderText = "Anaphylactic"
        Me.AnaphylacticDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Yes", "No"})
        Me.AnaphylacticDataGridViewTextBoxColumn.Name = "AnaphylacticDataGridViewTextBoxColumn"
        Me.AnaphylacticDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnaphylacticDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'OtherNotesDataGridViewTextBoxColumn
        '
        Me.OtherNotesDataGridViewTextBoxColumn.DataPropertyName = "Other Notes"
        Me.OtherNotesDataGridViewTextBoxColumn.HeaderText = "Other Notes"
        Me.OtherNotesDataGridViewTextBoxColumn.MaxInputLength = 100
        Me.OtherNotesDataGridViewTextBoxColumn.Name = "OtherNotesDataGridViewTextBoxColumn"
        Me.OtherNotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherNotesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Class Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Class Code"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 7
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Team Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Team Name"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 9
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'Sport
        '
        Me.Sport.DataPropertyName = "Sport"
        Me.Sport.HeaderText = "Sport"
        Me.Sport.MaxInputLength = 13
        Me.Sport.Name = "Sport"
        Me.Sport.ReadOnly = True
        Me.Sport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Sport.Visible = False
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "21/8"
        Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn1.HeaderText = "21/8"
        Me.DataGridViewComboBoxColumn1.Items.AddRange(New Object() {"Yes", "No"})
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DataPropertyName = "28/8"
        Me.DataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn2.HeaderText = "28/8"
        Me.DataGridViewComboBoxColumn2.Items.AddRange(New Object() {"Yes", "No"})
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1153, 513)
        Me.Controls.Add(Me.lblTeamInstruction)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblHelpInstruction)
        Me.Controls.Add(Me.lblDataGridInstructions)
        Me.Controls.Add(Me.lblFilterInstruction)
        Me.Controls.Add(Me.lblSearchInstruction)
        Me.Controls.Add(Me.lblUndoRedoInstruction)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblVisibleRowsDisplay)
        Me.Controls.Add(Me.lblVisibleRows)
        Me.Controls.Add(Me.lblTotalEntriesDisplay)
        Me.Controls.Add(Me.lblTotalEntries)
        Me.Controls.Add(Me.btnRedo)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnFullreset)
        Me.Controls.Add(Me.cmbTeamname)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSport)
        Me.Controls.Add(Me.lblTeamname)
        Me.Controls.Add(Me.cmbSport)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Coach Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCAbsenteeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuRedo As ToolStripMenuItem
    Friend WithEvents cmbSport As ComboBox
    Friend WithEvents lblTeamname As Label
    Friend WithEvents lblSport As Label
    Friend WithEvents MCAbsenteeDataSet As MCAbsenteeDataSet
    Friend WithEvents StudentDataBindingSource As BindingSource
    Friend WithEvents Student_DataTableAdapter As MCAbsenteeDataSetTableAdapters.Student_DataTableAdapter
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents tmrCountEdits As Timer
    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents cmbTeamname As ComboBox
    Friend WithEvents btnFullreset As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnRedo As Button
    Friend WithEvents tmrFilter As Timer
    Friend WithEvents lblTotalEntries As Label
    Friend WithEvents lblTotalEntriesDisplay As Label
    Friend WithEvents lblVisibleRowsDisplay As Label
    Friend WithEvents lblVisibleRows As Label
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuUndo As ToolStripMenuItem
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblHelpInstruction As Label
    Friend WithEvents lblDataGridInstructions As Label
    Friend WithEvents lblFilterInstruction As Label
    Friend WithEvents lblSearchInstruction As Label
    Friend WithEvents lblUndoRedoInstruction As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblTeamInstruction As Label
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents AnaphylacticDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents OtherNotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Sport As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As DataGridViewComboBoxColumn
End Class
