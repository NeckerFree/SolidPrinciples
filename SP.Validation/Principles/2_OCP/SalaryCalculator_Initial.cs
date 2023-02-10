using SP.Validation.Models;

namespace SP.Validation.Principles._2_OCP
{
    public class SalaryCalculator_Initial
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;

        public SalaryCalculator_Initial(List<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devReport in _developerReports)
            {
                totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
            }

            return totalSalaries;
        }
    }
}
