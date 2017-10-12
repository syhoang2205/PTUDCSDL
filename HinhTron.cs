using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap03
{
    public class HinhTron
    {
        private DiemOxy i;
        private double R;

        public HinhTron()
        {
            this.i = new DiemOxy();
            this.R = 0;
        }
        public HinhTron(DiemOxy a, double c)
        {
            this.i = new DiemOxy(a);
            this.R = c;
        }
        public HinhTron(HinhTron a)
        {
            this.i = a.i;
            this.R = a.R;
        }

        public void inputHinhTron()
        {
            Console.WriteLine("Tam I: ");
            this.i.inputDiem();
            kiemTraR:
            Console.Write("Ban Kinh R: ");
            try
            {
                this.R = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                goto kiemTraR;
            }
            
        }
        public void displayHinhTron()
        {
            Console.Write("Tam I = ");
            this.i.displayDiem();
            Console.WriteLine("BK R = {0}", this.R);
        }
        public double tinhDienTich()
        {
            double S;
            S = Math.Pow(this.R, 2) * Math.PI;
            return S;
        }
        public double tinhChuVi()
        {
            double P;
            P = this.R * 2 * Math.PI;
            return P;
        }
        public bool kiemTraHopLe()
        {
            double a = Math.Sqrt(this.i.X * this.i.X + this.i.Y * this.i.Y - this.R * this.R);
            if (this.R == a)
            {
                return true;
            }
            return false;
        }
    }
}
