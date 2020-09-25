namespace Jam.Samples.Customization
{
    partial class CustomIcons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomIcons));
            this.panel1 = new System.Windows.Forms.Panel();
            this.shellListView1 = new Jam.Shell.ShellListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.shellControlConnector1 = new Jam.Shell.ShellControlConnector();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.shellTreeView1 = new Jam.Shell.ShellTreeView();
            this.shellAddressBar1 = new Jam.Shell.ShellAddressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shellListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellAddressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.shellListView1);
            this.panel1.Controls.Add(this.shellTreeView1);
            this.panel1.Controls.Add(this.shellAddressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 482);
            this.panel1.TabIndex = 1;
            // 
            // shellListView1
            // 
            this.shellListView1.AutoSizeColumn = -1;
            this.shellListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellListView1.Filter = "";
            this.shellListView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shellListView1.LargeCustomImages = this.imageListLarge;
            this.shellListView1.Location = new System.Drawing.Point(255, 30);
            this.shellListView1.Name = "shellListView1";
            this.shellListView1.Path = "";
            this.shellListView1.ShellControlConnector = this.shellControlConnector1;
            this.shellListView1.ShowColorCompressed = System.Drawing.Color.Empty;
            this.shellListView1.ShowColorEncrypted = System.Drawing.Color.Empty;
            this.shellListView1.ShowOverlayIcons = true;
            this.shellListView1.Size = new System.Drawing.Size(463, 452);
            this.shellListView1.SmallCustomImages = this.imageListSmall;
            this.shellListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.shellListView1.TabIndex = 0;
            this.shellListView1.ThumbnailBorderColor = System.Drawing.Color.Transparent;
            this.shellListView1.ThumbnailSize = new System.Drawing.Size(96, 96);
            this.shellListView1.UseCompatibleStateImageBehavior = false;
            this.shellListView1.AddItem += new System.EventHandler<Jam.Shell.AddItemEventArgs>(this.shellListView1_AddItem);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "document_text.png");
            // 
            // shellControlConnector1
            // 
            this.shellControlConnector1.Enabled = true;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "folder.png");
            this.imageListSmall.Images.SetKeyName(1, "folder_document.png");
            this.imageListSmall.Images.SetKeyName(2, "folder_music.png");
            this.imageListSmall.Images.SetKeyName(3, "folder_movie.png");
            this.imageListSmall.Images.SetKeyName(4, "folder_network.png");
            this.imageListSmall.Images.SetKeyName(5, "flower.png");
            this.imageListSmall.Images.SetKeyName(6, "user.png");
            this.imageListSmall.Images.SetKeyName(7, "desktop.png");
            this.imageListSmall.Images.SetKeyName(8, "monitor.png");
            this.imageListSmall.Images.SetKeyName(9, "document_text.png");
            // 
            // shellTreeView1
            // 
            this.shellTreeView1.CustomImages = this.imageListSmall;
            this.shellTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.shellTreeView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shellTreeView1.ItemHeight = 24;
            this.shellTreeView1.Location = new System.Drawing.Point(0, 30);
            this.shellTreeView1.Name = "shellTreeView1";
            this.shellTreeView1.RootedAt = Jam.Shell.ShellFolder.Unknown;
            this.shellTreeView1.RootedAtFileSystemFolder = "";
            this.shellTreeView1.SelectedPath = "";
            this.shellTreeView1.ShellControlConnector = this.shellControlConnector1;
            this.shellTreeView1.ShowColorCompressed = System.Drawing.Color.Empty;
            this.shellTreeView1.ShowColorEncrypted = System.Drawing.Color.Empty;
            this.shellTreeView1.ShowRootLines = true;
            this.shellTreeView1.Size = new System.Drawing.Size(255, 452);
            this.shellTreeView1.SpecialFolder = Jam.Shell.ShellFolder.Drives;
            this.shellTreeView1.TabIndex = 2;
            this.shellTreeView1.AddTreeNode += new System.EventHandler<Jam.Shell.AddTreeNodeEventArgs>(this.shellTreeView1_AddTreeNode);
            // 
            // shellAddressBar1
            // 
            this.shellAddressBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shellAddressBar1.Location = new System.Drawing.Point(0, 0);
            this.shellAddressBar1.Name = "shellAddressBar1";
            this.shellAddressBar1.RootedAtFileSystemFolder = "Desktop";
            this.shellAddressBar1.ShellControlConnector = this.shellControlConnector1;
            this.shellAddressBar1.Size = new System.Drawing.Size(718, 30);
            this.shellAddressBar1.TabIndex = 1;
            this.shellAddressBar1.UseSystemFont = false;
            // 
            // CustomIcons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomIcons";
            this.Size = new System.Drawing.Size(718, 482);
            this.Load += new System.EventHandler(this.CustomIcons_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shellListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellAddressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Shell.ShellListView shellListView1;
        private System.Windows.Forms.ImageList imageListLarge;
        private Shell.ShellControlConnector shellControlConnector1;
        private System.Windows.Forms.ImageList imageListSmall;
        private Shell.ShellTreeView shellTreeView1;
        private Shell.ShellAddressBar shellAddressBar1;
    }
}
