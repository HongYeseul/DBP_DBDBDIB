using MySql.Data.MySqlClient;
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
        public int basicpay = 10000;
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

        private void buttonSelectEmployee_Click(object sender, EventArgs e)
        {
            int idx = listViewShowEmployee.FocusedItem.Index;
            string employeeid = listViewShowEmployee.Items[idx].Text;
            string name = listViewShowEmployee.Items[idx].SubItems[1].Text;

            int totalworktime;
            int extratime;

            string query = "SELECT * FROM SalaryDetail WHERE id = " + employeeid;
            MySqlDataReader rdr = DBManager.GetInstance().select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {
                DateTime today = DateTime.Now.Date;
                DateTime firstday = today.AddDays(1 - today.Day);
                DateTime lastday = firstday.AddMonths(1).AddDays(-1);
                string tmp = rdr["totalwork"].ToString();
                if (rdr["totalwork"].ToString() == "")
                    totalworktime = GetWorkingDays(firstday, lastday)*9;
                else
                    totalworktime = Int32.Parse(rdr["totalwork"].ToString());

                tmp = rdr["extratime"].ToString();
                if (rdr["extratime"].ToString() != "")
                    extratime = Int32.Parse(rdr["extratime"].ToString());
                else
                    extratime = 0;

                labelNormal.Text = (totalworktime * basicpay).ToString();
                labelExtra.Text = (extratime * basicpay * 1.5).ToString();
                labelPaymentAmount.Text = ((totalworktime * basicpay) + (extratime * basicpay * 1.5)).ToString();
            }
        }

        int GetWorkingDays(DateTime startDate, DateTime endDate)
        {
            DayOfWeek currDay = startDate.DayOfWeek;
            int WorkingDays = 0;

            foreach (var i in Enumerable.Range(0, Convert.ToInt32(endDate.Subtract(startDate).TotalDays)))
            {
                if (currDay != DayOfWeek.Sunday && currDay != DayOfWeek.Saturday)
                    WorkingDays++;
                if ((int)++currDay > 6) currDay = (DayOfWeek)0;
            }
            return WorkingDays;
        }

        private void buttonGetEmployee_Click(object sender, EventArgs e)
        {
            listViewShowEmployee.BeginUpdate(); //업데이트 시작
            string query = "SELECT * FROM Employee";
            MySqlDataReader rdr = DBManager.GetInstance().select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {
                ListViewItem items = new ListViewItem(rdr["identification"].ToString()); //커피 이름을 가져옴.
                items.SubItems.Add(rdr["name"].ToString()); //커피 가격을 가져옴
                listViewShowEmployee.Items.Add(items); //listview에 더함
            }
            // 컬럼명과 컬럼사이즈 지정
            listViewShowEmployee.Columns.Add("사원번호", 70, HorizontalAlignment.Left);
            listViewShowEmployee.Columns.Add("사원이름", 70, HorizontalAlignment.Left);

            listViewShowEmployee.EndUpdate(); //업데이트 종료
        }
    }
}
