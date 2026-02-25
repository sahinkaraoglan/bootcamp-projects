using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama2
{
    class Matematikİslem
    {
        public int Toplan(int a,int b)
        {
            return a + b;
        }
        public static int Toplam(int a,int b)
        {
            return a + b;
        }
    }
    static class Matematikİslem2
    {
        public static int Toplam(int a,int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matematikİslem nesne1 = new Matematikİslem();
            Console.WriteLine("Toplam: " + nesne1.Toplan(5, 9));
            Console.WriteLine("static toplam değeri: " + Matematikİslem2.Toplam(9, 8));




            Console.ReadKey();
        }
    }
}
