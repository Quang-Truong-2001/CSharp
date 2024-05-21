using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAADAPTER_DATASET_DATATABLE
{
    internal static class TriggerAdapter
    {
        private readonly static string SELECT_ALL = "SELECT * FROM Employees";
        private readonly static string INSERT_INTO = "INSERT INTO Employees (FirstName, LastName, Email, HireDate) VALUES (@FirstName, @LastName, @Email,@HireDate)";
        private readonly static string SELECT_ONE = "SELECT * FROM Employees WHERE EmployeeID=@Value";
        private readonly static string DELETE_ONE = "DELETE FROM Employees WHERE EmployeeID=@EmployeeID";
        private readonly static string UPDATE_ONE = "UPDATE Employees SET FirstName=@FirstName,LastName=@LastName, Email=@Email, HireDate=@HireDate WHERE EmployeeID = @EmployeeID";

        public static void InsertData(SqlDataAdapter adapter, SqlConnection connection)
        {
            try
            {

                adapter.InsertCommand = new SqlCommand(INSERT_INTO, connection);
                adapter.InsertCommand.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
                adapter.InsertCommand.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
                adapter.InsertCommand.Parameters.Add("@Email", SqlDbType.VarChar, 100, "Email");
                adapter.InsertCommand.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void SelectData(SqlDataAdapter adapter, DataSet dataSet, SqlConnection connection)
        {

                adapter.SelectCommand = new SqlCommand(SELECT_ALL, connection);
            adapter.Fill(dataSet);

        }
        public static void DeleteData(SqlDataAdapter adapter, SqlConnection connection)
        {


            adapter.DeleteCommand = new SqlCommand(DELETE_ONE, connection);
            var pr1 = adapter.DeleteCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int));
            // Thiết lập nguồn lấy dữ liệu từ DataTable đó là cột nào 
            pr1.SourceColumn = "EmployeeID";
            // Lấy phiên bản nào của dũ liệu cập nhật (Lấy dữ liệu gốc)
            pr1.SourceVersion = DataRowVersion.Original;

        }
        public static void UpdateData(SqlDataAdapter adapter, SqlConnection connection)
        { 
            adapter.UpdateCommand = new SqlCommand(UPDATE_ONE, connection);
            var pr1 = adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int));
            // Thiết lập nguồn lấy dữ liệu từ DataTable đó là cột nào 
            pr1.SourceColumn = "EmployeeID";
            // Lấy phiên bản nào của dũ liệu cập nhật (Lấy dữ liệu gốc)
            pr1.SourceVersion = DataRowVersion.Original;
            adapter.UpdateCommand.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            adapter.UpdateCommand.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            adapter.UpdateCommand.Parameters.Add("@Email", SqlDbType.VarChar, 100, "Email");
            adapter.UpdateCommand.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
        }
    }
}
