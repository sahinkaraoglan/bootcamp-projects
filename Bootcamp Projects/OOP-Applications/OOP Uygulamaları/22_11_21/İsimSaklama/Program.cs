using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsimSaklama
{
    public class A
    {
        public int a = 10;
    }
    public class B : A
    {
        public new int a = 20;
        int metot()
        {
            return base.a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B nesne = new B();
            Console.WriteLine(nesne.metot());
        }
    }
}
