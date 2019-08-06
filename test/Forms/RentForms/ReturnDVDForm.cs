using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Data;

namespace test.Forms.RentForms
{
    public partial class ReturnDVDForm : Form
    {
        public ReturnDVDForm()
        {
            InitializeComponent();
        }

        private void ReturnDVDForm_Load(object sender, EventArgs e)
        {
            cbbTitle.DataSource = DB.DVD.SearchStateFalse();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            DVD dvd = DB.DVD.SearchDVDNum((int)cbbTitle.SelectedValue);
            dvd.RentStatus = true;
            DB.DVD.Update(dvd);
            MessageBox.Show("반납이 완료되었습니다.");
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
