using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace uyg_3
{
    class Program
    {
        static void Worker()
        {
            try
            {
                while (true)
                    try
                    {
                        Thread.Sleep(500);

                    }
                    catch (ThreadAbortException)
                    {
                        Console.WriteLine("thread zorla kapatılmıştır...(2)");
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Beklenmeyen bir hata oluştuğu " + e.Message);
                    }
            }
            catch (ThreadAbortException)
            {

                Console.WriteLine("thread zorla kapatılıyor......(1)");
            }

        }
        static void Main(string[] args)
        {
            Thread myThread = new Thread(Worker);
            myThread.Start();
            Thread.Sleep(2000);
            Console.WriteLine(myThread.ThreadState+"join işlemi");
            myThread.Abort();
            Console.WriteLine(myThread.ThreadState+"ilk abort");
            myThread.Join();
            Console.WriteLine(myThread+"mythread join işlemi sonrası");
            Console.ReadKey();

        }
    }
}
