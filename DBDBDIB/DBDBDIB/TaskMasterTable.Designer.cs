namespace DBDBDIB
{
    partial class taskmasterform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Task_Apply = new System.Windows.Forms.Button();
            this.button_Task_Rectify = new System.Windows.Forms.Button();
            this.button_Task_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskmasterView = new System.Windows.Forms.DataGridView();
            this.comboBoxTaskKind = new System.Windows.Forms.ComboBox();
            this.textBoxTaskContents = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAFcompany = new System.Windows.Forms.ComboBox();
            this.buttonCellClickCancel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TaskmasterView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Task_Apply
            // 
            this.button_Task_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.button_Task_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Task_Apply.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.button_Task_Apply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.button_Task_Apply.Location = new System.Drawing.Point(746, 59);
            this.button_Task_Apply.Name = "button_Task_Apply";
            this.button_Task_Apply.Size = new System.Drawing.Size(130, 110);
            this.button_Task_Apply.TabIndex = 1;
            this.button_Task_Apply.Text = "등록";
            this.button_Task_Apply.UseVisualStyleBackColor = false;
            this.button_Task_Apply.Click += new System.EventHandler(this.button_Task_Apply_Click);
            // 
            // button_Task_Rectify
            // 
            this.button_Task_Rectify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.button_Task_Rectify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Task_Rectify.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.button_Task_Rectify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.button_Task_Rectify.Location = new System.Drawing.Point(746, 216);
            this.button_Task_Rectify.Name = "button_Task_Rectify";
            this.button_Task_Rectify.Size = new System.Drawing.Size(130, 111);
            this.button_Task_Rectify.TabIndex = 2;
            this.button_Task_Rectify.Text = "수정";
            this.button_Task_Rectify.UseVisualStyleBackColor = false;
            this.button_Task_Rectify.Click += new System.EventHandler(this.button_Task_Rectify_Click);
            // 
            // button_Task_Delete
            // 
            this.button_Task_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.button_Task_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Task_Delete.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.button_Task_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.button_Task_Delete.Location = new System.Drawing.Point(746, 371);
            this.button_Task_Delete.Name = "button_Task_Delete";
            this.button_Task_Delete.Size = new System.Drawing.Size(130, 111);
            this.button_Task_Delete.TabIndex = 3;
            this.button_Task_Delete.Text = "삭제";
            this.button_Task_Delete.UseVisualStyleBackColor = false;
            this.button_Task_Delete.Click += new System.EventHandler(this.button_Task_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY견고딕", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(389, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "업무마스터";
            // 
            // TaskmasterView
            // 
            this.TaskmasterView.AllowUserToAddRows = false;
            this.TaskmasterView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskmasterView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TaskmasterView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskmasterView.Location = new System.Drawing.Point(12, 59);
            this.TaskmasterView.Name = "TaskmasterView";
            this.TaskmasterView.ReadOnly = true;
            this.TaskmasterView.RowHeadersVisible = false;
            this.TaskmasterView.RowTemplate.Height = 23;
            this.TaskmasterView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskmasterView.Size = new System.Drawing.Size(714, 311);
            this.TaskmasterView.TabIndex = 0;
            this.TaskmasterView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskmasterView_CellClick);
            // 
            // comboBoxTaskKind
            // 
            this.comboBoxTaskKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.comboBoxTaskKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTaskKind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTaskKind.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.comboBoxTaskKind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.comboBoxTaskKind.FormattingEnabled = true;
            this.comboBoxTaskKind.Items.AddRange(new object[] {
            "정기업무",
            "단기업무"});
            this.comboBoxTaskKind.Location = new System.Drawing.Point(94, 434);
            this.comboBoxTaskKind.Name = "comboBoxTaskKind";
            this.comboBoxTaskKind.Size = new System.Drawing.Size(99, 21);
            this.comboBoxTaskKind.TabIndex = 20;
            // 
            // textBoxTaskContents
            // 
            this.textBoxTaskContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.textBoxTaskContents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTaskContents.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.textBoxTaskContents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.textBoxTaskContents.Location = new System.Drawing.Point(97, 472);
            this.textBoxTaskContents.Name = "textBoxTaskContents";
            this.textBoxTaskContents.Size = new System.Drawing.Size(614, 16);
            this.textBoxTaskContents.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(23, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "업무내용";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(23, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "업무종류";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(53, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "소속";
            // 
            // comboBoxAFcompany
            // 
            this.comboBoxAFcompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.comboBoxAFcompany.CausesValidation = false;
            this.comboBoxAFcompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAFcompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAFcompany.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.comboBoxAFcompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.comboBoxAFcompany.FormattingEnabled = true;
            this.comboBoxAFcompany.Location = new System.Drawing.Point(94, 397);
            this.comboBoxAFcompany.Name = "comboBoxAFcompany";
            this.comboBoxAFcompany.Size = new System.Drawing.Size(99, 21);
            this.comboBoxAFcompany.TabIndex = 21;
            // 
            // buttonCellClickCancel
            // 
            this.buttonCellClickCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.buttonCellClickCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCellClickCancel.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.buttonCellClickCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.buttonCellClickCancel.Location = new System.Drawing.Point(746, 59);
            this.buttonCellClickCancel.Name = "buttonCellClickCancel";
            this.buttonCellClickCancel.Size = new System.Drawing.Size(130, 111);
            this.buttonCellClickCancel.TabIndex = 22;
            this.buttonCellClickCancel.Text = "선택취소";
            this.buttonCellClickCancel.UseVisualStyleBackColor = false;
            this.buttonCellClickCancel.Click += new System.EventHandler(this.buttonCellClickCancel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pictureBox2.Location = new System.Drawing.Point(94, 489);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(614, 2);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // taskmasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(891, 514);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonCellClickCancel);
            this.Controls.Add(this.comboBoxAFcompany);
            this.Controls.Add(this.comboBoxTaskKind);
            this.Controls.Add(this.textBoxTaskContents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Task_Delete);
            this.Controls.Add(this.button_Task_Rectify);
            this.Controls.Add(this.button_Task_Apply);
            this.Controls.Add(this.TaskmasterView);
            this.Name = "taskmasterform";
            this.Text = "업무마스터";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.taskmasterform_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TaskmasterView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Task_Apply;
        private System.Windows.Forms.Button button_Task_Rectify;
        private System.Windows.Forms.Button button_Task_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TaskmasterView;
        private System.Windows.Forms.ComboBox comboBoxTaskKind;
        private System.Windows.Forms.TextBox textBoxTaskContents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAFcompany;
        private System.Windows.Forms.Button buttonCellClickCancel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}