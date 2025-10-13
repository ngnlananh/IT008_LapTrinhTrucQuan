using System;

public class Program
{
    // Hàm kiểm tra số nguyên tố
    static bool LaSoNguyenTo(int x)
    {
        if (x < 2) return false;
        for (int i = 2; i * i <= x; i++)
            if (x % i == 0) return false;
        return true;
    }
    // Hàm tính tổng các số nguyên tố < n
    static long TongNguyenTo(int n)
    {
        long sum = 0;
        for (int i = 2; i < n; i++)
        {
            if (LaSoNguyenTo(i))
                sum += i;
        }
        return sum;
    }
    public static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Tong cac so nguyen to < n la: " + TongNguyenTo(n));
    }
}
