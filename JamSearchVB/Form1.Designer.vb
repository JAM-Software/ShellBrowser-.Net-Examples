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
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.numericNoLessThan = New System.Windows.Forms.NumericUpDown
        Me.label5 = New System.Windows.Forms.Label
        Me.numericNotGreaterThan = New System.Windows.Forms.NumericUpDown
        Me.label4 = New System.Windows.Forms.Label
        Me.checkBoxNoLessThanKiB = New System.Windows.Forms.CheckBox
        Me.checkBoxNoMoreThanKiB = New System.Windows.Forms.CheckBox
        Me.buttStopSearch = New System.Windows.Forms.Button
        Me.checkBoxCaseSensitiveWildcards = New System.Windows.Forms.CheckBox
        Me.checkBoxBefore = New System.Windows.Forms.CheckBox
        Me.tabPage3 = New System.Windows.Forms.TabPage
        Me.checkBoxShowFolders = New System.Windows.Forms.CheckBox
        Me.dateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.SearchProgressBar = New System.Windows.Forms.ProgressBar
        Me.panel1 = New System.Windows.Forms.Panel
        Me.tabControl1 = New System.Windows.Forms.TabControl
        Me.tabPage1 = New System.Windows.Forms.TabPage
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.checkBoxRecursive = New System.Windows.Forms.CheckBox
        Me.buttonBrowse = New System.Windows.Forms.Button
        Me.shellComboBox1 = New Jam.Shell.ShellComboBox
        Me.shellControlConnector1 = New Jam.Shell.ShellControlConnector
        Me.textBoxSearchPattern = New System.Windows.Forms.TextBox
        Me.tabPage2 = New System.Windows.Forms.TabPage
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.checkBoxAfter = New System.Windows.Forms.CheckBox
        Me.comboSelectAccess = New System.Windows.Forms.ComboBox
        Me.radioButtonFindSpecificallyAccessedFiles = New System.Windows.Forms.RadioButton
        Me.radioButtonAllFiles = New System.Windows.Forms.RadioButton
        Me.buttStartSearch = New System.Windows.Forms.Button
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.searchResults = New Jam.Shell.FileList
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStripStatusSizeAndCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.groupBox1.SuspendLayout()
        CType(Me.numericNoLessThan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericNotGreaterThan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage3.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.shellComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.searchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.numericNoLessThan)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.numericNotGreaterThan)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.checkBoxNoLessThanKiB)
        Me.groupBox1.Controls.Add(Me.checkBoxNoMoreThanKiB)
        Me.groupBox1.Location = New System.Drawing.Point(8, 38)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(334, 74)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Size restrictions"
        '
        'numericNoLessThan
        '
        Me.numericNoLessThan.Enabled = False
        Me.numericNoLessThan.Location = New System.Drawing.Point(181, 16)
        Me.numericNoLessThan.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numericNoLessThan.Name = "numericNoLessThan"
        Me.numericNoLessThan.Size = New System.Drawing.Size(120, 20)
        Me.numericNoLessThan.TabIndex = 1
        Me.numericNoLessThan.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(307, 46)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(21, 13)
        Me.label5.TabIndex = 6
        Me.label5.Text = "KB"
        '
        'numericNotGreaterThan
        '
        Me.numericNotGreaterThan.Enabled = False
        Me.numericNotGreaterThan.Location = New System.Drawing.Point(181, 42)
        Me.numericNotGreaterThan.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numericNotGreaterThan.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericNotGreaterThan.Name = "numericNotGreaterThan"
        Me.numericNotGreaterThan.Size = New System.Drawing.Size(120, 20)
        Me.numericNotGreaterThan.TabIndex = 2
        Me.numericNotGreaterThan.Value = New Decimal(New Integer() {1024, 0, 0, 0})
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(307, 19)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(21, 13)
        Me.label4.TabIndex = 5
        Me.label4.Text = "KB"
        '
        'checkBoxNoLessThanKiB
        '
        Me.checkBoxNoLessThanKiB.AutoSize = True
        Me.checkBoxNoLessThanKiB.Location = New System.Drawing.Point(74, 19)
        Me.checkBoxNoLessThanKiB.Name = "checkBoxNoLessThanKiB"
        Me.checkBoxNoLessThanKiB.Size = New System.Drawing.Size(85, 17)
        Me.checkBoxNoLessThanKiB.TabIndex = 3
        Me.checkBoxNoLessThanKiB.Text = "No less than"
        Me.checkBoxNoLessThanKiB.UseVisualStyleBackColor = True
        '
        'checkBoxNoMoreThanKiB
        '
        Me.checkBoxNoMoreThanKiB.AutoSize = True
        Me.checkBoxNoMoreThanKiB.Location = New System.Drawing.Point(74, 45)
        Me.checkBoxNoMoreThanKiB.Name = "checkBoxNoMoreThanKiB"
        Me.checkBoxNoMoreThanKiB.Size = New System.Drawing.Size(103, 17)
        Me.checkBoxNoMoreThanKiB.TabIndex = 4
        Me.checkBoxNoMoreThanKiB.Text = "Not greater than"
        Me.checkBoxNoMoreThanKiB.UseVisualStyleBackColor = True
        '
        'buttStopSearch
        '
        Me.buttStopSearch.Enabled = False
        Me.buttStopSearch.Location = New System.Drawing.Point(444, 60)
        Me.buttStopSearch.Name = "buttStopSearch"
        Me.buttStopSearch.Size = New System.Drawing.Size(107, 23)
        Me.buttStopSearch.TabIndex = 2
        Me.buttStopSearch.Text = "Cancel"
        Me.buttStopSearch.UseVisualStyleBackColor = True
        '
        'checkBoxCaseSensitiveWildcards
        '
        Me.checkBoxCaseSensitiveWildcards.AutoSize = True
        Me.checkBoxCaseSensitiveWildcards.Location = New System.Drawing.Point(202, 15)
        Me.checkBoxCaseSensitiveWildcards.Name = "checkBoxCaseSensitiveWildcards"
        Me.checkBoxCaseSensitiveWildcards.Size = New System.Drawing.Size(141, 17)
        Me.checkBoxCaseSensitiveWildcards.TabIndex = 9
        Me.checkBoxCaseSensitiveWildcards.Text = "Case sensitive wildcards"
        Me.checkBoxCaseSensitiveWildcards.UseVisualStyleBackColor = True
        '
        'checkBoxBefore
        '
        Me.checkBoxBefore.AutoSize = True
        Me.checkBoxBefore.Enabled = False
        Me.checkBoxBefore.Location = New System.Drawing.Point(77, 98)
        Me.checkBoxBefore.Name = "checkBoxBefore"
        Me.checkBoxBefore.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.checkBoxBefore.Size = New System.Drawing.Size(56, 17)
        Me.checkBoxBefore.TabIndex = 5
        Me.checkBoxBefore.Text = "before"
        Me.checkBoxBefore.UseVisualStyleBackColor = True
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.checkBoxCaseSensitiveWildcards)
        Me.tabPage3.Controls.Add(Me.groupBox1)
        Me.tabPage3.Controls.Add(Me.checkBoxShowFolders)
        Me.tabPage3.Location = New System.Drawing.Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Size = New System.Drawing.Size(430, 127)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Advanced"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'checkBoxShowFolders
        '
        Me.checkBoxShowFolders.AutoSize = True
        Me.checkBoxShowFolders.Location = New System.Drawing.Point(14, 15)
        Me.checkBoxShowFolders.Name = "checkBoxShowFolders"
        Me.checkBoxShowFolders.Size = New System.Drawing.Size(182, 17)
        Me.checkBoxShowFolders.TabIndex = 7
        Me.checkBoxShowFolders.Text = "Also show folders in search result"
        Me.checkBoxShowFolders.UseVisualStyleBackColor = True
        '
        'dateTimePicker2
        '
        Me.dateTimePicker2.Enabled = False
        Me.dateTimePicker2.Location = New System.Drawing.Point(139, 94)
        Me.dateTimePicker2.Name = "dateTimePicker2"
        Me.dateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.dateTimePicker2.TabIndex = 4
        '
        'SearchProgressBar
        '
        Me.SearchProgressBar.Location = New System.Drawing.Point(444, 89)
        Me.SearchProgressBar.Name = "SearchProgressBar"
        Me.SearchProgressBar.Size = New System.Drawing.Size(107, 16)
        Me.SearchProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.SearchProgressBar.TabIndex = 3
        Me.SearchProgressBar.Visible = False
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.SearchProgressBar)
        Me.panel1.Controls.Add(Me.buttStopSearch)
        Me.panel1.Controls.Add(Me.tabControl1)
        Me.panel1.Controls.Add(Me.buttStartSearch)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(733, 164)
        Me.panel1.TabIndex = 3
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Location = New System.Drawing.Point(0, 9)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(438, 153)
        Me.tabControl1.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.label2)
        Me.tabPage1.Controls.Add(Me.label1)
        Me.tabPage1.Controls.Add(Me.checkBoxRecursive)
        Me.tabPage1.Controls.Add(Me.buttonBrowse)
        Me.tabPage1.Controls.Add(Me.shellComboBox1)
        Me.tabPage1.Controls.Add(Me.textBoxSearchPattern)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(430, 127)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Name / Location"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(8, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 13)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Look in:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Name:"
        '
        'checkBoxRecursive
        '
        Me.checkBoxRecursive.AutoSize = True
        Me.checkBoxRecursive.Checked = True
        Me.checkBoxRecursive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxRecursive.Location = New System.Drawing.Point(59, 82)
        Me.checkBoxRecursive.Name = "checkBoxRecursive"
        Me.checkBoxRecursive.Size = New System.Drawing.Size(158, 17)
        Me.checkBoxRecursive.TabIndex = 3
        Me.checkBoxRecursive.Text = "Include subfolders in search"
        Me.checkBoxRecursive.UseVisualStyleBackColor = True
        '
        'buttonBrowse
        '
        Me.buttonBrowse.Location = New System.Drawing.Point(327, 53)
        Me.buttonBrowse.Name = "buttonBrowse"
        Me.buttonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.buttonBrowse.TabIndex = 2
        Me.buttonBrowse.Text = "Browse.."
        Me.buttonBrowse.UseVisualStyleBackColor = True
        '
        'shellComboBox1
        '
        Me.shellComboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.shellComboBox1.FormattingEnabled = True
        Me.shellComboBox1.Location = New System.Drawing.Point(59, 54)
        Me.shellComboBox1.Name = "shellComboBox1"
        Me.shellComboBox1.ShellControlConnector = Me.shellControlConnector1
        Me.shellComboBox1.Size = New System.Drawing.Size(262, 22)
        Me.shellComboBox1.TabIndex = 1
        '
        'shellControlConnector1
        '
        Me.shellControlConnector1.Enabled = True
        '
        'textBoxSearchPattern
        '
        Me.textBoxSearchPattern.Location = New System.Drawing.Point(59, 29)
        Me.textBoxSearchPattern.Name = "textBoxSearchPattern"
        Me.textBoxSearchPattern.Size = New System.Drawing.Size(343, 20)
        Me.textBoxSearchPattern.TabIndex = 0
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.dateTimePicker1)
        Me.tabPage2.Controls.Add(Me.checkBoxBefore)
        Me.tabPage2.Controls.Add(Me.dateTimePicker2)
        Me.tabPage2.Controls.Add(Me.checkBoxAfter)
        Me.tabPage2.Controls.Add(Me.comboSelectAccess)
        Me.tabPage2.Controls.Add(Me.radioButtonFindSpecificallyAccessedFiles)
        Me.tabPage2.Controls.Add(Me.radioButtonAllFiles)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(430, 127)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Date"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.Enabled = False
        Me.dateTimePicker1.Location = New System.Drawing.Point(139, 72)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.dateTimePicker1.TabIndex = 6
        '
        'checkBoxAfter
        '
        Me.checkBoxAfter.AutoSize = True
        Me.checkBoxAfter.Enabled = False
        Me.checkBoxAfter.Location = New System.Drawing.Point(86, 75)
        Me.checkBoxAfter.Name = "checkBoxAfter"
        Me.checkBoxAfter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.checkBoxAfter.Size = New System.Drawing.Size(47, 17)
        Me.checkBoxAfter.TabIndex = 3
        Me.checkBoxAfter.Text = "after"
        Me.checkBoxAfter.UseVisualStyleBackColor = True
        '
        'comboSelectAccess
        '
        Me.comboSelectAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSelectAccess.Enabled = False
        Me.comboSelectAccess.FormattingEnabled = True
        Me.comboSelectAccess.Items.AddRange(New Object() {"modified", "accessed", "created"})
        Me.comboSelectAccess.Location = New System.Drawing.Point(77, 48)
        Me.comboSelectAccess.Name = "comboSelectAccess"
        Me.comboSelectAccess.Size = New System.Drawing.Size(121, 21)
        Me.comboSelectAccess.TabIndex = 2
        '
        'radioButtonFindSpecificallyAccessedFiles
        '
        Me.radioButtonFindSpecificallyAccessedFiles.AutoSize = True
        Me.radioButtonFindSpecificallyAccessedFiles.Location = New System.Drawing.Point(8, 49)
        Me.radioButtonFindSpecificallyAccessedFiles.Name = "radioButtonFindSpecificallyAccessedFiles"
        Me.radioButtonFindSpecificallyAccessedFiles.Size = New System.Drawing.Size(66, 17)
        Me.radioButtonFindSpecificallyAccessedFiles.TabIndex = 1
        Me.radioButtonFindSpecificallyAccessedFiles.Text = "Find files"
        Me.radioButtonFindSpecificallyAccessedFiles.UseVisualStyleBackColor = True
        '
        'radioButtonAllFiles
        '
        Me.radioButtonAllFiles.AutoSize = True
        Me.radioButtonAllFiles.Checked = True
        Me.radioButtonAllFiles.Location = New System.Drawing.Point(8, 26)
        Me.radioButtonAllFiles.Name = "radioButtonAllFiles"
        Me.radioButtonAllFiles.Size = New System.Drawing.Size(57, 17)
        Me.radioButtonAllFiles.TabIndex = 0
        Me.radioButtonAllFiles.TabStop = True
        Me.radioButtonAllFiles.Text = "All files"
        Me.radioButtonAllFiles.UseVisualStyleBackColor = True
        '
        'buttStartSearch
        '
        Me.buttStartSearch.Location = New System.Drawing.Point(444, 31)
        Me.buttStartSearch.Name = "buttStartSearch"
        Me.buttStartSearch.Size = New System.Drawing.Size(107, 23)
        Me.buttStartSearch.TabIndex = 1
        Me.buttStartSearch.Text = "Find now"
        Me.buttStartSearch.UseVisualStyleBackColor = True
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.searchResults, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(739, 396)
        Me.tableLayoutPanel1.TabIndex = 7
        '
        'searchResults
        '
        Me.searchResults.BackColor = System.Drawing.SystemColors.Window
        Me.searchResults.CheckIfExists = False
        Me.searchResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchResults.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchResults.Location = New System.Drawing.Point(3, 173)
        Me.searchResults.Name = "searchResults"
        Me.searchResults.ShowColorCompressed = System.Drawing.Color.Empty
        Me.searchResults.ShowColorEncrypted = System.Drawing.Color.Empty
        Me.searchResults.ShowErrorMessages = False
        Me.searchResults.Size = New System.Drawing.Size(733, 220)
        Me.searchResults.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.searchResults.TabIndex = 0
        Me.searchResults.ThumbnailBorderColor = System.Drawing.Color.LightGray
        Me.searchResults.ThumbnailSize = New System.Drawing.Size(96, 96)
        Me.searchResults.UseCompatibleStateImageBehavior = False
        Me.searchResults.UseThreadPool = True
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'toolStripStatusSizeAndCount
        '
        Me.toolStripStatusSizeAndCount.Name = "toolStripStatusSizeAndCount"
        Me.toolStripStatusSizeAndCount.Size = New System.Drawing.Size(0, 17)
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusSizeAndCount, Me.toolStripStatusLabel1})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 396)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(739, 22)
        Me.statusStrip1.TabIndex = 6
        Me.statusStrip1.Text = "statusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 418)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Name = "Form1"
        Me.Text = "JamSearch VB"
		Me.DoubleBuffered = true
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.numericNoLessThan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericNotGreaterThan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage3.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        CType(Me.shellComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.tableLayoutPanel1.ResumeLayout(False)
        CType(Me.searchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents numericNoLessThan As System.Windows.Forms.NumericUpDown
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents numericNotGreaterThan As System.Windows.Forms.NumericUpDown
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents checkBoxNoLessThanKiB As System.Windows.Forms.CheckBox
    Private WithEvents checkBoxNoMoreThanKiB As System.Windows.Forms.CheckBox
    Private WithEvents buttStopSearch As System.Windows.Forms.Button
    Private WithEvents checkBoxCaseSensitiveWildcards As System.Windows.Forms.CheckBox
    Private WithEvents checkBoxBefore As System.Windows.Forms.CheckBox
    Private WithEvents tabPage3 As System.Windows.Forms.TabPage
    Private WithEvents checkBoxShowFolders As System.Windows.Forms.CheckBox
    Private WithEvents dateTimePicker2 As System.Windows.Forms.DateTimePicker
    Private WithEvents SearchProgressBar As System.Windows.Forms.ProgressBar
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents checkBoxRecursive As System.Windows.Forms.CheckBox
    Private WithEvents buttonBrowse As System.Windows.Forms.Button
    Private WithEvents shellComboBox1 As Jam.Shell.ShellComboBox
    Private WithEvents shellControlConnector1 As Jam.Shell.ShellControlConnector
    Private WithEvents textBoxSearchPattern As System.Windows.Forms.TextBox
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents dateTimePicker1 As System.Windows.Forms.DateTimePicker
    Private WithEvents checkBoxAfter As System.Windows.Forms.CheckBox
    Private WithEvents comboSelectAccess As System.Windows.Forms.ComboBox
    Private WithEvents radioButtonFindSpecificallyAccessedFiles As System.Windows.Forms.RadioButton
    Private WithEvents radioButtonAllFiles As System.Windows.Forms.RadioButton
    Private WithEvents buttStartSearch As System.Windows.Forms.Button
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents searchResults As Jam.Shell.FileList
    Private WithEvents toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents toolStripStatusSizeAndCount As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip

End Class
