namespace DBDBDIB
{
    partial class TodayWorkSaveChange
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox소속 = new System.Windows.Forms.ComboBox();
            this.comboBox업무내용 = new System.Windows.Forms.ComboBox();
            this.comboBox업무종류 = new System.Windows.Forms.ComboBox();
            this.buttonSaveANDChange = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "소속";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "업무종류";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "업무내용";
            // 
            // comboBox소속
            // 
            this.comboBox소속.FormattingEnabled = true;
            this.comboBox소속.Location = new System.Drawing.Point(102, 74);
            this.comboBox소속.Name = "comboBox소속";
            this.comboBox소속.Size = new System.Drawing.Size(110, 23);
            this.comboBox소속.TabIndex = 7;
            this.comboBox소속.SelectedIndexChanged += new System.EventHandler(this.comboBox소속_SelectedIndexChanged);
            // 
            // comboBox업무내용
            // 
            this.comboBox업무내용.FormattingEnabled = true;
            this.comboBox업무내용.Location = new System.Drawing.Point(102, 121);
            this.comboBox업무내용.Name = "comboBox업무내용";
            this.comboBox업무내용.Size = new System.Drawing.Size(316, 23);
            this.comboBox업무내용.TabIndex = 8;
            this.comboBox업무내용.SelectedIndexChanged += new System.EventHandler(this.comboBox업무내용_SelectedIndexChanged);
            // 
            // comboBox업무종류
            // 
            this.comboBox업무종류.FormattingEnabled = true;
            this.comboBox업무종류.Location = new System.Drawing.Point(302, 74);
            this.comboBox업무종류.Name = "comboBox업무종류";
            this.comboBox업무종류.Size = new System.Drawing.Size(116, 23);
            this.comboBox업무종류.TabIndex = 9;
            this.comboBox업무종류.SelectedIndexChanged += new System.EventHandler(this.comboBox업무종류_SelectedIndexChanged);
            // 
            // buttonSaveANDChange
            // 
            this.buttonSaveANDChange.Location = new System.Drawing.Point(140, 188);
            this.buttonSaveANDChange.Name = "buttonSaveANDChange";
            this.buttonSaveANDChange.Size = new System.Drawing.Size(189, 41);
            this.buttonSaveANDChange.TabIndex = 10;
            this.buttonSaveANDChange.Text = "등록";
            this.buttonSaveANDChange.UseVisualStyleBackColor = true;
            this.buttonSaveANDChange.Click += new System.EventHandler(this.buttonSaveANDChange_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(247, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(182, 15);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "아무개님의 일일업무 등록";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "hh:mm";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(6, 24);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowUpDown = true;
            this.dateTimePickerStart.Size = new System.Drawing.Size(75, 25);
            this.dateTimePickerStart.TabIndex = 13;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "hh:mm";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(6, 24);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowUpDown = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(75, 25);
            this.dateTimePickerEnd.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Location = new System.Drawing.Point(32, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 67);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "시작시간";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerEnd);
            this.groupBox2.Location = new System.Drawing.Point(345, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(84, 67);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "종료시간";
            // 
            // TodayWorkSaveChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSaveANDChange);
            this.Controls.Add(this.comboBox업무종류);
            this.Controls.Add(this.comboBox업무내용);
            this.Controls.Add(this.comboBox소속);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "TodayWorkSaveChange";
            this.Text = "TodayWorkSaveChange";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TodayWorkSaveChange_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox소속;
        private System.Windows.Forms.ComboBox comboBox업무내용;
        private System.Windows.Forms.ComboBox comboBox업무종류;
        private System.Windows.Forms.Button buttonSaveANDChange;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}