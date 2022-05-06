using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{
    public class Student:User
    {
        private string _scholarship;
        private string _course;

        public Student(string name, int age, string scholarship, string course):base(name)
        {
            this.name = name;
            this.age = age;
            _scholarship = scholarship;
            _course = course;
        }

        public void PrintScholarshipCourse()
        {
            Console.WriteLine($"{name} won {_scholarship} scholarship and will be enrolled in {_course} course");
        }
    }
}
