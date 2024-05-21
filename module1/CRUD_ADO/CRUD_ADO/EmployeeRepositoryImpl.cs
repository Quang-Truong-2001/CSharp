using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ADO
{
    internal class EmployeeRepositoryImpl : IEmployeeRepository
    {
        private readonly static string SELECT_ALL = "SELECT * FROM Employees";
        private readonly static string INSERT_INTO = "INSERT INTO Employees (FirstName, LastName, Email, HireDate) VALUES (@Value1, @Value2, @Value3,@Value4)";
        private readonly static string SELECT_ONE = "SELECT * FROM Employees WHERE EmployeeID=@Value";
        private readonly static string DELETE_ONE = "DELETE FROM Employees WHERE EmployeeID=@Value";

        public void DeleteById(int id)
        {
            try
            {
                SqlConnection conn = ConnectSQLServerDB.GetSqlConnection();
                SqlCommand cmd = new SqlCommand(DELETE_ONE, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Value", id);
                // ExecuteNonQuery: dùng để trả về số dòng bị thay đổi, dùng cho câu lệnh insert, update, delete
                // ExecuteReader: dùng để trả về kết quả, dùng cho câu lệnh select 
                int row =cmd.ExecuteNonQuery();
                Console.WriteLine(row + " dong bi xoa");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();

            try
            {

                SqlConnection connection = ConnectSQLServerDB.GetSqlConnection();
                SqlCommand command = new SqlCommand(SELECT_ALL, connection);
                command.CommandType = System.Data.CommandType.Text;
                //command.CommandType=System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee emp = new Employee();
                    emp.Id = reader.GetInt32(0);
                    emp.FirstName = reader.GetString(1) != null ? reader.GetString(1) : string.Empty;
                    emp.LastName = reader.GetString(2);
                    emp.Email = reader.GetString(3);
                    emp.HireDate = (DateTime)reader.GetValue(4);
                    list.Add(emp);

                }
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }

        public Employee GetById(int id)
        {
            Employee emp=new Employee();
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
                SqlCommand command=new SqlCommand("GetEmployeeById", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", id);



                //SqlCommand command=new SqlCommand(SELECT_ONE, connection);
                //command.CommandType = System.Data.CommandType.Text;
                //command.Parameters.AddWithValue("@Value", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    emp.Id = Convert.ToInt32(reader.GetInt32(0)) ;
                    emp.FirstName = Convert.ToString(reader.GetString(1)) ;
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

        public void SaveNew(Employee employee)
        {
            try
            {
                SqlConnection connection = ConnectSQLServerDB.GetSqlConnection();
                SqlCommand command = new SqlCommand(INSERT_INTO, connection);
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.AddWithValue("@Value1", employee.FirstName);
                command.Parameters.AddWithValue("@Value2", employee.LastName);
                command.Parameters.AddWithValue("@Value3", employee.Email);
                command.Parameters.AddWithValue("@Value4", employee.HireDate);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data inserted successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to insert data.");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
