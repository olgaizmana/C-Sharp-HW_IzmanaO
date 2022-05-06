using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{
    public class Animal
    {
        protected string breed;
        protected string name;
        protected int age;

        public Animal(string breed, string name)
        {
            this.breed = breed;
            this.name = name;
        }

        public void PrintGreeting()
        {
            Console.WriteLine("We all are animals.Hello fellow animals");
        }
    }
}
