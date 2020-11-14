using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDBDIB
{
    class ForPaymentReg
    {//민영
        public ForPaymentReg()
        {}
        public MySqlDataReader SetWork()
        {
            //업무번호에 따른 업무내용을 들고와야함(업무번호,업무내용)삭제유무가 0인거는 들고오면 안됨
            //부서도 들고와야할거같기도.....
            MySqlDataReader Work = DBManager.GetInstance().select("");
            return Work;
        }
    }
}
