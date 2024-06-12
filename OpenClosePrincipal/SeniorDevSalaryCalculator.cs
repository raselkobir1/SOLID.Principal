namespace OpenClosePrincipal
{
    public class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport developmentReport) : base(developmentReport)
        {
        }

        public override double CalculateSalary()
        {
            double seniorSalary = DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
            return seniorSalary;
        }
    }
}
