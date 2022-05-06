using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{
    public class Cat:Animal
    {
        private string _species;

        public Cat(string name, string species, string breed, int age):base(name,breed)
        {
            this.name = name;
            _species = species;
            this.breed = breed;
            this.age = age;
        }

        public void PrintCatParameters()
        {
            Console.WriteLine($"{name} is a {_species} cat, {breed} breed and is {age} years old");
        }
    }
}
