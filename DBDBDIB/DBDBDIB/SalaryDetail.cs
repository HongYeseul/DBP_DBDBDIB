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
        private int basicpay = 10000;
        private double totalworktime_;
        public int ExtraHour_ { get; set; }
        private List<string> department_ = new List<string>(); //부서 목록
        private Label[] labels_;

        public SalaryDetail()
        {
            InitializeComponent();
            labels_ = new Label[] { labelNormal, labelExtra , labelPaymentAmount, labelNationalPension, labelHealthInsurance, labelLongtermCare, labelEmploymentInsurance, labelDeductionAmount, labelRealIncome };
            dateTimePickerYearMonth.CustomFormat = "yyyy년 MM월"; //년.월 형식을 timepicker에 지정
            GetDepartment(); //부서를 가져오는 코드
            comboBoxShowDepartment.SelectedIndex = -1; //선택된 인덱스 초기화
            initValue();
        }
        
        public void initValue() //label 값 초기화 해주는 코드
        {
            foreach(Label l in labels_) //label 값 0으로 초기화
            {
                l.Text = "0";
            }
        }


        #region 이벤트 리스너
        private void buttonInputExtra_Click(object sender, EventArgs e) //추가수당 입력 버튼 클릭시
        {
            if (listViewShowEmployee.SelectedItems.Count == 0)
            {
                MessageBox.Show("사원을 선택해주세요", "확인");
                return;
            }
            SalaryInputDialog dig = new SalaryInputDialog(this);
            dig.FormClosed += new FormClosedEventHandler(SalaryInputDialog_FormClosed);
            dig.Show();
        }

        void SalaryInputDialog_FormClosed(object sender, FormClosedEventArgs e) //추가수당 입력 dialog가 꺼졌을 때
        {
            ChangeLabel(); //업데이트 시킴.
            //추가수당을 db에 업데이트 시킴.
            int idx = listViewShowEmployee.FocusedItem.Index;
            string employeeid = listViewShowEmployee.Items[idx].Text;
            DateTime dt = dateTimePickerYearMonth.Value;
            string date = string.Format("{0}-{1}", dt.Year, dt.Month);
            string query = "UPDATE SalaryDetail SET extratime = " + ExtraHour_+ " WHERE employeeid = " + employeeid + " AND month = '" + date + "-01'";
            DBManager.GetInstance().DBquery(query); //insert 실행

        }

        private void buttonGetEmployee_Click(object sender, EventArgs e) //불러오기 버튼 클릭시
        {
            initValue();
            GetEmployee();
        }
        
        private void buttonSelectEmployee_Click(object sender, EventArgs e)//확인버튼 클릭시
        {
            initValue(); 

            // getlocaltime(employeeid,date); //추가기능 전
            GetTotalHour(); //추가기능 후

            ChangeLabel();
        }

        private void listViewShowEmployee_SelectedIndexChanged(object sender, EventArgs e) //listview 선택된 사람이 변할경우
        {
            initValue();
        }
        #endregion

        

        public void GetDepartment()//부서를 가져오는 코드
        {
            string query = "SELECT * FROM 부서 WHERE valid = 1";
            MySqlDataReader rdr = DBManager.GetInstance().select(query); //DB에서 값을 가져옴
            comboBoxShowDepartment.Items.Clear();
            while (rdr.Read())
            {
                string id = rdr["ID"].ToString();
                if (id == "1") //총장일 경우
                {
                    continue;
                }
                department_.Add(id);
                comboBoxShowDepartment.Items.Add(rdr["부서명"].ToString());
            }
            rdr.Close();
        }


        public void GetEmployee() //사원 가져오는 함수
        {
            listViewShowEmployee.BeginUpdate(); //업데이트 시작
            if (comboBoxShowDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("부서가 선택되지 않았습니다.", "확인");
                listViewShowEmployee.EndUpdate(); //업데이트 종료
                return;
            }
            listViewShowEmployee.Items.Clear(); //listview 초기화
            int idx = comboBoxShowDepartment.SelectedIndex;
            string query = "SELECT * FROM Employee WHERE department = " + department_[idx] +" AND valid = 1";
            MySqlDataReader rdr = DBManager.GetInstance().select(query); //DB에서 값을 가져옴
            while (rdr.Read())
            {
                ListViewItem items = new ListViewItem(rdr["identification"].ToString()); //사원 id 값을 가져옴.
                items.SubItems.Add(rdr["name"].ToString()); //사원의 이름을 가져옴.
                listViewShowEmployee.Items.Add(items); //listview에 더함
            }
            rdr.Close();
            // 컬럼명과 컬럼사이즈 지정
            listViewShowEmployee.Columns.Add("사원번호", 70, HorizontalAlignment.Left);
            listViewShowEmployee.Columns.Add("사원이름", 70, HorizontalAlignment.Left);

            listViewShowEmployee.EndUpdate(); //업데이트 종료
        }
        public void getlocaltime(string employeeid, string date)
        {
            string query = "SELECT * FROM SalaryDetail WHERE employeeid = " + employeeid + " AND month = '" + date + "-01'";
            MySqlDataReader rdr = DBManager.GetInstance().select(query); //DB에서 값을 가져옴
            if (rdr.Read())
            {
                // DateTime today = DateTime.Now.Date;
                //DateTime firstday = today.AddDays(1 - today.Day);
                // DateTime lastday = firstday.AddMonths(1).AddDays(-1);

                string tmp = rdr["totalwork"].ToString(); //총근무 시간을 가져옴
                if (rdr["totalwork"].ToString() == "") //추가기능 구현전 아무것도 입력되어 있지 않을 경우
                    totalworktime_ = 207;
                else
                    totalworktime_ = Int32.Parse(rdr["totalwork"].ToString());
                tmp = rdr["extratime"].ToString(); //추가시간을 가져옴.
                if (rdr["extratime"].ToString() != "")
                    ExtraHour_ = Int32.Parse(rdr["extratime"].ToString());
                else
                    ExtraHour_ = 0;
            }
            else
            {
                query = "INSERT INTO SalaryDetail(employeeid, month) VALUES(" + employeeid + ", '" + date + "-01')";
                DBManager.GetInstance().DBquery(query); //insert 실행
                totalworktime_ = 207;
                ExtraHour_ = 0;
            }
        }
        public void GetTotalHour() //추가기능 전체 시간 가져오는 함수
        {
            DateTime dt = dateTimePickerYearMonth.Value;
            string date = string.Format("{0}-{1}", dt.Year, dt.Month);
            if(listViewShowEmployee.SelectedItems.Count == 0)
            {
                MessageBox.Show("사원을 선택해주세요", "확인");
                return;
            }
            int idx = listViewShowEmployee.FocusedItem.Index;
            string employeeid = listViewShowEmployee.Items[idx].Text;
            string query = "select empID,sum(hour(daytime))as h, sum(minute(daytime))as m, sum(second(daytime))as s from(select empID,date,subtime(empOut, empIn) as daytime from Attendance) as tmp where empID ="
                + employeeid + " AND DATE_FORMAT(Date,'%Y-%m') = '"+date + "' group by empID";
            //사원 id, 시간, 분, 초를 받아옴.
            MySqlDataReader rdr = DBManager.GetInstance().select(query);
            int hour = 0, month = 0, second = 0;
            if (rdr.Read())
            {
                hour = Int32.Parse(rdr["h"].ToString());
                month = Int32.Parse(rdr["m"].ToString());
                second = Int32.Parse(rdr["s"].ToString());
            }
            totalworktime_ = hour + (float)month / 60;

            query = "SELECT * FROM SalaryDetail WHERE employeeid = " + employeeid + " AND month = '" + date + "-01'";
            rdr = DBManager.GetInstance().select(query); //DB에서 값을 가져옴
            if (rdr.Read())
            {
                if (rdr["extratime"].ToString() != "")
                    ExtraHour_ = Int32.Parse(rdr["extratime"].ToString());
                else
                    ExtraHour_ = 0;
            }
            else
            {
                query = "INSERT INTO SalaryDetail(employeeid, month) VALUES(" + employeeid + ", '" + date + "-01')";
                DBManager.GetInstance().DBquery(query); //insert 실행
                ExtraHour_ = 0;
            }
        }

        public void ChangeLabel() //급여 계산하는 함수
        {
            double healthinsurance; //국민건강보험
            double totalmoney; //총 급여

            if (ExtraHour_ == 0)
            {
                labelExtra.Text = "0";
            }
            else
            {
                labelExtra.Text = String.Format("{0:#,###}", (Math.Truncate((ExtraHour_ * basicpay * 1.5)/10d))*10);
            }
            if (totalworktime_ == 0)
            {
                return;
            }
            totalmoney = (Math.Truncate(((totalworktime_ * basicpay) + (ExtraHour_ * basicpay * 1.5))/10d)*10);
            //지급내역서 총급여 label 지정
            labelNormal.Text = String.Format("{0:#,###}", Math.Truncate((totalworktime_ * basicpay) / 10d) * 10);
            
            labelPaymentAmount.Text = String.Format("{0:#,###}", Math.Truncate(totalmoney / 10d) * 10);

            //지급내역서 공제내역 label 지정
            labelNationalPension.Text = String.Format("{0:#,###}", Math.Truncate((totalmoney * 0.09 / 2) / 10d) * 10); //국민연금 9%/2
            healthinsurance = (Math.Truncate((totalmoney * 0.0667 / 2) / 10d) * 10);
            labelHealthInsurance.Text = String.Format("{0:#,###}", (healthinsurance).ToString()); //건강보험료 *6.67% / 2
            labelLongtermCare.Text = String.Format("{0:#,###}", (Math.Truncate((healthinsurance * 0.09 / 2) / 10d) * 10)); //장기요양보험료 * 9% /2
            labelEmploymentInsurance.Text = String.Format("{0:#,###}", (Math.Truncate((totalmoney * 0.008) / 10d) * 10)); //고용보험료 * 0.8%
            double totaldelete = Math.Truncate(((totalmoney * 0.09 / 2) + healthinsurance + (healthinsurance * 0.09 / 2) + (totalmoney * 0.008)) / 10d) * 10;
            labelDeductionAmount.Text = String.Format("{0:#,###}", (totaldelete));


            //실 수령액
            labelRealIncome.Text = String.Format("{0:#,###}", Math.Truncate((totalmoney - totaldelete) / 10d) * 10);
        }

        #region 필요없는것
        int GetWorkingDays(DateTime startDate, DateTime endDate)   //평일수 구하기 - 아마 필요 없을듯..
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
        #endregion
    }
}
