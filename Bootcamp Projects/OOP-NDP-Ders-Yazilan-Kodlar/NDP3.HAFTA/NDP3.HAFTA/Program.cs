using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP3.HAFTA
{
    class kututester
    {
        public double length;
        public double height;
        public double breadth;
        static void Main(string[] args)
        {
            kututester kutu1 = new kututester();   //yaratılan birinci nesne
            kututester kutu2 = new kututester();   //yaratılan ikinci nesne

            double valume = 0.0;

            kutu1.height = 5.0;
            kutu1.length = 6.0;
            kutu1.breadth = 7.0;

            kutu2.height = 10.0;
            kutu2.length = 12.0;
            kutu2.breadth = 13.0;
            valume = kutu1.height * kutu1.length * kutu1.breadth;
            Console.WriteLine("valume of kutu1: {0}",valume);

            valume = kutu2.height * kutu2.length * kutu2.breadth;
            Console.WriteLine("valume of kutu2: {0}", valume);
            Console.ReadKey();




        }
    }
}
