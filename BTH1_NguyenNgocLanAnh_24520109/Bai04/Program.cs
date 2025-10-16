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

    //Hàm kiểm thử nhập tháng
    private int NhapThang(string message)
    {
        int temp;
        bool flag = false;
        do
        {
            if (flag)
                Console.WriteLine("Vui long nhap thang hop le [1-12] !!!!");

            Console.Write(message);
            string s = Console.ReadLine();
            flag = true;

            // Chỉ chấp nhận khi là số nguyên trong khoảng 1-12
            if (int.TryParse(s, out temp) && temp >= 1 && temp <= 12)
                return temp;

        } while (true);
    }

    //Hàm kiểm thử nhập năm 
    private int NhapNam(string message)
    {
        int temp;
        bool flag = false;

        do
        {
            if (flag)
                Console.WriteLine("Vui long nhap nam hop le (>0)!!!!");

            Console.Write(message);
            string s = Console.ReadLine();
            flag = true;

            if (int.TryParse(s, out temp) && temp > 0)
                return temp;

        } while (true);
    }

    //Nhập tháng năm từ bàn phím
    public void Nhap()
    {
        iMonth = NhapThang("Nhap thang: ");
        iYear = NhapNam("Nhap nam: ");
    }

    //Xuất tháng năm
    public void Xuat()
    {
        Console.Write("{0}/{1}", iMonth, iYear);
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