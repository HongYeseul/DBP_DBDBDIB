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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonPayment_Accept = new System.Windows.Forms.Button();
            this.buttonPayment_Deny = new System.Windows.Forms.Button();
            this.textBoxComent = new System.Windows.Forms.TextBox();
            this.Paymentlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentListView = new System.Windows.Forms.DataGridView();
            this.labelpaymentdeny = new System.Windows.Forms.Label();
            this.textBoxPaymentdenymemo = new System.Windows.Forms.TextBox();
            this.buttonDenycheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentListView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPayment_Accept
            // 
            this.buttonPayment_Accept.Location = new System.Drawing.Point(651, 341);
            this.buttonPayment_Accept.Name = "buttonPayment_Accept";
            this.buttonPayment_Accept.Size = new System.Drawing.Size(104, 33);
            this.buttonPayment_Accept.TabIndex = 2;
            this.buttonPayment_Accept.Text = "결재진행";
            this.buttonPayment_Accept.UseVisualStyleBackColor = true;
            this.buttonPayment_Accept.Click += new System.EventHandler(this.buttonPayment_Accept_Click);
            // 
            // buttonPayment_Deny
            // 
            this.buttonPayment_Deny.Location = new System.Drawing.Point(783, 341);
            this.buttonPayment_Deny.Name = "buttonPayment_Deny";
            this.buttonPayment_Deny.Size = new System.Drawing.Size(95, 33);
            this.buttonPayment_Deny.TabIndex = 3;
            this.buttonPayment_Deny.Text = "결재반려";
            this.buttonPayment_Deny.UseVisualStyleBackColor = true;
            this.buttonPayment_Deny.Click += new System.EventHandler(this.buttonPayment_Deny_Click);
            // 
            // textBoxComent
            // 
            this.textBoxComent.Location = new System.Drawing.Point(20, 283);
            this.textBoxComent.Multiline = true;
            this.textBoxComent.Name = "textBoxComent";
            this.textBoxComent.ReadOnly = true;
            this.textBoxComent.Size = new System.Drawing.Size(859, 50);
            this.textBoxComent.TabIndex = 1;
            // 
            // Paymentlabel
            // 
            this.Paymentlabel.AutoSize = true;
            this.Paymentlabel.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Paymentlabel.Location = new System.Drawing.Point(379, 19);
            this.Paymentlabel.Name = "Paymentlabel";
            this.Paymentlabel.Size = new System.Drawing.Size(120, 27);
            this.Paymentlabel.TabIndex = 4;
            this.Paymentlabel.Text = "결재내역";
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
            this.PaymentListView.AllowUserToAddRows = false;
            this.PaymentListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PaymentListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentListView.Location = new System.Drawing.Point(20, 58);
            this.PaymentListView.Name = "PaymentListView";
            this.PaymentListView.ReadOnly = true;
            this.PaymentListView.RowHeadersVisible = false;
            this.PaymentListView.RowTemplate.Height = 23;
            this.PaymentListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaymentListView.Size = new System.Drawing.Size(858, 184);
            this.PaymentListView.TabIndex = 6;
            this.PaymentListView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaymentListView_CellClick);
            // 
            // labelpaymentdeny
            // 
            this.labelpaymentdeny.AutoSize = true;
            this.labelpaymentdeny.Location = new System.Drawing.Point(19, 378);
            this.labelpaymentdeny.Name = "labelpaymentdeny";
            this.labelpaymentdeny.Size = new System.Drawing.Size(89, 12);
            this.labelpaymentdeny.TabIndex = 8;
            this.labelpaymentdeny.Text = "결재반려메모장";
            // 
            // textBoxPaymentdenymemo
            // 
            this.textBoxPaymentdenymemo.Location = new System.Drawing.Point(20, 404);
            this.textBoxPaymentdenymemo.Multiline = true;
            this.textBoxPaymentdenymemo.Name = "textBoxPaymentdenymemo";
            this.textBoxPaymentdenymemo.Size = new System.Drawing.Size(859, 67);
            this.textBoxPaymentdenymemo.TabIndex = 9;
            // 
            // buttonDenycheck
            // 
            this.buttonDenycheck.Location = new System.Drawing.Point(780, 477);
            this.buttonDenycheck.Name = "buttonDenycheck";
            this.buttonDenycheck.Size = new System.Drawing.Size(99, 29);
            this.buttonDenycheck.TabIndex = 10;
            this.buttonDenycheck.Text = "확인";
            this.buttonDenycheck.UseVisualStyleBackColor = true;
            this.buttonDenycheck.Click += new System.EventHandler(this.buttonDenycheck_Click);
            // 
            // paymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 514);
            this.Controls.Add(this.buttonDenycheck);
            this.Controls.Add(this.textBoxPaymentdenymemo);
            this.Controls.Add(this.labelpaymentdeny);
            this.Controls.Add(this.PaymentListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Paymentlabel);
            this.Controls.Add(this.buttonPayment_Deny);
            this.Controls.Add(this.buttonPayment_Accept);
            this.Controls.Add(this.textBoxComent);
            this.Name = "paymentform";
            this.Text = "결재기능";
            this.Load += new System.EventHandler(this.paymentform_Load);
            this.Shown += new System.EventHandler(this.paymentform_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPayment_Accept;
        private System.Windows.Forms.Button buttonPayment_Deny;
        private System.Windows.Forms.TextBox textBoxComent;
        private System.Windows.Forms.Label Paymentlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PaymentListView;
        private System.Windows.Forms.Label labelpaymentdeny;
        private System.Windows.Forms.TextBox textBoxPaymentdenymemo;
        private System.Windows.Forms.Button buttonDenycheck;
    }
}

