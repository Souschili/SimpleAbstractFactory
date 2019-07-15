using SimpleAbstractFactory.AbstarctClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstractFactory.Classes
{
    class LightGermanPanzer:AbstractPanzer
    {

        public string Model { get; set; }
        public string weaponModel { get; set; }


        public LightGermanPanzer()
        {
            this.Model = "Pz.III Ausf J";
            this.weaponModel = "50-мм KwK 38";
        }

        
        public override void Info()
        {
            Console.WriteLine($"I am Getman Panzer {Model} and i have weapon {weaponModel}");
        }

    }
}
