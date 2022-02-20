using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeeByGenderAndPosition(Gender gender, Position position);
    }
}
