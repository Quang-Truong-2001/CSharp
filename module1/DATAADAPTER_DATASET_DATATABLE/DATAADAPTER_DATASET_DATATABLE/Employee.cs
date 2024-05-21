using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAADAPTER_DATASET_DATATABLE
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string firstName, string lastName, string email, DateTime hireDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            HireDate = hireDate;
        }

        public Employee(string firstName, string lastName, string email, DateTime hireDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            HireDate = hireDate;
        }
    }
}
