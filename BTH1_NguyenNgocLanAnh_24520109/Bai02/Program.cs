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
        string s;
        int temp;
        int n;
        bool flag = false;
        // Nhập sô nguyên dương n
        do
        {
            if (flag == true)
                Console.WriteLine("Vui long nhap so nguyen duong!!!");
            Console.Write("Nhap so nguyen duong n: ");
            s = Console.ReadLine();
            flag = true;
        }
        while (!int.TryParse(s, out temp) || temp <= 0); // chỉ chấp nhận số nguyên dương
        n = temp;
        Console.WriteLine("Tong cac so nguyen to < n la: " + TongNguyenTo(n));
    }
}
