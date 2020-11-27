using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using MySql.Data.MySqlClient;

namespace DBDBDIB
{
    public partial class taskmasterform : Form
    {
        
        public taskmasterform()
        {
            InitializeComponent();
            TaskmasterView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TaskmasterView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            buttonCellClickCancel.Visible = false;
            TaskmasterView.MultiSelect = false;
            TaskmasterView.AllowUserToAddRows = false;
            fillcombo();
        }
        string strconn = "Server=49.50.174.201;Database=erp_school;Uid=dbdbdib;Pwd=123123;Charset=utf8";

        void fillcombo() // 콤보박스에 부서를 넣을 것임
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string Combolist = "SELECT * FROM 부서";
                MySqlCommand cmd = new MySqlCommand(Combolist, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string listname = rdr.GetString("부서명");
                    comboBoxAFcompany.Items.Add(listname);
                }
                rdr.Close();
                conn.Close();
            }
        }
        private void syndataview() // 동기화 함수
        {
            TaskmasterView.Rows.Clear();
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string Tasklist = "SELECT 업무번호,부서,업무종류,업무내용 FROM 업무마스터 WHERE 업무유효성 = 1";
                MySqlCommand cmd = new MySqlCommand(Tasklist, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int ii = 0;
                while (rdr.Read())
                {
                    TaskmasterView.Rows.Add();
                    for (int i = 0; i < 4; i++) // index 0 ~ 3까지 존재
                        TaskmasterView.Rows[ii].Cells[i].Value = rdr[i].ToString();
                    ii++;
                }
                rdr.Close();
                conn.Close();
            }
            comboBoxAFcompany.Text = "";
            comboBoxTaskKind.Text = "";
            textBoxTaskContents.Text = "";
        }
        private void button_Task_Rectify_Click(object sender, EventArgs e) // 수정 버튼
        {
            button_Task_Apply.Visible = true;
            string selected = TaskmasterView.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            if (comboBoxAFcompany.Text == "") // 소속에 아무것도 없으면
            {
                MessageBox.Show("소속명을 기입하십시오", "업무수정오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(comboBoxTaskKind.Text == "") // 업무종류를 선택하지 않으면
            {
                MessageBox.Show("업무종류를 선택해주세요", "업무수정오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBoxTaskContents.Text == "") // 업무내용에 아무것도 없으면
            {
                MessageBox.Show("업무내용을 기입하십시오", "업무수정오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("업무를 수정하시겠습니까?", "업무수정확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string updatetask = "UPDATE 업무마스터 SET  부서 = '" + comboBoxAFcompany.Text + "'" + "," +
                    "업무종류 = '" + comboBoxTaskKind.Text + "'" + "," + "업무내용 = '" + textBoxTaskContents.Text + "'" +
                     "WHERE 업무번호 = " + id + "";
                    DBManager.GetInstance().DBquery(updatetask);
                    MessageBox.Show("업무가수정되었습니다.", "업무수정확인", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    syndataview();
                }
                else
                {
                    MessageBox.Show("업무수정이 취소되었습니다.", "업무수정취소", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void button_Task_Delete_Click(object sender, EventArgs e) // 삭제 버튼
        {
            button_Task_Apply.Visible = true;
            string selected = TaskmasterView.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            
            if (MessageBox.Show("이 업무는 정말 삭제하시겠습니까? 삭제하시면 더이상 결재가 불가능한 업무입니다.", "업무삭제확인", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string deleteflagtask = "UPDATE 업무마스터 SET 업무유효성 = 0 Where 업무번호 = " + id + "";
                DBManager.GetInstance().DBquery(deleteflagtask);
                MessageBox.Show("이 업무는 더이상 결재 할 수 없습니다.", "업무삭제확인", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                syndataview();
            }
            else 
            {
                MessageBox.Show("업무삭제가 취소되었습니다.", "업무삭제취소", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button_Task_Apply_Click(object sender, EventArgs e) // 등록 버튼
        {
            string AFcompany = comboBoxAFcompany.Text;
            string Taskkind = comboBoxTaskKind.Text;
            string TaskContents = textBoxTaskContents.Text;
            MySqlDataReader count = DBManager.GetInstance().select("SELECT COUNT(*) as cnt FROM 업무마스터 WHERE 부서 = '" + AFcompany + "'" +
                "AND 업무종류 = '" + Taskkind + "'" + "AND 업무내용 = '" + TaskContents + "'"); // 중복여부 확인
            int overlapflag = 0;
            while (count.Read())
            {
                overlapflag = Convert.ToInt32(count["cnt"]); // 중복여부 확인을 정수로 선언
            }
            if (overlapflag == 0) // 중복된 값이 없으면
            {
                if (AFcompany == "") // 소속을 안 적으면
                {
                    MessageBox.Show("소속을 입력해주세요", "업무등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Taskkind == "") // 업무종류를 안 적으면
                {
                    MessageBox.Show("업무종류를 입력해주세요", "업무등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TaskContents == "") // 업무내용을 안 적으면
                {
                    MessageBox.Show("업무내용을 입력해주세요", "업무등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // 업무유효성은 1로 지정(초기값) => 데이터 그리뷰에 있는 내용을 보고 적을 수도 있어서 중복방지를 할려고 함
                {
                    if (MessageBox.Show("업무를 등록하시겠습니까?", "업무등록확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string addtask = "INSERT INTO 업무마스터(부서,업무종류,업무내용,업무유효성)" +
                        "VALUES('" + AFcompany + "','" + Taskkind + "','" + TaskContents + "'" + "," + "1)";
                        DBManager.GetInstance().DBquery(addtask);
                        MessageBox.Show("등록되었습니다.", "업무등록확인", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        syndataview();
                    }
                    else
                    {
                        MessageBox.Show("업무등록이 취소되었습니다.", "업무등록취소", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else // 중복된 값이 있으면
            {
                MessageBox.Show("중복된 업무는 등록할 수 없습니다.", "등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TaskmasterView_CellClick(object sender, DataGridViewCellEventArgs e) // datagridview의 셀을 누르면 발생하는 이벤트
        {
            button_Task_Apply.Visible = false;
            buttonCellClickCancel.Visible = true; // 혹시나 등록하고 싶은데 셀을 잘 못 입력하면
            comboBoxAFcompany.Text = TaskmasterView.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxTaskKind.Text = TaskmasterView.SelectedRows[0].Cells[2].Value.ToString();
            textBoxTaskContents.Text = TaskmasterView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e) // 업무마스터 폼 실행할 시
        {
            syndataview();
        }

        private void buttonCellClickCancel_Click(object sender, EventArgs e) // 수정/삭제 취소 시
        {
            buttonCellClickCancel.Visible = false;
            button_Task_Apply.Visible = true;
            TaskmasterView.ClearSelection();
            comboBoxAFcompany.Text = "";
            comboBoxTaskKind.Text = "";
            textBoxTaskContents.Text = "";
        }
    }
}
