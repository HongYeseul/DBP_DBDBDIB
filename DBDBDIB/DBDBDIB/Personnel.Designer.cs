namespace DBDBDIB
{
    partial class Personnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabManagement = new System.Windows.Forms.TabPage();
            this.bEnroll = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.dgvEmpManageView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dPBirth = new System.Windows.Forms.DateTimePicker();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bPostSearch = new System.Windows.Forms.Button();
            this.tbPWcheck = new System.Windows.Forms.TextBox();
            this.tbInsertAddress2 = new System.Windows.Forms.TextBox();
            this.tbInsertAddress1 = new System.Windows.Forms.TextBox();
            this.cbInsertRank = new System.Windows.Forms.ComboBox();
            this.cbInsertDept = new System.Windows.Forms.ComboBox();
            this.cbInsertGender = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbInsertName = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbInsertPhone = new System.Windows.Forms.TextBox();
            this.tbInsertPost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabLookup = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bEmpSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dgvEmpView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpManageView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabLookup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManagement
            // 
            this.tabManagement.Controls.Add(this.bEnroll);
            this.tabManagement.Controls.Add(this.bEdit);
            this.tabManagement.Controls.Add(this.bDelete);
            this.tabManagement.Controls.Add(this.dgvEmpManageView);
            this.tabManagement.Controls.Add(this.groupBox2);
            this.tabManagement.Location = new System.Drawing.Point(4, 24);
            this.tabManagement.Name = "tabManagement";
            this.tabManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabManagement.Size = new System.Drawing.Size(611, 393);
            this.tabManagement.TabIndex = 1;
            this.tabManagement.Text = "관리";
            this.tabManagement.UseVisualStyleBackColor = true;
            // 
            // bEnroll
            // 
            this.bEnroll.Location = new System.Drawing.Point(337, 237);
            this.bEnroll.Name = "bEnroll";
            this.bEnroll.Size = new System.Drawing.Size(83, 24);
            this.bEnroll.TabIndex = 2;
            this.bEnroll.Text = "사원 등록";
            this.bEnroll.UseVisualStyleBackColor = true;
            this.bEnroll.Click += new System.EventHandler(this.bEnroll_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(426, 237);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(83, 24);
            this.bEdit.TabIndex = 2;
            this.bEdit.Text = "사원 수정";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(515, 237);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(83, 24);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "사원 삭제";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // dgvEmpManageView
            // 
            this.dgvEmpManageView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpManageView.Location = new System.Drawing.Point(6, 267);
            this.dgvEmpManageView.Name = "dgvEmpManageView";
            this.dgvEmpManageView.ReadOnly = true;
            this.dgvEmpManageView.RowTemplate.Height = 23;
            this.dgvEmpManageView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpManageView.Size = new System.Drawing.Size(598, 111);
            this.dgvEmpManageView.TabIndex = 1;
            this.dgvEmpManageView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpManageView_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.dPBirth);
            this.groupBox2.Controls.Add(this.tbemail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bPostSearch);
            this.groupBox2.Controls.Add(this.tbPWcheck);
            this.groupBox2.Controls.Add(this.tbInsertAddress2);
            this.groupBox2.Controls.Add(this.tbInsertAddress1);
            this.groupBox2.Controls.Add(this.cbInsertRank);
            this.groupBox2.Controls.Add(this.cbInsertDept);
            this.groupBox2.Controls.Add(this.cbInsertGender);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tbInsertName);
            this.groupBox2.Controls.Add(this.tbPW);
            this.groupBox2.Controls.Add(this.tbInsertPhone);
            this.groupBox2.Controls.Add(this.tbInsertPost);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 219);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사원 관리";
            // 
            // dPBirth
            // 
            this.dPBirth.Location = new System.Drawing.Point(63, 151);
            this.dPBirth.Name = "dPBirth";
            this.dPBirth.Size = new System.Drawing.Size(177, 21);
            this.dPBirth.TabIndex = 13;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(63, 178);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(177, 21);
            this.tbemail.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // bPostSearch
            // 
            this.bPostSearch.Location = new System.Drawing.Point(458, 26);
            this.bPostSearch.Name = "bPostSearch";
            this.bPostSearch.Size = new System.Drawing.Size(118, 23);
            this.bPostSearch.TabIndex = 10;
            this.bPostSearch.Text = "우편번호 조회";
            this.bPostSearch.UseVisualStyleBackColor = true;
            this.bPostSearch.Click += new System.EventHandler(this.bPostSearch_Click);
            // 
            // tbPWcheck
            // 
            this.tbPWcheck.Location = new System.Drawing.Point(340, 178);
            this.tbPWcheck.Name = "tbPWcheck";
            this.tbPWcheck.Size = new System.Drawing.Size(236, 21);
            this.tbPWcheck.TabIndex = 9;
            // 
            // tbInsertAddress2
            // 
            this.tbInsertAddress2.Location = new System.Drawing.Point(312, 84);
            this.tbInsertAddress2.Multiline = true;
            this.tbInsertAddress2.Name = "tbInsertAddress2";
            this.tbInsertAddress2.Size = new System.Drawing.Size(264, 53);
            this.tbInsertAddress2.TabIndex = 8;
            // 
            // tbInsertAddress1
            // 
            this.tbInsertAddress1.Location = new System.Drawing.Point(312, 56);
            this.tbInsertAddress1.Multiline = true;
            this.tbInsertAddress1.Name = "tbInsertAddress1";
            this.tbInsertAddress1.Size = new System.Drawing.Size(264, 24);
            this.tbInsertAddress1.TabIndex = 8;
            // 
            // cbInsertRank
            // 
            this.cbInsertRank.FormattingEnabled = true;
            this.cbInsertRank.Location = new System.Drawing.Point(151, 64);
            this.cbInsertRank.Name = "cbInsertRank";
            this.cbInsertRank.Size = new System.Drawing.Size(89, 20);
            this.cbInsertRank.TabIndex = 7;
            // 
            // cbInsertDept
            // 
            this.cbInsertDept.FormattingEnabled = true;
            this.cbInsertDept.Location = new System.Drawing.Point(63, 123);
            this.cbInsertDept.Name = "cbInsertDept";
            this.cbInsertDept.Size = new System.Drawing.Size(177, 20);
            this.cbInsertDept.TabIndex = 7;
            // 
            // cbInsertGender
            // 
            this.cbInsertGender.FormattingEnabled = true;
            this.cbInsertGender.Location = new System.Drawing.Point(63, 64);
            this.cbInsertGender.Name = "cbInsertGender";
            this.cbInsertGender.Size = new System.Drawing.Size(47, 20);
            this.cbInsertGender.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 6;
            this.label16.Text = "성별";
            // 
            // tbInsertName
            // 
            this.tbInsertName.Location = new System.Drawing.Point(63, 34);
            this.tbInsertName.Name = "tbInsertName";
            this.tbInsertName.Size = new System.Drawing.Size(177, 21);
            this.tbInsertName.TabIndex = 5;
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(340, 148);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(236, 21);
            this.tbPW.TabIndex = 4;
            // 
            // tbInsertPhone
            // 
            this.tbInsertPhone.Location = new System.Drawing.Point(63, 93);
            this.tbInsertPhone.Name = "tbInsertPhone";
            this.tbInsertPhone.Size = new System.Drawing.Size(177, 21);
            this.tbInsertPhone.TabIndex = 4;
            // 
            // tbInsertPost
            // 
            this.tbInsertPost.Location = new System.Drawing.Point(312, 28);
            this.tbInsertPost.Name = "tbInsertPost";
            this.tbInsertPost.Size = new System.Drawing.Size(140, 21);
            this.tbInsertPost.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "비밀번호 확인";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "비밀번호";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "직급";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "소속부서";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(267, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "주소";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "우편번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "전화번호";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "생년월일";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "성명";
            // 
            // tabLookup
            // 
            this.tabLookup.Controls.Add(this.groupBox1);
            this.tabLookup.Controls.Add(this.dgvEmpView);
            this.tabLookup.Location = new System.Drawing.Point(4, 24);
            this.tabLookup.Name = "tabLookup";
            this.tabLookup.Padding = new System.Windows.Forms.Padding(3);
            this.tabLookup.Size = new System.Drawing.Size(611, 393);
            this.tabLookup.TabIndex = 0;
            this.tabLookup.Text = "조회";
            this.tabLookup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.bEmpSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사원 조회";
            // 
            // bEmpSearch
            // 
            this.bEmpSearch.Location = new System.Drawing.Point(527, 23);
            this.bEmpSearch.Name = "bEmpSearch";
            this.bEmpSearch.Size = new System.Drawing.Size(54, 27);
            this.bEmpSearch.TabIndex = 7;
            this.bEmpSearch.Text = "조회";
            this.bEmpSearch.UseVisualStyleBackColor = true;
            this.bEmpSearch.Click += new System.EventHandler(this.bEmpSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "나이";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "부서";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(54, 28);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(113, 20);
            this.cbCategory.TabIndex = 1;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(210, 27);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(121, 21);
            this.tbYear.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(374, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(131, 21);
            this.tbName.TabIndex = 0;
            // 
            // dgvEmpView
            // 
            this.dgvEmpView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpView.Location = new System.Drawing.Point(6, 105);
            this.dgvEmpView.Name = "dgvEmpView";
            this.dgvEmpView.ReadOnly = true;
            this.dgvEmpView.RowTemplate.Height = 23;
            this.dgvEmpView.Size = new System.Drawing.Size(598, 279);
            this.dgvEmpView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLookup);
            this.tabControl1.Controls.Add(this.tabManagement);
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 20);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 428);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Personnel";
            this.Text = "Form2";
            this.tabManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpManageView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabLookup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabManagement;
        private System.Windows.Forms.Button bEnroll;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.DataGridView dgvEmpManageView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bPostSearch;
        private System.Windows.Forms.TextBox tbPWcheck;
        private System.Windows.Forms.TextBox tbInsertAddress2;
        private System.Windows.Forms.ComboBox cbInsertRank;
        private System.Windows.Forms.ComboBox cbInsertDept;
        private System.Windows.Forms.ComboBox cbInsertGender;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbInsertName;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbInsertPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabLookup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bEmpSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView dgvEmpView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dPBirth;
        public System.Windows.Forms.TextBox tbInsertPost;
        public System.Windows.Forms.TextBox tbInsertAddress1;
    }
}