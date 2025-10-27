namespace BTH2_NguyenNgocLanAnh_24520109
{
    class Bai03
    {
        public static void Run()
        {
            cMaTran a = new cMaTran();
            int choice;
            do
            {
                Console.WriteLine("===MENU BAI 3===");
                Console.WriteLine("1. Nhap ma tran hai chieu.");
                Console.WriteLine("2. Xuat ma tran hai chieu");
                Console.WriteLine("3. Tim kiem phan tu trong ma tran");
                Console.WriteLine("4. Xuat cac so nguyen to trong ma tran");
                Console.WriteLine("5. Cho biet dong nao co nhieu so nguyen nhat");
                Console.WriteLine("0. Ket thuc BAI 3");
                Console.WriteLine("Nhap lua chon:");
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 5)
                {
                    Console.WriteLine("Vui long nhap lai so hop le [0 - 5]!");
                    continue;
                }

                //Xử lý lựa chọn
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Ket thuc bai 3");
                        return;
                    case 1: 
                        a.NhapMaTran();
                        break;
                    case 2:
                        a.XuatMaTran();
                        break;
                }
            } while (choice != 0);
        }
    }
}