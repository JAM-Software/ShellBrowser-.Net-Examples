using Jam.Shell;
using System;
using System.Windows.Forms;

namespace JamCommander
{
    public partial class JamCommanderMainForm : Form
    {
        ShellListViewPane focusedPane, paneLeft, paneRight;
        PreviewForm previewForm;
        TreeViewForm treeViewForm;

        public JamCommanderMainForm()
        {
            InitializeComponent();
            paneLeft = new ShellListViewPane
            {
                Dock = DockStyle.Fill
            };
            paneRight = new ShellListViewPane
            {
                Dock = DockStyle.Fill
            };
            tableLayoutPanel1.Controls.Add(paneLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(paneRight, 2, 0);
        }

        
        /// <summary>
        /// Handles keyboard shortcuts. 
        /// F2: Rename, F3: Paste, F4: Copy, F5: Cut, F6: New Folder
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    focusedPane.ShellListView.InvokeCommandOnSelected(ShellCommand.Rename);
                    break;
                case Keys.F3:
                    focusedPane.ShellListView.InvokeCommandOnFolder(ShellCommand.Paste);
                    break;
                case Keys.F4:
                    focusedPane.ShellListView.InvokeCommandOnSelected(ShellCommand.Copy);
                    break;
                case Keys.F5:
                    focusedPane.ShellListView.InvokeCommandOnSelected(ShellCommand.Cut);
                    break;
                case Keys.F6:
                    focusedPane.ShellListView.CreateDir(string.Empty, true /* Edit Mode */);
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void JamCommander_Load(object sender, EventArgs e)
        {
            //Left Pane
            paneLeft.OnQuitButtonClick += OnQuitButton;
            paneLeft.OnFocusChange += FocusChanged;
            focusedPane = paneLeft; //Start out with the left pane focused

            //Right Pane 
            paneRight.OnQuitButtonClick += OnQuitButton;
            paneRight.OnFocusChange += FocusChanged;

            //Thumbnail Image
            this.SizeChanged += delegate (object _sender, EventArgs _e)
            {
                thumbnailImage1.Margin = new Padding(3, paneRight.ShellListView.Top, 3, 3);
            };
            thumbnailImage1.Margin = new Padding(3, paneRight.ShellListView.Top, 3, 3);

            //Other forms are created at the start of the program and just displayed when needed
            previewForm = new PreviewForm();
            previewForm.FilePreview.ShellControlConnector = focusedPane.ShellControlConnector;

        }

        public ShellListViewPane getFocusedPane()
        {
            return paneLeft.ContainsFocus ? paneLeft : paneRight;
        }

        /// <summary>
        /// Event handler that gets called every time a new pane is focused. It updates all the ShellControlConnector Properties where needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FocusChanged(object sender, EventArgs e)
        {
            ShellControlConnector connector = getFocusedPane().ShellControlConnector;
            focusedPane = getFocusedPane();
            thumbnailImage1.ShellControlConnector = connector;

            if(previewForm != null)
                previewForm.FilePreview.ShellControlConnector = connector;
            if(treeViewForm != null)
                treeViewForm.TreeView.ShellControlConnector = connector;
            connector.FullRefreshControls(getFocusedPane().ShellListView);
        }

        private void ButtonNewFolder_Click(object sender, EventArgs e)
        {
            focusedPane.ShellListView.CreateDir(string.Empty, true /* Edit Mode */);
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            focusedPane.ShellListView.InvokeCommandOnFolder(ShellCommand.Paste);
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            focusedPane.ShellListView.InvokeCommandOnSelected(ShellCommand.Copy);
        }

        private void ButtonRename_Click(object sender, EventArgs e)
        {
            focusedPane.ShellListView.InvokeCommandOnSelected(ShellCommand.Rename);
        }

        private void PreviewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            previewForm.Visible = previewWindowToolStripMenuItem.Checked = !previewWindowToolStripMenuItem.Checked;
        }


        private void TreeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewToolStripMenuItem.Checked && treeViewForm != null)
            {
                treeViewForm.Close();
                treeViewForm = null;
                treeViewToolStripMenuItem.Checked = false;
            }
            else
            {
                treeViewForm = new TreeViewForm();
                treeViewForm.FormClosed += delegate (object _sender, FormClosedEventArgs _e)
                {
                    treeViewToolStripMenuItem.Checked = false;
                };
                treeViewForm.Show();
                treeViewForm.TreeView.ShellControlConnector = focusedPane.ShellControlConnector;
                treeViewToolStripMenuItem.Checked = true;
            }
        }

        private void windowsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            previewWindowToolStripMenuItem.Checked = (previewForm != null) && (previewForm.Visible);
        }


        private void ButtonCut_Click(object sender, EventArgs e)
        {
            focusedPane.ShellListView.InvokeCommandOnSelected(ShellCommand.Cut);
        }

        private void OnQuitButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
