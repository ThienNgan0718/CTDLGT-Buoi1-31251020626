using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi1_31251020626
{
    internal class Bai3
    {
        static long SolveA(int[] a)
        {
            long maxSum = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                long sum = 0;

                for (int j = i; j < a.Length; j++)
                {
                    sum += a[j];

                    if (sum > maxSum)
                        maxSum = sum;
                }
            }

            return maxSum;
        }

        static long SolveB(int[] a)
        {
            long currentSum = a[0];
            long maxSum = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                currentSum = Math.Max(
                    a[i],
                    currentSum + a[i]
                );

                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }

    }
}
