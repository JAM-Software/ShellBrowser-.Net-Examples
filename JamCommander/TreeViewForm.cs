using Jam.Shell;
using System;
using System.Windows.Forms;

namespace JamCommander
{
    public partial class TreeViewForm : Form
    {
        public ShellTreeView TreeView
        {
            get { return treeView; }
            set { treeView = value; }
        }

        public TreeViewForm()
        {
            InitializeComponent();
        }

        private void TreeViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
