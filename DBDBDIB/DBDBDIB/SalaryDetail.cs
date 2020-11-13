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
        private int totalworktime_;
        public int ExtraHour_ { get; set; }
        private Label[] labels;
        private double[] rates;
       
        private double healthinsurance;
        private double totalmoney;

        public SalaryDetail()
        {
            InitializeComponent();
            labels = new Label[] { labelNormal, labelExtra , labelPaymentAmount, labelNationalPension, labelHealthInsurance, labelLongtermCare, labelEmploymentInsurance, labelDeductionAmount, labelRealIncome };
            initValue();
        }
        
        public void initValue()
        {
            foreach(Label l in labels)
            {
                l.Text = "";
            }
        }
        
        private void buttonInputExtra_Click(object sender, EventArgs e) //추가수당 입력 버튼 클릭시
        {
            SalaryInputDialog dig = new SalaryInputDialog(this);
            dig.FormClosed += new FormClosedEventHandler(SalaryInputDialog_FormClosed);
            dig.Show();
        }

        void SalaryInputDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeLabel();
        }

        public void ChangeLabel()
        {
            totalmoney = (Math.Truncate((totalworktime_ * basicpay) + (ExtraHour_ * basicpay * 1.5)));
            //지급내역서 총급여 label 지정
            labelNormal.Text = String.Format("{0:#,###}", (totalworktime_ * basicpay));
            labelExtra.Text = String.Format("{0:#,###}", (Math.Truncate(ExtraHour_ * basicpay * 1.5)));
            labelPaymentAmount.Text = String.Format("{0:#,###}", totalmoney);

            //지급내역서 공제내역 label 지정
            labelNationalPension.Text = String.Format("{0:#,###}", (Math.Truncate(totalmoney * 0.09 / 2))); //국민연금 9%/2
            healthinsurance = (Math.Truncate(totalmoney * 0.0667 / 2));
            labelHealthInsurance.Text = String.Format("{0:#,###}", (healthinsurance).ToString()); //건강보험료 *6.67% / 2
            labelLongtermCare.Text = String.Format("{0:#,###}", (Math.Truncate(healthinsurance * 0.09 / 2))); //장기요양보험료 * 9% /2
            labelEmploymentInsurance.Text = String.Format("{0:#,###}", (Math.Truncate(totalmoney * 0.008))); //고용보험료 * 0.8%
            double totaldelete = Math.Truncate((totalmoney * 0.09 / 2) + healthinsurance + (healthinsurance * 0.09 / 2) + (totalmoney * 0.008));
            labelDeductionAmount.Text = String.Format("{0:#,###}", (totaldelete));


            //실 수령액
            labelRealIncome.Text = String.Format("{0:#,###}", (totalmoney - totaldelete));
        }

        private void buttonSelectEmployee_Click(object sender, EventArgs e)//확인버튼 클릭시
        {
            int idx = listViewShowEmployee.FocusedItem.Index;
            string employeeid = listViewShowEmployee.Items[idx].Text;
            string name = listViewShowEmployee.Items[idx].SubItems[1].Text;
            
            string query = "SELECT * FROM SalaryDetail WHERE id = " + employeeid;
            MySqlDataReader rdr = DBManager.GetInstance().select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {
                DateTime today = DateTime.Now.Date;
                DateTime firstday = today.AddDays(1 - today.Day);
                DateTime lastday = firstday.AddMonths(1).AddDays(-1);
                string tmp = rdr["totalwork"].ToString(); //총근무 시간을 가져옴
                if (rdr["totalwork"].ToString() == "")
                    totalworktime_ = GetWorkingDays(firstday, lastday)*9;
                else
                    totalworktime_ = Int32.Parse(rdr["totalwork"].ToString());

                tmp = rdr["extratime"].ToString(); //추가시간을 가져옴.
                if (rdr["extratime"].ToString() != "")
                    ExtraHour_ = Int32.Parse(rdr["extratime"].ToString());
                else
                    ExtraHour_ = 0;
            }
            ChangeLabel();

        }

        int GetWorkingDays(DateTime startDate, DateTime endDate)   //평일수 구하기
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

        private void buttonGetEmployee_Click(object sender, EventArgs e) //불러오기 버튼 클릭시
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
