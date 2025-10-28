using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_NguyenNgocLanAnh_24520109
{
    internal class cPhanSo : IComparable<cPhanSo>
    {
        private int iTu;
        private int iMau;

        //Hàm khởi tạo
        public cPhanSo(int tu = 0, int mau = 1)
        {
            iTu = tu; iMau = mau;
            RutGon();
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        private void RutGon()
        {
            int ucln = UCLN(Math.Abs(iTu), Math.Abs(iMau));
            iTu /= ucln;
            iMau /= ucln;

            if (iMau < 0)
            {
                iTu = -iTu;
                iMau = -iMau;
            }
        }

        public static implicit operator cPhanSo(int x)
        {
            return new cPhanSo(x, 1);
        }

        //Operator công hai phân số
        public static cPhanSo operator +(cPhanSo a, cPhanSo b)
        {
            return new cPhanSo(a.iTu * b.iMau + b.iTu * a.iMau, a.iMau * b.iMau);
        }

        //Operator trừ hai phân số
        public static cPhanSo operator -(cPhanSo a, cPhanSo b)
        {
            return new cPhanSo(a.iTu * b.iMau - b.iTu * a.iMau, a.iMau * b.iMau);
        }

        //Operator nhân hai phân số 
        public static cPhanSo operator *(cPhanSo a, cPhanSo b)
        {
            return new cPhanSo(a.iTu * b.iTu, a.iMau * b.iMau);
        }

        //Operator chia hai phân số
        public static cPhanSo operator /(cPhanSo a, cPhanSo b)
        {
            if (b.iTu == 0)
                throw new DivideByZeroException("Khong the chia cho 0");
            return new cPhanSo(a.iTu * b.iMau, a.iMau * b.iTu);
        }

        //So sánh hai phân số
        public int SoSanh (cPhanSo x)
        {
            double a = (double)this.iTu / this.iMau;
            double b = (double)x.iTu / x.iMau;
            return a.CompareTo(b);
        }

        public int CompareTo(cPhanSo? other)
        {
            if (other == null) return 1;
            return SoSanh(other);
        }

        public override string ToString()
        {
            if (iMau == 1) 
                return iTu.ToString();
            return $"{iTu}/{iMau}";
        }
    }
}
