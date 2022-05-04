using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class Worker2
    {
        private string name;
        private int age;
        private int salary;

        public void SetName(string value)
        {
            name = value;
        }
        public string GetName()
        {
            return name;
        }
        
       
        public void SetAge(int value)
        {
            age = value;
        }
        private bool CheckAge(int age)
        {
            return (age >= 1 && age <= 100) ? true : false;
        }

        public void GetAge()
        {
            if (CheckAge(age))
            {
                Console.WriteLine("Age Set as " + age);
            }
            else
            {
                Console.WriteLine("Value not valid");
            }
        }

        public void SetSalary(int value)
        {
            salary = value;
        }
        public int GetSalary()
        {
            return salary;
        }
    }
}





