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
            /// 코드 수정 필요 -> 사번으로 데이터 넘겨줘야합니다. !!!!!!!!!!
            string query = "SELECT * FROM Employee WHERE identification not in ('" + UserManager.Id + "')";

            MySqlDataReader rdr = DBmanager.select(query);

            while (rdr.Read())
            {
                string row = rdr["name"].ToString();
                listBox1.Items.Add(row);
            }

            rdr.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //폼 닫히면서 데이터 전송
            writeForm.txtSendToWhom.Text = listBox1.SelectedItem.ToString();
            this.Close();
        }
    }
}
