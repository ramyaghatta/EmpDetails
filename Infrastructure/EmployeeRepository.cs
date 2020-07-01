using CodeTask21.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTask21.Entities;

namespace CodeTask21.Infrastructure
{
    public class EmployeeRepository<T> : IEmployeeRepository<T> where T : Employee
    {
        private MyDbContext _DBContext;
        public EmployeeRepository(MyDbContext _Dbcont)
        {

            _DBContext = _Dbcont;
        }

        /// <summary>
        /// Creates an employee and stores it to the database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public T CreateEmployee(T employee)
        {
            _DBContext.Add(employee);
            _DBContext.SaveChanges();
            return employee;
        }

        /// <summary>
        /// Updates an employee and saves the changes to the database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public T UpdateEmployee(T employee)
        {
            //throw new NotImplementedException();
            _DBContext.Update(employee);
            _DBContext.SaveChanges();
            return employee;
        }

        /// <summary>
        /// Get all employees from the db
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IList<T> GetAll()
        {
            //throw new NotImplementedException();
            return (IList<T>)_DBContext.Employees.ToList();

        }

        /// <summary>
        /// Gets an employee from the db
        /// </summary>
        /// <param name="id">employee db</param>
        /// <returns></returns>
        public T GetEmployee(int id)
        {
            //throw new NotImplementedException();
            return (T)_DBContext.Employees.FirstOrDefault(e => e.EmpID == id);
        }

        /// <summary>
        /// Deletes an employee
        /// </summary>
        /// <param name="id">employee id</param>
        public void DeleteEmployee(int id)
        {
            //throw new NotImplementedException();
            Employee emp = new Employee();
            emp.EmpID = id;
            _DBContext.Employees.Remove(emp);
            _DBContext.SaveChanges();
            
        }
    }
}
