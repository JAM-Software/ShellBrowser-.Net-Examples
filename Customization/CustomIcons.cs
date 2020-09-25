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
    public partial class CustomIcons : UserControl, IExampleForm
    {
        private static string cInfo =
            "Per default, the ShellTreeView and ShellListView display icons from the system imagelist. " +
            Environment.NewLine +
            "To use custom icons, assign an ImageList containing the icons to the \"CustomImages\" property of the ShellTreeView, or the \"SmallCustomImages\" and \"LargeCustomImages\" of the ShellListView." +
            Environment.NewLine + Environment.NewLine +
            "To set images on items or nodes, the \"ShellTreeView.AddTreeNode\" and \"ShellListView.AddItem\" events were implemented. In this example the ShellTree's root nodes were given custom images. " +
            "The ShellList uses custom icons for text files." + Environment.NewLine +
            "Note, that custom icons work in all viewstyles of the ShellListView.";
        public CustomIcons()
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

        private void CustomIcons_Load(object sender, EventArgs e)
        {
            shellTreeView1.ClearRoots();
            shellTreeView1.AddRoot(ShellFolder.Drives);
            shellTreeView1.AddRoot(ShellFolder.UsersFiles);
            shellTreeView1.AddRoot(ShellFolder.MyMusic);
            shellTreeView1.AddRoot(ShellFolder.MyVideo);
            shellTreeView1.AddRoot(ShellFolder.MyPictures);

        }

        /// <summary>Event handler. Called by shellTreeView1 when a treenode is added. 
        ///  It sets the ImageIndex and SelectedImageIndex to use images that have been added to the ImageList that has been assigned to the <see cref="ShellTreeView.CustomImages"/> property.</summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">Holds information on the TreeNode.</param>
        private void shellTreeView1_AddTreeNode(object sender, AddTreeNodeEventArgs e)
        {
            // The following code removes the Icon for root nodes.
            // if (e.ParentNode == null) 
            // {
            //     e.Node.ImageIndex = e.Node.SelectedImageIndex = shellTreeView1.EmptyIconIndex;
            //     return;
            // }

            switch (e.Node.SpecialFolder)
            {
                case ShellFolder.Desktop:
                case ShellFolder.DesktopDirectory:
                    e.Node.ImageIndex = e.Node.SelectedImageIndex =
                        shellTreeView1.ImageList.Images.IndexOfKey("desktop.png");
                    break;
                case ShellFolder.Drives:
                    e.Node.ImageIndex = e.Node.SelectedImageIndex =
                        shellTreeView1.ImageList.Images.IndexOfKey("monitor.png");
                    break;

                case ShellFolder.UsersFiles:
                    e.Node.ImageIndex = e.Node.SelectedImageIndex =
                        shellTreeView1.ImageList.Images.IndexOfKey("user.png");
                    break;
                case ShellFolder.Network:
                    e.Node.ImageIndex = e.Node.SelectedImageIndex =
                        shellTreeView1.ImageList.Images.IndexOfKey("folder_network.png");
                    break;
                case ShellFolder.Documents:
                case ShellFolder.Personal:
                case ShellFolder.DocumentsLibrary:
                    e.Node.ImageIndex = e.Node.SelectedImageIndex =
                        shellTreeView1.ImageList.Images.IndexOfKey("folder_document.png");
                    break;
                case ShellFolder.CommonMusic:
                case ShellFolder.MusicLibrary:
                case ShellFolder.MyMusic:
                    e.Node.ImageIndex = e.Node.SelectedImageIndex =
                        shellTreeView1.ImageList.Images.IndexOfKey("folder_music.png");
                    break;
                case ShellFolder.VideosLibrary:
                case ShellFolder.CommonVideo:
                case ShellFolder.MyVideo:
                    e.Node.ImageIndex = e.Node.SelectedImageIndex =
                        shellTreeView1.ImageList.Images.IndexOfKey("folder_movie.png");
                    break;
                case ShellFolder.PicturesLibrary:
                case ShellFolder.MyPictures:
                case ShellFolder.CommonPictures:
                    e.Node.ImageIndex = e.Node.SelectedImageIndex =
                        shellTreeView1.ImageList.Images.IndexOfKey("flower.png");
                    break;
                default:
                    break;

            }
        }

        /// <summary>
        /// Eventhandler of the "AddItem" event. 
        /// It sets the ImageIndex of text files to an image that has been added to the "SmallCustomImages" and "LargeCustomImages" properties of the ShellListView.
        /// Note the usage of the "ActiveImageList" property: it refers to the currently used imagelist independently of the current viewstyle. 
        /// To make this work in all viewstyles, an image tagged "document_text.png" needs to be available in both image lists. 
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">Add item event information.</param>
        private void shellListView1_AddItem(object sender, AddItemEventArgs e)
        {
            if (System.IO.Path.GetExtension(e.Item.FullPath).ToUpper() == ".TXT")
            {
                e.Item.ImageIndex = shellListView1.ActiveImageList.Images.IndexOfKey("document_text.png");
            }

        }
    }
}
