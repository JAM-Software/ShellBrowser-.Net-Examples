namespace JamCommander
{
    partial class TreeViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeViewForm));
            this.treeView = new Jam.Shell.ShellTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.treeView.ItemHeight = 48;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.RootedAt = Jam.Shell.ShellFolder.Unknown;
            this.treeView.RootedAtFileSystemFolder = "";
            this.treeView.SelectedPath = "";
            this.treeView.ShowColorCompressed = System.Drawing.Color.Empty;
            this.treeView.ShowColorEncrypted = System.Drawing.Color.Empty;
            this.treeView.ShowRootLines = true;
            this.treeView.Size = new System.Drawing.Size(1134, 921);
            this.treeView.SpecialFolder = Jam.Shell.ShellFolder.Drives;
            this.treeView.TabIndex = 0;
            // 
            // TreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 921);
            this.Controls.Add(this.treeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TreeViewForm";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.TreeViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Jam.Shell.ShellTreeView treeView;
    }
}