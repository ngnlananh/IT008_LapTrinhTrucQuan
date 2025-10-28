namespace BTH2_NguyenNgocLanAnh_24520109
{
    class Bai05
    {
        static void NhapDanhSach(List<cKhuDat> ds, int n)
        {
            int i = 0;
            while(ds.Count() < n)
            {
                Console.WriteLine("Nhap giao dich thu " + (i + 1) + ": ");
                Console.Write("Chon loai giao dich: 1. Khu dat  2. Nha pho  3. Chung cu");
                if (!int.TryParse(Console.ReadLine(), out int loai))
                {
                    Console.WriteLine("Loai giao dich khong hop le. Vui long nhap lai.");
                    continue;
                }
                cKhuDat gd;
                switch (loai)
                {
                    case 1:
                        gd = new cKhuDat();
                        break;
                    case 2:
                        gd = new cNhaPho();
                        break;
                    case 3:
                        gd = new cChungCu();
                        break;
                    default:
                        Console.WriteLine("Loai giao dich khong hop le. Vui long nhap lai.");
                        continue;
                }
                gd.Nhap();
                ds.Add(gd);
                i++;
            }
        }

        static void XuatDanhSach(List<cKhuDat> ds)
        {
            Console.WriteLine("Danh sach giao dich: ");
            foreach(cKhuDat gd in ds)
            {
                gd.Xuat();
                Console.WriteLine();
            }
        }

        static double TinhTongGiaBan(List<cKhuDat> ds)
        {
            double tong = 0;
            foreach(cKhuDat gd in ds)
            {
                tong += gd.getGiaBan();
            }
            return tong;
        }

        static void XuatDSKhuDatVaNhaPho(List<cKhuDat> ds)
        {
            Console.WriteLine("Danh sach khu dat co dien tich > 100m2 hoac nha pho co dien tich > 60m2 va nam xay dung >= 2019: ");
            foreach(cKhuDat gd in ds)
            {
                if((gd.LoaiGiaoDich() == 0 && gd.getDienTich() > 100) ||
                   (gd.LoaiGiaoDich() == 1 && gd.getDienTich() > 60 && ((cNhaPho)gd).getNamXayDung() >= 2019))
                {
                    gd.Xuat();
                    Console.WriteLine();
                }
            }
        }

        static void TimKiemGiaoDichNhaPhoHoacChungCu(List<cKhuDat> ds)
        {
            Console.Write("Nhap dia diem can tim kiem: ");
            string diaDiemTimKiem = Console.ReadLine();
            Console.Write("Nhap gia ban toi da can tim kiem: ");
            double giaBanTimKiem = double.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich toi thieu can tim kiem: ");
            double dienTichTimKiem = double.Parse(Console.ReadLine());

            var ketQua = ds.Where(gd => (gd is cNhaPho || gd is cChungCu) 
            && gd.getDiaDiem().ToLower().Contains(diaDiemTimKiem.ToLower()) 
            && gd.getGiaBan() <= giaBanTimKiem 
            && gd.getDienTich() >= dienTichTimKiem);

            Console.WriteLine("Ket qua tim kiem: ");

            if (!ketQua.Any())
                Console.WriteLine("Khong tim thay giao dich nao phu hop.");
            else
                foreach (var gd in ketQua)
                {
                    gd.Xuat();
                    Console.WriteLine();
                }
            
        }

        public static void Run()
        {
            List<cKhuDat> ds = new List<cKhuDat>();
            int choice;
            do
            {
                Console.WriteLine("===MENU BAI 05===");
                Console.WriteLine("1. Nhap danh sach giao dich");
                Console.WriteLine("2. Xuat danh sach giao dich");
                Console.WriteLine("3. Tinh tong gia ban cua tat ca giao dich");
                Console.WriteLine("4. Xuat danh sach cac khu dat co dien tich > 100m2 hoac nha pho co dien tich  > 60m2 va nam xay dung >= 2019");
                Console.WriteLine("5. Tim kiem cac giao dich nha pho hoac chung cu");
                Console.WriteLine("0. Thoat");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    continue;
                }               

                switch (choice)
                {
                    case 1:
                        int num;
                        Console.Write("Nhap so luong giao dich: ");
                        num = int.Parse(Console.ReadLine());
                        NhapDanhSach(ds, num);
                        break;
                    case 2:
                        XuatDanhSach(ds);
                        break;
                    case 3:
                        Console.WriteLine("Tong gia ban cua tat ca giao dich: " + TinhTongGiaBan(ds));
                        break;
                    case 4:
                        XuatDSKhuDatVaNhaPho(ds);
                        break;
                    case 5:
                        TimKiemGiaoDichNhaPhoHoacChungCu(ds);
                        break;
                }
            } while (choice != 0);
            Console.WriteLine("===Ket thuc bai 05===");
        }
    }
}