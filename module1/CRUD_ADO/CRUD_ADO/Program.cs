using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ADO
{
    internal class Program
    {
        private static readonly IEmployeeRepository repository=new EmployeeRepositoryImpl();
        static void Main(string[] args)
        {

            //List<Employee> list = employeeRepository.GetAll();
            // if(list.Count == 0)
            // {
            //     Console.WriteLine("Loi");
            // }
            // else
            // {
            //     foreach (Employee e in list)
            //     {
            //         Console.WriteLine(e.FirstName);
            //     }
            // }
            //Employee employee = new Employee(null,"Dung","dung@gmail.com",DateTime.Now);
            //repository.SaveNew(employee);

            Employee employee = repository.GetById(2);
            Console.WriteLine(employee.FirstName);

            //repository.DeleteById(1);


            Console.ReadLine();

        }
    }
}

