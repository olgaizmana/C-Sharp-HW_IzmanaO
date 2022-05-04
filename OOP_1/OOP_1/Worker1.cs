using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class Worker1
    {
        private string name;
        private int age;
        private int salary;

        //public string Name
       // {
         //   get { return name; }
         //   set { name = value; }
        //}

        //public int Age
        //{
        //    get { return age; }
         //   set { age = value; }
       // }
        //public int Salary
       // {
        //    get { return salary; }
        //    set { salary = value; }
       // }

       // Worker1 worker1 = new Worker1();
       // worker1.Name = "John";
        //    worker1.Age = 25;
         //   worker1.Salary = 1000;
         //   Worker1 worker2 = new Worker1();
      //  worker2.Name = "Sam";
        //    worker2.Age = 26;
           // worker2.Salary = 2000;
          //  int age_sum = (worker1.Age + worker2.Age);
     //   Console.WriteLine($"AgesWorker1 sum is equal to {age_sum}");
       
            public void setName(string value)
        {
            name = value;
        }

        public string getName()
        {
            return name;
        }

        public void setAge(int value)
        {
            age = value;
        }

        public int getAge()
        {
            return age;
        }
        public void setSalary(int value)
        {
            salary = value;
        }

        public int getSalary()
        {
            return salary;
        }

        public void Workers1SalarySum(List<Worker1> workers1)
        {
            int salarySum = 0;

            foreach (var item in workers1)
            {
                salarySum += item.salary;
            }
            Console.WriteLine($"Salaries sum is equal to {salarySum}");
        }
        public void Workers1AgeSum(List<Worker1> workers1)
        {
            int ageSum = 0;
            foreach (var item in workers1)
            {
                ageSum += item.age;
            }
            Console.WriteLine($"Ages sum is equal to {ageSum}");
        }
    }
    }
 
            
