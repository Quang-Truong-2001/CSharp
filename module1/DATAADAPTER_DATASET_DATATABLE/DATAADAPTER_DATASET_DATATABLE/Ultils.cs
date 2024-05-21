using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAADAPTER_DATASET_DATATABLE
{
    internal static class Ultils
    {
        public static List<Employee> ConvertToEmployee(DataTable dataTable)
        {
            List<Employee> list = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Employee emp = new Employee();
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    emp.Id = Convert.ToInt32(row[0]);
                    emp.FirstName = Convert.ToString(row[1]);
                    emp.LastName = Convert.ToString(row[2]);
                    emp.Email = Convert.ToString(row[3]);
                    emp.HireDate = Convert.ToDateTime(row[4]);
                }
                list.Add(emp);
            }

            return list;

        }
        public static void ShowData(DataTable table)
        {
            int index = 0;
            Console.Write($"index");
            foreach (DataColumn c in table.Columns)
            {
                Console.Write($"{c.ColumnName,20}");

            }
            Console.WriteLine();
            foreach (DataRow row in table.Rows)
            {

                Console.Write(index);
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    Console.Write($"{row[i],20}");
                }
                index++;
                Console.WriteLine();
            }
        }
    }
}
