namespace Jam.Samples.Customization
{
    partial class CustomThumbnails
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
            ((System.ComponentModel.ISupportInitialize)(this.shellListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // shellListView1
            // 
            this.shellListView1.AutoSizeColumn = -1;
            this.shellListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellListView1.Filter = "";
            this.shellListView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shellListView1.Location = new System.Drawing.Point(0, 0);
            this.shellListView1.Name = "shellListView1";
            this.shellListView1.Path = "";
            this.shellListView1.ShowColorCompressed = System.Drawing.Color.Empty;
            this.shellListView1.ShowColorEncrypted = System.Drawing.Color.Empty;
            this.shellListView1.Size = new System.Drawing.Size(714, 449);
            this.shellListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.shellListView1.TabIndex = 0;
            this.shellListView1.ThumbnailBorderColor = System.Drawing.Color.Transparent;
            this.shellListView1.Thumbnails = true;
            this.shellListView1.ThumbnailSize = new System.Drawing.Size(96, 96);
            this.shellListView1.UseCompatibleStateImageBehavior = false;
            this.shellListView1.ViewState = Jam.Shell.ViewState.Thumbnails;
            this.shellListView1.ThumbnailUpdated += new System.EventHandler<Jam.Shell.ThumbnailUpdatedEventArgs>(this.shellListView1_ThumbnailUpdated);
            // 
            // CustomThumbnails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shellListView1);
            this.Name = "CustomThumbnails";
            this.Size = new System.Drawing.Size(714, 449);
            ((System.ComponentModel.ISupportInitialize)(this.shellListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shell.ShellListView shellListView1;
    }
}
