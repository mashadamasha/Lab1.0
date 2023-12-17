using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class SecondPart
    {
        public static int CountLocMin(int[,] matrix)
        {
            int count = 0;
            for (int i = 1; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i, j] < matrix[i - 1, j] &&
                        matrix[i, j] < matrix[i + 1, j] &&
                        matrix[i, j] < matrix[i, j - 1] &&
                        matrix[i, j] < matrix[i, j + 1])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static int SumMainDiag(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = i+1; j < matrix.GetLength(1); j++)
                {
                    sum += Math.Abs(matrix[i, j]);

                }
            }
            return sum;
        }
    }
}
