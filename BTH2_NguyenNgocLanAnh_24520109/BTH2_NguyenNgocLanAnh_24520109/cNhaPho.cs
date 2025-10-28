namespace BTH2_NguyenNgocLanAnh_24520109
{
    internal class cNhaPho : cKhuDat
    {
        private int iSoTang;
        private int iNamXayDung;

        public cNhaPho(int t = 0, int nam = 0)
        {
            iSoTang = t;
            iNamXayDung = nam;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap nam xay dung cua nha pho: ");
            iNamXayDung = int.Parse(Console.ReadLine());
            Console.Write("Nhap so tang cua nha pho: ");
            iSoTang = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write("Nam xay dung: " + iNamXayDung + "\t");
            Console.Write("So tang: " + iSoTang + "\t");
        }

        public int LoaiGiaoDich() { return 1; }

        public int getNamXayDung() { return iNamXayDung; }
    }
}
