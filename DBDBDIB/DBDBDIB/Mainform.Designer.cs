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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAtt = new System.Windows.Forms.Button();
            this.buttonDept = new System.Windows.Forms.Button();
            this.buttonEmp = new System.Windows.Forms.Button();
            this.buttonHR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonHR);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 467);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 100);
            this.panel4.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 223);
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
            this.panel3.Controls.Add(this.buttonAtt);
            this.panel3.Controls.Add(this.buttonDept);
            this.panel3.Controls.Add(this.buttonEmp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 100);
            this.panel3.TabIndex = 4;
            // 
            // buttonAtt
            // 
            this.buttonAtt.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAtt.Location = new System.Drawing.Point(0, 46);
            this.buttonAtt.Name = "buttonAtt";
            this.buttonAtt.Size = new System.Drawing.Size(175, 23);
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
            this.panel5.Size = new System.Drawing.Size(638, 467);
            this.panel5.TabIndex = 1;
            // 
            // Mainform
            // 
            this.ClientSize = new System.Drawing.Size(813, 467);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Mainform";
            this.Text = "예시";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
    }
}

