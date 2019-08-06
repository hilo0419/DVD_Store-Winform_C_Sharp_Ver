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
    public partial class InsertDVDForm : Form
    {
        string [] genres = {"ACTION", "COMEDY", "ROMANCE", "HORROR" };
        bool checkNum2 = false;
        int dvd_Num;
        public InsertDVDForm()
        {
            InitializeComponent();
        }

        private void InsertDVDForm_Load(object sender, EventArgs e)
        {
            cbbGenre.DataSource = genres;
        }

        private void BtnCheckDVDnum_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txbDVDNum.Text,out dvd_Num) == false)
            {
                MessageBox.Show("숫자만 입력해주세요.");
                return;
            }

            bool checkNum = DB.DVD.CheckDVDNum(dvd_Num);
            if(checkNum)
            {
                MessageBox.Show("중복된 DVD 번호입니다. 다시 입력해주세요.");
                checkNum2 = false;
            }
            else
            {
                MessageBox.Show("등록 가능한 DVD번호입니다.");
                checkNum2 = true;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if(checkNum2==false)
            {
                MessageBox.Show("중복체크를 해주세요.");
                return;
            }
            string title = txbTitle.Text;
            if(string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("제목을 입력해주세요");
                return;
            }
            DVD dvd = new DVD();
            dvd.DvdID = dvd_Num;
            dvd.Title = title;
            dvd.Genre = cbbGenre.SelectedItem.ToString();
            dvd.RentStatus = true;

            DB.DVD.Insert(dvd);
            MessageBox.Show("등록이 완료되었습니다.");
            Close();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
