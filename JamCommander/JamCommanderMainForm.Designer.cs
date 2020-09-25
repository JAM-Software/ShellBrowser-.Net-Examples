namespace JamCommander
{
    partial class JamCommanderMainForm
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

            if (previewForm != null)
                previewForm.Dispose();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JamCommanderMainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.thumbnailImage1 = new Jam.Shell.ThumbnailImage();
            this.buttonNewFolder = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImage1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 590);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.thumbnailImage1);
            this.flowLayoutPanel1.Controls.Add(this.buttonNewFolder);
            this.flowLayoutPanel1.Controls.Add(this.buttonPaste);
            this.flowLayoutPanel1.Controls.Add(this.buttonCopy);
            this.flowLayoutPanel1.Controls.Add(this.buttonCut);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(614, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(52, 590);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // thumbnailImage1
            // 
            this.thumbnailImage1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbnailImage1.IconsAsThumnbnails = true;
            this.thumbnailImage1.Location = new System.Drawing.Point(2, 2);
            this.thumbnailImage1.Margin = new System.Windows.Forms.Padding(2);
            this.thumbnailImage1.Name = "thumbnailImage1";
            this.thumbnailImage1.Path = "";
            this.thumbnailImage1.Size = new System.Drawing.Size(50, 52);
            this.thumbnailImage1.TabIndex = 0;
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNewFolder.BackgroundImage")));
            this.buttonNewFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewFolder.Location = new System.Drawing.Point(2, 82);
            this.buttonNewFolder.Margin = new System.Windows.Forms.Padding(2, 26, 2, 2);
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Size = new System.Drawing.Size(50, 52);
            this.buttonNewFolder.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonNewFolder, "New folder (F6)");
            this.buttonNewFolder.UseVisualStyleBackColor = true;
            this.buttonNewFolder.Click += new System.EventHandler(this.ButtonNewFolder_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPaste.BackgroundImage")));
            this.buttonPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPaste.Location = new System.Drawing.Point(2, 152);
            this.buttonPaste.Margin = new System.Windows.Forms.Padding(2, 16, 2, 2);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(50, 52);
            this.buttonPaste.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonPaste, "Paste (F3)");
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopy.BackgroundImage")));
            this.buttonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCopy.Location = new System.Drawing.Point(2, 211);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(50, 52);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = " ";
            this.toolTip1.SetToolTip(this.buttonCopy, "Copy (F4)");
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCut.BackgroundImage")));
            this.buttonCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCut.Location = new System.Drawing.Point(2, 270);
            this.buttonCut.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(50, 52);
            this.buttonCut.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonCut, "Cut (F5)");
            this.buttonCut.UseVisualStyleBackColor = true;
            this.buttonCut.Click += new System.EventHandler(this.ButtonCut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewWindowToolStripMenuItem,
            this.treeViewToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.windowsToolStripMenuItem.Text = "Windows";
            this.windowsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.windowsToolStripMenuItem_DropDownOpening);
            // 
            // previewWindowToolStripMenuItem
            // 
            this.previewWindowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("previewWindowToolStripMenuItem.Image")));
            this.previewWindowToolStripMenuItem.Name = "previewWindowToolStripMenuItem";
            this.previewWindowToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.previewWindowToolStripMenuItem.Text = "Preview Window";
            this.previewWindowToolStripMenuItem.Click += new System.EventHandler(this.PreviewWindowToolStripMenuItem_Click);
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("treeViewToolStripMenuItem.Image")));
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.treeViewToolStripMenuItem.Text = "Tree View";
            this.treeViewToolStripMenuItem.Click += new System.EventHandler(this.TreeViewToolStripMenuItem_Click);
            // 
            // JamCommanderMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 614);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JamCommanderMainForm";
            this.Text = "JamCommander";
            this.Load += new System.EventHandler(this.JamCommander_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImage1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Jam.Shell.ThumbnailImage thumbnailImage1;
        private System.Windows.Forms.Button buttonNewFolder;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeViewToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}