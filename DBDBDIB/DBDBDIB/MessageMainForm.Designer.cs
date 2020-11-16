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
            this.txtSearchWhoSent = new System.Windows.Forms.TextBox();
            this.btnNewMsg = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.검색하기 = new System.Windows.Forms.GroupBox();
            this.radioBtnContent = new System.Windows.Forms.RadioButton();
            this.radioBtnTitle = new System.Windows.Forms.RadioButton();
            this.radioBtnWhoSent = new System.Windows.Forms.RadioButton();
            this.txtSearchContent = new System.Windows.Forms.TextBox();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Panel();
            this.검색하기.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchWhoSent
            // 
            this.txtSearchWhoSent.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearchWhoSent.Location = new System.Drawing.Point(132, 19);
            this.txtSearchWhoSent.Name = "txtSearchWhoSent";
            this.txtSearchWhoSent.Size = new System.Drawing.Size(95, 22);
            this.txtSearchWhoSent.TabIndex = 0;
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
            this.listBox1.Location = new System.Drawing.Point(25, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(730, 324);
            this.listBox1.TabIndex = 5;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // 검색하기
            // 
            this.검색하기.Controls.Add(this.radioBtnContent);
            this.검색하기.Controls.Add(this.radioBtnTitle);
            this.검색하기.Controls.Add(this.radioBtnWhoSent);
            this.검색하기.Controls.Add(this.txtSearchContent);
            this.검색하기.Controls.Add(this.txtSearchTitle);
            this.검색하기.Controls.Add(this.txtSearchWhoSent);
            this.검색하기.Controls.Add(this.btnSearch);
            this.검색하기.Location = new System.Drawing.Point(25, 12);
            this.검색하기.Name = "검색하기";
            this.검색하기.Size = new System.Drawing.Size(625, 79);
            this.검색하기.TabIndex = 7;
            this.검색하기.TabStop = false;
            this.검색하기.Text = "검색하기";
            // 
            // radioBtnContent
            // 
            this.radioBtnContent.AutoSize = true;
            this.radioBtnContent.Location = new System.Drawing.Point(254, 20);
            this.radioBtnContent.Name = "radioBtnContent";
            this.radioBtnContent.Size = new System.Drawing.Size(91, 16);
            this.radioBtnContent.TabIndex = 15;
            this.radioBtnContent.TabStop = true;
            this.radioBtnContent.Text = "내용 별 검색";
            this.radioBtnContent.UseVisualStyleBackColor = true;
            this.radioBtnContent.CheckedChanged += new System.EventHandler(this.radioBtnContent_CheckedChanged);
            // 
            // radioBtnTitle
            // 
            this.radioBtnTitle.AutoSize = true;
            this.radioBtnTitle.Location = new System.Drawing.Point(15, 50);
            this.radioBtnTitle.Name = "radioBtnTitle";
            this.radioBtnTitle.Size = new System.Drawing.Size(91, 16);
            this.radioBtnTitle.TabIndex = 14;
            this.radioBtnTitle.TabStop = true;
            this.radioBtnTitle.Text = "제목 별 검색";
            this.radioBtnTitle.UseVisualStyleBackColor = true;
            this.radioBtnTitle.CheckedChanged += new System.EventHandler(this.radioBtnTitle_CheckedChanged);
            // 
            // radioBtnWhoSent
            // 
            this.radioBtnWhoSent.AutoSize = true;
            this.radioBtnWhoSent.Location = new System.Drawing.Point(15, 23);
            this.radioBtnWhoSent.Name = "radioBtnWhoSent";
            this.radioBtnWhoSent.Size = new System.Drawing.Size(115, 16);
            this.radioBtnWhoSent.TabIndex = 8;
            this.radioBtnWhoSent.TabStop = true;
            this.radioBtnWhoSent.Text = "보낸사람 별 검색";
            this.radioBtnWhoSent.UseVisualStyleBackColor = true;
            this.radioBtnWhoSent.CheckedChanged += new System.EventHandler(this.radioBtnWhoSent_CheckedChanged);
            // 
            // txtSearchContent
            // 
            this.txtSearchContent.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearchContent.Location = new System.Drawing.Point(351, 17);
            this.txtSearchContent.Name = "txtSearchContent";
            this.txtSearchContent.Size = new System.Drawing.Size(95, 22);
            this.txtSearchContent.TabIndex = 9;
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearchTitle.Location = new System.Drawing.Point(132, 45);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(95, 22);
            this.txtSearchTitle.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::DBDBDIB.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(504, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 47);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MessageMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.검색하기);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNewMsg);
            this.Name = "MessageMainForm";
            this.Text = "MessageMainForm";
            this.Load += new System.EventHandler(this.MessageMainForm_Load);
            this.검색하기.ResumeLayout(false);
            this.검색하기.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchWhoSent;
        private System.Windows.Forms.Button btnNewMsg;
        private System.Windows.Forms.Panel btnSearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox 검색하기;
        private System.Windows.Forms.RadioButton radioBtnContent;
        private System.Windows.Forms.RadioButton radioBtnTitle;
        private System.Windows.Forms.RadioButton radioBtnWhoSent;
        private System.Windows.Forms.TextBox txtSearchContent;
        private System.Windows.Forms.TextBox txtSearchTitle;
    }
}