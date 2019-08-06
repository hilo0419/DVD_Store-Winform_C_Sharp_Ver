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
    public partial class SearchDateForm : Form
    {
        public SearchDateForm()
        {
            InitializeComponent();
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = DB.Rent.SearchDate(dtpDate.Value);
        }
    }
}
