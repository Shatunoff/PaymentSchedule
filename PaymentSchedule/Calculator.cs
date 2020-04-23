using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PaymentSchedule
{
    public enum CalcType { ANNUITY, DIFFERENTIATED }

    public class Calculator
    {
        public decimal CreditAmount { get; set; }
        public decimal CreditRate { get; set; }
        public int CreditPeriod { get; set; }
        public CalcType SelectedCalcType { get; set; }

        public Calculator()
        {

        }

        public Calculator(decimal creditAmount, decimal creditRate, int creditPeriod, CalcType selectCalcType)
        {
            CreditAmount = creditAmount;
            CreditRate = creditRate;
            CreditPeriod = creditPeriod;
            SelectedCalcType = selectCalcType;
        }

        public DataTable GetShedule()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Месяц", typeof(int));
            dt.Columns.Add("Сумма платежа", typeof(int));
            dt.Columns.Add("Платеж по основному долгу, руб.", typeof(int));
            dt.Columns.Add("Платеж по процентам, руб.", typeof(int));
            dt.Columns.Add("Остаток основного долга, руб.", typeof(int));
            return dt;
        }
    }
}
