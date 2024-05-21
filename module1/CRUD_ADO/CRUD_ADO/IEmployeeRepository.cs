using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ADO
{
    internal interface IEmployeeRepository
    {
        List<Employee> GetAll();

        void SaveNew(Employee employee);

        Employee GetById(int id);

        void DeleteById(int id);
        
    }
}
