using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAADAPTER_DATASET_DATATABLE
{
    internal class Program
    {
        private static readonly IEmployeeRepository _employeeRepository=new EmployeeRepositoryImpl();
        static void Main(string[] args)
        {
            //List<Employee> list=_employeeRepository.GetAllDataAdapter();
            //foreach(Employee emp in list)
            //{

            //    Console.WriteLine(emp.LastName);
            //}
            _employeeRepository.GetAllDataAdapter();
            Employee employee = new Employee();
            //_employeeRepository.SaveNew(employee);
            //_employeeRepository.GetAllDataAdapter();

            //_employeeRepository.DeleteById(0);
            _employeeRepository.UpdateEmployee(employee);
            Console.ReadLine();



        }
    }
}
