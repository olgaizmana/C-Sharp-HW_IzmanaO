using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    public abstract class Animal
    {
        protected string breed;
        protected string name;
        protected int age;
        public virtual void PrintGreeting()
        {
            Console.WriteLine("We all are animals.Hello fellow animals");
        }

        public abstract void PrintAnimalParameter();

        public abstract void PrintByeMessage();
    }
}
