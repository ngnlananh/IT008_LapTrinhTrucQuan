using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Write("Nhap gia ban: ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dien tich khu dat: ");
            DienTich = double.Parse(Console.ReadLine());
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
