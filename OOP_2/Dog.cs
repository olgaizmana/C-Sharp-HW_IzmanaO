using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{
    public class Dog:Animal
    {
        private string _size;

        public Dog (string breed, string name, string size, int age):base(breed, name)
        {
            this.breed = breed;
            this.name = name;            
            _size = size;
            this.age = age;
        }

        public Dog(string breed, string name, string size):base(breed, name)
        {
            this.breed = breed;
            this.name = name;
            _size = size;
        }
        public void PrintDogParameters()
        {
            Console.WriteLine($"{name} is a {_size} {breed} and is {age} years old");
        }
    }
}
