using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi1_31251020626
{
    internal class Bai2
    {
        public static void Main(string[] args)
        {
            //Viết chương trình nhập ba số nguyên a, b và c. Chương trình xuất số lớn nhất, số nhỏ nhất, tổng và trung bình cộng của ba số.
            Console.Write("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c:");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;

            int min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;

            long tong = a + b + c;
            double Avg = tong / 3.0;
            Console.WriteLine($"Lon Nhat: {max}");
            Console.WriteLine($"Nho Nhat: {min}");
            Console.WriteLine($"Tong: {tong}");
            Console.WriteLine($"Trung binh: {Avg}");
        }
    }
}
