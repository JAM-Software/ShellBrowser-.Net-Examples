using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jam.Shell;

namespace Jam.Samples.Customization
{
    public partial class CustomColumns : UserControl, IExampleForm
    {
        public CustomColumns()
        {
            InitializeComponent();
        }

        private static string cInfo = "This example shows how to add and fill custom columns easily." + Environment.NewLine +
                              Environment.NewLine
                              + "The CreatedColumns event is called every time the columns for a ShellListView are created, i.e. when opening a folder or doing a FullRefresh. " +
                              Environment.NewLine
                              + "You can either use it to display additional shell columns or to add custom columns. " +
                              Environment.NewLine
                              + "Shell columns are filled automatically." + Environment.NewLine
                              + "For custom columns values have to be provided in the AddItem EventHandler. In the example, 2 columns are added, the first custom column will be used for the path length and the second for the link target." +
                              Environment.NewLine
                              + "To fill the columns, we use the AddItem event handler. We retrieve the path length, the possible link target and add subitems containing these information to the currently added item.";



        string cPathLengthString = "Path Length";
        string cLinkTargetString = "Link Target";


        private void shellListView1_AddItem(object sender, Shell.AddItemEventArgs e)
        {
            // get the path length
            string lLength = e.Item.FullPath.Length.ToString();
            // add the path length as subitem
            e.Item.SubItems.Add(lLength);

            // check whether the item is a link
            // note: the next few lines are just used for illustrative purposes.
            // the retrieval of the link target may take some time for large file lists
            string lLinkTarget = ShellBrowser.GetLinkTarget(e.Item.FullPath);
            // add the link target as subitem (if it`s not a link, an empty string was returned)
            e.Item.SubItems.Add(lLinkTarget);

        }

        private void shellListView1_CreatedColumns(object sender, EventArgs e)
        {
            // add a column for the path length
            JamShellColumnHeader lCol = new JamShellColumnHeader();
            lCol.Text = cPathLengthString;
            lCol.TextAlign = HorizontalAlignment.Right;
            lCol.Width = 85;
            shellListView1.Columns.Add(lCol);

            // add a column for the link target
            lCol = new JamShellColumnHeader();
            lCol.Text = cLinkTargetString;
            // the link target is a full path so we need a large column
            lCol.Width = 350;
            shellListView1.Columns.Add(lCol);

        }

        public ScrollableControl GetMainPanel()
        {
            return this;
        }

        public string GetDescription()
        {
            return cInfo;
        }
    }
}
