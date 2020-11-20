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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "받는 사람";
            // 
            // txtSendToWhom
            // 
            this.txtSendToWhom.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSendToWhom.Location = new System.Drawing.Point(97, 26);
            this.txtSendToWhom.Name = "txtSendToWhom";
            this.txtSendToWhom.ReadOnly = true;
            this.txtSendToWhom.Size = new System.Drawing.Size(100, 27);
            this.txtSendToWhom.TabIndex = 1;
            // 
            // btnAddr
            // 
            this.btnAddr.Location = new System.Drawing.Point(203, 21);
            this.btnAddr.Name = "btnAddr";
            this.btnAddr.Size = new System.Drawing.Size(75, 36);
            this.btnAddr.TabIndex = 2;
            this.btnAddr.Text = "주소록";
            this.btnAddr.UseVisualStyleBackColor = true;
            this.btnAddr.Click += new System.EventHandler(this.btnAddr_Click);
            // 
            // txtMsgBox
            // 
            this.txtMsgBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsgBox.Location = new System.Drawing.Point(35, 113);
            this.txtMsgBox.Name = "txtMsgBox";
            this.txtMsgBox.Size = new System.Drawing.Size(722, 294);
            this.txtMsgBox.TabIndex = 3;
            this.txtMsgBox.Text = "";
            this.txtMsgBox.TextChanged += new System.EventHandler(this.txtMsgBox_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(652, 17);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(95, 36);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "/ 1000자";
            // 
            // labelTextLength
            // 
            this.labelTextLength.AutoSize = true;
            this.labelTextLength.Location = new System.Drawing.Point(673, 410);
            this.labelTextLength.Name = "labelTextLength";
            this.labelTextLength.Size = new System.Drawing.Size(11, 12);
            this.labelTextLength.TabIndex = 6;
            this.labelTextLength.Text = "0";
            this.labelTextLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMsgTitle
            // 
            this.txtMsgTitle.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsgTitle.Location = new System.Drawing.Point(83, 80);
            this.txtMsgTitle.Name = "txtMsgTitle";
            this.txtMsgTitle.Size = new System.Drawing.Size(315, 27);
            this.txtMsgTitle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "제목";
            // 
            // MessageWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}