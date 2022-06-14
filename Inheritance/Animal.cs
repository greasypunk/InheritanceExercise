using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {
        }

        public int LifespanYrs { get; set; }
        public string Noise { get; set; }
        public bool IsFriendly { get; set; }
        public string Diet { get; set; }
        public string Nickname { get; set; }

        public void AnimalFacts()
        {
            Console.WriteLine($"Type               = {GetType().Name}");
            Console.WriteLine($"LifespanYrs        = {LifespanYrs}");
            Console.WriteLine($"Noise              = {Noise}");
            Console.WriteLine($"IsFriendly         = {IsFriendly}");
            Console.WriteLine($"Diet               = {Diet}");
            Console.WriteLine($"Nickname           = {Nickname}");
        }
    }
}
