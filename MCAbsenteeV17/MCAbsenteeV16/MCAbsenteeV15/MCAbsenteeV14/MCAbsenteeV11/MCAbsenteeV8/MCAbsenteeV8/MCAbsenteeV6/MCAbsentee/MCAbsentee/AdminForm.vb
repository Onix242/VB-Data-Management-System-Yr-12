'Module Name: Main Screen (Admin)
'Authors Name: Michael Chow 
'Date: 9/8
'Dependencies: AdminLogin.vb 
'Purpose: For the Heads of Girls and Boys Sport, Girls and Boys Sport Absence Monitors and Sport Adminstrator to access student information with ease 
'Bibliography: https://www.youtube.com/channel/UCWc48sSzqPLUOfNCy9sxUug, https://stackoverflow.com/questions/509578/how-to-get-visible-row-count-of-datagridview-after-bindingsource-filter, http://converter.telerik.com/
'Acknowledgements: Chris Do

'Had problems with binding the same datatable from Form1, but found that I did not set it bound
'Namespace BindingSourceMultipleForms
'Public Class MainForm
'Inherits AdminForm

' Public Sub New()
'AddHandler Load, New EventHandler(AddressOf AdminForm_Load)
'End Sub

' Private Shared Sub Main()

'  End Sub
'End Class
'End Namespace

