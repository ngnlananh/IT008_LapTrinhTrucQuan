using System;

class cThangNam
{
    private int iMonth;
    private int iYear;

    //Hàm khởi tạo
    public cThangNam(int iMonth = 0, int iYear = 0)
    {
        this.iMonth = iMonth;
        this.iYear = iYear;
    }

    //Nhập tháng năm từ bàn phím
    public void Nhap()
    {
        Console.Write("Nhap thang:");
        iMonth = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam:");
        iYear = int.Parse(Console.ReadLine());
    }

    //Xuất tháng năm
    public void Xuat()
    {
        Console.Write("{0}/{1}/{2}", iMonth, iYear);
    }

    //Kiểm tra năm nhuận
    public bool IsNamNhuan()
    {
        if (iYear % 400 == 0 || (iYear % 4 == 0 && iYear % 100 != 0))
            return true;
        return false;
    }

    //Trả về số ngày tối đa trong tháng
    public int SoNgayTrongThang()
    {
        int[] DaysofMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (iMonth == 2 && this.IsNamNhuan())
            return 29;
        return DaysofMonth[iMonth - 1];
    }
}

class Program
{
    public static void Main()
    {
        cThangNam ThangNam = new cThangNam();

        //Nhập tháng năm 
        Console.WriteLine("Nhap thang nam: ");
        ThangNam.Nhap();

        //Xuất kết quả số ngày trong tháng
        Console.Write("So ngay cua thang ");
        ThangNam.Xuat();
        Console.WriteLine(" la: " + ThangNam.SoNgayTrongThang());
    }
}