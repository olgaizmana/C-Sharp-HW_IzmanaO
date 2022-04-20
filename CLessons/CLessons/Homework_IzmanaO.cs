using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLessons
{
    public class Homework
    {
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
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
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
            var result = (number % 4 == 0) ? "The number divides to 4" : "The number doesn't divide to 4";
            Console.WriteLine(result);
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

                case "monday":
                    Console.WriteLine("1");
                    break;
                case "tuesday":
                    Console.WriteLine("2");
                    break;
                case "wednesday":
                    Console.WriteLine("3");
                    break;
                case "thursday":
                    Console.WriteLine("4");
                    break;
                case "friday":
                    Console.WriteLine("5");
                    break;
                case "saturday":
                    Console.WriteLine("6");
                    break;
                case "sunday":
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("Wrong value! Please give a day of a week");
                    break;
            }
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
        switch (character)
        {
            case 'a':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'i':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'o':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'u':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'e':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'y':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'b':
                Console.WriteLine(character + "is not a letter");
                break;
            case 'c':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'd':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'f':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'g':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'h':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'j':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'k':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'l':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'm':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'n':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'p':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'q':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'r':
                Console.WriteLine(character + "is a consonant");
                break;
            case 's':
                Console.WriteLine(character + "is a consonant");
                break;
            case 't':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'v':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'w':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'z':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'x':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'A':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'I':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'O':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'U':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'E':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'Y':
                Console.WriteLine(character + "is a vowel");
                break;
            case 'B':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'C':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'D':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'F':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'G':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'H':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'J':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'K':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'L':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'M':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'N':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'P':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'Q':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'R':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'S':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'T':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'V':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'W':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'Z':
                Console.WriteLine(character + "is a consonant");
                break;
            case 'X':
                Console.WriteLine(character + "is a consonant");
                break;
            default:
                Console.WriteLine(character + "is not a letter");
                break;
        }
        static void CheckLetterIfVowel(char character)
        {
            string vowels = "aeuioy";
            string consonant = "qwrtplkjhgfdszxcvbnm";
            char value = character;
            Boolean resultvowels = vowels.Contains(character);
            Boolean resultconsonant = consonant.Contains(character);
            {
                if (resultvowels = true) ;
                {
                    Console.WriteLine(character + "is a vowel");
                }
            else if (resultconsonant = true) ;
                {
                    Console.WriteLine(character + "is a consonant");
                }
            else
                {
                    Console.WriteLine(character + "is not a letter");
                }
            }
        }



        Homework homework = new Homework();

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
    }
}

