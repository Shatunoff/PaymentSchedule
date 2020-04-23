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
        private decimal _creditRateYear; // Годовая ставка по кредиту
        private decimal _creditRateMonth; // Месячная ставка по кредиту

        private string _summaryMonthlyPayment; // ДЛЯ РЕЗУЛЬТАТОВ: ЕЖЕМЕСЯЧНЫЙ ПЛАТЕЖ
        private string _summaryCreditAmount; // ДЛЯ РЕЗУЛЬТАТОВ: ИТОГОВАЯ СУММА КРЕДИТА
        private string _summaryOverPayment; // ДЛЯ РЕЗУЛЬТАТОВ: ИТОГОВАЯ ПЕРЕПЛАТА ПО КРЕДИТУ

        // Годовая по кредиту в процентах 
        // При установке значения автоматически приводится к математическому виду, 
        // а также вычисляется и задается месячная ставка.
        public decimal CreditRateYear 
        { 
            get
            {
                return _creditRateYear * 100;
            }
            set
            {
                _creditRateYear = value / 100;
                _creditRateMonth = value / 100 / 12;
            }
        }

        // Сумма кредита
        public decimal CreditAmount { get; set; }
        public int CreditPeriod { get; private set; } // Срок кредита (месяцев)
        public CalcType SelectedCalcType { get; set; } // Вид платежа

        public Calculator(decimal creditAmount, decimal creditRate, int creditPeriod, CalcType selectCalcType)
        {
            CreditAmount = creditAmount;
            CreditRateYear = creditRate;
            CreditPeriod = creditPeriod;
            SelectedCalcType = selectCalcType;
        }

        /// <summary>
        /// Возвращает график платежей в виде DataTable на основе указанных данных.
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable GetShedule()
        {
            DataTable dtShedule = new DataTable();
            dtShedule.Columns.Add("Месяц", typeof(int));
            dtShedule.Columns.Add("Сумма платежа", typeof(string));
            dtShedule.Columns.Add("Платеж по основному долгу, руб.", typeof(string));
            dtShedule.Columns.Add("Платеж по процентам, руб.", typeof(string));
            dtShedule.Columns.Add("Остаток основного долга, руб.", typeof(string));

            DataRow dr = dtShedule.NewRow();

            // АННУИТЕТНЫЙ ПЛАТЕЖ
            if (SelectedCalcType == CalcType.ANNUITY)
            {
                decimal monthlyPayment = CreditAmount * (_creditRateMonth / (1 - Pow(1 + _creditRateMonth, -CreditPeriod))); // Вычисление ежемесячного платежа
                decimal summaryCreditAmount = monthlyPayment * CreditPeriod; // Итоговая сумма кредита

                _summaryMonthlyPayment = monthlyPayment.ToString("N2"); // Для результатов
                _summaryCreditAmount = summaryCreditAmount.ToString("N2"); // Для результатов

                decimal tempCreditAmount = CreditAmount;
                decimal tempSummaryCreditAmount = summaryCreditAmount;
                decimal tempItogPlus = 0;

                for (int i = 1; i <= CreditPeriod; i++)
                {
                    decimal percent = tempCreditAmount * _creditRateMonth;
                    tempCreditAmount -= monthlyPayment - percent;
                    dr[0] = i;
                    dr[1] = _summaryMonthlyPayment;
                    dr[2] = (monthlyPayment - percent).ToString("N2");
                    dr[3] = percent.ToString("N2");
                    dr[4] = tempCreditAmount.ToString("N2");
                    tempSummaryCreditAmount -= monthlyPayment;
                    if (i == CreditPeriod) tempItogPlus = tempCreditAmount;
                    dtShedule.Rows.Add(dr);
                }

                _summaryOverPayment = (summaryCreditAmount - CreditAmount + tempItogPlus).ToString("N2"); // Для результатов
            }
            // ДИФФЕРЕНЦИРОВАННЫЙ ПЛАТЕЖ
            if (SelectedCalcType == CalcType.DIFFERENTIATED)
            {
                for (int i = 1; i <= CreditPeriod; i++)
                {
                    dr[0] = i;
                    dr[1] = 2;
                    dr[2] = 2;
                    dr[3] = 2;
                    dr[4] = 2;
                    dtShedule.Rows.Add(dr);
                }
            }
            
            return dtShedule;
        }

        private decimal Pow(decimal x, decimal y)
        {
            return 0;
        }

        public string GetOverPayment()
        {
            return _summaryOverPayment;
        }
    }
}
