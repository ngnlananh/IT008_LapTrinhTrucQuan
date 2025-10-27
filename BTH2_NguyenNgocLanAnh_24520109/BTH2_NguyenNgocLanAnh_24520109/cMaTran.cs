using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_NguyenNgocLanAnh_24520109
{
    internal class cMaTran
    {
        private int iCol;
        private int iRow;
        private int[,] iMatran;

        //Hàm khởi tạo
        public cMaTran(int c = 0, int r = 0)
        {
            iCol = c;
            iRow = r;
            iMatran = new int[iRow, iCol];
        }

        public void NhapMaTran()
        {
            int tmp_c, tmp_r;
            bool flag = false;
            string tmp;

            //Nhập số cột của ma trận
            do
            {
                if (flag)
                    Console.WriteLine("Vui long nhap so cot hop le (>0) !!!!");

                Console.Write("Nhap so cot cua ma tran: ");
                tmp = Console.ReadLine();
                flag = true;

            } while (!int.TryParse(tmp, out tmp_c) || tmp_c < 0); //Chỉ chấp nhận khi là số nguyên > 0

            //Nhập số dòng của ma trận
            tmp = "\0";
            flag = false;
            do
            {
                if (flag)
                    Console.WriteLine("Vui long nhap so dong hop le (>0) !!!!");

                Console.Write("Nhap so dong cua ma tran: ");
                tmp = Console.ReadLine();
                flag = true;
            } while (!int.TryParse(tmp, out tmp_r) || tmp_r < 0);

            iCol = tmp_c;
            iRow = tmp_r;

            //Nhập các phần tử của ma trận
            Console.WriteLine("Vui long nhap lan luot cac phan tu trong ma tran.");
            for (int i = 0; i < iRow; i++)
            {
                for (int j = 0; j < iCol; j++)
                {
                    flag = false;
                    string temp;
                    int n;
                    do
                    {
                        if (flag)
                            Console.WriteLine("Vui long nhap lai so nguyen!");
                        Console.WriteLine("Nhap gia tri phan tu matrix[{0}][{1}]: ", i + 1, j + 1);
                        temp = Console.ReadLine();
                        flag = true;
                    } while (!int.TryParse(tmp, out n));
                }
            }
        }

        public void XuatMaTran()
        {
            Console.WriteLine("Ma tran: ");
            for(int i = 0; i < iRow; i++)
            {
                for (int j = 0; j < iCol; j++)
                    Console.Write(iMatran[i, j] + ' ');
                Console.WriteLine();
            }
        }
    }
}
