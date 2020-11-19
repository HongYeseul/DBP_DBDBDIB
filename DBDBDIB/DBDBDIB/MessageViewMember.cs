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
    public partial class MessageViewMember : Form
    {
        DBManager DBmanager = DBManager.GetInstance();
        UserInfo UserManager = UserInfo.Getinstance();

        MessageWriteForm writeForm;

        public MessageViewMember()
        {
            InitializeComponent();
        }
        public MessageViewMember(MessageWriteForm form)
        {
            InitializeComponent();
            writeForm = form;
        }

        private void MessageViewMember_Load(object sender, EventArgs e)
        {
            /// 사원이 삭제되었을 때는 보이지 않으나 부서가 삭제됐을 때는 고려를 하지 않음.
            /// 부서가 삭제되면 사원도 같이 옮기는 시나리오로 생각함.
            string query = "SELECT identification AS 사번, 부서명, name AS 이름 FROM Employee join 부서 on Employee.department = 부서.ID WHERE identification not in ('" + UserManager.Id + "') AND Employee.valid = 1";

            MySqlDataReader rdr = DBmanager.select(query);

            DataTable dt = new DataTable();
            dt.Load(rdr);
            viewAddr.DataSource = dt;

            rdr.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //폼 닫히면서 데이터 전송
            //writeForm.txtSendToWhom.Text = listBox1.SelectedItem.ToString();

            int rowIndex = viewAddr.CurrentRow.Index;

            Console.WriteLine(viewAddr.Rows[rowIndex].Cells[0].Value.ToString());
            writeForm.txtSendToWhom.Text = viewAddr.Rows[rowIndex].Cells[0].Value.ToString();

            this.Close();
        }
    }
}
