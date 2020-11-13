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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
        }

        private void hideSubMenu() //상위 버튼(인사/업무/결재) 클릭 시 숨기는 용도
        {
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
            if (panel6.Visible == true)
                panel6.Visible = false;

        }

        private void showSubMenu(Panel submenu) //하위 메뉴 보임 숨김 토글
        {
            if (submenu.Visible == false)
            {
                hideSubMenu(); // 다른 하위 패널이 열려있을 때 닫아줌
                submenu.Visible = true;
            }
            else 
                submenu.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e) //인사 버튼
        {
            showSubMenu(panel3); //인사 하위 메뉴 보임 숨김
        }

        private void button2_Click(object sender, EventArgs e) //인사>사원등록 버튼
        {
            showChildForm(new Personnel());
        }

        private void button3_Click(object sender, EventArgs e)//인사>부서/사원 관리 버튼
        {
            showChildForm(new Approval());
        }

        private void button4_Click(object sender, EventArgs e)//인사>급여내역서 버튼
        {
            showChildForm(new SalaryDetail());
        }

        private void button5_Click(object sender, EventArgs e)//업무 버튼
        {
            showSubMenu(panel4); //업무 하위 메뉴 보임 숨김
        }

        private Form activateForm = null;
        private void showChildForm(Form child) // 오른쪽 창에 다른 폼(매개변수) 열기
        {
            if (activateForm != null)
                activateForm.Close(); //열려는 폼 외에 다른 폼이 열려있다면 먼저 닫아줌
            activateForm = child; //열고 싶은 폼을 엶
            
            //서브 폼의 꾸밈 설정
            child.TopLevel = false; // 최상위가 아님> 왜 하는거지
            child.FormBorderStyle = FormBorderStyle.None; //테두리 없음
            child.Dock = DockStyle.Fill; //(패널)중앙에 고정

            panel5.Controls.Add(child); //패널에 열려는 폼 추가
            panel5.Tag = child; //폼 설정..
            child.BringToFront();
            child.Show(); // 폼 보이기

            //열려는 폼은 패널의 크기에 맞춰서 만들기
        }

        private void buttonTodayWork_Click(object sender, EventArgs e)
        {
            showChildForm(new TodayWork());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panel6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showChildForm(new Payment_Registration1());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showChildForm(new ApprovalListForm());
        }
    }
}
