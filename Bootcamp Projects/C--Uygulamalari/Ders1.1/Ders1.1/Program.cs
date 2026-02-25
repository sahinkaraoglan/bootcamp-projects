using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1._1
{
    class Program
    {
        public static int topla(int a)
        {
            return a;
        }
        public static int topla(int a, int b)
        {
            return a + b;
        }
        public static void selamver(string a)
        {
            Console.WriteLine("merhaba" + " " + a);
        }

        public static double faktoriyel(int a)
        {
            double sonuc = 1;
            for (int i = 1; i <= a; i++)
                sonuc = sonuc * i;
            return sonuc;
        }

        public static double recursivefaktoriyel(int a)
        {
            if (a == 0 || a == 1) return 1;
            else
                return                                           //bir yordamın içinde başka bir yordam çalıştırılabilir sebebi STATİC olması.
                    a * recursivefaktoriyel(a - 1);
        }

            static void Main(string[] args)
            {
           int sonuc= topla(5, 8);
            Console.WriteLine(sonuc);
            Console.WriteLine(topla(5, 8));

            selamver("şahin");

            Console.WriteLine(faktoriyel(5));

            Console.WriteLine(recursivefaktoriyel(7));


            Console.ReadLine();
            }
        
    }
}
