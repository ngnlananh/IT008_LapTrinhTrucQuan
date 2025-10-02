using System;
class Program
{
    public static void Main()
    {
        Console.Write("Nhap thang: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("So ngay trong thang {0} la: {1} ngay", 
            m, SoNgayTrongThang(m, y));
    }
    static bool Check_NamNhuan(int year)
    {
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            return true;
        return false;
    }
    static int SoNgayTrongThang(int m, int y)
    {
        int[] DaysofMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (m == 2 && Check_NamNhuan(y))
            return 29;
        return DaysofMonth[m - 1];
    }
}