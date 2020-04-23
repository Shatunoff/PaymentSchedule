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
        public Form1()
        {
            InitializeComponent();
        }

        private void checkCalcAtSum_CheckedChanged(object sender, EventArgs e)
        {
            nudCreditAmount.ReadOnly = nudCostOfPurchase.Enabled = nudInitialPayment.Enabled = !checkCalcAtSum.Checked;
            //nudCreditAmount.Enabled = checkCalcAtSum.Checked;
        }

        // Рассчитать стоимость
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator(nudCreditAmount.Value, nudCreditRate.Value, (int)nudCreditPeriod.Value, (CalcType)comboPaymentType.SelectedIndex);
            dgvSchedule.DataSource = calculator.GetShedule();
        }
    }
}
