using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    public class FirstDiagonal
    {

        public int GetColumnsLength(int[,] matrixOfIntegers)
        {
            int n = matrixOfIntegers.GetLength(0);
            return n;
        }

        public int GetRowsLength(int[,] matrixOfIntegers)
        {
            int m = matrixOfIntegers.GetLength(1);
            return m;
        }
        public bool CheckLengthIfEqual(int[,] matrixOfIntegers)
        {

            return GetColumnsLength(matrixOfIntegers) == GetRowsLength(matrixOfIntegers);
        }

        public void GetFirstDiagonalSum(int[,] matrixOfIntegers)
        {
            int firstDiagonal = 0;
            if (CheckLengthIfEqual(matrixOfIntegers))
            {
                for (int i = 0; i < GetColumnsLength(matrixOfIntegers); i++)
                {
                    for (int j = 0; j < GetColumnsLength(matrixOfIntegers); j++)
                    {
                        if (i == j)
                        {
                            firstDiagonal += matrixOfIntegers[i, j];
                        }
                    }
                    

                }
                Console.WriteLine("First diagonal: "
                                    + firstDiagonal);
            }
            
            else
            {
                Console.WriteLine("This matrix doesn't have a diagonal");
            }

            


        }

    } 
}

    