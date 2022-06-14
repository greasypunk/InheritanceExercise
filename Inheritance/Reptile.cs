using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            LifespanYrs = 500;
            IsFriendly = false;
            Diet = "children";
        }

        public int NumberTeeth { get; set; }
        public double LengthTongueFt { get; set; }
        public bool Nocturnal { get; set; }
        public string MagicPower { get; set; }

        public void ReptileFacts()
        {
            AnimalFacts();
            Console.WriteLine($"Number of Teeth    = {NumberTeeth}");
            Console.WriteLine($"LengthTongue (Ft)  = {LengthTongueFt}");
            Console.WriteLine($"Nocturnal          = {Nocturnal}");
            Console.WriteLine($"MagicPower         = {MagicPower}");
        }



    }
}
