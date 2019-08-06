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
    public partial class RentDVDForm : Form
    {
        bool checkID = false; 
        public RentDVDForm()
        {
            InitializeComponent();
        }

        private void RentDVDForm_Load(object sender, EventArgs e)
        {
            dVDBindingSource1.DataSource = DB.DVD.GetAll();
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            string id = txbCusID.Text;
            if(string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }
            Customer customer = DB.Customer.SearchId(id);
            if(customer==null)
            {
                MessageBox.Show("존재하지 않는 ID입니다. 다시 입력해주세요.");
                return;
            }
            MessageBox.Show("존재하는 ID입니다.");
            checkID = true;
        }

        private void BtnRent_Click(object sender, EventArgs e)
        {
            if(checkID==false)
            {
                MessageBox.Show("아이디를 조회해주세요.");
                return;
            }
            Rent rent = new Rent();
            Customer customer = DB.Customer.SearchId(txbCusID.Text);
            DVD dvd=DB.DVD.SearchDVDNum((int)cbbTitle.SelectedValue);
            if(dvd.RentStatus==false)
            {
                MessageBox.Show("해당 도서는 이미 대여중입니다.");
                return;
            }
            rent.CustomerID = customer.CustomerID;
            rent.DvdID = (int)cbbTitle.SelectedValue;
            rent.RentDate = DateTime.Now;
            DB.Rent.Insert(rent);
            dvd.RentStatus = false;
            DB.DVD.Update(dvd);
            MessageBox.Show("대여가 완료되었습니다.");
            Close();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
