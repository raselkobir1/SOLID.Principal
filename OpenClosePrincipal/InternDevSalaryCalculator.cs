namespace OpenClosePrincipal
{
    public class InternDevSalaryCalculator : BaseSalaryCalculator
    {
        public InternDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }

        public override double CalculateSalary()
        {
            double internSalary = DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
            return internSalary;
        }
    }
}
