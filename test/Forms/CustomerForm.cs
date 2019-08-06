using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Forms.CustoemrForms;

namespace test.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void BtnCusInsert_Click(object sender, EventArgs e)
        {
            InsertCusForm insertCusForm = new InsertCusForm();
            insertCusForm.ShowDialog();
        }

        private void BtnUpdateInfo_Click(object sender, EventArgs e)
        {
            UpdateInfoForm updateInfoForm = new UpdateInfoForm();
            updateInfoForm.ShowDialog();
        }

        private void BtnSearchCus_Click(object sender, EventArgs e)
        {
            SearchCusForm searchCusForm = new SearchCusForm();
            searchCusForm.ShowDialog();
        }
    }
}
