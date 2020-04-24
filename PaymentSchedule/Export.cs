using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentSchedule
{
    public static class Export
    {
        public static void ToCSV(string filename, DataTable dataTable, string summaryCreditAmount, string creditAmount, string summaryOverpayment)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine(String.Join(";", dataTable.Columns[0].Caption, dataTable.Columns[1].Caption, dataTable.Columns[2].Caption, dataTable.Columns[3].Caption, dataTable.Columns[4].Caption));
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    sw.WriteLine(String.Join(";", dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4]));
                sw.WriteLine(String.Join(";", "Итого", summaryCreditAmount, creditAmount, summaryOverpayment));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                sw?.Close();
                fs?.Close();
            }
        }
    }
}
