using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Paddings;

namespace DBDBDIB
{
    public partial class Personnel : Form
    {
        HRInfo hr=new HRInfo();
        public Personnel()
        {
            InitializeComponent();
            initVariables();
            initbox();
        }
        private void initVariables()
        {
            DataTable categoryItem = hr.selectDGV("ID, 부서명","부서"," WHERE ID>1 AND valid=1");
            string[] rank = { "부서장", "사원" };
            cbCategory.Items.Add("전체");
            for (int i = 0; i < categoryItem.Rows.Count; i++) {
                cbCategory.Items.Add(categoryItem.Rows[i][1]+"-"+ categoryItem.Rows[i][0]);
                cbInsertDept.Items.Add(categoryItem.Rows[i][1]);
            }
            for (int i = 0; i < rank.Length; i++)
                cbInsertRank.Items.Add(rank[i]);

            cbInsertGender.Items.Add("남");
            cbInsertGender.Items.Add("여");

            getDGV(dgvEmpManageView, "identification AS 사원ID, name AS 사원명, gender AS 성별, birthDay AS 생년월일, phoneNum AS 전화번호, address AS 주소, 부서명 AS 소속부서, position AS 직급, email", "Employee,부서", " WHERE department>1 AND Employee.valid=1 AND department=ID");           
        }
        private void initbox() {
            cbCategory.SelectedIndex = 0;
            cbInsertDept.SelectedIndex = 0;
            cbInsertGender.SelectedIndex = 0;
            tbYear.Text = null;
            tbName.Text = null;
            tbInsertName.Text = null;
            tbInsertPhone.Text = null;
            tbInsertPost.Text = null;
            tbInsertAddress1.Text = null;
            tbInsertAddress2.Text = null;
            tbPW.Text = null;
            tbPWcheck.Text = null;
            tbemail.Text = null;
        }
        private void insertsearchDB()
        {
           if(cbCategory.Text!="전체")
                hr.searchDept = cbCategory.Text.Split('-')[1];
            hr.searchYear = tbYear.Text;
            hr.searchName = tbName.Text;
        }
        private void insertInfoDB()
        {
            hr.empCategory = cbInsertDept.Text;
            hr.empgender = cbInsertGender.Text;                      
            hr.empName = tbInsertName.Text;
            hr.empPhone = tbInsertPhone.Text;
            hr.empPost = tbInsertPost.Text;
            hr.empBirth = dPBirth.Value.ToString("yyyy-MM-dd");
            hr.empAddress1 = tbInsertAddress1.Text;
            hr.empAddress2 = tbInsertAddress2.Text;
            hr.empRank = cbInsertRank.Text;
            hr.empPassword = tbPW.Text;
            hr.empPasswordCheck = tbPWcheck.Text;
            hr.empEmail = tbemail.Text;
        }
        private void getDGV(DataGridView dgv, string column, string table, string data)
        {
            dgv.DataSource = hr.selectDGV(column,table,data);
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        #region handler
        private void bEmpSearch_Click(object sender, EventArgs e)
        {
            //버튼으로 부터 받은 값을 HRInfo로 보내고 HR에서 쿼리를 작성해 DBManager로 보냄>HR에서 셀렉트를 사용
            int parameter = 0;
            if (cbCategory.Text != "전체")
                parameter += 1;
            if (tbYear.Text != "")
                parameter += 2;
            if (tbName.Text != "")
                parameter += 4;

            insertsearchDB();
            getDGV(dgvEmpView, "identification AS 사원ID, name AS 사원명, gender AS 성별, birthDay AS 생년월일, phoneNum AS 전화번호, address AS 주소, 부서명 AS 소속부서, position AS 직급, email", "Employee,부서", " WHERE Employee.valid=1 AND department=ID"+hr.searchQuery(parameter));
        }
        private void bEnroll_Click(object sender, EventArgs e)
        {
            //사원등록- 버튼으로 부터 받은 값을 HRInfo로 보내고 HR에서 DBManager로 보내서 DB에 Insert 
            //겹치는게 있으면 겹치는게 있다고 말해야함
            if (tbPW.Text != tbPWcheck.Text)
            {
                MessageBox.Show("비밀번호가 맞지 않습니다. 다시 입력해주세요.");
                tbPWcheck = null;
                return;
            }
            insertInfoDB();
            hr.insertHRData("Employee", "password, name, gender, birthDay, phoneNum, department, position, address, email,valid", hr.insertQuery(1));//추가-테이블에 넣음
            getDGV(dgvEmpManageView, "identification AS 사원ID, name AS 사원명, gender AS 성별, birthDay AS 생년월일, phoneNum AS 전화번호, address AS 주소, 부서명 AS 소속부서, position AS 직급, email", "Employee,부서", " WHERE department>1 AND Employee.valid=1 AND department=ID");
            dgvEmpManageView.CurrentCell = dgvEmpManageView.Rows[dgvEmpManageView.Rows.Count - 1].Cells[0];
            initbox();
        }
        private void bEdit_Click(object sender, EventArgs e)
        {
            //선택된 row를 버튼에 뒤집어 씌워야하니까 읽어온걸 버튼에 띄울 수 있어야 함  HR에서는 return할게 필요함
            //클릭하면 dgv에 있는 내용 textbox 채우기
            string query = "";
            if (tbPW.Text != tbPWcheck.Text)
            {
                MessageBox.Show("비밀번호가 맞지 않습니다. 다시 입력해주십시오.");
                tbPWcheck = null;
                return;
            }
            insertInfoDB();

            if (hr.empRank == "부서장")
            {
                if (hr.selectDGV("identification", "Employee", " WHERE position = '부서장' AND identification<>'" + hr.empID + "' AND department in (SELECT ID FROM 부서 WHERE 부서명='"+hr.empCategory+"')").Rows.Count != 0)
                {
                    MessageBox.Show("해당 부서에는 이미 부서장이 존재합니다.");
                    cbInsertRank.SelectedIndex = 1;
                    return;
                }
                query += "UPDATE 부서 SET 부서장=" + hr.empID + " WHERE  부서명='" + hr.empCategory + "'; ";
            }

            else if (hr.empRank == "사원")
                query += "UPDATE 부서 SET 부서장=NULL WHERE 부서장=" + hr.empID + "; ";

            try {
                hr.updateHRData(query,"Employee", hr.updateQuery(1));//그리드에서 선택한값-테이블에 넣음
            }
            catch
            {
                MessageBox.Show("모든 항목을 기입해주십시오.");
                return;
            }
            string address = tbInsertPost.Text + "/" + tbInsertAddress1.Text + "/" + tbInsertAddress2.Text;
            //getDGV(dgvEmpManageView, "identification AS 사원ID, name AS 사원명, gender AS 성별, birthDay AS 생년월일, phoneNum AS 전화번호, address AS 주소, 부서명 AS 소속부서, position AS 직급, email", "Employee,부서", " WHERE department>1 AND Employee.valid=1 AND department=ID");
            dgvEmpManageView.Rows[dgvEmpManageView.CurrentRow.Index].SetValues(hr.empID, hr.empName, hr.empgender, hr.empBirth, hr.empPhone, address, cbInsertDept.Text, hr.empRank, hr.empEmail);
            initbox();
        }
        private void bDelete_Click(object sender, EventArgs e)
        {
            //선택된 row를 HR에서 삭제 쿼리를 작성해주도록
            //여기서 사원 급여 테이블에서도 삭제하도록 해줘야함. 사원번호로.
            //클릭하면 dgv에 있는 내용 textbox 채우기
            insertInfoDB();
            if (hr.empRank=="부서장")
            {
                MessageBox.Show("먼저 부서장 직책을 위임해주십시오.");
                return;
            }
            hr.updateHRData("","Employee", hr.updateQuery(4));//그리드에서 선택한값-테이블에서 삭제
            dgvEmpManageView.Rows.RemoveAt(dgvEmpManageView.CurrentRow.Index);
            initbox();
        }
        #endregion

        private void dgvEmpManageView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvEmpManageView.SelectedRows[0].Index < dgvEmpManageView.Rows.Count) {
                hr.empID = Convert.ToString(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[0].Value);
                tbInsertName.Text = Convert.ToString(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[1].Value);
                cbInsertGender.Text = Convert.ToString(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[2].Value);
                dPBirth.Value = Convert.ToDateTime(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[3].Value);
                tbInsertPhone.Text = Convert.ToString(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[4].Value);
                tbInsertPost.Text = Convert.ToString(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[5].Value).Split('/')[0];
                tbInsertAddress1.Text = Convert.ToString(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[5].Value).Split('/')[1];
                tbInsertAddress2.Text = Convert.ToString(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[5].Value).Split('/')[2];
                cbInsertDept.Text = Convert.ToString(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[6].Value);
                cbInsertRank.Text = Convert.ToString(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[7].Value);
                tbemail.Text = Convert.ToString(dgvEmpManageView.Rows[dgvEmpManageView.SelectedRows[0].Index].Cells[8].Value);
                tbPW.Text = hr.selectDGV("password", "Employee", " WHERE identification=" + hr.empID).Rows[0][0].ToString();
                tbPWcheck.Text = tbPW.Text;
            }
            
        }
        private void bPostSearch_Click(object sender, EventArgs e)
        {
            Post ps = new Post(this);
            ps.Show();
        }
    }
}
