using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap01
{
    public class PhanSo
    {
        private double tu;
        private double mau;

        public PhanSo()
        {
            this.tu = 0;
            this.mau = 1;
        }
        public PhanSo(double a,double b)
        {
            this.tu = a;
            if(b != 0)
            {
                this.mau = b;
            }
        }
        public PhanSo(PhanSo a)
        {
            this.tu = a.tu;
            this.mau = a.mau;
        }

        public void inputPS()
        {
            kiemTraTu:
            Console.Write("Tu = ");
            try
            {
                this.tu = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                goto kiemTraTu;
            }

            kiemTraMau:
            Console.Write("Mau = ");
            try
            {
                this.mau = Double.Parse(Console.ReadLine());
                bool check = kiemTraPS();
                
                if(!check)
                {
                    Console.WriteLine("Mau so phai khac 0");
                    goto kiemTraMau;
                }

            }
            catch
            {
                Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                goto kiemTraMau;
            }
        }

        public void displayPS()
        {
            PhanSo ps = new PhanSo();
            ps = rutGonPS();
            if(ps.mau < 0)
            {
                ps.mau *= -1.0;
                ps.tu *= -1.0;
            }
            if(ps.mau == 1)
            {
                Console.WriteLine("PS = {0}", ps.tu);
            }
            else
            {
                Console.WriteLine("PS = {0}/{1}", ps.tu, ps.mau);
            }
            
        }
        public double tinhGiaTri()
        {
            double value = 1.0 * this.tu / this.mau;
            return value;
        }
        public bool kiemTraPS()
        {
            if (this.mau == 0)
            {
                return false;
            }
            return true;
        }
        public double timUCLN(double a,double b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
        public PhanSo rutGonPS()
        {
            PhanSo ps = new PhanSo();
            double UCLN = timUCLN(this.tu, this.mau);
            if( UCLN != 0)
            {
                ps.tu = this.tu / UCLN;
                ps.mau = this.mau / UCLN;
            }
            else
            {
                ps.tu = this.tu;
                ps.mau = this.mau;
            }
            return ps;
        }
        public PhanSo Tong(PhanSo n)
        {
            PhanSo psTong = new PhanSo();
            if (this.mau == n.mau)
            {
                psTong.tu = this.tu + n.tu;
                psTong.mau = n.mau;
            }
            else
            {
                psTong.tu = this.tu * n.mau + this.mau * n.tu;
                psTong.mau = this.mau * n.mau;
            }
            return psTong;
        }
        public PhanSo Hieu(PhanSo n)
        {
            PhanSo psHieu = new PhanSo();
            if (this.mau == n.mau)
            {
                psHieu.tu = this.tu - n.tu;
                psHieu.mau = n.mau;
            }
            else
            {
                psHieu.tu = this.tu * n.mau - this.mau * n.tu;
                psHieu.mau = this.mau * n.mau;
            }
            return psHieu;
        }
        public PhanSo Tich(PhanSo n)
        {
            PhanSo psTich = new PhanSo();
            psTich.tu = this.tu * n.tu;
            psTich.mau = this.mau * n.mau;
            return psTich;
        }
    }
}
