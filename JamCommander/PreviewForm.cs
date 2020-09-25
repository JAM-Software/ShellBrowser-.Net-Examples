using Jam.Shell;
using System;
using System.Windows.Forms;

namespace JamCommander
{
    public partial class PreviewForm : Form
    {
        public ShellFilePreview FilePreview
        {
            get { return filePreview; }
            set { filePreview = value;  }
        }

        public PreviewForm()
        {
            InitializeComponent();
        }

        private void PreviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //avoid recreating the Preview everytime, and just keep re-using the form.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void PreviewForm_VisibleChanged(object sender, EventArgs e)
        {
            //disabling the preview when not visible will make the Preview keep track of the current file without loading the Preview.
            FilePreview.Enabled = Visible;
        }
    }
}
