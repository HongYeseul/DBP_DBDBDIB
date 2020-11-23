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
    public partial class LoginForm : Form
    {
        UserInfo UserManager = UserInfo.Getinstance();
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManager.Login(txtBoxID.Text, txtBoxPW.Text);
            /*if (UserManager.loginON == true)
            {
                Mainform newForm = new Mainform();
                newForm.Show();
                this.Close();
            }
            */
            this.Close();
                
        }

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLogin.Checked)
            {
                Console.WriteLine("체크됨");
                Properties.Settings.Default.ID = txtBoxID.Text.ToString();
                Properties.Settings.Default.Password = txtBoxPW.Text.ToString();
                Properties.Settings.Default.Save();
            }
            /*
            else
            {
                Properties.Settings.Default.ID = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
            */
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string id = Properties.Settings.Default.ID;
            string pw = Properties.Settings.Default.Password;

            if (id != "")
            {
                Properties.Settings.Default.ID = id;
                Properties.Settings.Default.Password = pw;
                Properties.Settings.Default.Save();
                txtBoxID.Text = id;
                txtBoxPW.Text = pw;
                checkBoxLogin.Checked = true;
                txtBoxID.Text = id;
                txtBoxPW.Text = pw;
                UserManager.Login(id, pw);
                this.Close();
            }
        }
    }
}
