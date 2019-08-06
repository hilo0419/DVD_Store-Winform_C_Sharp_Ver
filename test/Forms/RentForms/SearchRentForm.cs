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
    public partial class SearchRentForm : Form
    {
        public SearchRentForm()
        {
            InitializeComponent();
        }

        private void SearchRentForm_Load(object sender, EventArgs e)
        {
            cbbTitle.DataSource = DB.DVD.GetAll();
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = DB.DVD.Get((int)cbbTitle.SelectedValue);

        }

        private void BtnAllSearch_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = DB.DVD.GetAll();
        }

        private void DgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {    
                switch(e.Value)
                {
                    case true: e.Value = "대여 가능";
                        break;
                    case false: e.Value = "대여 중";
                        break;
                }
            }
        }
    }
}
