using System.Collections.Generic;
using System.Linq;

namespace OpenClosePrincipal.OpenCloseExample2
{
    public class MonitorFilter : IFilter<ComputerMonitor>
    {
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        {
            return monitors.Where(m => specification.isSatisfied(m)).ToList();
        }
    }
}



/*
     public class MonitorFilter 
    {
        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type)
        {
            return monitors.Where(m => m.Type == type).ToList();
        }
        public List<ComputerMonitor> FilterByScreen(IEnumerable<ComputerMonitor> monitors, Screen screen)
        {
            return monitors.Where(x => x.Screen == screen).ToList();
        }
    }
 */