namespace DBDBDIB
{
    partial class MessageViewMember
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.viewAddr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("HY견고딕", 11F);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.btnSubmit.Location = new System.Drawing.Point(245, 122);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 47);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "확인";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // viewAddr
            // 
            this.viewAddr.AllowUserToAddRows = false;
            this.viewAddr.AllowUserToDeleteRows = false;
            this.viewAddr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewAddr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAddr.Location = new System.Drawing.Point(12, 12);
            this.viewAddr.MultiSelect = false;
            this.viewAddr.Name = "viewAddr";
            this.viewAddr.ReadOnly = true;
            this.viewAddr.RowHeadersVisible = false;
            this.viewAddr.RowTemplate.Height = 23;
            this.viewAddr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewAddr.Size = new System.Drawing.Size(215, 270);
            this.viewAddr.TabIndex = 4;
            // 
            // MessageViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(344, 297);
            this.Controls.Add(this.viewAddr);
            this.Controls.Add(this.btnSubmit);
            this.Name = "MessageViewMember";
            this.Text = "MessageViewMember";
            this.Load += new System.EventHandler(this.MessageViewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAddr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView viewAddr;
    }
}