Imports System.Windows.Forms
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReadForm
    Inherits Form

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

    ' Token: 0x06000017 RID: 23 RVA: 0x00002BB8 File Offset: 0x00000DB8
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReadForm))
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exportToCSVFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.homepageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.openToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.exportToCSVFileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.copyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.waitPanel = New System.Windows.Forms.Panel()
        Me.WaitLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuStrip.SuspendLayout()
        Me.waitPanel.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.viewToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(744, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "menuStrip"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem, Me.closeToolStripMenuItem, Me.toolStripMenuItem1, Me.exportToCSVFileToolStripMenuItem, Me.toolStripMenuItem2, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.openToolStripMenuItem.Text = "Open..."
        '
        'closeToolStripMenuItem
        '
        Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
        Me.closeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.closeToolStripMenuItem.Text = "Close"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(164, 6)
        '
        'exportToCSVFileToolStripMenuItem
        '
        Me.exportToCSVFileToolStripMenuItem.Name = "exportToCSVFileToolStripMenuItem"
        Me.exportToCSVFileToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.exportToCSVFileToolStripMenuItem.Text = "Export to CSV File"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(164, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'viewToolStripMenuItem
        '
        Me.viewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyToolStripMenuItem, Me.selectAllToolStripMenuItem})
        Me.viewToolStripMenuItem.Name = "viewToolStripMenuItem"
        Me.viewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.viewToolStripMenuItem.Text = "View"
        '
        'copyToolStripMenuItem
        '
        Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
        Me.copyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.copyToolStripMenuItem.Text = "Copy"
        '
        'selectAllToolStripMenuItem
        '
        Me.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
        Me.selectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.selectAllToolStripMenuItem.Text = "Select All"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homepageToolStripMenuItem, Me.toolStripMenuItem3, Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.helpToolStripMenuItem.Text = "Help"
        '
        'homepageToolStripMenuItem
        '
        Me.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem"
        Me.homepageToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.homepageToolStripMenuItem.Text = "Homepage"
        '
        'toolStripMenuItem3
        '
        Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
        Me.toolStripMenuItem3.Size = New System.Drawing.Size(130, 6)
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.aboutToolStripMenuItem.Text = "About"
        '
        'openFileDialog
        '
        Me.openFileDialog.DefaultExt = "xls"
        Me.openFileDialog.Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx"
        '
        'tabControl
        '
        Me.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(0, 24)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(744, 540)
        Me.tabControl.TabIndex = 1
        '
        'saveFileDialog
        '
        Me.saveFileDialog.DefaultExt = "csv"
        Me.saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
        '
        'openToolStripMenuItem1
        '
        Me.openToolStripMenuItem1.Name = "openToolStripMenuItem1"
        Me.openToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.openToolStripMenuItem1.Text = "Open..."
        '
        'closeToolStripMenuItem1
        '
        Me.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1"
        Me.closeToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.closeToolStripMenuItem1.Text = "Close"
        '
        'toolStripMenuItem4
        '
        Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
        Me.toolStripMenuItem4.Size = New System.Drawing.Size(164, 6)
        '
        'exportToCSVFileToolStripMenuItem1
        '
        Me.exportToCSVFileToolStripMenuItem1.Name = "exportToCSVFileToolStripMenuItem1"
        Me.exportToCSVFileToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.exportToCSVFileToolStripMenuItem1.Text = "Export to CSV File"
        '
        'toolStripMenuItem5
        '
        Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
        Me.toolStripMenuItem5.Size = New System.Drawing.Size(164, 6)
        '
        'copyToolStripMenuItem1
        '
        Me.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1"
        Me.copyToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.copyToolStripMenuItem1.Text = "Copy"
        '
        'selectAllToolStripMenuItem1
        '
        Me.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1"
        Me.selectAllToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.selectAllToolStripMenuItem1.Text = "Select All"
        '
        'waitPanel
        '
        Me.waitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.waitPanel.Controls.Add(Me.WaitLabel)
        Me.waitPanel.Location = New System.Drawing.Point(254, 13)
        Me.waitPanel.Name = "waitPanel"
        Me.waitPanel.Size = New System.Drawing.Size(200, 50)
        Me.waitPanel.TabIndex = 2
        Me.waitPanel.Visible = False
        '
        'WaitLabel
        '
        Me.WaitLabel.Location = New System.Drawing.Point(3, 13)
        Me.WaitLabel.Name = "WaitLabel"
        Me.WaitLabel.Size = New System.Drawing.Size(194, 25)
        Me.WaitLabel.TabIndex = 0
        Me.WaitLabel.Text = "Reading..."
        Me.WaitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem1, Me.closeToolStripMenuItem1, Me.toolStripMenuItem4, Me.exportToCSVFileToolStripMenuItem1, Me.toolStripMenuItem5, Me.copyToolStripMenuItem1, Me.selectAllToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "contextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 148)
        '
        'ReadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 564)
        Me.ContextMenuStrip = Me.ContextMenuStrip
        Me.Controls.Add(Me.waitPanel)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.menuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "ReadForm"
        Me.Text = "XLS Reader (www.xlsreader.com)"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.waitPanel.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents openToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents closeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents exportToCSVFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents selectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents helpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents homepageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents openToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents closeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents copyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents selectAllToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents exportToCSVFileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents waitPanel As Panel
    Friend WithEvents toolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents toolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents toolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents toolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents toolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents WaitLabel As Label
    Friend WithEvents tabControl As TabControl
    Friend WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents copyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents viewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents openFileDialog As OpenFileDialog
    Friend WithEvents saveFileDialog As SaveFileDialog
    Friend WithEvents menuStrip As MenuStrip
    ' Token: 0x04000002 RID: 2
    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
End Class
