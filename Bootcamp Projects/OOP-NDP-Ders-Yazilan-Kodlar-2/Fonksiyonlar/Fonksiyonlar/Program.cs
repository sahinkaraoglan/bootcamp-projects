using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonksiyonlar
{
    class Program
    {
        static double kuvvet5(double x)
        {
            double x5 = x * x * x * x * x;
            return x5;
        }
        //kombinasyon hesabı
        static int fakt(int s)
        {
            int fk = 1;
            for (int i = 1; i <= s; i++)
                fk *= i;
            return fk;
        }
        static void Main(string[] args)
        {
            double p5 = kuvvet5(1.5);
            Console.WriteLine("{0}",p5);
            Console.WriteLine("******************************************");


            int n = 5, r=3;
            int comb = fakt(n) / (fakt(n - r) * fakt(r));
            Console.WriteLine("C({0},{1})={2}", n, r, comb);
            Console.ReadLine();
        }
    }
}
