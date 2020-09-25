using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jam.Shell;

namespace Jam.Explorer
{
    public partial class FileListForm : Form
    {
        /// <summary>
        /// Access the filelist component publicly
        /// </summary>
        public FileList FileList
        {
            get
            {
                return this.fileList1;
            }
        }

        /// <summary>
        /// A setter to display the total size retrieved from the 
        /// shellControlConnector selection list.
        /// </summary>
        public long TotalSize
        {
            set
            {
                label1.Text =
                    String.Format("Total size: {0} kb", value >> 10);
            }
        }

        public string TotalSizeDisabled
        {
            set
            {
                label1.Text = value;
            }
        }

        public FileListForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is called if one of the toolstrip items is clicked to switch the views.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnViewToolStripMenuItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == null)
                return;

            toolstripViewDetails.Checked =
            toolstripViewIcons.Checked =
            toolstripViewLargeIcons.Checked = 
            toolstripViewTile.Checked =
            toolstripViewList.Checked = 
            toolstripViewThumbnails.Checked = false;

            item.Checked = true;

            if (item == toolstripViewThumbnails)
            {
                fileList1.ViewState = ViewState.Thumbnails;
            }
            else if (item == toolstripViewTile)
            {
                fileList1.ViewState = ViewState.Tile;
            }
            else if (item == toolstripViewIcons)
            {
                fileList1.ViewState = ViewState.SmallIcons;
            }
            else if (item == toolstripViewLargeIcons)
            {
                fileList1.ViewState = ViewState.LargeIcons;
            }
            else if (item == toolstripViewDetails)
            {
                fileList1.ViewState = ViewState.Details;
            }
            else if (item == toolstripViewList)
            {
                fileList1.ViewState = ViewState.List;
            }
        }

        /// <summary>
        /// This method is called if the user enabled the extra large icons in vista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnToolstripViewExtraLargeIconsClick(object sender, EventArgs e)
        {
            fileList1.ShowExtraLargeIcons = toolstripViewExtraLargeIcons.Checked;
        }
    }
}