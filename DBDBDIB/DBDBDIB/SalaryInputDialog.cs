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
            textBoxInputHour.Text = detail.ExtraHour_;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {//입력되지 않았을 경우 예외처리하기
            detail_.ExtraHour_ = textBoxInputHour.Text;
            this.Close();
        }
    }
}
