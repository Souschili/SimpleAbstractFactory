using SimpleAbstractFactory.AbstarctClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstractFactory.Classes
{
    class LightGermanPanzerFactory : AbstractFactory
    {
        public override AbstractPanzer CreatePanzer()
        {
            return new LightGermanPanzer();
        }
    }
}
