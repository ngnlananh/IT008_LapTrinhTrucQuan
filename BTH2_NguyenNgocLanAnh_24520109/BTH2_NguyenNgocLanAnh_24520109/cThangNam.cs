namespace BTH2_NguyenNgocLanAnh_24520109
{
    internal class cThangNam
    {
        private int iMonth;
        private int iYear;

        //Hàm khởi tạo
        public cThangNam(int iMonth = 0, int iYear = 0)
        {
            this.iMonth = iMonth;
            this.iYear = iYear;
        }

        public int getMonth() { return iMonth; }
        public int getYear() { return iYear; }

        //Hàm kiểm thử nhập tháng
        private int NhapThang(string message)
        {
            int temp;
            bool flag = false;
            do
            {
                if (flag)
                    Console.WriteLine("Vui long nhap thang hop le [1-12] !!!!");

                Console.Write(message);
                string s = Console.ReadLine();
                flag = true;

                // Chỉ chấp nhận khi là số nguyên trong khoảng 1-12
                if (int.TryParse(s, out temp) && temp >= 1 && temp <= 12)
                    return temp;

            } while (true);
        }

        //Hàm kiểm thử nhập năm 
        private int NhapNam(string message)
        {
            int temp;
            bool flag = false;

            do
            {
                if (flag)
                    Console.WriteLine("Vui long nhap nam hop le (>0)!!!!");

                Console.Write(message);
                string s = Console.ReadLine();
                flag = true;

                if (int.TryParse(s, out temp) && temp > 0)
                    return temp;

            } while (true);
        }

        //Nhập tháng năm từ bàn phím
        public void Nhap()
        {
            iMonth = NhapThang("Nhap thang: ");
            iYear = NhapNam("Nhap nam: ");
        }

        //Xuất tháng năm
        public void Xuat()
        {
            Console.Write("{0}/{1}", iMonth, iYear);
        }

        //Kiểm tra năm nhuận
        public bool IsNamNhuan()
        {
            if (iYear % 400 == 0 || (iYear % 4 == 0 && iYear % 100 != 0))
                return true;
            return false;
        }

        //Trả về số ngày tối đa trong tháng
        public int SoNgayTrongThang()
        {
            int[] DaysofMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (iMonth == 2 && this.IsNamNhuan())
                return 29;
            return DaysofMonth[iMonth - 1];
        }

        public void printCalendar()
        {
            // Xác định ngày đầu tiên trong tháng 
            DateTime firstDay = new DateTime(iYear, iMonth, 1);
            int startDay = (int)firstDay.DayOfWeek; // 0 = Chủ Nhật, 1 = Thứ 2, ...

            int num_day = SoNgayTrongThang();

            Console.WriteLine(" Sun |Mon |Tue |Web |Thu |Fri |Sat");

            //In khoảng trống trước ngày đầu tiên
            for (int i = 0; i < startDay; i++)
                Console.Write("     ");

            for (int day = 1; day <= num_day; day++)
            {
                Console.Write("{0,5}", day);
                if ((startDay + day) % 7 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
