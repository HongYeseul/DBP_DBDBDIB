namespace DBDBDIB
{
    partial class TodayWork
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
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonKeyword = new System.Windows.Forms.RadioButton();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSelcet = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.AllowUserToAddRows = false;
            this.dataGridViewSelect.AllowUserToDeleteRows = false;
            this.dataGridViewSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Location = new System.Drawing.Point(32, 25);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.ReadOnly = true;
            this.dataGridViewSelect.RowHeadersVisible = false;
            this.dataGridViewSelect.RowHeadersWidth = 51;
            this.dataGridViewSelect.RowTemplate.Height = 27;
            this.dataGridViewSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelect.Size = new System.Drawing.Size(626, 446);
            this.dataGridViewSelect.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUser);
            this.groupBox1.Controls.Add(this.radioButtonKeyword);
            this.groupBox1.Controls.Add(this.radioButtonDate);
            this.groupBox1.Location = new System.Drawing.Point(677, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 항목";
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Location = new System.Drawing.Point(44, 96);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(73, 19);
            this.radioButtonUser.TabIndex = 2;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "등록자";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            this.radioButtonUser.CheckedChanged += new System.EventHandler(this.radioButtonUser_CheckedChanged);
            // 
            // radioButtonKeyword
            // 
            this.radioButtonKeyword.AutoSize = true;
            this.radioButtonKeyword.Location = new System.Drawing.Point(44, 71);
            this.radioButtonKeyword.Name = "radioButtonKeyword";
            this.radioButtonKeyword.Size = new System.Drawing.Size(108, 19);
            this.radioButtonKeyword.TabIndex = 1;
            this.radioButtonKeyword.TabStop = true;
            this.radioButtonKeyword.Text = "업무 키워드";
            this.radioButtonKeyword.UseVisualStyleBackColor = true;
            this.radioButtonKeyword.CheckedChanged += new System.EventHandler(this.radioButtonKeyword_CheckedChanged);
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(44, 46);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(58, 19);
            this.radioButtonDate.TabIndex = 0;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "날짜";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            this.radioButtonDate.CheckedChanged += new System.EventHandler(this.radioButtonDate_CheckedChanged);
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(677, 210);
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.Size = new System.Drawing.Size(200, 25);
            this.textBoxSelect.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(677, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonSelcet
            // 
            this.buttonSelcet.Location = new System.Drawing.Point(677, 255);
            this.buttonSelcet.Name = "buttonSelcet";
            this.buttonSelcet.Size = new System.Drawing.Size(200, 39);
            this.buttonSelcet.TabIndex = 4;
            this.buttonSelcet.Text = "검색";
            this.buttonSelcet.UseVisualStyleBackColor = true;
            this.buttonSelcet.Click += new System.EventHandler(this.buttonSelcet_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(677, 345);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 39);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "등록";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(677, 300);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(96, 39);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "수정";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(781, 300);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 39);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // TodayWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 506);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSelcet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSelect);
            this.Name = "TodayWork";
            this.Text = "TodayWork";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.RadioButton radioButtonKeyword;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.TextBox textBoxSelect;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSelcet;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.DataGridView dataGridViewSelect;
    }
}