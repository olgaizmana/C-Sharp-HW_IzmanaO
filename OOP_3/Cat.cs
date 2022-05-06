using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    public class Cat:Animal
    {
        private string _species;

        public Cat(string name, string species, string breed, int age) 
        { 
            this.name = name;
            _species = species;
            this.breed = breed;
            this.age = age;
        }

        public override void PrintAnimalParameter()
        {
            Console.WriteLine($"{name} is a {_species} cat, {breed} breed and is {age} years old");
        }

        public override void PrintByeMessage()
        {
            Console.WriteLine("Bye Meoow fellow cats");
        }
    }
}
