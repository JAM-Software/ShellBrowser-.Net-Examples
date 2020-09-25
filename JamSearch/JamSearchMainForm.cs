using System;
using System.Windows.Forms;
using Jam.Shell;
using System.IO;
namespace JamSearch
{
    public partial class JamSearchMainForm : Form
    {
        public JamSearchMainForm()
        {
            InitializeComponent();
            comboSelectAccess.SelectedIndex = 0;
            dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-1);
            searchResults.SizeOrCountRefreshed += new EventHandler<EventArgs>(searchResults_ItemListChanged);
        }

        internal readonly ShellBrowser shellBrowser = new ShellBrowser();

        /// <summary>
        /// The event-handle is kept here to also handle the next searches correctly
        /// </summary>
        private EventHandler<FileMatchEventArgs> fileMatchEventHandler;

        /// <summary>
        /// provide on-access to our selfdefined file matching handler that extends the
        /// search filter.
        /// </summary>
        private EventHandler<FileMatchEventArgs> FileMatchEventHandler
        {
            get
            {
                if (fileMatchEventHandler == null)
                    fileMatchEventHandler = new EventHandler<FileMatchEventArgs>(searchResults_SearchFileMatches);

                return fileMatchEventHandler;
            }
        }

        /// <summary>
        /// The user starts a search, after he specified severeal options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttStartSearch_Click(object sender, EventArgs e)
        {
            searchResults.AutomaticRefresh = false;
            m_searchCompleted = false;
            
            string[] searchPaths;
            shellBrowser.FolderIdList = shellComboBox1.CurrentFolderIdList;

            if (shellBrowser.SpecialFolder == ShellFolder.Drives)
            {
                //the user selected the Drives folder in the combobox. search all drives
                searchPaths = Environment.GetLogicalDrives();
            }
            else
            {
                //the default situation: a single folder is searched
                searchPaths = new string[] { shellBrowser.Folder };
            }

            SearchOptions searchOptions = new SearchOptions();

            //set the search options in the searchable FileList control...
            searchResults.SearchOptions = searchOptions;

            #region Options of the first tab

            //set the filter pattern
            if (textBoxSearchPattern.Text.Length == 0)
                textBoxSearchPattern.Text = "*";

            searchOptions.Filter = textBoxSearchPattern.Text;
            //wether the user selected recursive searching...
            searchOptions.RecursiveSearch = checkBoxRecursive.Checked;
            
            #endregion

            #region Options of the second tab

            if (radioButtonFindSpecificallyAccessedFiles.Checked) // in case the user wants to find files within a specific datetime interval
            {
                DateTimeInterval searchInterval = null;

                //the datetime picker also return the time of day, set it to 0:00/23:59 respectively
                DateTime lFrom = new DateTime(
                            dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0, 0, 0);
                DateTime lUntil = new DateTime(
                            dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 23, 59, 59);

                if (checkBoxAfter.Checked && checkBoxBefore.Checked)
                {
                    try
                    {
                        searchInterval =
                            new DateTimeInterval(lFrom, lUntil);
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show(
                            "The time interval you specified would definitively an empty search result", 
                            "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (checkBoxAfter.Checked)
                {
                    searchInterval =
                        new DateTimeInterval(lFrom, true);
                }
                else if (checkBoxBefore.Checked)
                {

                    searchInterval =
                        new DateTimeInterval(lUntil, false);
                }
                
                //now determine which access time are restricted (all three are actually possible)
                switch (comboSelectAccess.SelectedIndex) 
                {
                    case 2: //created
                        searchOptions.CreationInterval = searchInterval;
                        break;
                    case 1: //accessed
                        searchOptions.AccessInterval = searchInterval;
                        break;
                    default:
                    case 0: //modified
                        searchOptions.LastWriteInterval = searchInterval;
                        break;
                }
            }

            #endregion

            #region Options of the third tab

            //show only files ?
            searchOptions.FilesOnly = !checkBoxShowFolders.Checked;

            //ignore case ?
            searchOptions.FilterIgnoreCase = !checkBoxCaseSensitiveWildcards.Checked;

            //The user specified a minimum size or maximum size
            if (checkBoxNoLessThanKiB.Checked || checkBoxNoMoreThanKiB.Checked)
            {
                //we further extend the filter of the search algorithm:
                searchResults.SearchFileMatches += FileMatchEventHandler;
            }

            #endregion

            //clear the listview
            searchResults.Clear();
            toolStripStatusSizeAndCount.Text = "Searching...";
            searchResults.SortColumn = -1;

            //start to search            
            try
            {
                //the recursive search provides a rough estimation of search progress, so use it
                if (searchOptions.RecursiveSearch)
                {
                    searchResults.Search(searchPaths, true);
                    SearchProgressBar.Visible = true;
                }
                else
                {
                    searchResults.Search(searchPaths);
                }

                //show the user the tools' changed state
                buttStartSearch.Enabled = false;
                buttStopSearch.Enabled = true;
                buttStopSearch.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "An exception occurred upon search initialization", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// extend the search filtering criterion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void searchResults_SearchFileMatches(object sender, FileMatchEventArgs e)
        {
            if (!e.FileMatchesSearchCriterion) // in case we are within an event chain, break early.
                return;                        // this does not happen for this example.

            FileInfo fileInfo = new FileInfo(e.File);

            //here we check for the filesize
            bool fileMatches = true;

            try
            {
                if (checkBoxNoMoreThanKiB.Checked)
                {
                    fileMatches &= fileInfo.Length <= (numericNotGreaterThan.Value * 1024);
                }
                if (checkBoxNoLessThanKiB.Checked)
                {
                    fileMatches &= fileInfo.Length >= (numericNoLessThan.Value * 1024);
                }
            }
            catch (FileNotFoundException)
            { 
                //the file does not exist, this happens e.g. if a *directory* is passed
                //you can of course handle this case accordingly in your own code
            } 

            //return wether the file matches the search criterion
            e.FileMatchesSearchCriterion = fileMatches;

            if (fileMatches && ShellControlConnector != null)
            {
                this.Invoke( uiDelegate ,new object[]{e.File});
                //the above Invoke calls the function below from the ui thread
                //ShellControlConnector.SelectionList.AddPathToSelection(e.File);
            }
        }

        private void buttStopSearch_Click(object sender, EventArgs e)
        {
            searchResults.SearchCancel();
            searchResults.AutomaticRefresh = true;
        }

        internal int lastTickCount = 0;
        private const string cSearchingIn = "Searching in ";

        /// <summary>
        /// let the user know where the search engine is currently working
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchResults_SearchProgressChanged(object sender, SearchProgressChangedEventArgs e)
        {
            if (!toolStripStatusLabel1.Text.Equals(cSearchingIn + e.CurrentFolder))
            {
                if (System.Environment.TickCount - lastTickCount > 250)
                {   //only refresh every 250ms
                    toolStripStatusLabel1.Text = cSearchingIn + e.CurrentFolder;
                    lastTickCount = System.Environment.TickCount;
                }
            }
            SearchProgressBar.Value = e.PercentageEstimated;
        }

        private bool m_searchCompleted;

        /// <summary>
        /// The search completed. Either successfully, cancelled by the user, or due to an exception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchResults_SearchCompleted(object sender, SearchCompletedEventArgs e)
        {
            //remove the filematching eventhandler if specified, see buttStartSearch_Click
            searchResults.SearchFileMatches -= FileMatchEventHandler;
            
            buttStopSearch.Enabled = false;
            buttStartSearch.Enabled = true;
            
            //reset the progress indicator
            SearchProgressBar.Visible = false;
            SearchProgressBar.Value = 0;
                        
            //the search was cancelled by the user
            if (e.Cancelled)
            {
                toolStripStatusLabel1.Text = "The search operation was cancelled by the user.";
                return;
            }
            else
                toolStripStatusLabel1.Text = string.Empty;

            m_searchCompleted = true;

            //an error/exception occurred during the search, inform the user
            if (e.Error != null)
            {
                string errString = "An Error occurred: " + e.Error.Message;
                MessageBox.Show(errString, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabel1.Text = errString;
            }
            //all went ok, the search is complete
            else
                toolStripStatusSizeAndCount.Text = "Found " + searchResults.Items.Count + " objects. ";

            searchResults.AutomaticRefresh = true;
        }

        /// <summary>
        /// here you can filter out exceptions during search! if the exception for a specific
        /// file was handled accordingly the search continues.
        /// otherwise it is cancelled and a SearchCompleted event occurs which reports the error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchResults_SearchExceptionOccurred(object sender, SearchExceptionEventArgs e)
        {
            //ignore files/folders we do not have access to like "System Volume Information"
            if (!((e.Exception is UnauthorizedAccessException) || e.Exception is PathTooLongException)) 
            {
                //for all other exceptions make the search thread cancel, the exception can be handled in SearchCompleted.
                e.ExceptionPermanent = true;
            }
        }

        private void buttBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();
            if (dlgResult == DialogResult.OK)
                shellComboBox1.SelectedPath = folderBrowserDialog1.SelectedPath;
        }

        private void radioButtonFindSpecificallyAccessedFiles_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAfter.Enabled =
            checkBoxBefore.Enabled =
            dateTimePicker2.Enabled =
            dateTimePicker1.Enabled =
            comboSelectAccess.Enabled =
                radioButtonFindSpecificallyAccessedFiles.Checked;
        }

        private void checkBoxKiB_CheckedChanged(object sender, EventArgs e)
        {
            numericNoLessThan.Enabled = checkBoxNoLessThanKiB.Checked;
            numericNotGreaterThan.Enabled = checkBoxNoMoreThanKiB.Checked;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if the user hits the enter key, immediately start/stop the search
            if (e.KeyCode == Keys.Enter)
            {
                if (buttStartSearch.Enabled)
                    buttStartSearch_Click(null, null);
                else
                    buttStopSearch_Click(null, null);
            }
        }

        private void searchResults_ItemListChanged(object sender, EventArgs e)
        {
            if (!m_searchCompleted)
                toolStripStatusSizeAndCount.Text = "Found " + searchResults.Items.Count + " matching objects.";
        }


        #region extensions for integration into the JamExplorer example

        /// <summary>
        /// The calling delegate for the possibility to update from within the 
        /// user interface thread.
        /// </summary>
        /// <param name="path"></param>
        delegate void UIAddPathToSelection(string path);

        private ShellControlConnector m_ShellControlConnector;

        UIAddPathToSelection uiDelegate; 

        /// <summary>
        /// Assign this property if the files found should be added to the SelectionList of 
        /// the shellcontrolconnector that acts as a mediator. This allows showing the 
        /// items as with checkboxes in the <see cref="ShellTreeView"/> and <see cref="ShellListView"/>,
        /// for reference see the JamExplorer example.
        /// </summary>
        public ShellControlConnector ShellControlConnector
        {
            get { return m_ShellControlConnector; }
            set
            { 
                m_ShellControlConnector = value;
                if (m_ShellControlConnector != null)
                {
                    uiDelegate = new UIAddPathToSelection(m_ShellControlConnector.SelectionList.Add);
                    //you could also call "AddPathToSelection" in that case however 
                    //the calculate and size update makes things very slow:
                    //uiDelegate = new UIAddPathToSelection(m_ShellControlConnector.SelectionList.AddPathToSelection);
                }
                else
                {
                    //in case the connector is reset to null
                    uiDelegate = new UIAddPathToSelection(EmptyMethod);
                }
            }
        }

        private void EmptyMethod(string param) { }

        public string SearchPath
        {
            get
            {
                return shellComboBox1.SelectedPath;
            }
            set
            {
                shellComboBox1.SelectedPath = value;
            }
        }

        #endregion

        private void searchResults_BeforeShellCommand(object sender, BeforeShellCommandEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Verb);
        }
    }
}