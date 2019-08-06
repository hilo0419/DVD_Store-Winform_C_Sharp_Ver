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

namespace test.Forms.DVDForms
{
    public partial class SearchDVDForm : Form
    {
        public SearchDVDForm()
        {
            InitializeComponent();
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            int dvdNum;
            if (int.TryParse(txbID.Text, out dvdNum)==false)
            {
               if(string.IsNullOrWhiteSpace(txbID.Text))
                {
                    List<DVD> dvds = DB.DVD.GetAll();
                    dgvList.DataSource = dvds;
                    return;
                }
               else
                {
                    MessageBox.Show("숫자를 입력해주세요.");
                    return;
                }
            }

            dgvList.DataSource = DB.DVD.Get(dvdNum);
        
        }
    }
}
