using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonksiyonlar
{
    class Program
    {
        static void ucgen()   //değer döndürmeyen ve parametreesi olmayan bir fonksiyondur.
        {
            Console.WriteLine("*");
            Console.WriteLine("***");
            Console.WriteLine("*****");
            Console.WriteLine("*******");
            Console.WriteLine("**********");
        }


        static void kuvvetal(double x)      //değer döndürmeyen ama bir tane parametresi olan bir fonksiyon.
        {
            double x2 = x * x;
            double x6 = x * x * x * x * x * x;

            Console.WriteLine("x=F{0:F6}",x);
            Console.WriteLine("x^2=F{0:F6}", x2);
            Console.WriteLine("x^6=F{0:F6}", x6);
        }


        static int fakt (int s)
        {
            int fk = 1;
            for (int i = 1; i <= s; i++)
                fk *= i;
            return fk;

        }


        static void Main(string[] args)
        {
            ucgen();
            ucgen();           //fonksiyonlar istenildiği kadar çağrılabilir.
            ucgen();

            Console.WriteLine("------------------------------------------------------");
            kuvvetal(2.5);
            Console.WriteLine("************");
            kuvvetal(3.1);
            Console.WriteLine("*******************************************");


            //FONKSİYON KULLANARAK KOMBİNASYON HESABI

            int n = 5, r = 3;
            int comb = fakt(n) / fakt(n - r) * fakt(r);
            Console.WriteLine("C({0},{1})={2}", n, r, comb);

            Console.ReadLine();
        }
    }
}
