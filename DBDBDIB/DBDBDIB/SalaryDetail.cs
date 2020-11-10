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
    public partial class SalaryDetail : Form
    {

        public string ExtraHour_ { get; set; }

        public SalaryDetail()
        {
            InitializeComponent();
        }

        private void tabControlSalary_Selected(object sender, EventArgs e)
        {
            if (tabControlSalary.SelectedTab == tabPageShowSalary)
            {

            }
            else if (tabControlSalary.SelectedTab == tabPageShowTax)
            {

            }
        }

        private void buttonInputExtra_Click(object sender, EventArgs e)
        {
            SalaryInputDialog dig = new SalaryInputDialog(this);
            dig.Show();
        }
    }
}
