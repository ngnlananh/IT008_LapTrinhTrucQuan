using System;
using System.Net.NetworkInformation;

class cThoiGian
{
    private int iDay;
    private int iMonth;
    private int iYear;

    //Hàm khởi tạo
    public cThoiGian(int iDay = 0, int iMonth = 0, int iYear = 0)
    {
        this.iDay = iDay;
        this.iMonth = iMonth;
        this.iYear = iYear;
    }

    //Nhập ngày tháng năm từ bàn phím
    public void Nhap()
    {
        Console.Write("Nhập ngày:");
        iDay = int.Parse(Console.ReadLine());
        Console.Write("Nhập tháng:");
        iMonth = int.Parse(Console.ReadLine());
        Console.Write("Nhập năm:");
        iYear = int.Parse(Console.ReadLine());
    }

    //Xuất ngày tháng năm
    public void Xuat()
    {
        Console.Write("Ngày tháng năm vừa nhập là: ");
        Console.WriteLine("{0}/{1}/{2}", iDay, iMonth, iYear);
    }
    
    //Kiểm tra năm nhuận
    public bool IsNamNhuan(int year)
    {
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            return true;
        return false;
    }

    //Kiểm tra tính hợp lệ của ngày tháng năm
    public bool IsHopLe()
    {
        if (iYear < 0 || iMonth < 1 || iMonth > 12 || iDay < 1)
            return false;
        int[] DaysofMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (iMonth == 2 && IsNamNhuan(iYear))
            DaysofMonth[1] = 29;
        if (DaysofMonth[iMonth - 1] < iDay)
            return false;
        return true;
    }
}

class Program
{
    static void Main()
    {
        //Nhập ngày tháng năm từ bàn phím
        cThoiGian date = new cThoiGian();
        Console.WriteLine("Nhập ngày tháng năm:");
        date.Nhap();

        //Xuất ngày tháng năm vừa nhập
        date.Xuat();

        //Xuất kết quả kiểm tra ngày tháng năm hợp lệ
        if (date.IsHopLe() == true)
            Console.WriteLine("Ngày tháng năm hợp lệ.");
        else Console.WriteLine("Ngày tháng năm không hợp lệ.");
    }
}