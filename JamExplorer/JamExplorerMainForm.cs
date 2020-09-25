using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jam.Shell;
using Jam.Shell.Controls;
using Jam.Explorer.Properties;
using System.Globalization;
using System.IO;

namespace Jam.Explorer
{
    
    public partial class JamExplorerMainForm : Form
    {
        public JamExplorerMainForm()
        {
            InitializeComponent();
            setPreviewVisibility(false);
        }

        private void ToolbarFolderUp_Click(object sender, EventArgs e)
        {
            shellListView1.GoUp();
            
        }

        private void MenuShowPropertiesItem_Click(object sender, EventArgs e)
        {
            if (shellTreeView1.Focused)
                shellTreeView1.InvokeCommandOnSelected(ShellCommand.Properties);            
            else
                shellListView1.InvokeCommandOnSelected(ShellCommand.Properties);            
        }

        private void MenuRenameItem_Click(object sender, EventArgs e)
        {
            if (shellTreeView1.Focused)
                shellTreeView1.InvokeCommandOnSelected(ShellCommand.Rename);
            if (shellListView1.Focused)
                shellListView1.InvokeCommandOnSelected(ShellCommand.Rename);
        }

        private void MenuDeleteItem_Click(object sender, EventArgs e)
        {
            if (shellTreeView1.Focused)
                shellTreeView1.InvokeCommandOnSelected(ShellCommand.Delete);
            if (shellListView1.Focused)
                shellListView1.InvokeCommandOnSelected(ShellCommand.Delete);
        }

        private void MenuCloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                shellListView1.CreateDir(string.Empty, true);
            }
            catch (Exception ex)
            {
                if (ex is UnauthorizedAccessException || ex is InvalidOperationException)
                    MessageBox.Show(String.Format(CultureInfo.CurrentCulture,
                            "Unable to create Folder:" + Environment.NewLine + "{0}", ex.Message), String.Empty,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                else
                    throw;
            }

        }

