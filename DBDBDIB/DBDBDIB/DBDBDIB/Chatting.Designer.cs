namespace DBDBDIB
{
    partial class Chatting
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
            this.RoomNum = new System.Windows.Forms.NumericUpDown();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtUserMsg = new System.Windows.Forms.TextBox();
            this.txtBoxMsg = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNum)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomNum
            // 
            this.RoomNum.Location = new System.Drawing.Point(485, 22);
            this.RoomNum.Margin = new System.Windows.Forms.Padding(5);
            this.RoomNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RoomNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.ReadOnly = true;
            this.RoomNum.Size = new System.Drawing.Size(61, 32);
            this.RoomNum.TabIndex = 12;
            this.RoomNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(556, 19);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 40);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "방 번호";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(526, 600);
            this.btnSend.Margin = new System.Windows.Forms.Padding(5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 40);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtUserMsg
            // 
            this.txtUserMsg.Location = new System.Drawing.Point(33, 602);
            this.txtUserMsg.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserMsg.Name = "txtUserMsg";
            this.txtUserMsg.Size = new System.Drawing.Size(482, 32);
            this.txtUserMsg.TabIndex = 8;
            // 
            // txtBoxMsg
            // 
            this.txtBoxMsg.Location = new System.Drawing.Point(33, 70);
            this.txtBoxMsg.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxMsg.Name = "txtBoxMsg";
            this.txtBoxMsg.ReadOnly = true;
            this.txtBoxMsg.Size = new System.Drawing.Size(609, 518);
            this.txtBoxMsg.TabIndex = 7;
            this.txtBoxMsg.Text = "";
            // 
            // Chatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 669);
            this.Controls.Add(this.RoomNum);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserMsg);
            this.Controls.Add(this.txtBoxMsg);
            this.Name = "Chatting";
            this.Text = "Chatting";
            this.Load += new System.EventHandler(this.Chatting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown RoomNum;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtUserMsg;
        private System.Windows.Forms.RichTextBox txtBoxMsg;
    }
}