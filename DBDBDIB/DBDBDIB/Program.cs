using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBDBDIB
{
    static class Program
    {
        public static ApplicationContext ac = new ApplicationContext();

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm startForm = new LoginForm(); //동적으로 폼을 열수 있도록 함.
            ac.MainForm = startForm;
            Application.Run(ac);


            //Mainform Main = new Mainform();
            //Application.Run(Main);
            //LoginForm login = new LoginForm();
            //Application.Run(login);
            //아래 민영
            //Application.Run(new Payment_Registration1());
        }
    }
}
