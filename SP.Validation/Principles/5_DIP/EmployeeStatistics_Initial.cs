using static SP.Validation.Models.Enumerations;

namespace SP.Validation.Principles._5_DIP
{
    public class EmployeeStatistics_Initial
    {
        private readonly EmployeeManager_Initial _empManager;
        public EmployeeStatistics_Initial(EmployeeManager_Initial empManager)
        {
            _empManager = empManager;
        }
        public int CountFemaleManagers() =>
               _empManager.Employees.Count(emp => emp.Gender == Gender.Female && emp.Position == Position.Manager);

    }
}
