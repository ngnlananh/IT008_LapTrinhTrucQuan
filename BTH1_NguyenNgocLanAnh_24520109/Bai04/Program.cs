using System;
class Program
{
    public static void Main()
    {
        int m, y;

        //Nhập tháng bằng vòng lặp do ... while 
        do
        {
            Console.Write("Nhap thang: ");
            m = int.Parse(Console.ReadLine());
            if (m < 1 || m > 12)
                Console.WriteLine("Thang khong hop le. Vui long nhap lai!");
        } while (m < 1 || m > 12);

        //Nhập năm bằng vòng lặp do ... while 
        do
        {
            Console.Write("Nhap nam: ");
            y = int.Parse(Console.ReadLine());
            if (y<0) 
                Console.WriteLine("Nam khong hop le. Vui long nhap lai!");
        } while (y < 0);

        Console.WriteLine("So ngay trong thang {0} la: {1} ngay", m, SoNgayTrongThang(m, y));
    }

    //Kiểm tra năm nhuận
    static bool Check_NamNhuan(int year)
    {
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            return true;
        return false;
    }

    //Trả về số ngày tối đa trong tháng
    static int SoNgayTrongThang(int m, int y)
    {
        int[] DaysofMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (m == 2 && Check_NamNhuan(y))
            return 29;
        return DaysofMonth[m - 1];
    }
}