using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal.OpenCloseExample2
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}
