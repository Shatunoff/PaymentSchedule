using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSchedule
{
    public enum CalcType { ANNUITY, DIFFERENTIATED }

    public class Calculator
    {
        public CalcType SelectedCalcType { get; set; }
        public decimal CreditAmount { get; set; }
    }
}
