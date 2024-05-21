using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DATAADAPTER_DATASET_DATATABLE
{

    internal class EmployeeRepositoryImpl : IEmployeeRepository
    {
        private static readonly SqlDataAdapter adapter=new SqlDataAdapter() ;
        private static readonly DataSet dataSet = DataAdapterConfig.Config(adapter);


        public void UpdateEmployee(Employee employee)
        {
            DataTable employees = dataSet.Tables["Employees"];
            DataRow row = employees.Rows[0];
            row["FirstName"] = "Hello";
            adapter.Update(dataSet);
            GetAllDataAdapter();
        }

        public void SaveNew(Employee employee)
        {
            try
            {
                DataTable employees = dataSet.Tables["Employees"];
                DataRow row = employees.Rows.Add();
                row["FirstName"] = "Tran";
                //row["LastName"] = "Tran";
                row["Email"] = "Tran";
                row["HireDate"] = DateTime.Now;
                adapter.Update(dataSet);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public List<Employee> GetAllDataAdapter()
        {
            try
            {
                DataTable employees = dataSet.Tables["Employees"];
                Ultils.ShowData(employees); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Ultils.ConvertToEmployee(dataSet.Tables["Employees"]);
        }
        public void DeleteById(int id)
        {
            try
            {
                DataTable employees = dataSet.Tables["Employees"];
                DataRow row = employees.Rows[id];
                row.Delete();
                adapter.Update(dataSet);    
                GetAllDataAdapter();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public Employee GetById(int id)
        {
            Employee emp = new Employee();
            try
            {
                SqlConnection connection = ConnectSQLServerDB.GetSqlConnection();
                // Sử dụng SP (Stored Procedure)
                //select* from[dbo].[Employees] ;

                //CREATE PROCEDURE GetEmployeeById
                //    @EmployeeID INT
                //AS
                //BEGIN
                //     SELECT* FROM Employees WHERE EmployeeID = @EmployeeID;
                //END
                SqlCommand command = new SqlCommand("GetEmployeeById", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", id);



                //SqlCommand command=new SqlCommand(SELECT_ONE, connection);
                //command.CommandType = System.Data.CommandType.Text;
                //command.Parameters.AddWithValue("@Value", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    emp.Id = Convert.ToInt32(reader.GetInt32(0));
                    emp.FirstName = Convert.ToString(reader.GetString(1));
                    emp.LastName = Convert.ToString(reader.GetString(2));
                    emp.Email = Convert.ToString(reader.GetString(3));
                    emp.HireDate = Convert.ToDateTime(reader.GetValue(4));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return emp;
        }

    }

}
