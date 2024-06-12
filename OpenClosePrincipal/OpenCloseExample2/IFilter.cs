using System.Collections.Generic;

namespace OpenClosePrincipal.OpenCloseExample2
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}
