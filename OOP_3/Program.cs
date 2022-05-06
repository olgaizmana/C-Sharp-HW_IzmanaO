using System;
using System.Collections.Generic;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dogKuzya = new Dog("Rotweiller", "Kuzya", "medium", 2);
            dogKuzya.PrintGreeting();
            dogKuzya.PrintAnimalParameter();
            dogKuzya.PrintByeMessage();
            dogKuzya.PrintByeMessage("Kuzya");
            

            Cat catWasya = new Cat("Wasya", "house", "dvornyaga", 5);
            catWasya.PrintGreeting();
            catWasya.PrintAnimalParameter();
            catWasya.PrintByeMessage();
        }
    }
}
