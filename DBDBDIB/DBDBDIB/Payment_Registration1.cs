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
    public partial class Payment_Registration1 : Form
    {
        string title="";
        string content="";
        int selectedId=0;
        string coment="";

        ForPaymentReg listbox = new ForPaymentReg();//처음사용자에게 업무마스터의 일을 띄어줄때사용할겁니다.
        public Payment_Registration1()
        {
            InitializeComponent();
            SetForm();
        }
        
        public void SetForm()
        {
            textBoxTitle.Text = "";
            textBoxContent.Text = "";
            textBoxSelected.Text = "";
            ListLoad();
            textBoxComent.Text = "";
        }
        public void ListLoad()
        {
            listBoxforWork.Items.Clear();//listbox초기화
            //MySqlDataReader set=listbox.SetWork();
            //while(set.Read())
            //{
                listBoxforWork.Items.Add("");//업무내용을 들고오고
            //}
        }
        private void listBoxforWork_SelectedIndexChanged(object sender, EventArgs e)//사용자가 업무를 선택한경우 
        {
            // 사용자가 선택한 업무내용이 어떤 업무id랑 매칭되는지 알필요있음....부서도 들고와야할듯..그리드뷰가 맞을까....
            //textBoxSelected초기화 필요
            //selectedId 초기화 필요
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            //title,content,selectedId는 null즉 빈값이면 안됨
            title = textBoxTitle.Text;
            content = textBoxContent.Text;
            coment = textBoxComent.Text;

            Payment_Registration2 set2 = new Payment_Registration2();
            
            set2.SetReg1(title, content, selectedId, coment);
            set2.Show();
            this.Hide();//hide로만 처리하면 되는가.. 내일 회의하고 이거 처리 어떻게했는지 묻고 없애는 법있으면 그방법을 적용
        }

        
    }
}