        private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enabledToolStripMenuItem.Checked = !enabledToolStripMenuItem.Checked;
        }

        private void enabledToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            shellListView1.CheckBoxes = enabledToolStripMenuItem.Checked;
            shellTreeView1.CheckBoxes = enabledToolStripMenuItem.Checked;
            if (!enabledToolStripMenuItem.Checked)
            {
                shellControlConnector1.SelectionList.Clear();
            }

        }

        private void showSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PathSelectionList selectionList = 
                shellControlConnector1.SelectionList;

            string selection = shellControlConnector1.SelectionList.ToString();
            if (selection.Length == 0)
            {
                selection = "Nothing is currently checked.";
                if (!(enabledToolStripMenuItem.Checked))
                    selection += " You need to enable checkboxes.";
                MessageBox.Show(selection, "Selectionlist");
            }
            //See also the event 
            //selectionList.CompletedSizeCalculation += ...
            else
            {
                string text = string.Empty;
                if (recursivelyScanSelectedToolStripMenuItem.Checked)
                {
                    text = selection + Environment.NewLine +
                    "Additional values retrieved in background:" + Environment.NewLine +
                    selectionList.FileCount + " files" + Environment.NewLine +
                    selectionList.FolderCount + " folders" + Environment.NewLine +
                    selectionList.Size + " bytes" + Environment.NewLine + Environment.NewLine
                    + "Note: If you selected a large folder, it may take some time to calculate. However the values in this MessageBox are not refreshed automatically. Please open again for updated values.";
                }
                else
                {
                    text = selection + Environment.NewLine +
                        "To retrieve additional information (like filecount or size) for the selection,\n" +
                        "enbable Checkboxes --> Recursively Scan Selected";
                }
                MessageBox.Show(text, "Selectionlist");
            }
        }

        /// <summary>
        /// This enables/disables the recursive scan to calculate the overall size
        /// of the selected files. It demonstrates the use of the CheckBoxes without
        /// the additional overhead to determine the filesize.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recursivelyScanSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //switch the calculation mode:
            shellControlConnector1.SelectionList.CalculateSelectedFiles ^= true;

            recursivelyScanSelectedToolStripMenuItem.Checked =
                shellControlConnector1.SelectionList.CalculateSelectedFiles;
        }


        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!enabledToolStripMenuItem.Checked) return;
            System.Collections.Specialized.StringCollection sc = new System.Collections.Specialized.StringCollection();
            foreach (string item in shellControlConnector1.SelectionList)
            {
                sc.Add(PathCollection.ExcludeTrailingPathDelimiter(item.TrimEnd('*')));
            }
            if (sc.Count > 0)
            {
                Clipboard.SetFileDropList(sc);
            }
        }

        private void clearSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellControlConnector1.SelectionList.Clear();
        }

        private void automaticRefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellTreeView1.AutomaticRefresh = !shellTreeView1.AutomaticRefresh;
            automaticRefreshTreeToolStripMenuItem.Checked = shellTreeView1.AutomaticRefresh;
        }

        private void fullRefreshTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellTreeView1.Refresh(RefreshLevel.Full);
        }

        private void smartRefreshTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellTreeView1.Refresh(RefreshLevel.Smart);
        }

        private void desktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellTreeView1.RootedAt = ShellFolder.Desktop;
        }

        private void myComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellTreeView1.RootedAt = ShellFolder.Drives;
        }

        private void allTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellTreeView1.RootedAt = ShellFolder.AllTasks;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellTreeView1.RootedAtFileSystemFolder = @"C:\";
        }

        private void showHiddenObjectsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.ShowHidden = !shellListView1.ShowHidden;
            showHiddenObjectsListToolStripMenuItem.Checked = shellListView1.ShowHidden;
        }

        private void showParentFolderIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.ShowParentFolder = !shellListView1.ShowParentFolder;
            showParentFolderIconToolStripMenuItem.Checked = shellListView1.ShowParentFolder;
        }

        private void automaticRefreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.AutomaticRefresh = !shellListView1.AutomaticRefresh;
            automaticRefreshListToolStripMenuItem.Checked = shellListView1.AutomaticRefresh;
        }

        private void fullRefreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.Refresh(RefreshLevel.Full);
        }

        private void smartRefreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.Refresh(RefreshLevel.Smart);
        }

        private void showOverlayIconsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.ShowOverlayIcons = !shellListView1.ShowOverlayIcons;
            showOverlayIconsListToolStripMenuItem.Checked = shellListView1.ShowOverlayIcons;
        }

        private void shellListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = shellListView1.SelectedItems.Count.ToString() + " item(s) selected.";
        }

        private void shellTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            toolStripStatusLabel1.Text = shellTreeView1.SelectedPath;
        }


        private void allowDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowDropToolStripMenuItem.Checked = !allowDropToolStripMenuItem.Checked;
        }

        private void allowDropToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            shellTreeView1.AllowDrop =
                allowDropToolStripMenuItem.Checked;
            shellTreeView1.AllowDrag =
                allowDropToolStripMenuItem.Checked;
        }

        private void OnShowOverlayiconsTreeToolStripMenuItemClick(object sender, EventArgs e)
        {
            shellTreeView1.ShowOverlayIcons = !shellTreeView1.ShowOverlayIcons;
            showOverlayiconsTreeToolStripMenuItem.Checked = shellTreeView1.ShowOverlayIcons;
        }

        private void showFilesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showFilesToolStripMenuItem.Checked = !showFilesToolStripMenuItem.Checked;
        }

        private void showFilesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            shellTreeView1.ShowFiles = showFilesToolStripMenuItem.Checked;
            Properties.Settings.Default.ShowFiles = shellTreeView1.ShowFiles;
        }

        private void desktopToolStripMenuItemSpecialFolder_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem toolStripMenuItem =   sender as ToolStripMenuItem;

            if (toolStripMenuItem != null)
            {
                object result = null;
                try
                {
                    result = Enum.Parse(typeof(ShellFolder), toolStripMenuItem.Text, true);
                }
                catch (ArgumentException) { }
                if (result != null)
                {
                    // fixes bug #3837
                    if (shellTreeView1.RootedAt != ShellFolder.Desktop)
                        shellTreeView1.RootedAt = (ShellFolder)result;
                    else
                        shellTreeView1.SpecialFolder = (ShellFolder)result;
                }
                else
                    MessageBox.Show(
                            "There are even more SpecialFolders you can set,\r\n" +
                            "please see the reference or use the code-completion features of your IDE.",
                            "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private bool dialogShown = true; //set to false to enable the "BeforeShellCommand" functionality

        /// <summary>
        /// This shows how to capture the invocation command in order to
        /// process it explicitly, instead of letting shellbrowser do the 
        /// default system task. You can of course also extend its functionality
        /// here, e.g. by adding logging capabilities.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">The event args holding the affected paths and the possibility to cancel the operation.</param>
        private void shellListView1_BeforeShellCommand(object sender, BeforeShellCommandEventArgs e)
        {
            if (dialogShown)
                return;

            if ((e.Verb == ShellCommand.Default) || (e.Verb == ShellCommand.Open)) {
                DialogResult dialogResult =
                    MessageBox.Show(String.Format("Do you want to open the file selected?{0}" +
                                    "(This message is shown only once as a demonstration of the 'BeforeShellCommand' event)",
                        System.Environment.NewLine, e.Verb),
                        "BeforeShellCommand", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                dialogShown = true;
                if (dialogResult == DialogResult.No)
                {
                    //process the selected items on your own
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// This method gets called if a key has been pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnJamExplorerMainKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        shellControlConnector1.MoveInHistory(-1);
                        break;
                    case Keys.Right:
                        shellControlConnector1.MoveInHistory(+1);
                        break;
                }
            }
        }

        #region show files selected via checkboxes in a file list 


        private void OnShowSelectedInAFileListToolStripMenuItemClick(object sender, EventArgs e)
        {
            FileListForm fileListform = new Explorer.FileListForm();

            fileListform.Show();

            //With GetFileEnumerator you get all files that are selected directly or indirectly via their folder.
            foreach (string s in shellControlConnector1.SelectionList.GetFileEnumerator())
            {
                fileListform.FileList.Add(s);
                Application.DoEvents();
                if (fileListform.IsDisposed)
                {
                    return;
                }
            }
            if (recursivelyScanSelectedToolStripMenuItem.Checked)
            {
                if (shellControlConnector1.SelectionList.Count > 0)
                    fileListform.TotalSize = shellControlConnector1.SelectionList.Size;
                else
                    fileListform.TotalSize = 0;
            }
            else
            {
                fileListform.TotalSizeDisabled =
                    "Enable \"CheckBoxes --> Recursively scan selected\" to show the total size of your selection.";
            }
        }

        #endregion

        #region trigger the FileSystemOnly  property of ShellListView and ShellTreeView

        private void OnFileSystemOnlyToolStripMenuItemClick(object sender, EventArgs e)
        {
            shellTreeView1.FileSystemOnly = !shellTreeView1.FileSystemOnly;
            fileSystemOnlyToolStripMenuItem1.Checked = shellTreeView1.FileSystemOnly;
        }

        private void OnFileSystemOnlyToolStripMenuItemClick2(object sender, EventArgs e)
        {
            shellListView1.FileSystemOnly = !shellListView1.FileSystemOnly;
            fileSystemOnlyToolStripMenuItem2.Checked = shellListView1.FileSystemOnly;
        }

        #endregion

        #region open up the search dialog

        private JamSearch.JamSearchMainForm searchForm;

        private void toolStripSearchButtonClick(object sender, EventArgs e)
        {
            if (searchForm == null)
            {
                searchForm = new JamSearch.JamSearchMainForm();
                searchForm.FormClosing += new FormClosingEventHandler(OnSearchFormFormClosing);
                //connect the shellControl connector to the searchform, 
                //this way the found files will be checked 
                searchForm.ShellControlConnector = shellControlConnector1;
            }
            //switch the visibility:
            searchForm.Visible ^= true;

            if (searchForm.Visible)
            {
                searchForm.SearchPath = shellTreeView1.SelectedPath;
            }
        }

        /// <summary>
        /// Suppress disposing the form to be able to show it again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnSearchFormFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            searchForm.Visible = false;
        }

        #endregion


        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.SelectAll();
        }

        private void OnToggleListViewBackgroundToolStripMenuItemClick(object sender, EventArgs e)
        {
            shellListView1.BackgroundImageTiled = true;
            ToggleBackground(shellListView1);
        }

        private int m_currentBackground = 0;

        private void ToggleBackground(Control control)
        {
            switch (m_currentBackground)
            {
                case 0:
                    control.BackgroundImage = Resources.background;
                    break;
                case 1:
                case 2:
                    control.BackgroundImage = null;
                    control.BackColor = (m_currentBackground == 1) ? Color.OldLace : Color.White;
                    break;
            }

            if (++m_currentBackground > 2)
                m_currentBackground = 0;
        }

        private void JamExplorerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (searchForm != null)
            {
                searchForm.Dispose();
            }
        }

        private void setPreviewVisibility(bool visible)
        {
            shellFilePreview1.Visible = shellFilePreview1.Enabled = visible;
            splitContainerPreview.Panel2Collapsed = !visible;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            setPreviewVisibility(!shellFilePreview1.Visible);
        }

        private void shellFilePreview1_LoadPreview(object sender, LoadPreviewEventArgs e)
        {
            string file = e.Path;
            if (file == null)
            {
                return;
            }
            if (".xyz".Equals(Path.GetExtension(file), StringComparison.OrdinalIgnoreCase))
            {
                e.PreviewHandlerGuid = new Guid("1531d583-8375-4d3f-b5fb-d23bbd169f22");
            }
            else if (".pas".Equals(Path.GetExtension(file), StringComparison.OrdinalIgnoreCase))
            {
                e.CustomPreviewHandler = new CustomPreviewHandler();
            }
            else if (ShellFilePreview.WebPreviewHandler.Equals(e.PreviewHandlerGuid))
            {
                // Like Windows Explorer we do not use this PreviewHandler (used for e.g. .htm, .xml, .jer, .eml files). 
                // While it works for some files, for others it'll show a SaveAs message.
                e.PreviewHandlerGuid = null;
            }
            else if (e.PreviewHandlerGuid == null)
            {
                //add actions to take if no registered PreviewHandler is available.
            }
        }

        private void likeWindowsExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellTreeView1.MultipleRoots = MultipleRoots.MultipleRoots;
        }
        private SizeF m_Scale = new SizeF(1.0f, 1.0f);
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            m_Scale = new SizeF(m_Scale.Width * factor.Width, m_Scale.Height * factor.Height);
            base.ScaleControl(factor, specified);
        }

        private void JamExplorerMainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "ShellBrowser: " + new ShellBrowser().Version + " .NET Framework: " +
            AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;

            toolStripSplitButtonView.DefaultItem = toolStripSplitButtonView.DropDownItems[0];

            //Un-comment for a custom entry in the background context menu.
