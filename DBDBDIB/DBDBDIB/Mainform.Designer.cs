namespace DBDBDIB
{
    partial class Mainform
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonForPaymentReg = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Button10 = new System.Windows.Forms.Button();
            this.buttonTodayWork = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSalary = new System.Windows.Forms.Button();
            this.buttonAtt = new System.Windows.Forms.Button();
            this.buttonDept = new System.Windows.Forms.Button();
            this.buttonEmp = new System.Windows.Forms.Button();
            this.buttonHR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnChatting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelpersonnum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelpersonname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnChatting);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnMessage);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonHR);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 553);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Location = new System.Drawing.Point(0, 491);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(175, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMessage.Location = new System.Drawing.Point(0, 468);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(175, 23);
            this.btnMessage.TabIndex = 7;
            this.btnMessage.Text = "쪽지";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.button9);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.buttonForPaymentReg);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 368);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 100);
            this.panel6.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.Location = new System.Drawing.Point(0, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 26);
            this.button9.TabIndex = 0;
            this.button9.Text = "결재 관리";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Location = new System.Drawing.Point(0, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "나의 결재 리스트";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonForPaymentReg
            // 
            this.buttonForPaymentReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonForPaymentReg.Location = new System.Drawing.Point(0, 0);
            this.buttonForPaymentReg.Name = "buttonForPaymentReg";
            this.buttonForPaymentReg.Size = new System.Drawing.Size(175, 24);
            this.buttonForPaymentReg.TabIndex = 0;
            this.buttonForPaymentReg.Text = "결재등록";
            this.buttonForPaymentReg.UseVisualStyleBackColor = true;
            this.buttonForPaymentReg.Click += new System.EventHandler(this.buttonForPaymentReg_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "결재";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.Button10);
            this.panel4.Controls.Add(this.buttonTodayWork);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 266);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 79);
            this.panel4.TabIndex = 6;
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(0, 23);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(175, 23);
            this.Button10.TabIndex = 1;
            this.Button10.Text = "업무마스터";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // buttonTodayWork
            // 
            this.buttonTodayWork.Location = new System.Drawing.Point(0, 0);
            this.buttonTodayWork.Name = "buttonTodayWork";
            this.buttonTodayWork.Size = new System.Drawing.Size(175, 23);
            this.buttonTodayWork.TabIndex = 0;
            this.buttonTodayWork.Text = "일일 업무 관리";
            this.buttonTodayWork.UseVisualStyleBackColor = true;
            this.buttonTodayWork.Click += new System.EventHandler(this.buttonTodayWork_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "업무";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.buttonSalary);
            this.panel3.Controls.Add(this.buttonAtt);
            this.panel3.Controls.Add(this.buttonDept);
            this.panel3.Controls.Add(this.buttonEmp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 120);
            this.panel3.TabIndex = 4;
            // 
            // buttonSalary
            // 
            this.buttonSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSalary.Location = new System.Drawing.Point(0, 70);
            this.buttonSalary.Name = "buttonSalary";
            this.buttonSalary.Size = new System.Drawing.Size(175, 23);
            this.buttonSalary.TabIndex = 3;
            this.buttonSalary.Text = "급여내역서";
            this.buttonSalary.UseVisualStyleBackColor = true;
            this.buttonSalary.Click += new System.EventHandler(this.buttonSalary_Click);
            // 
            // buttonAtt
            // 
            this.buttonAtt.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAtt.Location = new System.Drawing.Point(0, 46);
            this.buttonAtt.Name = "buttonAtt";
            this.buttonAtt.Size = new System.Drawing.Size(175, 24);
            this.buttonAtt.TabIndex = 2;
            this.buttonAtt.Text = "근태관리";
            this.buttonAtt.UseVisualStyleBackColor = true;
            this.buttonAtt.Click += new System.EventHandler(this.buttonAtt_Click);
            // 
            // buttonDept
            // 
            this.buttonDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDept.Location = new System.Drawing.Point(0, 23);
            this.buttonDept.Name = "buttonDept";
            this.buttonDept.Size = new System.Drawing.Size(175, 23);
            this.buttonDept.TabIndex = 1;
            this.buttonDept.Text = "부서관리";
            this.buttonDept.UseVisualStyleBackColor = true;
            this.buttonDept.Click += new System.EventHandler(this.buttonDept_Click);
            // 
            // buttonEmp
            // 
            this.buttonEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmp.Location = new System.Drawing.Point(0, 0);
            this.buttonEmp.Name = "buttonEmp";
            this.buttonEmp.Size = new System.Drawing.Size(175, 23);
            this.buttonEmp.TabIndex = 0;
            this.buttonEmp.Text = "사원관리";
            this.buttonEmp.UseVisualStyleBackColor = true;
            this.buttonEmp.Click += new System.EventHandler(this.buttonEmp_Click);
            // 
            // buttonHR
            // 
            this.buttonHR.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHR.Location = new System.Drawing.Point(0, 100);
            this.buttonHR.Name = "buttonHR";
            this.buttonHR.Size = new System.Drawing.Size(175, 23);
            this.buttonHR.TabIndex = 3;
            this.buttonHR.Text = "인사";
            this.buttonHR.UseVisualStyleBackColor = true;
            this.buttonHR.Click += new System.EventHandler(this.buttonHR_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.labelpersonname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelpersonnum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(175, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(907, 553);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사원번호 :";
            // 
            // labelpersonnum
            // 
            this.labelpersonnum.AutoSize = true;
            this.labelpersonnum.Location = new System.Drawing.Point(92, 30);
            this.labelpersonnum.Name = "labelpersonnum";
            this.labelpersonnum.Size = new System.Drawing.Size(29, 12);
            this.labelpersonnum.TabIndex = 1;
            this.labelpersonnum.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "사원이름 :";
            // 
            // labelpersonname
            // 
            this.labelpersonname.AutoSize = true;
            this.labelpersonname.Location = new System.Drawing.Point(92, 55);
            this.labelpersonname.Name = "labelpersonname";
            this.labelpersonname.Size = new System.Drawing.Size(26, 12);
            this.labelpersonname.TabIndex = 3;
            this.labelpersonname.Text = "ooo";
            // 
            // btnChatting
            // 
            this.btnChatting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChatting.Location = new System.Drawing.Point(0, 514);
            this.btnChatting.Name = "btnChatting";
            this.btnChatting.Size = new System.Drawing.Size(175, 23);
            this.btnChatting.TabIndex = 9;
            this.btnChatting.Text = "채팅하기";
            this.btnChatting.UseVisualStyleBackColor = true;
            this.btnChatting.Click += new System.EventHandler(this.btnChatting_Click);
            // 
            // Mainform
            // 
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Mainform";
            this.Text = "예시";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAtt;
        private System.Windows.Forms.Button buttonDept;
        private System.Windows.Forms.Button buttonEmp;
        private System.Windows.Forms.Button buttonHR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonTodayWork;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonForPaymentReg;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button buttonSalary;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChatting;
        private System.Windows.Forms.Label labelpersonname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelpersonnum;
        private System.Windows.Forms.Label label1;
    }
}

