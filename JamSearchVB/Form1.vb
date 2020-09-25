Imports Jam.Shell
Imports System.IO

Public Class Form1

    Friend ReadOnly m_shellBrowser As New ShellBrowser
    Friend m_lastTickCount As Integer = 0
    Private m_ShellControlConnector As ShellControlConnector
    Private m_SearchComplete

    'The event-handle is kept here to also handle the next searches correctly
    Private m_fileMatchEventHandler As EventHandler(Of FileMatchEventArgs)

    'The calling delegate for the possibility to update from within the user interface thread.
    Private Delegate Sub m_UIAddPathToSelection(ByVal path As String)
    Private uiDelegate As m_UIAddPathToSelection


    'The user starts a search, after he specified severeal options
    Private Sub OnButtonStartSearchClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttStartSearch.Click
        m_SearchComplete = False
        Dim searchPaths As String()
        Me.m_shellBrowser.FolderIdList = Me.shellComboBox1.CurrentFolderIdList
        If (Me.m_shellBrowser.SpecialFolder = ShellFolder.Drives) Then
            'the user selected the Drives folder in the combobox. search all drives
            searchPaths = Environment.GetLogicalDrives()
        Else
            'the default situation: a single folder is searched
            searchPaths = New String() {Me.m_shellBrowser.Folder}
        End If
        Dim searchOptions As New SearchOptions
        'set the search options in the searchable FileList control...
        Me.searchResults.SearchOptions = searchOptions
        If (Me.textBoxSearchPattern.Text.Length = 0) Then
            Me.textBoxSearchPattern.Text = "*"
        End If
        'set the filter pattern
        searchOptions.Filter = Me.textBoxSearchPattern.Text
        'whether the user selected recursive searching...
        searchOptions.RecursiveSearch = Me.checkBoxRecursive.Checked
        'in case the user wants to find files within a specific datetime interval
        If Me.radioButtonFindSpecificallyAccessedFiles.Checked Then
            Dim searchInterval As DateTimeInterval = Nothing
            If (Me.checkBoxAfter.Checked AndAlso Me.checkBoxBefore.Checked) Then
                Try
                    'the datetime picker also return the time of day, will set to 0:00
                    Dim date1 As New DateTime(Me.dateTimePicker1.Value.Year, Me.dateTimePicker1.Value.Month, Me.dateTimePicker1.Value.Day)
                    Dim date2 As New DateTime(Me.dateTimePicker2.Value.Year, Me.dateTimePicker2.Value.Month, Me.dateTimePicker2.Value.Day)
                    searchInterval = New DateTimeInterval(date1, date2)
                Catch exception1 As ArgumentException
                    MessageBox.Show("The time interval you specified would definitively produce an empty search result", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Return
                End Try
            ElseIf Me.checkBoxAfter.Checked Then
                searchInterval = New DateTimeInterval(Me.dateTimePicker1.Value, True)
            ElseIf Me.checkBoxBefore.Checked Then
                searchInterval = New DateTimeInterval(Me.dateTimePicker2.Value, False)
            End If
            'now determine which access time are restricted (all three are actually possible)
            Select Case Me.comboSelectAccess.SelectedIndex
                Case 0 'modified
                    searchOptions.LastWriteInterval = searchInterval
                Case 1 'accessed
                    searchOptions.AccessInterval = searchInterval
                Case 2 'created
                    searchOptions.CreationInterval = searchInterval
                Case Else 'default: modified
                    searchOptions.LastWriteInterval = searchInterval
            End Select
        End If
        'show only files ?
        searchOptions.FilesOnly = Not Me.checkBoxShowFolders.Checked
        'ignore case ?
        searchOptions.FilterIgnoreCase = Not Me.checkBoxCaseSensitiveWildcards.Checked
        'The user specified a minimum size or maximum size
        If (Me.checkBoxNoLessThanKiB.Checked OrElse Me.checkBoxNoMoreThanKiB.Checked) Then
            'we further extend the filter of the search algorithm:
            AddHandler Me.searchResults.SearchFileMatches, Me.FileMatchEventHandler
        End If
        'clear the listview
        Me.searchResults.Clear()
        'Set the Sorting to be unavailable until the search operation finished.
        Me.searchResults.Sorting = SortOrder.None
        Me.searchResults.HeaderStyle = ColumnHeaderStyle.Nonclickable
        'start to search 
        Try
            'the recursive search provides a rough estimation of search progress, so use it
            If searchOptions.RecursiveSearch Then
                Me.searchResults.Search(searchPaths, True)
                Me.SearchProgressBar.Visible = True
            Else
                Me.searchResults.Search(searchPaths)
            End If
            'show the user the tools' changed state
            Me.buttStartSearch.Enabled = False
            Me.buttStopSearch.Enabled = True
            Me.buttStopSearch.Focus()
        Catch exc As Exception
            MessageBox.Show(exc.Message, "An exception occurred upon search initialization", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
    End Sub

    'extend the search filtering criterion
    Private Sub searchResults_SearchFileMatches(ByVal sender As Object, ByVal e As FileMatchEventArgs) Handles searchResults.SearchFileMatches
        If e.FileMatchesSearchCriterion Then 'in case we are within an event chain, break early. This does not happen for this example.
            Dim fileMatches As Boolean = True
            'here we check for the filesize
            Try
                If Me.checkBoxNoMoreThanKiB.Checked Then
                    fileMatches = (fileMatches And (PathCollection.GetFileSize(e.File) < (Me.numericNotGreaterThan.Value * 1024)))
                End If
                If Me.checkBoxNoLessThanKiB.Checked Then
                    fileMatches = (fileMatches And (PathCollection.GetFileSize(e.File) > (Me.numericNoLessThan.Value * 1024)))
                End If
            Catch exception1 As FileNotFoundException
                'the file does not exist, this happens e.g. if a *directory* is passed
                'you can of course handle this case accordingly in your own code
            End Try
            'return wether the file matches the search criterion
            e.FileMatchesSearchCriterion = fileMatches
            If (fileMatches AndAlso (Not Me.ShellControlConnector Is Nothing)) Then
                MyBase.Invoke(Me.uiDelegate, New Object() {e.File})
                'the above Invoke calls the function below from the ui thread
                'ShellControlConnector.SelectionList.AddPathToSelection(e.File);
            End If
        End If
    End Sub

    Private Sub OnButtonStopSearchClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttStopSearch.Click
        Me.searchResults.SearchCancel()
    End Sub

    Private Sub OnButtonBrowseClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonBrowse.Click
        If (Me.folderBrowserDialog1.ShowDialog = DialogResult.OK) Then
            Me.shellComboBox1.SelectedPath = Me.folderBrowserDialog1.SelectedPath
        End If
    End Sub

    'let the user know where the search engine is currently working
    Private Sub OnSearchResultsSearchProgressChanged(ByVal sender As System.Object, ByVal e As Jam.Shell.SearchProgressChangedEventArgs) Handles searchResults.SearchProgressChanged
        If (Not Me.toolStripStatusLabel1.Text.Equals(e.CurrentFolder)) Then
            If ((Environment.TickCount - Me.m_lastTickCount) > 250) Then
                'only refresh every 250ms
                Me.toolStripStatusLabel1.Text = e.CurrentFolder
                Me.m_lastTickCount = Environment.TickCount
            End If
        End If
        Me.SearchProgressBar.Value = e.PercentageEstimated
    End Sub

    'The search completed. Either successfully, cancelled by the user, or due to an exception
    Private Sub OnSearchResultsSearchCompleted(ByVal sender As Object, ByVal e As SearchCompletedEventArgs) Handles searchResults.SearchCompleted
        m_SearchComplete = True
        'remove the filematching eventhandler if specified, see buttStartSearch_Click
        RemoveHandler Me.searchResults.SearchFileMatches, Me.FileMatchEventHandler
        Me.buttStopSearch.Enabled = False
        Me.buttStartSearch.Enabled = True
        'reset the progress indicator
        Me.SearchProgressBar.Visible = False
        Me.SearchProgressBar.Value = 0
        'allow sorting again
        Me.searchResults.HeaderStyle = ColumnHeaderStyle.Clickable
        'the search was cancelled by the user
        If e.Cancelled Then
            Me.toolStripStatusLabel1.Text = "The search operation was cancelled by the user."
        ElseIf (Not e.Error Is Nothing) Then
            'an error/exception occurred during the search, inform the user
            Dim errString As String = ("An Error occurred: " & e.Error.Message)
            MessageBox.Show(errString, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.toolStripStatusLabel1.Text = errString
        Else
            'all went ok, the search is complete
            Me.toolStripStatusLabel1.Text = "The search operation completed."
        End If
    End Sub

    'here you can filter out exceptions during search! if the exception for a specific
    'file was handled accordingly the search continues.
    'otherwise it is cancelled and a SearchCompleted event occurs which reports the error.
    Private Sub OnSearchResultsSearchExceptionOccurred(ByVal sender As Object, ByVal e As SearchExceptionEventArgs) Handles searchResults.SearchExceptionOccurred
        'ignore files/folders we do not have access to like "System Volume Information"
        If Not TypeOf e.Exception Is UnauthorizedAccessException Then
            'for all other exceptions make the search thread cancel, the exception can be handled in SearchCompleted.
            e.ExceptionPermanent = True
        End If
    End Sub

    Private Sub OnRadioButtonFindSpecificallyAccessedFilesCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonFindSpecificallyAccessedFiles.CheckedChanged
        Me.checkBoxAfter.Enabled = Me.radioButtonFindSpecificallyAccessedFiles.Checked
        Me.dateTimePicker2.Enabled = Me.checkBoxAfter.Enabled
        Me.checkBoxBefore.Enabled = Me.checkBoxAfter.Enabled
        Me.dateTimePicker1.Enabled = Me.checkBoxAfter.Enabled
        Me.comboSelectAccess.Enabled = Me.checkBoxAfter.Enabled
        Me.radioButtonFindSpecificallyAccessedFiles.Checked = Me.checkBoxAfter.Enabled
    End Sub

    Private Sub OnCheckBoxKiBCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxNoLessThanKiB.CheckedChanged, checkBoxNoMoreThanKiB.CheckedChanged
        Me.numericNoLessThan.Enabled = Me.checkBoxNoLessThanKiB.Checked
        Me.numericNotGreaterThan.Enabled = Me.checkBoxNoMoreThanKiB.Checked
    End Sub

    'if the user hits the enter key, immediately start/stop the search
    Private Sub OnForm1KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Return) Then
            If Me.buttStartSearch.Enabled Then
                Me.OnButtonStartSearchClick(Nothing, Nothing)
            Else
                Me.OnButtonStopSearchClick(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub OnSearchResultsItemListChanged(ByVal sender As Object, ByVal e As EventArgs) Handles searchResults.ItemListChanged, searchResults.SizeOrCountRefreshed
        If (Me.checkBoxShowFolders.Checked And Not m_SearchComplete) Then
            Me.toolStripStatusSizeAndCount.Text = String.Concat(New Object() {"Found ", searchResults.Items.Count, " matching objects."})
        Else
            Me.toolStripStatusSizeAndCount.Text = String.Concat(New Object() {Me.searchResults.TotalFileCount, " File", IIf((Me.searchResults.TotalFileCount <> 1), "s", ""), ", total size: ", (Me.searchResults.TotalFileSize >> 10), " KB"})
        End If
    End Sub

    Private Sub EmptyMethod(ByVal param As String)
    End Sub

    Public Property SearchPath() As String
        Get
            Return Me.shellComboBox1.SelectedPath
        End Get
        Set(ByVal value As String)
            Me.shellComboBox1.SelectedPath = value
        End Set
    End Property

    'Assign this property if the files found should be added to the SelectionList of 
    'the shellcontrolconnector that acts as a mediator. This allows showing the
    'items as with checkboxes in the "ShellTreeView" and "ShellListView",
    'for reference see the JamExplorer example.
    Public Property ShellControlConnector() As ShellControlConnector
        Get
            Return Me.m_ShellControlConnector
        End Get
        Set(ByVal value As ShellControlConnector)
            Me.m_ShellControlConnector = value
            If (Not Me.m_ShellControlConnector Is Nothing) Then
                Me.uiDelegate = New m_UIAddPathToSelection(AddressOf Me.m_ShellControlConnector.SelectionList.Add)
                'you could also call "AddPathToSelection" in that case however
                'the calculate and size update makes things very slow:
                'uiDelegate = New m_UIAddPathToSelection(m_ShellControlConnector.SelectionList.AddPathToSelection);
            Else
                'in case the connector is reset to null
                Me.uiDelegate = New m_UIAddPathToSelection(AddressOf Me.EmptyMethod)
            End If
        End Set
    End Property

    Private ReadOnly Property FileMatchEventHandler() As EventHandler(Of FileMatchEventArgs)
        Get
            If (Me.m_fileMatchEventHandler Is Nothing) Then
                Me.m_fileMatchEventHandler = New EventHandler(Of FileMatchEventArgs)(AddressOf Me.searchResults_SearchFileMatches)
            End If
            Return Me.m_fileMatchEventHandler
        End Get
    End Property

    Private Sub OnTextBoxSearchPatternKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxSearchPattern.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Me.OnButtonStartSearchClick(sender, e)
        End If
    End Sub
End Class