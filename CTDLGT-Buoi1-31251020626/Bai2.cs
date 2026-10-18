
using System;

class Bai2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        int max1 = 0, max2 = 0;
        bool coMax1 = false, coMax2 = false;

        for (int i = 0; i < n; i++)
        {
            int x = a[i];

            if (!coMax1 || x > max1)
            {
                if (coMax1)
                {
                    max2 = max1;
                    coMax2 = true;
                }

                max1 = x;
                coMax1 = true;
            }
            else if (x < max1 && (!coMax2 || x > max2))
            {
                max2 = x;
                coMax2 = true;
            }
        }

        if (coMax2)
        {
            Console.WriteLine(max1);
            Console.WriteLine(max2);
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
