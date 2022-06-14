using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            // Create a class Animal
            // give this class 4 members that all Animals have in common
            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             * Creatively display the class member values 
             */

            Bird Eagle = new Bird();
            Eagle.Nickname = "Baldy";
            Eagle.Noise = "CAAARAAAHHH";
            Eagle.WingspanFt = 15;
            Eagle.LbsAbleToCarry = 100;
            Eagle.CanFly = true;
            Eagle.EggColor = "bald";

            Reptile BeardedDragon = new Reptile();
            BeardedDragon.Nickname = "Mr.Grumpy";
            BeardedDragon.Noise = "grrreeeahhhhhhhhhh";
            BeardedDragon.NumberTeeth = 720;
            BeardedDragon.LengthTongueFt = 4.25;
            BeardedDragon.Nocturnal = true;
            BeardedDragon.MagicPower = "hypnosis";

            Console.WriteLine("you have obtained two spirit animals so far!");
            Console.WriteLine("Look at them!");
            
            Eagle.BirdFacts();

            Console.WriteLine();

            BeardedDragon.ReptileFacts();









        }
    }
}
