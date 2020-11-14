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
    public partial class MessageMainForm : Form
    {
        String msgDetails = "{0,-10}{1, -20}{2, 20}";
        public MessageMainForm()
        {
            InitializeComponent();
        }

        private void MessageMainForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(String.Format(msgDetails, "읽음유무", "보낸사람", "제목"));

            listBox1.Items.Add(String.Format(msgDetails, "읽음", "재무팀", "입금내역서 안내"));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click");
        }

        private void btnNewMsg_Click(object sender, EventArgs e)
        {
            MessageWriteForm newForm = new MessageWriteForm();
            newForm.Show();
        }
    }
}
