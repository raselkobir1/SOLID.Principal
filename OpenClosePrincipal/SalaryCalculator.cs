﻿using System;
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
                totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
            }
            return totalSalaries;
        }
    }
}