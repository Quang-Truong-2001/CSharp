using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAADAPTER_DATASET_DATATABLE
{
    internal interface IEmployeeRepository
    { 
        List<Employee> GetAllDataAdapter();

        void SaveNew(Employee employee);

        Employee GetById(int id);

        void DeleteById(int id);
        void UpdateEmployee(Employee employee);
    }
}
