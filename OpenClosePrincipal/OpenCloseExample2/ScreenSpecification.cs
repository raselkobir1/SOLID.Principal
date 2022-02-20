using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal.OpenCloseExample2
{
    public class ScreenSpecification : ISpecification<ComputerMonitor>
    {
        private readonly Screen _screen;
        public ScreenSpecification(Screen screen)
        {
            _screen = screen;
        }
        public bool isSatisfied(ComputerMonitor item)
        {
            return item.Screen == _screen;
        }

    }
}
