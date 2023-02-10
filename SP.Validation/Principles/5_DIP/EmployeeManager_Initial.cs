using SP.Validation.Models;

namespace SP.Validation.Principles._5_DIP
{

    public class EmployeeManager_Initial
    {
        private readonly List<Employee> _employees;
        public EmployeeManager_Initial()
        {
            _employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> Employees => _employees;
    }
}

