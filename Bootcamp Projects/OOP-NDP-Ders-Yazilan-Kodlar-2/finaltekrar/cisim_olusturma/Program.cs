using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cisim_olusturma
{
    class Cisim
    {
        private int x;
        private int y;
        public Cisim()
        {
            x = 0;
            y = 0;
        }
        public Cisim(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
        public void Goster()
        {
            Console.WriteLine(x + " & " + y);
        }
        public static Cisim operator-(Cisim c)
        {
            Cisim temp = new Cisim();
            temp.x = -(Math.Abs(c.x));
            temp.y = -(Math.Abs(c.y));
            return temp;
        }
        public static Cisim operator+(Cisim c1,Cisim c2)
        {
            Cisim temp = new Cisim();
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c1.y;
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cisim c1 = new Cisim(10, 20);
            c1.Goster();
            Cisim c2 = new Cisim();
            c2.Goster();
            c2 = -c1;    //negatif alma işlemlerini yazdım.
            c2.Goster();
            Cisim c3 = new Cisim(15, 5);
            Cisim c4 = c2 + c3;
            c4.Goster();
            Console.ReadLine();
        }
    }
}
