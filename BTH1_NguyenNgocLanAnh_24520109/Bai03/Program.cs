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

    //Hàm kiểm thử nhập số nguyên
    private int NhapSoNguyen(string message)
    {
        int temp;
        bool flag = false;
        do
        {
            if (flag)
                Console.WriteLine("Vui long nhap so nguyen!!!!");

            Console.Write(message);
            string s = Console.ReadLine();
            flag = true;

            // Chỉ chấp nhận khi là số nguyên
            if (int.TryParse(s, out temp))
                return temp;

        } while (true);
    }

    //Nhập ngày tháng năm từ bàn phím
    public void Nhap()
    {

        iDay = NhapSoNguyen("Nhap ngay: ");
        iMonth = NhapSoNguyen("Nhap thang: ");
        iYear = NhapSoNguyen("Nhap nam: ");
    }

    //Xuất ngày tháng năm
    public void Xuat()
    {
        Console.Write("Ngay thang nam vua nhap la: ");
        Console.WriteLine("{0}/{1}/{2}", iDay, iMonth, iYear);
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
}

class Program
{
    static void Main()
    {
        //Nhập ngày tháng năm từ bàn phím
        cNgayThangNam date = new cNgayThangNam();
        Console.WriteLine("Nhap ngay thang nam:");
        date.Nhap();

        //Xuất ngày tháng năm vừa nhập
        date.Xuat();

        //Xuất kết quả kiểm tra ngày tháng năm hợp lệ
        if (date.IsHopLe() == true)
            Console.WriteLine("Ngay thang nam hop le.");
        else Console.WriteLine("Ngay thang nam khong hop le.");
    }
}