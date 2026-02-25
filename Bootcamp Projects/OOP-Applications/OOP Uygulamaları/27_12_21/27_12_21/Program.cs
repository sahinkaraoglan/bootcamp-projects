using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_12_21
{
    class Program
    {
        public delegate int MyDelegate(int x);
        static int KareAl(int sayi)
        {
            return sayi * sayi;
        }
        static void Main(string[] args)
        {
            MyDelegate delege1 = new MyDelegate(KareAl);
            int y = delege1(4);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
