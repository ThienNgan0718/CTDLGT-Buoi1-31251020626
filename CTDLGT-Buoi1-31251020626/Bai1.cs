
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
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

        long tong = (long)a + b + c;
        double trungBinh = tong / 3.0;

        Console.WriteLine($"Lon nhat: {max}");
        Console.WriteLine($"Nho nhat: {min}");
        Console.WriteLine($"Tong: {tong}");
        Console.WriteLine($"Trung binh: {trungBinh:F2}");
    }
}
