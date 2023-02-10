using SP.Validation.Models;

namespace SP.Validation.Principles._2_OCP
{
    internal class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport) 
            : base(developerReport)
        {
        }

        public override double CalculateSalary()
        {
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
    }
    }
}
