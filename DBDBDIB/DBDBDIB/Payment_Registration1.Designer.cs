namespace DBDBDIB
{
    partial class Payment_Registration1
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
            this.groupBoxForpay1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewWork = new System.Windows.Forms.DataGridView();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxSelected = new System.Windows.Forms.TextBox();
            this.textBoxComent = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxForpay2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelRegister = new System.Windows.Forms.TableLayoutPanel();
            this.결재자3사원명 = new System.Windows.Forms.Label();
            this.결재자3직급 = new System.Windows.Forms.Label();
            this.결재자3부서 = new System.Windows.Forms.Label();
            this.결재자2사원명 = new System.Windows.Forms.Label();
            this.labelfree = new System.Windows.Forms.Label();
            this.부서 = new System.Windows.Forms.Label();
            this.직급 = new System.Windows.Forms.Label();
            this.사원명 = new System.Windows.Forms.Label();
            this.제1결재자 = new System.Windows.Forms.Label();
            this.제2결재자 = new System.Windows.Forms.Label();
            this.제3결재자 = new System.Windows.Forms.Label();
            this.결재자1부서 = new System.Windows.Forms.Label();
            this.결재자1직급 = new System.Windows.Forms.Label();
            this.결재자1사원명 = new System.Windows.Forms.Label();
            this.결재자2부서 = new System.Windows.Forms.Label();
            this.결재자2직급 = new System.Windows.Forms.Label();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.listBoxRank = new System.Windows.Forms.ListBox();
            this.listBoxApart = new System.Windows.Forms.ListBox();
            this.radioButtonThir = new System.Windows.Forms.RadioButton();
            this.radioButtonSec = new System.Windows.Forms.RadioButton();
            this.radioButtonfirst = new System.Windows.Forms.RadioButton();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxForpay1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWork)).BeginInit();
            this.groupBoxForpay2.SuspendLayout();
            this.tableLayoutPanelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForpay1
            // 
            this.groupBoxForpay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxForpay1.Controls.Add(this.dataGridViewWork);
            this.groupBoxForpay1.Controls.Add(this.buttonNext);
            this.groupBoxForpay1.Controls.Add(this.textBoxSelected);
            this.groupBoxForpay1.Controls.Add(this.textBoxComent);
            this.groupBoxForpay1.Controls.Add(this.textBoxContent);
            this.groupBoxForpay1.Controls.Add(this.textBoxTitle);
            this.groupBoxForpay1.Controls.Add(this.label6);
            this.groupBoxForpay1.Controls.Add(this.label4);
            this.groupBoxForpay1.Controls.Add(this.label3);
            this.groupBoxForpay1.Controls.Add(this.label2);
            this.groupBoxForpay1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxForpay1.Name = "groupBoxForpay1";
            this.groupBoxForpay1.Size = new System.Drawing.Size(1012, 665);
            this.groupBoxForpay1.TabIndex = 2;
            this.groupBoxForpay1.TabStop = false;
            this.groupBoxForpay1.Text = "결재 등록 기입 사항";
            // 
            // dataGridViewWork
            // 
            this.dataGridViewWork.AllowUserToAddRows = false;
            this.dataGridViewWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWork.ColumnHeadersVisible = false;
            this.dataGridViewWork.Location = new System.Drawing.Point(131, 283);
            this.dataGridViewWork.MultiSelect = false;
            this.dataGridViewWork.Name = "dataGridViewWork";
            this.dataGridViewWork.ReadOnly = true;
            this.dataGridViewWork.RowHeadersVisible = false;
            this.dataGridViewWork.RowHeadersWidth = 62;
            this.dataGridViewWork.RowTemplate.Height = 30;
            this.dataGridViewWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWork.Size = new System.Drawing.Size(856, 194);
            this.dataGridViewWork.TabIndex = 10;
            this.dataGridViewWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWork_CellClick);
            this.dataGridViewWork.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWork_CellContentClick);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.Location = new System.Drawing.Point(865, 626);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(122, 33);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "다음";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxSelected
            // 
            this.textBoxSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSelected.Location = new System.Drawing.Point(131, 249);
            this.textBoxSelected.Name = "textBoxSelected";
            this.textBoxSelected.Size = new System.Drawing.Size(856, 28);
            this.textBoxSelected.TabIndex = 7;
            // 
            // textBoxComent
            // 
            this.textBoxComent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxComent.Location = new System.Drawing.Point(133, 502);
            this.textBoxComent.Multiline = true;
            this.textBoxComent.Name = "textBoxComent";
            this.textBoxComent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxComent.Size = new System.Drawing.Size(854, 101);
            this.textBoxComent.TabIndex = 6;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContent.Location = new System.Drawing.Point(131, 122);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(856, 110);
            this.textBoxContent.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTitle.Location = new System.Drawing.Point(131, 68);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(856, 28);
            this.textBoxTitle.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "결재 코멘트";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "관련 업무";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "결재 내용";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "결재 제목";
            // 
            // groupBoxForpay2
            // 
            this.groupBoxForpay2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxForpay2.Controls.Add(this.tableLayoutPanelRegister);
            this.groupBoxForpay2.Controls.Add(this.buttonPayment);
            this.groupBoxForpay2.Controls.Add(this.listBoxName);
            this.groupBoxForpay2.Controls.Add(this.listBoxRank);
            this.groupBoxForpay2.Controls.Add(this.listBoxApart);
            this.groupBoxForpay2.Controls.Add(this.radioButtonThir);
            this.groupBoxForpay2.Controls.Add(this.radioButtonSec);
            this.groupBoxForpay2.Controls.Add(this.radioButtonfirst);
            this.groupBoxForpay2.Controls.Add(this.buttonDel);
            this.groupBoxForpay2.Controls.Add(this.buttonUpdate);
            this.groupBoxForpay2.Controls.Add(this.buttonAdd);
            this.groupBoxForpay2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBoxForpay2.Location = new System.Drawing.Point(12, 12);
            this.groupBoxForpay2.Name = "groupBoxForpay2";
            this.groupBoxForpay2.Size = new System.Drawing.Size(1012, 666);
            this.groupBoxForpay2.TabIndex = 4;
            this.groupBoxForpay2.TabStop = false;
            this.groupBoxForpay2.Text = "결재자 선택";
            // 
            // tableLayoutPanelRegister
            // 
            this.tableLayoutPanelRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelRegister.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelRegister.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelRegister.ColumnCount = 4;
            this.tableLayoutPanelRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRegister.Controls.Add(this.결재자3사원명, 3, 3);
            this.tableLayoutPanelRegister.Controls.Add(this.결재자3직급, 2, 3);
            this.tableLayoutPanelRegister.Controls.Add(this.결재자3부서, 1, 3);
            this.tableLayoutPanelRegister.Controls.Add(this.결재자2사원명, 3, 2);
            this.tableLayoutPanelRegister.Controls.Add(this.labelfree, 0, 0);
            this.tableLayoutPanelRegister.Controls.Add(this.부서, 1, 0);
            this.tableLayoutPanelRegister.Controls.Add(this.직급, 2, 0);
            this.tableLayoutPanelRegister.Controls.Add(this.사원명, 3, 0);
            this.tableLayoutPanelRegister.Controls.Add(this.제1결재자, 0, 1);
            this.tableLayoutPanelRegister.Controls.Add(this.제2결재자, 0, 2);
            this.tableLayoutPanelRegister.Controls.Add(this.제3결재자, 0, 3);
            this.tableLayoutPanelRegister.Controls.Add(this.결재자1부서, 1, 1);
            this.tableLayoutPanelRegister.Controls.Add(this.결재자1직급, 2, 1);
            this.tableLayoutPanelRegister.Controls.Add(this.결재자1사원명, 3, 1);
            this.tableLayoutPanelRegister.Controls.Add(this.결재자2부서, 1, 2);
            this.tableLayoutPanelRegister.Controls.Add(this.결재자2직급, 2, 2);
            this.tableLayoutPanelRegister.Location = new System.Drawing.Point(19, 28);
            this.tableLayoutPanelRegister.Name = "tableLayoutPanelRegister";
            this.tableLayoutPanelRegister.RowCount = 4;
            this.tableLayoutPanelRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRegister.Size = new System.Drawing.Size(797, 192);
            this.tableLayoutPanelRegister.TabIndex = 11;
            // 
            // 결재자3사원명
            // 
            this.결재자3사원명.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.결재자3사원명.AutoSize = true;
            this.결재자3사원명.Location = new System.Drawing.Point(601, 142);
            this.결재자3사원명.Name = "결재자3사원명";
            this.결재자3사원명.Size = new System.Drawing.Size(192, 49);
            this.결재자3사원명.TabIndex = 15;
            this.결재자3사원명.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 결재자3직급
            // 
            this.결재자3직급.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.결재자3직급.AutoSize = true;
            this.결재자3직급.Location = new System.Drawing.Point(402, 142);
            this.결재자3직급.Name = "결재자3직급";
            this.결재자3직급.Size = new System.Drawing.Size(192, 49);
            this.결재자3직급.TabIndex = 14;
            this.결재자3직급.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 결재자3부서
            // 
            this.결재자3부서.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.결재자3부서.AutoSize = true;
            this.결재자3부서.Location = new System.Drawing.Point(203, 142);
            this.결재자3부서.Name = "결재자3부서";
            this.결재자3부서.Size = new System.Drawing.Size(192, 49);
            this.결재자3부서.TabIndex = 13;
            this.결재자3부서.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 결재자2사원명
            // 
            this.결재자2사원명.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.결재자2사원명.AutoSize = true;
            this.결재자2사원명.Location = new System.Drawing.Point(601, 95);
            this.결재자2사원명.Name = "결재자2사원명";
            this.결재자2사원명.Size = new System.Drawing.Size(192, 46);
            this.결재자2사원명.TabIndex = 12;
            this.결재자2사원명.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfree
            // 
            this.labelfree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelfree.AutoSize = true;
            this.labelfree.Location = new System.Drawing.Point(4, 1);
            this.labelfree.Name = "labelfree";
            this.labelfree.Size = new System.Drawing.Size(192, 46);
            this.labelfree.TabIndex = 11;
            this.labelfree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 부서
            // 
            this.부서.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.부서.AutoSize = true;
            this.부서.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.부서.Location = new System.Drawing.Point(203, 1);
            this.부서.Name = "부서";
            this.부서.Size = new System.Drawing.Size(192, 46);
            this.부서.TabIndex = 0;
            this.부서.Text = "부서";
            this.부서.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 직급
            // 
            this.직급.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.직급.AutoSize = true;
            this.직급.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.직급.Location = new System.Drawing.Point(402, 1);
            this.직급.Name = "직급";
            this.직급.Size = new System.Drawing.Size(192, 46);
            this.직급.TabIndex = 1;
            this.직급.Text = "직급";
            this.직급.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 사원명
            // 
            this.사원명.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.사원명.AutoSize = true;
            this.사원명.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.사원명.Location = new System.Drawing.Point(601, 1);
            this.사원명.Name = "사원명";
            this.사원명.Size = new System.Drawing.Size(192, 46);
            this.사원명.TabIndex = 2;
            this.사원명.Text = "사원명";
            this.사원명.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 제1결재자
            // 
            this.제1결재자.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.제1결재자.AutoSize = true;
            this.제1결재자.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.제1결재자.Location = new System.Drawing.Point(4, 48);
            this.제1결재자.Name = "제1결재자";
            this.제1결재자.Size = new System.Drawing.Size(192, 46);
            this.제1결재자.TabIndex = 3;
            this.제1결재자.Text = "제1결재자";
            this.제1결재자.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 제2결재자
            // 
            this.제2결재자.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.제2결재자.AutoSize = true;
            this.제2결재자.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.제2결재자.Location = new System.Drawing.Point(4, 95);
            this.제2결재자.Name = "제2결재자";
            this.제2결재자.Size = new System.Drawing.Size(192, 46);
            this.제2결재자.TabIndex = 4;
            this.제2결재자.Text = "제2결재자";
            this.제2결재자.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 제3결재자
            // 
            this.제3결재자.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.제3결재자.AutoSize = true;
            this.제3결재자.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.제3결재자.Location = new System.Drawing.Point(4, 142);
            this.제3결재자.Name = "제3결재자";
            this.제3결재자.Size = new System.Drawing.Size(192, 49);
            this.제3결재자.TabIndex = 5;
            this.제3결재자.Text = "제3결재자";
            this.제3결재자.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 결재자1부서
            // 
            this.결재자1부서.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.결재자1부서.AutoSize = true;
            this.결재자1부서.Location = new System.Drawing.Point(203, 48);
            this.결재자1부서.Name = "결재자1부서";
            this.결재자1부서.Size = new System.Drawing.Size(192, 46);
            this.결재자1부서.TabIndex = 6;
            this.결재자1부서.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 결재자1직급
            // 
            this.결재자1직급.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.결재자1직급.AutoSize = true;
            this.결재자1직급.Location = new System.Drawing.Point(402, 48);
            this.결재자1직급.Name = "결재자1직급";
            this.결재자1직급.Size = new System.Drawing.Size(192, 46);
            this.결재자1직급.TabIndex = 7;
            this.결재자1직급.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 결재자1사원명
            // 
            this.결재자1사원명.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.결재자1사원명.AutoSize = true;
            this.결재자1사원명.Location = new System.Drawing.Point(601, 48);
            this.결재자1사원명.Name = "결재자1사원명";
            this.결재자1사원명.Size = new System.Drawing.Size(192, 46);
            this.결재자1사원명.TabIndex = 8;
            this.결재자1사원명.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 결재자2부서
            // 
            this.결재자2부서.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.결재자2부서.AutoSize = true;
            this.결재자2부서.Location = new System.Drawing.Point(203, 95);
            this.결재자2부서.Name = "결재자2부서";
            this.결재자2부서.Size = new System.Drawing.Size(192, 46);
            this.결재자2부서.TabIndex = 9;
            this.결재자2부서.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 결재자2직급
            // 
            this.결재자2직급.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.결재자2직급.AutoSize = true;
            this.결재자2직급.Location = new System.Drawing.Point(402, 95);
            this.결재자2직급.Name = "결재자2직급";
            this.결재자2직급.Size = new System.Drawing.Size(192, 46);
            this.결재자2직급.TabIndex = 10;
            this.결재자2직급.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPayment
            // 
            this.buttonPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPayment.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPayment.Location = new System.Drawing.Point(892, 613);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(105, 33);
            this.buttonPayment.TabIndex = 10;
            this.buttonPayment.Text = "결재";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // listBoxName
            // 
            this.listBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.ItemHeight = 18;
            this.listBoxName.Location = new System.Drawing.Point(748, 297);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.ScrollAlwaysVisible = true;
            this.listBoxName.Size = new System.Drawing.Size(249, 292);
            this.listBoxName.TabIndex = 8;
            // 
            // listBoxRank
            // 
            this.listBoxRank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxRank.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxRank.FormattingEnabled = true;
            this.listBoxRank.ItemHeight = 18;
            this.listBoxRank.Location = new System.Drawing.Point(389, 297);
            this.listBoxRank.Name = "listBoxRank";
            this.listBoxRank.ScrollAlwaysVisible = true;
            this.listBoxRank.Size = new System.Drawing.Size(249, 292);
            this.listBoxRank.TabIndex = 7;
            this.listBoxRank.SelectedIndexChanged += new System.EventHandler(this.listBoxRank_SelectedIndexChanged);
            // 
            // listBoxApart
            // 
            this.listBoxApart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxApart.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxApart.FormattingEnabled = true;
            this.listBoxApart.ItemHeight = 18;
            this.listBoxApart.Location = new System.Drawing.Point(19, 297);
            this.listBoxApart.Name = "listBoxApart";
            this.listBoxApart.ScrollAlwaysVisible = true;
            this.listBoxApart.Size = new System.Drawing.Size(249, 292);
            this.listBoxApart.TabIndex = 6;
            this.listBoxApart.SelectedIndexChanged += new System.EventHandler(this.listBoxApart_SelectedIndexChanged);
            // 
            // radioButtonThir
            // 
            this.radioButtonThir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonThir.AutoSize = true;
            this.radioButtonThir.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButtonThir.Location = new System.Drawing.Point(701, 251);
            this.radioButtonThir.Name = "radioButtonThir";
            this.radioButtonThir.Size = new System.Drawing.Size(115, 22);
            this.radioButtonThir.TabIndex = 5;
            this.radioButtonThir.TabStop = true;
            this.radioButtonThir.Text = "제3결재자";
            this.radioButtonThir.UseVisualStyleBackColor = true;
            this.radioButtonThir.CheckedChanged += new System.EventHandler(this.radioButtonThir_CheckedChanged);
            // 
            // radioButtonSec
            // 
            this.radioButtonSec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonSec.AutoSize = true;
            this.radioButtonSec.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButtonSec.Location = new System.Drawing.Point(474, 251);
            this.radioButtonSec.Name = "radioButtonSec";
            this.radioButtonSec.Size = new System.Drawing.Size(115, 22);
            this.radioButtonSec.TabIndex = 4;
            this.radioButtonSec.TabStop = true;
            this.radioButtonSec.Text = "제2결재자";
            this.radioButtonSec.UseVisualStyleBackColor = true;
            this.radioButtonSec.CheckedChanged += new System.EventHandler(this.radioButtonSec_CheckedChanged);
            // 
            // radioButtonfirst
            // 
            this.radioButtonfirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonfirst.AutoSize = true;
            this.radioButtonfirst.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButtonfirst.Location = new System.Drawing.Point(231, 251);
            this.radioButtonfirst.Name = "radioButtonfirst";
            this.radioButtonfirst.Size = new System.Drawing.Size(115, 22);
            this.radioButtonfirst.TabIndex = 3;
            this.radioButtonfirst.TabStop = true;
            this.radioButtonfirst.Text = "제1결재자";
            this.radioButtonfirst.UseVisualStyleBackColor = true;
            this.radioButtonfirst.CheckedChanged += new System.EventHandler(this.radioButtonfirst_CheckedChanged);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDel.Location = new System.Drawing.Point(862, 171);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(135, 34);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "삭제";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonUpdate.Location = new System.Drawing.Point(862, 112);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(135, 34);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "수정";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAdd.Location = new System.Drawing.Point(862, 50);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 34);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Payment_Registration1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 689);
            this.Controls.Add(this.groupBoxForpay2);
            this.Controls.Add(this.groupBoxForpay1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment_Registration1";
            this.Text = "결재등록";
            this.groupBoxForpay1.ResumeLayout(false);
            this.groupBoxForpay1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWork)).EndInit();
            this.groupBoxForpay2.ResumeLayout(false);
            this.groupBoxForpay2.PerformLayout();
            this.tableLayoutPanelRegister.ResumeLayout(false);
            this.tableLayoutPanelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForpay1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxSelected;
        private System.Windows.Forms.TextBox textBoxComent;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxForpay2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegister;
        private System.Windows.Forms.Label 결재자3사원명;
        private System.Windows.Forms.Label 결재자3직급;
        private System.Windows.Forms.Label 결재자3부서;
        private System.Windows.Forms.Label 결재자2사원명;
        private System.Windows.Forms.Label labelfree;
        private System.Windows.Forms.Label 부서;
        private System.Windows.Forms.Label 직급;
        private System.Windows.Forms.Label 사원명;
        private System.Windows.Forms.Label 제1결재자;
        private System.Windows.Forms.Label 제2결재자;
        private System.Windows.Forms.Label 제3결재자;
        private System.Windows.Forms.Label 결재자1부서;
        private System.Windows.Forms.Label 결재자1직급;
        private System.Windows.Forms.Label 결재자1사원명;
        private System.Windows.Forms.Label 결재자2부서;
        private System.Windows.Forms.Label 결재자2직급;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.ListBox listBoxRank;
        private System.Windows.Forms.ListBox listBoxApart;
        private System.Windows.Forms.RadioButton radioButtonThir;
        private System.Windows.Forms.RadioButton radioButtonSec;
        private System.Windows.Forms.RadioButton radioButtonfirst;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewWork;
    }
}