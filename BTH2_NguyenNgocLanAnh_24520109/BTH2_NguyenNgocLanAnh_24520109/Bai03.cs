namespace BTH2_NguyenNgocLanAnh_24520109
{
    class Bai03
    {
        public static void Run()
        {
            int choice;
            string tmp;
            bool flag = false;
            do
            {
                if (flag == false)
                    Console.WriteLine("Vui long nhap so nguyen duong tu 1 den 5!!!!");
                Console.WriteLine("===MENU BAI 3===");
                Console.WriteLine("1. Nhap ma tran hai chieu.");
                Console.WriteLine("2. Xuat ma tran hai chieu");
                Console.WriteLine("3. Tim kiem phan tu trong ma tran");
                Console.WriteLine("4. Xuat cac so nguyen to trong ma tran");
                Console.WriteLine("5. Cho biet dong nao co nhieu so nguyen nhat");
                Console.WriteLine("0. Ket thuc BAI 3");

                Console.WriteLine("Nhap lua chon:");
                tmp = Console.ReadLine();
                flag = false;

            } while (!int.TryParse(tmp, out choice) || choice < 0 || choice > 5);

            cMaTran a = new cMaTran();
            a.NhapMaTran();
            a.XuatMaTran();
        }
    }
}