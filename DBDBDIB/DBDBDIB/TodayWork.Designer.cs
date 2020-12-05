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
            this.dataGridViewSelect.Location = new System.Drawing.Point(28, 20);
            this.dataGridViewSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSelect.MultiSelect = false;
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.ReadOnly = true;
            this.dataGridViewSelect.RowHeadersVisible = false;
            this.dataGridViewSelect.RowHeadersWidth = 51;
            this.dataGridViewSelect.RowTemplate.Height = 27;
            this.dataGridViewSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelect.Size = new System.Drawing.Size(643, 473);
            this.dataGridViewSelect.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUser);
            this.groupBox1.Controls.Add(this.radioButtonKeyword);
            this.groupBox1.Controls.Add(this.radioButtonDate);
            this.groupBox1.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.groupBox1.Location = new System.Drawing.Point(695, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(175, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 항목";
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.radioButtonUser.Location = new System.Drawing.Point(38, 81);
            this.radioButtonUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(67, 18);
            this.radioButtonUser.TabIndex = 2;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "등록자";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            this.radioButtonUser.CheckedChanged += new System.EventHandler(this.radioButtonUser_CheckedChanged);
            // 
            // radioButtonKeyword
            // 
            this.radioButtonKeyword.AutoSize = true;
            this.radioButtonKeyword.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.radioButtonKeyword.Location = new System.Drawing.Point(38, 59);
            this.radioButtonKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonKeyword.Name = "radioButtonKeyword";
            this.radioButtonKeyword.Size = new System.Drawing.Size(100, 18);
            this.radioButtonKeyword.TabIndex = 1;
            this.radioButtonKeyword.TabStop = true;
            this.radioButtonKeyword.Text = "업무 키워드";
            this.radioButtonKeyword.UseVisualStyleBackColor = true;
            this.radioButtonKeyword.CheckedChanged += new System.EventHandler(this.radioButtonKeyword_CheckedChanged);
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.radioButtonDate.Location = new System.Drawing.Point(38, 37);
            this.radioButtonDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(53, 18);
            this.radioButtonDate.TabIndex = 0;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "날짜";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            this.radioButtonDate.CheckedChanged += new System.EventHandler(this.radioButtonDate_CheckedChanged);
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(695, 224);
            this.textBoxSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.Size = new System.Drawing.Size(176, 21);
            this.textBoxSelect.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(695, 224);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonSelcet
            // 
            this.buttonSelcet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.buttonSelcet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelcet.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.buttonSelcet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.buttonSelcet.Location = new System.Drawing.Point(695, 260);
            this.buttonSelcet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelcet.Name = "buttonSelcet";
            this.buttonSelcet.Size = new System.Drawing.Size(175, 31);
            this.buttonSelcet.TabIndex = 4;
            this.buttonSelcet.Text = "검색";
            this.buttonSelcet.UseVisualStyleBackColor = false;
            this.buttonSelcet.Click += new System.EventHandler(this.buttonSelcet_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.buttonSave.Location = new System.Drawing.Point(695, 332);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(175, 31);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "등록";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.buttonChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.buttonChange.Location = new System.Drawing.Point(695, 296);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(84, 31);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "수정";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.buttonDelete.Location = new System.Drawing.Point(786, 296);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(84, 31);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // TodayWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(891, 514);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSelcet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSelect);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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