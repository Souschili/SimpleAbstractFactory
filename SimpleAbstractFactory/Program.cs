using SimpleAbstractFactory.Classes;
using SimpleAbstractFactory.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructArea panzer1=new ConstructArea(new LightGermanPanzerFactory());
            panzer1.About();
            var panzer2 = new ConstructArea(new LightSovietPanzerFactory());
            panzer2.About();
        }
    }
}
