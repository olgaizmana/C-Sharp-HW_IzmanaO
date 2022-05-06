using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{
    public class Worker
    {
        private string _name;
        private int _salary;
        private int _age;

        public Worker(string name, int salary, int age)
        {
            _name = name;
            _salary = salary;
            _age = age;
        }

        public string GetName(string _name)
        {
            return _name;
        }

        public int GetSalary(int _salary)
        {
            return _salary;
        }

        public int GetAge(int _age)
        {
            return _age;
        }

        public void PrintAgeSalary()
        {
            Console.WriteLine($"Object's age is {_age} and salary is {_salary}");
        }
    }
}
