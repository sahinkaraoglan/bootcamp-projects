using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration
{
    class Program
    {
        enum Gunler {pazartesi=2,salı=4,çarşamba=60,persembe,cuma,cumartesi,pazar};

        static void Main(string[] args)
        {
            int x = (int)Gunler.persembe;
            Console.WriteLine(x);
            Console.WriteLine("x degiskeni: "+x);
            Console.WriteLine(Gunler.persembe);
            Console.ReadKey();
        }
    }
}
