using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    public class Dog:Animal
    {
        private string _size;

        public Dog (string breed, string name, string size, int age)
        {
            this.breed = breed;
            this.name = name;            
            _size = size;
            this.age = age;
        }

        public Dog(string breed, string name, string size)
        {
            this.breed = breed;
            this.name = name;
            _size = size;
        }
        public override void PrintAnimalParameter()
        {
            Console.WriteLine($"{name} is a {_size} {breed} and is {age} years old");
        }

        public override void PrintGreeting()
        {
            Console.WriteLine("We all are dogs.Woof Woof fellow dogs");
        }

        public override void PrintByeMessage()
        {
            Console.WriteLine("Bye Woof fellow dogs");
        }
    }
}
