namespace DBDBDIB
{
    partial class Approval
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
            this.dgvDeptView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bDeptLookUp = new System.Windows.Forms.Button();
            this.bDeptEnroll = new System.Windows.Forms.Button();
            this.tbInsertDeptManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInsertDeptName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bDeptEdit = new System.Windows.Forms.Button();
            this.bDeptDelete = new System.Windows.Forms.Button();
            this.bDeptEmpSearch = new System.Windows.Forms.Button();
            this.dgvEmpSearchView = new System.Windows.Forms.DataGridView();
            this.tbDeptfSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpSearchView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeptView
            // 
            this.dgvDeptView.AllowUserToAddRows = false;
            this.dgvDeptView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeptView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDeptView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeptView.Location = new System.Drawing.Point(30, 32);
            this.dgvDeptView.MultiSelect = false;
            this.dgvDeptView.Name = "dgvDeptView";
            this.dgvDeptView.ReadOnly = true;
            this.dgvDeptView.RowHeadersWidth = 5;
            this.dgvDeptView.RowTemplate.Height = 23;
            this.dgvDeptView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeptView.Size = new System.Drawing.Size(410, 496);
            this.dgvDeptView.TabIndex = 2;
            this.dgvDeptView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeptView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.bDeptLookUp);
            this.groupBox1.Controls.Add(this.bDeptEnroll);
            this.groupBox1.Controls.Add(this.tbInsertDeptManager);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbInsertDeptName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bDeptEdit);
            this.groupBox1.Controls.Add(this.bDeptDelete);
            this.groupBox1.Location = new System.Drawing.Point(457, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "부서 관리";
            // 
            // bDeptLookUp
            // 
            this.bDeptLookUp.Location = new System.Drawing.Point(76, 111);
            this.bDeptLookUp.Name = "bDeptLookUp";
            this.bDeptLookUp.Size = new System.Drawing.Size(65, 32);
            this.bDeptLookUp.TabIndex = 17;
            this.bDeptLookUp.Text = "조회";
            this.bDeptLookUp.UseVisualStyleBackColor = true;
            this.bDeptLookUp.Click += new System.EventHandler(this.bDeptLookUp_Click);
            // 
            // bDeptEnroll
            // 
            this.bDeptEnroll.Location = new System.Drawing.Point(151, 111);
            this.bDeptEnroll.Name = "bDeptEnroll";
            this.bDeptEnroll.Size = new System.Drawing.Size(65, 32);
            this.bDeptEnroll.TabIndex = 16;
            this.bDeptEnroll.Text = "등록";
            this.bDeptEnroll.UseVisualStyleBackColor = true;
            this.bDeptEnroll.Click += new System.EventHandler(this.bDeptEnroll_Click);
            // 
            // tbInsertDeptManager
            // 
            this.tbInsertDeptManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInsertDeptManager.Location = new System.Drawing.Point(69, 76);
            this.tbInsertDeptManager.Name = "tbInsertDeptManager";
            this.tbInsertDeptManager.Size = new System.Drawing.Size(309, 21);
            this.tbInsertDeptManager.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "부서장";
            // 
            // tbInsertDeptName
            // 
            this.tbInsertDeptName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInsertDeptName.Location = new System.Drawing.Point(69, 41);
            this.tbInsertDeptName.Name = "tbInsertDeptName";
            this.tbInsertDeptName.Size = new System.Drawing.Size(309, 21);
            this.tbInsertDeptName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "부서명";
            // 
            // bDeptEdit
            // 
            this.bDeptEdit.Location = new System.Drawing.Point(227, 111);
            this.bDeptEdit.Name = "bDeptEdit";
            this.bDeptEdit.Size = new System.Drawing.Size(65, 32);
            this.bDeptEdit.TabIndex = 9;
            this.bDeptEdit.Text = "수정";
            this.bDeptEdit.UseVisualStyleBackColor = true;
            this.bDeptEdit.Click += new System.EventHandler(this.bDeptEdit_Click);
            // 
            // bDeptDelete
            // 
            this.bDeptDelete.Location = new System.Drawing.Point(303, 111);
            this.bDeptDelete.Name = "bDeptDelete";
            this.bDeptDelete.Size = new System.Drawing.Size(65, 32);
            this.bDeptDelete.TabIndex = 11;
            this.bDeptDelete.Text = "삭제";
            this.bDeptDelete.UseVisualStyleBackColor = true;
            this.bDeptDelete.Click += new System.EventHandler(this.bDeptDelete_Click);
            // 
            // bDeptEmpSearch
            // 
            this.bDeptEmpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeptEmpSearch.Location = new System.Drawing.Point(789, 208);
            this.bDeptEmpSearch.Name = "bDeptEmpSearch";
            this.bDeptEmpSearch.Size = new System.Drawing.Size(88, 34);
            this.bDeptEmpSearch.TabIndex = 10;
            this.bDeptEmpSearch.Text = "사원 조회";
            this.bDeptEmpSearch.UseVisualStyleBackColor = true;
            this.bDeptEmpSearch.Click += new System.EventHandler(this.bDeptEmpSearch_Click);
            // 
            // dgvEmpSearchView
            // 
            this.dgvEmpSearchView.AllowUserToAddRows = false;
            this.dgvEmpSearchView.AllowUserToOrderColumns = true;
            this.dgvEmpSearchView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpSearchView.ColumnHeadersHeight = 4;
            this.dgvEmpSearchView.Location = new System.Drawing.Point(457, 245);
            this.dgvEmpSearchView.Name = "dgvEmpSearchView";
            this.dgvEmpSearchView.ReadOnly = true;
            this.dgvEmpSearchView.RowHeadersWidth = 4;
            this.dgvEmpSearchView.RowTemplate.Height = 23;
            this.dgvEmpSearchView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpSearchView.Size = new System.Drawing.Size(424, 283);
            this.dgvEmpSearchView.TabIndex = 2;
            // 
            // tbDeptfSearch
            // 
            this.tbDeptfSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeptfSearch.Location = new System.Drawing.Point(541, 214);
            this.tbDeptfSearch.Name = "tbDeptfSearch";
            this.tbDeptfSearch.Size = new System.Drawing.Size(238, 21);
            this.tbDeptfSearch.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "부서 번호";
            // 
            // Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmpSearchView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDeptView);
            this.Controls.Add(this.tbDeptfSearch);
            this.Controls.Add(this.bDeptEmpSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Approval";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpSearchView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDeptView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bDeptEnroll;
        private System.Windows.Forms.TextBox tbInsertDeptManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInsertDeptName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bDeptEdit;
        private System.Windows.Forms.Button bDeptEmpSearch;
        private System.Windows.Forms.Button bDeptDelete;
        private System.Windows.Forms.DataGridView dgvEmpSearchView;
        private System.Windows.Forms.TextBox tbDeptfSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDeptLookUp;
    }
}