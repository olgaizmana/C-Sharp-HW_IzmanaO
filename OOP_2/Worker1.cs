using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{
    public class Worker1 : User
    {
        private int _salary;      
        public Worker1 (string name, int age, int salary): base(name)
        { 
            this.name = name;
            this.age = age;
            _salary = salary;
        }
        public void SetSalary(int salary)
        {
            _salary = salary;
        }

        public int GetSalary(int salary)
        {
            return salary;
        }

        public void Worker1SalarySum(List<Worker1> workers)
        {
            int salarySum = 0;

            foreach (var item in workers)
            {
                salarySum += item._salary;
            }
            Console.WriteLine($"Salaries sum is equal to {salarySum}");
        }
    }

}

