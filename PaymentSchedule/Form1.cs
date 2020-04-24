using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentSchedule
{
    public partial class Form1 : Form
    {
        DataTable dtShedule = new DataTable();

        public Form1()
        {
            InitializeComponent();
            comboPaymentType.SelectedIndex = 0;
        }

        private void checkCalcAtSum_CheckedChanged(object sender, EventArgs e)
        {
            nudCostOfPurchase.Enabled = nudInitialPayment.Enabled = !checkCalcAtSum.Checked;
            nudCreditAmount.Enabled = checkCalcAtSum.Checked;
        }

        // Рассчитать стоимость
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator((double)nudCreditAmount.Value, (double)nudCreditRate.Value, (int)nudCreditPeriod.Value, (CalcType)comboPaymentType.SelectedIndex);
            dtShedule = calculator.GetShedule();
            dgvSchedule.DataSource = dtShedule;
            tbMonthlyPayment.Text = calculator.GetMonthlyPayment();
            tbSummaryCreditAmount.Text = calculator.GetSummaryCreditAmount();
            tbSummaryOverPayment.Text = calculator.GetSummaryOverPayment();
            for (int i = 1; i < dgvSchedule.Columns.Count; i++)
                dgvSchedule.Columns[i].DefaultCellStyle.Format = String.Format("### ### ### ##0.#0");
            btnExportToCSV.Enabled = true;
        }

        // Очистить расчеты
        private void btnClear_Click(object sender, EventArgs e)
        {
            dtShedule.Clear();
            checkCalcAtSum.Checked = false;
            nudCostOfPurchase.Value = nudCostOfPurchase.Minimum;
            nudInitialPayment.Value = nudInitialPayment.Minimum;
            nudCreditAmount.Value = nudCreditAmount.Minimum;
            nudCreditPeriod.Value = nudCreditPeriod.Minimum;
            nudCreditRate.Value = nudCreditRate.Minimum;
            comboPaymentType.SelectedIndex = 0;
            tbMonthlyPayment.Clear();
            tbSummaryCreditAmount.Clear();
            tbSummaryOverPayment.Clear();
            btnExportToCSV.Enabled = false;
        }
    }
}
