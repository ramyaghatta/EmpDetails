using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTask21.Entities;

namespace CodeTask21.Interfaces
{
    public interface IEmployeeRepository<T> where T : Employee
    {
        T CreateEmployee(T employee);
        T UpdateEmployee(T employee);
        IList<T> GetAll();
        T GetEmployee(int id);
        void DeleteEmployee(int id);
    }

}
