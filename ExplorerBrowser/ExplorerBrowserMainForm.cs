using System;
using System.Windows.Forms;
using Jam.Shell;

namespace ExplorerBrowser
{
    public partial class ExplorerBrowserMainForm : Form
    {
        public ExplorerBrowserMainForm()
        {
            InitializeComponent();
        }

        private void myComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.SpecialFolder = ShellFolder.Drives;
        }

        private void desktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.SpecialFolder = ShellFolder.Desktop;
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.SpecialFolder = ShellFolder.Windows;
        }

        private void controlPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.SpecialFolder = ShellFolder.Controls;
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BrowseForFolder dialog = new BrowseForFolder())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    explorerBrowser1.FolderIdList = dialog.SelectedFolderIdList;
                }
            }
        }

        private bool IsPaneVisible(ExplorerPane pane)
        {
            return (explorerBrowser1.VisiblePanes & pane) == pane;
        }

        private bool IsFlagSet(FolderFlags flag)
        {
            return (explorerBrowser1.ViewFolderFlags & flag) == flag;
        }

        private void TogglePane(ExplorerPane pane)
        {
            explorerBrowser1.VisiblePanes ^= pane;
        }

        private void ToggleFlag(FolderFlags flag)
        {
            explorerBrowser1.ViewFolderFlags ^= flag;
        }

        private void addressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TogglePane(ExplorerPane.AddressBar);
        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TogglePane(ExplorerPane.Navigation);
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //either Preview or Details pane can be displayed, but not both.
            if (!((ToolStripMenuItem)sender).Checked)
            {
                if (IsPaneVisible(ExplorerPane.DetailsPane))
                    TogglePane(ExplorerPane.DetailsPane);
            }

            TogglePane(ExplorerPane.PreviewPane);
        }

        private void commandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.VisiblePanes |= ExplorerPane.CommandsOrganize | ExplorerPane.CommandsView; //show "Organize" and "View" in the Command panel.
            TogglePane(ExplorerPane.Commands); //show/hide Command panel
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.ContentFilter.ShowFiles = !explorerBrowser1.ContentFilter.ShowFiles;
        }

        private void foldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.ContentFilter.ShowFolders = !explorerBrowser1.ContentFilter.ShowFolders;
        }

        private void networkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.ContentFilter.ShowNethood = !explorerBrowser1.ContentFilter.ShowNethood;
        }

        private void filesystemOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.ContentFilter.FileSystemOnly = !explorerBrowser1.ContentFilter.FileSystemOnly;
        }

        private void setFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //only shows txt - files
            if (String.IsNullOrEmpty(explorerBrowser1.ContentFilter.FilePatternFilter))
                explorerBrowser1.ContentFilter.FilePatternFilter = "*.txt";
            else
                explorerBrowser1.ContentFilter.FilePatternFilter = null;
        }

        private void hiddenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.ContentFilter.ShowHidden = !explorerBrowser1.ContentFilter.ShowHidden;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.View = Jam.Shell.Com.FolderViewMode.Details;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.View = Jam.Shell.Com.FolderViewMode.SmallIcon;
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.ThumbnailSize = (int)IconSize.Thumbnail;
            explorerBrowser1.View = Jam.Shell.Com.FolderViewMode.Thumbnail;
        }

        private void jumboIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.ThumbnailSize = (int)IconSize.Jumbo;
            explorerBrowser1.View = Jam.Shell.Com.FolderViewMode.Thumbnail;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.View = Jam.Shell.Com.FolderViewMode.Tile;
        }

        private void contentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.View = Jam.Shell.Com.FolderViewMode.Content;
        }

        private void singleSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleFlag(FolderFlags.SingleSelection);
        }

        private void columnHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleFlag(FolderFlags.NoColumnHeader);
        }

        private void filteringAllowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleFlag(FolderFlags.NoFilters);
        }

        private void groupingAllowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleFlag(FolderFlags.NoGrouping);
        }

        private void extendedTilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.View = Jam.Shell.Com.FolderViewMode.Tile;
            ToggleFlag(FolderFlags.ExtendedTiles);
            explorerBrowser1.FullRefresh();
        }

        private void headerOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.ShowHeader = ExplorerShowHeader.Always;
        }

        private void headerOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.ShowHeader = ExplorerShowHeader.Never;
        }

        private void headerAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.ShowHeader = ExplorerShowHeader.Auto;
        }

        private void headerToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            headerOnToolStripMenuItem.Checked = explorerBrowser1.ShowHeader == ExplorerShowHeader.Always;
            headerOffToolStripMenuItem.Checked = explorerBrowser1.ShowHeader == ExplorerShowHeader.Never;
            headerAutoToolStripMenuItem.Checked = explorerBrowser1.ShowHeader == ExplorerShowHeader.Auto;
        }

        private void columnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormColumns().Show(explorerBrowser1);
        }

        private void viewToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            detailsToolStripMenuItem.Checked = explorerBrowser1.View == Jam.Shell.Com.FolderViewMode.Details;
            smallIconsToolStripMenuItem.Checked = explorerBrowser1.View == Jam.Shell.Com.FolderViewMode.SmallIcon;
            largeIconsToolStripMenuItem.Checked = explorerBrowser1.View == Jam.Shell.Com.FolderViewMode.Thumbnail && explorerBrowser1.ThumbnailSize == (int)IconSize.Thumbnail;
            jumboIconsToolStripMenuItem.Checked = explorerBrowser1.View == Jam.Shell.Com.FolderViewMode.Thumbnail && explorerBrowser1.ThumbnailSize == (int)IconSize.Jumbo;
            tileToolStripMenuItem.Checked = explorerBrowser1.View == Jam.Shell.Com.FolderViewMode.Tile;
            contentToolStripMenuItem.Checked = explorerBrowser1.View == Jam.Shell.Com.FolderViewMode.Content;
        }

        private void toolStripDropDownButton2_DropDownOpened(object sender, EventArgs e)
        {
            addressBarToolStripMenuItem.Checked = IsPaneVisible(ExplorerPane.AddressBar);
            previewToolStripMenuItem.Checked = IsPaneVisible(ExplorerPane.PreviewPane);
            navigationToolStripMenuItem.Checked = IsPaneVisible(ExplorerPane.Navigation);
            commandsToolStripMenuItem.Checked = IsPaneVisible(ExplorerPane.Commands);
            searchBoxToolStripMenuItem.Checked = IsPaneVisible(ExplorerPane.SearchEdit);
            detailsToolStripMenuItem1.Checked = IsPaneVisible(ExplorerPane.DetailsPane);
            historyToolStripMenuItem.Checked = IsPaneVisible(ExplorerPane.History);
        }

        private void toolStripDropDownButton3_DropDownOpened(object sender, EventArgs e)
        {
            singleSelectionToolStripMenuItem.Checked = IsFlagSet(FolderFlags.SingleSelection);
            extendedTilesToolStripMenuItem.Checked = IsFlagSet(FolderFlags.ExtendedTiles);
            filteringAllowedToolStripMenuItem.Checked = !IsFlagSet(FolderFlags.NoFilters);
            groupingAllowedToolStripMenuItem.Checked = !IsFlagSet(FolderFlags.NoGrouping);

            selectionCheckboxesToolStripMenuItem.Checked = explorerBrowser1.CheckMode == CheckMode.AutoSelect;
        }

        private void toolStripDropDownButton4_DropDownOpened(object sender, EventArgs e)
        {
            filesToolStripMenuItem.Checked = explorerBrowser1.ContentFilter.ShowFiles;
            foldersToolStripMenuItem.Checked = explorerBrowser1.ContentFilter.ShowFolders;
            networkToolStripMenuItem.Checked = explorerBrowser1.ContentFilter.ShowNethood;
            hiddenToolStripMenuItem.Checked = explorerBrowser1.ContentFilter.ShowHidden;
            setFilterToolStripMenuItem.Checked = !String.IsNullOrEmpty(explorerBrowser1.ContentFilter.FilePatternFilter);
            filesystemOnlyToolStripMenuItem.Checked = explorerBrowser1.ContentFilter.FileSystemOnly;
        }

        private void allTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorerBrowser1.SpecialFolder = ShellFolder.AllTasks;
        }

        private void searchBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsPaneVisible(ExplorerPane.SearchEdit))
            {
                if (!IsPaneVisible(ExplorerPane.AddressBar))
                    TogglePane(ExplorerPane.AddressBar);
            }
            TogglePane(ExplorerPane.SearchEdit);
        }

        private void ExplorerBrowserMainForm_Load(object sender, EventArgs e)
        {
            // Search is not supported prior to Vista (SBNET-1221)
            if (!ShellBrowser.IsWindows7OrLater)
            {
                explorerBrowser1.VisiblePanes -= ExplorerPane.SearchEdit;
                searchBoxToolStripMenuItem.Enabled = false;
            }
        }

        private void detailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //either Preview or Details pane can be displayed, but not both.
            if (!((ToolStripMenuItem)sender).Checked)
            {
                if (IsPaneVisible(ExplorerPane.PreviewPane))
                    TogglePane(ExplorerPane.PreviewPane);
            }
            TogglePane(ExplorerPane.DetailsPane);
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsPaneVisible(ExplorerPane.History))
            {
                if (!IsPaneVisible(ExplorerPane.AddressBar))
                    TogglePane(ExplorerPane.AddressBar);
            }
            TogglePane(ExplorerPane.History);

        }

        private void SortBy(SHCOLUMNID pColumn, ViewSortDirection pDefaultSortOrder)
        {
            ViewSortDirection lSortOrder = pDefaultSortOrder;
            if (explorerBrowser1.Columns.SortBy == pColumn)
            {
                //toggle direction
                if (explorerBrowser1.Columns.SortDirection == ViewSortDirection.Ascending)
                    lSortOrder = ViewSortDirection.Descending;
                else
                    lSortOrder = ViewSortDirection.Ascending;
            }
            else
            {
                explorerBrowser1.Columns.SortBy = pColumn;
            }

            explorerBrowser1.Columns.SortDirection = lSortOrder;
        }

        private void NameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortBy(SHCOLUMNID.ShellColumnName, ViewSortDirection.Ascending);
        }

        private void DateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortBy(SHCOLUMNID.ShellColumnWriteTime, ViewSortDirection.Descending);
        }

        private void TypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortBy(SHCOLUMNID.ShellColumnType, ViewSortDirection.Ascending);
        }

        private void SortToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            nameToolStripMenuItem.Checked = explorerBrowser1.Columns.SortBy == SHCOLUMNID.ShellColumnName;
            dateToolStripMenuItem.Checked = explorerBrowser1.Columns.SortBy == SHCOLUMNID.ShellColumnWriteTime;
            typeToolStripMenuItem.Checked = explorerBrowser1.Columns.SortBy == SHCOLUMNID.ShellColumnType;
        }




        ItemIdList m_Root = null;        
        private void explorerBrowser1_NavigationPending(object sender, FolderChangingEventArgs e)
        {
            if (ItemIdList.IsNullOrInvalid(m_Root))
                return;

            e.Cancel = !e.FolderIdList.IsSearchFolder && !(m_Root.IsParentOf(e.FolderIdList));

        }

        private void restrictAccessToCurrentFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string msgDefault = "Restrict access to current folder";
            const string msgRestricted = "Restricted to ";

            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            if (((ToolStripMenuItem)sender).Checked)
            {
                m_Root = explorerBrowser1.FolderIdList;
                ((ToolStripMenuItem)sender).Text = msgRestricted + m_Root.Caption;
            }
            else
            {
                m_Root = null;
                ((ToolStripMenuItem)sender).Text = msgDefault;
            }
        }

        private void selectionCheckboxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectionCheckboxesToolStripMenuItem.Checked = !selectionCheckboxesToolStripMenuItem.Checked;
            if (selectionCheckboxesToolStripMenuItem.Checked)
            {
                explorerBrowser1.CheckMode = CheckMode.AutoSelect;
            }
            else
            {
                explorerBrowser1.CheckMode = CheckMode.None;
            }
            
        }
    }
}
