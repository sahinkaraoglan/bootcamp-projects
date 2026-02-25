using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] renkler = new string[] { "yeşil", "beyaz", "kırmızı", "mavi", "sarı", "turkuaz", "gri" };
            //for(int i=0;i<renkler.Length;i++)
            //    Console.WriteLine(renkler[i]);

            //Console.WriteLine("*********************************************");


            //Array.Sort(renkler);
            //foreach(string item in renkler)
            //    Console.WriteLine(item);

            //Console.WriteLine("*********************************************");

            //Array.Reverse(renkler);
            //foreach (string item in renkler)
            //    Console.WriteLine(item);
            //Console.WriteLine("*********************************************");

            int[] yas = new int[] { 11, 24, 36, 42, 57, 29, 76, 61, 34, 45, 38 };
            Array.Sort(yas);
            for(int i=0;i<yas.Length;i++)
                Console.WriteLine(yas[i]);
            Console.WriteLine("************************************");

            int max = 0;
            for(int i=0;i<yas.Length;i++)
            {
                if (yas[i] > max)
                    max = yas[i];
            }
            Console.WriteLine("max eleman: "+max);




            Console.ReadLine();
        }
    }
}
