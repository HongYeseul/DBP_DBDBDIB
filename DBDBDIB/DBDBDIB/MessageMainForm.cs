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
    public partial class MessageMainForm : Form
    {
        String msgDetails = "{0,-10}{1, 15}{2, 30}";
        DBManager DBmanager = DBManager.GetInstance();
        UserInfo UserManager = UserInfo.Getinstance();
        List<string> ls = new List<string>();

        enum Search
        {
            보낸사람,
            제목,
            내용
        }
        private Search _selectedSearch;
        string SearchQuery;

        public MessageMainForm()
        {
            InitializeComponent();
        }

        private void LoadMessage()
        {
            listBox1.Items.Clear();
            ls.Clear();
            listBox1.Items.Add(String.Format(msgDetails, "읽음유무", "보낸사람", "제목"));

            string query = "SELECT * FROM 쪽지 join Employee on 쪽지.보낸사람 = Employee.identification WHERE 받는사람 = " + UserManager.Id;
            MySqlDataReader rdr = DBmanager.select(query);
            while (rdr.Read())
            {
                string row = String.Format(msgDetails, rdr["수신확인"].ToString(), rdr["name"].ToString(), rdr["제목"].ToString());
                string idRow = rdr["id"].ToString(); // 새로운 폼 열 때 넘겨주기 위한 id list 저장
                ls.Add(idRow);
                listBox1.Items.Add(row);
                //Console.WriteLine(rdr["제목"].ToString());
            }

            foreach (string v in ls)
            {
                Console.WriteLine(v);
            }
            rdr.Close();
        }
        private void LoadMessage(string query)  //검색할 때 필요한 메서드
        {
            listBox1.Items.Clear();
            ls.Clear();
            listBox1.Items.Add(String.Format(msgDetails, "읽음유무", "보낸사람", "제목"));

            UserManager.Id = "5500000"; // 나중에 지워야함!!!!!!!!
            MySqlDataReader rdr = DBmanager.select(query);
            while (rdr.Read())
            {
                string row = String.Format(msgDetails, rdr["수신확인"].ToString(), rdr["name"].ToString(), rdr["제목"].ToString());
                string idRow = rdr["id"].ToString(); // 새로운 폼 열 때 넘겨주기 위한 id list 저장
                ls.Add(idRow);
                listBox1.Items.Add(row);
            }

            foreach (string v in ls)
            {
                Console.WriteLine(v);
            }
            rdr.Close();
        }

        private void MessageMainForm_Load(object sender, EventArgs e)
        {
            LoadMessage();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click");
            if (radioBtnContent.Checked == false && radioBtnTitle.Checked == false && radioBtnWhoSent.Checked == false)
                return; // 아무것도 선택 안되었을 때
            
            switch (_selectedSearch)
            {
                case Search.보낸사람:
                    Console.WriteLine("보낸사람을 기준으로 검색");
                    string whoSent = txtSearchWhoSent.Text;
                    SearchQuery = String.Format("SELECT * FROM 쪽지 join Employee on 쪽지.보낸사람 = Employee.identification " +
                        "WHERE 받는사람 = {0} AND name LIKE '%{1}%'",UserManager.Id, whoSent);
                    txtSearchWhoSent.Text = "";
                    break;
                case Search.제목:
                    Console.WriteLine("제목을 기준으로 검색");
                    string title = txtSearchTitle.Text;
                    SearchQuery = String.Format("SELECT * FROM 쪽지 join Employee on 쪽지.보낸사람 = Employee.identification " +
                        "WHERE 받는사람 = {0} AND 제목 LIKE '%{1}%'", UserManager.Id, title);
                    txtSearchTitle.Text = "";
                    break;
                case Search.내용:
                    Console.WriteLine("내용을 기준으로 검색");
                    string content = txtSearchContent.Text;
                    SearchQuery = String.Format("SELECT * FROM 쪽지 join Employee on 쪽지.보낸사람 = Employee.identification " +
                        "WHERE 받는사람 = {0} AND 내용 LIKE '%{1}%'", UserManager.Id, content);
                    txtSearchContent.Text = "";
                    break;
            }

            Console.WriteLine(SearchQuery);
            LoadMessage(SearchQuery);

        }

        private void btnNewMsg_Click(object sender, EventArgs e)
        {
            MessageWriteForm newForm = new MessageWriteForm();
            newForm.Show();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
                return;
            Console.WriteLine(ls[listBox1.SelectedIndex-1]);
            MessageDetail newForm = new MessageDetail(ls[listBox1.SelectedIndex - 1]);
            newForm.Show();
            //읽음으로 Update 후 폼 다시 로드

            string query = "UPDATE 쪽지 SET 수신확인 = '읽음' WHERE id = " + ls[listBox1.SelectedIndex - 1];
            DBmanager.DBquery(query);
            LoadMessage();
        }

        private void radioBtnWhoSent_CheckedChanged(object sender, EventArgs e)
        {
            this._selectedSearch = Search.보낸사람;
        }

        private void radioBtnContent_CheckedChanged(object sender, EventArgs e)
        {
            this._selectedSearch = Search.내용;
        }

        private void radioBtnTitle_CheckedChanged(object sender, EventArgs e)
        {
            this._selectedSearch = Search.제목;
        }

        private void btnAck_Click(object sender, EventArgs e)
        {
            MessageAck newForm = new MessageAck();
            newForm.Show();
        }
    }
}
