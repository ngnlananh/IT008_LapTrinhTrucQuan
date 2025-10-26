namespace BTH2_NguyenNgocLanAnh_24520109
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; //biến tạm lưu giá trị nhập vào để kiểm thử
            string tmp;
            bool flag = true; //đặt cờ báo hiệu lần nhập thứ nhất 
            do
            {
                if (flag == false)
                    Console.WriteLine("Vui long nhap so nguyen duong tu 1 den 5!!!!");
                Console.WriteLine("Nhap so thu tu bai: (1,2,3,4,5)");
                tmp = Console.ReadLine();
                flag = false;
            } while (!int.TryParse(tmp, out n) || n > 5 || n < 1); //chỉ nhận giá trị 1 - 5 cho num 

            int num = n;
            switch (num)
            {
                case 1: Bai01.Run(); break;
                case 2: Bai02.Run(); break;
                case 3: Bai03.Run(); break;
                case 4: Bai04.Run(); break;
                case 5: Bai05.Run(); break;
            }
            Console.WriteLine("=====Ket thuc chuong trinh=====");
        }
    }
}