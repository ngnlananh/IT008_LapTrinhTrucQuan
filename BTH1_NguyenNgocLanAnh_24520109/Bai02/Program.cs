using System;

public class Program
{
    static int Tong_n(int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
            sum += i;
        return sum;
    }
    public static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Tong cac so nguyen to < n la: " + Tong_n(n));
    }
}