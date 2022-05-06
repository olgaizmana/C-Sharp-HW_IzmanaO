using System;
using System.Collections.Generic;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("John", 1000, 25);
            worker.PrintAgeSalary();

            List<Worker1> workers = new List<Worker1>();
            Worker1 workerIvan = new Worker1("Ivan", 25, 1000);
            workers.Add(workerIvan);
            Worker1 workerVasya = new Worker1("Vasya", 26, 2000);
            workers.Add(workerVasya);
            workerIvan.Worker1SalarySum(workers);

            Student student = new Student("Wasya", 20, "Nobel", "Math");
            student.PrintScholarshipCourse();

            Dog dogKuzya = new Dog("Rotweiller", "Kuzya", "medium", 2);
            dogKuzya.PrintGreeting();
            dogKuzya.PrintDogParameters();
            dogKuzya.DogExtend();

            Cat catWasya = new Cat("Wasya", "house", "dvornyaga", 5);
            catWasya.PrintGreeting();
            catWasya.PrintCatParameters();
        }
    }
}

