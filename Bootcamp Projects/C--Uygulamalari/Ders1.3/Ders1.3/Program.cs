using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1._3
{
    class Program
    {
        public static void yıldızyaz(int a)
        {
            int sayac = a - 1;  //boşkuk basmak için.
            for(int k=1;k<a;k++)
            {
                for(int i=1;i<=sayac;i++)
                    Console.Write(" ");
                sayac--;
                for (int i = 1; i <= 2 * k - 1; i++)  //boşluk karakter basmak için gerekli döngü.
                    Console.Write("*");
                Console.WriteLine();
            }
            sayac = 1;
            for(int k=1;k<=a-1;k++)
            {
                for (int i = 1; i <= sayac; i++)
                    Console.Write(" ");
                sayac++;
                for (int i = 1; i <= 2 * (a - k) - 1; i++)  //yıldız basmak için.
                    Console.Write("*");
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            yıldızyaz(10);
            Console.ReadLine();
        }
    }
}
