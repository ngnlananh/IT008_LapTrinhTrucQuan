using System;

public class Program
{
    //tính tổng các số nguyên tố < n
    static int Tong_n(int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
            sum += i;
        return sum;
    }
    public static void Main()
    {
        //Nhập số nguyên n 
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        //Xuất kết quả 
        Console.WriteLine("Tong cac so nguyen to < n la: " + Tong_n(n));
    }
}