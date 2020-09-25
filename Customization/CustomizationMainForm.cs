using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jam.Samples.Customization
{
    public partial class CustomizationMainForm : Form
    {
        private enum Example
        {
            CustomColumns,
            CustomIcons,
            CustomThumbnails
        }

        private Dictionary<Example, IExampleForm> SubForms;  

        public CustomizationMainForm()
        {
            InitializeComponent();
        }

        private void ShowCustomColumns()
        {

        }

        private void ShowForm(Example pExample)
        {
            if (panel1.Controls.Count > 0)
                panel1.Controls[0].Parent = null;

            IExampleForm lSource = SubForms[pExample];
            lSource.GetMainPanel().Parent = panel1;
            lSource.GetMainPanel().Dock = DockStyle.Fill;
            textBoxDescription.Text = lSource.GetDescription();

        }

        private void radioButtonCustomColumns_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomColumns.Checked)
                ShowForm(Example.CustomColumns);
        }

        private void radioButtonCustomImages_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomImages.Checked)
                ShowForm(Example.CustomIcons);

        }

        private void CustomizationMainForm_Load(object sender, EventArgs e)
        {
            SubForms = new Dictionary<Example, IExampleForm>()
            {
                [Example.CustomColumns] = new CustomColumns(),
                [Example.CustomIcons] = new CustomIcons(),
                [Example.CustomThumbnails] = new CustomThumbnails()
            };

        }

        private void radioButtonCustomThumbs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomThumbs.Checked)
                ShowForm(Example.CustomThumbnails);
        }
    }

    public interface IExampleForm
    {
        ScrollableControl GetMainPanel();
        string GetDescription();

    }
}
