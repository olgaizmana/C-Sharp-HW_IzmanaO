using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework
{
    public class Homework
    {
        int[,] matrix1 = new int[3, 3] { { 1, 3, 5 }, { -1, 100, 11 }, { 2, 15, 44 } };
        int[,] matrix2 = new int[3, 4] { { 1, 6, 21, 8 }, { 5, -4, 5, 7 }, { 77, 5, 0, 74 } };
        IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
        
        public void GetCentralElementFromMatrix1(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            //your code here

            int n = matrix1.GetLength(0);
            int m = matrix1.GetLength(1);
            int midlength0m1 = n / 2;
            int midlength1m1 = m / 2;
            

            if (matrix1.GetLength(1) % 2 != 0 && n == m)
                {
                    Console.WriteLine("The central element is " + matrix1[midlength0m1, midlength1m1]);
                }
                else
                {
                    Console.WriteLine("This matrix doesn't have a central element");
                }
            }
        
        public void GetCentralElementFromMatrix2(int[,] matrixOfIntegers)
        {
            int a = matrix2.GetLength(0);
            int b = matrix2.GetLength(1);
            int midlength0m2 = a / 2;
            int midlength1m2 = b / 2;
            

            if (matrix2.GetLength(1) % 2 != 0 && a == b)
            {
                Console.WriteLine("The central element is " + matrix2[midlength0m2, midlength1m2]);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a central element");
            }
        
    }

        public void GetSummOfDiagonalsElements1(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            //your code here

            int firstDiagonal = 0;
            int secondDiagonal = 0;
            int n = matrix1.GetLength(0);
            int m = matrix1.GetLength(1);

            if (m == n)
            {

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                            firstDiagonal += matrix1[i, j];
                        if ((i + j) == (n - 1))
                            secondDiagonal += matrix1[i, j];
                    }
                }
                Console.WriteLine("First diagonal: "
                                      + firstDiagonal);

                Console.WriteLine("Second diagonal: "
                                          + secondDiagonal);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a diagonals");
            }

        }
        public void GetSummOfDiagonalsElements2(int[,] matrixOfIntegers)
        {
            int firstDiagonal = 0;
            int secondDiagonal = 0;
            int a = matrix2.GetLength(0);
            int b = matrix2.GetLength(1);


            if (a == b)
            {

                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (i == j)
                            firstDiagonal += matrix2[i, j];
                        if ((i + j) == (a - 1))
                            secondDiagonal += matrix2[i, j];
                    }
                }
                Console.WriteLine("First diagonal: "
                                      + firstDiagonal);

                Console.WriteLine("Second diagonal: "
                                          + secondDiagonal);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a diagonals");
            }

        }
        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            //your code here
            int n = triangleHight;
            int i, j, k;

            for (i = 1; i <= n; i++)
            {

                Console.Write(" ");

                for (j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }

        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            //your code here
            var orderedList = list.OrderBy(num => num);
            
            foreach (int value in orderedList)
            {
                Console.Write(value + " ");
            }

        }
    }
}