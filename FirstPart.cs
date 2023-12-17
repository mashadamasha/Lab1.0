using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class FirstPart
    {
        public static int MinAbs(int[] vector)
        {
            var min = Math.Abs(vector[0]);
            for (int i = 0; i < vector.Length; i++)
            {
                if (Math.Abs(vector[i]) < min)
                {
                    min = Math.Abs(vector[i]);
                }
            }
            return min;
        }
        public static int? AbsSum(int[] vector)
        {
            int? sum = null;

            int? zeroIndex = null;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == 0)
                {
                    zeroIndex = i;
                    break;
                }
            }

            if (zeroIndex.HasValue)
            {
                sum = 0;
                for (int i = zeroIndex.Value; i < vector.Length; i++)
                {
                    sum += Math.Abs(vector[i]);
                }
            }

            return sum;
        }
        public static int[] Renovate(int[] vector)
        {
            int n = vector.Length;
            var temp = new int[n];
            int k = 0;
            int j = 1;
            var stop = 0;
            for (int i = 0; i < temp.Length / 2 + 1; i++)
            {
                temp[i] = vector[k];
                k += 2;
                if (k > n - 1)
                {
                    stop = i + 1;
                    break;
                }

            }
            for (int i = stop; i < temp.Length; i++)
            {
                temp[i] = vector[j];
                j += 2;
            }
            for (int i = 0; i < temp.Length; i++)
            {
                vector[i] = temp[i];
           
            }
            return vector;

        }
    }
}
