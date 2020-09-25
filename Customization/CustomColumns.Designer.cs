namespace Jam.Samples.Customization
{
    partial class CustomColumns
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.shellListView1 = new Jam.Shell.ShellListView();
            this.shellControlConnector1 = new Jam.Shell.ShellControlConnector();
            this.panelMain = new System.Windows.Forms.Panel();
            this.shellAddressBar1 = new Jam.Shell.ShellAddressBar();
            ((System.ComponentModel.ISupportInitialize)(this.shellListView1)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shellAddressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // shellListView1
            // 
            this.shellListView1.AutoSizeColumn = -1;
            this.shellListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellListView1.Filter = "";
            this.shellListView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shellListView1.Location = new System.Drawing.Point(0, 30);
            this.shellListView1.Name = "shellListView1";
            this.shellListView1.Path = "";
            this.shellListView1.ShellControlConnector = this.shellControlConnector1;
            this.shellListView1.ShowColorCompressed = System.Drawing.Color.Empty;
            this.shellListView1.ShowColorEncrypted = System.Drawing.Color.Empty;
            this.shellListView1.Size = new System.Drawing.Size(541, 377);
            this.shellListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.shellListView1.TabIndex = 3;
            this.shellListView1.ThumbnailBorderColor = System.Drawing.Color.Transparent;
            this.shellListView1.ThumbnailSize = new System.Drawing.Size(96, 96);
            this.shellListView1.UseCompatibleStateImageBehavior = false;
            this.shellListView1.AddItem += new System.EventHandler<Jam.Shell.AddItemEventArgs>(this.shellListView1_AddItem);
            this.shellListView1.CreatedColumns += new System.EventHandler(this.shellListView1_CreatedColumns);
            // 
            // shellControlConnector1
            // 
            this.shellControlConnector1.Enabled = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.shellListView1);
            this.panelMain.Controls.Add(this.shellAddressBar1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(541, 407);
            this.panelMain.TabIndex = 1;
            // 
            // shellAddressBar1
            // 
            this.shellAddressBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shellAddressBar1.Location = new System.Drawing.Point(0, 0);
            this.shellAddressBar1.Name = "shellAddressBar1";
            this.shellAddressBar1.RootedAtFileSystemFolder = "Desktop";
            this.shellAddressBar1.ShellControlConnector = this.shellControlConnector1;
            this.shellAddressBar1.Size = new System.Drawing.Size(541, 30);
            this.shellAddressBar1.TabIndex = 0;
            this.shellAddressBar1.UseSystemFont = false;
            // 
            // CustomColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "CustomColumns";
            this.Size = new System.Drawing.Size(541, 407);
            ((System.ComponentModel.ISupportInitialize)(this.shellListView1)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shellAddressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shell.ShellListView shellListView1;
        private Shell.ShellControlConnector shellControlConnector1;
        private System.Windows.Forms.Panel panelMain;
        private Shell.ShellAddressBar shellAddressBar1;
    }
}
