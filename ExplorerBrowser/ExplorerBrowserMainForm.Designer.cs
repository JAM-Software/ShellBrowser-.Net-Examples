namespace ExplorerBrowser
{
    partial class ExplorerBrowserMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerBrowserMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.myComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesystemOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumboIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filteringAllowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupingAllowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerBrowser1 = new Jam.Shell.ExplorerBrowser();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBrowser1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton3,
            this.checkboxesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myComputerToolStripMenuItem,
            this.desktopToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.controlPanelToolStripMenuItem,
            this.allTasksToolStripMenuItem,
            this.chooseToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(53, 19);
            this.toolStripDropDownButton1.Text = "Folder";
            // 
            // myComputerToolStripMenuItem
            // 
            this.myComputerToolStripMenuItem.Name = "myComputerToolStripMenuItem";
            this.myComputerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.myComputerToolStripMenuItem.Text = "My Computer";
            this.myComputerToolStripMenuItem.Click += new System.EventHandler(this.myComputerToolStripMenuItem_Click);
            // 
            // desktopToolStripMenuItem
            // 
            this.desktopToolStripMenuItem.Name = "desktopToolStripMenuItem";
            this.desktopToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.desktopToolStripMenuItem.Text = "Desktop";
            this.desktopToolStripMenuItem.Click += new System.EventHandler(this.desktopToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.windowsToolStripMenuItem.Text = "Windows";
            this.windowsToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // controlPanelToolStripMenuItem
            // 
            this.controlPanelToolStripMenuItem.Name = "controlPanelToolStripMenuItem";
            this.controlPanelToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.controlPanelToolStripMenuItem.Text = "Control Panel";
            this.controlPanelToolStripMenuItem.Click += new System.EventHandler(this.controlPanelToolStripMenuItem_Click);
            // 
            // allTasksToolStripMenuItem
            // 
            this.allTasksToolStripMenuItem.Name = "allTasksToolStripMenuItem";
            this.allTasksToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.allTasksToolStripMenuItem.Text = "AllTasks";
            this.allTasksToolStripMenuItem.Click += new System.EventHandler(this.allTasksToolStripMenuItem_Click);
            // 
            // chooseToolStripMenuItem
            // 
            this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            this.chooseToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.chooseToolStripMenuItem.Text = "Choose...";
            this.chooseToolStripMenuItem.Click += new System.EventHandler(this.chooseToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressBarToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.searchBoxToolStripMenuItem,
            this.navigationToolStripMenuItem,
            this.previewToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.detailsToolStripMenuItem1});
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(51, 19);
            this.toolStripDropDownButton2.Text = "Panes";
            this.toolStripDropDownButton2.DropDownOpened += new System.EventHandler(this.toolStripDropDownButton2_DropDownOpened);
            // 
            // addressBarToolStripMenuItem
            // 
            this.addressBarToolStripMenuItem.Name = "addressBarToolStripMenuItem";
            this.addressBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addressBarToolStripMenuItem.Text = "AddressBar";
            this.addressBarToolStripMenuItem.Click += new System.EventHandler(this.addressBarToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // searchBoxToolStripMenuItem
            // 
            this.searchBoxToolStripMenuItem.Name = "searchBoxToolStripMenuItem";
            this.searchBoxToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.searchBoxToolStripMenuItem.Text = "SearchBox";
            this.searchBoxToolStripMenuItem.Click += new System.EventHandler(this.searchBoxToolStripMenuItem_Click);
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.navigationToolStripMenuItem.Text = "Navigation";
            this.navigationToolStripMenuItem.Click += new System.EventHandler(this.navigationToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commandsToolStripMenuItem.Text = "Commands";
            this.commandsToolStripMenuItem.Click += new System.EventHandler(this.commandsToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem1
            // 
            this.detailsToolStripMenuItem1.Name = "detailsToolStripMenuItem1";
            this.detailsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.detailsToolStripMenuItem1.Text = "Details";
            this.detailsToolStripMenuItem1.Click += new System.EventHandler(this.detailsToolStripMenuItem1_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.foldersToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.hiddenToolStripMenuItem,
            this.filesystemOnlyToolStripMenuItem,
            this.setFilterToolStripMenuItem});
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(46, 19);
            this.toolStripDropDownButton4.Text = "Filter";
            this.toolStripDropDownButton4.DropDownOpened += new System.EventHandler(this.toolStripDropDownButton4_DropDownOpened);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // foldersToolStripMenuItem
            // 
            this.foldersToolStripMenuItem.Name = "foldersToolStripMenuItem";
            this.foldersToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.foldersToolStripMenuItem.Text = "Folders";
            this.foldersToolStripMenuItem.Click += new System.EventHandler(this.foldersToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.networkToolStripMenuItem.Text = "Network";
            this.networkToolStripMenuItem.Click += new System.EventHandler(this.networkToolStripMenuItem_Click);
            // 
            // hiddenToolStripMenuItem
            // 
            this.hiddenToolStripMenuItem.Name = "hiddenToolStripMenuItem";
            this.hiddenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.hiddenToolStripMenuItem.Text = "Hidden";
            this.hiddenToolStripMenuItem.Click += new System.EventHandler(this.hiddenToolStripMenuItem_Click);
            // 
            // filesystemOnlyToolStripMenuItem
            // 
            this.filesystemOnlyToolStripMenuItem.Name = "filesystemOnlyToolStripMenuItem";
            this.filesystemOnlyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.filesystemOnlyToolStripMenuItem.Text = "Filesystem only";
            this.filesystemOnlyToolStripMenuItem.Click += new System.EventHandler(this.filesystemOnlyToolStripMenuItem_Click);
            // 
            // setFilterToolStripMenuItem
            // 
            this.setFilterToolStripMenuItem.Name = "setFilterToolStripMenuItem";
            this.setFilterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.setFilterToolStripMenuItem.Text = "txt files only";
            this.setFilterToolStripMenuItem.Click += new System.EventHandler(this.setFilterToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.singleSelectionToolStripMenuItem,
            this.filteringAllowedToolStripMenuItem,
            this.groupingAllowedToolStripMenuItem,
            this.headerToolStripMenuItem,
            this.extendedTilesToolStripMenuItem,
            this.columnsToolStripMenuItem,
            this.sortToolStripMenuItem});
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(62, 19);
            this.toolStripDropDownButton3.Text = "Options";
            this.toolStripDropDownButton3.DropDownOpened += new System.EventHandler(this.toolStripDropDownButton3_DropDownOpened);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.largeIconsToolStripMenuItem,
            this.jumboIconsToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.contentToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownOpened += new System.EventHandler(this.viewToolStripMenuItem_DropDownOpened);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.smallIconsToolStripMenuItem.Text = "Small Icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.largeIconsToolStripMenuItem.Text = "Large Icons";
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.largeIconsToolStripMenuItem_Click);
            // 
            // jumboIconsToolStripMenuItem
            // 
            this.jumboIconsToolStripMenuItem.Name = "jumboIconsToolStripMenuItem";
            this.jumboIconsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.jumboIconsToolStripMenuItem.Text = "Jumbo Icons";
            this.jumboIconsToolStripMenuItem.Click += new System.EventHandler(this.jumboIconsToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.contentToolStripMenuItem.Text = "Content";
            this.contentToolStripMenuItem.Click += new System.EventHandler(this.contentToolStripMenuItem_Click);
            // 
            // singleSelectionToolStripMenuItem
            // 
            this.singleSelectionToolStripMenuItem.Name = "singleSelectionToolStripMenuItem";
            this.singleSelectionToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.singleSelectionToolStripMenuItem.Text = "SingleSelection";
            this.singleSelectionToolStripMenuItem.Click += new System.EventHandler(this.singleSelectionToolStripMenuItem_Click);
            // 
            // filteringAllowedToolStripMenuItem
            // 
            this.filteringAllowedToolStripMenuItem.Name = "filteringAllowedToolStripMenuItem";
            this.filteringAllowedToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.filteringAllowedToolStripMenuItem.Text = "Filtering allowed in column header";
            this.filteringAllowedToolStripMenuItem.Click += new System.EventHandler(this.filteringAllowedToolStripMenuItem_Click);
            // 
            // groupingAllowedToolStripMenuItem
            // 
            this.groupingAllowedToolStripMenuItem.Name = "groupingAllowedToolStripMenuItem";
            this.groupingAllowedToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.groupingAllowedToolStripMenuItem.Text = "Grouping available in context menu";
            this.groupingAllowedToolStripMenuItem.Click += new System.EventHandler(this.groupingAllowedToolStripMenuItem_Click);
            // 
            // headerToolStripMenuItem
            // 
            this.headerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headerOnToolStripMenuItem,
            this.headerOffToolStripMenuItem,
            this.headerAutoToolStripMenuItem});
            this.headerToolStripMenuItem.Name = "headerToolStripMenuItem";
            this.headerToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.headerToolStripMenuItem.Text = "Show Header";
            this.headerToolStripMenuItem.DropDownOpened += new System.EventHandler(this.headerToolStripMenuItem_DropDownOpened);
            // 
            // headerOnToolStripMenuItem
            // 
            this.headerOnToolStripMenuItem.Name = "headerOnToolStripMenuItem";
            this.headerOnToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.headerOnToolStripMenuItem.Text = "On";
            this.headerOnToolStripMenuItem.Click += new System.EventHandler(this.headerOnToolStripMenuItem_Click);
            // 
            // headerOffToolStripMenuItem
            // 
            this.headerOffToolStripMenuItem.Name = "headerOffToolStripMenuItem";
            this.headerOffToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.headerOffToolStripMenuItem.Text = "Off";
            this.headerOffToolStripMenuItem.Click += new System.EventHandler(this.headerOffToolStripMenuItem_Click);
            // 
            // headerAutoToolStripMenuItem
            // 
            this.headerAutoToolStripMenuItem.Name = "headerAutoToolStripMenuItem";
            this.headerAutoToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.headerAutoToolStripMenuItem.Text = "Auto";
            this.headerAutoToolStripMenuItem.Click += new System.EventHandler(this.headerAutoToolStripMenuItem_Click);
            // 
            // extendedTilesToolStripMenuItem
            // 
            this.extendedTilesToolStripMenuItem.Name = "extendedTilesToolStripMenuItem";
            this.extendedTilesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.extendedTilesToolStripMenuItem.Text = "Extended Tiles";
            this.extendedTilesToolStripMenuItem.Click += new System.EventHandler(this.extendedTilesToolStripMenuItem_Click);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.columnsToolStripMenuItem.Text = "Columns...";
            this.columnsToolStripMenuItem.Click += new System.EventHandler(this.columnsToolStripMenuItem_Click);
            // 
            // checkboxesToolStripMenuItem
            // 
            this.checkboxesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offToolStripMenuItem,
            this.onToolStripMenuItem});
            this.checkboxesToolStripMenuItem.Name = "checkboxesToolStripMenuItem";
            this.checkboxesToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.checkboxesToolStripMenuItem.Text = "Checkboxes";
            this.checkboxesToolStripMenuItem.DropDownOpened += new System.EventHandler(this.checkboxesToolStripMenuItem_DropDownOpened);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.offToolStripMenuItem.Text = "off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.onToolStripMenuItem.Text = "on";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // explorerBrowser1
            // 
            this.explorerBrowser1.AutoCheckSelect = false;
            this.explorerBrowser1.BackColor = System.Drawing.SystemColors.Window;
            this.explorerBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerBrowser1.Location = new System.Drawing.Point(0, 26);
            this.explorerBrowser1.Name = "explorerBrowser1";
            this.explorerBrowser1.Path = "Dieser PC";
            this.explorerBrowser1.Size = new System.Drawing.Size(919, 459);
            this.explorerBrowser1.TabIndex = 0;
            this.explorerBrowser1.ThumbnailSize = 48;
            this.explorerBrowser1.VisiblePanes = ((Jam.Shell.ExplorerPane)(((((((Jam.Shell.ExplorerPane.Commands | Jam.Shell.ExplorerPane.CommandsOrganize) 
            | Jam.Shell.ExplorerPane.CommandsView) 
            | Jam.Shell.ExplorerPane.Navigation) 
            | Jam.Shell.ExplorerPane.AddressBar) 
            | Jam.Shell.ExplorerPane.SearchEdit) 
            | Jam.Shell.ExplorerPane.History)));
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.typeToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.DropDownOpening += new System.EventHandler(this.SortToolStripMenuItem_DropDownOpening);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.NameToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.DateToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.typeToolStripMenuItem.Text = "Type";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.TypeToolStripMenuItem_Click);
            // 
            // ExplorerBrowserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 485);
            this.Controls.Add(this.explorerBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExplorerBrowserMainForm";
            this.Text = "ExplorerBrowser sample";
            this.Load += new System.EventHandler(this.ExplorerBrowserMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBrowser1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Jam.Shell.ExplorerBrowser explorerBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem myComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem addressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiddenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesystemOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumboIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filteringAllowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupingAllowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headerOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headerOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headerAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendedTilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkboxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
    }
}

