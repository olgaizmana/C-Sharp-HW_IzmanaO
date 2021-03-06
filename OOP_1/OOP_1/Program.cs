using System;
using System.Collections.Generic;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
            
        {
            List<Worker> workers = new List<Worker>();
            Worker worker = new Worker();
            worker.name = "John";
            worker.age = 25;
            worker.salary = 1000;
            Worker worker1 = new Worker();
            worker1.name = "Sam";
            worker1.age = 26;
            worker1.salary = 2000;

            workers.Add(worker);
            workers.Add(worker1);

            worker.WorkersSalarySum(workers);
            worker.WorkersAgeSum(workers);

            List<Worker1> workers1 = new List<Worker1>();
            Worker1 worker3 = new Worker1();
            worker3.setName("John");
            worker3.setAge(25);
            worker3.setSalary(1000);
            Worker1 worker4 = new Worker1();
            worker4.setName("Sam");
            worker4.setAge(26);
            worker4.setSalary(2000);

            workers1.Add(worker3);
            workers1.Add(worker4);

            worker3.Workers1AgeSum(workers1);
            worker3.Workers1SalarySum(workers1);

            Worker2 worker5 = new Worker2();
            worker5.SetName("Johnny");
            worker5.SetAge(101);         

            worker5.GetAge();

            Matrix matrix = new Matrix();

            FirstDiagonal firstDiagonal = new FirstDiagonal();
            firstDiagonal.GetFirstDiagonalSum(matrix.CreateFirstMatrix());
            firstDiagonal.GetFirstDiagonalSum(matrix.CreateSecondMatrix());

            SecondDiagonal secondDiagonal = new SecondDiagonal();
            secondDiagonal.GetSecondDiagonalSum(matrix.CreateFirstMatrix());
            secondDiagonal.GetSecondDiagonalSum(matrix.CreateSecondMatrix());

            

            //Worker worker = new Worker();

            //worker.SalarySum();
            //worker.AgeSum();
            
            




            


        }
         
    }
}
