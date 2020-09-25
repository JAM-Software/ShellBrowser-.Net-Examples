using System;
using System.Windows.Forms;
using Jam.Shell;

namespace GettingStarted
{
    public partial class GettingStartedMainForm : Form
    {
        public GettingStartedMainForm()
        {
            InitializeComponent();
            //initial event to set the comment/description text
            tabControl1_SelectedIndexChanged(this, new EventArgs());
            driveListDriveListTab.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// Enable/Disable Checkboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            shellListViewShellTreeAndShellListTab.CheckBoxes =
            shellTreeViewShellTreeAndShellListTab.CheckBoxes =
                (sender as CheckBox).Checked;
        }

        #region methods of the ShellChangeNotifier Tab

        /// <summary>
        /// Handles Change-Events from the ShellChangeNotifier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shellChangeNotifier1_Change(object sender, Jam.Shell.ChangeNotificationEventArgs e)
        {
            textBox1.Text += e.Event.ToString() + ':' + Environment.NewLine;
            textBox1.Text += e.Path1 + Environment.NewLine;
            if (e.Event == NotificationEvents.FolderRename || e.Event == NotificationEvents.FileRename)
                textBox1.Text += e.Path2 + Environment.NewLine;

            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }

        /// <summary>
        /// Clears the FileList.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearList_Click(object sender, EventArgs e)
        {
            fileListShellChangeNotifierTab.Clear();
        }

        /// <summary>
        /// This method gets called if one of the option checkboxes 
        /// changes its state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxOptionsCheckStateChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (sender == null)
                return;

            if (sender == checkBoxEnableShellChangeNotifier)
            {
                shellChangeNotifier1.Enabled = checkBoxEnableShellChangeNotifier.Checked;
                return;
            }
            if (sender == checkBoxShellChangeNotifierRecursive)
            {
                shellChangeNotifier1.Recursive = checkBoxShellChangeNotifierRecursive.Checked;
                return;
            }

            object o = Enum.Parse(typeof(NotificationEvents), checkBox.Text);
            if (o == null) return;
            NotificationEvents notificationEvent = (NotificationEvents)o;

            if (checkBox.Checked)
                //set the bit of the particular event to listen to
                shellChangeNotifier1.EventFilter |= notificationEvent;
            else
                //clear the bit of the particular event by applying the inverted mask
                shellChangeNotifier1.EventFilter &= (NotificationEvents)(~(int)notificationEvent);
        }

        private void fileList1_ItemListChanged(object sender, EventArgs e)
        {
            shellChangeNotifier1.Directories.Clear();
            foreach (FileListItem item in fileListShellChangeNotifierTab.Items)
            {
                shellChangeNotifier1.Directories.Add(item.Path);
            }
        }

        #endregion

        private void createALinkOnTheDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Your context menu item integrated with the ShellSystemList",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Changes the info text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    infoLabel.Text = Properties.Resources.SimpleExample1;
                    break;
                case 1:
                    infoLabel.Text = Properties.Resources.SimpleExample2;
                    break;
                case 2:
                    infoLabel.Text = Properties.Resources.SimpleExample3;
                    break;
                case 3:
                    infoLabel.Text = Properties.Resources.SimpleExample4;
                    break;
            }
        }

        private void OnClearEventListClick(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void OnMasterCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            shellChangeNotifier1.Enabled = false;
            try
            {
                foreach (Control c in fileSystemEvents.Controls)
                {
                    if (masterCheckBox.Equals(c))
                        continue;
                    CheckBox checkbox = c as CheckBox;
                    if (checkbox != null)
                        checkbox.Checked = masterCheckBox.Checked;
                }
            }
            finally
            {
                shellChangeNotifier1.Enabled = checkBoxEnableShellChangeNotifier.Checked;
            }
        }

        private void addWatch_Click(object sender, EventArgs e)
        {
            fileListShellChangeNotifierTab.Add(pathEdit.Path);
        }
    }
}
