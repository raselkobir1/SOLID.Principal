﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
