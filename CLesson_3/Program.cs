using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLesson_3;

namespace Homework
{
    class Program
    {
        public static void Main(String[] args)
        {
            Homework homework = new Homework();
            Generic_Collections generic_Collections = new Generic_Collections();
            Stack<int> stack = new Stack<int>();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix1 = new int[3, 3] { { 1, 3, 5 }, { -1, 100, 11 }, { 2, 15, 44 } };
            int[,] matrix2 = new int[3, 4] { { 1, 6, 21, 8 }, { 5, -4, 5, 7 }, { 77, 5, 0, 74 } };
            int triangleHight = 10;
            var orderedList = list.OrderBy(num => num).ToList();
            
            
            homework.GetCentralElementFromMatrix1(matrix1);
            homework.GetCentralElementFromMatrix2(matrix2);
            homework.GetSummOfDiagonalsElements1(matrix1);
            homework.GetSummOfDiagonalsElements2(matrix2);
            homework.StarPrinter(triangleHight);
            homework.SortList(orderedList);
            Console.WriteLine();
            generic_Collections.AddElementsStack();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
