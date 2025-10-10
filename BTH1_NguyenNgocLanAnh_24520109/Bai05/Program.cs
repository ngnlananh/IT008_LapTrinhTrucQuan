using System;
class Program
{
    public static void Main()
    {
        int d, m, y;
        do
        {
            Console.Write("Nhap ngay: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thang: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            y = Convert.ToInt32(Console.ReadLine());
            if (!Check_HopLe(d, m, y))
                Console.WriteLine("Ngay khong hop le, vui long nhap lai!");
        } while (!Check_HopLe(d, m, y));
        
        int thu = DayofWeek(d, m, y);
        if (thu == -1)
            Console.WriteLine("Nam khong hop le");
        else
        {
            Console.WriteLine("---Ngay {0}/{1}/{2} la:", d, m, y);
            switch (thu)
            {
                case 0: Console.Write("Thu bay"); break;
                case 1: Console.Write("Chu nhat"); break;
                case 2: Console.Write("Thu hai"); break;
                case 3: Console.Write("Thu ba"); break;
                case 4: Console.Write("Thu tu"); break;
                case 5: Console.Write("Thu nam"); break;
                case 6: Console.Write("Thu sau"); break;
            }
        }
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
    public static bool Check_HopLe(int day, int month, int year) 
    {
        if (year < 1 || month < 1 || month > 12)
            return false;
        int daysInMonth = SoNgayTrongThang(month, year);
        return (day >= 1 && day <= daysInMonth);
    }
    public static int DayofWeek (int day, int month, int year)
    {
        // ap dung cong thuc Zeller
        int y = year;
        int m = month;
        if (m == 1 || m == 2) { m += 12; y--; }

        int q = day;
        int K = y % 100; //so nam trong the ky
        int J = y / 100; // the ky

        int h = (q + (13 * (m + 1)) / 5 + K + (K / 4) + (J / 4) + 5 * J) % 7;
        return h;
    }
}