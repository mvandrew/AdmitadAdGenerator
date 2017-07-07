using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmitadAdGenerator.References
{
    public partial class admitadAccountsForm : Form
    {
        public admitadAccountsForm()
        {
            InitializeComponent();
        }

        private void admitadAccountsForm_Load(object sender, EventArgs e)
        {

            // Загрузка данных из БД
            this.admitadAccountsTableTableAdapter.Fill(this.admitadAdsDBDataSet.AdmitadAccountsTable);

        }

        private void admitadAccountsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateData();
        }

        private void admitadAccountsForm_Leave(object sender, EventArgs e)
        {
            updateData();
        }

        /// <summary>
        /// Обновление данных в БД
        /// </summary>
        private void updateData()
        {
            this.admitadAccountsTableTableAdapter.Update(this.admitadAdsDBDataSet.AdmitadAccountsTable);
        }
    }
}
