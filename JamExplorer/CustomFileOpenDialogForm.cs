using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jam.Explorer
{
    public partial class CustomFileOpenDialogForm : Form
    {
        public CustomFileOpenDialogForm()
        {
            InitializeComponent();
            if (filterComboBox1.Items.Count > 0)
              filterComboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = recentlyUsedComboBox1.SelectedItem.ToString();
            if (File.Exists(path))
                Process.Start(path);
            else if (Directory.Exists(path))
                shellListView1.Path = path;
            else
                MessageBox.Show("Windows cannot find the specified file or folder, please make sure that you have typed the name correctly and please try again.");
        
        }

        private void filterComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            recentlyUsedComboBox1.Filter = filterComboBox1.SelectedItem.ToString();
            shellListView1.Filter = recentlyUsedComboBox1.Filter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
