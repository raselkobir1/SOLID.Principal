using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmployeeStatistics  //higher lavel class
    {
        private readonly EmployeeManager _empManager;
        public EmployeeStatistics(EmployeeManager empManager) 
        {
            _empManager = empManager;
        }
        public int CountFemaleManager()
        {
            return _empManager.Employees().Count(emp => emp.Gender.Equals(Gender.Female) && emp.Position.Equals(Position.Manager));
        }
    }
}
 