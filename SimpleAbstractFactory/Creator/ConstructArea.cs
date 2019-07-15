using SimpleAbstractFactory.AbstarctClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstractFactory.Creator
{
    class ConstructArea
    {
        private AbstractPanzer panzer;

        public ConstructArea(AbstractFactory factory)
        {
            this.panzer = factory.CreatePanzer();
        }

        public void About()
        {
            this.panzer.Info();
        }
    }
}
