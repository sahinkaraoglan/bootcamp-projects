using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp11
{
    class Program
    {
        static void Worker()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("işlem----->"+i);
                Thread.Sleep(500);

            }
        }
        static void Main(string[] args)
        {
            Thread mythread = new Thread(Worker);
            mythread.Start();
            Thread.Sleep(1500);
            Console.WriteLine("benim işim bitti.....");
            Console.ReadKey();
        }
    }
}
