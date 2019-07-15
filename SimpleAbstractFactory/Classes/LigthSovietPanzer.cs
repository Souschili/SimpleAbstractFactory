using SimpleAbstractFactory.AbstarctClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstractFactory.Classes
{
    class LightSovietPanzer:AbstractPanzer
    {

        public string Model { get; set; }
        public string weaponModel { get; set; }


        public LightSovietPanzer()
        {
            this.Model = "БТ-7";
            this.weaponModel = "45-мм 20-К обр. 1934 г.";
        }


        public override void Info()
        {
            Console.WriteLine($"I am Soviet Panzer {Model} and i have weapon {weaponModel}");
        }
    }
}
