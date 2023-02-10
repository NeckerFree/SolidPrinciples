using SP.Validation.Models;
using SP.Validation.Principles._5_DIP.Interfaces;
using static SP.Validation.Models.Enumerations;

namespace SP.Validation.Principles._5_DIP.Implementation
{
    public class EmployeeManager_DIP : IEmployeeSearchable
    {
        private readonly List<Employee> _employees;
        public EmployeeManager_DIP()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
            => _employees.Where(emp => emp.Gender == gender && emp.Position == position);
    }
}
