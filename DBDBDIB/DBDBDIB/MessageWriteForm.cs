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
    public partial class MessageWriteForm : Form
    {
        UserInfo UserManager = UserInfo.Getinstance();
        DBManager DBmanager = DBManager.GetInstance();
        public MessageWriteForm()
        {
            InitializeComponent();
        }

        private void txtMsgBox_TextChanged(object sender, EventArgs e)
        {
            labelTextLength.Text = txtMsgBox.Text.Length.ToString();
            // 애초에 1000자 넘는 글자를 복붙하면 동작 안합니다..
            // 999자 쓰고 한자씩 더 추가하려하면 들어가지 않는 코드 입니다.
            if(txtMsgBox.Text.Length > 1000)
            {
                var txtBox = new RichTextBox();
                txtBox.Text = txtMsgBox.Text.Substring(0, txtMsgBox.Text.Length - 1);
                txtMsgBox.Text = txtBox.Text;
                txtMsgBox.Focus();
                txtMsgBox.Select(txtMsgBox.Text.Length, 0);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // 유저 -> 다른 유저에게 보내기
            // 텍스트 박스에 받아온 데이터를 가지고 검색 후 Insert

            string title = txtMsgTitle.Text.ToString();
            string content = txtMsgBox.Text.ToString();

            try
            {
                string query = String.Format("INSERT INTO 쪽지(보낸사람, 받는사람, 제목, 내용) " +
                    "VALUES({0}, {1}, '{2}', '{3}')", UserManager.Id, txtSendToWhom.Text.ToString(), title, content);
                DBmanager.DBquery(query);
            }
            catch
            {
                MessageBox.Show("정상적으로 발송되지 않았습니다.");
                return;
            }
            MessageBox.Show("정상적으로 발송 되었습니다.");
            txtSendToWhom.Text = "";
            txtMsgTitle.Text = "";
            txtMsgBox.Text = "";
        }

        private void btnAddr_Click(object sender, EventArgs e)
        {
            MessageViewMember newForm = new MessageViewMember(this);
            newForm.Show();
        }
    }
}
