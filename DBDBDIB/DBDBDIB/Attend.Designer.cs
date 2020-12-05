namespace DBDBDIB
{
    partial class Attend
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
            this.dgvattend = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bLookup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmp = new System.Windows.Forms.TextBox();
            this.dtpToday = new System.Windows.Forms.DateTimePicker();
            this.bOut = new System.Windows.Forms.Button();
            this.bIn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvattend)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvattend
            // 
            this.dgvattend.AllowUserToAddRows = false;
            this.dgvattend.AllowUserToDeleteRows = false;
            this.dgvattend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvattend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvattend.Location = new System.Drawing.Point(12, 134);
            this.dgvattend.MultiSelect = false;
            this.dgvattend.Name = "dgvattend";
            this.dgvattend.RowTemplate.Height = 23;
            this.dgvattend.Size = new System.Drawing.Size(883, 402);
            this.dgvattend.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.bLookup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEmp);
            this.groupBox1.Controls.Add(this.dtpToday);
            this.groupBox1.Controls.Add(this.bOut);
            this.groupBox1.Controls.Add(this.bIn);
            this.groupBox1.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "근태관리";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pictureBox3.Location = new System.Drawing.Point(495, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(228, 2);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // bLookup
            // 
            this.bLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.bLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLookup.Font = new System.Drawing.Font("HY견고딕", 12F);
            this.bLookup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.bLookup.Location = new System.Drawing.Point(731, 30);
            this.bLookup.Name = "bLookup";
            this.bLookup.Size = new System.Drawing.Size(107, 51);
            this.bLookup.TabIndex = 4;
            this.bLookup.Text = "조회";
            this.bLookup.UseVisualStyleBackColor = false;
            this.bLookup.Click += new System.EventHandler(this.bLookup_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "사원이름";
            // 
            // tbEmp
            // 
            this.tbEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.tbEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmp.Font = new System.Drawing.Font("HY견고딕", 10F);
            this.tbEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.tbEmp.Location = new System.Drawing.Point(496, 65);
            this.tbEmp.Name = "tbEmp";
            this.tbEmp.Size = new System.Drawing.Size(222, 16);
            this.tbEmp.TabIndex = 2;
            // 
            // dtpToday
            // 
            this.dtpToday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpToday.Location = new System.Drawing.Point(495, 30);
            this.dtpToday.Name = "dtpToday";
            this.dtpToday.ShowCheckBox = true;
            this.dtpToday.Size = new System.Drawing.Size(222, 24);
            this.dtpToday.TabIndex = 1;
            this.dtpToday.ValueChanged += new System.EventHandler(this.dtpToday_ValueChanged);
            // 
            // bOut
            // 
            this.bOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.bOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.bOut.Location = new System.Drawing.Point(215, 24);
            this.bOut.Name = "bOut";
            this.bOut.Size = new System.Drawing.Size(172, 64);
            this.bOut.TabIndex = 0;
            this.bOut.Text = "퇴근";
            this.bOut.UseVisualStyleBackColor = false;
            this.bOut.Click += new System.EventHandler(this.bOut_Click);
            // 
            // bIn
            // 
            this.bIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.bIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.bIn.Location = new System.Drawing.Point(28, 24);
            this.bIn.Name = "bIn";
            this.bIn.Size = new System.Drawing.Size(172, 64);
            this.bIn.TabIndex = 0;
            this.bIn.Text = "출근";
            this.bIn.UseVisualStyleBackColor = false;
            this.bIn.Click += new System.EventHandler(this.bIn_Click);
            // 
            // Attend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(907, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvattend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attend";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.dgvattend)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvattend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpToday;
        private System.Windows.Forms.Button bOut;
        private System.Windows.Forms.Button bIn;
        private System.Windows.Forms.Button bLookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}