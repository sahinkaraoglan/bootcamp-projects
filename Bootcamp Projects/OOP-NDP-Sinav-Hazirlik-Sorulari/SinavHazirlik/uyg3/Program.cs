using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg3
{
    class Program
    {
        public delegate int MyDelegate(int x);   //1.aşama declaration(tanımlama)
        static int kareal(int sayi)
        {
            return sayi * sayi;
        }
        static void Main(string[] args)
        {
            MyDelegate delege1 = new MyDelegate(kareal);
            int y = delege1(4);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
