namespace BTH2_NguyenNgocLanAnh_24520109
{
    class Bai01
    {
        public static void Run()
        {
            cThangNam a = new cThangNam();
            a.Nhap();
            Console.Write("\t\tLich cua thang ");
            a.Xuat();
            Console.Write(": ");
            Console.WriteLine();
            a.printCalendar();
        }
    }
}