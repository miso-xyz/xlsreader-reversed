Imports System
Imports System.Linq
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Excel
Imports NPOI.SS.UserModel
Imports System.Collections.Generic
Imports System.Diagnostics
Public Class ReadForm
    Dim XLS_Filename As String
    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles aboutToolStripMenuItem.Click
        MessageBox.Show("XLS Reader (Freeware)" & vbCrLf & "www.xlsreader.com" & vbCrLf & vbCrLf & "NPOI (Apache License)" & vbCrLf & "npoi.codeplex.com" & vbCrLf & vbCrLf & "Excel Data Reader (The MIT License)" & vbCrLf & "exceldatareader.codeplex.com", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub closeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles closeToolStripMenuItem.Click, closeToolStripMenuItem1.Click
        closeXLS()
    End Sub

    Private Sub closeXLS()
        If Me.waitPanel.Visible Then
            Me.waitPanel.Visible = False
        End If
        If Me.XLS_Filename = "" Then
            Return
        End If
        Me.XLS_Filename = ""
        For Each obj As Object In Me.tabControl.TabPages
            Dim tabPage As TabPage = CType(obj, TabPage)
            tabPage.Controls(0).Dispose()
        Next
        Me.tabControl.TabPages.Clear()
        Me.Text = "XLS Reader (www.xlsreader.com)"
    End Sub

    Private Sub copyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles copyToolStripMenuItem.Click, copyToolStripMenuItem1.Click
        Dim dataGridView As DataGridView = Me.currentGataGridView()
        If dataGridView Is Nothing Then
            Return
        End If
        Clipboard.SetDataObject(dataGridView.GetClipboardContent())
    End Sub

    Private Function currentGataGridView() As DataGridView
        If Me.XLS_Filename = "" Then
            Return Nothing
        End If
        If Me.tabControl.TabPages.Count = 0 Then
            Return Nothing
        End If
        Return CType(Me.tabControl.TabPages(Me.tabControl.SelectedIndex).Controls(0), DataGridView)
    End Function

    Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub exportToCSVFileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exportToCSVFileToolStripMenuItem.Click, exportToCSVFileToolStripMenuItem1.Click
        Dim dataGridView As DataGridView = Me.currentGataGridView()
        If dataGridView Is Nothing Then
            Return
        End If
        If Me.tabControl.TabPages.Count > 1 Then
            Me.saveFileDialog.FileName = Path.GetFileNameWithoutExtension(Me.XLS_Filename) + " - " + Me.tabControl.TabPages(Me.tabControl.SelectedIndex).Text + ".csv"
        Else
            Me.saveFileDialog.FileName = Path.ChangeExtension(Me.XLS_Filename, ".csv")
        End If
        If Me.saveFileDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If
        Try
            Dim stringBuilder As StringBuilder = New StringBuilder()
            Dim source As IEnumerable(Of DataGridViewColumn) = dataGridView.Columns.Cast(Of DataGridViewColumn)()
            stringBuilder.Append(String.Join(",", source.[Select](Function(column As DataGridViewColumn) """" + column.HeaderText + """")))
            stringBuilder.AppendLine()
            For Each obj As Object In CType(dataGridView.Rows, DataGridViewRowCollection)
                Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
                Dim source2 As IEnumerable(Of DataGridViewCell) = dataGridViewRow.Cells.Cast(Of DataGridViewCell)()
                stringBuilder.Append(String.Join(",", source2.[Select](Function(cell As DataGridViewCell) """" + cell.Value + """")))
                stringBuilder.AppendLine()
            Next
            Dim streamWriter As StreamWriter = New StreamWriter(Me.saveFileDialog.FileName, False, Encoding.UTF8)
            streamWriter.WriteLine(stringBuilder)
            streamWriter.Flush()
            streamWriter.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Public Shared Function GetDataSet(ByVal filename As String) As DataSet
        Dim dataSet As DataSet = Nothing
        Dim workbook As IWorkbook
        Try
            workbook = WorkbookFactory.Create(filename)
        Catch
            Return Nothing
        End Try
        dataSet = New DataSet()
        For i As Integer = 0 To workbook.NumberOfSheets - 1
            Try
                Dim sheetAt As ISheet = workbook.GetSheetAt(i)
                If sheetAt IsNot Nothing Then
                    Dim dataTable As DataTable = ReadForm.GetDataTable(sheetAt)
                    If dataTable IsNot Nothing Then
                        dataSet.Tables.Add(dataTable)
                    End If
                End If
            Catch
            End Try
        Next
        Return dataSet
    End Function

    Public Shared Function GetDataTable(ByVal sheet As ISheet) As DataTable
        Dim dataTable As DataTable = New DataTable()
        dataTable.TableName = sheet.SheetName
        Dim row As IRow = sheet.GetRow(0)
        Try
            Dim lastCellNum As Integer = CInt(row.LastCellNum)
            Dim num As Integer = CInt(row.FirstCellNum)
            If num > 0 Then
                num = 0
            End If
            For i As Integer = num To lastCellNum - 1
                dataTable.Columns.Add("Column " + (i + 1).ToString())
            Next
            Dim lastRowNum As Integer = sheet.LastRowNum
            For j As Integer = sheet.FirstRowNum To sheet.LastRowNum
                Dim row2 As IRow = Nothing
                Dim dataRow As DataRow = Nothing
                Try
                    row2 = sheet.GetRow(j)
                    dataRow = dataTable.NewRow()
                Catch
                    row2 = Nothing
                    dataRow = Nothing
                End Try
                If row2 IsNot Nothing AndAlso dataRow IsNot Nothing Then
                    For k As Integer = CInt(row2.FirstCellNum) To lastCellNum - 1
                        If row2.GetCell(k) IsNot Nothing Then
                            Try
                                Select Case row2.GetCell(k).CellType
                                    Case CellType.NUMERIC
                                        row2.GetCell(k).CellStyle.GetDataFormatString()
                                        dataRow(k) = row2.GetCell(k).ToString()
                                        GoTo IL_1A2
                                    Case CellType.[STRING]
                                        dataRow(k) = row2.GetCell(k).StringCellValue
                                        GoTo IL_1A2
                                    Case CellType.BLANK
                                        dataRow(k) = ""
                                        GoTo IL_1A2
                                    Case CellType.[BOOLEAN]
                                        dataRow(k) = row2.GetCell(k).BooleanCellValue
                                        GoTo IL_1A2
                                    Case CellType.[ERROR]
                                        dataRow(k) = row2.GetCell(k).ErrorCellValue
                                        GoTo IL_1A2
                                End Select
                                dataRow(k) = row2.GetCell(k).CellFormula
IL_1A2:
                            Catch
                                Exit Try
                            End Try
                        End If
                    Next
                    dataTable.Rows.Add(dataRow)
                End If
            Next
        Catch ex As Exception
            Throw ex
        Finally
            sheet = Nothing
        End Try
        Return dataTable
    End Function

    Public Shared Function GetExcelDataSet(ByVal filename As String) As DataSet
        Dim result As DataSet = Nothing
        Try
            Dim fileStream As FileStream = File.Open(filename, FileMode.Open, FileAccess.Read)
            Dim a As String = Path.GetExtension(filename).ToLower()
            Dim excelDataReader As IExcelDataReader
            If a = ".xlsx" Then
                excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(fileStream)
            Else
                excelDataReader = ExcelReaderFactory.CreateBinaryReader(fileStream)
            End If
            result = excelDataReader.AsDataSet()
        Catch
            Return Nothing
        End Try
        Return result
    End Function

    Private Sub homepageToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles homepageToolStripMenuItem.Click
        Process.Start("www.xlsreader.com")
    End Sub

    Private Sub openToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles openToolStripMenuItem.Click, openToolStripMenuItem1.Click
        If Me.openFileDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If
        Me.closeXLS()
        Me.openXLS(Me.openFileDialog.FileName)
    End Sub

    Private Sub openXLS(ByVal filename As String)
        If Not File.Exists(filename) Then
            Return
        End If
        Me.ReadForm_Resize(Nothing, Nothing)
        Me.waitPanel.Visible = True
        Me.waitPanel.Refresh()
        Me.menuStrip.Enabled = False
        Me.ContextMenuStrip1.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim dataSet As DataSet = ReadForm.GetDataSet(filename)
            If dataSet Is Nothing Then
                dataSet = ReadForm.GetExcelDataSet(filename)
            End If
            If dataSet Is Nothing Then
                MessageBox.Show("Cannot open file """ + filename + """", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                For Each obj As Object In dataSet.Tables
                    Dim dataTable As DataTable = CType(obj, DataTable)
                    Me.tabControl.TabPages.Add(dataTable.TableName)
                    Dim tabPage As TabPage = Me.tabControl.TabPages(Me.tabControl.TabPages.Count - 1)
                    Dim dataGridView As DataGridView = New DataGridView()
                    dataGridView.Parent = tabPage
                    dataGridView.Left = 0
                    dataGridView.Top = 0
                    dataGridView.Width = tabPage.Width
                    dataGridView.Height = tabPage.Height
                    dataGridView.Dock = DockStyle.Fill
                    dataGridView.ContextMenuStrip = Me.ContextMenuStrip1
                    dataGridView.DataSource = dataTable
                    dataGridView.[ReadOnly] = True
                    dataGridView.Visible = True
                    AddHandler dataGridView.ColumnHeaderMouseClick, AddressOf Me.dataGridView_ColumnHeaderMouseClick
                    If Me.tabControl.TabPages.Count = 1 Then
                        For i As Integer = 0 To dataGridView.Rows.Count - 1
                            dataGridView.Rows(i).HeaderCell.Value = (i + 1).ToString()
                        Next
                        dataGridView.RowHeadersWidth = 60
                    End If
                Next
                Me.XLS_Filename = filename
                Me.Text = filename
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Me.waitPanel.Visible = False
            Me.menuStrip.Enabled = True
            Me.ContextMenuStrip1.Enabled = True
            Me.Cursor = Cursors.[Default]
        End Try
    End Sub
    Private Sub dataGridView_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs)
        Me.tabControl_SelectedIndexChanged(Nothing, Nothing)
    End Sub
    Private Sub ReadForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        closeXLS()
    End Sub

    Private Sub ReadForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.waitPanel.Left <> (MyBase.ClientSize.Width - Me.waitPanel.Width) / 2 Then
            Me.waitPanel.Left = (MyBase.ClientSize.Width - Me.waitPanel.Width) / 2
        End If
        If Me.waitPanel.Top <> (MyBase.ClientSize.Height - Me.waitPanel.Height) / 2 Then
            Me.waitPanel.Top = (MyBase.ClientSize.Height - Me.waitPanel.Height) / 2
        End If
    End Sub

    Private Sub ReadForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Me.openFileDialog.FileName <> "" Then
            Me.openXLS(Me.openFileDialog.FileName)
        End If
    End Sub

    Private Sub selectAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles selectAllToolStripMenuItem.Click, selectAllToolStripMenuItem1.Click
        Dim dataGridView As DataGridView = Me.currentGataGridView()
        If dataGridView Is Nothing Then
            Return
        End If
        dataGridView.SelectAll()
    End Sub

    Private Sub tabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabControl.SelectedIndexChanged
        Dim dataGridView As DataGridView = Me.currentGataGridView()
        If dataGridView Is Nothing Then
            Return
        End If
        If dataGridView.RowHeadersWidth <> 60 OrElse sender Is Nothing Then
            For i As Integer = 0 To dataGridView.Rows.Count - 1
                dataGridView.Rows(i).HeaderCell.Value = (i + 1).ToString()
            Next
            dataGridView.RowHeadersWidth = 60
        End If
    End Sub
End Class