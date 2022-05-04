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
              //  List<Worker> workers = new List<Worker>();

        //public void Workersobj()
        //{

        //Worker worker = new Worker();
        //worker.name = "John";
        //worker.age = 25;
        //worker.salary = 1000;


        //Worker worker1 = new Worker();
        // worker1.name = "Sam";
        // worker1.age = 26;
        // worker1.salary = 2000;

        // workers.Add(worker);
        // workers.Add(worker1);
        //}

        public void WorkersSalarySum(List<Worker> workers)
        {
            int salarySum = 0;

            foreach (var item in workers)
         {
              salarySum += item.salary;
         }
          Console.WriteLine($"Salaries sum is equal to {salarySum}");
         }

        public void WorkersAgeSum(List<Worker> workers)
        {
         int ageSum = 0;
         foreach (var item in workers)
         {
             ageSum += item.age;
         }
         Console.WriteLine($"Ages sum is equal to {ageSum}");
        }
    }
}


//public void SalarySum()
//{
  //  int salary_sum = worker.salary + worker1.salary;
  //  Console.WriteLine($"Salaries sum is equal to {salary_sum}");
//}


//public void AgeSum()
//{
//    int age_sum = (worker.age + worker1.age);
 //   Console.WriteLine($"Ages sum is equal to {age_sum}");
//}








