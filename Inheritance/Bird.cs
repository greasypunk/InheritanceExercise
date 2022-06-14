using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            LifespanYrs = 100;
            IsFriendly = true;
            Diet = "cheese and fine meats";
        }

        public int WingspanFt { get; set; }
        public int LbsAbleToCarry { get; set; }
        public bool CanFly { get; set; }
        public string EggColor { get; set; }

        public void BirdFacts()
        {
            AnimalFacts();
            Console.WriteLine($"Wingspan (Ft)      = {WingspanFt}");
            Console.WriteLine($"Can Carry (lbs)    = {LbsAbleToCarry}");
            Console.WriteLine($"CanFly             = {CanFly}");
            Console.WriteLine($"EggColor           = {EggColor}");
        }

    }
}
