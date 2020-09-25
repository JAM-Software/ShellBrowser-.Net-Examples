using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jam.Samples.Customization
{
    public partial class CustomThumbnails : UserControl, IExampleForm
    {
        private static string cInfo = "Modifiying thumbnails" + Environment.NewLine + Environment.NewLine +
                                      "When the ShellListView displays thumbnails, it will raise the \"ThumbnailUpdated\" event for every item in the list. " +
                                      "The passed thumbnail can either be replaced or modified.";
        public CustomThumbnails()
        {
            InitializeComponent();
        }

        public string GetDescription()
        {
            return cInfo;
        }

        public ScrollableControl GetMainPanel()
        {
            return this;
        }

        /// <summary>Draws the initial letters into the thumbnail .</summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">Thumbnail updated event information.</param>
        private void shellListView1_ThumbnailUpdated(object sender, Shell.ThumbnailUpdatedEventArgs e)
        {
            string lName = e.Item.AbsoluteItemIdList.Name;
            if (String.IsNullOrEmpty(lName))
                lName = e.Item.Text;
            if (String.IsNullOrEmpty(lName))
                return;

            string lInitialLetter = lName.Substring(0, 1).ToUpper();
            using (Font f = new Font(FontFamily.GenericSansSerif, 14f, FontStyle.Bold))
            using (Graphics g = Graphics.FromImage(e.Thumbnail))
            { 
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                g.DrawString(lInitialLetter, f, Brushes.Black, 10, 10);
            }
            
        }
    }
}
