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
    public partial class TodayWorkSaveChange : Form
    {
        private string CASE = "";
        public TodayWorkSaveChange(string buttonText,int id =0)
        {
            InitializeComponent();
            //등록인지 수정인지 버튼 수정
            buttonSaveANDChange.Text = buttonText;
            this.CASE = buttonText;

            //만약 수정이면 기본 combobox 세팅
            if (CASE.Equals("수정"))
            {

            }

        }

        
        
        
        
        //콤보박스 값들은 이벤트에 따라 바뀌여야함. 

        private void button1_Click(object sender, EventArgs e)
        {
            //날짜,등록자, 소분류에서 선택된 업무마스터 id 값 (button text에 따라 등록 || 수정)

        }

        private void comboBox소속_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox업무종류_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox업무내용_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
