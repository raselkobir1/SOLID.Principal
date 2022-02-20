using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal.OpenCloseExample2
{
    public class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType _monitorType; 
        public MonitorTypeSpecification(MonitorType monitorType)
        {
            _monitorType = monitorType;
        }
        public bool isSatisfied(ComputerMonitor item)
        {
            return item.Type == _monitorType;
        }
    }
}
