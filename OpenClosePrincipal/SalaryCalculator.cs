using System.Collections.Generic;

namespace OpenClosePrincipal
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation; 
        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerCalculation)
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


/*
 * Even though this solution is going to give us the correct result, this is not an optimal solution.

Why is that?

Mainly, because we had to modify our existing class behavior which worked perfectly.
Another thing is that if our boss comes again and ask us to modify calculation for the junior dev’s as well,
we would have to change our class again. This is totally against of what OCP stands for.

 */


/*-------------- before refectoring OCP principal--------------
 * 
 *  public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developmentReports;
        public SalaryCalculator(List<DeveloperReport> developmentReports)
        {
            _developmentReports = developmentReports;
        }
        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var devReport in _developmentReports)
            {
                if (devReport.Level == "Senior Developer")
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours * 1.2;   //20% bonus for senior dev
                }
                else
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
                }

            }
            return totalSalaries;
        }
    }
 * 
 */