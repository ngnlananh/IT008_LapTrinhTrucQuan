namespace BTH2_NguyenNgocLanAnh_24520109
{
    internal class cKhuDat
    {
        protected string DiaDiem;
        protected double GiaBan;
        protected double DienTich;

        //Phương thức khởi tạo 
        public cKhuDat(string dd = "khong co", double gia = 0, double dt = 0)
        {
            DiaDiem = dd;
            GiaBan = gia;
            DienTich = dt;
        }

        //Phương thức nhập
        public virtual void Nhap()
        {
            Console.Write("Nhap dia diem: ");
            DiaDiem = Console.ReadLine();
            while(true)
            {
                Console.Write("Nhap gia ban: ");
                if (!double.TryParse(Console.ReadLine(), out GiaBan) || GiaBan < 0)
                {
                    Console.WriteLine("Gia ban khong hop le. Vui long nhap lai gia ban >= 0.");
                    continue;
                }
                else
                    break;
            }

            while (true)
            {
                Console.Write("Nhap dien tich: ");
                if (!double.TryParse(Console.ReadLine(), out DienTich) || DienTich < 0)
                {
                    Console.WriteLine("Dien tich khong hop le. Vui long nhap lai dien tich >= 0.");
                    continue;
                }
                else
                    break;
            }
        }

        //Phương thức xuất 
        public virtual void Xuat()
        {
            Console.Write("Dia diem: " + DiaDiem + "\t");
            Console.Write("Gia ban: " + GiaBan + "\t");
            Console.Write("Dien tich: " + DienTich + "\t");
        }

        //Phương thức trả về loại giao dịch, để phân biệt với các giao dịch khác
        public int LoaiGiaoDich() { return 0; }
        
        //Phương thức lấy giá bán của khu đất
        public double getGiaBan() { return GiaBan; }

        //Phương thức lấy giá trị của diện tích khu đất 
        public double getDienTich() { return DienTich; }

        //Phương thức lấy giá trị của địa điểm của khu đất 
        public string getDiaDiem() { return DiaDiem; }
    }
}
