using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace uyg_2
{
    class Program
    {
        static void Topla()
        {
            for(int i=1;i<1000000000;i++)
            {

            }
            Console.WriteLine("deneme için yazılmıştır. ");
        }
        static void worker()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("işlem "+i);
                //sleep iş parcaçığını milisaniye cinsinden bekletir.
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            //Topla();
            //Console.WriteLine("main içersindeyim");

            Thread myThread = new Thread(worker);
            myThread.Start();
            Thread.Sleep(1500);
            Console.WriteLine("benim işim burada bitti");
            Console.ReadKey();
        }
    }
}
