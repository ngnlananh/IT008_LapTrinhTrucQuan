using System;

class cNgayThangNam
{
    private int iDay;
    private int iMonth;
    private int iYear;

    //Hàm khởi tạo
    public cNgayThangNam(int iDay = 0, int iMonth = 0, int iYear = 0)
    {
        this.iDay = iDay;
        this.iMonth = iMonth;
        this.iYear = iYear;
    }

    //Nhập ngày tháng năm từ bàn phím
    public void Nhap()
    {
        Console.Write("Nhap ngay:");
        iDay = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang:");
        iMonth = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam:");
        iYear = int.Parse(Console.ReadLine());
    }

    //Xuất ngày tháng năm
    public void Xuat()
    {
        Console.Write("{0}/{1}/{2}", iDay, iMonth, iYear);
    }

    //Kiểm tra năm nhuận
    public bool IsNamNhuan()
    {
        if (iYear % 400 == 0 || (iYear % 4 == 0 && iYear % 100 != 0))
            return true;
        return false;
    }

    //Kiểm tra tính hợp lệ của ngày tháng năm
    public bool IsHopLe()
    {
        if (iYear < 0 || iMonth < 1 || iMonth > 12 || iDay < 1)
            return false;
        int[] DaysofMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (iMonth == 2 && this.IsNamNhuan())
            DaysofMonth[1] = 29;
        if (DaysofMonth[iMonth - 1] < iDay)
            return false;
        return true;
    }

    //Tính thứ trong tuần theo công thức Zeller
    public int DayofWeek()
    {
        // ap dung cong thuc Zeller
        int y = this.iYear;
        int m = this.iMonth;
        if (m == 1 || m == 2) { m += 12; y--; }

        int q = this.iDay;
        int K = y % 100; //so nam trong the ky
        int J = y / 100; // the ky

        int h = (q + (13 * (m + 1)) / 5 + K + (K / 4) + (J / 4) + 5 * J) % 7;
        return h;
    }
}


class Program
{
    public static void Main()
    {
        cNgayThangNam date = new cNgayThangNam();

        do
        {
            Console.WriteLine("Nhap ngay thang nam: ");
            date.Nhap();
            if (date.IsHopLe() == false)
                Console.WriteLine("Ngay thang nam khong hop le, vui long nhap lai!!!");
        } while (date.IsHopLe() == false);

        int thu = date.DayofWeek();
        Console.Write("Ngay ");
        date.Xuat();
        Console.Write(" la: ");
        
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