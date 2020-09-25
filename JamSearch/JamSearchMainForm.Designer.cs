namespace JamSearch
{
    partial class JamSearchMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JamSearchMainForm));
            this.buttStopSearch = new System.Windows.Forms.Button();
            this.buttStartSearch = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSizeAndCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRecursive = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.shellComboBox1 = new Jam.Shell.ShellComboBox();
            this.shellControlConnector1 = new Jam.Shell.ShellControlConnector();
            this.textBoxSearchPattern = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxBefore = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxAfter = new System.Windows.Forms.CheckBox();
            this.comboSelectAccess = new System.Windows.Forms.ComboBox();
            this.radioButtonFindSpecificallyAccessedFiles = new System.Windows.Forms.RadioButton();
            this.radioButtonAllFiles = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxCaseSensitiveWildcards = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericNoLessThan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericNotGreaterThan = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxNoLessThanKiB = new System.Windows.Forms.CheckBox();
            this.checkBoxNoMoreThanKiB = new System.Windows.Forms.CheckBox();
            this.checkBoxShowFolders = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchResults = new Jam.Shell.FileList();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shellComboBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoLessThan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNotGreaterThan)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // buttStopSearch
            // 
            this.buttStopSearch.Enabled = false;
            this.buttStopSearch.Location = new System.Drawing.Point(444, 60);
            this.buttStopSearch.Name = "buttStopSearch";
            this.buttStopSearch.Size = new System.Drawing.Size(107, 23);
            this.buttStopSearch.TabIndex = 2;
            this.buttStopSearch.Text = "Cancel";
            this.buttStopSearch.UseVisualStyleBackColor = true;
            this.buttStopSearch.Click += new System.EventHandler(this.buttStopSearch_Click);
            // 
            // buttStartSearch
            // 
            this.buttStartSearch.Location = new System.Drawing.Point(444, 31);
            this.buttStartSearch.Name = "buttStartSearch";
            this.buttStartSearch.Size = new System.Drawing.Size(107, 23);
            this.buttStartSearch.TabIndex = 1;
            this.buttStartSearch.Text = "Find now";
            this.buttStartSearch.UseVisualStyleBackColor = true;
            this.buttStartSearch.Click += new System.EventHandler(this.buttStartSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSizeAndCount,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 376);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(693, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusSizeAndCount
            // 
            this.toolStripStatusSizeAndCount.Name = "toolStripStatusSizeAndCount";
            this.toolStripStatusSizeAndCount.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 153);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBoxRecursive);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.shellComboBox1);
            this.tabPage1.Controls.Add(this.textBoxSearchPattern);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Name / Location";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Look in:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // checkBoxRecursive
            // 
            this.checkBoxRecursive.AutoSize = true;
            this.checkBoxRecursive.Checked = true;
            this.checkBoxRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRecursive.Location = new System.Drawing.Point(59, 82);
            this.checkBoxRecursive.Name = "checkBoxRecursive";
            this.checkBoxRecursive.Size = new System.Drawing.Size(158, 17);
            this.checkBoxRecursive.TabIndex = 3;
            this.checkBoxRecursive.Text = "Include subfolders in search";
            this.checkBoxRecursive.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Browse..";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttBrowse_Click);
            // 
            // shellComboBox1
            // 
            this.shellComboBox1.FileSystemOnly = true;
            this.shellComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shellComboBox1.FormattingEnabled = true;
            this.shellComboBox1.Location = new System.Drawing.Point(59, 54);
            this.shellComboBox1.Name = "shellComboBox1";
            this.shellComboBox1.SelectedPath = "C:\\";
            this.shellComboBox1.ShellAutoCompletionMode = ((Jam.Shell.ShellAutoComplete)((Jam.Shell.ShellAutoComplete.FileSystem | Jam.Shell.ShellAutoComplete.Url)));
            this.shellComboBox1.ShellControlConnector = this.shellControlConnector1;
            this.shellComboBox1.ShowRecycleBin = false;
            this.shellComboBox1.Size = new System.Drawing.Size(262, 24);
            this.shellComboBox1.TabIndex = 1;
            // 
            // shellControlConnector1
            // 
            this.shellControlConnector1.Enabled = true;
            // 
            // textBoxSearchPattern
            // 
            this.textBoxSearchPattern.Location = new System.Drawing.Point(59, 29);
            this.textBoxSearchPattern.Name = "textBoxSearchPattern";
            this.textBoxSearchPattern.Size = new System.Drawing.Size(343, 20);
            this.textBoxSearchPattern.TabIndex = 0;
            this.textBoxSearchPattern.Text = "*.txt";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.checkBoxBefore);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.checkBoxAfter);
            this.tabPage2.Controls.Add(this.comboSelectAccess);
            this.tabPage2.Controls.Add(this.radioButtonFindSpecificallyAccessedFiles);
            this.tabPage2.Controls.Add(this.radioButtonAllFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(430, 127);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Date";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // checkBoxBefore
            // 
            this.checkBoxBefore.AutoSize = true;
            this.checkBoxBefore.Enabled = false;
            this.checkBoxBefore.Location = new System.Drawing.Point(77, 98);
            this.checkBoxBefore.Name = "checkBoxBefore";
            this.checkBoxBefore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxBefore.Size = new System.Drawing.Size(56, 17);
            this.checkBoxBefore.TabIndex = 5;
            this.checkBoxBefore.Text = "before";
            this.checkBoxBefore.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(139, 94);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // checkBoxAfter
            // 
            this.checkBoxAfter.AutoSize = true;
            this.checkBoxAfter.Enabled = false;
            this.checkBoxAfter.Location = new System.Drawing.Point(86, 75);
            this.checkBoxAfter.Name = "checkBoxAfter";
            this.checkBoxAfter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAfter.Size = new System.Drawing.Size(47, 17);
            this.checkBoxAfter.TabIndex = 3;
            this.checkBoxAfter.Text = "after";
            this.checkBoxAfter.UseVisualStyleBackColor = true;
            // 
            // comboSelectAccess
            // 
            this.comboSelectAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectAccess.Enabled = false;
            this.comboSelectAccess.FormattingEnabled = true;
            this.comboSelectAccess.Items.AddRange(new object[] {
            "modified",
            "accessed",
            "created"});
            this.comboSelectAccess.Location = new System.Drawing.Point(77, 48);
            this.comboSelectAccess.Name = "comboSelectAccess";
            this.comboSelectAccess.Size = new System.Drawing.Size(121, 21);
            this.comboSelectAccess.TabIndex = 2;
            // 
            // radioButtonFindSpecificallyAccessedFiles
            // 
            this.radioButtonFindSpecificallyAccessedFiles.AutoSize = true;
            this.radioButtonFindSpecificallyAccessedFiles.Location = new System.Drawing.Point(8, 49);
            this.radioButtonFindSpecificallyAccessedFiles.Name = "radioButtonFindSpecificallyAccessedFiles";
            this.radioButtonFindSpecificallyAccessedFiles.Size = new System.Drawing.Size(66, 17);
            this.radioButtonFindSpecificallyAccessedFiles.TabIndex = 1;
            this.radioButtonFindSpecificallyAccessedFiles.Text = "Find files";
            this.radioButtonFindSpecificallyAccessedFiles.UseVisualStyleBackColor = true;
            this.radioButtonFindSpecificallyAccessedFiles.CheckedChanged += new System.EventHandler(this.radioButtonFindSpecificallyAccessedFiles_CheckedChanged);
            // 
            // radioButtonAllFiles
            // 
            this.radioButtonAllFiles.AutoSize = true;
            this.radioButtonAllFiles.Checked = true;
            this.radioButtonAllFiles.Location = new System.Drawing.Point(8, 26);
            this.radioButtonAllFiles.Name = "radioButtonAllFiles";
            this.radioButtonAllFiles.Size = new System.Drawing.Size(57, 17);
            this.radioButtonAllFiles.TabIndex = 0;
            this.radioButtonAllFiles.TabStop = true;
            this.radioButtonAllFiles.Text = "All files";
            this.radioButtonAllFiles.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxCaseSensitiveWildcards);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.checkBoxShowFolders);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(430, 127);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Advanced";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaseSensitiveWildcards
            // 
            this.checkBoxCaseSensitiveWildcards.AutoSize = true;
            this.checkBoxCaseSensitiveWildcards.Location = new System.Drawing.Point(202, 15);
            this.checkBoxCaseSensitiveWildcards.Name = "checkBoxCaseSensitiveWildcards";
            this.checkBoxCaseSensitiveWildcards.Size = new System.Drawing.Size(129, 17);
            this.checkBoxCaseSensitiveWildcards.TabIndex = 9;
            this.checkBoxCaseSensitiveWildcards.Text = "Case sensitive search";
            this.checkBoxCaseSensitiveWildcards.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericNoLessThan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericNotGreaterThan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxNoLessThanKiB);
            this.groupBox1.Controls.Add(this.checkBoxNoMoreThanKiB);
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size restrictions";
            // 
            // numericNoLessThan
            // 
            this.numericNoLessThan.Enabled = false;
            this.numericNoLessThan.Location = new System.Drawing.Point(181, 16);
            this.numericNoLessThan.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericNoLessThan.Name = "numericNoLessThan";
            this.numericNoLessThan.Size = new System.Drawing.Size(120, 20);
            this.numericNoLessThan.TabIndex = 1;
            this.numericNoLessThan.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "KB";
            // 
            // numericNotGreaterThan
            // 
            this.numericNotGreaterThan.Enabled = false;
            this.numericNotGreaterThan.Location = new System.Drawing.Point(181, 42);
            this.numericNotGreaterThan.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericNotGreaterThan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNotGreaterThan.Name = "numericNotGreaterThan";
            this.numericNotGreaterThan.Size = new System.Drawing.Size(120, 20);
            this.numericNotGreaterThan.TabIndex = 2;
            this.numericNotGreaterThan.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "KB";
            // 
            // checkBoxNoLessThanKiB
            // 
            this.checkBoxNoLessThanKiB.AutoSize = true;
            this.checkBoxNoLessThanKiB.Location = new System.Drawing.Point(74, 19);
            this.checkBoxNoLessThanKiB.Name = "checkBoxNoLessThanKiB";
            this.checkBoxNoLessThanKiB.Size = new System.Drawing.Size(85, 17);
            this.checkBoxNoLessThanKiB.TabIndex = 3;
            this.checkBoxNoLessThanKiB.Text = "No less than";
            this.checkBoxNoLessThanKiB.UseVisualStyleBackColor = true;
            this.checkBoxNoLessThanKiB.CheckedChanged += new System.EventHandler(this.checkBoxKiB_CheckedChanged);
            // 
            // checkBoxNoMoreThanKiB
            // 
            this.checkBoxNoMoreThanKiB.AutoSize = true;
            this.checkBoxNoMoreThanKiB.Location = new System.Drawing.Point(74, 45);
            this.checkBoxNoMoreThanKiB.Name = "checkBoxNoMoreThanKiB";
            this.checkBoxNoMoreThanKiB.Size = new System.Drawing.Size(103, 17);
            this.checkBoxNoMoreThanKiB.TabIndex = 4;
            this.checkBoxNoMoreThanKiB.Text = "Not greater than";
            this.checkBoxNoMoreThanKiB.UseVisualStyleBackColor = true;
            this.checkBoxNoMoreThanKiB.CheckedChanged += new System.EventHandler(this.checkBoxKiB_CheckedChanged);
            // 
            // checkBoxShowFolders
            // 
            this.checkBoxShowFolders.AutoSize = true;
            this.checkBoxShowFolders.Checked = true;
            this.checkBoxShowFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowFolders.Location = new System.Drawing.Point(14, 15);
            this.checkBoxShowFolders.Name = "checkBoxShowFolders";
            this.checkBoxShowFolders.Size = new System.Drawing.Size(182, 17);
            this.checkBoxShowFolders.TabIndex = 7;
            this.checkBoxShowFolders.Text = "Also show folders in search result";
            this.checkBoxShowFolders.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchProgressBar);
            this.panel1.Controls.Add(this.buttStopSearch);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.buttStartSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 164);
            this.panel1.TabIndex = 3;
            // 
            // SearchProgressBar
            // 
            this.SearchProgressBar.Location = new System.Drawing.Point(444, 89);
            this.SearchProgressBar.Name = "SearchProgressBar";
            this.SearchProgressBar.Size = new System.Drawing.Size(107, 16);
            this.SearchProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.SearchProgressBar.TabIndex = 3;
            this.SearchProgressBar.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.searchResults, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 376);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // searchResults
            // 
            this.searchResults.AutoSizeColumn = -1;
            this.searchResults.BackColor = System.Drawing.SystemColors.Window;
            this.searchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResults.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.searchResults.FullRowSelect = true;
            this.searchResults.Location = new System.Drawing.Point(3, 173);
            this.searchResults.Name = "searchResults";
            this.searchResults.SearchOptions.AccessInterval = null;
            this.searchResults.SearchOptions.CreationInterval = null;
            this.searchResults.SearchOptions.Filter = "";
            this.searchResults.SearchOptions.FilterRegex = null;
            this.searchResults.SearchOptions.LastWriteInterval = null;
            this.searchResults.SearchOptions.MaxFileSize = ((long)(9223372036854775807));
            this.searchResults.SearchOptions.MinFileSize = ((long)(0));
            this.searchResults.SearchOptions.RecursiveSearch = true;
            this.searchResults.SearchOptions.RegexPattern = "";
            this.searchResults.ShowColorCompressed = System.Drawing.Color.Empty;
            this.searchResults.ShowColorEncrypted = System.Drawing.Color.Empty;
            this.searchResults.Size = new System.Drawing.Size(687, 200);
            this.searchResults.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.searchResults.TabIndex = 0;
            this.searchResults.ThumbnailBorderColor = System.Drawing.Color.LightGray;
            this.searchResults.ThumbnailSize = new System.Drawing.Size(96, 96);
            this.searchResults.UseCompatibleStateImageBehavior = false;
            this.searchResults.UseSystemFont = false;
            this.searchResults.SearchFileMatches += new System.EventHandler<Jam.Shell.FileMatchEventArgs>(this.searchResults_SearchFileMatches);
            this.searchResults.SearchCompleted += new System.EventHandler<Jam.Shell.SearchCompletedEventArgs>(this.searchResults_SearchCompleted);
            this.searchResults.SearchProgressChanged += new System.EventHandler<Jam.Shell.SearchProgressChangedEventArgs>(this.searchResults_SearchProgressChanged);
            this.searchResults.SearchExceptionOccurred += new System.EventHandler<Jam.Shell.SearchExceptionEventArgs>(this.searchResults_SearchExceptionOccurred);
            this.searchResults.ItemListChanged += new System.EventHandler<System.EventArgs>(this.searchResults_ItemListChanged);
            // 
            // JamSearchMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 398);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 427);
            this.Name = "JamSearchMainForm";
            this.Text = "JamSearch";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shellComboBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoLessThan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNotGreaterThan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttStopSearch;
        private System.Windows.Forms.Button buttStartSearch;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Jam.Shell.ShellControlConnector shellControlConnector1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxRecursive;
        private System.Windows.Forms.Button button3;
        private Jam.Shell.ShellComboBox shellComboBox1;
        private System.Windows.Forms.TextBox textBoxSearchPattern;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxBefore;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBoxAfter;
        private System.Windows.Forms.ComboBox comboSelectAccess;
        private System.Windows.Forms.RadioButton radioButtonFindSpecificallyAccessedFiles;
        private System.Windows.Forms.RadioButton radioButtonAllFiles;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericNoLessThan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericNotGreaterThan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxNoLessThanKiB;
        private System.Windows.Forms.CheckBox checkBoxNoMoreThanKiB;
        private System.Windows.Forms.CheckBox checkBoxShowFolders;
        private System.Windows.Forms.Panel panel1;
        private Jam.Shell.FileList searchResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar SearchProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSizeAndCount;
        private System.Windows.Forms.CheckBox checkBoxCaseSensitiveWildcards;
    }
}