//            shellListView1.BackgroundContextMenu = new MyBackgroundContextMenu();
        }

        private void OpenControlPanelTask(Jam.Shell.Dialogs.ControlPanelItem pControlPanelItem)
        {
            Jam.Shell.Dialogs.ControlPanelTaskDialog lControlPanelTaskDialog = new Jam.Shell.Dialogs.ControlPanelTaskDialog();
            lControlPanelTaskDialog.ControlPanelItem = pControlPanelItem;
            lControlPanelTaskDialog.ShowDialog();
        }
        private void allTasksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenControlPanelTask(Jam.Shell.Dialogs.ControlPanelItem.AllTasks);
        }

        private void userAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenControlPanelTask(Jam.Shell.Dialogs.ControlPanelItem.UserAccounts);
        }

        private void folderOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenControlPanelTask(Jam.Shell.Dialogs.ControlPanelItem.AdministrativeTools);
        }

        private void programsAndFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenControlPanelTask(Jam.Shell.Dialogs.ControlPanelItem.ProgramsAndFeatures);
        }

        private void toolStripButtonViewDetails_Click(object sender, EventArgs e)
        {
            shellListView1.ViewState = ViewState.Details;
        }

        private void toolStripButtonViewList_Click(object sender, EventArgs e)
        {
            shellListView1.ViewState = ViewState.List;
        }


        private void toolStripButtonViewThumbnails_Click(object sender, EventArgs e)
        {
            shellListView1.ViewState = ViewState.Thumbnails;
        }

        private void viewTile_Click(object sender, EventArgs e)
        {
            shellListView1.ViewState = ViewState.Tile;
        }

        private void viewLargerIcons_Click(object sender, EventArgs e)
        {
            shellListView1.ViewState = ViewState.LargerIcons;
        }

        private void viewIcons_Click(object sender, EventArgs e)
        {
            shellListView1.ViewState = ViewState.LargeIcons;
        }

        private void viewExtraLarge_Click(object sender, EventArgs e)
        {
            shellListView1.ViewState = ViewState.ExtraLargeIcons;
        }

        private void addressBar1_PathSelected(object sender, EventArgs e)
        {
            shellListView1.Focus();
        }

        private void explorerContextMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellTreeView1.ShellContextMenu = !shellTreeView1.ShellContextMenu;
            explorerContextMenuToolStripMenuItem.Checked = shellTreeView1.ShellContextMenu;
        }
    }

    class CustomPreviewHandler : IShellPreviewHandler
    {
        private TextBox m_TextBox;

        public bool Load(ICommonPreviewHandlerHost p_Parent, string p_Path, ItemIdList p_AbsolutePidl)
        {
            ShellFilePreview parent = p_Parent as ShellFilePreview;
            m_TextBox = new TextBox();
            m_TextBox.Dock = DockStyle.Fill;
            m_TextBox.Parent = parent;
            m_TextBox.WordWrap = false;
            m_TextBox.ScrollBars = ScrollBars.Both;
            m_TextBox.Multiline = true;
            m_TextBox.Text = File.ReadAllText(p_Path);
            parent.Controls.Add(m_TextBox);
            return true;
        }

        public void Show()
        {
            
        }
        public void Unload()
        {
            m_TextBox.Dispose();
        }

        public void Resize()
        {

        }
    }

    class MyBackgroundContextMenu : BackgroundContextMenu
    {
        protected override void SetupMenuItems()
        {
            base.SetupMenuItems();
            ToolStripMenuItem myItem = new ToolStripMenuItem("My Additional Item");
            myItem.Click += myItem_Click;
            Items.Add(myItem);
            //hide a default item:
            //this.Actualize.Visible = false;
        }

        void myItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("additional item clicked");
        }
    }

}