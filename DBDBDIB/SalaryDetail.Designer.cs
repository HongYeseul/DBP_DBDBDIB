namespace DBDBDIB
{
    partial class SalaryDetail
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
            this.tabControlSalary = new System.Windows.Forms.TabControl();
            this.tabPageShowSalary = new System.Windows.Forms.TabPage();
            this.listViewShowEmployee = new System.Windows.Forms.ListView();
            this.label23 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBoxShowDepartment = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDeductionAmount = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelEmploymentInsurance = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelHealthInsurance = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelNationalPension = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelPaymentAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelExtra = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNormal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInputExtra = new System.Windows.Forms.Button();
            this.labelRealIncome = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonSelectEmployee = new System.Windows.Forms.Button();
            this.buttonGetEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageShowTax = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTaxRate = new System.Windows.Forms.TableLayoutPanel();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelLongtermCare = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControlSalary.SuspendLayout();
            this.tabPageShowSalary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageShowTax.SuspendLayout();
            this.tableLayoutPanelTaxRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSalary
            // 
            this.tabControlSalary.Controls.Add(this.tabPageShowSalary);
            this.tabControlSalary.Controls.Add(this.tabPageShowTax);
            this.tabControlSalary.Location = new System.Drawing.Point(-4, 0);
            this.tabControlSalary.Name = "tabControlSalary";
            this.tabControlSalary.SelectedIndex = 0;
            this.tabControlSalary.Size = new System.Drawing.Size(896, 517);
            this.tabControlSalary.TabIndex = 0;
            // 
            // tabPageShowSalary
            // 
            this.tabPageShowSalary.Controls.Add(this.listViewShowEmployee);
            this.tabPageShowSalary.Controls.Add(this.label23);
            this.tabPageShowSalary.Controls.Add(this.label29);
            this.tabPageShowSalary.Controls.Add(this.comboBoxShowDepartment);
            this.tabPageShowSalary.Controls.Add(this.groupBox1);
            this.tabPageShowSalary.Controls.Add(this.labelRealIncome);
            this.tabPageShowSalary.Controls.Add(this.label28);
            this.tabPageShowSalary.Controls.Add(this.buttonSelectEmployee);
            this.tabPageShowSalary.Controls.Add(this.buttonGetEmployee);
            this.tabPageShowSalary.Controls.Add(this.label1);
            this.tabPageShowSalary.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowSalary.Name = "tabPageShowSalary";
            this.tabPageShowSalary.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageShowSalary.Size = new System.Drawing.Size(888, 491);
            this.tabPageShowSalary.TabIndex = 0;
            this.tabPageShowSalary.Text = "급여 내역서 확인";
            // 
            // listViewShowEmployee
            // 
            this.listViewShowEmployee.FullRowSelect = true;
            this.listViewShowEmployee.HideSelection = false;
            this.listViewShowEmployee.Location = new System.Drawing.Point(163, 56);
            this.listViewShowEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewShowEmployee.Name = "listViewShowEmployee";
            this.listViewShowEmployee.Size = new System.Drawing.Size(149, 373);
            this.listViewShowEmployee.TabIndex = 31;
            this.listViewShowEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewShowEmployee.View = System.Windows.Forms.View.Details;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(807, 413);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 21);
            this.label23.TabIndex = 30;
            this.label23.Text = "원";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(51, 166);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 12);
            this.label29.TabIndex = 29;
            this.label29.Text = "부서 선택";
            // 
            // comboBoxShowDepartment
            // 
            this.comboBoxShowDepartment.FormattingEnabled = true;
            this.comboBoxShowDepartment.Location = new System.Drawing.Point(21, 193);
            this.comboBoxShowDepartment.Name = "comboBoxShowDepartment";
            this.comboBoxShowDepartment.Size = new System.Drawing.Size(121, 20);
            this.comboBoxShowDepartment.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelDeductionAmount);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.labelPaymentAmount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(416, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 379);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "급여 내역서";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.Location = new System.Drawing.Point(396, 329);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(24, 16);
            this.label30.TabIndex = 7;
            this.label30.Text = "원";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(396, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "원";
            // 
            // labelDeductionAmount
            // 
            this.labelDeductionAmount.AutoSize = true;
            this.labelDeductionAmount.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDeductionAmount.Location = new System.Drawing.Point(287, 329);
            this.labelDeductionAmount.Name = "labelDeductionAmount";
            this.labelDeductionAmount.Size = new System.Drawing.Size(58, 16);
            this.labelDeductionAmount.TabIndex = 23;
            this.labelDeductionAmount.Text = "label24";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(154, 329);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 16);
            this.label25.TabIndex = 22;
            this.label25.Text = "공제 액계: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.labelLongtermCare);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.labelEmploymentInsurance);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.labelHealthInsurance);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.labelNationalPension);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(21, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 152);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "공제 내역";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(303, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 24;
            this.label17.Text = "원";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(303, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "원";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(303, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "원";
            // 
            // labelEmploymentInsurance
            // 
            this.labelEmploymentInsurance.AutoSize = true;
            this.labelEmploymentInsurance.Location = new System.Drawing.Point(184, 121);
            this.labelEmploymentInsurance.Name = "labelEmploymentInsurance";
            this.labelEmploymentInsurance.Size = new System.Drawing.Size(44, 12);
            this.labelEmploymentInsurance.TabIndex = 17;
            this.labelEmploymentInsurance.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 16;
            this.label19.Text = "고용보험 : ";
            // 
            // labelHealthInsurance
            // 
            this.labelHealthInsurance.AutoSize = true;
            this.labelHealthInsurance.Location = new System.Drawing.Point(184, 62);
            this.labelHealthInsurance.Name = "labelHealthInsurance";
            this.labelHealthInsurance.Size = new System.Drawing.Size(44, 12);
            this.labelHealthInsurance.TabIndex = 14;
            this.labelHealthInsurance.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(45, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "건강보험 : ";
            // 
            // labelNationalPension
            // 
            this.labelNationalPension.AutoSize = true;
            this.labelNationalPension.Location = new System.Drawing.Point(184, 29);
            this.labelNationalPension.Name = "labelNationalPension";
            this.labelNationalPension.Size = new System.Drawing.Size(44, 12);
            this.labelNationalPension.TabIndex = 11;
            this.labelNationalPension.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "국민연금 : ";
            // 
            // labelPaymentAmount
            // 
            this.labelPaymentAmount.AutoSize = true;
            this.labelPaymentAmount.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPaymentAmount.Location = new System.Drawing.Point(293, 139);
            this.labelPaymentAmount.Name = "labelPaymentAmount";
            this.labelPaymentAmount.Size = new System.Drawing.Size(49, 16);
            this.labelPaymentAmount.TabIndex = 8;
            this.labelPaymentAmount.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(154, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "지급 액계:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelExtra);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelNormal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonInputExtra);
            this.groupBox2.Location = new System.Drawing.Point(21, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 111);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "총 급여";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "원";
            // 
            // labelExtra
            // 
            this.labelExtra.AutoSize = true;
            this.labelExtra.Location = new System.Drawing.Point(184, 70);
            this.labelExtra.Name = "labelExtra";
            this.labelExtra.Size = new System.Drawing.Size(38, 12);
            this.labelExtra.TabIndex = 5;
            this.labelExtra.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "수당 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "원";
            // 
            // labelNormal
            // 
            this.labelNormal.AutoSize = true;
            this.labelNormal.Location = new System.Drawing.Point(184, 33);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(38, 12);
            this.labelNormal.TabIndex = 2;
            this.labelNormal.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "기본급 : ";
            // 
            // buttonInputExtra
            // 
            this.buttonInputExtra.Location = new System.Drawing.Point(344, 65);
            this.buttonInputExtra.Name = "buttonInputExtra";
            this.buttonInputExtra.Size = new System.Drawing.Size(75, 23);
            this.buttonInputExtra.TabIndex = 0;
            this.buttonInputExtra.Text = "시간입력";
            this.buttonInputExtra.UseVisualStyleBackColor = true;
            this.buttonInputExtra.Click += new System.EventHandler(this.buttonInputExtra_Click);
            // 
            // labelRealIncome
            // 
            this.labelRealIncome.AutoSize = true;
            this.labelRealIncome.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRealIncome.Location = new System.Drawing.Point(688, 413);
            this.labelRealIncome.Name = "labelRealIncome";
            this.labelRealIncome.Size = new System.Drawing.Size(69, 21);
            this.labelRealIncome.TabIndex = 26;
            this.labelRealIncome.Text = "label27";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.Location = new System.Drawing.Point(519, 413);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(122, 21);
            this.label28.TabIndex = 25;
            this.label28.Text = "실 수령액 : ";
            // 
            // buttonSelectEmployee
            // 
            this.buttonSelectEmployee.Location = new System.Drawing.Point(325, 197);
            this.buttonSelectEmployee.Name = "buttonSelectEmployee";
            this.buttonSelectEmployee.Size = new System.Drawing.Size(75, 49);
            this.buttonSelectEmployee.TabIndex = 3;
            this.buttonSelectEmployee.Text = "확인";
            this.buttonSelectEmployee.UseVisualStyleBackColor = true;
            this.buttonSelectEmployee.Click += new System.EventHandler(this.buttonSelectEmployee_Click);
            // 
            // buttonGetEmployee
            // 
            this.buttonGetEmployee.Location = new System.Drawing.Point(43, 228);
            this.buttonGetEmployee.Name = "buttonGetEmployee";
            this.buttonGetEmployee.Size = new System.Drawing.Size(75, 36);
            this.buttonGetEmployee.TabIndex = 2;
            this.buttonGetEmployee.Text = "불러오기";
            this.buttonGetEmployee.UseVisualStyleBackColor = true;
            this.buttonGetEmployee.Click += new System.EventHandler(this.buttonGetEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사원 선택";
            // 
            // tabPageShowTax
            // 
            this.tabPageShowTax.Controls.Add(this.tableLayoutPanelTaxRate);
            this.tabPageShowTax.Font = new System.Drawing.Font("굴림", 10F);
            this.tabPageShowTax.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowTax.Name = "tabPageShowTax";
            this.tabPageShowTax.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageShowTax.Size = new System.Drawing.Size(888, 491);
            this.tabPageShowTax.TabIndex = 1;
            this.tabPageShowTax.Text = "세율 확인";
            // 
            // tableLayoutPanelTaxRate
            // 
            this.tableLayoutPanelTaxRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanelTaxRate.ColumnCount = 3;
            this.tableLayoutPanelTaxRate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanelTaxRate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelTaxRate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelTaxRate.Controls.Add(this.label44, 2, 7);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label43, 1, 7);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label42, 0, 7);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label41, 2, 6);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label40, 1, 6);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label39, 0, 6);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label38, 2, 5);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label37, 1, 5);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label36, 0, 5);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label35, 2, 4);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label34, 1, 4);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label33, 0, 4);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label32, 2, 3);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label31, 1, 3);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label27, 0, 3);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label26, 2, 2);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label24, 1, 2);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label21, 0, 2);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label15, 1, 1);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label18, 2, 1);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanelTaxRate.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanelTaxRate.Location = new System.Drawing.Point(95, 70);
            this.tableLayoutPanelTaxRate.Name = "tableLayoutPanelTaxRate";
            this.tableLayoutPanelTaxRate.RowCount = 8;
            this.tableLayoutPanelTaxRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTaxRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTaxRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTaxRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTaxRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTaxRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTaxRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTaxRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTaxRate.Size = new System.Drawing.Size(680, 358);
            this.tableLayoutPanelTaxRate.TabIndex = 0;
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(481, 313);
            this.label44.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(194, 35);
            this.label44.TabIndex = 23;
            this.label44.Text = "3,540만원";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(379, 313);
            this.label43.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(91, 35);
            this.label43.TabIndex = 22;
            this.label43.Text = "42%";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(5, 313);
            this.label42.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(363, 35);
            this.label42.TabIndex = 21;
            this.label42.Text = "5억원 초과";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(481, 269);
            this.label41.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(194, 34);
            this.label41.TabIndex = 20;
            this.label41.Text = "2,540만원";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(379, 269);
            this.label40.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(91, 34);
            this.label40.TabIndex = 19;
            this.label40.Text = "40%";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(5, 269);
            this.label39.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(363, 34);
            this.label39.TabIndex = 18;
            this.label39.Text = "3억원 초과 5억원 이하";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(481, 225);
            this.label38.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(194, 34);
            this.label38.TabIndex = 17;
            this.label38.Text = "1,940만원";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(379, 225);
            this.label37.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(91, 34);
            this.label37.TabIndex = 16;
            this.label37.Text = "38%";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(5, 225);
            this.label36.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(363, 34);
            this.label36.TabIndex = 15;
            this.label36.Text = "1억 5천만원 초과 3억원 이하";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(481, 181);
            this.label35.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(194, 34);
            this.label35.TabIndex = 14;
            this.label35.Text = "1,490만원";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(379, 181);
            this.label34.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(91, 34);
            this.label34.TabIndex = 13;
            this.label34.Text = "35%";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(5, 181);
            this.label33.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(363, 34);
            this.label33.TabIndex = 12;
            this.label33.Text = "8,800만원 초과 1억 5천만원 이하";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(481, 137);
            this.label32.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(194, 34);
            this.label32.TabIndex = 11;
            this.label32.Text = "522만원";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(379, 137);
            this.label31.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(91, 34);
            this.label31.TabIndex = 10;
            this.label31.Text = "24%";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(5, 137);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(363, 34);
            this.label27.TabIndex = 9;
            this.label27.Text = "4,600만원 초과 8,800만원 이하";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(481, 93);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(194, 34);
            this.label26.TabIndex = 8;
            this.label26.Text = "108만원";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(379, 93);
            this.label24.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 34);
            this.label24.TabIndex = 7;
            this.label24.Text = "15%";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(5, 93);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(363, 34);
            this.label21.TabIndex = 6;
            this.label21.Text = "1,200만원 초과 4,600만원 이하";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(379, 49);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 34);
            this.label15.TabIndex = 4;
            this.label15.Text = "6%";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(481, 49);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 34);
            this.label18.TabIndex = 5;
            this.label18.Text = "해당 없음";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(5, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(1);
            this.label12.Size = new System.Drawing.Size(363, 34);
            this.label12.TabIndex = 3;
            this.label12.Text = "1,200만원 이하";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(379, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 34);
            this.label6.TabIndex = 1;
            this.label6.Text = "세율";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(481, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 34);
            this.label9.TabIndex = 2;
            this.label9.Text = "누진 공제";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "과세표준";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(303, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 28;
            this.label20.Text = "원";
            // 
            // labelLongtermCare
            // 
            this.labelLongtermCare.AutoSize = true;
            this.labelLongtermCare.Location = new System.Drawing.Point(184, 90);
            this.labelLongtermCare.Name = "labelLongtermCare";
            this.labelLongtermCare.Size = new System.Drawing.Size(44, 12);
            this.labelLongtermCare.TabIndex = 27;
            this.labelLongtermCare.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 12);
            this.label22.TabIndex = 26;
            this.label22.Text = "장기요양보험료 :";
            // 
            // SalaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 514);
            this.Controls.Add(this.tabControlSalary);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalaryDetail";
            this.Text = "Form2";
            this.tabControlSalary.ResumeLayout(false);
            this.tabPageShowSalary.ResumeLayout(false);
            this.tabPageShowSalary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageShowTax.ResumeLayout(false);
            this.tableLayoutPanelTaxRate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSalary;
        private System.Windows.Forms.TabPage tabPageShowSalary;
        private System.Windows.Forms.TabPage tabPageShowTax;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboBoxShowDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDeductionAmount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelEmploymentInsurance;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelHealthInsurance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelNationalPension;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPaymentAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelExtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInputExtra;
        private System.Windows.Forms.Label labelRealIncome;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button buttonSelectEmployee;
        private System.Windows.Forms.Button buttonGetEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTaxRate;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewShowEmployee;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelLongtermCare;
        private System.Windows.Forms.Label label22;
    }
}