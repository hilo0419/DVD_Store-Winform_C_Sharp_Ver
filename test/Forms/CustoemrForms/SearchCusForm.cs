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

namespace test.Forms.CustoemrForms
{
    public partial class SearchCusForm : Form
    {
        public SearchCusForm()
        {
            InitializeComponent();
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {

            //아이디가 빈칸일경우 -전체조회
            string id = txbID.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                dgvList.DataSource = DB.Customer.Get();
                return;
            }
            //아이디가 입력될경우 - 하나만 조회           
            dgvList.DataSource = DB.Customer.SearchIdList(id); ;


        }
    }
}
