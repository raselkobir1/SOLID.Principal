using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeeByGenderAndPosition(Gender gender, Position position);
    }
}
