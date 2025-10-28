using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_NguyenNgocLanAnh_24520109
{
    internal class cChungCu : cKhuDat
    {
        private int iTang;

        public cChungCu(int t = 0) { iTang = t; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap tang cua chung cu: ");
            iTang = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write("Tang: " + iTang + "\t");
        }

        public int LoaiGiaoDich() { return 2; }
    }
}
