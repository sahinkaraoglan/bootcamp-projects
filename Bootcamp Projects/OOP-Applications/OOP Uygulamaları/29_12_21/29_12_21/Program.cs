using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_12_21
{
    class Program
    {
        public delegate int MyDelegate(int x);   //1. aşama tanımlama aşaması.
        public static int KareAl(int a)
        {
            return a * a;
        }
        static void Main(string[] args)
        {
            MyDelegate delege1 = new MyDelegate(KareAl);   //2. aşama örnekleme.
            int sonuc = delege1(5);
            Console.WriteLine(sonuc);
        }
    }
}
