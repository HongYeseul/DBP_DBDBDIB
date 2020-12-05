namespace DBDBDIB
{
    partial class MessageWriteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSendToWhom = new System.Windows.Forms.TextBox();
            this.btnAddr = new System.Windows.Forms.Button();
            this.txtMsgBox = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTextLength = new System.Windows.Forms.Label();
            this.txtMsgTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "받는 사람";
            // 
            // txtSendToWhom
            // 
            this.txtSendToWhom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.txtSendToWhom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSendToWhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSendToWhom.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.txtSendToWhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.txtSendToWhom.Location = new System.Drawing.Point(95, 30);
            this.txtSendToWhom.Name = "txtSendToWhom";
            this.txtSendToWhom.ReadOnly = true;
            this.txtSendToWhom.Size = new System.Drawing.Size(100, 16);
            this.txtSendToWhom.TabIndex = 1;
            // 
            // btnAddr
            // 
            this.btnAddr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddr.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.btnAddr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnAddr.Location = new System.Drawing.Point(206, 20);
            this.btnAddr.Name = "btnAddr";
            this.btnAddr.Size = new System.Drawing.Size(75, 36);
            this.btnAddr.TabIndex = 2;
            this.btnAddr.Text = "주소록";
            this.btnAddr.UseVisualStyleBackColor = true;
            this.btnAddr.Click += new System.EventHandler(this.btnAddr_Click);
            // 
            // txtMsgBox
            // 
            this.txtMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(69)))));
            this.txtMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsgBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsgBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(151)))));
            this.txtMsgBox.Location = new System.Drawing.Point(35, 113);
            this.txtMsgBox.Name = "txtMsgBox";
            this.txtMsgBox.Size = new System.Drawing.Size(722, 294);
            this.txtMsgBox.TabIndex = 3;
            this.txtMsgBox.Text = "";
            this.txtMsgBox.TextChanged += new System.EventHandler(this.txtMsgBox_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnSend.Location = new System.Drawing.Point(652, 17);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(95, 46);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(686, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "/ 1000자";
            // 
            // labelTextLength
            // 
            this.labelTextLength.AutoSize = true;
            this.labelTextLength.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.labelTextLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(151)))));
            this.labelTextLength.Location = new System.Drawing.Point(659, 416);
            this.labelTextLength.Name = "labelTextLength";
            this.labelTextLength.Size = new System.Drawing.Size(16, 14);
            this.labelTextLength.TabIndex = 6;
            this.labelTextLength.Text = "0";
            this.labelTextLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMsgTitle
            // 
            this.txtMsgTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.txtMsgTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsgTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMsgTitle.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.txtMsgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.txtMsgTitle.Location = new System.Drawing.Point(94, 81);
            this.txtMsgTitle.Name = "txtMsgTitle";
            this.txtMsgTitle.Size = new System.Drawing.Size(315, 16);
            this.txtMsgTitle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(54, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "제목";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pictureBox2.Location = new System.Drawing.Point(92, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 2);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pictureBox1.Location = new System.Drawing.Point(92, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 2);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pictureBox3.Location = new System.Drawing.Point(35, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(719, 2);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pictureBox4.Location = new System.Drawing.Point(35, 410);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(719, 2);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // MessageWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMsgTitle);
            this.Controls.Add(this.labelTextLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsgBox);
            this.Controls.Add(this.btnAddr);
            this.Controls.Add(this.txtSendToWhom);
            this.Controls.Add(this.label1);
            this.Name = "MessageWriteForm";
            this.Text = "새 쪽지 쓰기";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddr;
        private System.Windows.Forms.RichTextBox txtMsgBox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTextLength;
        public System.Windows.Forms.TextBox txtSendToWhom;
        private System.Windows.Forms.TextBox txtMsgTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}