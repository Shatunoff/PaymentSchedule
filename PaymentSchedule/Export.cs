﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace PaymentSchedule
{
    public static class Export
    {
        public static void ToCSV(DataTable dataTable, string filename)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine(string.Join(";", dataTable.Columns[0].Caption, dataTable.Columns[1].Caption, dataTable.Columns[2].Caption, dataTable.Columns[3].Caption, dataTable.Columns[4].Caption));
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    sw.WriteLine($"{dataTable.Rows[i][0].ToString()};{dataTable.Rows[i][1].ToString()};{dataTable.Rows[i][2].ToString()};{dataTable.Rows[i][3].ToString()};{dataTable.Rows[i][4].ToString()}");
            }
            finally
            {
                sw?.Close();
                fs?.Close();
            }
        }
    }
}
