using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap02
{
    public class DiemOxy
    {
        private int x;
        private int y;

        public DiemOxy()
        {
            this.x = 0;
            this.y = 0;
        }
        public DiemOxy(int a,int b)
        {
            this.x = a;
            this.y = b;
        }
        public DiemOxy(DiemOxy a)
        {
            this.x = a.x;
            this.y = a.y;
        }

        public void inputDiem()
        {
            kiemTraX:
            Console.Write("x = ");
            try
            {
                this.x = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                goto kiemTraX;
            }

            kiemTraY:
            Console.Write("y = ");
            try
            {
                this.y = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                goto kiemTraY;
            }
        }
        public void displayDiem()
        {
            Console.WriteLine("({0},{1})", this.x, this.y);
        }
        public double tinhKhoangCach(DiemOxy A)
        {
            double kc1, kc2, kc;
            kc1 = Math.Pow(this.x - A.x, 2);
            kc2 = Math.Pow(this.y - A.y, 2);
            kc = 1.0 * Math.Sqrt(kc1 + kc2);
            return kc;
        }
        public void kiemTraThuocPhanTu()
        {
            if (this.x > 0 && this.y > 0)
            {
                Console.WriteLine("Diem ({0},{1}) thuoc phan tu thu 1", this.x, this.y);
            }
            else if (this.x < 0 && this.y > 0)
            {
                Console.WriteLine("Diem ({0},{1}) thuoc phan tu thu 2", this.x, this.y);
            }
            else if (this.x < 0 && this.y < 0)
            {
                Console.WriteLine("Diem ({0},{1}) thuoc phan tu thu 3", this.x, this.y);
            }
            else
            {
                Console.WriteLine("Diem ({0},{1}) thuoc phan tu thu 4", this.x, this.y);   
            }
        }
    }
}
