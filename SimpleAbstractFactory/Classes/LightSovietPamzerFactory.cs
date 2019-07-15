using SimpleAbstractFactory.AbstarctClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstractFactory.Classes
{
    class LightSovietPamzerFactory : AbstractFactory
    {
        public override AbstractPanzer CreatePanzer()
        {
            return new LightSovietPanzer();
        }
    }
}
