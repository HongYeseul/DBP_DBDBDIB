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
        int id = Convert.ToInt32(UserInfo.Getinstance().Id);
        int paymentprocesscount = 4; // 오류처리
        int usercount = 4; // 오류처리
        public paymentform()
        {
            InitializeComponent();
            PaymentListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PaymentListView.MultiSelect = false;
            PaymentListView.AllowUserToAddRows = false;
        }

        string strconn = "Server=49.50.174.201;Database=erp_school;Uid=dbdbdib;Pwd=123123;Charset=utf8";

        private void paymentviewer() // 첫 화면 함수
        {
            labelpaymentdeny.Visible = false;
            textBoxPaymentdenymemo.Visible = false;
            buttonDenycheck.Visible = false;
            textBoxComent.Text = "";
            DataTable dt = new DataTable();
            dt.Clear();
            string checkpayment1 = "SELECT ID,기안자,제목,내용,코멘트,제1결재자,제2결재자" +
                ",ifnull(제3결재자,0)AS 제3결재자 FROM 결재 WHERE 진행상황 < 결재자수 AND 1승인시간 IS NULL AND 반려여부 = 0 AND 제1결재자 = " + id;
            string checkpayment2 = "SELECT ID,기안자,제목,내용,코멘트,제1결재자,제2결재자" +
                ",ifnull(제3결재자,0)AS 제3결재자 FROM 결재 WHERE 진행상황 < 결재자수 AND 2승인시간 IS NULL AND 반려여부 = 0 AND 제2결재자 = " + id;
            string checkpayment3 = "SELECT ID,기안자,제목,내용,코멘트,제1결재자,제2결재자" +
                ",ifnull(제3결재자,0)AS 제3결재자 FROM 결재 WHERE 진행상황 < 결재자수 AND 3승인시간 IS NULL AND 반려여부 = 0 AND 제3결재자 = " + id;
            MySqlDataReader rdr1 = DBManager.GetInstance().select(checkpayment1);
            MySqlDataReader rdr2 = DBManager.GetInstance().select(checkpayment2);
            MySqlDataReader rdr3 = DBManager.GetInstance().select(checkpayment3);
            DataTable dt1 = new DataTable();
            dt1.Load(rdr1);
            DataTable dt2 = new DataTable();
            dt2.Load(rdr2);
            DataTable dt3 = new DataTable();
            dt3.Load(rdr3);
            dt1.Merge(dt2);
            dt1.Merge(dt3);
            dt1.DefaultView.Sort = "ID"; // 데이터그리드뷰에서 ID를 정렬한다.
            PaymentListView.DataSource = dt1;
        }
        private void buttonPayment_Accept_Click(object sender, EventArgs e) // 결재진행을 누를 시
        {
            string selected = PaymentListView.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            string paymenttime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if(paymentprocesscount + 1 == usercount && usercount == 1)
            {
                string first_payment_accepttime = "UPDATE 결재 SET 진행상황 = 진행상황 + 1, 1승인시간 = '" + paymenttime + "'" + "WHERE ID = " + id;
                DBManager.GetInstance().DBquery(first_payment_accepttime);
                MessageBox.Show(paymenttime + "에 결재가 완료되었습니다.", "결재알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                paymentviewer();
            }
            else if(paymentprocesscount + 1 == usercount && usercount == 2)
            {
                string second_payment_accepttime = "UPDATE 결재 SET 진행상황 = 진행상황 + 1, 2승인시간 = '" + paymenttime + "'" + "WHERE ID = " + id;
                DBManager.GetInstance().DBquery(second_payment_accepttime);
                MessageBox.Show(paymenttime + "에 결재가 완료되었습니다.", "결재알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                paymentviewer();
            }
            else if(paymentprocesscount + 1 == usercount && usercount == 3)
            {
                string second_payment_accepttime = "UPDATE 결재 SET 진행상황 = 진행상황 + 1, 3승인시간 = '" + paymenttime + "'" + "WHERE ID = " + id;
                DBManager.GetInstance().DBquery(second_payment_accepttime);
                MessageBox.Show(paymenttime + "에 결재가 완료되었습니다.", "결재알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                paymentviewer();
            }
            else
            {
                MessageBox.Show("현재 결재할 수 있는 사용자가아닙니다.", "결재알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonPayment_Deny_Click(object sender, EventArgs e) // 결재반려를 누를 시
        {
            string selected = PaymentListView.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            if (paymentprocesscount + 1 == usercount)
            {
                labelpaymentdeny.Visible = true;
                textBoxPaymentdenymemo.Visible = true;
                buttonDenycheck.Visible = true;
            }
            else
            {
                MessageBox.Show("현재 반려할 수 있는 사용자가아닙니다.", "결재알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PaymentListView_CellClick(object sender, DataGridViewCellEventArgs e) // 그냥 셀 클릭 시
        {
            string selected = PaymentListView.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            string commentquery = "SELECT * FROM 결재 WHERE ID = " + id;
            MySqlDataReader rdr = DBManager.GetInstance().select(commentquery);
            while (rdr.Read())
            {
                textBoxComent.Text = rdr["코멘트"].ToString();
            }
            rdr.Close();
        }
        private void paymentform_Load(object sender, EventArgs e) // 결재확인 load
        {
            paymentviewer();
        }
        private void buttonDenycheck_Click(object sender, EventArgs e) // 결재반려 후 확인을 누르면
        {
            string selected = PaymentListView.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            if (MessageBox.Show("결재를 반려하시겠습니까?", "결재반려확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string paymentdenymemo = "UPDATE 결재 SET 반려메모 ='" + textBoxPaymentdenymemo.Text + "'" + "," + "반려여부 = '1'" + "WHERE ID = " + id;
                DBManager.GetInstance().DBquery(paymentdenymemo);
                MessageBox.Show("결재가 반려되었습니다.", "결재반려", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                paymentviewer();
            }
            else
            {
                MessageBox.Show("결재반려가 취소되었습니다.", "결재반려취소", MessageBoxButtons.OK);
            }
        }
        private void PaymentListView_CellContentClick(object sender, DataGridViewCellEventArgs e) // 업무 그리드뷰 클릭 시
        {
            int rowIndex = PaymentListView.CurrentCellAddress.Y;
            string num = PaymentListView.Rows[rowIndex].Cells[0].Value.ToString();
            int selectedId = Convert.ToInt32(num);
            int firstpaymentid = 0;
            int secondpaymentid = 0;
            int thirdpaymentid = 0;
            string checkpayment1 = "SELECT 진행상황,결재자수,제1결재자,제2결재자" +
                ",ifnull(제3결재자,0)AS 제3결재자 FROM 결재 WHERE ID = " + selectedId;
            MySqlDataReader rdr = DBManager.GetInstance().select(checkpayment1);

            while(rdr.Read())
            {
                paymentprocesscount = Convert.ToInt32(rdr["진행상황"].ToString()); // 진행상황 값 받아오기
                firstpaymentid = Convert.ToInt32(rdr["제1결재자"].ToString()); // 제 1결재자 값 받아오기
                secondpaymentid = Convert.ToInt32(rdr["제2결재자"].ToString()); // 제 2결재자 값 받아오기
                thirdpaymentid = Convert.ToInt32(rdr["제3결재자"].ToString()); // 제 3결재 값 받아오기
            }

            if(firstpaymentid == id)
            {
                usercount = 1;
            }
            else if(secondpaymentid == id)
            {
                usercount = 2;
            }
            else if(thirdpaymentid == id)
            {
                usercount = 3;
            }
        }
    }
}
