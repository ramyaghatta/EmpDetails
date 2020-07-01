using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTask21.DTO;
using CodeTask21.Services;

namespace CodeTask21.Interfaces
{
    /// <summary>
    /// Service for handling the requests of EmployeeController
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEmployeeService<T> where T : EmployeeViewModel
    {
        T CreateEmployeeHandler(EmployeeDto employeeDto);
        T UpdateEmployeeHandler(EmployeeDto employeeDto);
        IList<T> GetAllHandler();
        T GetEmployeeHandler(int id);
        void DeleteEmployee(int id);
    }

}
