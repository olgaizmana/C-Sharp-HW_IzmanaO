using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    public class Matrix
    {
        public int[,] CreateFirstMatrix()
        {
           int[,] matrix1 = new int[3, 3] { { 1, 3, 5 }, { -1, 100, 11 }, { 2, 15, 44 } }; ;
            return matrix1;
        }

        public int[,] CreateSecondMatrix()
        {
            int[,] matrix2 = new int[3, 4] { { 1, 6, 21, 8 }, { 5, -4, 5, 7 }, { 77, 5, 0, 74 } };
            return matrix2;
        }
    }
}
