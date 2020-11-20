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
            this.buttonSaveANDChange.Location = new System.Drawing.Point(138, 177);
            this.buttonSaveANDChange.Name = "buttonSaveANDChange";
            this.buttonSaveANDChange.Size = new System.Drawing.Size(189, 41);
            this.buttonSaveANDChange.TabIndex = 10;
            this.buttonSaveANDChange.Text = "등록";
            this.buttonSaveANDChange.UseVisualStyleBackColor = true;
            this.buttonSaveANDChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // TodayWorkSaveChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 261);
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
    }
}