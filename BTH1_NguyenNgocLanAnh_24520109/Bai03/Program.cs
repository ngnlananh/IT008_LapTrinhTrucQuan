using System;
class Program
{
    public static void Main()
    {
        Console.Write("Nhap ngay: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam: ");
        int y = int.Parse(Console.ReadLine());

        bool Check = Check_HopLe(d, m, y);
        if (Check)
            Console.WriteLine("Ngay thang nam hop le");
        else
            Console.WriteLine("Ngay thang nam khong hop le");
    }
    static bool Check_NamNhuan(int year)
    {
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            return true;
        return false;
    }
    static bool Check_HopLe(int d, int m, int y)
    {
        if (y < 0 || m < 1 || m > 12 || d < 1)
            return false;
        int[] DaysofMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (m == 2 && Check_NamNhuan(y))
            DaysofMonth[1] = 29;
        if (DaysofMonth[m - 1] < d)
            return false;
        return true;
    }
}