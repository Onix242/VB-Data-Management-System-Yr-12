<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.lblVisibleRowsDisplay = New System.Windows.Forms.Label()
        Me.lblVisibleRows = New System.Windows.Forms.Label()
        Me.lblTotalEntriesDisplay = New System.Windows.Forms.Label()
        Me.lblTotalEntries = New System.Windows.Forms.Label()
        Me.btnRedo = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnFullreset = New System.Windows.Forms.Button()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.StudentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MCAbsenteeDataSet = New MCAbsentee.MCAbsenteeDataSet()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnDelentry = New System.Windows.Forms.Button()
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Student_DataTableAdapter = New MCAbsentee.MCAbsenteeDataSetTableAdapters.Student_DataTableAdapter()
        Me.tmrFilter = New System.Windows.Forms.Timer(Me.components)
        Me.lblDeleteInstruction = New System.Windows.Forms.Label()
        Me.lblSortInstruction = New System.Windows.Forms.Label()
        Me.lblUndoRedoInstruction = New System.Windows.Forms.Label()
        Me.cmbSortFilterMode = New System.Windows.Forms.ComboBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblSearchInstruction = New System.Windows.Forms.Label()
        Me.lblFilterInstruction = New System.Windows.Forms.Label()
        Me.lblSortFilter = New System.Windows.Forms.Label()
        Me.lblDataGridInstructions = New System.Windows.Forms.Label()
        Me.lblHelpInstruction = New System.Windows.Forms.Label()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AnaphylacticDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OtherNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCAbsenteeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVisibleRowsDisplay
        '
        Me.lblVisibleRowsDisplay.AutoSize = True
        Me.lblVisibleRowsDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblVisibleRowsDisplay.Location = New System.Drawing.Point(150, 175)
        Me.lblVisibleRowsDisplay.Name = "lblVisibleRowsDisplay"
        Me.lblVisibleRowsDisplay.Size = New System.Drawing.Size(15, 13)
        Me.lblVisibleRowsDisplay.TabIndex = 14
        Me.lblVisibleRowsDisplay.Text = "U"
        '
        'lblVisibleRows
        '
        Me.lblVisibleRows.AutoSize = True
        Me.lblVisibleRows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblVisibleRows.Location = New System.Drawing.Point(27, 175)
        Me.lblVisibleRows.Name = "lblVisibleRows"
        Me.lblVisibleRows.Size = New System.Drawing.Size(117, 13)
        Me.lblVisibleRows.TabIndex = 13
        Me.lblVisibleRows.Text = "Total Unfiltered Entries:"
        '
        'lblTotalEntriesDisplay
        '
        Me.lblTotalEntriesDisplay.AutoSize = True
        Me.lblTotalEntriesDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTotalEntriesDisplay.Location = New System.Drawing.Point(128, 149)
        Me.lblTotalEntriesDisplay.Name = "lblTotalEntriesDisplay"
        Me.lblTotalEntriesDisplay.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalEntriesDisplay.TabIndex = 12
        Me.lblTotalEntriesDisplay.Text = "V"
        '
        'lblTotalEntries
        '
        Me.lblTotalEntries.AutoSize = True
        Me.lblTotalEntries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTotalEntries.Location = New System.Drawing.Point(27, 149)
        Me.lblTotalEntries.Name = "lblTotalEntries"
        Me.lblTotalEntries.Size = New System.Drawing.Size(95, 13)
        Me.lblTotalEntries.TabIndex = 11
        Me.lblTotalEntries.Text = "Total Valid Entries:"
        '
        'btnRedo
        '
        Me.btnRedo.Location = New System.Drawing.Point(955, 121)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(75, 23)
        Me.btnRedo.TabIndex = 8
        Me.btnRedo.Text = "Redo Filter"
        Me.btnRedo.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(874, 121)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 7
        Me.btnUndo.Text = "Undo Filter"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnFullreset
        '
        Me.btnFullreset.Location = New System.Drawing.Point(1036, 121)
        Me.btnFullreset.Name = "btnFullreset"
        Me.btnFullreset.Size = New System.Drawing.Size(103, 23)
        Me.btnFullreset.TabIndex = 9
        Me.btnFullreset.Text = "Full Reset Filter"
        Me.btnFullreset.UseVisualStyleBackColor = True
        '
        'dgvStudent
        '
        Me.dgvStudent.AllowUserToAddRows = False
        Me.dgvStudent.AllowUserToDeleteRows = False
        Me.dgvStudent.AutoGenerateColumns = False
        Me.dgvStudent.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.YrDataGridViewTextBoxColumn, Me.FormDataGridViewTextBoxColumn, Me.AnaphylacticDataGridViewTextBoxColumn, Me.OtherNotesDataGridViewTextBoxColumn, Me.ClassCodeDataGridViewTextBoxColumn, Me.TeamNameDataGridViewTextBoxColumn, Me.SportDataGridViewTextBoxColumn, Me.DataGridViewComboBoxColumn1, Me.DataGridViewComboBoxColumn2})
        Me.dgvStudent.DataSource = Me.StudentDataBindingSource
        Me.dgvStudent.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvStudent.Location = New System.Drawing.Point(179, 149)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.Size = New System.Drawing.Size(1246, 319)
        Me.dgvStudent.TabIndex = 10
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
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Menu
        Me.txtSearch.Location = New System.Drawing.Point(435, 121)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(156, 20)
        Me.txtSearch.TabIndex = 4
        '
        'btnDelentry
        '
        Me.btnDelentry.Location = New System.Drawing.Point(274, 121)
        Me.btnDelentry.Name = "btnDelentry"
        Me.btnDelentry.Size = New System.Drawing.Size(89, 23)
        Me.btnDelentry.TabIndex = 2
        Me.btnDelentry.Text = "Delete An Entry"
        Me.btnDelentry.UseVisualStyleBackColor = True
        '
        'btnAddEntry
        '
        Me.btnAddEntry.Location = New System.Drawing.Point(179, 121)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(89, 23)
        Me.btnAddEntry.TabIndex = 1
        Me.btnAddEntry.Text = "Add New Entry"
        Me.btnAddEntry.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(4, 43)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(266, 32)
        Me.lblWelcome.TabIndex = 22
        Me.lblWelcome.Text = "Attendance Record"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RosyBrown
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuUndo, Me.mnuRedo, Me.mnuHelp, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1453, 24)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuSave
        '
        Me.mnuSave.BackColor = System.Drawing.Color.Transparent
        Me.mnuSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnuSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(43, 20)
        Me.mnuSave.Text = "&Save"
        '
        'mnuUndo
        '
        Me.mnuUndo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.Size = New System.Drawing.Size(48, 20)
        Me.mnuUndo.Text = "&Undo"
        '
        'mnuRedo
        '
        Me.mnuRedo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnuRedo.Name = "mnuRedo"
        Me.mnuRedo.Size = New System.Drawing.Size(46, 20)
        Me.mnuRedo.Text = "&Redo"
        '
        'mnuHelp
        '
        Me.mnuHelp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuExit
        '
        Me.mnuExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "&Exit"
        '
        'Student_DataTableAdapter
        '
        Me.Student_DataTableAdapter.ClearBeforeFill = True
        '
        'tmrFilter
        '
        '
        'lblDeleteInstruction
        '
        Me.lblDeleteInstruction.AutoSize = True
        Me.lblDeleteInstruction.Location = New System.Drawing.Point(267, 79)
        Me.lblDeleteInstruction.Name = "lblDeleteInstruction"
        Me.lblDeleteInstruction.Size = New System.Drawing.Size(96, 39)
        Me.lblDeleteInstruction.TabIndex = 17
        Me.lblDeleteInstruction.Text = "To Delete:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click on a row cell " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press the button"
        Me.lblDeleteInstruction.Visible = False
        '
        'lblSortInstruction
        '
        Me.lblSortInstruction.AutoSize = True
        Me.lblSortInstruction.Location = New System.Drawing.Point(608, 41)
        Me.lblSortInstruction.Name = "lblSortInstruction"
        Me.lblSortInstruction.Size = New System.Drawing.Size(170, 78)
        Me.lblSortInstruction.TabIndex = 19
        Me.lblSortInstruction.Text = "To Sort:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Make sure ""Sort"" is ""On"" " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click on a column heading once" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cannot filte" &
    "r then sort, else" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sorting a column with filtered items " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "also fully resets the " &
    "filters "
        Me.lblSortInstruction.Visible = False
        '
        'lblUndoRedoInstruction
        '
        Me.lblUndoRedoInstruction.AutoSize = True
        Me.lblUndoRedoInstruction.Location = New System.Drawing.Point(7, 27)
        Me.lblUndoRedoInstruction.Name = "lblUndoRedoInstruction"
        Me.lblUndoRedoInstruction.Size = New System.Drawing.Size(352, 52)
        Me.lblUndoRedoInstruction.TabIndex = 16
        Me.lblUndoRedoInstruction.Text = resources.GetString("lblUndoRedoInstruction.Text")
        Me.lblUndoRedoInstruction.Visible = False
        '
        'cmbSortFilterMode
        '
        Me.cmbSortFilterMode.BackColor = System.Drawing.SystemColors.Control
        Me.cmbSortFilterMode.FormattingEnabled = True
        Me.cmbSortFilterMode.Items.AddRange(New Object() {"Sort", "Filter"})
        Me.cmbSortFilterMode.Location = New System.Drawing.Point(731, 123)
        Me.cmbSortFilterMode.Name = "cmbSortFilterMode"
        Me.cmbSortFilterMode.Size = New System.Drawing.Size(47, 21)
        Me.cmbSortFilterMode.TabIndex = 6
        Me.cmbSortFilterMode.Text = "Filter"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(383, 124)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(46, 15)
        Me.lblSearch.TabIndex = 3
        Me.lblSearch.Text = "Search"
        '
        'lblSearchInstruction
        '
        Me.lblSearchInstruction.AutoSize = True
        Me.lblSearchInstruction.Location = New System.Drawing.Point(388, 28)
        Me.lblSearchInstruction.Name = "lblSearchInstruction"
        Me.lblSearchInstruction.Size = New System.Drawing.Size(214, 91)
        Me.lblSearchInstruction.TabIndex = 18
        Me.lblSearchInstruction.Text = resources.GetString("lblSearchInstruction.Text")
        Me.lblSearchInstruction.Visible = False
        '
        'lblFilterInstruction
        '
        Me.lblFilterInstruction.AutoSize = True
        Me.lblFilterInstruction.Location = New System.Drawing.Point(786, 27)
        Me.lblFilterInstruction.Name = "lblFilterInstruction"
        Me.lblFilterInstruction.Size = New System.Drawing.Size(353, 91)
        Me.lblFilterInstruction.TabIndex = 20
        Me.lblFilterInstruction.Text = resources.GetString("lblFilterInstruction.Text")
        Me.lblFilterInstruction.Visible = False
        '
        'lblSortFilter
        '
        Me.lblSortFilter.AutoSize = True
        Me.lblSortFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortFilter.Location = New System.Drawing.Point(608, 126)
        Me.lblSortFilter.Name = "lblSortFilter"
        Me.lblSortFilter.Size = New System.Drawing.Size(121, 15)
        Me.lblSortFilter.TabIndex = 5
        Me.lblSortFilter.Text = "Sort and Filter Mode:"
        '
        'lblDataGridInstructions
        '
        Me.lblDataGridInstructions.AutoSize = True
        Me.lblDataGridInstructions.Location = New System.Drawing.Point(7, 201)
        Me.lblDataGridInstructions.Name = "lblDataGridInstructions"
        Me.lblDataGridInstructions.Size = New System.Drawing.Size(170, 91)
        Me.lblDataGridInstructions.TabIndex = 21
        Me.lblDataGridInstructions.Text = resources.GetString("lblDataGridInstructions.Text")
        Me.lblDataGridInstructions.Visible = False
        '
        'lblHelpInstruction
        '
        Me.lblHelpInstruction.AutoSize = True
        Me.lblHelpInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpInstruction.Location = New System.Drawing.Point(218, 1)
        Me.lblHelpInstruction.Name = "lblHelpInstruction"
        Me.lblHelpInstruction.Size = New System.Drawing.Size(249, 26)
        Me.lblHelpInstruction.TabIndex = 15
        Me.lblHelpInstruction.Text = "Help Notes:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double click ""Help"" to hide all instructions"
        Me.lblHelpInstruction.Visible = False
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.MaxInputLength = 6
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.MaxInputLength = 50
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
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
        Me.FormDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FormDataGridViewTextBoxColumn.HeaderText = "Form"
        Me.FormDataGridViewTextBoxColumn.Items.AddRange(New Object() {"12MSC", "11BOA", "11JWO"})
        Me.FormDataGridViewTextBoxColumn.Name = "FormDataGridViewTextBoxColumn"
        Me.FormDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FormDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AnaphylacticDataGridViewTextBoxColumn
        '
        Me.AnaphylacticDataGridViewTextBoxColumn.DataPropertyName = "Anaphylactic"
        Me.AnaphylacticDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
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
        Me.OtherNotesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ClassCodeDataGridViewTextBoxColumn
        '
        Me.ClassCodeDataGridViewTextBoxColumn.DataPropertyName = "Class Code"
        Me.ClassCodeDataGridViewTextBoxColumn.HeaderText = "Class Code"
        Me.ClassCodeDataGridViewTextBoxColumn.MaxInputLength = 7
        Me.ClassCodeDataGridViewTextBoxColumn.Name = "ClassCodeDataGridViewTextBoxColumn"
        '
        'TeamNameDataGridViewTextBoxColumn
        '
        Me.TeamNameDataGridViewTextBoxColumn.DataPropertyName = "Team Name"
        Me.TeamNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.TeamNameDataGridViewTextBoxColumn.HeaderText = "Team Name"
        Me.TeamNameDataGridViewTextBoxColumn.Items.AddRange(New Object() {"1sts", "2nds", "3rds Red", "3rds Blue", "3rds Gold", "4ths Red", "4ths Blue", "4ths Gold"})
        Me.TeamNameDataGridViewTextBoxColumn.Name = "TeamNameDataGridViewTextBoxColumn"
        Me.TeamNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TeamNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SportDataGridViewTextBoxColumn
        '
        Me.SportDataGridViewTextBoxColumn.DataPropertyName = "Sport"
        Me.SportDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.SportDataGridViewTextBoxColumn.HeaderText = "Sport"
        Me.SportDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Soccer", "Football", "Badminton", "Hockey", "Cross Country"})
        Me.SportDataGridViewTextBoxColumn.Name = "SportDataGridViewTextBoxColumn"
        Me.SportDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SportDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "21/8"
        Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn1.HeaderText = "21/8"
        Me.DataGridViewComboBoxColumn1.Items.AddRange(New Object() {"Yes", "No"})
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DataPropertyName = "28/8"
        Me.DataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn2.HeaderText = "28/8"
        Me.DataGridViewComboBoxColumn2.Items.AddRange(New Object() {"Yes", "No"})
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1453, 480)
        Me.Controls.Add(Me.lblHelpInstruction)
        Me.Controls.Add(Me.lblDataGridInstructions)
        Me.Controls.Add(Me.lblSortFilter)
        Me.Controls.Add(Me.lblFilterInstruction)
        Me.Controls.Add(Me.lblSearchInstruction)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.cmbSortFilterMode)
        Me.Controls.Add(Me.lblUndoRedoInstruction)
        Me.Controls.Add(Me.lblSortInstruction)
        Me.Controls.Add(Me.lblDeleteInstruction)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblVisibleRowsDisplay)
        Me.Controls.Add(Me.lblVisibleRows)
        Me.Controls.Add(Me.lblTotalEntriesDisplay)
        Me.Controls.Add(Me.lblTotalEntries)
        Me.Controls.Add(Me.btnRedo)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnFullreset)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelentry)
        Me.Controls.Add(Me.btnAddEntry)
        Me.Name = "AdminForm"
        Me.Text = "Admin Form"
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCAbsenteeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVisibleRowsDisplay As Label
    Friend WithEvents lblVisibleRows As Label
    Friend WithEvents lblTotalEntriesDisplay As Label
    Friend WithEvents lblTotalEntries As Label
    Friend WithEvents btnRedo As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnFullreset As Button
    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnDelentry As Button
    Friend WithEvents btnAddEntry As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuUndo As ToolStripMenuItem
    Friend WithEvents mnuRedo As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents StudentDataBindingSource As BindingSource
    Friend WithEvents MCAbsenteeDataSet As MCAbsenteeDataSet
    Friend WithEvents Student_DataTableAdapter As MCAbsenteeDataSetTableAdapters.Student_DataTableAdapter
    Friend WithEvents tmrFilter As Timer
    Friend WithEvents lblDeleteInstruction As Label
    Friend WithEvents lblSortInstruction As Label
    Friend WithEvents lblUndoRedoInstruction As Label
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents cmbSortFilterMode As ComboBox
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblSearchInstruction As Label
    Friend WithEvents lblFilterInstruction As Label
    Friend WithEvents lblSortFilter As Label
    Friend WithEvents lblDataGridInstructions As Label
    Friend WithEvents lblHelpInstruction As Label
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents AnaphylacticDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents OtherNotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeamNameDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents SportDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As DataGridViewComboBoxColumn
End Class
