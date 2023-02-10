using SP.Validation.Models;
using SP.Validation.Principles._5_DIP.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SP.Validation.Models.Enumerations;

namespace SP.Validation.Principles._5_DIP.Implementation
{
    public class EmployeeManager_DIC : IEmployeeSearchable
    {
        private readonly HashSet<Employee> _employees;
        public EmployeeManager_DIC( )
        {
            _employees = new HashSet<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
           => _employees.Where(emp => emp.Gender == gender && emp.Position == position);
    }
}
