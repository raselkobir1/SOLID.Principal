using System.Linq;

namespace DependencyInversionPrinciple
{
    public class EmployeeStatistics  //higher lavel class/module
    {
        private readonly EmployeeManager _empManager;
        public EmployeeStatistics(EmployeeManager empManager) 
        {
            _empManager = empManager;
        }
        public int CountFemaleManager()
        {
            return _empManager.GetEmployeeByGenderAndPosition(Gender.Female, Position.Manager).Count();
        }
    }
}
 