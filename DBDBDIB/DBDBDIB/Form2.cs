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

        private void syndataview() // 동기화
        {
            TaskmasterView.Rows.Clear();
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string Tasklist = "SELECT * FROM 업무마스터";
                MySqlCommand cmd = new MySqlCommand(Tasklist, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int ii = 0;
                while (rdr.Read())
                {
                    TaskmasterView.Rows.Add();
                    for (int i = 0; i < 5; i++) // index 0 ~ 4까지 존재
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
                string updatetask = "UPDATE 업무마스터 SET  부서 = '" + comboBoxAFcompany.Text + "'" + "," +
                    "업무종류 = '" + comboBoxTaskKind.Text + "'" + "," + "업무내용 = '" + textBoxTaskContents.Text + "'" +
                     "WHERE 업무번호 = " + id + "";
                DBManager.GetInstance().DBquery(updatetask);
                MessageBox.Show("수정되었습니다.", "업무수정확인", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                syndataview();
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
                MessageBox.Show("취소되었습니다.", "업무삭제취소", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_Task_Apply_Click(object sender, EventArgs e) // 등록 버튼
        {
            if (comboBoxAFcompany.Text == "") // 소속을 안 적으면
            {
                MessageBox.Show("소속을 입력해주세요", "업무등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxTaskKind.Text == "") // 업무종류를 안 적으면
            {
                MessageBox.Show("업무종류를 입력해주세요", "업무등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxTaskContents.Text == "") // 업무내용을 안 적으면
            {
                MessageBox.Show("업무내용을 입력해주세요", "업무등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // 업무유효성은 1로 지정(초기값)
            {
                string addtask = "INSERT INTO 업무마스터(부서,업무종류,업무내용,업무유효성)" +
                "VALUES('" + comboBoxAFcompany.Text + "','" + comboBoxTaskKind.Text +
                "','" + textBoxTaskContents.Text + "'" + "," + "1)";
                 DBManager.GetInstance().DBquery(addtask);
                 MessageBox.Show("등록되었습니다.", "업무등록확인", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 syndataview();
            }
        }
        private void TaskmasterView_CellClick(object sender, DataGridViewCellEventArgs e) // datagridview의 셀을 누르면 발생하는 이벤트
        {
            button_Task_Apply.Visible = false;
            comboBoxAFcompany.Text = TaskmasterView.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxTaskKind.Text = TaskmasterView.SelectedRows[0].Cells[2].Value.ToString();
            textBoxTaskContents.Text = TaskmasterView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e) // 업무마스터 폼 실행할 시
        {
            syndataview();
        }
    }
}