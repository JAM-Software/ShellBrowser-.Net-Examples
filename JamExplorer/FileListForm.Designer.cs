namespace Jam.Explorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileListForm));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonView = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolstripViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripViewThumbnails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripViewIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripViewLargeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripViewTile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripViewExtraLargeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.fileList1 = new Jam.Shell.FileList();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total size: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonView
            // 
            this.toolStripDropDownButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripViewDetails,
            this.toolstripViewThumbnails,
            this.toolstripViewIcons,
            this.toolstripViewLargeIcons,
            this.toolstripViewTile,
            this.toolstripViewList,
            this.toolStripMenuItem1,
            this.toolstripViewExtraLargeIcons});
            this.toolStripDropDownButtonView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonView.Image")));
            this.toolStripDropDownButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonView.Name = "toolStripDropDownButtonView";
            this.toolStripDropDownButtonView.Size = new System.Drawing.Size(42, 22);
            this.toolStripDropDownButtonView.Text = "View";
            this.toolStripDropDownButtonView.ToolTipText = "Switch View of the FileList";
            // 
            // toolstripViewDetails
            // 
            this.toolstripViewDetails.Checked = true;
            this.toolstripViewDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolstripViewDetails.Name = "toolstripViewDetails";
            this.toolstripViewDetails.Size = new System.Drawing.Size(195, 22);
            this.toolstripViewDetails.Text = "Details";
            this.toolstripViewDetails.Click += new System.EventHandler(this.OnViewToolStripMenuItemClick);
            // 
            // toolstripViewThumbnails
            // 
            this.toolstripViewThumbnails.Name = "toolstripViewThumbnails";
            this.toolstripViewThumbnails.Size = new System.Drawing.Size(195, 22);
            this.toolstripViewThumbnails.Text = "Thumbnails";
            this.toolstripViewThumbnails.Click += new System.EventHandler(this.OnViewToolStripMenuItemClick);
            // 
            // toolstripViewIcons
            // 
            this.toolstripViewIcons.Name = "toolstripViewIcons";
            this.toolstripViewIcons.Size = new System.Drawing.Size(195, 22);
            this.toolstripViewIcons.Text = "Icons";
            this.toolstripViewIcons.Click += new System.EventHandler(this.OnViewToolStripMenuItemClick);
            // 
            // toolstripViewLargeIcons
            // 
            this.toolstripViewLargeIcons.Name = "toolstripViewLargeIcons";
            this.toolstripViewLargeIcons.Size = new System.Drawing.Size(195, 22);
            this.toolstripViewLargeIcons.Text = "Large Icons";
            this.toolstripViewLargeIcons.Click += new System.EventHandler(this.OnViewToolStripMenuItemClick);
            // 
            // toolstripViewTile
            // 
            this.toolstripViewTile.Name = "toolstripViewTile";
            this.toolstripViewTile.Size = new System.Drawing.Size(195, 22);
            this.toolstripViewTile.Text = "Tile";
            this.toolstripViewTile.Click += new System.EventHandler(this.OnViewToolStripMenuItemClick);
            // 
            // toolstripViewList
            // 
            this.toolstripViewList.Name = "toolstripViewList";
            this.toolstripViewList.Size = new System.Drawing.Size(195, 22);
            this.toolstripViewList.Text = "List";
            this.toolstripViewList.Click += new System.EventHandler(this.OnViewToolStripMenuItemClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // toolstripViewExtraLargeIcons
            // 
            this.toolstripViewExtraLargeIcons.CheckOnClick = true;
            this.toolstripViewExtraLargeIcons.Name = "toolstripViewExtraLargeIcons";
            this.toolstripViewExtraLargeIcons.Size = new System.Drawing.Size(195, 22);
            this.toolstripViewExtraLargeIcons.Text = "Extra large (Vista only)";
            this.toolstripViewExtraLargeIcons.CheckStateChanged += new System.EventHandler(this.OnToolstripViewExtraLargeIconsClick);
            // 
            // fileList1
            // 
            this.fileList1.AllowDuplicates = false;
            this.fileList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList1.CheckIfExists = false;
            this.fileList1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fileList1.LabelEdit = true;
            this.fileList1.Location = new System.Drawing.Point(12, 31);
            this.fileList1.Name = "fileList1";
            this.fileList1.ShowColorCompressed = System.Drawing.Color.Empty;
            this.fileList1.ShowColorEncrypted = System.Drawing.Color.Empty;
            this.fileList1.ShowErrorMessages = false;
            this.fileList1.ShowOverlayIcons = true;
            this.fileList1.Size = new System.Drawing.Size(670, 289);
            this.fileList1.SortColumn = 0;
            this.fileList1.TabIndex = 2;
            this.fileList1.ThumbnailSize = new System.Drawing.Size(96, 96);
            this.fileList1.UseCompatibleStateImageBehavior = false;
            this.fileList1.UseThreadPool = true;
            // 
            // FileListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 345);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.fileList1);
            this.Controls.Add(this.label1);
            this.Name = "FileListForm";
            this.Text = "An Example using the FileListForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Jam.Shell.FileList fileList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonView;
        private System.Windows.Forms.ToolStripMenuItem toolstripViewDetails;
        private System.Windows.Forms.ToolStripMenuItem toolstripViewThumbnails;
        private System.Windows.Forms.ToolStripMenuItem toolstripViewIcons;
        private System.Windows.Forms.ToolStripMenuItem toolstripViewTile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolstripViewExtraLargeIcons;
        private System.Windows.Forms.ToolStripMenuItem toolstripViewLargeIcons;
        private System.Windows.Forms.ToolStripMenuItem toolstripViewList;
    }
}