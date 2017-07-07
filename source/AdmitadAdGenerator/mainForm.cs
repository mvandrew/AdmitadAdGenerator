using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmitadAdGenerator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admitadAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            References.admitadAccountsForm frm = new References.admitadAccountsForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
