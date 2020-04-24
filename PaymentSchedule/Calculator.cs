using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Policy;

namespace PaymentSchedule
{
    public enum CalcType { ANNUITY, DIFFERENTIATED }

    public class Calculator
    {
        private double _creditRateYear; // Годовая ставка по кредиту
        private double _creditRateMonth; // Месячная ставка по кредиту

        private string _summaryMonthlyPayment; // ДЛЯ РЕЗУЛЬТАТОВ: ЕЖЕМЕСЯЧНЫЙ ПЛАТЕЖ
        private string _summaryCreditAmount; // ДЛЯ РЕЗУЛЬТАТОВ: ИТОГОВАЯ СУММА КРЕДИТА
        private string _summaryOverPayment; // ДЛЯ РЕЗУЛЬТАТОВ: ИТОГОВАЯ ПЕРЕПЛАТА ПО КРЕДИТУ

        // Годовая по кредиту в процентах 
        // При установке значения автоматически приводится к математическому виду, 
        // а также вычисляется и задается месячная ставка.
        public double CreditRateYear 
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
        public double CreditAmount { get; set; }
        public int CreditPeriod { get; private set; } // Срок кредита (месяцев)
        public CalcType SelectedCalcType { get; set; } // Вид платежа

        public Calculator(double creditAmount, double creditRate, int creditPeriod, CalcType selectCalcType)
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
            dtShedule.Columns.Add("Сумма платежа", typeof(double));
            dtShedule.Columns.Add("Платеж по основному долгу, руб.", typeof(double));
            dtShedule.Columns.Add("Платеж по процентам, руб.", typeof(double));
            dtShedule.Columns.Add("Остаток основного долга, руб.", typeof(double));

            DataRow dr;

            // АННУИТЕТНЫЙ ПЛАТЕЖ
            if (SelectedCalcType == CalcType.ANNUITY)
            {
                double monthlyPayment = CreditAmount * (_creditRateMonth / (1 - Math.Pow(1 + _creditRateMonth, -CreditPeriod))); // Вычисление ежемесячного платежа
                double summaryCreditAmount = monthlyPayment * CreditPeriod; // Итоговая сумма кредита

                _summaryMonthlyPayment = monthlyPayment.ToString("N2"); // Для результатов
                _summaryCreditAmount = summaryCreditAmount.ToString("N2"); // Для результатов

                double tempCreditAmount = CreditAmount;
                double tempSummaryCreditAmount = summaryCreditAmount;
                double tempItogPlus = 0;

                for (int i = 1; i <= CreditPeriod; i++)
                {
                    dr = dtShedule.NewRow();
                    double percent = tempCreditAmount * _creditRateMonth;
                    tempCreditAmount -= monthlyPayment - percent;
                    dr[0] = i; // Месяц
                    dr[1] = monthlyPayment; // Ежемесячный платеж
                    dr[2] = monthlyPayment - percent; // Основной долг
                    dr[3] = percent; // Долг по процентам
                    dr[4] = tempCreditAmount; // Остаток основного долга
                    tempSummaryCreditAmount -= monthlyPayment;
                    if (i == CreditPeriod) tempItogPlus = tempCreditAmount;
                    dtShedule.Rows.Add(dr);
                }

                _summaryOverPayment = (summaryCreditAmount - CreditAmount + tempItogPlus).ToString("N2"); // Для результатов
            }
            // ДИФФЕРЕНЦИРОВАННЫЙ ПЛАТЕЖ
            if (SelectedCalcType == CalcType.DIFFERENTIATED)
            {
                double mainPayment = CreditAmount / CreditPeriod; // Платеж по основному долгу
                double summaryCreditAmount = 0;
                double summaryOverPayment = 0;
                double tempCreditAmount = CreditAmount;
                double itogPlus = 0;

                for (int i = 1; i <= CreditPeriod; i++)
                {
                    dr = dtShedule.NewRow();
                    double percent = CreditAmount * _creditRateMonth; // процентная часть ежемесячного платежа
                    double monthlyPayment = mainPayment + percent;
                    summaryCreditAmount += monthlyPayment; // Итоговая сумма кредита
                    summaryOverPayment += percent; // Итоговая переплата по кредиту
                    tempCreditAmount -= mainPayment; // Остаток основного долга (с каждым месяцем уменьшается)
                    dr[0] = i;
                    dr[1] = monthlyPayment; // Ежемесячный платеж
                    dr[2] = mainPayment; // Основной долг
                    dr[3] = percent; // Долг по процентам
                    dr[4] = tempCreditAmount; // Остаток основного долга
                    dtShedule.Rows.Add(dr);
                    if (i == 1) _summaryMonthlyPayment = monthlyPayment.ToString("N2") + "...";
                    if (i == CreditPeriod) 
                    { 
                        _summaryMonthlyPayment += monthlyPayment.ToString("N2");
                        itogPlus += tempCreditAmount;
                    }
                }

                _summaryCreditAmount = summaryCreditAmount.ToString("N2");
                _summaryOverPayment = (summaryOverPayment + itogPlus).ToString("N2");
                

            }
            
            return dtShedule;
        }

        public string GetSummaryOverPayment()
        {
            return _summaryOverPayment;
        }

        public string GetSummaryCreditAmount()
        {
            return _summaryCreditAmount;
        }

        public string GetMonthlyPayment()
        {
            return _summaryMonthlyPayment;
        }

        public static decimal GetCreditAmount(decimal costOfPurchase, decimal initialPayment)
        {
            return costOfPurchase - initialPayment;
        }
    }
}
