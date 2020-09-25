using Jam.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExplorerBrowser
{
    public partial class FormColumns : Form
    {
        public FormColumns()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Jam.Shell.ExplorerBrowser m_ExplorerBrowser;
        private bool m_IgnoreChecks;

        private void FillColumns()
        {
            checkedListBox1.Items.Clear();
            if (!ShellBrowser.IsVistaOrLater) //Columns are not supported in XP.
            {
                labelXP.Show();
                checkedListBox1.Enabled = false;
                return; 
            }

            m_IgnoreChecks = true;
            checkedListBox1.DisplayMember = "Caption";
            
            checkedListBox1.BeginUpdate();
            
            List<ShellViewColumn> cols = new List<ShellViewColumn>();
            cols.AddRange(m_ExplorerBrowser.AllColumns);
            cols.Sort(delegate(ShellViewColumn col1, ShellViewColumn col2)
            {
                if (m_ExplorerBrowser.Columns.Contains(col1) ^ m_ExplorerBrowser.Columns.Contains(col2))
                {
                    return (m_ExplorerBrowser.Columns.Contains(col1)) ? -1 : 1;
                }

                else 
                {
                    if (m_ExplorerBrowser.Columns.Contains(col1))
                        //both are visible: order by index
                        return (m_ExplorerBrowser.Columns.IndexOf(col1) < m_ExplorerBrowser.Columns.IndexOf(col2))
                            ? -1
                            : 1;
                    else //order alphabetically.
                        return String.Compare(col1.Caption, col2.Caption);
                }
            });

            foreach (ShellViewColumn col in cols)
            {
                checkedListBox1.Items.Add(col, m_ExplorerBrowser.Columns.Contains(col));
            }
            checkedListBox1.EndUpdate();
            m_IgnoreChecks = false;

        }
        public void Show(Jam.Shell.ExplorerBrowser explorerBrowser)
        {
            m_ExplorerBrowser = explorerBrowser;
            m_ExplorerBrowser.NavigationComplete += m_ExplorerBrowser_NavigationComplete;
            FillColumns();
            Show();
        }

        void m_ExplorerBrowser_NavigationComplete(object sender, EventArgs e)
        {
            FillColumns();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (m_IgnoreChecks) return;
            if (e.NewValue == System.Windows.Forms.CheckState.Checked)
            {
                m_ExplorerBrowser.Columns.Show(((ShellViewColumn)checkedListBox1.Items[e.Index]).ShellColumnId);
            }
            else
            {
                m_ExplorerBrowser.Columns.Hide(((ShellViewColumn)checkedListBox1.Items[e.Index]).ShellColumnId);
            }
        }


        private void FormColumns_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_ExplorerBrowser.NavigationComplete -= m_ExplorerBrowser_NavigationComplete;
        }
    }
}
