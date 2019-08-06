using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void BtnDvd_Click(object sender, EventArgs e)
        {
            DVDForm dVDForm = new DVDForm();
            dVDForm.ShowDialog();
        }

        private void BtnRent_Click(object sender, EventArgs e)
        {
            RentForm rentForm = new RentForm();
            rentForm.ShowDialog();
        }
    }
}
