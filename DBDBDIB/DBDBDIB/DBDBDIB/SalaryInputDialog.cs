using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBDBDIB
{
    public partial class SalaryInputDialog : Form
    {
        private SalaryDetail detail_ = new SalaryDetail();
        public SalaryInputDialog(SalaryDetail detail)
        {
            InitializeComponent();
            detail_ = detail;
            textBoxInputHour.Text = detail.ExtraHour_.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {//입력되지 않았을 경우 예외처리하기
            if(textBoxInputHour.Text == "") //입력되지 않은 경우
            {
                DBManager.GetInstance().msg("시간을 입력해주세요");
                return;
            }
            double i = 0;
            if (double.TryParse(textBoxInputHour.Text, out i) == false) //가격이 정수가 아닐경우
            {
                DBManager.GetInstance().msg("정수 가격을 입력해주세요");
                return;
            }
            detail_.ExtraHour_ = Double.Parse(textBoxInputHour.Text);
            this.Close();
        }
    }
}
