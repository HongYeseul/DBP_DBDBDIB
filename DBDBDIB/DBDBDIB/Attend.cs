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
    public partial class Attend : Form
    {
        public Attend()
        {
            InitializeComponent();
            initVariables();
        }
        HRInfo hr = new HRInfo();
        private string currentdate = "";
        private string currenttime = "";

        private string loginID = UserInfo.Getinstance().Id;

        private void initVariables()
        {
            tbEmp.Text = null;
        }
        private void bIn_Click(object sender, EventArgs e)
        {
            currentdate = DateTime.Now.ToString("%y-%M-%d");
            currenttime = DateTime.Now.ToString("%H:%m:%s");

            if (hr.selectDGV("id", "Attendance", " WHERE empID="+ loginID+" AND " +"Date='" + currentdate + "'").Rows.Count!=0)
            {
                MessageBox.Show("출근시간 갱신은 하루에 한 번만 할 수 있습니다.");
                return;
            }
            hr.insertHRData("Attendance", "Date, empID, empIn", "'" + currentdate + "', " + loginID + ", '" + currenttime + "'");           
            dgvVisible("");
            dgvattend.CurrentCell = dgvattend.Rows[dgvattend.Rows.Count - 1].Cells[0];
        }

        private void bOut_Click(object sender, EventArgs e)
        {
            currentdate = DateTime.Now.ToString("%y-%M-%d");
            currenttime = DateTime.Now.ToString("%H:%m:%s");
            string login_logout_check;
            try {
                if (hr.selectDGV("empOut", "Attendance", " WHERE empID=" + loginID + " AND " + "Date='" + currentdate + "' AND empOut IS NOT NULL").Rows.Count != 0)
                {
                    MessageBox.Show("퇴근시간 갱신은 하루에 한 번만 할 수 있습니다.");
                    return;
                }
            }
            catch {
                MessageBox.Show("오늘 출근정보가 없습니다.");
                return;
            }
            login_logout_check = Convert.ToString(hr.selectDGV("id ", "Attendance ", " WHERE Date='" + currentdate + "'" + " AND empID=" + loginID).Rows[0][0]);
            hr.updateHRData("","Attendance", "empOut='" + DateTime.Now.ToString("%H:%m:%s") + "' WHERE id=" + login_logout_check);
            dgvVisible("");
            dgvattend.CurrentCell = dgvattend.Rows[dgvattend.Rows.Count - 1].Cells[0];
        }
        private void bLookup_Click(object sender, EventArgs e)
        {
            string query = "";
            if (dtpToday.Checked)
                query = " AND Date='" + dtpToday.Value.ToString("%y-%M-%d") +"'";
            if (tbEmp.Text != "")
                query += " AND empID="+tbEmp.Text; 
            dgvVisible(query);
        }
        private void dgvVisible(string where)
        {
            dgvattend.DataSource = hr.selectDGV("Date as 날짜, empID as 사원번호, name as 사원이름, empIn as 출근, empOut as 퇴근", "Employee,Attendance"," WHERE identification=empID"+where+" ORDER BY Date,empIn");
            dgvattend.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dtpToday_ValueChanged(object sender, EventArgs e)
        {
            dtpToday.CustomFormat = "yyyy-MM-dd";
        }


    }
}
