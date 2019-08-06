using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Forms.DVDForms;

namespace test.Forms
{
    public partial class DVDForm : Form
    {
        public DVDForm()
        {
            InitializeComponent();
        }

        private void BtnDVDInsert_Click(object sender, EventArgs e)
        {
            InsertDVDForm insertDVDForm = new InsertDVDForm();
            insertDVDForm.ShowDialog();
        }

        private void BtnUpdateDVDInfo_Click(object sender, EventArgs e)
        {
            UpdateDVDInfoForm updateDVDInfoForm = new UpdateDVDInfoForm();
            updateDVDInfoForm.ShowDialog();
        }

        private void BtnSearchDVD_Click(object sender, EventArgs e)
        {
            SearchDVDForm searchDVDForm = new SearchDVDForm();
            searchDVDForm.ShowDialog();
        }
    }
}
