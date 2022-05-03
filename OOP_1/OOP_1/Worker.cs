using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_1
{
    class Worker
    {

        public string name;
        public int age;
        public int salary;
     
        public void WorkersSums()
        {
            Worker worker = new Worker();
            worker.name = "John";
            worker.age = 25;
            worker.salary = 1000;
          
            Worker worker1 = new Worker();
            worker1.name = "Sam";
            worker1.age = 26;
            worker1.salary = 2000;

            int salary_sum = (worker.salary + worker1.salary);
            int age_sum = (worker.age + worker1.age);
            Console.WriteLine($"Salaries sum is equal to {salary_sum}");
            Console.WriteLine($"Ages sum is equal to {age_sum}");
        }

    }
}