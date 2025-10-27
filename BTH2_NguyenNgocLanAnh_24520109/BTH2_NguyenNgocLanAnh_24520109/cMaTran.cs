using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

        private bool isPrime(int n) // Kiểm tra số nguyên tố  
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public void NhapMaTran()
        {
            //Nhập số dòng của ma trận
            while (true)
            {
                Console.Write("Nhap so dong cua ma tran: ");
                if (int.TryParse(Console.ReadLine(), out iRow) && iRow > 0)
                    break;
                Console.WriteLine("Vui long nhap so dong hop le (>0) !!!!");
            }

            // Nhập số cột của ma trận 
            while (true)
            {
                Console.Write("Nhap so cot cua ma tran: ");
                if (int.TryParse(Console.ReadLine(), out iCol) && iCol > 0)
                    break;
                Console.WriteLine("Vui long nhap so cot hop le (>0) !!!!");
            }

            iMatran = new int[iRow, iCol];

            //Nhập các phần tử của ma trận
            Console.WriteLine("Vui long nhap lan luot cac phan tu trong ma tran.");
            for (int i = 0; i < iRow; i++)
            {
                for (int j = 0; j < iCol; j++)
                {
                    while(true)
                    {
                        Console.Write("Nhap phan tu matrix[{0}][{1}]: ", i, j);
                        if (int.TryParse(Console.ReadLine(), out iMatran[i, j]))
                            break;
                        else
                        {
                            Console.Write("Vui long nhap lai phan tu matrix[{0}][{1}]. ", i, j);
                            continue;
                        }
                    }
                }
            }
        }

        public void XuatMaTran()
        {
            Console.WriteLine("Ma tran: ");
            for(int i = 0; i < iRow; i++)
            {
                for (int j = 0; j < iCol; j++)
                    Console.Write(iMatran[i, j] + "\t");
                Console.WriteLine();
            }
        }

        public bool TimPhanTu(int n)
        {
            bool flag = false;
            for(int i = 0; i < iRow; i++)
            {
                for (int j = 0; j < iCol; j++)
                {
                    if (iMatran[i, j] == n)
                    {
                        flag = true;
                        Console.WriteLine("Phan tu {0} la phan tu tai vi tri [{1}][{2}], tuc la dong {3} cot {4}.", n, i, j, i + 1, j + 1);
                    }
                }
            }
            if (!flag)
                Console.WriteLine("Khong tim thay phan tu {0} trong ma tran!", n);
            return flag;
        }

        public bool CoSNT()
        {
            for (int i = 0; i < iRow; i++)
            {
                for (int j = 0; j < iCol; j++)
                    if (isPrime(iMatran[i, j]))
                        return true;
            }
            return false;
        }

        public void XuatSNT()
        {
            if (!CoSNT())
                return;
            List<int> result = new List<int>();
            for (int i = 0; i < iRow; i++)
            {
                for(int j = 0; j < iCol; j++)
                    if (isPrime(iMatran[i, j]))
                            result.Add(iMatran[i, j]);
            }
            if (result.Count > 0)
            {
                Console.Write("Cac so nguyen to trong ma tran la: ");
                foreach (var item in result)
                    Console.Write(item + "\t");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Khong ton tai so nguyen to trong ma tran.");
        }

        public int DongNhieuSNT()
        {
            if (!CoSNT())
            {
                Console.WriteLine("Khong ton tai so nguyen to trong ma tran.");
                return -1;
            }
            int result = -1; //Dòng có nhiều số nguyên tố nhất
            int maxCount = 0;
            for (int i = 0; i < iRow; i++)
            {
                int countRow = 0;
                for (int j = 0; j < iCol; j++)
                    if (isPrime(iMatran[i, j]))
                        countRow++;
                if (countRow > maxCount)
                {
                    maxCount = countRow;
                    result = i;
                }
            }
            Console.WriteLine("Dong {0} co nhieu so nguyen to nhat trong ma tran.", result + 1);
            return result;
        }
    }
}
