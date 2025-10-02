using System;
class Date
{
    private int day;
    private int month;
    private int year;

    public Date(int d, int m, int y)
    {
        day = d; month = m; year = y;
    }
    public Date()
    {
        day = DateTime.Now.Day;
        month = DateTime.Now.Month;
        year = DateTime.Now.Year;
    }
    bool Check_NamNhuan()
    {
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            return true;
        return false;
    }
    public bool CheckDate()
    {
        if (year < 1) return false;
        if (month < 1 || month > 12) return false;
        int[] Days_of_month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (Check_NamNhuan()) 
            Days_of_month[1] = 29;

        if (day < 1 || day > Days_of_month[month - 1])
            return false;
        return true;
    }
    public void NhapDate()
    {
        Console.Write("Nhap ngay: ");
        day = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang: ");
        month = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam: ");
        year = int.Parse(Console.ReadLine());
    }
}

class Program
{
    public static void Main()
    {
        Date a = new Date();
        a.NhapDate();
        if (a.CheckDate())
            Console.WriteLine("Ngay thang nam hop le");
        else
            Console.WriteLine("Ngay thang nam khong hop le");
    }
}