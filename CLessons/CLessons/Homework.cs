using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLessons_1
{
    public class Homework
    {
        public Homework() 
        {

        }

        public Homework(int val)
        {
            MyProperty = val;
        }
        public int MyProperty { get; set; }

        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | even                                 |
          * |--------|--------------------------------------|
          * |  2     | odd                                  |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater then zero|
          * -------------------------------------------------
          * 
          */
            //your code here
            if (number < 0)
            {
                Console.WriteLine("the value should be greater then zero");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine(number + " is even");
            }
            else
            {
                Console.WriteLine(number + " is odd");
            }
        }

        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that print if number divide to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divide to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
            //your code here
            var result = (number % 4 == 0) ? number + " divides to 4" : number + " doesn't divide to 4";
            Console.WriteLine(result);
            DayOfWeek("");
            //var tt = MyProperty;
            //MyProperty = 123;
        }

        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */

            switch (day)
            {
                //your code here

                case "Monday":
                    Console.WriteLine("1");
                    break;
                case "Tuesday":
                    Console.WriteLine("2");
                    break;
                case "Wednesday":
                    Console.WriteLine("3");
                    break;
                case "Thursday":
                    Console.WriteLine("4");
                    break;
                case "Friday":
                    Console.WriteLine("5");
                    break;
                case "Saturday":
                    Console.WriteLine("6");
                    break;
                case "Sunday":
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("Wrong value! Please give a day of a week");
                    break;
            }
        }

        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            //your code here
            string vowels = "aeuioyAEUIOY";
      
            string consonant = "qwrtplkjhgfdszxcvbnmQWRTPLKJHGFDSZXCVBNM";
          
            switch (true)
            {
                case bool resultVowels when vowels.Contains(character):
                    Console.WriteLine(character + " is a vowel");
                    break;
                case bool resultConsonant when consonant.Contains(character):
                    Console.WriteLine(character + " is a consonant");
                    break;
                default:
                    Console.WriteLine(character + " is not a letter");
                    break;





            }
        }

        public void CheckLetterIfVowelContains(char character)
        {
            string vowels = "aeuioyAEUIOY";
            bool resultvowels = vowels.Contains(character);

            string consonant = "qwrtplkjhgfdszxcvbnmQWRTPLKJHGFDSZXCVBNM";
            bool resultconsonant = consonant.Contains(character);

            if (resultvowels)
            {
                Console.WriteLine(character + " is a vowel");
            }
            else if (resultconsonant)
            {
                Console.WriteLine(character + " is a consonant");
            }
            else
            {
                Console.WriteLine(character + " is not a letter");
            }
        }
    }
}
