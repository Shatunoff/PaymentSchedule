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

            dgvSchedule.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            for (int i = 1; i < dgvSchedule.Columns.Count; i++)
            {
                dgvSchedule.Columns[i].DefaultCellStyle.Format = String.Format("### ### ### ##0.#0");
                dgvSchedule.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvSchedule.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
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
            nudCreditPeriod.Value = 60M;
            nudCreditRate.Value = 6.5M;
            comboPaymentType.SelectedIndex = 0;
            tbMonthlyPayment.Clear();
            tbSummaryCreditAmount.Clear();
            tbSummaryOverPayment.Clear();
            btnExportToCSV.Enabled = false;
        }

        private void CalcCreditAmount(object sender, EventArgs e)
        {
            decimal cAm = Calculator.GetCreditAmount(nudCostOfPurchase.Value, nudInitialPayment.Value);
            nudCreditAmount.Value = cAm < 0? cAm : 0;
        }

        private void comboPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPaymentType.SelectedIndex == 0)
                toolTip.SetToolTip(comboPaymentType, "Вариант ежемесячного платежа по кредиту, когда размер ежемесячного платежа остаётся постоянным на всём периоде кредитования.");
            if (comboPaymentType.SelectedIndex == 1)
                toolTip.SetToolTip(comboPaymentType, "Вариант ежемесячного платежа по кредиту, когда размер ежемесячного платежа по погашению кредита постепенно уменьшается к концу периода кредитования.");
        }

        private void nuds_Enter(object sender, EventArgs e)
        {
            if (sender is NumericUpDown)
                (sender as NumericUpDown).Select(0, (sender as NumericUpDown).Value.ToString().Length);
        }

        private void nudCreditPeriod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K)
                nudCreditPeriod.Value *= 12;
        }
    }
}
