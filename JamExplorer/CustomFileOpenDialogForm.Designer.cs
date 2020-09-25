namespace Jam.Explorer
{
    partial class CustomFileOpenDialogForm
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
            this.shellBrowser1 = new Jam.Shell.ShellBrowser();
            this.shellListView1 = new Jam.Shell.ShellListView();
            this.shellAddressBar1 = new Jam.Shell.ShellAddressBar();
            this.shellTreeView1 = new Jam.Shell.ShellTreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.filterComboBox1 = new Jam.Shell.Controls.FilterComboBox();
            this.recentlyUsedComboBox1 = new Jam.Shell.Controls.RecentlyUsedComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.shellControlConnector1 = new Jam.Shell.ShellControlConnector();
            ((System.ComponentModel.ISupportInitialize)(this.shellListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellAddressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellTreeView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shellBrowser1
            // 
            this.shellBrowser1.Folder = "";
            this.shellBrowser1.FullPath = "";
            this.shellBrowser1.ObjectName = "";
            this.shellBrowser1.ShowErrorMessages = false;
            this.shellBrowser1.SpecialFolder = Jam.Shell.ShellFolder.Drives;
            this.shellBrowser1.SpecialObject = Jam.Shell.ShellFolder.Unknown;
            // 
            // shellListView1
            // 
            this.shellListView1.AutoSizeColumn = -1;
            this.shellListView1.Filter = "";
            this.shellListView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shellListView1.Location = new System.Drawing.Point(193, 36);
            this.shellListView1.Name = "shellListView1";
            this.shellListView1.Path = "";
            this.shellListView1.ShellControlConnector = this.shellControlConnector1;
            this.shellListView1.ShowColorCompressed = System.Drawing.Color.Empty;
            this.shellListView1.ShowColorEncrypted = System.Drawing.Color.Empty;
            this.shellListView1.Size = new System.Drawing.Size(724, 397);
            this.shellListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.shellListView1.TabIndex = 0;
            this.shellListView1.ThumbnailBorderColor = System.Drawing.Color.LightGray;
            this.shellListView1.ThumbnailSize = new System.Drawing.Size(96, 96);
            this.shellListView1.UseCompatibleStateImageBehavior = false;
            // 
            // shellAddressBar1
            // 
            this.shellAddressBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shellAddressBar1.Location = new System.Drawing.Point(0, 0);
            this.shellAddressBar1.Name = "shellAddressBar1";
            this.shellAddressBar1.RootedAtFileSystemFolder = "Desktop";
            this.shellAddressBar1.Size = new System.Drawing.Size(929, 30);
            this.shellAddressBar1.TabIndex = 1;
            this.shellAddressBar1.UseSystemFont = false;
            // 
            // shellTreeView1
            // 
            this.shellTreeView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shellTreeView1.ItemHeight = 24;
            this.shellTreeView1.Location = new System.Drawing.Point(12, 36);
            this.shellTreeView1.Name = "shellTreeView1";
            this.shellTreeView1.RootedAt = Jam.Shell.ShellFolder.Unknown;
            this.shellTreeView1.RootedAtFileSystemFolder = "";
            this.shellTreeView1.SelectedPath = "";
            this.shellTreeView1.ShellControlConnector = this.shellControlConnector1;
            this.shellTreeView1.ShowColorCompressed = System.Drawing.Color.Empty;
            this.shellTreeView1.ShowColorEncrypted = System.Drawing.Color.Empty;
            this.shellTreeView1.ShowRootLines = true;
            this.shellTreeView1.Size = new System.Drawing.Size(175, 397);
            this.shellTreeView1.SpecialFolder = Jam.Shell.ShellFolder.Drives;
            this.shellTreeView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.filterComboBox1);
            this.panel1.Controls.Add(this.recentlyUsedComboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 84);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(830, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterComboBox1
            // 
            this.filterComboBox1.Filter = null;
            this.filterComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterComboBox1.FormattingEnabled = true;
            this.filterComboBox1.Items.AddRange(new object[] {
            "All files(*.*)",
            "Batch files(*.bat;*.cmd;*.nt)",
            "HTML files(*.html;*.htm;*.shtml;*.shtm;*.xhtml;*.xht;*.hta)",
            "Image files(*.jpe;*.jpeg;*.png;*.gif;*.bmp)",
            "Jason files(*.json)",
            "OpenDocument-text(*.odt)",
            "PDF(*.pdf)",
            "Rich-Text-Format(*.rtf)",
            "Text file(*.txt)",
            "Word files(*.docx)",
            "All Word files(*.docx;*.docm;*.dotx;*.dotm;*.dot;*.doc;*.htm;*.html;*.rtf;*.mht;*" +
                ".mhtml;*.xml;*.odt;*.pdf)",
            "XML files(*.xml)",
            "html (*.htm;*.html;*.ht)"});
            this.filterComboBox1.Location = new System.Drawing.Point(736, 3);
            this.filterComboBox1.Name = "filterComboBox1";
            this.filterComboBox1.Size = new System.Drawing.Size(169, 23);
            this.filterComboBox1.TabIndex = 1;
            this.filterComboBox1.UseSystemFont = false;
            this.filterComboBox1.SelectedIndexChanged += new System.EventHandler(this.filterComboBox1_SelectedIndexChanged);
            // 
            // recentlyUsedComboBox1
            // 
            this.recentlyUsedComboBox1.Filter = "*;";
            this.recentlyUsedComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.recentlyUsedComboBox1.FormattingEnabled = true;
            this.recentlyUsedComboBox1.Items.AddRange(new object[] {
            "\\\\MIRA",
            "C:\\Users\\lorenz\\Pictures\\delphi.PNG",
            "D:\\Projects\\TreeSizeTrunk\\DelphiLib",
            "C:\\Windows\\System32\\Ranorex.ReportViewer.exe",
            "D:\\ReportViewer\\Ranorex.ReportViewer.exe",
            "D:\\Projects\\TreeSizeTrunk",
            "C:\\Users\\lorenz\\Pictures\\watchlist.PNG",
            "D:\\testfile",
            "C:\\Users\\lorenz\\Documents\\testpermission",
            "D:\\Projects\\TreeSizeTrunk\\TreeSizeGroup.groupproj",
            "C:\\",
            "D:\\Projects\\HeavyLoadClean\\Heavyload.dproj",
            "D:\\Projects\\Test",
            "D:\\Projects",
            "D:\\Projects\\TreeSizeTrunk\\DelphiLib\\Jam.ServiceLocator.pas",
            "C:\\Program Files (x86)\\Embarcadero\\Studio\\20.0\\unins000.exe",
            "D:\\Projects\\HeavyLoadRelease\\Heavyload.dproj",
            "D:\\Projects\\HeavyLoad\\Heavyload.dproj",
            "C:\\Users\\lorenz\\Pictures\\JiraWatchlist.PNG",
            "D:\\Projects\\HeavyLoad"});
            this.recentlyUsedComboBox1.Location = new System.Drawing.Point(181, 3);
            this.recentlyUsedComboBox1.Name = "recentlyUsedComboBox1";
            this.recentlyUsedComboBox1.Size = new System.Drawing.Size(549, 23);
            this.recentlyUsedComboBox1.TabIndex = 0;
            this.recentlyUsedComboBox1.UseSystemFont = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // shellControlConnector1
            // 
            this.shellControlConnector1.Enabled = true;
            // 
            // CustomFileOpenDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shellTreeView1);
            this.Controls.Add(this.shellAddressBar1);
            this.Controls.Add(this.shellListView1);
            this.Name = "CustomFileOpenDialogForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shellListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellAddressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellTreeView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shell.ShellBrowser shellBrowser1;
        private Shell.ShellListView shellListView1;
        private Shell.ShellAddressBar shellAddressBar1;
        private Shell.ShellTreeView shellTreeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Shell.Controls.FilterComboBox filterComboBox1;
        private Shell.Controls.RecentlyUsedComboBox recentlyUsedComboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Shell.ShellControlConnector shellControlConnector1;
    }
}