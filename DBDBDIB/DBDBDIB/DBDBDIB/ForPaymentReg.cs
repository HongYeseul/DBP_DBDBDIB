using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDBDIB
{
    class ForPaymentReg
    {//민영
     
        public ForPaymentReg()
        {}
        public DataTable SetWork()
        {
            //업무번호에 따른 업무내용을 들고와야함(업무번호,업무내용)삭제유무가 0인거는 들고오면 안됨
            //부서도 들고와야할거같기도.....
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT 업무번호, 부서, 업무내용 FROM erp_school.업무마스터 WHERE 업무유효성=1;");
            DataTable work = new DataTable();
            work.Load(rdr) ;
            rdr.Close();
            return work;
        }
        public MySqlDataReader SetApart()
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT 부서명 FROM erp_school.부서 WHERE valid=1;");
            return rdr;
        }
        public MySqlDataReader SearchApartId(string apart)
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT ID FROM erp_school.부서 WHERE 부서명='"+apart+"';");
            return rdr;
        }
        public MySqlDataReader SetRank(int apart)
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT DISTINCT position FROM erp_school.Employee WHERE department=" + apart);
            return rdr;
        }
        public MySqlDataReader SetName(int apartid,string rank)
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT name FROM erp_school.Employee WHERE department="+apartid+" AND position='"+rank+"';");
            return rdr;
        }
        public MySqlDataReader SearchId(int apartid,string rank, string name)
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT identification FROM erp_school.Employee WHERE department=" + apartid + " AND position='"+ rank +"' AND name='"+name+"';");
            return rdr;
        }
        //코멘트가 null이 아닐때
        public void Insert_payment(int id, string title, string content, int selectedId, string coment, int chckapprovernum,
            int Approver1, int Approver2, Nullable<int> Approver3)
        {
            DateTime date = DateTime.Now;
            string date_now = date.ToString("yyy-MM-dd HH:mm:ss");
            if (coment==null && Approver3 == null) 
            { 
                DBManager.GetInstance().DBquery(
                "INSERT INTO erp_school.결재(기안자, 제목, 내용, 관련업무, 코멘트, 진행상황, 결재자수, 제1결재자, 제2결재자, 제3결재자, 기안자시간,반려여부) VALUES("
                + id + ",'" + title + "','" + content + "'," + selectedId + ",null,0," + chckapprovernum +
                "," + Approver1 + "," + Approver2 + ",null,'" + date_now + "',0);"); 
            }
            else if (Approver3 == null)
            {
                DBManager.GetInstance().DBquery(
               "INSERT INTO erp_school.결재(기안자,제목,내용,관련업무,코멘트,진행상황,결재자수,제1결재자,제2결재자,제3결재자,기안자시간,반려여부) VALUES("
               + id + ",'" + title + "','" + content + "'," + selectedId + ",'" + coment + "',0," + chckapprovernum +
               "," + Approver1 + "," + Approver2 + ",null,'" + date_now + "',0);");
            }
            else if (coment==null)
            {
                DBManager.GetInstance().DBquery(
                "INSERT INTO erp_school.결재(기안자,제목,내용,관련업무,코멘트,진행상황,결재자수,제1결재자,제2결재자,제3결재자,기안자시간,반려여부) VALUES("
                + id + ",'" + title + "','" + content + "'," + selectedId + ",null,0," + chckapprovernum +
                "," + Approver1 + "," + Approver2 + "," + Approver3 + ",'" + date_now + "',0);");
            }
            else
            {
                DBManager.GetInstance().DBquery(
                "INSERT INTO erp_school.결재(기안자,제목,내용,관련업무,코멘트,진행상황,결재자수,제1결재자,제2결재자,제3결재자,기안자시간,반려여부) VALUES("
                + id + ",'" + title + "','" + content + "'," + selectedId + ",'" + coment + "',0," + chckapprovernum +
                "," + Approver1 + "," + Approver2 + "," + Approver3 + ",'" + date_now + "',0);");
            }
        }
    }
}
