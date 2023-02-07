using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Validation.Principles._2_OCP
{
    public class SalaryCalculator_OCP
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;

        public SalaryCalculator_OCP(IEnumerable<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devCalc in _developerCalculation)
            {
                totalSalaries += devCalc.CalculateSalary();
            }

            return totalSalaries;
        }
    }
}
