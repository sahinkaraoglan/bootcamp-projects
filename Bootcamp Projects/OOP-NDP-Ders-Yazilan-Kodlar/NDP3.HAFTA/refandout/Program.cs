using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refandout
{
    class Program
    {
        ////ref anahtar kelimesi değer tipinden önce kullanılmalı.
        //static void kareal(ref double d)
        //{
        //    d = d * d;
        //}

        static int Max(int x,int y,out bool b)
        {
            if (x > y)
                b = true;
            else
                b = false;
            return Math.Max(x, y);
        }
        static void Main(string[] args)
        {
            //double i = 3.45;
            //Console.WriteLine("double sayi: {0}",i);
            //kareal(ref i);   //ref parametresini içren metot çağrılıyor.
            //Console.WriteLine("karesi: {0}",i);
            //Console.ReadLine();

            //Console.WriteLine("**************************************************************");

            bool b;
            int max = Max(9, 2, out b);
            Console.WriteLine(b);

            Console.ReadLine();






        }
    }
}
