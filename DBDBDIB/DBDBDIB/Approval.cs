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
    public partial class Approval : Form
    {
        HRInfo hr = new HRInfo();
        public Approval()
        {
            InitializeComponent();
            initBox();
        }
        private void initBox()
        {
            tbDeptfSearch.Text = null;
            tbInsertDeptManager.Text = null;
            tbInsertDeptName.Text = null;
            
            //getDGV(dgvDeptView, "ID AS 부서ID, 부서명, 부서장, name AS 사원이름", "부서 LEFT JOIN Employee ON identification = 부서장", " WHERE ID>1 AND valid=1");
        }
        private void insertDeptInfoDB()
        {
            hr.deptName = tbInsertDeptName.Text;
            hr.deptMaster = tbInsertDeptManager.Text;
        }
        private void getDGV(DataGridView dgv, string column, string table, string data)
        { 
            dgv.DataSource = hr.selectDGV(column, table, data);
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void bDeptEnroll_Click(object sender, EventArgs e)
        {
            insertDeptInfoDB();
            DataTable dt = hr.selectDGV("COUNT(*)", "부서", " WHERE 부서명='"+hr.deptName+"'");
            if (Convert.ToInt32(dt.Rows[0][0])>0)
            {
                MessageBox.Show("기입하신 부서명과 동일한 부서가 이미 존재합니다.");
                return;
            }
            try
            {
                hr.insertHRData("부서", "부서명,부서장,valid", hr.insertQuery(2));//그리드에서 선택한값
            }
            catch
            {
                MessageBox.Show("모든 항목을 기입해주십시오.");
                return;
            }
            dt =hr.selectDGV("ID, name", "부서,Employee", hr.searchQuery(10)+ " AND department>1 AND 부서.valid=1 AND Employee.valid=1");
            hr.ChangeDept(Convert.ToString(dt.Rows[0][0]),1);
            getDGV(dgvDeptView, "ID AS 부서ID, 부서명, 부서장, name AS 사원이름", "부서 LEFT JOIN Employee ON identification = 부서장", " WHERE ID>1 AND 부서.valid=1 AND Employee.valid=1");
            //dgvDeptView.Rows.Add(dt.Rows[0][0], tbInsertDeptName.Text, tbInsertDeptManager.Text, dt.Rows[0][1]);
            dgvDeptView.CurrentCell = dgvDeptView.Rows[dgvDeptView.Rows.Count - 2].Cells[0];
            initBox();
        }

        private void bDeptEdit_Click(object sender, EventArgs e)
        {
            insertDeptInfoDB();
            if (tbInsertDeptManager.Text=="")
            {
                MessageBox.Show("부서장을 입력해주십시오.");
                return;
            }
            try
            {
                hr.updateHRData("부서", hr.updateQuery(2));//그리드에서 선택한값
            }
            catch
            {
                MessageBox.Show("모든 항목을 기입해주십시오.");
                return;
            }
            hr.ChangeDept(hr.deptID,2);
            DataTable dt = hr.selectDGV("ID,name", "부서,Employee", hr.searchQuery(8));
            dgvDeptView.Rows[dgvDeptView.CurrentRow.Index].SetValues(dt.Rows[0][0],tbInsertDeptName.Text, tbInsertDeptManager.Text, dt.Rows[0][1]);
            getDGV(dgvEmpSearchView, "identification AS 사원번호, name AS 사원이름, 부서명, position AS 직급", "부서,Employee", " WHERE Employee.valid=1 AND ID>1 AND ID = department AND ID=" + hr.deptID);
            initBox();
        }

        private void bDeptDelete_Click(object sender, EventArgs e)
        {

            insertDeptInfoDB();
            if (hr.deptID == null) {
                MessageBox.Show("삭제할 부서를 선택해주십시오.");
                return;
            }
                
            if (hr.selectDGV("identification", "Employee", " WHERE department=" + hr.deptID).Rows.Count != 0)
            {
                MessageBox.Show("부서 내 인원이 남아있어 부서를 삭제할 수 없습니다.");
                return;
            }
            hr.updateHRData("부서", hr.updateQuery(3));//그리드에서 선택한값
            dgvDeptView.Rows.RemoveAt(dgvDeptView.CurrentRow.Index);
            getDGV(dgvEmpSearchView, "identification AS 사원번호, name AS 사원이름, 부서명, position AS 직급", "부서,Employee", " WHERE Employee.valid=1 AND ID>1 AND ID = department AND ID=" + hr.deptID);
            initBox();
        }

        private void bDeptEmpSearch_Click(object sender, EventArgs e)
        {
            //버튼으로 부터 받은 값을 HRInfo로 보내고 HR에서 쿼리를 작성해 DBManager로 보냄>HR에서 셀렉트를 사용
            string query= " WHERE Employee.valid = 1 AND ID> 1 AND ID = department";
            insertDeptInfoDB();
            if (tbDeptfSearch.Text != "")
                query+= " AND ID=" + tbDeptfSearch.Text;
            getDGV(dgvEmpSearchView, "identification AS 사원번호, name AS 사원이름, 부서명, position AS 직급", "부서,Employee", query);
        }

        private void dgvDeptView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDeptView.SelectedRows[0].Index < dgvDeptView.Rows.Count - 1)
            {
                hr.deptID = Convert.ToString(dgvDeptView.Rows[dgvDeptView.SelectedRows[0].Index].Cells[0].Value);
                tbInsertDeptName.Text = Convert.ToString(dgvDeptView.Rows[dgvDeptView.SelectedRows[0].Index].Cells[1].Value);
                tbInsertDeptManager.Text = Convert.ToString(dgvDeptView.Rows[dgvDeptView.SelectedRows[0].Index].Cells[2].Value);
            }
        }

        private void bDeptLookUp_Click(object sender, EventArgs e)
        {
            getDGV(dgvDeptView, "ID AS 부서ID, 부서명, identification AS 부서장, name AS 사원이름", "부서 LEFT JOIN (SELECT * FROM erp_school.Employee WHERE valid=1) AS 사원 ON identification = 부서장", " WHERE ID>1 AND 부서.valid=1");
        }

    }
}
