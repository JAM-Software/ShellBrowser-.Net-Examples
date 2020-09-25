namespace JamCommander
{
    partial class FileListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileListForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FileList = new Jam.Shell.FileList();
            this.shellControlConnector1 = new Jam.Shell.ShellControlConnector();
            this.shellFilePreview1 = new Jam.Shell.ShellFilePreview();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellFilePreview1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.FileList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.shellFilePreview1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1880, 762);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FileList
            // 
            this.FileList.AutoSizeColumn = -1;
            this.FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileList.Location = new System.Drawing.Point(3, 3);
            this.FileList.Name = "FileList";
            this.FileList.SearchOptions.AccessInterval = null;
            this.FileList.SearchOptions.CreationInterval = null;
            this.FileList.SearchOptions.Filter = "";
            this.FileList.SearchOptions.FilterRegex = null;
            this.FileList.SearchOptions.LastWriteInterval = null;
            this.FileList.SearchOptions.MaxFileSize = ((long)(9223372036854775807));
            this.FileList.SearchOptions.MinFileSize = ((long)(0));
            this.FileList.SearchOptions.RecursiveSearch = true;
            this.FileList.SearchOptions.RegexPattern = "";
            this.FileList.ShellControlConnector = this.shellControlConnector1;
            this.FileList.ShowColorCompressed = System.Drawing.Color.Empty;
            this.FileList.ShowColorEncrypted = System.Drawing.Color.Empty;
            this.FileList.Size = new System.Drawing.Size(1247, 756);
            this.FileList.TabIndex = 0;
            this.FileList.ThumbnailBorderColor = System.Drawing.Color.LightGray;
            this.FileList.ThumbnailSize = new System.Drawing.Size(96, 96);
            this.FileList.UseCompatibleStateImageBehavior = false;
            // 
            // shellControlConnector1
            // 
            this.shellControlConnector1.Enabled = true;
            // 
            // shellFilePreview1
            // 
            this.shellFilePreview1.DisplayMsg = "shellFilePreview1";
            this.shellFilePreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellFilePreview1.ItemIdList = null;
            this.shellFilePreview1.Location = new System.Drawing.Point(1256, 3);
            this.shellFilePreview1.Name = "shellFilePreview1";
            this.shellFilePreview1.Path = null;
            this.shellFilePreview1.SelectFileMessage = "";
            this.shellFilePreview1.ShellControlConnector = this.shellControlConnector1;
            this.shellFilePreview1.Size = new System.Drawing.Size(621, 756);
            this.shellFilePreview1.TabIndex = 1;
            this.shellFilePreview1.Text = "shellFilePreview1";
            // 
            // FileListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1880, 762);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileListForm";
            this.Text = "FileListForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellFilePreview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public Jam.Shell.FileList FileList;
        private Jam.Shell.ShellFilePreview shellFilePreview1;
        private Jam.Shell.ShellControlConnector shellControlConnector1;
    }
}