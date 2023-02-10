using SP.Validation.Principles._5_DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SP.Validation.Models.Enumerations;

namespace SP.Validation.Principles._5_DIP
{
    public class EmployeeStatistics_DIP
    {
        private readonly IEmployeeSearchable _emp;
        public EmployeeStatistics_DIP(IEmployeeSearchable emp)
        {
            _emp = emp;
        }
        public int CountFemaleManagers() =>
         _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}
