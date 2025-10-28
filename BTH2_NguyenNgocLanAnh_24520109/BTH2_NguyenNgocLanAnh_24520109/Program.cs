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
                Console.WriteLine("----MENU----");
                Console.WriteLine("1. Bai 01");
                Console.WriteLine("2. Bai 02");
                Console.WriteLine("3. Bai 03");
                Console.WriteLine("4. Bai 04");
                Console.WriteLine("5. Bai 05");
                Console.WriteLine("0. Ket thuc chuong trinh");
                Console.Write("Nhap lua chon: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lua chon khong hop le!");
                    choice = -1;
                    continue;
                }

                //Xử lý lựa chọn
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