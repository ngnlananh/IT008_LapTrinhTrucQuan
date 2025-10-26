using System.Xml.Serialization;

namespace BTH2_NguyenNgocLanAnh_24520109
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                int n; //biến tạm lưu giá trị nhập vào để kiểm thử
                string tmp;
                bool flag = true; //đặt cờ báo hiệu lần nhập thứ nhất 
                do
                {
                    if (flag == false)
                        Console.WriteLine("Vui long nhap so nguyen duong tu 1 den 5!!!!");
                    Console.WriteLine("----MENU----");
                    Console.WriteLine("1. Bai 01");
                    Console.WriteLine("2. Bai 02");
                    Console.WriteLine("3. Bai 03");
                    Console.WriteLine("4. Bai 04");
                    Console.WriteLine("5. Bai 05");
                    Console.WriteLine("0. Ket thuc chuong trinh");

                    Console.WriteLine("Nhap lua chon:");
                    tmp = Console.ReadLine();
                    flag = false;
                } while (!int.TryParse(tmp, out n) || n > 5 || n < 0); //chỉ nhận giá trị 0 - 5 cho num 

                choice = n;
                switch (choice)
                {
                    case 1: Bai01.Run(); break;
                    case 2: Bai02.Run(); break;
                    case 3: Bai03.Run(); break;
                    case 4: Bai04.Run(); break;
                    case 5: Bai05.Run(); break;
                    case 0:
                        Console.WriteLine("=====Ket thuc chuong trinh=====");
                        return;
                }
            } while (choice != 0);
        }
    }
}