Public Class AdminForm
    'Undos and Redos text inside the datagridview when tabbed out
    Dim undoEditList As New List(Of Array)
    Dim undoEditCountList As New List(Of Array)
    Dim redoEditList As New List(Of Array)
    Dim redoEditCountList As New List(Of Array)

    'switch between filter modes then filter empty cell problem
    'Undos and Redos filters any datagridview changes
    Dim undoFilterList As New List(Of Integer)
    Dim undoFilterCountList As New List(Of Integer)
    Dim redoFilterList As New List(Of Integer)
    Dim redoFilterCountList As New List(Of Integer)

    Dim SortMode As Boolean = False
    Dim CurrentTrackedRowStudentID As Integer

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MCAbsenteeDataSet.Student_Data' table. You can move, or remove it, as needed.
        'Tried converting to x64 bit, all functionalities works excepts the database changes to one not in debug file
        Student_DataTableAdapter.Fill(MCAbsenteeDataSet.Student_Data)
        'dgvStudent.VirtualMode = True
        tmrFilter.Start() 'Way to check if table rows update
        '"DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter" not needed, vb already has inbuilt feature
        dgvStudent.RowsDefaultCellStyle.BackColor = Color.FromArgb(236, 242, 246) 'lighter blue/grey
        dgvStudent.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        dgvStudent.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 213, 225) 'light blue/grey
        dgvStudent.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 51, 153) 'Navy Blue
    End Sub

    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click
        'Clicking off the empty row created vb function error message, and resets to original state
        If cmbSortFilterMode.Text = "Sort" Then
            Try
                StudentDataBindingSource.AddNew() 'Alternative to inbuilt row adding function as it creates difficulties in features such as validation, filter systems, in particular the undoing and redoing in the datagridview
                'The inbuilt feature makes a new row (the one the user inputs) and a "new" new row which is the row that is automatically created after data is inputted in the new row 
            Catch ex As Exception
                MessageBox.Show("Fill in empty row", "Empty Rows", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Occurs when adding multiple empty rows
            End Try
        Else
            MessageBox.Show("Cannot add entry whilst in Filter Mode", "Add Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnDelentry_Click(sender As Object, e As EventArgs) Handles btnDelentry.Click
        'Bibliography: http://www.inforbiro.com/blog-eng/c-sharp-datagridview-confirmation-dialog-on-row-delete/
        If cmbSortFilterMode.Text = "Sort" Then
            If MessageBox.Show("Are you sure?", "Deleting", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                StudentDataBindingSource.RemoveCurrent() 'User clicks on row to remove
            End If
        Else
            MessageBox.Show("Cannot delete entry whilst in Filter Mode", "Delete Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        'Try
        '    For Each row As DataGridViewRow In dgvStudent.Rows
        '        If row.Cells(0).Value = CurrentTrackedRowStudentID Then
        '            StudentDataBindingSource.RemoveAt(row.Index)
        '        End If
        '    Next
        'Catch ex As exception
        'End Try

        'For Each row As DataGridViewRow In dgvStudent.Rows
        'dgvStudent.Rows(row.Index).Visible = True
        ' Next
        'Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager)
        'cm1.Refresh()

        'Bibliography: http://www.inforbiro.com/blog-eng/c-sharp-datagridview-confirmation-dialog-on-row-delete/
        'Console.WriteLine("DELETE ENTRY DEBUG")
        'Console.WriteLine(StudentDataBindingSource.Current)

        'Console.WriteLine(StudentDataBindingSource.Current)

        'If MessageBox.Show("Are you sure?", "Deleting", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '    'Dim currentRow = DirectCast(StudentDataBindingSource.Current, DataRowView)

        '    'StudentDataBindingSource.F
        '    For Each row As DataGridViewRow In dgvStudent.Rows
        '        dgvStudent.Rows(row.Index).Visible = True
        '    Next
        '    'Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager)
        '    'cm1.Refresh()
        '    Try
        '        'cm1.SuspendBinding()

        '        'User clicks on row to remove

        '        'Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager)
        '        'cm1.Refresh()

        '        'StudentDataBindingSource.RemoveFilter()

        '        StudentDataBindingSource.RemoveCurrent()
        '    Catch ex As Exception
        '        MessageBox.Show("Please click on cell you wish to delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    End Try

        '    'StudentDataBindingSource.Remove(currentRow)
        '    'Console.WriteLine("CurenCellValue: " + Str(dgvStudent.CurrentCell.Value))
        '    'StudentDataBindingSource.RemoveAt(dgvStudent.CurrentCell.Last())
        '    'StudentDataBindingSource.RemoveCurrent()
        '    'cm1.ResumeBinding() Remove(currentRow)
        '    'Console.WriteLine(StudentDataBindingSource.Current)
        '    'For Each row As DataGridViewRow In dgvStudent.Rows
        '    '    dgvStudent.Rows(row.Index).Visible = True
        '    'Next
        'Else
        'End If

        'Tried undoing deleted rows, scrapped as it is assumed the rows would definite in deleting and is obsolete because of the deleting statement in btnDelete event
        ' e.Cancel = MessageBox.Show("Really delete?", "", MessageBoxButtons.OKCancel) = DialogResult.Cancel
        'Dim lastDeletedDataRow = TryCast(e.Row.DataBoundItem, DataRow)
        'lastDeletedDataRow.SetModified()
        ' If Not MessageBox.Show("Are you sure?", "Deleting", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        'e.Cancel = True
        'End If
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
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
            If ((e.State And DataGridViewElementStates.Selected) <> DataGridViewElementStates.None) Then
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
    End Sub

    Private Sub dgvStudent_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellDoubleClick
        'Bibiliography: https://stackoverflow.com/questions/509578/how-to-get-visible-row-count-of-datagridview-after-bindingsource-filter
        'Originally used the ContentClick event which had issues where users could click on the content headers and crash the program
        'Undoing functionailty for full reset works when clicked on the in-built sort function, and can hide everything if double clicked
        'If e.RowIndex <> 0 Then
        Console.WriteLine("CellDouble")
        'Console.WriteLine(CStr(InvisibleRows.Count))
        'SortModeOn = False
        'Console.WriteLine(Str(e.RowIndex))
        If SortMode = False Then
            If e.RowIndex <> -1 Then
                Try 'Without this, if the user triple clicks in succession would crash the program
                    ' redoFilterList.Clear()
                    ' redoFilterCountList.Clear()
                    Dim field As String = dgvStudent.Columns(e.ColumnIndex).Name 'Stores column name into a variable
                    Dim key As String
                    Try
                        key = dgvStudent.CurrentCell.Value
                    Catch ex As Exception
                        key = "NULL" 'To not crash program since key needs a value
                    End Try
                    Dim cm1 As CurrencyManager = CType(BindingContext(dgvStudent.DataSource), CurrencyManager)
                    'Because the currently selected cell/row must be visible, thus suspends the binding of all the rows before setting them to invisible, this is especially apparent when deleting rows 
                    cm1.SuspendBinding() 'Also "cm1.ResumeBinding()", or refreshing the CurrencyManager was omitted since the datagridview screen updates itself
                    ' Dim changedUndexes As New List(Of Integer)
                    Dim countAdditions As Integer = 0 'Count number of rows that needs to be filters
                    Dim beforeCount As Integer = dgvStudent.Rows.GetRowCount(DataGridViewElementStates.Visible)
                    redoFilterList.Clear() 'Program had saved the undo filters to be removed
                    redoFilterCountList.Clear()
                    For Each row As DataGridViewRow In dgvStudent.Rows '"Originally had "For i = 0 To 6", but if changed later, it will have to be programmatically fixed 
                        'For i = 0 To 6
                        'Console.WriteLine(row.Cells(field).Value)
                        'Console.WriteLine(key)
                        Try 'Adds to undo filter list 
                            'If Not (row.Cells(field).Value Is Nothing) Then
                            If row.Cells(field).Value <> key And dgvStudent.Rows(row.Index).Visible = True Then 'Turning rows invisibles if they don't match key
                                dgvStudent.Rows(row.Index).Visible = False
                                'changedUndexes.Add(row.Index)
                                undoFilterList.Add(row.Index)
                                countAdditions += 1
                                'Console.WriteLine("filtered")
                            End If
                            'End If
                        Catch ex As Exception
                            dgvStudent.Rows(row.Index).Visible = False
                            If Len(row.Cells(field).Value.ToString) = 0 Then 'Enabling filtering by empty cells
                                dgvStudent.Rows(row.Index).Visible = True
                            End If
                            'Console.WriteLine(row.Cells(field).Value)
                        End Try
                        'Next
                    Next

                    If dgvStudent.Rows.GetRowCount(DataGridViewElementStates.Visible) <> beforeCount Then
                        undoFilterCountList.Add(countAdditions)
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnFullreset_Click(sender As Object, e As EventArgs) Handles btnFullreset.Click
        'Originally attempted to recopy the entire datatable - it was too difficult
        For Each row As DataGridViewRow In dgvStudent.Rows
            dgvStudent.Rows(row.Index).Visible = True
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

    Private Sub dgvStudent_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvStudent.CellFormatting
        'Bibliography: https://stackoverflow.com/questions/50128867/make-the-first-character-upper-case-of-a-string-in-win-form-datagridview-c-net
        'Separate from CellValidating event as code can be shortened
        Try 'If there is no try statement, some of the entries in datagridview does not appear and works in tandem with cell end edit
            Select Case e.ColumnIndex
                Case 1, 2, 6 'Effects Surname, Firstname, and Other Notes
                    If e.Value IsNot Nothing Then
                        Dim str As String = CStr(e.Value)
                        str = Char.ToUpper(str(0)) & str.Substring(1) 'The only first characters are capitalised, originally made this as a public function but could be condensed 
                        e.Value = str
                    End If
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvStudent_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvStudent.CellValidating
        'Bibliography: https://stackoverflow.com/questions/2460284/how-to-roll-back-changes-in-gridview-in-case-of-incorrect-input, https://stackoverflow.com/questions/2813505/get-last-5-characters-in-a-string,  
        'https://www.daniweb.com/programming/software-development/threads/334424/datagridview-input-validation-vb-net, http://www.vbforums.com/showthread.php?648141-RESOLVED-Datagridview-specif-column(s)-capital-letters
        'Does work in tandem with CellEndEdit event - also all of validation was in CellEndEdit but did not allow for "dgvStudent.CancelEdit", an undo feature for incorrect values; "e.Cancel = True" and "dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty" did not provide this 
        'Had tried "StudentDataBindingSource.CancelEdit()" and "dgvStudent.RefreshEdit()", but makes it so the column cannot be edited 
        Try 'Fixed exiting from creating new entries

            'Not necessary - creates multiple error messages to conflict/occur
            'Select Case e.ColumnIndex
            '    Case 1, 2, 3 'Effects Surname, Firstname and Year
            '        If dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
            '            Dim value As String = CStr(e.FormattedValue)
            '            If value.Contains(" ") Or value.Contains("-") Or value.Contains(".") Or value.Contains("?") Then 
            '                MessageBox.Show("Cannot contain any non alphanumeric character(s)")
            '                dgvStudent.CancelEdit()
            '            End If
            '        End If
            'End Select

            If e.ColumnIndex = 0 Then 'Effects StudentID, originally had "dgvStudent.Columns(e.ColumnIndex).HeaderText = "StudentID"" but was too long for validating multiple columns
                If dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
                    Dim value As String = CStr(e.FormattedValue) 'Originally had value equal to "dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()", but was too lengthy
                    If Not IsNumeric(value) Then
                        MessageBox.Show("Please enter a numeric StudentID", "Validity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        dgvStudent.CancelEdit() 'Makes it so that the redo does not save the previous incorrect character(s)
                    End If
                    If value.Contains(" ") Or value.Contains("-") Or value.Contains(".") Or value.Contains("?") Then 'Numeric values includes decimal points, as well as negative numbers - contains statement have to be individual https://stackoverflow.com/questions/2212719/vb-net-adding-more-than-1-string-to-contains
                        MessageBox.Show("Cannot contain any non alphanumeric character(s)")
                        dgvStudent.CancelEdit()
                    End If
                End If
            End If

            If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Then 'Effects Surname, Firstname
                If dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
                    Dim value As String = CStr(e.FormattedValue)
                    If IsNumeric(value) Then
                        MessageBox.Show("Please enter only letters")
                        dgvStudent.CancelEdit()
                        Exit Sub
                    End If
                End If
            End If

            If e.ColumnIndex = 3 Then 'Effects Year; cannot become a DataGridViewComboBox because it deals with only numbers (not mixture)
                If dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
                    Dim Yearvalue As Integer = Int(e.FormattedValue)
                    'MessageBox.Show(Yearvalue)
                    If Not (Yearvalue = 11 Or Yearvalue = 12) Then
                        MessageBox.Show("Please enter only valid years between 11 and 12", "Validity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        dgvStudent.CancelEdit()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

        'Originally had but was not necessary since form could be made into a combobox column
        'If e.ColumnIndex = 4 Then 'Effects Form
        '    If dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
        '        Dim Numvalue As String = CStr(e.FormattedValue)
        '        Numvalue = Numvalue.Substring(0, 2)
        '        If Not IsNumeric(Numvalue) Then 'Replaces "isnumeric(numvalue) = false", as it was too lengthy
        '            MessageBox.Show("Not a valid input; it should only contain numbers", "Validity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '            dgvStudent.CancelEdit()
        '        Else
        '            Dim Lettervalue As String = CStr(e.FormattedValue)
        '            Lettervalue = Lettervalue.Substring(Lettervalue.Length - 3) 'Gets the last 3 characters of the string, cannot use the previous numvalue equals statement, it only whens at the beginning of the string
        '            ' MessageBox.Show(Lettervalue)
        '            'strUpperValue = dgvStudent.CurrentCell.Value
        '            '        dgvStudent.CurrentCell.Value = strUpperValue.ToUpper
        '            Dim keywords = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        '            For Each keyword As String In keywords
        '                If Lettervalue.Contains(keyword) Then 'Originally the if statment had "IsNumeric(Lettervalue)" but it did not consider the combination of both numeric and alphabetic characters
        '                    MessageBox.Show("Not a valid input; it should only contain letters", "Validity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'An issue had also occured when just clicking onto the cell and exiting
        '                    dgvStudent.CancelEdit()
        '                End If
        '            Next
        '        End If
        '    End If
        'End If

        'Discovered DataGridViewCheckBoxColumn for "Anaphylactic", since "yes" and "no" in statement conflicts with setting the columns as DataGridViewTextBox, and terms can be searched
        'If e.ColumnIndex = 5 Then
        '    If dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
        '        Dim value As Boolean = CStr(e.FormattedValue)
        '        If value <> "Yes" And "No" Then
        '            MessageBox.Show("Please enter only Yes and No")
        '            dgvStudent.CancelEdit()
        '        End If
        '    End If
        'End If

        'Originally had some in CellEndEdit event
        'Try
        'If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Then
        '        If dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
        '        Dim value As String = dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

        '        'For Each row As DataGridViewRow In dgvStudent.Rows
        '        'Dim str As String = CStr(value)
        '        'value = StrConv(value.ToUpper(Str(0)) & value.Substring(1))
        '        'value = StrConv(value, vbProperCase)
        '        'Next
        '        'value = UppercaseFirst()
        '        'value = StrConv(value, VbStrConv.ProperCase)
        '        'Dim str As String = CStr(value)
        '        'value = Char.ToUpper(Str(0)) Str.Substring(1)

        '        'Dim NewStr As String = StrConv(value, VbStrConv.ProperCase)
        '        'StrConv(value, VbStrConv.ProperCase)
        '        If IsNumeric(value) Then
        '            MessageBox.Show("Please enter only letters")
        '            dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
        '            Exit Sub
        '        End If

        '        'Dim strUpperValue As String
        '        'strUpperValue = dgvStudent.CurrentCell.Value
        '        'dgvStudent.CurrentCell.Value = strUpperValue.ToUpper
        '    End If
        '    End If

        'Creates problems when deleting an entry with at least 1 other filled cell
        'Dim strUpperValue As String
        'Select Case e.ColumnIndex
        '    Case 4
        '        strUpperValue = dgvStudent.CurrentCell.Value
        '        dgvStudent.CurrentCell.Value = strUpperValue.ToUpper
        'End Select

        'Catch ex As Exception
        'End Try

        'If (e.ColumnIndex = 1) Then
        '    dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing Then 
        '        Dim value As String = dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
        '    If Not Information.IsNumeric(value) Then
        '        MessageBox.Show("Please enter numeric number")
        '    End If
        '    dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
        '    Exit Sub
        'End If
        'End If
    End Sub

    Private Sub dgvStudent_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles dgvStudent.CellParsing
        'Trigger event for undo edits
        Dim entry(3) As String
        entry(0) = CStr(e.RowIndex)
        entry(1) = dgvStudent.Columns(e.ColumnIndex).Name
        entry(2) = dgvStudent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() 'Original value being edited
        entry(3) = CStr(e.Value) 'Post edited value
        undoEditList.Add(entry)
        redoEditList.Clear() 'It does not remember old redos

    End Sub

    Private Sub mnuUndo_Click(sender As Object, e As EventArgs) Handles mnuUndo.Click
        'Invisible cell(s) edits can be undone without row being visible
        If undoEditList.Count > 0 Then
            Dim toUndo = undoEditList.Last()
            dgvStudent.Rows(toUndo(0)).Cells(toUndo(1)).Value = toUndo(2)
            redoEditList.Add(undoEditList.Last())
            undoEditList.RemoveAt(undoEditList.Count - 1)
        End If
    End Sub

    Private Sub mnuRedo_Click(sender As Object, e As EventArgs) Handles mnuRedo.Click
        'Invisible cell(s) edits can be redone without row being visible
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

    Private Sub cmbSortMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSortFilterMode.SelectedIndexChanged
        'Combobox starts with set value, "Filter" so Full Reset does not occur
        If cmbSortFilterMode.Text = "Filter" Then
            SortMode = False
            For Each column As DataGridViewColumn In dgvStudent.Columns
                column.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        Else
            btnFullreset_Click(sender, e) 'Activates Full Reset
            undoFilterList.Clear()
            undoFilterCountList.Clear()
            redoFilterList.Clear()
            redoFilterCountList.Clear()
            MessageBox.Show("Filter has been fully reset", "Filter Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SortMode = True
            For Each column As DataGridViewColumn In dgvStudent.Columns
                column.SortMode = DataGridViewColumnSortMode.Automatic
            Next
        End If
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        mnuHelp.DoubleClickEnabled = True
        lblHelpInstruction.Show()
        lblUndoRedoInstruction.Show()
        lblDeleteInstruction.Show()
        lblSearchInstruction.Show()
        lblSortInstruction.Show()
        lblFilterInstruction.Show()
        lblDataGridInstructions.Show()
    End Sub

    Private Sub mnuHelp_DoubleClick(sender As Object, e As EventArgs) Handles mnuHelp.DoubleClick
        lblHelpInstruction.Hide()
        lblUndoRedoInstruction.Hide()
        lblDeleteInstruction.Hide()
        lblSearchInstruction.Hide()
        lblSortInstruction.Hide()
        lblFilterInstruction.Hide()
        lblDataGridInstructions.Hide()
    End Sub
End Class