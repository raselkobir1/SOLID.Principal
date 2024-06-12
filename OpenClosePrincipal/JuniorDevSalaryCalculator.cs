namespace OpenClosePrincipal
{
    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }
        public override double CalculateSalary()
        {
            double juniorSalary = DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
            return juniorSalary;
        }
    }
}
