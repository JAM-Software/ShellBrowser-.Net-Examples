namespace JamCommander
{
    partial class PreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.filePreview = new Jam.Shell.ShellFilePreview();
            ((System.ComponentModel.ISupportInitialize)(this.filePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // filePreview
            // 
            this.filePreview.DisplayMsg = "filePreview";
            this.filePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePreview.Enabled = false;
            this.filePreview.ItemIdList = null;
            this.filePreview.Location = new System.Drawing.Point(0, 0);
            this.filePreview.Margin = new System.Windows.Forms.Padding(2);
            this.filePreview.Name = "filePreview";
            this.filePreview.Path = null;
            this.filePreview.ShellControlConnector = null;
            this.filePreview.Size = new System.Drawing.Size(568, 335);
            this.filePreview.TabIndex = 0;
            this.filePreview.Text = "FilePreview";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 335);
            this.Controls.Add(this.filePreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PreviewForm";
            this.Text = "Preview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreviewForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.PreviewForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.filePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Jam.Shell.ShellFilePreview filePreview;
    }
}