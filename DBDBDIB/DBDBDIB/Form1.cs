using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBDBDIB
{
    public partial class paymentform : Form
    {
        public paymentform()
        {
            InitializeComponent();
            PaymentListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PaymentListView.MultiSelect = false;
            PaymentListView.AllowUserToAddRows = false;
            labelpaymentdeny.Visible = false;
            textBoxPaymentdenymemo.Visible = false;
            buttonDenycheck.Visible = false;
        }
        string strconn = "Server=49.50.174.201;Database=erp_school;Uid=dbdbdib;Pwd=123123;Charset=utf8";

        private void paymentviewer() 
        {
            PaymentListView.Rows.Clear();
            second_payment();
        }

        private void first_payment()
        {
            string firstpayment = "SELECT ID,기안자,제목,내용,시간 FROM 결재 WHERE 진행상황 = 0 AND 결재자수 = 2";
            MySqlDataReader rdr = DBManager.GetInstance().select(firstpayment);
            int ii = 0;
            while (rdr.Read())
            {
                PaymentListView.Rows.Add();
                for (int i = 0; i < 5; i++) // index 0 ~ 4까지 존재
                    PaymentListView.Rows[ii].Cells[i].Value = rdr[i].ToString();
                ii++;
            }
            rdr.Close();
        }

        private void second_payment()
        {
            string secondpayment = "SELECT ID,기안자,제목,내용,시간 FROM 결재 WHERE 진행상황 = 1 AND 결재자수 = 2";
            MySqlDataReader rdr = DBManager.GetInstance().select(secondpayment);
            int ii = 0;
            while (rdr.Read())
            {
                PaymentListView.Rows.Add();
                for (int i = 0; i < 5; i++) // index 0 ~ 4까지 존재
                    PaymentListView.Rows[ii].Cells[i].Value = rdr[i].ToString();
                ii++;
            }
            rdr.Close();
        }

        private void buttonPayment_Accept_Click(object sender, EventArgs e) // 결재진행을 누를 시
        {
            string selected = PaymentListView.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            string paymenttime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string accepttime = "UPDATE 결재 SET 진행상황 = 진행상황 + 1, 시간 = '" + paymenttime + "'" + "WHERE ID = " + id + "";
            DBManager.GetInstance().DBquery(accepttime);
            MessageBox.Show("결재가 완료되었습니다.", "결재진행");
        } 

        private void buttonPayment_Deny_Click(object sender, EventArgs e) // 결재반려를 누를 시
        {
            labelpaymentdeny.Visible = true;
            textBoxPaymentdenymemo.Visible = true;
            buttonDenycheck.Visible = true;
        }

        private void button_TaskMaster_Click(object sender, EventArgs e) // 업무마스터 보기를 누를 시
        {
            taskmasterform newForm = new taskmasterform();
            newForm.Show();
        }

        private void PaymentListView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selected = PaymentListView.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            string commentquery = "SELECT * FROM 결재 WHERE ID = " + id + "";
            MySqlDataReader rdr = DBManager.GetInstance().select(commentquery);
            while (rdr.Read())
            {
                textBoxComent.Text = rdr["코멘트"].ToString();
            }
            rdr.Close();
        }

        private void paymentform_Load(object sender, EventArgs e)
        {
            paymentviewer();
        }
    }
}
/* 총장용
 * string Master_payment = "SELECT ID,기안자,제목,내용,시간 FROM 결재 WHERE 진행상황 = 2 AND 결재자수 = 3";
            MySqlDataReader rdr = DBManager.GetInstance().Select(Master_payment);
            int ii = 0;
            while (rdr.Read())
            {
                PaymentListView.Rows.Add();
                for (int i = 0; i < 5; i++) // index 0 ~ 4까지 존재
                    PaymentListView.Rows[ii].Cells[i].Value = rdr[i].ToString();
                ii++;
            }
            rdr.Close();*/


/*string checkpayment = "SELECT 진행상황,결재자수 FROM 결재";
MySqlDataReader rdr = DBManager.GetInstance().Select(checkpayment);
rdr.Read();
int paymentflag = Convert.ToInt32(rdr["진행상황"].ToString()); // 진행상황
int paymentcount = Convert.ToInt32(rdr["결재자수"].ToString()); // 결재자 수
rdr.Close();

if (paymentcount == 2)
{
    switch (paymentflag)
    {
        case 0:
            first_payment();
            break;
        case 1:
            second_payment();
            break;
    }
}*/