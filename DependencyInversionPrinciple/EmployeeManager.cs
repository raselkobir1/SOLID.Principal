using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public class EmployeeManager : IEmployeeSearchable    //lower lavel clsss/ module
    {
        private readonly List<Employee> _employees;
        public EmployeeManager()
        {
            _employees = new List<Employee>();  
        }
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);   
        }
        public IEnumerable<Employee> GetEmployeeByGenderAndPosition(Gender gender, Position position)
        {
            return _employees.Where(emp => emp.Gender.Equals(gender) && emp.Position.Equals(position));
        }
    }
}
