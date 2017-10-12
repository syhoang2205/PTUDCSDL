using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap04
{
    public class ChuNhat
    {
        private double cd;
        private double cr;

        public ChuNhat()
        {
            this.cd = 0;
            this.cr = 0;
        }
        public ChuNhat(double a,double b)
        {
            this.cd = a;
            this.cr = b;
        }
        public ChuNhat(ChuNhat a)
        {
            this.cd = a.cd;
            this.cr = a.cr;
        }

        public void inputChuNhat()
        {
            kiemTraCD:
            Console.Write("Chieu dai: ");
            try
            {
                this.cd = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                goto kiemTraCD;
            }

            kiemTraCR:
            Console.Write("Chieu rong: ");
            try
            {
                this.cr = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                goto kiemTraCR;
            }
        }
        public void displayChuNhat()
        {
            Console.WriteLine("Hinh Chu Nhat Co: ");
            Console.WriteLine("Chieu dai = {0}", this.cd);
            Console.WriteLine("Chieu rong = {0}", this.cr);
        }
        public double tinhChuVi()
        {
            double P = 2 * (this.cd + this.cr);
            return P;
        }
        public double tinhDienTich()
        {
            double S = this.cd * this.cr;
            return S;
        }
        //public bool kiemTraHopLe()
        //{
        //    if (this.cd > this.cr)
        //    {
                
        //    }
        //    else
        //    {

        //    }
        //}
    }
}
