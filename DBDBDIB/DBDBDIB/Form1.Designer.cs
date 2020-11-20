namespace DBDBDIB
{
    partial class paymentform
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonPayment_Accept = new System.Windows.Forms.Button();
            this.buttonPayment_Deny = new System.Windows.Forms.Button();
            this.textBoxComent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentListView = new System.Windows.Forms.DataGridView();
            this.button_TaskMaster = new System.Windows.Forms.Button();
            this.labelpaymentdeny = new System.Windows.Forms.Label();
            this.textBoxPaymentdenymemo = new System.Windows.Forms.TextBox();
            this.buttonDenycheck = new System.Windows.Forms.Button();
            this.paymentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drafter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskContents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentaccepttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentListView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPayment_Accept
            // 
            this.buttonPayment_Accept.Location = new System.Drawing.Point(843, 358);
            this.buttonPayment_Accept.Name = "buttonPayment_Accept";
            this.buttonPayment_Accept.Size = new System.Drawing.Size(75, 23);
            this.buttonPayment_Accept.TabIndex = 2;
            this.buttonPayment_Accept.Text = "결재진행";
            this.buttonPayment_Accept.UseVisualStyleBackColor = true;
            this.buttonPayment_Accept.Click += new System.EventHandler(this.buttonPayment_Accept_Click);
            // 
            // buttonPayment_Deny
            // 
            this.buttonPayment_Deny.Location = new System.Drawing.Point(967, 358);
            this.buttonPayment_Deny.Name = "buttonPayment_Deny";
            this.buttonPayment_Deny.Size = new System.Drawing.Size(75, 23);
            this.buttonPayment_Deny.TabIndex = 3;
            this.buttonPayment_Deny.Text = "결재반려";
            this.buttonPayment_Deny.UseVisualStyleBackColor = true;
            this.buttonPayment_Deny.Click += new System.EventHandler(this.buttonPayment_Deny_Click);
            // 
            // textBoxComent
            // 
            this.textBoxComent.Location = new System.Drawing.Point(20, 288);
            this.textBoxComent.Multiline = true;
            this.textBoxComent.Name = "textBoxComent";
            this.textBoxComent.Size = new System.Drawing.Size(1022, 50);
            this.textBoxComent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "결재내역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "코멘트";
            // 
            // PaymentListView
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PaymentListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentid,
            this.drafter,
            this.TaskTitle,
            this.TaskContents,
            this.paymentaccepttime});
            this.PaymentListView.Location = new System.Drawing.Point(21, 28);
            this.PaymentListView.Name = "PaymentListView";
            this.PaymentListView.RowTemplate.Height = 23;
            this.PaymentListView.Size = new System.Drawing.Size(1022, 221);
            this.PaymentListView.TabIndex = 6;
            this.PaymentListView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaymentListView_CellClick);
            // 
            // button_TaskMaster
            // 
            this.button_TaskMaster.Location = new System.Drawing.Point(20, 516);
            this.button_TaskMaster.Name = "button_TaskMaster";
            this.button_TaskMaster.Size = new System.Drawing.Size(139, 23);
            this.button_TaskMaster.TabIndex = 7;
            this.button_TaskMaster.Text = "업무마스터 보기";
            this.button_TaskMaster.UseVisualStyleBackColor = true;
            this.button_TaskMaster.Click += new System.EventHandler(this.button_TaskMaster_Click);
            // 
            // labelpaymentdeny
            // 
            this.labelpaymentdeny.AutoSize = true;
            this.labelpaymentdeny.Location = new System.Drawing.Point(19, 398);
            this.labelpaymentdeny.Name = "labelpaymentdeny";
            this.labelpaymentdeny.Size = new System.Drawing.Size(89, 12);
            this.labelpaymentdeny.TabIndex = 8;
            this.labelpaymentdeny.Text = "결재반려메모장";
            // 
            // textBoxPaymentdenymemo
            // 
            this.textBoxPaymentdenymemo.Location = new System.Drawing.Point(20, 424);
            this.textBoxPaymentdenymemo.Multiline = true;
            this.textBoxPaymentdenymemo.Name = "textBoxPaymentdenymemo";
            this.textBoxPaymentdenymemo.Size = new System.Drawing.Size(1022, 67);
            this.textBoxPaymentdenymemo.TabIndex = 9;
            // 
            // buttonDenycheck
            // 
            this.buttonDenycheck.Location = new System.Drawing.Point(967, 516);
            this.buttonDenycheck.Name = "buttonDenycheck";
            this.buttonDenycheck.Size = new System.Drawing.Size(75, 23);
            this.buttonDenycheck.TabIndex = 10;
            this.buttonDenycheck.Text = "확인";
            this.buttonDenycheck.UseVisualStyleBackColor = true;
            // 
            // paymentid
            // 
            this.paymentid.HeaderText = "결재번호";
            this.paymentid.Name = "paymentid";
            // 
            // drafter
            // 
            this.drafter.HeaderText = "기안자";
            this.drafter.Name = "drafter";
            // 
            // TaskTitle
            // 
            this.TaskTitle.HeaderText = "업무제목";
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.Width = 350;
            // 
            // TaskContents
            // 
            this.TaskContents.HeaderText = "업무내용";
            this.TaskContents.Name = "TaskContents";
            this.TaskContents.Width = 530;
            // 
            // paymentaccepttime
            // 
            this.paymentaccepttime.HeaderText = "결제승인시간";
            this.paymentaccepttime.Name = "paymentaccepttime";
            this.paymentaccepttime.Width = 150;
            // 
            // paymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.buttonDenycheck);
            this.Controls.Add(this.textBoxPaymentdenymemo);
            this.Controls.Add(this.labelpaymentdeny);
            this.Controls.Add(this.button_TaskMaster);
            this.Controls.Add(this.PaymentListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPayment_Deny);
            this.Controls.Add(this.buttonPayment_Accept);
            this.Controls.Add(this.textBoxComent);
            this.Name = "paymentform";
            this.Text = "결재기능";
            this.Load += new System.EventHandler(this.paymentform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPayment_Accept;
        private System.Windows.Forms.Button buttonPayment_Deny;
        private System.Windows.Forms.TextBox textBoxComent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PaymentListView;
        private System.Windows.Forms.Button button_TaskMaster;
        private System.Windows.Forms.Label labelpaymentdeny;
        private System.Windows.Forms.TextBox textBoxPaymentdenymemo;
        private System.Windows.Forms.Button buttonDenycheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn drafter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskContents;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentaccepttime;
    }
}

