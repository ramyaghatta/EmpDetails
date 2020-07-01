using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTask21.Entities;

namespace CodeTask21.Services
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static implicit operator EmployeeViewModel(Employee v)
        {
            throw new NotImplementedException();
        }
    }
}
