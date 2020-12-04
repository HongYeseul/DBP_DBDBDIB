namespace DBDBDIB
{
    partial class MessageDetail
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
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.txtWhoSent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(22, 119);
            this.txtContent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(639, 470);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            // 
            // txtWhoSent
            // 
            this.txtWhoSent.Location = new System.Drawing.Point(118, 16);
            this.txtWhoSent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtWhoSent.Name = "txtWhoSent";
            this.txtWhoSent.ReadOnly = true;
            this.txtWhoSent.Size = new System.Drawing.Size(109, 32);
            this.txtWhoSent.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "보낸사람";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(118, 63);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(227, 32);
            this.txtTitle.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "제목";
            // 
            // MessageDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 612);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWhoSent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContent);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MessageDetail";
            this.Text = "MessageDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.TextBox txtWhoSent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
    }
}