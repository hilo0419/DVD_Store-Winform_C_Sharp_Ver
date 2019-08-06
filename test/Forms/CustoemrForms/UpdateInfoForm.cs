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
    public partial class UpdateInfoForm : Form
    {
        bool check = false;
        Customer _cus;

        public UpdateInfoForm()
        {
            InitializeComponent();
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            txbNumber.Clear();

            string id = txbID.Text;
            _cus = DB.Customer.SearchId(id);
            //등록된아이디인지체크
            if (_cus == null)
            {
                MessageBox.Show("등록되지 않은 ID입니다. 다시 입력해주세요");
                return;
            }
            //기존번호 출력
            txbNumber.Text = _cus.PhoneNumber;
            check = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //중복체크를 했는지 확인
            if (check == false)
            {
                MessageBox.Show("아이디를 조회해주세요");
                return;
            }
            //빈칸이 있는지 확인
            string number = txbNumber.Text;
            if (string.IsNullOrWhiteSpace(number))
            {
                MessageBox.Show("폰번호를 입력해주세요");
                return;
            }
            string id = txbID.Text;
           
            _cus.PhoneNumber = number;
            DB.Customer.Update(_cus);
            MessageBox.Show("수정이 완료되었습니다");
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
