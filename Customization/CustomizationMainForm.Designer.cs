namespace Jam.Samples.Customization
{
    partial class CustomizationMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizationMainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonCustomImages = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomColumns = new System.Windows.Forms.RadioButton();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButtonCustomThumbs = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.radioButtonCustomThumbs);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButtonCustomImages);
            this.groupBox1.Controls.Add(this.radioButtonCustomColumns);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 540);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Examples";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(20, 131);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(138, 63);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Demonstrates how to use custom icons in the ShellTreeView and ShellListView.";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(20, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(138, 48);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Demonstrates how to add custom columns.";
            // 
            // radioButtonCustomImages
            // 
            this.radioButtonCustomImages.AutoSize = true;
            this.radioButtonCustomImages.Location = new System.Drawing.Point(12, 108);
            this.radioButtonCustomImages.Name = "radioButtonCustomImages";
            this.radioButtonCustomImages.Size = new System.Drawing.Size(89, 17);
            this.radioButtonCustomImages.TabIndex = 3;
            this.radioButtonCustomImages.TabStop = true;
            this.radioButtonCustomImages.Text = "Custom Icons";
            this.radioButtonCustomImages.UseVisualStyleBackColor = true;
            this.radioButtonCustomImages.CheckedChanged += new System.EventHandler(this.radioButtonCustomImages_CheckedChanged);
            // 
            // radioButtonCustomColumns
            // 
            this.radioButtonCustomColumns.AutoSize = true;
            this.radioButtonCustomColumns.Location = new System.Drawing.Point(12, 31);
            this.radioButtonCustomColumns.Name = "radioButtonCustomColumns";
            this.radioButtonCustomColumns.Size = new System.Drawing.Size(103, 17);
            this.radioButtonCustomColumns.TabIndex = 2;
            this.radioButtonCustomColumns.TabStop = true;
            this.radioButtonCustomColumns.Text = "Custom Columns";
            this.radioButtonCustomColumns.UseVisualStyleBackColor = true;
            this.radioButtonCustomColumns.CheckedChanged += new System.EventHandler(this.radioButtonCustomColumns_CheckedChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(158, 390);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(839, 150);
            this.textBoxDescription.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(158, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 390);
            this.panel1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(20, 223);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(138, 48);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Demonstrates how to use custom images.";
            // 
            // radioButtonCustomThumbs
            // 
            this.radioButtonCustomThumbs.AutoSize = true;
            this.radioButtonCustomThumbs.Location = new System.Drawing.Point(12, 200);
            this.radioButtonCustomThumbs.Name = "radioButtonCustomThumbs";
            this.radioButtonCustomThumbs.Size = new System.Drawing.Size(117, 17);
            this.radioButtonCustomThumbs.TabIndex = 6;
            this.radioButtonCustomThumbs.TabStop = true;
            this.radioButtonCustomThumbs.Text = "Custom Thumbnails";
            this.radioButtonCustomThumbs.UseVisualStyleBackColor = true;
            this.radioButtonCustomThumbs.CheckedChanged += new System.EventHandler(this.radioButtonCustomThumbs_CheckedChanged);
            // 
            // CustomizationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomizationMainForm";
            this.Text = "Customizing ShellBrower.NET controls";
            this.Load += new System.EventHandler(this.CustomizationMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCustomImages;
        private System.Windows.Forms.RadioButton radioButtonCustomColumns;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButtonCustomThumbs;
    }
}

