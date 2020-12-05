namespace DBDBDIB
{
    partial class ApprovalListForm
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
            this.dgv_MyApprList = new System.Windows.Forms.DataGridView();
            this.combo_Appr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MyApprList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MyApprList
            // 
            this.dgv_MyApprList.AllowUserToAddRows = false;
            this.dgv_MyApprList.AllowUserToDeleteRows = false;
            this.dgv_MyApprList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MyApprList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_MyApprList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_MyApprList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MyApprList.Location = new System.Drawing.Point(10, 53);
            this.dgv_MyApprList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_MyApprList.MultiSelect = false;
            this.dgv_MyApprList.Name = "dgv_MyApprList";
            this.dgv_MyApprList.ReadOnly = true;
            this.dgv_MyApprList.RowHeadersVisible = false;
            this.dgv_MyApprList.RowHeadersWidth = 51;
            this.dgv_MyApprList.RowTemplate.Height = 27;
            this.dgv_MyApprList.Size = new System.Drawing.Size(757, 342);
            this.dgv_MyApprList.TabIndex = 0;
            // 
            // combo_Appr
            // 
            this.combo_Appr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.combo_Appr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Appr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Appr.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.combo_Appr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.combo_Appr.FormattingEnabled = true;
            this.combo_Appr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combo_Appr.Items.AddRange(new object[] {
            "등록 결재 내역",
            "결재 중 내역",
            "결재 완료 내역",
            "결재할 내역",
            "반려 내역"});
            this.combo_Appr.Location = new System.Drawing.Point(86, 15);
            this.combo_Appr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_Appr.Name = "combo_Appr";
            this.combo_Appr.Size = new System.Drawing.Size(171, 21);
            this.combo_Appr.TabIndex = 1;
            this.combo_Appr.SelectedIndexChanged += new System.EventHandler(this.combo_Appr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "모아보기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(289, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "*진행상황: 결재 승인 수(ex. 1 = 제1결재자만 승인함)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(289, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "*결재자수: 총 결재해야 하는 인원";
            // 
            // ApprovalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(778, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Appr);
            this.Controls.Add(this.dgv_MyApprList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ApprovalListForm";
            this.Text = "ApprovalListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MyApprList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MyApprList;
        private System.Windows.Forms.ComboBox combo_Appr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}