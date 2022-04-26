using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLessons_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Home work");

            var homework = new Homework(12);

            homework.CheckIfNumberIsEvenOrOdd(4);
            homework.CheckIfNumberIsEvenOrOdd(7);

            homework.CheckLetterIfVowelContains('8');


            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);
            //---------------------------------------
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);
            //---------------------------------------
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("some day");
            //---------------------------------------
            homework.CheckLetterIfVowel('p');
            homework.CheckLetterIfVowel('i');

            homework.CheckLetterIfVowelContains('p');
            homework.CheckLetterIfVowelContains('i');

            Console.ReadKey();
        }
    }
}
