'Module Name: Main Screen (Admin)
'Authors Name: Michael Chow 
'Date: 9/8
'Dependencies: CoachLogin.vb 
'Purpose: For the Heads of Girls and Boys Sport, Girls and Boys Sport Absence Monitors and Sport Adminstrator to access student information with ease 
'Bibliography: https://www.youtube.com/channel/UCWc48sSzqPLUOfNCy9sxUug, https://stackoverflow.com/questions/509578/how-to-get-visible-row-count-of-datagridview-after-bindingsource-filter, http://converter.telerik.com/
'Acknowledgements: Chris Do

Public Class Form1
    'Undos and Redos text inside the datagridview when tabbed out
    Dim undoEditList As New List(Of Array)
    Dim undoEditCountList As New List(Of Array)
    Dim redoEditList As New List(Of Array)
    Dim redoEditCountList As New List(Of Array)

    'Undos and Redos filters any datagridview changes
    Dim undoFilterList As New List(Of Integer) 'Tracks row indexes which have been filtered
    Dim undoFilterCountList As New List(Of Integer) 'Tracks number of rows filtered per filters
    Dim redoFilterList As New List(Of Integer)
    Dim redoFilterCountList As New List(Of Integer)

    'Lists worked better as stacks created problems with CStr function
    'Dim undoStack As New Stack(Of Object()())
    'Dim undoCountStack As New Stack(Of Object()())
    'Dim redoStack As New Stack(Of Object()())
    'Dim ignore As Boolean = False

    'Found that the bulit-in autosort had crashed the program with filtering then immediately sorting 
    'Discontinued as sort for a small amount of data was not necessary 
    'Dim SortModeOn As Boolean = True
    'Dim FixSort As Boolean = False 'Dim CurrentTrackedRowStudentID As Integer

    Dim SportEvent As Boolean
    Dim TeamNameEvent As Boolean
    Dim InvisibleRows As New List(Of Integer)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tried converting to x64 bit, all functionalities works excepts the database changes to one not in debug file
        'Student_DataTableAdapter.Fill(MCAbsenteeDataSet.Student_Data)
        'dgvStudent.VirtualMode = True
        tmrCountEdits.Start() 'Way to check if table rows update
        '"DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter" not needed, vb already has inbuilt feature
        dgvStudent.RowsDefaultCellStyle.BackColor = Color.FromArgb(236, 242, 246) 'Lighter blue/grey
        dgvStudent.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        dgvStudent.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 213, 225) 'Light blue/grey
        dgvStudent.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 51, 153) 'Navy Blue
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs)
        Try 'If any error occurs while saving the data, it catches exceptions and shows messages
            Validate()
            StudentDataBindingSource.EndEdit()
            Student_DataTableAdapter.Update(MCAbsenteeDataSet.Student_Data) 'Updates access file in Debug folder, excluding the one in Projects
            '"Me.MCAbsenteeDataSet.AcceptChanges()" is already an inbuilt function 
            '"Me.TableAdapterManager1.UpdateAll(Me.MCAbsenteeDataSet)", originally had a problem with saving the data, datatableadapter was not the problem - datagridview was just binded to dataset/source incorrectly 
            MessageBox.Show("Data Saved", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error occurred while saving data", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub tmrFilter_Tick(sender As Object, e As EventArgs) Handles tmrFilter.Tick
        'User UI Filter
        Dim count As Integer
        count = StudentDataBindingSource.Count 'Checks how many saved entries there are 
        lblTotalEntriesDisplay.Text = count 'Checks how many valid entries there are, even those that have been added
        lblVisibleRowsDisplay.Text = dgvStudent.Rows.GetRowCount(DataGridViewElementStates.Visible) 'Checks how many valid entries visible 

        'Used a button before to check how many times the list has been filtered/hidden and how many entries have been
        'Console.Write(undoFilterList.Count)
        'Console.Write(undoFilterCountList.Count)
        'Console.WriteLine(undoFilterList.Last())
    End Sub

    Private Sub tmrCountEdits_Tick(sender As Object, e As EventArgs) Handles tmrCountEdits.Tick
        'User UI Filter
        Dim count As Integer
        count = StudentDataBindingSource.Count 'Checks how many saved entries there are 
        lblTotalEntriesDisplay.Text = count 'Checks how many valid entries there are, even those that have been added
        lblVisibleRowsDisplay.Text = dgvStudent.Rows.GetRowCount(DataGridViewElementStates.Visible) 'Checks how many valid entries visible 

        'Debugging Tools
        'Dim count As Integer
        'count = undoEditList.Count 'Checks how many characters/strings have been saved 
        'lblUndoEditList.Text = count
        'lblRedoEditList.Text = redoEditList.Count


        'Attempt to fix sorting with invisible rows
        'Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager) ' because the currently selected cell/row must be visible, thus suspends the binding of all the rows before setting them to invisible, this is especially apparent when deleting rows 
        'cm1.SuspendBinding()
        'If FixSort = True Then
        ''Trigger combobox value change event 
        'Console.WriteLine("At TImer: " + Str(InvisibleRows.Count))
        'For Each row As DataGridViewRow In dgvStudent.Rows
        '    'Console.WriteLine("Before If:" + Str(row.Index))
        '    If InvisibleRows.Contains(dgvStudent.Rows(row.Index).Cells(0).Value) Then
        '        'Try
        '        'cm1.SuspendBinding()
        '        Console.WriteLine("Before refresh:" + Str(row.Index))
        '        'Console.WriteLine("HERE")
        '        'Console.WriteLine(cm1.Position)
        '        cm1.SuspendBinding()
        '        Console.WriteLine("..." + CStr(cm1.IsBindingSuspended))
        '        Console.WriteLine(dgvStudent.Rows(row.Index).Cells(0).Value)
        '        cm1.Refresh() ' changes row index
        '        Console.WriteLine("After refresh:" + Str(row.Index + 1))
        '        Console.WriteLine(dgvStudent.Rows(row.Index + 1).Cells(0).Value)
        '        dgvStudent.Rows(row.Index + 1).Visible = False
        '        cm1.ResumeBinding()
        '        'Catch ex As Exception
        '        'Console.WriteLine("ERROR ERROR ERROR")
        '        'Console.WriteLine(CStr(row.Index))
        '        'Console.WriteLine(dgvStudent.Rows(row.Index).Cells(0).Value)
        '        'End Try
        '    End If
        'Next
        'System.Threading.Thread.Sleep(5000)
        'FixSort = False
        'InvisibleRows.Clear()
        'End If


        'Tried to create as an own sub
        'Sub Hiderows()
        '    Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager)

        '    For Each row As DataGridViewRow In dgvStudent.Rows
        '        dgvStudent.Rows(row.Index).Selected = False
        '    Next
        '    For Each row As DataGridViewRow In dgvStudent.Rows
        '        cm1.SuspendBinding()
        '        dgvStudent.Rows(row.Index).Visible = False
        '    Next
        'End Sub


        'Additionally tried in Sorted event
        'Console.WriteLine("Sorted")
        'turn rows with index from invisiblerows list invisible
        'Dim rowindex As String
        'rowindex = dgvStudent.Rows.Index.ToString()
        'Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager) ' because the currently selected cell/row must be visible, thus suspends the binding of all the rows before setting them to invisible, this is especially apparent when deleting rows 
        'cm1.SuspendBinding()
        'System.Threading.Thread.Sleep(5000)
        'Console.WriteLine("Unpaused")
        'SortModeOn = True
        'If SortModeOn = True Then
        'Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager)
        'cm1.SuspendBinding()
        'FixSort = True
        'End If
        'SortModeOn = True
        'For Each row As DataGridViewRow In dgvStudent.Rows
        '    'If row.Cells(field).Value <> key And dgvStudent.Rows(row.Index).Visible = True Then
        '    'If InvisibleRows In row.Index Then 
        '    'If row.Index.IndexOf(InvisibleRows.Count) Then
        '    'If InvisibleRows.Exists(row.Index.ToString()) Then '.FindIndex(dgvStudent.Rows(row.Index)) Then
        '    'If InvisibleRows.dgvStudent.Rows.IndexOf(lDataRow) Then
        '    '    dgvStudent.Rows(row.Index).Visible = True
        '    'End If

        '    If InvisibleRows.Contains(row.Index) Then
        '        'Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager) ' because the currently selected cell/row must be visible, thus suspends the binding of all the rows before setting them to invisible, this is especially apparent when deleting rows 
        '        'cm1.SuspendBinding()
        '        Console.WriteLine(row.Index)
        '        'dgvStudent.Rows(row.Index).Visible = False
        '    End If
        '    'turn row invisible
        'Next


        'Also tried in MouseDown event
        'Console.WriteLine("MouseDown")
        'InvisibleRows.Clear()
        'For Each row As DataGridViewRow In dgvStudent.Rows
        'Dim indexOfInvisibleRow = List.IndexOf(InvisibleRows)
        'Dim indexofInvisibleRows = Enumerable.Range(0, InvisibleRows.Count)
        'If dgvStudent.Rows(row.Index).Visible = False Then
        'InvisibleRows.Add(dgvStudent.Rows(row.Index).Cells(0).Value)
        ' End If
        'Get indexes of invisiblerows
        'Add e.RowIndex in InvisibleRows
        'Next
        'Console.WriteLine("At Mouse Down: " + Str(InvisibleRows.Count))
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        If MessageBox.Show("Do you want to exit without saving?", "Exiting", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        If txtSearch.Text = String.Empty Then
            MessageBox.Show("Error occurred while searching", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub dgvStudent_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvStudent.CellPainting
        'Bibliography: https://www.youtube.com/channel/UCs6nmQViDpUw0nuIx9c_WvA
        'If there is no search string, no row, or nothing in this cell, it 
        'Cells hides text whilst search term is in; crashes when input is number
        'Double clicking on row then back to a new row hides all cells in that row; referenced wrong variable
        'If a DataGridViewColumn was a DataGridViewComboBoxColumn, the Display Style needs to be set a Nothing in order from a search to occur
        'Even so the user still need to focus out of the combobox for the term to be highlighted
        Try
            If txtSearch.Text = String.Empty Then Return
            If (e.Value Is Nothing) Then Return
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return
            If e.ColumnIndex = 0 Then
                Return
            End If
            e.Handled = True
            e.PaintBackground(e.CellBounds, True)
            Dim SearchTerm As String = txtSearch.Text.Trim.ToLower
            Dim CellText As String = DirectCast(e.FormattedValue, String).ToLower
            'Creates a list of the character ranges that needs to be highlighted, needs to know the start index and the length
            Dim HLRanges As New List(Of CharacterRange)
            Dim SearchIndex As Integer = CellText.IndexOf(SearchTerm)
            Do Until SearchIndex = -1
                HLRanges.Add(New CharacterRange(SearchIndex, SearchTerm.Length))
                SearchIndex = CellText.IndexOf(SearchTerm, SearchIndex + SearchTerm.Length)
            Loop
            'Work with the original cell text which has not been which has not been converted to lowercase, else sizes are incorrect
            CellText = DirectCast(e.FormattedValue, String)
            'Choose colours, different is used on currently selected row
            Dim HLColour As SolidBrush
            If ((e.State And DataGridViewElementStates.Visible) <> DataGridViewElementStates.None) Then
                HLColour = New SolidBrush(Color.DarkGoldenrod)
            Else
                HLColour = New SolidBrush(Color.BurlyWood)
            End If
            'Loop through all of the found instances and draw the highlighted box
            For Each HLRange In HLRanges
                'Creates the rectangle, should start just underneath the top of the cell, and go to just above the bottom of the
                Dim HLRectangle As New Rectangle()
                HLRectangle.Y = e.CellBounds.Y + 2
                HLRectangle.Height = e.CellBounds.Height - 5
                'Determines the size of the text before the area to highlight, and the size of the text to highlight
                'Need to know the size of the text before so that we know where to start the hightlight rectangle 
                Dim TextBeforeHL As String = CellText.Substring(0, HLRange.First)
                Dim TextToHL As String = CellText.Substring(HLRange.First, HLRange.Length)
                Dim SizeTextBefore As Size = TextRenderer.MeasureText(e.Graphics, TextBeforeHL, e.CellStyle.Font, e.CellBounds.Size)
                Dim SizeTextToHL As Size = TextRenderer.MeasureText(e.Graphics, TextToHL, e.CellStyle.Font, e.CellBounds.Size)
                'Sets the width of the rectangle, wider to make highlight clearer
                If SizeTextBefore.Width > 5 Then
                    HLRectangle.X = e.CellBounds.X + SizeTextBefore.Width - 6
                    HLRectangle.Width = SizeTextToHL.Width - 6
                Else
                    HLRectangle.X = e.CellBounds.X + 2
                    HLRectangle.Width = SizeTextToHL.Width - 6
                End If
                'Paints the highlight area
                e.Graphics.FillRectangle(HLColour, HLRectangle)
            Next
            'Paints rest of the cell
            e.PaintContent(e.CellBounds)
            'Gets the value of the text in the cell, and the search term. Works with everything in lowercase
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvStudent_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvStudent.DataError
        Try 'When clicked onto another reset empty entry to original
            MessageBox.Show("Empty entry has been reset", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
        End Try
        'Tried in CellClick event
        'dgvStudent.Rows.Item(sender).Visible = False
        'Try

        'Catch ex As Exception
        '    MessageBox.Show("Fill empty entry")
        'End Try
    End Sub

    Private Sub dgvStudent_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellDoubleClick
        'Bibiliography: https://stackoverflow.com/questions/509578/how-to-get-visible-row-count-of-datagridview-after-bindingsource-filter
        'Originally used the ContentClick event which had issues where users could click on the content headers and crash the program
        'Undoing functionailty for full reset works when clicked on the in-built sort function, and can hide everything if double clicked

        'If e.RowIndex <> 0 Then
        'Console.WriteLine("CellDouble")
        'Console.WriteLine(CStr(InvisibleRows.Count))
        'SortModeOn = False
        'Console.WriteLine(Str(e.RowIndex))
        'Hiderows()
        If e.RowIndex <> -1 Then
            Try 'Without this, if the user triple clicks in succession would crash the program
                redoFilterList.Clear()
                redoFilterCountList.Clear()
                Dim field As String = dgvStudent.Columns(e.ColumnIndex).Name 'Stores column name into a variable
                Dim key As String
                Try
                    key = dgvStudent.CurrentCell.Value
                Catch ex As Exception
                    key = "NULL"
                End Try
                Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager)
                'Because the currently selected cell/row must be visible, thus suspends the binding of all the rows before setting them to invisible, this is especially apparent when deleting rows 
                'cm1.SuspendBinding() 'Also "cm1.ResumeBinding()", or refreshing the CurrencyManager was omitted since the datagridview screen updates itself
                Dim countAdditions As Integer = 0
                Dim beforeCount As Integer = dgvStudent.Rows.GetRowCount(DataGridViewElementStates.Visible)
                For Each row As DataGridViewRow In dgvStudent.Rows '"Originally had "For i = 0 To 6", but if changed later, it will have to be programmatically fixed
                    'Console.WriteLine(row.Cells(field).Value)
                    'Console.WriteLine(key)
                    Try
                        If row.Cells(field).Value <> key And dgvStudent.Rows(row.Index).Visible = True Then 'Was changed from "If Not (row.Cells(field).Value Is Nothing) Then" as there was other exceptions
                            dgvStudent.Rows(row.Index).Visible = False
                            'changedIndexes.Add(row.Index)
                            undoFilterList.Add(row.Index)
                            countAdditions += 1
                            'Console.WriteLine("filtered")
                        Else
                            dgvStudent.Rows(row.Index).Visible = False
                        End If
                    Catch ex As Exception
                        dgvStudent.Rows(row.Index).Visible = False
                        If Len(row.Cells(field).Value.ToString) = 0 Then
                            dgvStudent.Rows(row.Index).Visible = True
                        End If
                        'Console.WriteLine(row.Cells(field).Value)
                    End Try
                Next

                If dgvStudent.Rows.GetRowCount(DataGridViewElementStates.Visible) <> beforeCount Then
                    undoFilterCountList.Add(countAdditions)
                End If
            Catch ex As Exception
            End Try
        End If

        'SortModeOn = False

        'Another attempt at making sorting whilst DataGridView had invisble rows 
        'Dim rowCount As Integer = cm1.Count
        'For row As Integer = 0 To rowCount - 1
        '    Dim dgvr As DataGridViewRow = dgvStudent.Rows(row)
        '    If dgvr.Cells(field).Value <> key And dgvStudent.Rows(dgvr.Index).Visible Then
        '        cm1.SuspendBinding()
        '        dgvr.Visible = False
        '    End If
        'Next


        'Double Click cell event had also extended to column headings instead of just content cell
        'Private Sub dgvStudent_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStudent.ColumnHeaderMouseDoubleClick
        '   Console.WriteLine("ContentHeadedDouble")
        'End Sub


        'Did not work as a filter since cell data could not be saved into the datasource - it just alters what the user views
        'Undoing functionailty for partial reset worked when clicked on the adding entry button and deleting button
        'Deleting a filtered row partially resets filter; filting multiple times, adding then deleting entries also resets 

        ''Originally had "Dim ds As New DataSet" which was not a datatable needs to be correct data type for dv function
        'Dim dv As DataView
        'Dim field As String = dgvStudent.Columns(e.ColumnIndex).Name 
        'Dim key As String = dgvStudent.CurrentCell.Value
        ''"ds.tables.add(dgvStudent.DataSource)", binding source incompatible
        ''"Dim dtgridsource As DataTable = CType(dgvStudent.DataSource, DataTable)" was unable To be converted 
        ' Dim changedIndexes As New List(Of Integer)

        'Dim dtgrid As New DataTable
        'For Each column As DataGridViewColumn In dgvStudent.Columns
        '    dtgrid.Columns.Add(column.HeaderText, column.ValueType)
        'Next
        'For Each row As DataGridViewRow In dgvStudent.Rows ' creates empty entries for each in row in datagridview and 
        '    checks each row for double-clicked values
        '    dtgrid.Rows.Add()
        '    For Each cell As DataGridViewCell In row.Cells
        '        Try
        '            dtgrid.Rows(dtgrid.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString() 'Adds entry to new table
        '            If (dgvStudent.Rows.Count > 0) Then
        '                For Each row As DataGridViewRow In dgvStudent.VisibleRows
        '                    dgvStudent.Rows.Item(row.Index).Visible = False
        '                Next
        '            End If
        '        Catch ex As Exception

        '        End Try
        '    Next
        'Next

        'undoCountStack.Push(changedIndexes.ToArray())

        ''"Console.WriteLine("HERE")" used To test If Function works which could be ran In the program
        ''"Console.WriteLine(dgvStudent.CurrentCell.Value)", this is the same as "Columns(e.ColumnIndex)"
        ''"Console.WriteLine(field + "='" + key + "'")"

        'dv = New DataView(dtgrid, field + "='" + key + "'", field, DataViewRowState.CurrentRows) 'Creates a new filtered dataview
        'dgvStudent.DataSource = dv
    End Sub

    Private Sub btnFullreset_Click(sender As Object, e As EventArgs) Handles btnFullreset.Click
        'Originally attempted to recopy the entire datatable - it was too difficult
        Dim Sport As String = cmbSport.Text 'Orignally had problems as the combobox was not consistent e.g cannot have spaces at the end
        Dim SportField As String = dgvStudent.Columns(9).Name
        Dim TeamName As String = cmbTeamname.Text 'Has to be consistent e.g cannot have spaces
        Dim TeamNameField As String = dgvStudent.Columns(8).Name

        Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager) 'Because the currently selected cell/row must be visible, thus suspends the binding of all the rows before setting them to invisible, this is especially apparent when deleting rows 
        cm1.SuspendBinding()
        For Each row As DataGridViewRow In dgvStudent.Rows
            dgvStudent.Rows(row.Index).Visible = True
            Try

                If row.Cells(TeamNameField).Value <> TeamName Or row.Cells(SportField).Value <> Sport Then
                    dgvStudent.Rows(row.Index).Visible = False
                End If
            Catch ex As Exception
                Try
                    dgvStudent.Rows(row.Index).Visible = False
                Catch exe As Exception
                End Try
            End Try
        Next
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        'Bibliography: https://stackoverflow.com/questions/23245569/how-to-remove-the-last-element-added-into-the-list/23245652, https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=netframework-4.8
        Try
            Dim numRowsToUndo As Integer = undoFilterCountList.Last()
            For i = 0 To numRowsToUndo - 1
                dgvStudent.Rows(undoFilterList.Last()).Visible = True 'Last number of rows filtered
                'Console.WriteLine("Count:")
                'Console.WriteLine(undoFilterList.Count)
                redoFilterList.Add(undoFilterList.Last()) 'Moves undone filtered rows to redo (filter list)
                undoFilterList.RemoveAt(undoFilterList.Count - 1) 'Clears last row from undone history
            Next
            redoFilterCountList.Add(numRowsToUndo)
            'Console.WriteLine(redoFilterCountList.Count)
            undoFilterCountList.RemoveAt(undoFilterCountList.Count - 1)
        Catch ex As Exception
            MessageBox.Show("There is nothing to undo", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        'Cannot copy an old datatable over an updated datable
        'Realised that the undo and redo button using stacks is only compatible to reset the datatable that is not bound - this created problems as it does not work vice versa
        'Bibliography: https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=netframework-4.8, https://social.msdn.microsoft.com/Forums/vstudio/en-US/3230c02e-412d-4a5b-a2d5-9de74fca6d4b/undo-and-redo-buttons-for-bound-datagridview?forum=vbgeneral

        'If redoStack.Count = 0 OrElse NeedsItem(redoStack, dgvStudent) Then
        '    redoStack.Push(dgvStudent.Rows.Cast(Of DataGridViewRow).Where(Function(r) Not r.IsNewRow).Select(Function(r) r.Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray).ToArray)
        'End If
        'Dim rows()() As Object = undoStack.Pop()

        'While ItemEquals(rows, dgvStudent.Rows.Cast(Of DataGridViewRow).Where(Function(r) Not r.IsNewRow).ToArray)
        '    rows = undoStack.Pop()
        'End While

        'ignore = True
        'MCAbsenteeDataSet.Tables.Clear()
        'For x As Integer = 0 To rows.GetUpperBound(0)
        '    dgvStudent.Rows.Add(rows(x))

        'Next
        'ignore = False
        'mnuRedo.Enabled = undoStack.Count > 0
        'mnuRedo.Enabled = redoStack.Count > 0

        'Public Shared Function NeedsItem(ByVal instance As Stack(Of Object()()), ByVal dgv As DataGridView) As Boolean
        'If instance.Count = 0 Then Return True
        'Dim rows()() As Object = instance.Peek
        'Return Not ItemEquals(rows, dgv.Rows.Cast(Of DataGridViewRow).Where(Function(r) Not r.IsNewRow).ToArray)
        'End Function

        'Private Sub dgvStudent_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellValidated
        'If ignore Then Return
        'If NeedsItem(undoStack, dgvStudent) Then
        '    Console.WriteLine("UndoStackPushed")
        '    undoStack.Push(dgvStudent.Rows.Cast(Of DataGridViewRow).Where(Function(r) Not r.IsNewRow).Select(Function(r) r.Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray).ToArray)
        'End If
        'mnuUndo.Enabled = undoStack.Count > 1
        'End Sub
    End Sub

    Private Sub btnRedo_Click(sender As Object, e As EventArgs) Handles btnRedo.Click
        Try
            Dim numRowsToRedo As Integer = redoFilterCountList.Last()
            For i = 0 To numRowsToRedo - 1
                dgvStudent.Rows(redoFilterList.Last()).Visible = False
                undoFilterList.Add(redoFilterList.Last())
                redoFilterList.RemoveAt(redoFilterList.Count - 1)
            Next
            undoFilterCountList.Add(numRowsToRedo)
            redoFilterCountList.RemoveAt(redoFilterCountList.Count - 1)
        Catch ex As Exception
            MessageBox.Show("There is nothing to redo", "Redo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub dgvStudent_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles dgvStudent.CellParsing
        'Tried to undo text whilst still focused in cell with events such as CellBeginEdit, CurrentCellChanged, Click, CellEnter and CellLeave event but failed
        'Dim cellColumn = Str(e.ColumnIndex)
        'Dim cellRow = Str(e.RowIndex)
        'Dim cellValue = Str(e.Value)
        Dim entry(3) As String
        entry(0) = CStr(e.RowIndex)
        entry(1) = dgvStudent.Columns(e.ColumnIndex).Name
        entry(2) = dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
        entry(3) = CStr(e.Value)
        undoEditList.Add(entry)
        redoEditList.Clear() 'It does not remember old redos
        'countAdditions += 1
    End Sub

    Private Sub mnuUndo_Click(sender As Object, e As EventArgs) Handles mnuUndo.Click
        If undoEditList.Count > 0 Then
            Dim toUndo = undoEditList.Last()
            dgvStudent.Rows(toUndo(0)).Cells(toUndo(1)).Value = toUndo(2)
            redoEditList.Add(undoEditList.Last())
            undoEditList.RemoveAt(undoEditList.Count - 1)
        End If
    End Sub

    Private Sub mnuRedo_Click(sender As Object, e As EventArgs) Handles mnuRedo.Click
        Try
            If redoEditList.Count > 0 Then
                Dim toRedo = redoEditList.Last()
                dgvStudent.Rows(toRedo(0)).Cells(toRedo(1)).Value = toRedo(3)
                undoEditList.Add(redoEditList.Last())
                redoEditList.RemoveAt(redoEditList.Count - 1)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function ComboFilters()
        If TeamNameEvent = True And SportEvent = True Then
            Student_DataTableAdapter.Fill(MCAbsenteeDataSet.Student_Data)
            Dim Sport As String = cmbSport.Text 'Orignally had problems as the combobox was not consistent e.g cannot have spaces at the end
            Dim SportField As String = dgvStudent.Columns(9).Name
            Dim TeamName As String = cmbTeamname.Text 'Has to be consistent e.g cannot have spaces
            Dim TeamNameField As String = dgvStudent.Columns(8).Name

            Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager) 'Because the currently selected cell/row must be visible, thus suspends the binding of all the rows before setting them to invisible, this is especially apparent when deleting rows 
            cm1.SuspendBinding()
            For Each row As DataGridViewRow In dgvStudent.Rows
                dgvStudent.Rows(row.Index).Visible = True
                Try

                    If row.Cells(TeamNameField).Value <> TeamName Or row.Cells(SportField).Value <> Sport Then
                        dgvStudent.Rows(row.Index).Visible = False
                    End If
                Catch ex As Exception
                    Try
                        dgvStudent.Rows(row.Index).Visible = False
                    Catch exe As Exception
                    End Try
                End Try
            Next
            'TeamNameEvent = False
            'SportEvent = False
        End If
    End Function

    Private Sub cmbSport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSport.SelectedIndexChanged
        SportEvent = True
        ComboFilters()

        'Tried to do ComboFilters' functionality in SelectedIndexChanged for each combobox
        'Dim TeamName As String = cmbTeamname.Text ' has to be consistent e.g cannot have spaces
        'Dim TeamNameField As String = dgvStudent.Columns(8).Name

        'Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager) ' because the currently selected cell/row must be visible, thus suspends the binding of all the rows before setting them to invisible, this is especially apparent when deleting rows 
        'cm1.SuspendBinding()
        'For Each row As DataGridViewRow In dgvStudent.Rows
        '    dgvStudent.Rows(row.Index).Visible = True
        '    Try
        '        If row.Cells(TeamNameField).Value <> TeamName And dgvStudent.Rows(row.Index).Visible = True Then
        '            dgvStudent.Rows(row.Index).Visible = False
        '        End If
        '    Catch ex As Exception
        '        dgvStudent.Rows(row.Index).Visible = False
        '        If Len(row.Cells(TeamNameField).Value.ToString) = 0 Then
        '            dgvStudent.Rows(row.Index).Visible = True
        '        End If
        '    End Try
        'Next
    End Sub

    Private Sub cmbTeamname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeamname.SelectedIndexChanged
        TeamNameEvent = True
        ComboFilters()
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        mnuHelp.DoubleClickEnabled = True
        lblHelpInstruction.Show()
        lblUndoRedoInstruction.Show()
        lblSearchInstruction.Show()
        lblFilterInstruction.Show()
        lblDataGridInstructions.Show()
        lblTeamInstruction.Show()
    End Sub

    Private Sub mnuHelp_DoubleClick(sender As Object, e As EventArgs) Handles mnuHelp.DoubleClick
        lblHelpInstruction.Hide()
        lblUndoRedoInstruction.Hide()
        lblSearchInstruction.Hide()
        lblFilterInstruction.Hide()
        lblDataGridInstructions.Hide()
        lblTeamInstruction.Hide()
    End Sub
End Class
