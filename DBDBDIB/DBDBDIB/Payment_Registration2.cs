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
    public partial class Payment_Registration2 : Form
    {
        string title;
        string content;
        int selectedId;
        string coment;

        int count = 0;//결재자수
        public Payment_Registration2()
        {
            InitializeComponent();
        }
        public void SetReg1(string title_, string content_, int selectedId_, string coment_)
        {
            this.title = title_;
            this.content = content;
            this.selectedId = selectedId_;
            this.coment = coment_;
        }
        
    }
}
