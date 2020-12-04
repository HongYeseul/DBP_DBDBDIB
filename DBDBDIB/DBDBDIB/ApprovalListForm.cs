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
    public partial class ApprovalListForm : Form
    {
        private string query = "";
        int id = Convert.ToInt32(UserInfo.Getinstance().Id); //로그인 계정
        public ApprovalListForm()
        {
            InitializeComponent();
            combo_Appr.Text = "";
        }

        private void combo_Appr_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combo_Appr.Text) //콤보박스 선택 변경마다 조건 변경
            {
                case "등록 결재 내역": //내가 기안자인 모든 결재 내역 
                    query = "SELECT a.ID as 번호,(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 기안자 FROM Employee WHERE identification = " + id + ") AS 기안자," +
                        "a.제목,a.내용,w.업무내용,a.코멘트,a.진행상황,a.결재자수,(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제1결재자) as 제1결재자," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제2결재자) as 제2결재자," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제3결재자) as 제3결재자," +
                        "a.기안자시간,a.1승인시간,a.2승인시간,a.3승인시간,a.반려메모 " +
                    "FROM 결재 as a, 업무마스터 as w WHERE 기안자 = " + id + " AND (a.관련업무 = w.업무번호) ORDER BY a.반려여부";
                    break;
                case "결재 중 내역": //내가 기안자인 결재 중 내역
                    query = "SELECT a.ID as 번호,(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 기안자 FROM Employee WHERE identification = " + id + ") AS 기안자," +
                        "a.제목,a.내용,w.업무내용,a.코멘트,a.진행상황,a.결재자수,(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제1결재자) as 제1결재자," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제2결재자) as 제2결재자," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제3결재자) as 제3결재자" +
                        ",a.기안자시간,a.1승인시간,a.2승인시간,a.3승인시간,a.반려메모 " +
                        "FROM 결재 as a, 업무마스터 as w WHERE 기안자 = " + id + " AND 진행상황 < 결재자수 AND (a.관련업무 = w.업무번호) AND 반려여부 = 0";
                    break;
                case "결재 완료 내역": //내가 기안자인 결재 완료 내역
                    query = "SELECT a.ID as 번호,(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 기안자 FROM Employee WHERE identification = " + id + ") AS 기안자," +
                        "a.제목,a.내용,w.업무내용,(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제1결재자) as 제1결재자," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제2결재자) as 제2결재자," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제3결재자) as 제3결재자," +
                        "a.기안자시간,a.1승인시간,a.2승인시간,a.3승인시간 " +
                        "FROM 결재 as a, 업무마스터 as w WHERE 기안자 = " + id + " AND 진행상황 = 결재자수 AND (a.관련업무 = w.업무번호)";
                    break;
                case "결재할 내역": //내가 결재할 차례인 모든 결재 내역
                    query = "SELECT a.ID as 번호,(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.기안자) as 기안자,a.제목,a.내용,w.업무내용,a.코멘트," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제1결재자) as 제1결재자," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제2결재자) as 제2결재자," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제3결재자) as 제3결재자," +
                        "a.기안자시간,a.1승인시간,a.2승인시간,a.3승인시간,a.반려메모 " +
                        "FROM 결재 as a, 업무마스터 as w WHERE 진행상황 < 결재자수 AND ((진행상황 = 0 AND 제1결재자 = " + id + ") OR" +
                        "(진행상황 = 1 AND 제2결재자 = " + id + ") OR (진행상황 = 2 AND 제3결재자 = " + id + ")) AND (a.관련업무 = w.업무번호) AND 반려여부 = 0";
                    break;
                case "반려 내역": //내가 기안한 결재 중 반려 내역
                    query = "SELECT a.ID as 번호,(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.기안자) as 기안자,a.제목,a.내용,w.업무내용," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제1결재자) as 제1결재자," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제2결재자) as 제2결재자," +
                        "(SELECT GROUP_CONCAT(name, '(', identification, ')') AS 사원 FROM Employee WHERE identification = a.제3결재자) as 제3결재자," +
                        "a.기안자시간,a.1승인시간,a.2승인시간,a.3승인시간,a.반려메모 " +
                        "FROM 결재 as a, 업무마스터 as w WHERE (기안자 = " + id + " OR  제1결재자 = " + id + " OR 제2결재자 = " + id + " OR 제3결재자 = " + id + ") " +
                        "AND (a.관련업무 = w.업무번호) AND 반려여부 = 1 ORDER BY a.기안자시간 desc";
                    break;
                    //반려내역 누구에게 보여줄것인지
            }
            MySqlDataReader rdr = DBManager.GetInstance().select(query); //테이블 가져오기

            DataTable dt = new DataTable();
            dt.Load(rdr);
            dgv_MyApprList.DataSource = dt;
            rdr.Close();
        }
    }
}
