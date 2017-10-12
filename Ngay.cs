using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap05
{
    public class Ngay
    {
        private int ngay, thang, nam;

        public int NAM { get => nam; set => nam = value; }

        public Ngay()
        {
            this.ngay = 1;
            this.thang = 1;
            this.nam = 1;
        }
        public Ngay(int d, int m, int y)
        {
            this.ngay = d;
            this.thang = m;
            this.nam = y;
        }
        public Ngay(Ngay a)
        {
            this.ngay = a.ngay;
            this.thang = a.thang;
            this.nam = a.nam;
        }

        public void inputNgay()
        {
            bool check;
            do
            {
                kiemTraNgay:
                Console.Write("Ngay: ");
                try
                {
                    this.ngay = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                    goto kiemTraNgay;
                }

                kiemTraThang:
                Console.Write("Thang: ");
                try
                {
                    this.thang = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                    goto kiemTraThang;
                }

                kiemTraNam:
                Console.Write("Nam: ");
                try
                {
                    int now = DateTime.Now.Year;
                    this.nam = int.Parse(Console.ReadLine());
                    if (this.nam < 1900 || this.nam > now)
                    {
                        Console.WriteLine("Nam khong hop le. Nam phai lon hon 1900 va nho hon nam hien tai");
                        goto kiemTraNam;
                    }
                }
                catch
                {
                    Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                    goto kiemTraNam;
                }
                check = this.kiemTraHopLe();
                if(!check)
                {
                    Console.WriteLine("Ngay hoac Thang hoac Nam khong hop le. Xin kiem tra lai.");
                }
            } while (!check);
           
        }
        public void displayNgay()
        {
            Console.WriteLine("{0}/{1}/{2}", this.ngay, this.thang, this.nam);
        }

        public bool kiemTraHopLe()
        {
            if (this.thang == 1 || this.thang == 3 || this.thang == 5 || this.thang == 7 || this.thang == 8 || this.thang == 10 || this.thang == 12)
            {
                if (this.ngay >= 1 && this.ngay <= 31)
                {
                    return true;
                }
            }
            if (this.thang == 4 || this.thang == 6 || this.thang == 9 || this.thang == 11)
            {
                if (this.ngay >= 1 && this.ngay <= 30)
                {
                    return true;
                }
            }
            if (this.thang == 2)
            {
                bool check = this.kiemTraNamNhuan();
                if (check)
                {
                    if (this.ngay >= 1 && this.ngay <= 29)
                    {
                        return true;
                    }
                }
                else
                {
                    if (this.ngay >= 1 && this.ngay <= 28)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool kiemTraNamNhuan()
        {
            if (this.nam % 4 == 0 && this.nam % 100 != 0 || this.nam % 400 == 0)
            {
                return true;
            }
            return false;
        }
        public double tinhKhoangCachHaiNgay(Ngay A)
        {
            double kq = 0;
            if (A.nam != this.nam)
            {
                Ngay C = A;
                for (int i = A.nam; i < this.nam; i++)
                {
                    bool checkNam = C.kiemTraNamNhuan();
                    if (checkNam)
                    {
                        kq += 366 * 24 * 60;
                    }
                    else
                    { 
                        kq += 365 * 24 * 60;
                    }
                    C.nam++;
                }
            }
            if (A.thang != this.thang)
            {
                for (int i = A.thang; i < this.thang; i++)
                {
                    if (i== 1 || i == 3 || i == 5 || i== 7 || i == 8 || i == 10 || i == 12)
                        kq += 31 * 24 * 60;
                    if (i == 4 || i == 6 || i == 9 || i == 11)
                        kq += 30 * 24 * 60;
                    if (i == 2)
                    {
                        bool checkThang = this.kiemTraNamNhuan();
                        if (checkThang)
                        {
                            kq += 29 * 24 * 60;
                        }
                        else
                        {
                            kq += 28 * 24 * 60;
                        }
                    }
                }
            }
            if (A.ngay != this.ngay)
            {
                for (int i = A.ngay; i < this.ngay; i++)
                {
                    kq += 24 * 60;
                }
            }
            return kq;
        }
    }
}