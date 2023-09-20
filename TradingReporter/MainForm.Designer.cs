namespace TradingReporter2
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSelect = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabWeeklyReport = new System.Windows.Forms.TabPage();
            this.grvWeeklyReport = new System.Windows.Forms.DataGridView();
            this.CW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDailyDetail = new System.Windows.Forms.GroupBox();
            this.txtDetailAvgRR = new System.Windows.Forms.Label();
            this.txtDetailWinRate = new System.Windows.Forms.Label();
            this.txtDetailTpBeSl = new System.Windows.Forms.Label();
            this.txtDetailTongLenh = new System.Windows.Forms.Label();
            this.grvDailyDetail = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxLossPercent = new System.Windows.Forms.Label();
            this.txtMaxLoss = new System.Windows.Forms.TextBox();
            this.txtTotalProfitPercent = new System.Windows.Forms.Label();
            this.txtAvgRR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWinrate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalProfit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bRRDisplay = new System.Windows.Forms.CheckBox();
            this.numAccountSize = new System.Windows.Forms.NumericUpDown();
            this.btnReload = new System.Windows.Forms.Button();
            this.tabRaw = new System.Windows.Forms.TabPage();
            this.grvRaw = new System.Windows.Forms.DataGridView();
            this.cbbFilePath = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInfoAsian = new System.Windows.Forms.Label();
            this.txtInfoLondon = new System.Windows.Forms.Label();
            this.txtInfoNY = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabWeeklyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvWeeklyReport)).BeginInit();
            this.grDailyDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDailyDetail)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountSize)).BeginInit();
            this.tabRaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvRaw)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelect.Location = new System.Drawing.Point(504, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(74, 24);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabWeeklyReport);
            this.tabControl.Controls.Add(this.tabRaw);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(652, 530);
            this.tabControl.TabIndex = 2;
            // 
            // tabWeeklyReport
            // 
            this.tabWeeklyReport.Controls.Add(this.grvWeeklyReport);
            this.tabWeeklyReport.Controls.Add(this.grDailyDetail);
            this.tabWeeklyReport.Controls.Add(this.groupBox3);
            this.tabWeeklyReport.Controls.Add(this.groupBox2);
            this.tabWeeklyReport.Location = new System.Drawing.Point(4, 26);
            this.tabWeeklyReport.Name = "tabWeeklyReport";
            this.tabWeeklyReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeeklyReport.Size = new System.Drawing.Size(644, 500);
            this.tabWeeklyReport.TabIndex = 1;
            this.tabWeeklyReport.Text = "Weekly Report";
            this.tabWeeklyReport.UseVisualStyleBackColor = true;
            // 
            // grvWeeklyReport
            // 
            this.grvWeeklyReport.AllowUserToAddRows = false;
            this.grvWeeklyReport.AllowUserToDeleteRows = false;
            this.grvWeeklyReport.AllowUserToResizeRows = false;
            this.grvWeeklyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvWeeklyReport.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grvWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvWeeklyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CW,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.TOTAL});
            this.grvWeeklyReport.Location = new System.Drawing.Point(3, 138);
            this.grvWeeklyReport.Name = "grvWeeklyReport";
            this.grvWeeklyReport.ReadOnly = true;
            this.grvWeeklyReport.RowHeadersVisible = false;
            this.grvWeeklyReport.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grvWeeklyReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grvWeeklyReport.ShowRowErrors = false;
            this.grvWeeklyReport.Size = new System.Drawing.Size(491, 357);
            this.grvWeeklyReport.TabIndex = 0;
            this.grvWeeklyReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvWeeklyReport_CellClick);
            // 
            // CW
            // 
            this.CW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CW.DefaultCellStyle = dataGridViewCellStyle1;
            this.CW.HeaderText = "CW";
            this.CW.Name = "CW";
            this.CW.ReadOnly = true;
            this.CW.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CW.Width = 45;
            // 
            // Monday
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Monday.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monday.HeaderText = "Mon";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.Width = 70;
            // 
            // Tuesday
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Tuesday.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tuesday.HeaderText = "Tue";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.Width = 70;
            // 
            // Wednesday
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Wednesday.DefaultCellStyle = dataGridViewCellStyle4;
            this.Wednesday.HeaderText = "Wed";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.Width = 70;
            // 
            // Thursday
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Thursday.DefaultCellStyle = dataGridViewCellStyle5;
            this.Thursday.HeaderText = "Thu";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.Width = 70;
            // 
            // Friday
            // 
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Friday.DefaultCellStyle = dataGridViewCellStyle6;
            this.Friday.HeaderText = "Fri";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.Width = 70;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle7;
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.MinimumWidth = 70;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // grDailyDetail
            // 
            this.grDailyDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDailyDetail.Controls.Add(this.txtDetailAvgRR);
            this.grDailyDetail.Controls.Add(this.txtDetailWinRate);
            this.grDailyDetail.Controls.Add(this.txtDetailTpBeSl);
            this.grDailyDetail.Controls.Add(this.txtDetailTongLenh);
            this.grDailyDetail.Controls.Add(this.grvDailyDetail);
            this.grDailyDetail.Controls.Add(this.label7);
            this.grDailyDetail.Location = new System.Drawing.Point(380, 3);
            this.grDailyDetail.Name = "grDailyDetail";
            this.grDailyDetail.Size = new System.Drawing.Size(255, 492);
            this.grDailyDetail.TabIndex = 10;
            this.grDailyDetail.TabStop = false;
            this.grDailyDetail.Text = "Chi Tiết";
            // 
            // txtDetailAvgRR
            // 
            this.txtDetailAvgRR.AutoSize = true;
            this.txtDetailAvgRR.Location = new System.Drawing.Point(0, 103);
            this.txtDetailAvgRR.Name = "txtDetailAvgRR";
            this.txtDetailAvgRR.Size = new System.Drawing.Size(77, 18);
            this.txtDetailAvgRR.TabIndex = 2;
            this.txtDetailAvgRR.Text = "AvgRR: ## R";
            // 
            // txtDetailWinRate
            // 
            this.txtDetailWinRate.AutoSize = true;
            this.txtDetailWinRate.Location = new System.Drawing.Point(0, 79);
            this.txtDetailWinRate.Name = "txtDetailWinRate";
            this.txtDetailWinRate.Size = new System.Drawing.Size(99, 18);
            this.txtDetailWinRate.TabIndex = 2;
            this.txtDetailWinRate.Text = "WinRate: ##.#%";
            // 
            // txtDetailTpBeSl
            // 
            this.txtDetailTpBeSl.AutoSize = true;
            this.txtDetailTpBeSl.Location = new System.Drawing.Point(0, 46);
            this.txtDetailTpBeSl.Name = "txtDetailTpBeSl";
            this.txtDetailTpBeSl.Size = new System.Drawing.Size(120, 18);
            this.txtDetailTpBeSl.TabIndex = 2;
            this.txtDetailTpBeSl.Text = "TP/BE/SL: ##/##/##";
            // 
            // txtDetailTongLenh
            // 
            this.txtDetailTongLenh.AutoSize = true;
            this.txtDetailTongLenh.Location = new System.Drawing.Point(0, 21);
            this.txtDetailTongLenh.Name = "txtDetailTongLenh";
            this.txtDetailTongLenh.Size = new System.Drawing.Size(88, 18);
            this.txtDetailTongLenh.TabIndex = 2;
            this.txtDetailTongLenh.Text = "Tổng lệnh: ##";
            // 
            // grvDailyDetail
            // 
            this.grvDailyDetail.AllowUserToAddRows = false;
            this.grvDailyDetail.AllowUserToDeleteRows = false;
            this.grvDailyDetail.AllowUserToResizeRows = false;
            this.grvDailyDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvDailyDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grvDailyDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Ss,
            this.Profit});
            this.grvDailyDetail.Location = new System.Drawing.Point(120, 21);
            this.grvDailyDetail.Name = "grvDailyDetail";
            this.grvDailyDetail.ReadOnly = true;
            this.grvDailyDetail.RowHeadersVisible = false;
            this.grvDailyDetail.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grvDailyDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDailyDetail.ShowRowErrors = false;
            this.grvDailyDetail.Size = new System.Drawing.Size(129, 471);
            this.grvDailyDetail.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(-2, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "-----------------------------------------------";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtMaxLossPercent);
            this.groupBox3.Controls.Add(this.txtMaxLoss);
            this.groupBox3.Controls.Add(this.txtTotalProfitPercent);
            this.groupBox3.Controls.Add(this.txtAvgRR);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtWinrate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTotalProfit);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(179, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 132);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profit:";
            // 
            // txtMaxLossPercent
            // 
            this.txtMaxLossPercent.AutoSize = true;
            this.txtMaxLossPercent.Location = new System.Drawing.Point(140, 49);
            this.txtMaxLossPercent.Name = "txtMaxLossPercent";
            this.txtMaxLossPercent.Size = new System.Drawing.Size(58, 18);
            this.txtMaxLossPercent.TabIndex = 1;
            this.txtMaxLossPercent.Text = "+##.##%";
            // 
            // txtMaxLoss
            // 
            this.txtMaxLoss.Location = new System.Drawing.Point(74, 46);
            this.txtMaxLoss.Name = "txtMaxLoss";
            this.txtMaxLoss.ReadOnly = true;
            this.txtMaxLoss.Size = new System.Drawing.Size(64, 24);
            this.txtMaxLoss.TabIndex = 2;
            this.txtMaxLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalProfitPercent
            // 
            this.txtTotalProfitPercent.AutoSize = true;
            this.txtTotalProfitPercent.Location = new System.Drawing.Point(140, 24);
            this.txtTotalProfitPercent.Name = "txtTotalProfitPercent";
            this.txtTotalProfitPercent.Size = new System.Drawing.Size(58, 18);
            this.txtTotalProfitPercent.TabIndex = 1;
            this.txtTotalProfitPercent.Text = "+##.##%";
            // 
            // txtAvgRR
            // 
            this.txtAvgRR.Location = new System.Drawing.Point(74, 100);
            this.txtAvgRR.Name = "txtAvgRR";
            this.txtAvgRR.ReadOnly = true;
            this.txtAvgRR.Size = new System.Drawing.Size(64, 24);
            this.txtAvgRR.TabIndex = 2;
            this.txtAvgRR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "SL Streak:";
            // 
            // txtWinrate
            // 
            this.txtWinrate.Location = new System.Drawing.Point(74, 75);
            this.txtWinrate.Name = "txtWinrate";
            this.txtWinrate.ReadOnly = true;
            this.txtWinrate.Size = new System.Drawing.Size(64, 24);
            this.txtWinrate.TabIndex = 2;
            this.txtWinrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Win Rate:";
            // 
            // txtTotalProfit
            // 
            this.txtTotalProfit.Location = new System.Drawing.Point(74, 21);
            this.txtTotalProfit.Name = "txtTotalProfit";
            this.txtTotalProfit.ReadOnly = true;
            this.txtTotalProfit.Size = new System.Drawing.Size(64, 24);
            this.txtTotalProfit.TabIndex = 2;
            this.txtTotalProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Avg RR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(-3, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "-----------------------------------------------";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bRRDisplay);
            this.groupBox2.Controls.Add(this.numAccountSize);
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Location = new System.Drawing.Point(2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 132);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Account:";
            // 
            // bRRDisplay
            // 
            this.bRRDisplay.AutoSize = true;
            this.bRRDisplay.Location = new System.Drawing.Point(5, 45);
            this.bRRDisplay.Name = "bRRDisplay";
            this.bRRDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bRRDisplay.Size = new System.Drawing.Size(90, 22);
            this.bRRDisplay.TabIndex = 7;
            this.bRRDisplay.Text = "RR Display";
            this.bRRDisplay.UseVisualStyleBackColor = true;
            // 
            // numAccountSize
            // 
            this.numAccountSize.DecimalPlaces = 1;
            this.numAccountSize.Location = new System.Drawing.Point(74, 17);
            this.numAccountSize.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numAccountSize.Name = "numAccountSize";
            this.numAccountSize.Size = new System.Drawing.Size(63, 24);
            this.numAccountSize.TabIndex = 5;
            this.numAccountSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAccountSize.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(5, 73);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(164, 53);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // tabRaw
            // 
            this.tabRaw.Controls.Add(this.txtInfoNY);
            this.tabRaw.Controls.Add(this.txtInfoLondon);
            this.tabRaw.Controls.Add(this.txtInfoAsian);
            this.tabRaw.Controls.Add(this.grvRaw);
            this.tabRaw.Location = new System.Drawing.Point(4, 26);
            this.tabRaw.Name = "tabRaw";
            this.tabRaw.Padding = new System.Windows.Forms.Padding(3);
            this.tabRaw.Size = new System.Drawing.Size(637, 500);
            this.tabRaw.TabIndex = 0;
            this.tabRaw.Text = "Raw data";
            this.tabRaw.UseVisualStyleBackColor = true;
            // 
            // grvRaw
            // 
            this.grvRaw.AllowUserToAddRows = false;
            this.grvRaw.AllowUserToDeleteRows = false;
            this.grvRaw.AllowUserToResizeRows = false;
            this.grvRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvRaw.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grvRaw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRaw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.OrderNo,
            this.OpenTime,
            this.Session,
            this.ProfitLoss});
            this.grvRaw.Location = new System.Drawing.Point(3, 3);
            this.grvRaw.Name = "grvRaw";
            this.grvRaw.ReadOnly = true;
            this.grvRaw.RowHeadersVisible = false;
            this.grvRaw.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grvRaw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvRaw.Size = new System.Drawing.Size(634, 329);
            this.grvRaw.TabIndex = 0;
            // 
            // cbbFilePath
            // 
            this.cbbFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbFilePath.FormattingEnabled = true;
            this.cbbFilePath.Location = new System.Drawing.Point(0, 0);
            this.cbbFilePath.Name = "cbbFilePath";
            this.cbbFilePath.Size = new System.Drawing.Size(504, 25);
            this.cbbFilePath.TabIndex = 8;
            this.cbbFilePath.SelectedIndexChanged += new System.EventHandler(this.cbbFilePath_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.Location = new System.Drawing.Point(578, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(74, 24);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbFilePath);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 24);
            this.panel1.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "No.";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // OrderNo
            // 
            this.OrderNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OrderNo.HeaderText = "CW";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            this.OrderNo.Width = 70;
            // 
            // OpenTime
            // 
            this.OpenTime.HeaderText = "DoW";
            this.OpenTime.Name = "OpenTime";
            this.OpenTime.ReadOnly = true;
            // 
            // Session
            // 
            this.Session.HeaderText = "Session";
            this.Session.Name = "Session";
            this.Session.ReadOnly = true;
            // 
            // ProfitLoss
            // 
            this.ProfitLoss.HeaderText = "Profit Loss";
            this.ProfitLoss.Name = "ProfitLoss";
            this.ProfitLoss.ReadOnly = true;
            // 
            // txtInfoAsian
            // 
            this.txtInfoAsian.AutoSize = true;
            this.txtInfoAsian.Location = new System.Drawing.Point(3, 335);
            this.txtInfoAsian.Name = "txtInfoAsian";
            this.txtInfoAsian.Size = new System.Drawing.Size(350, 18);
            this.txtInfoAsian.TabIndex = 1;
            this.txtInfoAsian.Text = "Asian: Total(###) Win(##) Loss(##) BE(##) | WinRate (##.#%)";
            // 
            // txtInfoLondon
            // 
            this.txtInfoLondon.AutoSize = true;
            this.txtInfoLondon.Location = new System.Drawing.Point(3, 367);
            this.txtInfoLondon.Name = "txtInfoLondon";
            this.txtInfoLondon.Size = new System.Drawing.Size(350, 18);
            this.txtInfoLondon.TabIndex = 1;
            this.txtInfoLondon.Text = "Asian: Total(###) Win(##) Loss(##) BE(##) | WinRate (##.#%)";
            // 
            // txtInfoNY
            // 
            this.txtInfoNY.AutoSize = true;
            this.txtInfoNY.Location = new System.Drawing.Point(3, 399);
            this.txtInfoNY.Name = "txtInfoNY";
            this.txtInfoNY.Size = new System.Drawing.Size(350, 18);
            this.txtInfoNY.TabIndex = 1;
            this.txtInfoNY.Text = "Asian: Total(###) Win(##) Loss(##) BE(##) | WinRate (##.#%)";
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // Ss
            // 
            this.Ss.HeaderText = "Ss.";
            this.Ss.Name = "Ss";
            this.Ss.ReadOnly = true;
            this.Ss.Width = 30;
            // 
            // Profit
            // 
            this.Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 554);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(654, 593);
            this.Name = "MainForm";
            this.Text = "TradingReporter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabWeeklyReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvWeeklyReport)).EndInit();
            this.grDailyDetail.ResumeLayout(false);
            this.grDailyDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDailyDetail)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountSize)).EndInit();
            this.tabRaw.ResumeLayout(false);
            this.tabRaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvRaw)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRaw;
        private System.Windows.Forms.TabPage tabWeeklyReport;
        private System.Windows.Forms.DataGridView grvWeeklyReport;
        private System.Windows.Forms.DataGridView grvRaw;
        private System.Windows.Forms.TextBox txtMaxLoss;
        private System.Windows.Forms.TextBox txtTotalProfit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAccountSize;
        private System.Windows.Forms.Label txtMaxLossPercent;
        private System.Windows.Forms.Label txtTotalProfitPercent;
        private System.Windows.Forms.ComboBox cbbFilePath;
        private System.Windows.Forms.TextBox txtWinrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.CheckBox bRRDisplay;
        private System.Windows.Forms.TextBox txtAvgRR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grDailyDetail;
        private System.Windows.Forms.DataGridView grvDailyDetail;
        private System.Windows.Forms.Label txtDetailTongLenh;
        private System.Windows.Forms.Label txtDetailTpBeSl;
        private System.Windows.Forms.Label txtDetailAvgRR;
        private System.Windows.Forms.Label txtDetailWinRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitLoss;
        private System.Windows.Forms.Label txtInfoAsian;
        private System.Windows.Forms.Label txtInfoNY;
        private System.Windows.Forms.Label txtInfoLondon;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}

