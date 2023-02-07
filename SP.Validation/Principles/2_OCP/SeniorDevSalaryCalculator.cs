using SP.Validation.Models;

namespace SP.Validation.Principles._2_OCP
{
    internal class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport developerReport) 
            : base(developerReport)
        {
        }

        public override double CalculateSalary()
        {
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
        }
    }
}
