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
    public partial class UpdateDVDInfoForm : Form
    {
        DVD _dvd;
        bool check = false;

        public UpdateDVDInfoForm()
        {
            InitializeComponent();
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            txbTitle.Clear();

            int dvdNum;
            if (int.TryParse(txbDVDNum.Text, out dvdNum) == false)
            {
                if (string.IsNullOrWhiteSpace(txbDVDNum.Text))
                {
                    MessageBox.Show("다시 입력해주세요.");
                    return;
                }
                MessageBox.Show("숫자를 입력해주세요.");
                return;
            }

            _dvd = DB.DVD.SearchDVDNum(dvdNum);
            if (_dvd == null)
            {
                MessageBox.Show("등록되지 않은 DVD번호입니다. 다시 입력해주세요.");
                return;
            }

            txbTitle.Text = _dvd.Title;
            check = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(check==false)
            {
                MessageBox.Show("DVD번호 조회를 선택해주세요.");
                return;
            }
            string title = txbTitle.Text;
            if(string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("제목을 입력해주세요.");
                return;
            }

            _dvd.Title = title;
            DB.DVD.Update(_dvd);
            MessageBox.Show("수정이 완료되었습니다.");
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
