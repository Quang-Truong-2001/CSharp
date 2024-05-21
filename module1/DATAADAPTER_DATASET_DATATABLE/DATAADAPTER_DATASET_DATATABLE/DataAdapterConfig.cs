using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAADAPTER_DATASET_DATATABLE
{
    internal static class DataAdapterConfig
    {
        public static DataSet Config(SqlDataAdapter adapter)
        {
            DataSet dataSet = new DataSet();
            try
            {
                // không được đổi tên chữ Table 
                SqlConnection connection = ConnectSQLServerDB.GetSqlConnection();
                adapter.TableMappings.Add("Table", "Employees");
                TriggerAdapter.InsertData(adapter,connection);
                TriggerAdapter.SelectData(adapter, dataSet, connection);
                TriggerAdapter.DeleteData(adapter, connection);
                TriggerAdapter.UpdateData(adapter, connection);
                connection.Close();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
            return dataSet;
        }
        
    }
}
