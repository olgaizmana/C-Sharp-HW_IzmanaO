using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        public static void Main(String[] args)
        {
                    Homework homework = new Homework();
        IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
        int[,] matrix1 = new int[3, 3] { { 1, 3, 5 }, { -1, 100, 11 }, { 2, 15, 44 } };
        int[,] matrix2 = new int[3, 4] { { 1, 6, 21, 8 }, { 5, -4, 5, 7 }, { 77, 5, 0, 74 } };


                    homework.GetCentralElementFromMatrix1(matrix1);
                    homework.GetCentralElementFromMatrix2(matrix2);
                    homework.GetSummOfDiagonalsElements(matrix1);
                    homework.GetSummOfDiagonalsElements(matrix2);
                    homework.StarPrinter(5);
                    homework.SortList(list);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
