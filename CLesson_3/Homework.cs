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

            int midlength0m1 = matrix1.GetLength(0) / 2;
            int midlength1m1 = matrix1.GetLength(1) / 2;

            if (matrix1.GetLength(0) % 2 != 0 || matrix1.GetLength(1) % 2 != 0)
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
            int midlength0m2 = matrix2.GetLength(0) / 2;
            int midlength1m2 = matrix2.GetLength(1) / 2;

            if (matrix2.GetLength(0) % 2 == 0 || matrix2.GetLength(1) % 2 == 0)
            {
                Console.WriteLine("The central element is " + matrix2[midlength0m2, midlength1m2]);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a central element");
            }
        
        }

                public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
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
                }
                public void SortList(IList<int> listOfNumbers)
                {
                    //Print to console elements of  listOfNumbers in ascending order
                    //your code here
                }
              
                

            }
}
