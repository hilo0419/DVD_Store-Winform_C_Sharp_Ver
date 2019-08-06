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
    public partial class InsertCusForm : Form
    {
        bool checkId2 = true;
        public InsertCusForm()
        {
            InitializeComponent();
        }

        private void BtnCheckId_Click(object sender, EventArgs e)
        {
            string loginId = txbId.Text;
            bool checkId = DB.Customer.CheckId(loginId);
            if (checkId)
            { 
            MessageBox.Show("중복된 아이디입니다. 다시 입력해주세요.");
                checkId2 = false;
            }
            else
            {
                MessageBox.Show("사용 가능한 아이디입니다.");
                checkId2 = true;
            }
           }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            //1.중복체크를 했는지 체크
            if (checkId2 == false)
            {
                MessageBox.Show("중복체크를 해주세요.");
                return;
            }
            //2.이름,폰번호 빈칸인지 체크
            string name = txbName.Text;
            if(string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("이름을 입력해주세요");
                return;
            }
            string phoneNumber = txbPhoneNum.Text;
            if(string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("폰번호를 입력해주세요");
                return;
            }
            //3.가입
            Customer customer = new Customer();
            customer.LoginID = txbId.Text;
            customer.Name = name;
            customer.PhoneNumber = phoneNumber;

            DB.Customer.Insert(customer);
            //4.메세지박스-가입완료
            MessageBox.Show("가입이 완료되었습니다");
            //5.클로즈
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
