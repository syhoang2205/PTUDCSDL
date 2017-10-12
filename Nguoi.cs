using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap05
{
    public class Nguoi
    {
        private string name;
        private Ngay bd;
        private string id;
        private string addr;

        public Nguoi()
        {
            this.name = "Le Sy Hoang";
            this.bd = new Ngay();
            this.id = "025114939";
            this.addr = "72/4 Trung Chanh, Hoc Mon, Sai Gon";
        }
        public Nguoi(string name, Ngay bd, string id, string addr)
        {
            this.name = name;
            this.bd = bd;
            this.id = id;
            this.addr = addr;
        }
        public Nguoi(Nguoi a)
        {
            this.name = a.name;
            this.bd = a.bd;
            this.id = a.id;
            this.addr = a.addr;
        }

        public void input()
        {
            Console.Write("Ho Ten: ");
            this.name = Console.ReadLine();

            Console.WriteLine("Ngay Sinh: ");
            this.bd.inputNgay();
            
            Console.Write("CMND: ");
            this.id = Console.ReadLine();

            Console.Write("Dia Chi: ");
            this.addr = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Ho Ten: {0}", this.name);
            Console.Write("Ngay Sinh: ");
            this.bd.displayNgay();
            Console.WriteLine("CMND: {0}", this.id);
            Console.WriteLine("Dia Chi: {0}", this.addr);
        }
        public int tinhAge()
        {
            int age;
            age = DateTime.Now.Year - this.bd.NAM;
            return age;
        }
    }
}
