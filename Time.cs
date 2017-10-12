using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap07
{
    public class Time
    {
        private int hour;
        private int min;
        private int sec;

        public int Hour { get => hour; set => hour = value; }

        public Time()
        {
            this.hour = 0;
            this.min = 0;
            this.sec = 0;
        }
        public Time(int h, int m, int s)
        {
            this.hour = h;
            this.min = m;
            this.sec = s;
        }
        public Time(Time A)
        {
            this.hour = A.hour;
            this.min = A.min;
            this.sec = A.sec;
        }

        public void inputTime()
        {
            bool checkTime;
            do
            {
                kiemTraGio:
                Console.Write("Gio: ");
                try
                {
                    this.hour = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                    goto kiemTraGio;
                }

                kiemTraPhut:
                Console.Write("Phut: ");
                try
                {
                    this.min = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                    goto kiemTraPhut;
                }

                kiemTraGiay:
                Console.Write("Giay: ");
                try
                {
                    this.sec = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Du lieu Sai hoac thieu. Xin kiem tra lai.");
                    goto kiemTraGiay;
                }
                checkTime = this.kiemTraHopLe();
                if(!checkTime)
                {
                    Console.WriteLine("Gio hoac Phut hoac Giay khong hop le. Xin kiem tra lai");
                }
            } while (!checkTime);


        }
        public void displayTime()
        {
            Console.WriteLine("{0}:{1}:{2}", this.hour, this.min, this.sec);
        }

        public bool kiemTraHopLe()
        {
            bool check = false;
            if (this.hour >= 0 && this.hour <= 23)
            {
                check = true;
            }
            if (this.min >= 0 && this.min <= 60)
            {
                check = true;
            }
            if (this.sec >= 0 && this.sec <= 60)
            {
                check = true;
            }
            return check;
        }

        public void doiGioPhut(int s)
        {
            int hour, P, min, sec;
            hour = s / (60 * 60);
            P = s % (60 * 60);
            min = P / 60;
            sec = s % 60;
            Console.WriteLine("{0} Giay = {1} Gio {2} Phut {3} Giay", s, hour, min, sec);
        }
        public double tinhKhoangCachHaiGio(Time A)
        {
            double kq = 0; ;
            for (int i = A.hour; i < this.hour; i++)
            {
                kq += 60;
            }
            return kq;
        }
    }
}
