namespace BTH2_NguyenNgocLanAnh_24520109
{
    class Bai04
    {
        static cPhanSo NhapPhanSo()
        {
            //Nhập tử số
            int iTu, iMau;
            while (true)
            {
                Console.Write("Nhap tu so: ");
                if (!int.TryParse(Console.ReadLine(), out iTu))
                {
                    Console.WriteLine("Vui long nhap lai tu so la so nguyen!");
                    continue;
                }
                else
                    break;
            }

            //Nhập mẫu số
            while (true)
            {
                Console.Write("Nhap mau so: ");
                if (!int.TryParse(Console.ReadLine(), out iMau) || iMau == 0)
                {
                    Console.WriteLine("Vui long nhap lai mau so la so nguyen (khac 0) !");
                    continue;
                }
                else
                    break;
            }
            return new cPhanSo(iTu, iMau);
        }
        public static void Run()
        {

            //nhập vào hai phân số, xuất ra các giá trị là tổng, hiệu, tích và thương của hai phân số này
            
            Console.WriteLine("Nhap phan so A:");
            cPhanSo a = NhapPhanSo();
            Console.WriteLine("Nhap phan so B:");
            cPhanSo b = NhapPhanSo();

            Console.WriteLine("Cac gia tri tong, hieu, tich thuong cua hai phan so tren: ");
            Console.WriteLine("Tong: {0}", a + b);
            Console.WriteLine("Hieu: {0}", a - b);
            Console.WriteLine("Tich: {0}", a * b);
            Console.WriteLine("Thuong: {0}", a / b);

            // nhập vào một dãy các phân sô
            int n;
            while (true)
            {
                Console.Write("Nhap so luong phan so: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    break;
                else
                {
                    Console.Write("Vui long nhap lai so nguyen > 0.");
                    continue;
                }
            }
            
            List<cPhanSo> list = new List<cPhanSo>(n);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan so thu {0}: ", i + 1);
                list.Add(NhapPhanSo());
            }

            //Tìm phân số lớn nhất
            cPhanSo maxPS = list[0];
            for(int i = 0; i < list.Count(); i++)
            {
                if (list[i].SoSanh(maxPS) > 0)
                    maxPS = list[i];
            }
            Console.WriteLine("Phan so lon nhat trong day la: " + maxPS);

            //Sắp xếp các phân số trong dãy tăng dần
            list.Sort();
            Console.WriteLine("Day phan so sau khi sap xep tang dan: ");
            foreach(var item in list)
            {
                Console.WriteLine(item + "\t");
            }
        }
    }
}