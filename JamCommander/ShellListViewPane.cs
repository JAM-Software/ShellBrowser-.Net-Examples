using Jam.Shell;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JamCommander
{
    public partial class ShellListViewPane : UserControl
    {
        private bool CheckboxListIsCalculatingSize = true;
        private EventHandler onFocusChange;
        private EventHandler onQuitButtonClick;

        public EventHandler OnQuitButtonClick
        {
            get { return onQuitButtonClick; }
            set { onQuitButtonClick = value; }
        }

        public EventHandler OnFocusChange
        {
            get { return onFocusChange; }
            set { onFocusChange = value; }
        }

        public ShellListView ShellListView
        {
            get { return shellListView1; }
        }

        public ShellControlConnector ShellControlConnector
        {
            get { return shellControlConnector1; }
        }

        public ShellListViewPane()
        {
            InitializeComponent();

            flowLayoutPanel1.HorizontalScroll.Visible = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;

            shellListView1.Enter += delegate (object _sender, EventArgs _e)
            {
                //Update all the Shell Components in the main form to react to this Pane.
                OnFocusChange(this, null);
                panel1.BorderStyle = BorderStyle.FixedSingle;
            };
            shellListView1.Leave += delegate (object _sender, EventArgs _e)
            {
                panel1.BorderStyle = BorderStyle.None;
            };

            #region Configuration Menu
            //Reset all the controls to default
            shellControlConnector1.ShowParentfolderItem = shellListView1.ShowParentFolder;
            showParentFolderToolStripMenuItem.Checked = shellListView1.ShowParentFolder;
            showHiddenObjectsToolStripMenuItem.Checked = shellListView1.ShowHidden;
            showOverlayIconsToolStripMenuItem.Checked = shellListView1.ShowOverlayIcons;
            useSystemFontToolStripMenuItem.Checked = shellListView1.UseSystemFont;
            fileSystemOnlyToolStripMenuItem.Checked = shellListView1.FileSystemOnly;
            #endregion

            #region Checkboxes
            scanRecursivelyToolStripMenuItem.Checked =
                shellControlConnector1.SelectionList.CalculateSelectedFiles;
            toggleCheckboxesToolStripMenuItem.Checked = shellListView1.CheckBoxes;

            shellControlConnector1.SelectionList.SelectionChanged += delegate (object _sender, EventArgs _e)
            {
                CheckboxListIsCalculatingSize = true; //Keep track if we have finished calculating the size
            };
            shellControlConnector1.SelectionList.CompletedSizeCalculation += delegate (object _sender, EventArgs _e)
            {
                CheckboxListIsCalculatingSize = false;
            };
            #endregion

            #region Drives 
            ShellBrowser browser = new ShellBrowser(ShellFolder.Drives); //Initialize a new Browser with the Root point at "This PC"
            while (browser.Next()) //Browse through all Items listed at Root Point
            { 
                if (PathCollection.IsDrive(browser.FullPath) || browser.HasAttributes(SFGAOF.SFGAO_REMOVABLE))
                {
                    var path = browser.FullPath; //Read the DisplayPath from the ShellBrowser instance

                    //Create a button with the drive icon next to the text.
                    Button driveBtn = new Button
                    {
                        ImageAlign = ContentAlignment.MiddleRight,
                        TextImageRelation = TextImageRelation.ImageBeforeText,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    int index = SystemImageList.GetIndexFromItemIdList(ItemIdList.Parse(path), false);
                    driveBtn.Image = new SystemImageListHelper().GetIconAsBitmap(index);
                    driveBtn.Text = path;
                    driveBtn.Width = 0;
                    driveBtn.AutoSize = true;
                    driveBtn.Click += delegate (object a, EventArgs b)
                    {
                        //When the button is clicked, go to the path by setting the FolderIdList Property.
                        shellListView1.FolderChanged(ItemIdList.Parse(path));
                    };
                    flowLayoutPanel1.Controls.Add(driveBtn);

                }
            }
            #endregion
        }


        #region FileMenu
        private void NewFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.CreateDir(string.Empty, true);
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.InvokeCommandOnSelected(ShellCommand.Rename);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.InvokeCommandOnSelected(ShellCommand.Delete);
        }

        private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.InvokeCommandOnSelected(ShellCommand.Properties);
        }
        #endregion

        #region Checkboxes

        private void ToggleCheckboxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.CheckBoxes ^= true;
            toggleCheckboxesToolStripMenuItem.Checked = shellListView1.CheckBoxes;
            if (!shellListView1.CheckBoxes)
            {
                ShellControlConnector.SelectionList.Clear();
            }
        }

        private void ScanRecursivelyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellControlConnector1.SelectionList.CalculateSelectedFiles ^= true;

            scanRecursivelyToolStripMenuItem.Checked =
                shellControlConnector1.SelectionList.CalculateSelectedFiles;
        }

        /// <summary>
        /// Opens a MessageBox containing information on the currently checkboxed items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PathSelectionList selectionList = shellControlConnector1.SelectionList;

            string selection = shellControlConnector1.SelectionList.ToString();
            if (selection.Length == 0)
            {
                selection = "Nothing is currently checked.";
                if (!(toggleCheckboxesToolStripMenuItem.Checked))
                    selection += " You need to enable checkboxes.";
                MessageBox.Show(selection, "Selectionlist");
            }
            else
            {
                string text = string.Empty;
                if (scanRecursivelyToolStripMenuItem.Checked)
                {
                    text = selection + Environment.NewLine +
                    "Additional values retrieved in background:" + Environment.NewLine +
                    selectionList.FileCount + " files" + Environment.NewLine +
                    selectionList.FolderCount + " folders" + Environment.NewLine +
                    selectionList.Size + " bytes" + Environment.NewLine + Environment.NewLine;
                    if (CheckboxListIsCalculatingSize)
                        text += "Note: File Scanning is not yet complete, please check back later to see the final results.";
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
        /// Opens a form with a FileList containing the currently checkboxed items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowSelectedInAFileListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileListForm fileListform = new FileListForm();

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
        }

        /// <summary>
        /// Copies the selected items to the clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!toggleCheckboxesToolStripMenuItem.Checked) return;
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

        private void ClearSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellControlConnector1.SelectionList.Clear();
        }
        #endregion

        #region Configuration Menu

        private void ShowHiddenObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.ShowHidden ^= true;
            showHiddenObjectsToolStripMenuItem.Checked = shellListView1.ShowHidden;
        }

        private void ShowOverlayIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.ShowOverlayIcons ^= true;
            showOverlayIconsToolStripMenuItem.Checked = shellListView1.ShowOverlayIcons;
        }

        private void ShowParentFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.ShowParentFolder = shellControlConnector1.ShowParentfolderItem ^= true;
            showParentFolderToolStripMenuItem.Checked = shellListView1.ShowParentFolder;
        }

        private void UseSystemFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.UseSystemFont ^= true;
            useSystemFontToolStripMenuItem.Checked = shellListView1.UseSystemFont;
        }

        private void FileSystemOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shellListView1.FileSystemOnly ^= true;
            fileSystemOnlyToolStripMenuItem.Checked = shellListView1.FileSystemOnly;
        }

        /// <summary>
        /// Sets the ViewState Property of the shellListView according to what button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                switch (item.Name)
                {
                    case "viewThumbnails":
                        shellListView1.ViewState = ViewState.Thumbnails;
                        break;
                    case "viewTile":
                        shellListView1.ViewState = ViewState.Tile;
                        break;
                    case "viewDetails":
                        shellListView1.ViewState = ViewState.Details;
                        break;
                    case "viewIcons":
                        shellListView1.ViewState = ViewState.LargeIcons;
                        break;
                    case "viewExtraLargeIcons":
                        shellListView1.ViewState = ViewState.ExtraLargeIcons;
                        break;
                    case "viewLargeIcons":
                        shellListView1.ViewState = ViewState.LargerIcons;
                        break;
                    default:
                        shellListView1.ViewState = ViewState.List;
                        break;
                }
            }
        }
        #endregion

        /// <summary>
        /// Opens the folder selected in the "Special Folder" menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemSpecialFolder_Click(object sender, EventArgs e)
        {
            //To see all special folders either consult the Documentation included or use a code completion feature:
            //ShellFolder.

            var toolStripMenuItem = sender as ToolStripMenuItem;

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
                    shellListView1.SpecialFolder = (ShellFolder)result;
                }
                else
                    MessageBox.Show(
                            "There are even more SpecialFolders you can set,\r\n" +
                            "please see the reference or use the code-completion features of your IDE.",
                            "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnQuitButtonClick(this, null);
        }
    }
}
