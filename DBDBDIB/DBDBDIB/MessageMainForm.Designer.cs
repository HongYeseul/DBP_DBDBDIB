namespace DBDBDIB
{
    partial class MessageMainForm
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
            this.txtSearchMsg = new System.Windows.Forms.TextBox();
            this.btnDeleteMsg = new System.Windows.Forms.Button();
            this.btnNewMsg = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtSearchMsg
            // 
            this.txtSearchMsg.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearchMsg.Location = new System.Drawing.Point(25, 23);
            this.txtSearchMsg.Name = "txtSearchMsg";
            this.txtSearchMsg.Size = new System.Drawing.Size(138, 26);
            this.txtSearchMsg.TabIndex = 0;
            // 
            // btnDeleteMsg
            // 
            this.btnDeleteMsg.Location = new System.Drawing.Point(210, 25);
            this.btnDeleteMsg.Name = "btnDeleteMsg";
            this.btnDeleteMsg.Size = new System.Drawing.Size(51, 23);
            this.btnDeleteMsg.TabIndex = 2;
            this.btnDeleteMsg.Text = "삭제";
            this.btnDeleteMsg.UseVisualStyleBackColor = true;
            // 
            // btnNewMsg
            // 
            this.btnNewMsg.Location = new System.Drawing.Point(666, 17);
            this.btnNewMsg.Name = "btnNewMsg";
            this.btnNewMsg.Size = new System.Drawing.Size(98, 38);
            this.btnNewMsg.TabIndex = 4;
            this.btnNewMsg.Text = "쪽지 쓰기";
            this.btnNewMsg.UseVisualStyleBackColor = true;
            this.btnNewMsg.Click += new System.EventHandler(this.btnNewMsg_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(25, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(730, 364);
            this.listBox1.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::DBDBDIB.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(169, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MessageMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNewMsg);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteMsg);
            this.Controls.Add(this.txtSearchMsg);
            this.Name = "MessageMainForm";
            this.Text = "MessageMainForm";
            this.Load += new System.EventHandler(this.MessageMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchMsg;
        private System.Windows.Forms.Button btnDeleteMsg;
        private System.Windows.Forms.Button btnNewMsg;
        private System.Windows.Forms.Panel btnSearch;
        private System.Windows.Forms.ListBox listBox1;
    }
}