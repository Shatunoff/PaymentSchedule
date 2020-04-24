namespace PaymentSchedule
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSchedule = new System.Windows.Forms.GroupBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMonthlyPayment = new System.Windows.Forms.TextBox();
            this.tbSummaryOverPayment = new System.Windows.Forms.TextBox();
            this.tbSummaryCreditAmount = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudCreditAmount = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comboPaymentType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCreditPeriod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCreditRate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudInitialPayment = new System.Windows.Forms.NumericUpDown();
            this.nudCostOfPurchase = new System.Windows.Forms.NumericUpDown();
            this.checkCalcAtSum = new System.Windows.Forms.CheckBox();
            this.gbSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostOfPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSchedule
            // 
            this.gbSchedule.Controls.Add(this.dgvSchedule);
            this.gbSchedule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSchedule.Location = new System.Drawing.Point(0, 243);
            this.gbSchedule.Name = "gbSchedule";
            this.gbSchedule.Size = new System.Drawing.Size(554, 358);
            this.gbSchedule.TabIndex = 1;
            this.gbSchedule.TabStop = false;
            this.gbSchedule.Text = "График платежей";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.AllowUserToResizeColumns = false;
            this.dgvSchedule.AllowUserToResizeRows = false;
            this.dgvSchedule.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedule.Location = new System.Drawing.Point(3, 16);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(548, 339);
            this.dgvSchedule.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnExportToCSV);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbMonthlyPayment);
            this.groupBox2.Controls.Add(this.tbSummaryOverPayment);
            this.groupBox2.Controls.Add(this.tbSummaryCreditAmount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(330, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 243);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат расчетов";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "руб.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "руб.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "руб.";
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Enabled = false;
            this.btnExportToCSV.Location = new System.Drawing.Point(6, 208);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(205, 23);
            this.btnExportToCSV.TabIndex = 3;
            this.btnExportToCSV.Text = "Экспортировать результаты в .CSV";
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ежемесячный платеж:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Переплата по кредиту:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Итоговая стоимость:";
            // 
            // tbMonthlyPayment
            // 
            this.tbMonthlyPayment.Location = new System.Drawing.Point(6, 155);
            this.tbMonthlyPayment.Name = "tbMonthlyPayment";
            this.tbMonthlyPayment.Size = new System.Drawing.Size(173, 20);
            this.tbMonthlyPayment.TabIndex = 2;
            // 
            // tbSummaryOverPayment
            // 
            this.tbSummaryOverPayment.Location = new System.Drawing.Point(6, 103);
            this.tbSummaryOverPayment.Name = "tbSummaryOverPayment";
            this.tbSummaryOverPayment.Size = new System.Drawing.Size(173, 20);
            this.tbSummaryOverPayment.TabIndex = 1;
            // 
            // tbSummaryCreditAmount
            // 
            this.tbSummaryCreditAmount.Location = new System.Drawing.Point(6, 51);
            this.tbSummaryCreditAmount.Name = "tbSummaryCreditAmount";
            this.tbSummaryCreditAmount.Size = new System.Drawing.Size(173, 20);
            this.tbSummaryCreditAmount.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(330, 243);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudCreditAmount);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.comboPaymentType);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.nudCreditPeriod);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nudCreditRate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nudInitialPayment);
            this.tabPage1.Controls.Add(this.nudCostOfPurchase);
            this.tabPage1.Controls.Add(this.checkCalcAtSum);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Исходные данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudCreditAmount
            // 
            this.nudCreditAmount.Enabled = false;
            this.nudCreditAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCreditAmount.Location = new System.Drawing.Point(183, 81);
            this.nudCreditAmount.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudCreditAmount.Name = "nudCreditAmount";
            this.nudCreditAmount.Size = new System.Drawing.Size(133, 20);
            this.nudCreditAmount.TabIndex = 3;
            this.nudCreditAmount.ThousandsSeparator = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(183, 186);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Рассчитать стоимость";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистить расчеты";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboPaymentType
            // 
            this.comboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaymentType.FormattingEnabled = true;
            this.comboPaymentType.Items.AddRange(new object[] {
            "Аннуитетный",
            "Дифференцированный"});
            this.comboPaymentType.Location = new System.Drawing.Point(183, 159);
            this.comboPaymentType.Name = "comboPaymentType";
            this.comboPaymentType.Size = new System.Drawing.Size(133, 21);
            this.comboPaymentType.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Вид платежа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Срок кредита (мес.):";
            // 
            // nudCreditPeriod
            // 
            this.nudCreditPeriod.Location = new System.Drawing.Point(183, 133);
            this.nudCreditPeriod.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCreditPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCreditPeriod.Name = "nudCreditPeriod";
            this.nudCreditPeriod.Size = new System.Drawing.Size(133, 20);
            this.nudCreditPeriod.TabIndex = 5;
            this.nudCreditPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Процентная ставка (% годовых):";
            // 
            // nudCreditRate
            // 
            this.nudCreditRate.DecimalPlaces = 2;
            this.nudCreditRate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudCreditRate.Location = new System.Drawing.Point(183, 107);
            this.nudCreditRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCreditRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCreditRate.Name = "nudCreditRate";
            this.nudCreditRate.Size = new System.Drawing.Size(133, 20);
            this.nudCreditRate.TabIndex = 4;
            this.nudCreditRate.Value = new decimal(new int[] {
            65,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма кредита (руб.):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Первоначальный взнос (руб.):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Стоимость покупки (руб.):";
            // 
            // nudInitialPayment
            // 
            this.nudInitialPayment.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInitialPayment.Location = new System.Drawing.Point(183, 55);
            this.nudInitialPayment.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudInitialPayment.Name = "nudInitialPayment";
            this.nudInitialPayment.Size = new System.Drawing.Size(133, 20);
            this.nudInitialPayment.TabIndex = 2;
            this.nudInitialPayment.ThousandsSeparator = true;
            this.nudInitialPayment.ValueChanged += new System.EventHandler(this.CalcCreditAmount);
            // 
            // nudCostOfPurchase
            // 
            this.nudCostOfPurchase.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCostOfPurchase.Location = new System.Drawing.Point(183, 29);
            this.nudCostOfPurchase.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudCostOfPurchase.Name = "nudCostOfPurchase";
            this.nudCostOfPurchase.Size = new System.Drawing.Size(133, 20);
            this.nudCostOfPurchase.TabIndex = 1;
            this.nudCostOfPurchase.ThousandsSeparator = true;
            this.nudCostOfPurchase.ValueChanged += new System.EventHandler(this.CalcCreditAmount);
            // 
            // checkCalcAtSum
            // 
            this.checkCalcAtSum.AutoSize = true;
            this.checkCalcAtSum.Location = new System.Drawing.Point(6, 6);
            this.checkCalcAtSum.Name = "checkCalcAtSum";
            this.checkCalcAtSum.Size = new System.Drawing.Size(156, 17);
            this.checkCalcAtSum.TabIndex = 0;
            this.checkCalcAtSum.Text = "Расчет по сумме кредита";
            this.checkCalcAtSum.UseVisualStyleBackColor = true;
            this.checkCalcAtSum.CheckedChanged += new System.EventHandler(this.checkCalcAtSum_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(554, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Кредитный калькулятор";
            this.gbSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostOfPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSchedule;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboPaymentType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCreditPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCreditRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudInitialPayment;
        private System.Windows.Forms.NumericUpDown nudCostOfPurchase;
        private System.Windows.Forms.CheckBox checkCalcAtSum;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExportToCSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMonthlyPayment;
        private System.Windows.Forms.TextBox tbSummaryOverPayment;
        private System.Windows.Forms.TextBox tbSummaryCreditAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCreditAmount;
    }
}

