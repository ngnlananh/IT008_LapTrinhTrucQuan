namespace BTH2_NguyenNgocLanAnh_24520109
{
    class Bai01
    {
        public static void Run()
        {
            cThangNam a = new cThangNam();
            a.Nhap();
            Console.WriteLine("\t\tLich cua thang {0} nam {1}: ", a.getMonth(), a.getYear());
            a.printCalendar();
        }
    }
}