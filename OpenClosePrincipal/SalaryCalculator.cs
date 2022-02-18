using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DevelopmentReport> _developmentReports;
        public SalaryCalculator(List<DevelopmentReport> developmentReports)
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
}


/*
 * Even though this solution is going to give us the correct result, this is not an optimal solution.

Why is that?

Mainly, because we had to modify our existing class behavior which worked perfectly.
Another thing is that if our boss comes again and ask us to modify calculation for the junior dev’s as well,
we would have to change our class again. This is totally against of what OCP stands for.

 */