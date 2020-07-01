using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTask21.DTO;
using CodeTask21.Entities;
using CodeTask21.Infrastructure;
using CodeTask21.Interfaces;

namespace CodeTask21.Services
{
    public class EmployeeService<T> : IEmployeeService<T> where T : EmployeeViewModel
    {
        private IEmployeeRepository<Employee> _employeeRepository;
        public EmployeeService(IEmployeeRepository<Employee> Iemp)
        {
            _employeeRepository = Iemp;
        }

        /// <summary>
        /// Deletes an employee
        /// </summary>
        /// <param name="id">The employee id</param>
        public void DeleteEmployee(int id)
        {
            //throw new NotImplementedException();
            //throw new NotImplementedException();

        }

        /// <summary>
        /// Gets an employee with its id
        /// </summary>
        /// <param name="id">employee id</param>
        /// <returns></returns>
        public T GetEmployeeHandler(int id)
        {
            // throw new NotImplementedException();
            return (T)_employeeRepository.GetEmployee(id);

        }

        /// <summary>
        /// Will create an employee with the provided Dto and calls the IUserRepository
        /// </summary>
        /// <param name="employeeDto"></param>
        /// <returns></returns>
        T IEmployeeService<T>.CreateEmployeeHandler(EmployeeDto employeeDto)
        {
            //throw new NotImplementedException();
            EmployeeViewModel empVM = new EmployeeViewModel();
            try
            {
                Employee objEmp = new Employee();
                objEmp.EmpID = employeeDto.EmpID;
                objEmp.EmpName = employeeDto.EmpName;
                objEmp.Address = employeeDto.ProjectType;
                _employeeRepository.CreateEmployee(objEmp);
                empVM = objEmp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return (T)empVM;
        }


        /// <summary>
        /// Gets all the employees
        /// </summary>
        /// <returns></returns>
        IList<T> IEmployeeService<T>.GetAllHandler()
        {
            //throw new NotImplementedException();
            return (IList<T>)_employeeRepository.GetAll();

        }

        /// <summary>
        /// Updates an employee
        /// </summary>
        /// <param name="employeeDto">Dto that contains the data to be updated</param>
        /// <returns></returns>
        T IEmployeeService<T>.UpdateEmployeeHandler(EmployeeDto employeeDto)
        {
            //throw new NotImplementedException();
            Employee _empObj = new Employee();
            _empObj.EmpID = employeeDto.EmpID;
            _empObj.EmpName = employeeDto.EmpName;
            _empObj.Address = employeeDto.Address;
            _empObj.Salary = employeeDto.Salary;
            //_employeeRepository.UpdateEmployee(_empObj);
            return (T)_employeeRepository.UpdateEmployee(_empObj);
        }
    }
}
