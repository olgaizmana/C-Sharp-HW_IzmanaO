

namespace C_Sharp_Lesson_3_Homework
{
    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
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
        public static void Main(String[] args)
        {
            Homework homework = new Homework();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(5);
            homework.SortList(list);
        }

    }
}
