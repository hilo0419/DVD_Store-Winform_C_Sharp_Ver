using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Forms.RentForms;

namespace test.Forms
{
    public partial class RentForm : Form
    {
        public RentForm()
        {
            InitializeComponent();
        }

        private void BtnRentDVD_Click(object sender, EventArgs e)
        {
            RentDVDForm rentDVDForm = new RentDVDForm();
            rentDVDForm.ShowDialog();
        }

        private void BtnReturnDVD_Click(object sender, EventArgs e)
        {
            ReturnDVDForm returnDVDForm = new ReturnDVDForm();
            returnDVDForm.ShowDialog();
        }

        private void BtnSearchDVD_Click(object sender, EventArgs e)
        {
            SearchRentForm searchRentForm = new SearchRentForm();
            searchRentForm.ShowDialog();
        }

        private void BtnSearchDate_Click(object sender, EventArgs e)
        {
            SearchDateForm searchDateForm = new SearchDateForm();
            searchDateForm.ShowDialog();
        }
    }
}
